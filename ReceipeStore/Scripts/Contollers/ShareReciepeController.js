
var ShareController = function ($scope, $http, $rootScope, ShareService) {
    $scope.Reciepe = {};
    $scope.returnStatus = "";
    $scope.isHidden = "";

    $scope.Share = function () {
        console.log("This is in the share reciepe controller :" +$scope.Reciepe);
        ShareService.ShareReciepe($http, $scope.Reciepe, $rootScope);
    }


    $scope.$on('ShareStatus', function () {
        $scope.Status = ShareService.Status;
        console.log(ShareService.Status);
        
        $scope.returnStatus = "Reciepe is Entered Successfully!";
        $scope.isHidden = true;


    });
}


 ShareController.$inject = ['$scope'];