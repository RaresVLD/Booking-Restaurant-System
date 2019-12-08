'use strict';

Object.defineProperty(exports, "__esModule", {
    value: true
});

var _extends = Object.assign || function (target) { for (var i = 1; i < arguments.length; i++) { var source = arguments[i]; for (var key in source) { if (Object.prototype.hasOwnProperty.call(source, key)) { target[key] = source[key]; } } } return target; };

var _react = require('react');

var _react2 = _interopRequireDefault(_react);

var _Input = require('@material-ui/core/Input');

var _Input2 = _interopRequireDefault(_Input);

var _InputAdornment = require('@material-ui/core/InputAdornment');

var _InputAdornment2 = _interopRequireDefault(_InputAdornment);

require('./css/style.css');

var _reactInputMask = require('react-input-mask');

var _reactInputMask2 = _interopRequireDefault(_reactInputMask);

function _interopRequireDefault(obj) { return obj && obj.__esModule ? obj : { default: obj }; }

function setMask(format, readOnly) {
    if (readOnly) return "";

    var reg = new RegExp("Y|M|D|H|S", "g");
    return format.toUpperCase().replace(reg, "9");
}

exports.default = function (props) {
    if (!props.defaults.inputCustomControl) return _react2.default.createElement(
        'div',
        { className: !props.defaults.readOnly && !props.defaults.isValid ? "r-input-group r-has-feedback r-has-error" : "r-input-group" },
        _react2.default.createElement(_reactInputMask2.default, {
            className: props.className,
            style: props.style,
            placeholder: props.defaults.format,
            value: props.defaults.value,
            onFocus: props.defaults.enableInputClick ? props.onClick : null,
            onChange: props.onTextChange,
            mask: setMask(props.defaults.format, props.defaults.readOnly),
            readOnly: props.defaults.readOnly }),
        props.defaults.icon && _react2.default.createElement(
            'div',
            { style: { cursor: 'pointer', width: 'auto', display: 'table-cell', position: 'relative' }, className: 'r-input-group-addon', onClick: props.onClick },
            _react2.default.createElement('i', { className: props.defaults.iconType || "fa fa-calendar" })
        )
    );
    return _react2.default.createElement(
        _reactInputMask2.default,
        { mask: setMask(props.defaults.format, props.defaults.readOnly), value: props.defaults.value,
            className: props.className, style: props.style, onChange: props.onTextChange,
            onFocus: props.defaults.enableInputClick ? props.onClick : null, placeholder: props.defaults.format,
            readOnly: props.defaults.readOnly },
        function (inputProps) {
            return _react2.default.createElement(
                'div',
                { style: { display: 'inline-flex' } },
                _react2.default.createElement(_Input2.default, _extends({}, inputProps, { startAdornment: _react2.default.createElement(
                        _InputAdornment2.default,
                        { position: 'start' },
                        props.defaults.iconType
                    ), endAdornment: _react2.default.createElement(
                        _InputAdornment2.default,
                        { position: 'end' },
                        _react2.default.createElement('i', { onClick: function onClick(e) {
                                e.stopPropagation();
                                props.onDecrease(props.defaults.value);
                            }, className: 'fa fa-angle-left input-controls' }),
                        _react2.default.createElement('i', { onClick: function onClick(e) {
                                e.stopPropagation();
                                props.onIncrease(props.defaults.value);
                            }, className: 'fa fa-angle-right input-controls' })
                    ), disableUnderline: true }))
            );
        }
    );
};