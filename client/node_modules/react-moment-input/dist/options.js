"use strict";

Object.defineProperty(exports, "__esModule", {
    value: true
});

var _react = require("react");

var _react2 = _interopRequireDefault(_react);

function _interopRequireDefault(obj) { return obj && obj.__esModule ? obj : { default: obj }; }

exports.default = function (_ref) {
    var activeTab = _ref.activeTab,
        onActiveTab = _ref.onActiveTab,
        translations = _ref.translations;
    return _react2.default.createElement(
        "div",
        { className: "options" },
        _react2.default.createElement(
            "button",
            {
                tabIndex: -1,
                className: "ion-ios-calendar im-btn" + (activeTab === 0 || activeTab === 2 ? " is-active" : ""),
                onClick: function onClick() {
                    onActiveTab(0);
                } },
            translations.DATE || "Date"
        ),
        _react2.default.createElement(
            "button",
            {
                tabIndex: -1,
                className: "ion-ios-clock im-btn" + (activeTab === 1 ? " is-active" : ""),
                onClick: function onClick() {
                    onActiveTab(1);
                } },
            translations.TIME || "Time"
        )
    );
};