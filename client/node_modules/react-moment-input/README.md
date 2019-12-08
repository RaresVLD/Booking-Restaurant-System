# react-moment-input
[![npm](https://img.shields.io/npm/v/react-moment-input.svg)](https://www.npmjs.com/package/react-moment-input)
[ ![Codeship Status for kenanberbic/react-moment-input](https://app.codeship.com/projects/defd3130-8d08-0135-56c7-72b04f178433/status?branch=master)](https://app.codeship.com/projects/249635)
[![Known Vulnerabilities](https://snyk.io/test/npm/react-moment-input/badge.svg)](https://snyk.io/test/npm/react-moment-input)

React datetime picker powered by [momentjs](http://momentjs.com)

The design is from http://wangzuo.github.io/input-moment/.

The icon is from [ionicons](http://ionicons.com/).

Demo: [react-moment-input](https://kenanberbic.bitbucket.io/react-moment-input/).

Source: [react-moment-input](https://git@bitbucket.org/kenanberbic/react-moment-input).

Issue tracker: [react-moment-input](https://bitbucket.org/kenanberbic/react-moment-input/issues)

Support:

* Date time picker
* Translations
* Different date formats, support for AM/PM YYYY-MM-DD hh:mm AA
* Tab selection
* Month selection
* Current day
* Days of week order
* Min and max date
* Icon support
* Custom style

### Installation
``` sh
npm i react-moment-input --save
```

### Usage
``` javascript

import MomentInput from 'react-moment-input';

<MomentInput
              max={moment().add(5,'days')}
              min={moment()}
              format="YYYY-MM-DD HH:mm"
              options={true}
              readOnly={false}
              icon={false}
              onChange={(date)=> {console.log(date)}} />
```

### Usage Available properties

| Property | Type | Content  | Default Value |
| --- | --- | --- | --- |
| min | `moment` | Min selected date | `undefined`
| max | `moment` | Max selected date | `undefined`
| value | `moment` | The current value | `undefined`
| defaultValue | `moment` | The current value, only apply on component mount | `undefined`
| format | `string` | Date time format | `YYYY-MM-DD HH:mm`
| tab | `Number` | Selected tab: 0-Calendar, 1-Time, 2-Year  | `0`
| options | `boolean` | Show header options  | `true`
| position | `string` | Picker positions : 'bottom' or 'right'  | `bottom`
| readOnly | `boolean` | Disable input  | `true`
| monthSelect | `boolean` | Disable month select control  | `false`
| today | `boolean` | Today button  | `false`
| isOpen | `boolean` | Show picker  | `false`
| icon | `boolean` | Show calendar icon  | `false`
| daysOfWeek | `array` | Days order in a week  | `['Sun','Mon','Tue', '...']`
| translations | `JSON` | {DATE:"Date", TIMES:"Times", DAYS_MON:"Mon", MONTHS_OCTOBER:"October"}  | `{}`
| style | `JSON` | Container style  | `undefined`
| className | `string` | Container class  | `r-input-group`
| inputStyle | `JSON` | Input style  | `undefined`
| inputClassName | `string` | Input class | `r-input`
| onChange | `function` | Emit value on every click (value, name) | `undefined`
| onSave | `function` | Emit value on save click (value, name)  | `undefined`
| onClose | `function` | Emit value on picker close (value, name)  | `undefined`
| enableInputClick | `boolean` | Show picker  | `undefined`
| iconType | `string` | Render custom font icon if icon is set to true | `undefined`
| autoClose | `boolean` | Close picker on value change  | `undefined`

### Development
- npm install
- npm start
- http://localhost:8081

### License
ISC