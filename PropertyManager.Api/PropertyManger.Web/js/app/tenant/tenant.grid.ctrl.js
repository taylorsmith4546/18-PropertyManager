angular.module('app').controller('TenantGridController', function ($scope, TenantResource) {

    function activate() {
        $scope.tenants = TenantResource.query();
    }
    $scope.deleteTenant = function (tenant) {
        tenant.$remove(function () {
            alert('delete successful');
            activate();
        });
    };
    activate();

});