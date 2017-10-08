var app = angular.module('app', []);

app.controller('mainController', ['$scope', 'webServ', function (scope, webServ) {

    var vm = scope;
    vm.test = 'hello world';

    webServ.getStudents().then(function (data) {
       alert()
    });


}]);

app.factory('webServ', ['$http', function ($http) {
    

    return {
        
        getStudents: function () {
           
            return $http({
                url: 'student/GetStudents',
                method: 'GET'
            });
        }
    }

}]);