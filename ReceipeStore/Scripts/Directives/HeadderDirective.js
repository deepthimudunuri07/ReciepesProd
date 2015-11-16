/// <reference path="../templates/Header.html" />
/// <reference path="../templates/Header.html" />
/// <reference path="../templates/Header.html" />
Runapp.directive('testheader', function () {
    return {
        restrict: 'AE', //This menas that it will be used as an attribute and NOT as an element. I don't like creating custom HTML elements
        replace: true,
        templateUrl: "../templates/Header.html",
        controller: 
             function($scope) {

                var myArray = ["Receipes", "Cuisines", "Healthy Cooking", "Drinks"];
                $scope.MenuItems = myArray;
                 console.log($scope.MenuItems);
             },
            controllerAs: "MenuCtrl"
    
}
});