"use strict";

Object.defineProperty(exports, "__esModule", {
    value: true
});

var _react = require("react");

var _react2 = _interopRequireDefault(_react);

function _interopRequireDefault(obj) { return obj && obj.__esModule ? obj : { default: obj }; }

function replaceMonths(value, translation) {
    var values = value.split(" ");
    var tValue = translation["MONTHS_" + values[0].toUpperCase()];
    return tValue ? tValue + (values[1] ? " " + values[1] : "") : value;
}

function replaceDays(value, translation) {
    return translation["DAYS_" + value.toUpperCase()] || value;
}

var MONTHS = ['January', 'February', 'March', 'April', 'May', 'June', 'July', 'August', 'September', 'October', 'November', 'December'];

exports.default = function (_ref) {
    var defaults = _ref.defaults,
        add = _ref.add,
        onActiveTab = _ref.onActiveTab,
        _onClick = _ref.onClick,
        isDisabled = _ref.isDisabled,
        translations = _ref.translations;
    return _react2.default.createElement(
        "div",
        { className: "r-calendar tab-m is-active" },
        _react2.default.createElement(
            "div",
            { className: "toolbar" },
            _react2.default.createElement(
                "button",
                { className: "prev-month", onClick: add(-1, 'month'), tabIndex: -1 },
                _react2.default.createElement("i", { className: "ion-md-arrow-dropleft" })
            ),
            _react2.default.createElement(
                "span",
                { className: "current-date react-textselect", style: { marginRight: "-5px" } },
                replaceMonths(defaults.selected.format("MMMM YYYY"), translations),
                defaults.monthSelect && _react2.default.createElement(
                    "select",
                    { className: "react-textselect-input", tabIndex: -1,
                        onChange: function onChange(_ref2) {
                            var target = _ref2.target;
                            _onClick(defaults.selected.clone().month(target.value));
                        },
                        value: Number(defaults.selected.format("MM")) - 1 },
                    MONTHS.map(function (x, index) {
                        return _react2.default.createElement(
                            "option",
                            { value: index,
                                disabled: isDisabled(defaults.min, defaults.max, defaults.selected.clone().month(x), defaults.date, x),
                                key: index },
                            replaceMonths(x, translations)
                        );
                    })
                )
            ),
            _react2.default.createElement(
                "button",
                { className: "next-month", onClick: add(1, 'month'), tabIndex: -1 },
                _react2.default.createElement("i", { className: "ion-md-arrow-dropright" })
            ),
            _react2.default.createElement(
                "button",
                { className: "next-month", style: { marginRight: "5px" }, onClick: function onClick(e) {
                        onActiveTab(2);e.stopPropagation();
                    }, tabIndex: -1 },
                _react2.default.createElement("i", { className: "fa fa-level-down", "aria-hidden": "true" })
            )
        ),
        _react2.default.createElement(
            "table",
            null,
            _react2.default.createElement(
                "thead",
                null,
                _react2.default.createElement(
                    "tr",
                    null,
                    defaults.months.map(function (x, i) {
                        return _react2.default.createElement(
                            "td",
                            { key: i },
                            replaceDays(x, translations)
                        );
                    })
                )
            ),
            _react2.default.createElement(
                "tbody",
                null,
                defaults.days.map(function (items, index) {
                    return _react2.default.createElement(
                        "tr",
                        { key: index },
                        items.map(function (x, iIndex) {
                            return _react2.default.createElement(
                                "td",
                                { key: index + "" + iIndex,
                                    className: isDisabled(defaults.min, defaults.max, defaults.selected.clone().date(x), defaults.date, x),
                                    onClick: function onClick() {
                                        return x !== "" && _onClick(defaults.selected.clone().date(x));
                                    } },
                                x
                            );
                        })
                    );
                })
            )
        )
    );
};