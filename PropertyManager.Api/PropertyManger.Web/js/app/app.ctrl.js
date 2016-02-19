angular.module('app').controller('AppController', function ($scope, AuthenticationService) {
    $scope.user = AuthenticationService.state;

    $scope.logout = function () {
        authService.logOut();
    };
});