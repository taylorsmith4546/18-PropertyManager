﻿angular.module('app').controller('PropertyGridController', function ($scope, PropertyResource) {
    
    function activate() {
        $scope.properties = PropertyResource.query();
    }
    $scope.deleteProperty = function (property) {
        property.$remove(function () {
            alert('delete successful');
            activate();
        });
    };

    activate();

});