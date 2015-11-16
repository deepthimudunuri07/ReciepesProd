//Runapp.factory("MenuService", function($rootScope,$http) {
//    var service = {};
//    service.ReciepeCategorySelected = "";
//    service.ReciepeCategory = "";


//    service.ReciepeCategorySelection = function () {

//        console.log("Enterted Factory");
//        $http.get("http://localhost/ReceipeStoreServices/api/AvaliableList").success(function(result1) {
//            this.ReciepeCategory = result1;
//        }).error(function(result1) { alert("There was an error while getting the data" + result1); });
//        $rootScope.$broadcast(ReciepeCategory);
//    }
//    return service;
//});


    