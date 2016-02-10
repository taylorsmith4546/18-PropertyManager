﻿angular.module('app', ['ngResource', 'ui.router']);

angular.module('app').value('apiUrl', 'http://localhost:51228/api');

angular.module('app').config(function ($stateProvider, $urlRouterProvider) {

    $stateProvider.state('dashboard', { url: '/dashboard', templateUrl: '/templates/dashboard/dashboard.html', controller: 'DashboardController' })
                  .state('property', { url: '/property', abstract: true, template: '<ui-view/>' })
                      .state('property.grid', { url: '/grid', templateUrl: '/templates/property/property.grid.html', controller: 'PropertyGridController' })
                      .state('property.detail', { url: '/detail/:id', templateUrl: '/templates/property/property.detail.html', controller: 'PropertyDetailController' })
                  .state('tenant', { url: '/tenant', abstact: true, template: '<ui-view/>' })
                      .state('tenant.grid', { url: '/grid', templateUrl: '/templates/tenant/tenant.grid.html', controller: 'TenantGridController' })
                      .state('tenant.detail', { url: '/detail/:id', templateUrl: '/templates/tenant/tenant.detail.html', controller: 'TenantDetailController' })
                  .state('lease', { url: '/lease', abstract: true, template: '<ui-view/>' })
                      .state('lease.grid', { url: '/grid', templateUrl: '/templates/lease/lease.grid.html', controller: 'LeaseGridController' })
                      .state('lease.detail', { url: '/detail/:id', templateUrl: '/templates/lease/lease.detail.html', controller: 'LeaseDetailController' })
                  .state('workOrder', { url: '/workOrder', abstract: true, template: '<ui-view/>' })
                      .state('workOrder.grid', { url: '/grid', templateUrl: '/templates/workOrder/workOrder.grid.html', controller: 'WorkOrderGridController' })
                      .state('workOrder.detail', { url: '/detail/:id', templateUrl: '/templates/workOrder/workOrder.detail.html', controller: 'WorkOrderDetailController' })
    ;
});