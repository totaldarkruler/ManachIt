// create the module
var manageitApp = angular.module('manageitApp', ['ngRoute']);

//routing
manageitApp.config(function ($routeProvider) {
	$routeProvider
		// route for the home page
		.when('/', {
			templateUrl: 'components/dashboard/dashboardView.html',
			controller: 'dashboardController'
		})

});

// create the controller and inject Angular's $scope
manageitApp.controller('mainController', function ($scope) {



});