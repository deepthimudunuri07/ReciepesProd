/// <reference path="C:\Users\mudunuride01\Documents\GitHub\ReceipesProd\ReciepesProd\ReceipeStore\Views/Home/_Home.cshtml" />
/// <reference path="C:\Users\mudunuride01\Documents\GitHub\ReceipesProd\ReciepesProd\ReceipeStore\Views/Home/_Home.cshtml" />

// create the module and name it scotchApp
var scotchApp = angular.module('RoutingModule', ['ngRoute']);

// configure our routes
scotchApp.config(function($routeProvider) {
    $routeProvider

        // route for the home page
        .when('/', {
            templateUrl : '../Views/Home/_Home.cshtml',
            controller  : 'mainController'
        })

        // route for the about page
        .when('/about', {
            templateUrl : 'pages/about.html',
            controller  : 'aboutController'
        })

        // route for the contact page
        .when('/contact', {
            templateUrl : 'pages/contact.html',
            controller  : 'contactController'
        });
});

// create the controller and inject Angular's $scope
scotchApp.controller('mainController', function($scope) {
    // create a message to display in our view
    $scope.message = 'Everyone come and see how good I look!';
});

scotchApp.controller('aboutController', function($scope) {
    $scope.message = 'Look! I am an about page.';
});

scotchApp.controller('contactController', function($scope) {
    $scope.message = 'Contact us! JK. This is just a demo.';
});