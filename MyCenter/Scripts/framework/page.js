define(['knockout', 'app'], function (ko, app) {
    var page = {};
    page.name = ko.observable();
    page.data = ko.observable();

    page.changePage = function (pageName) {
        require([pageName + '-js'], function (pageData) {
            page.name(pageName + '-html');
            page.data(pageData);
        });
    }

    page.app = ko.observable(app);

    return page;
})