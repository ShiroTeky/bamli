function alertController($scope, $http)
{
    $scope.loading = true;
    $scope.addMode = false;

    //Used to display the data 
    $http.get('/api/Alert/').success(function (data) {
        $scope.Alertes = data;
        $scope.loading = false;
    })
    .error(function () {
        $scope.error = "An Error has occured while loading posts!";
        $scope.loading = false;
    });


}