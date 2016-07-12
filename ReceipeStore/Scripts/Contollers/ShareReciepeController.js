
var ShareController = function($scope, $http, $rootScope, ShareService) {
    $scope.Reciepe = {};
    $scope.returnStatus = "";
    $scope.IsRecTypeHidden = true;
    $scope.Newtype = "";
    $scope.displaymessage = true;

    $scope.Share = function() {
        var file = document.getElementById("imageid").files[0];
        if (file != undefined) {
            $scope.Reciepe.ImageUrl = file.name;
        }
        ShareService.ShareReciepe($http, $scope.Reciepe, $rootScope);
    }

    $scope.AddRecType = function() {
        $scope.isHidden = true;
        $scope.IsRecTypeHidden = false;
    }

    $scope.add = function() {
        var file = document.getElementById("imageid").files[0];
        console.log(file + " this is file");
        
        
    }

    $scope.addnewtype = function() {
        ShareService.ShareReciepeType($http, $scope.Newtype, $rootScope);

    }

    $scope.$on('ShareReciepeTypeStatus', function() {

        $scope.Status = ShareService.Status1;
        console.log("this is on scope:sharerecipetypestatus" + $scope.Status);
        $scope.displaymessage = false;
        $scope.returnStatus = " New ReciepeType is added!";
        $scope.isHidden = true;
        $scope.IsRecTypeHidden = true;
    });

    $scope.$on('ShareStatus', function() {
        $scope.Status = ShareService.Status;
        $scope.displaymessage = false;
        console.log(ShareService.Status);

        $scope.returnStatus = "Reciepe is Entered Successfully!";
        $scope.isHidden = true;
        $scope.IsRecTypeHidden = true;
    });

        
    


    ShareController.$inject = ['$scope'];
}