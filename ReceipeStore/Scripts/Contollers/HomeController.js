var HomeController = function ($scope, $http,$rootScope,MenuService) {

    
    MenuService.ReciepeCategorySelection($http, $rootScope);
    $scope.$on('ReciepeCategory', function () {
        $scope.ReciepeCategory = MenuService.ReciepeCategory;
        console.log("This is in the $scope.on" , $scope.ReciepeCategory);
    });



    
        $scope.DisplaySubList = function (ReciepeCategorySelected) {
            console.log("called DisplaySubList function in the hoem contoller ");
            MenuService.DisplaySubList($http, ReciepeCategorySelected, $rootScope);
        }

        $scope.$on('ReciepeList', function () {
              $scope.StyleAttr = MenuService.StyleAttr;
              $scope.ReciepeList = MenuService.ReciepeList;
       
        });

    


        $scope.DisplayReciepe = function (selectedID) {
               console.log("function called in the secondControl");
               MenuService.DisplayReciepe($http, selectedID, $rootScope);
           }


    }

HomeController.$inject = ['$scope'];
