var paths = {
    'jquery': 'lib/jquery',
    'director': 'lib/director',
    'knockout-amd-helpers': 'lib/knockout-amd-helpers',
    'knockout': 'lib/knockout',
    'text': 'lib/text',

    'page': 'framework/page',
    'router': 'framework/myrouter',
    'routes': 'framework/routes',

    'app': 'app/app',
    'error404-js': 'app/share/error404',
    'error404-html': '../templates/app/share/error404.html',
    'login-js': 'app/account/login',
    'login-html': '../templates/app/account/login.html',
    'signup-js': 'app/account/signup',
    'signup-html': '../templates/app/account/signup.html',
}

var baseUrl = '../';

require.config({
    baeuUrl: baseUrl,
    paths: paths,
    shim: {
        '': {
            exports:''
        }
    }
});

require(['knockout', 'page', 'text', 'knockout-amd-helpers', 'router'], function (ko,page) {
    ko.applyBindings(page);

    location.href = '#/login';
})