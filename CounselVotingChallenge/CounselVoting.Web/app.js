const counselApp = angular.module('counselApp', []);

counselApp.controller('AppController', ['$scope', ($scope) => {
    $scope.tabSelected = 'sample';

    $scope.selectTabHandler = (tabSelected) => {
        $scope.tabSelected = tabSelected;
    }
}]);

counselApp.controller('SampleController', ['$scope', '$http', ($scope, $http) => {
    $scope.load = () => {
    };
}]);
