var Runapp = angular.module('Runapp', []);

Runapp.controller('HomeController', ["$scope", "$http", '$rootScope', 'MenuService', HomeController]);

Runapp.controller('DisplayController', ["$scope", "$http", '$rootScope','MenuService', DisplayList]);

Runapp.controller('ShareReciepeController', ["$scope", "$http", '$rootScope', 'ShareService', ShareController]);

Runapp.factory("MenuService", function () {
    var service = {};
    service.ReciepeCategorySelected = "";
    service.ReciepeCategory = "";
    service.ReciepeList = "";
    service.Reciepe = "";
    service.StyleAttr = "";
   

    service.ReciepeCategorySelection = function ($http, $rootScope) {

        console.log("Function called in the service");
        $http.get("http://localhost/ReceipeStoreServices/api/AvaliableList").success(function (result1) {
            
            service.ReciepeCategory = result1;
           $rootScope.$broadcast('ReciepeCategory');
        }).error(function (result1) { alert("There was an error while getting the data" + result1); });

        return service.ReciepeCategory;
    }


    service.DisplaySubList = function ($http, ReciepeCategorySelected, $rootScope) {

        $(".dropdown-submenu").hide();
        $("ul." + ReciepeCategorySelected.Name).show();
        service.StyleAttr = "margin-left: 50*" + ReciepeCategorySelected.ID;
        console.log( ReciepeCategorySelected);
        $http.get("http://localhost/ReceipeStoreServices/api/values?selected=" + ReciepeCategorySelected.ReciepeID).success(function (result) {
            service.ReciepeList = result;
        $rootScope.$broadcast('ReciepeList');

        }).error(function (result) {
            alert("There was an error while getting the data" + result);
        });
    }


    service.DisplayReciepe = function ($http, selectedID, $rootScope) {

        $http.get("http://localhost/ReceipeStoreServices/api/Reciepe?ReciepeiD=" + selectedID.ReciepeID).success(function (result3) {
            console.log("this is the selected item",selectedID.ReciepeID );
            service.Reciepe = result3;
            $rootScope.$broadcast('Reciepe');

        }).error(function (result3) {
            alert("There was an error while getting the data" + result3);
        });
    }

    
    return service;
});





