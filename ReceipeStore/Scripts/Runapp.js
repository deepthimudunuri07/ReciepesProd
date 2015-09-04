var Runapp = angular.module('Runapp',[]);

Runapp.controller('landingPageController', landingPage);
Runapp.controller('HomeController', HomeControl);
Runapp.controller('secondControl', ["$scope",  "$http", secondTest]);