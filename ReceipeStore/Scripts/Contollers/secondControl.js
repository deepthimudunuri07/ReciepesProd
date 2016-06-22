var DisplayList = function ($scope, $http, $rootScope, MenuService) {
   
    $scope.$on('Reciepe', function () {
        console.log("$scope.$on in the DsiplayList");
        $scope.Reciepe = MenuService.Reciepe;
    });
    
   
   
}
DisplayList.$inject = ['$scope'];



