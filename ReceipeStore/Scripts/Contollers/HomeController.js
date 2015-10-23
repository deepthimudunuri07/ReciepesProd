var HomeControl = function ($scope, $http) {

    //$scope.ReciepeList = 'test';
    $scope.ReciepeCategorySelected = '';
    $http.get("http://localhost/ReceipeStoreServices/api/AvaliableList").success(function(result1) {
        $scope.ReciepeCategory = result1;
    }).error(function(result1) { alert("There was an error while getting the data" +result1);});


    $scope.DisplaySubList = function(ReciepeCategorySelected) {
        console.log(ReciepeCategorySelected.ID);
        $(".dropdown-submenu").hide();
        $("ul." + ReciepeCategorySelected.Name).show();
        $scope.StyleAttr = "margin-left: 50*" + ReciepeCategorySelected.ID;
        $http.get("http://localhost/ReceipeStoreServices/api/values?selected=" + ReciepeCategorySelected.ID).success(function(result) {
            $scope.ReciepeList = result;

        }).error(function(result) {
            alert("There was an error while getting the data" + result);
        });
    }



    $scope.DisplayReciepe = function(selectedID) {
        
        $http.get("http://localhost/ReceipeStoreServices/api/Reciepe?ReciepeiD=" + selectedID.ReciepeID).success(function (result3) {
            console.log(selectedID.ReciepeID);
            $scope.Reciepe = result3;
           

        }).error(function (result3) {
            alert("There was an error while getting the data"+ result3);
        });
    }




    //$(".dropdown-menu > li > a.trigger").on("click", function (e) {
    //        var current = $(this).next();
    //        console.log("this is current:" + current);
    //        var grandparent = $(this).parent().parent();
    //        console.log("this is the grandparent" + grandparent);
    //        if ($(this).hasClass('left-caret') || $(this).hasClass('right-caret'))
    //            $(this).toggleClass('right-caret left-caret');
    //        grandparent.find('.left-caret').not(this).toggleClass('right-caret left-caret');
    //        grandparent.find(".sub-menu:visible").not(current).hide();
    //        current.toggle();
    //        e.stopPropagation();
    //    });
    //    $(".dropdown-menu > li > a:not(.trigger)").on("click", function () {
    //        var root = $(this).closest('.dropdown');
    //        root.find('.left-caret').toggleClass('right-caret left-caret');
    //        root.find('.sub-menu:visible').hide();
    //    });

    }

HomeControl.$inject = ['$scope'];
