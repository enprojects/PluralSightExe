using Microsoft.Owin.Hosting;
using Owin;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace KatanaIntro
{
    using System.IO;
    using AppFunc = Func<IDictionary<string, object>, Task>;
    class Program
    {
        static void Main(string[] args)
        {
            string uri = "http://localhost:8080";

       

            using (WebApp.Start<Startup>(uri))
            {
                Console.WriteLine("HasStarted ");
                Console.ReadKey();
                
            }
        }

        public class Startup
        {
            public void Configuration(IAppBuilder app)
            {


                app.Middleware();

                app.Use(async (ctx, next) =>
                {
                    Console.WriteLine("req from middle1");
                    await ctx.Response.WriteAsync("Hello from my second component \n");

                    //await next();
                    Console.WriteLine("Response from middle1");
                });
              
                //app.Run(ctx =>
                //{
                //    return ctx.Response.WriteAsync("Hello wold");
                //});

                //app.Run(async ctx => {
                //    await ctx.Response.WriteAsync("Hello from 2nd delegate.");
                //});
            }
        }

       

    }

    public static class Wrapper

    {
        public static void Middleware(this IAppBuilder app)
        {
            app.Use<MyComponent>();
        }
    }

    internal class MyComponent
    {
        AppFunc _next;
        public MyComponent(AppFunc next)
        {
            _next = next;
        }
        public async  Task Invoke(IDictionary<string, object> ctx)
        {
            Console.WriteLine(  "Request to My component");
            var response = ctx["owin.ResponseBody"] as Stream;
            using (var res = new StreamWriter(response))
            {
                await  res.WriteAsync("Hello from my component");
                await _next(ctx);

            }
            Console.WriteLine("Response from My component");
        }
    }
}
