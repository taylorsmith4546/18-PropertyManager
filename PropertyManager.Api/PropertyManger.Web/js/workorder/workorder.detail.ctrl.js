angular.module('app').controller('WorkOrderDetailController', function ($scope, $stateParams, WorkOrderResource) {
    $scope.tenant = workOrderResource.get({ workOrderId: $stateParams.id });

    $scope.saveWorkOrder = function () {
        $scope.workOrder.$update(function () {
            alert('save successful');
        });
    };
});