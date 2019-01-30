var app = angular.module("superMasks", ['ngSanitize', 'ngCookies', 'ui.bootstrap', 'countdownTimer',
    'angularUtils.directives.dirPagination', 'ngCart', 'paypal-button']);

app.controller("todaysdateController", function ($scope, $location) {
    $scope.today = new Date();
});

app.controller("navController", function ($scope) {
   
});

app.controller('payController', function ($scope, ngCart) {
    $scope.opts = {
        env: 'sandbox',
        client: {
            sandbox: 'AWi18rxt26-hrueMoPZ0tpGEOJnNT4QkiMQst9pYgaQNAfS1FLFxkxQuiaqRBj1vV5PmgHX_jA_c1ncL',
            production: '<insert production client id>'
        },
        payment: function () {
            var env = this.props.env;
            var client = this.props.client;
            return paypal.rest.payment.create(env, client, {
                transactions: [
                    {
                        amount: { total: '1.00', currency: 'USD' }
                    }
                ]
            });
        },
        commit: true, 
        onAuthorize: function (data, actions) {            
            return actions.payment.execute().then(function () {               
            });
        }
    };
});

app.controller("datController", function ($interval) {
    var timeController = this;
    timeController.clock = { time: "", interval: 1000 };
    $interval(function () {
        timeController.clock.time = Date.now();
    }, timeController.clock.interval);
});

app.controller("mainController", function ($scope, $rootScope, ngCart, $http, $window) {
    $scope.customer = (localStorage.getItem("customer") != null) ? JSON.parse(localStorage.getItem("customer")) : null;
    $rootScope.custname = ($scope.customer != null) ? $scope.customer.cfname : "Login";   

    $scope.logout = function () {
        localStorage.removeItem("customer");
        $scope.customer = null;
        $rootScope.custname = "Login";
        $('#cart-login').modal('hide');
        $window.location = "/";
    }

    $scope.showlogin = function(){
        $('#cart-login').modal('show');
        if ($scope.customer) {
            $http.get("/api/GetOrders/" + $scope.customer.custid).then((res) => {
                $rootScope.orders = res.data;                
            });
        }
    }
});

app.controller("loginController", function ($scope, $rootScope, $http, $window) {
    $scope.user = { username: "", password: "" };
    $scope.customer = (localStorage.getItem("customer") != null) ? JSON.parse(localStorage.getItem("customer")) : null;
    $rootScope.custname = ($scope.customer != null) ? $scope.customer.cfname : "Login";  
    $scope.Titles = ['Mr', 'Ms', 'Miss', 'Mrs', 'Dr'];
    $scope.title = "Mr";
    $rootScope.orders = null;
    $scope.login = function () { 
        $http({
            method: "POST",
            url: "/api/LoginCustomer",
            data: $scope.user
        }).then((res) => {                       
            $scope.customer = res.data;
            if ($scope.customer) {
                localStorage.setItem("customer", JSON.stringify($scope.customer));
                $rootScope.custname = $scope.customer.cfname;
                $scope.getOrders();
            } else {

            }
        });
    }

    $scope.getAccount = function () {
        $scope.customer = (localStorage.getItem("customer") != null) ? JSON.parse(localStorage.getItem("customer")) : null;        
    }
    
    $scope.getOrders = function () {
        $scope.customer = (localStorage.getItem("customer") != null) ? JSON.parse(localStorage.getItem("customer")) : null;
        if ($scope.customer) {
            $http.get("/api/GetOrders/" + $scope.customer.custid).then((res) => {
                $rootScope.orders = res.data;
                console.log($rootScope.orders);
            });
        }              
    }

    $scope.logout = function () {
        localStorage.removeItem("customer");
        $scope.customer = null;
        $rootScope.custname = "Login";
        $('#cart-login').modal('hide');
        $window.location = "/";
    }
});

app.controller("appColors", function ($scope, $http, $cookies, $window) {
    $scope.Colors = [];
    $scope.colorid = $cookies.get("colorid");
    $http.get("/api/GetColors").then(function (response) {
        $scope.Colors = response.data;
    });

    $scope.setcolor = function (colorid) {       
        $scope.colorid = colorid;
        $window.location.reload();
    }
});

app.controller("appCategories", function ($scope, $http) {
    $scope.oneAtATime = true;
    $scope.Categories = [];
    $http.get("/api/GetMainCategories").then(function (response) {
        $scope.Categories = response.data;        
    });

    $scope.status = {
        isCustomHeaderOpen: false,
        isFirstOpen: true,
        isFirstDisabled: false
    };
});

app.controller("appProduct", function ($scope, $http, ngCart) {
    ngCart.setPostageid(3);
    ngCart.setPostage(3.75);
    $scope.url = null;
    $scope.product = null;
    $scope.extraimages = null;
    $scope.relatedprods = null;
    $scope.init = function (value) {
        console.log(value);
        $scope.url = value;
        $http.get("/api/GetProduct/" + value).then(function (response) {
            $scope.product = response.data;            
            $http.get("/api/GetExtraImage/" + $scope.product.prodid).then(function (response) {
                $scope.extraimages = response.data;
                console.log($scope.extraimages);
            });
            $http.get("/api/GetRelatedProducts/" + $scope.product.prodid).then(function (response) {
                $scope.relatedprods = response.data;
                console.log($scope.relatedprods);
            });            
        });
    }

});

app.controller("appProducts", function ($scope, $http, ngCart) {
    ngCart.setPostageid(3);
    ngCart.setPostage(3.75); 
    $scope.url = null;
    $scope.products = null;
    $scope.pageSize = { name: '12', value: 12 };
    $scope.sortColumn = { name: 'Name Asc', value: "+name" };

    $scope.init = function (value) {
        $scope.url = value;
        $http.get("/api/GetProducts/" + value).then(function (response) {
            $scope.products = response.data;            
        });
    }

    $scope.pSizes = [{ 'name': '12', 'value': 12 }, { 'name': '22', 'value': 24 }, { 'name': '36', 'value': 36 }, { 'name': '48', 'value': 48 }, { 'name': '60', 'value': 60 }];
    $scope.pSort = [{ 'name': 'Name Asc', 'value': '+name' }, { 'name': 'Name Desc', 'value': '-name' }, { 'name': 'Price Asc', 'value': '+price' }];
    $scope.currentPage = 1;
    $scope.pageSize = $scope.pSizes[0];
    $scope.sortColumn = $scope.pSort[0];
});


app.directive('toggleInt', function () {
    function link($scope, $element, attr) {
        $element.on('click', function () {
            $scope.$apply(function () {
                $scope.toggleModel = +!$scope.toggleModel;
            });
        });

        $scope.$watch('toggleModel', function (value) {
            $element.prop('checked', !!value);
        });
    }

    return {
        restrict: 'A',
        scope: {
            toggleModel: '='
        },
        link: link
    };
});