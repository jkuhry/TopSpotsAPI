 angular
      .module('app')
      .factory('mainfactory', mainfactory);

      mainfactory.$inject = ['$http', '$q']; //inject of $q.

    /* @ngInject */
    function mainfactory($http,$q) {
        var service = {
            getTopSpots: getTopSpots
        };
        return service;

        ////////////////

        function getTopSpots() {
          var defer = $q.defer();
        	  $http({
               method: 'GET',
               url: 'http://localhost:49993/api/topspots'
               }).then(function(response) {

               	     defer.resolve(response);
              },

              function(error){

                 defer.reject(error);  //error handling for reject and defer promise.

        });
               return defer.promise;
    }
};