﻿angular.module('app').controller('WorkOrderGridController', function ($scope, WorkOrderResource) {

    function activate() {
        $scope.workOrders = WorkOrderResource.query();
    }
    $scope.deleteWorkOrder = function (workOrder) {
        workOrder.$remove(function () {
            alert('delete successful');
            activate();
        });
    };

    activate();

});