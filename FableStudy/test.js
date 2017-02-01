"use strict";

Object.defineProperty(exports, "__esModule", {
  value: true
});
exports.add10 = exports.x = undefined;
exports.f = f;
exports.negiate = negiate;

var _String = require("fable-core/umd/String");

var _List = require("fable-core/umd/List");

var _Seq = require("fable-core/umd/Seq");

var _module = require("./module");

(0, _String.fsFormat)("hello, fable")(function (x) {
  console.log(x);
});
var x = exports.x = 10;
(0, _String.fsFormat)("x=%A")(function (x) {
  console.log(x);
})(x);

function f(x_1, y) {
  return x_1 + y;
}

(0, _String.fsFormat)("x+y=%A")(function (x) {
  console.log(x);
})(f(10, 20));

var add10 = exports.add10 = function () {
  var x_1 = 10;
  return function (y) {
    return f(x_1, y);
  };
}();

(0, _String.fsFormat)("50 add 10 = %A")(function (x) {
  console.log(x);
})(add10(50));

function negiate(x_1) {
  return -x_1;
}

(0, _String.fsFormat)("20 add 10 and negiate=%A")(function (x) {
  console.log(x);
})(function ($var2) {
  return function (value) {
    return String(value);
  }(function ($var1) {
    return function (x_1) {
      return negiate(x_1);
    }(add10($var1));
  }($var2));
}(20));
(0, _String.fsFormat)("%A")(function (x) {
  console.log(x);
})(function (list) {
  return (0, _List.map)(add10, list);
}((0, _Seq.toList)((0, _Seq.range)(1, 50))));
(0, _String.fsFormat)("50^2 = %A")(function (x) {
  console.log(x);
})((0, _module.square)(50));