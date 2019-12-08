'use strict';

Object.defineProperty(exports, "__esModule", {
  value: true
});

var _createClass = function () { function defineProperties(target, props) { for (var i = 0; i < props.length; i++) { var descriptor = props[i]; descriptor.enumerable = descriptor.enumerable || false; descriptor.configurable = true; if ("value" in descriptor) descriptor.writable = true; Object.defineProperty(target, descriptor.key, descriptor); } } return function (Constructor, protoProps, staticProps) { if (protoProps) defineProperties(Constructor.prototype, protoProps); if (staticProps) defineProperties(Constructor, staticProps); return Constructor; }; }();

var _classnames = require('classnames');

var _classnames2 = _interopRequireDefault(_classnames);

var _react = require('react');

var _react2 = _interopRequireDefault(_react);

var _range = require('lodash/range');

var _range2 = _interopRequireDefault(_range);

var _chunk = require('lodash/chunk');

var _chunk2 = _interopRequireDefault(_chunk);

function _interopRequireDefault(obj) { return obj && obj.__esModule ? obj : { default: obj }; }

function _classCallCheck(instance, Constructor) { if (!(instance instanceof Constructor)) { throw new TypeError("Cannot call a class as a function"); } }

function _possibleConstructorReturn(self, call) { if (!self) { throw new ReferenceError("this hasn't been initialised - super() hasn't been called"); } return call && (typeof call === "object" || typeof call === "function") ? call : self; }

function _inherits(subClass, superClass) { if (typeof superClass !== "function" && superClass !== null) { throw new TypeError("Super expression must either be null or a function, not " + typeof superClass); } subClass.prototype = Object.create(superClass && superClass.prototype, { constructor: { value: subClass, enumerable: false, writable: true, configurable: true } }); if (superClass) Object.setPrototypeOf ? Object.setPrototypeOf(subClass, superClass) : subClass.__proto__ = superClass; }

var _class = function (_React$Component) {
  _inherits(_class, _React$Component);

  function _class(props) {
    _classCallCheck(this, _class);

    return _possibleConstructorReturn(this, (_class.__proto__ || Object.getPrototypeOf(_class)).call(this, props));
  }

  _createClass(_class, [{
    key: 'render',
    value: function render() {
      var _this2 = this;

      var mom = this.props.moment;

      var currentDay = mom.date();
      var firstDayOfWeek = mom.localeData().firstDayOfWeek();
      var endOfPreviousMonth = mom.clone().subtract(1, 'month').endOf('month').date();
      var startDayOfCurrentMonth = mom.clone().date(1).day();
      var endOfCurrentMonth = mom.clone().endOf('month').date();

      var days = [].concat((0, _range2.default)(endOfPreviousMonth - startDayOfCurrentMonth + firstDayOfWeek + 1, endOfPreviousMonth + 1), (0, _range2.default)(1, endOfCurrentMonth + 1), (0, _range2.default)(1, 42 - endOfCurrentMonth - startDayOfCurrentMonth + firstDayOfWeek + 1));

      var weeks = mom.localeData().weekdaysShort();
      weeks = weeks.slice(firstDayOfWeek).concat(weeks.slice(0, firstDayOfWeek));

      return _react2.default.createElement(
        'table',
        null,
        _react2.default.createElement(
          'thead',
          null,
          _react2.default.createElement(
            'tr',
            null,
            weeks.map(function (week, index) {
              return _react2.default.createElement(
                'td',
                { key: index },
                week
              );
            })
          )
        ),
        _react2.default.createElement(
          'tbody',
          null,
          (0, _chunk2.default)(days, 7).map(function (row, week) {
            return _react2.default.createElement(
              'tr',
              { key: week },
              row.map(function (day) {
                return _react2.default.createElement(Day, { key: day, day: day, currentDay: currentDay, week: week, onClick: function onClick() {
                    return _this2.props.onDaySelect(day, week);
                  } });
              })
            );
          })
        )
      );
    }
  }]);

  return _class;
}(_react2.default.Component);

exports.default = _class;

var Day = function (_React$Component2) {
  _inherits(Day, _React$Component2);

  function Day(props) {
    _classCallCheck(this, Day);

    return _possibleConstructorReturn(this, (Day.__proto__ || Object.getPrototypeOf(Day)).call(this, props));
  }

  _createClass(Day, [{
    key: 'render',
    value: function render() {
      var _props = this.props,
          day = _props.day,
          week = _props.week,
          currentDay = _props.currentDay;


      var prevMonth = week === 0 && day > 7;
      var nextMonth = week >= 4 && day <= 14;

      var cn = (0, _classnames2.default)({
        'prev-month': prevMonth,
        'next-month': nextMonth,
        'current': !prevMonth && !nextMonth && day === currentDay
      });

      return _react2.default.createElement(
        'td',
        { className: cn, onClick: this.props.onClick },
        day
      );
    }
  }]);

  return Day;
}(_react2.default.Component);