var manageitApp = angular.module('manageitApp');

manageitApp.controller('clientesController', function ($scope) {

    $scope.nuevoCliente = function () {
     
        $scope.showModal = true;
    }
});