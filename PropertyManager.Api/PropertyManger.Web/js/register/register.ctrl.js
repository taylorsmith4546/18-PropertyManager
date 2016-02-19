﻿angular.module('app').controller('RegisterController', function ($scope, $timeout, AuthenticationService) {

    $scope.registration = {};

    $scope.register = function () {
        AuthenticationService.register($scope.registration).then(
            function (response) {
                alert("Registration complete, you will be redirected to the login page in 2 seconds.");
                $timeout(function () {
                    location.replace('/#/login');
                }, 2000);

            },
            function (err) {
                alert("Failed to register");

            }
        )
    };

});