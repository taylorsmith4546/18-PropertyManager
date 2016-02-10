angular.module('app').controller('TenantDetailController', function ($scope, $stateParams, TenantResource) {
    $scope.tenant = tenantResource.get({ tenantId: $stateParams.id });

    $scope.saveTenant = function () {
        $scope.tenant.$update(function () {
            alert('save successful');
        });
    };
});