Runapp.factory("MenuList", function() {

    $scope.ReciepeCategorySelected = '';
    $http.get("http://localhost/ReceipeStoreServices/api/AvaliableList").success(function(result1) {
        $scope.ReciepeCategory = result1;
    }).error(function(result1) { alert("There was an error while getting the data" + result1); });

});