var secondTest = function ($scope, $http) {
    
    //$scope.ReciepeList = 'test';
    $http.get("http://localhost/ReceipeStoreServices/api/values").success(function(result){
        $scope.ReciepeList = result;
    });
}
secondTest.$inject = ['$scope'];



