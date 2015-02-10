var myApp = angular.module('myApp', []);

myApp.controller(
    'newsManager',

['$scope', '$http', function ($scope, $http) {
    $scope.sportNewsList = new Array();
    $scope.entertainmentNewsList = new Array();
    $scope.techNewsList = new Array();

    function loadRemoteData() {
        $scope.getSportNews();
        $scope.getEntertainmentNews();
        $scope.getTechNews();
    };

    $scope.getSportNews = function () {
        $http.get('/Home/GetSportNews')
            .success(function (data) {
                $scope.sportNewsList = jQuery.parseJSON(data.results);
            });
    };

    $scope.getEntertainmentNews = function () {
        $http.get('/Home/GetEntertainmentNews')
            .success(function (data) {
                $scope.entertainmentNewsList = jQuery.parseJSON(data.results);
            });
    };

    $scope.getTechNews = function () {
        $http.get('/Home/GetTechNews')
            .success(function (data) {
                $scope.techNewsList = jQuery.parseJSON(data.results);
            });
    };

    loadRemoteData();
}]);

$(function () {
    $("#tabs").tabs();
});
