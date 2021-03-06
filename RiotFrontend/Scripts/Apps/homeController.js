﻿angular.module("IgnorantItems", [])
    .controller("homeController", function($scope, $http) {
        $scope.allMatches = [];

        $scope.title = "Recent Matches";

        $http.get("/api/matches").success(function(data) {
            $scope.allMatches = data;
         });

        $scope.getMatchResultText = function(match) {
            return match.Won ? "Win" : "Loss";
        };

        $scope.getMatchResultColor = function(match) {
            return match.Won ? {"color": "#00b300"} : {"color": "#cc0000"};
        };
        
        $http.get("/api/static/summonerSpells").success(function (data) {
            $scope.summonerSpells = {};

            for (var el in data) {
                $scope.summonerSpells[data[el].Id] = data[el];
            }
        });
    });
