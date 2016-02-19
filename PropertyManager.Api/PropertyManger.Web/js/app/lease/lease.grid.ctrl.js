angular.module('app').controller('LeaseGridController', function ($scope, LeaseResource) {

    function activate() {
        $scope.leases = LeaseResource.query();
    }
    $scope.deleteLease = function (lease) {
        lease.$remove(function () {
            alert('delete successful');
            activate();
        });
    };
    activate();

});