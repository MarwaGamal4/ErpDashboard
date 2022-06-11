var ko = require('knockout');
require('devexpress-reporting/dx-reportdesigner');
import "./style.css";

window.JsFunctions = {

    _viewerOptions: {
        hostUrl : window.location.host,
        reportUrl: ko.observable("MyReport"),
        requestOptions: {
            invokeAction: "/DXXRDV"
        }
    },
    _designerOptions: {
        hostUrl : window.location.host,
        reportUrl: ko.observable("MyReport"),
        requestOptions: {
            getDesignerModelAction: "api/Reporting/getReportDesignerModel"
        }
    },
    InitWebDocumentViewer: function (rname, node) {
        this._viewerOptions.reportUrl = rname;
        ko.applyBindings(this._viewerOptions, document.getElementById(node));
    },
    InitReportDesigner: function (rname, node) {
        this._designerOptions.reportUrl = rname;
        ko.applyBindings(this._designerOptions, document.getElementById(node));
    },
    Dispose: function (elementId) {
        var element = document.getElementById(elementId);
        element && ko.cleanNode(element);
    }
}