// create the module
var manageitApp = angular.module('manageitApp', ['ngRoute', 'ui.bootstrap']);

//routing
manageitApp.config(function ($routeProvider) {
	$routeProvider
		// route for the home page
		.when('/', {
			templateUrl: 'app/components/dashboard/dashboardView.html',
			controller: 'dashboardController'

		})
        .when('/main', {
            templateUrl: 'app/components/dashboard/dashboardView.html',
            controller: 'dashboardController'
		})
        .when('/clientes', {
		    templateUrl: 'app/components/clientes/clientesView.html',
		    controller: 'clientesController'
		})

});

// create the controller and inject Angular's $scope
manageitApp.controller('mainController', function ($scope) {



});