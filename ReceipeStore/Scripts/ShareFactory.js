Runapp.factory("ShareService", function() {
    var service = {};
    service.Status = "";
    service.Status1 = "";

    service.ShareReciepe = function($http, $Reciepe, $rootScope) {
        console.log("Entered Shareservice sharereciepe method: " + $Reciepe.ReceipeTypeID.ReciepeID);
        $Reciepe.ReceipeTypeID = $Reciepe.ReceipeTypeID.ReciepeID;
        //console.log("This is the image selected " +$Reciepe.ImageUrl);
        console.log("This is the selected cat " + $Reciepe.ReceipeTypeID);
        $http({
                method: 'POST',
                url: 'http://localhost/ReceipeStoreServices/api/Reciepe/',
                data: $Reciepe, //forms user object
                headers: { 'Content-Type': 'application/json' }
            }).success(function(result4) {

                service.Status = result4;
                console.log("On Success " + result4);
                $rootScope.$broadcast('ShareStatus');
            }).
            error(function(result4) {
                alert("There was an error while getting the data" + result4);
            });
    }

    service.ShareReciepeType = function ($http, $NewType, $rootScope) {
       $http.post('http://localhost/ReceipeStoreServices/api/AvaliableList/', '"' + $NewType + '"')
                .success(function(result) {
                    service.Status1 = result;
                    console.log("This is the result"+ result);
                    $rootScope.$broadcast('ShareReciepeTypeStatus');
                }).
                error(function(result) {
                    alert("There was an error while getting the data" + result);
                });


        }


    return service;
});