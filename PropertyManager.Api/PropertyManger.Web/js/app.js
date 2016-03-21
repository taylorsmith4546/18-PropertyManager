﻿angular.module('app', ['ngResource', 'ui.router', 'LocalStorageModule']);

angular.module('app').value('apiUrl', 'https://taylorpropertiesapi.azurewebsites.net/api/');

angular.module('app').config(function ($stateProvider, $urlRouterProvider, $httpProvider) {
    $httpProvider.interceptors.push('AuthenticationInterceptor');

    $urlRouterProvider.otherwise('home');
     
    $stateProvider
                       .state('home', { url: '/home', templateUrl: '/templates/home/home.html', controller: 'HomeController' })
                        .state('register', { url: '/register', templateUrl: 'templates/register/register.html', controller: 'RegisterController' })
                        .state('login', {url: '/login', templateUrl: 'templates/login/login.html', controller: 'LoginController' })
                       .state('app', {url: '/app', templateUrl: '/templates/app/app.html', controller: 'AppController'})
                      .state('app.property', { url: '/property', abstract: true, template: '<ui-view/>' })
                          .state('app.property.grid', { url: '/grid', templateUrl: '/templates/app/property/property.grid.html', controller: 'PropertyGridController' })
                          .state('app.property.detail', { url: '/detail/:id', templateUrl: '/templates/app/property/property.detail.html', controller: 'PropertyDetailController' })
                      .state('app.tenant', { url: '/tenant', abstact: true, template: '<ui-view/>' })
                          .state('app.tenant.grid', { url: '/grid', templateUrl: '/templates/app/tenant/tenant.grid.html', controller: 'TenantGridController' })
                          .state('app.tenant.detail', { url: '/detail/:id', templateUrl: '/templates/app/tenant/tenant.detail.html', controller: 'TenantDetailController' })
                      .state('app.lease', { url: '/lease', abstract: true, template: '<ui-view/>' })
                          .state('app.lease.grid', { url: '/grid', templateUrl: '/templates/app/lease/lease.grid.html', controller: 'LeaseGridController' })
                          .state('app.lease.detail', { url: '/detail/:id', templateUrl: '/templates/app/lease/lease.detail.html', controller: 'LeaseDetailController' })
    ;
});

angular.module('app').run(function (AuthenticationService) {
    AuthenticationService.initialize();
});