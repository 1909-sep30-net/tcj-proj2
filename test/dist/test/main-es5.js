(window["webpackJsonp"] = window["webpackJsonp"] || []).push([["main"], {
        /***/ "./$$_lazy_route_resource lazy recursive": 
        /*!******************************************************!*\
          !*** ./$$_lazy_route_resource lazy namespace object ***!
          \******************************************************/
        /*! no static exports found */
        /***/ (function (module, exports) {
            function webpackEmptyAsyncContext(req) {
                // Here Promise.resolve().then() is used instead of new Promise() to prevent
                // uncaught exception popping up in devtools
                return Promise.resolve().then(function () {
                    var e = new Error("Cannot find module '" + req + "'");
                    e.code = 'MODULE_NOT_FOUND';
                    throw e;
                });
            }
            webpackEmptyAsyncContext.keys = function () { return []; };
            webpackEmptyAsyncContext.resolve = webpackEmptyAsyncContext;
            module.exports = webpackEmptyAsyncContext;
            webpackEmptyAsyncContext.id = "./$$_lazy_route_resource lazy recursive";
            /***/ 
        }),
        /***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/HelpByPros/Components/Category/category.component.html": 
        /*!**************************************************************************************************************!*\
          !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/HelpByPros/Components/Category/category.component.html ***!
          \**************************************************************************************************************/
        /*! exports provided: default */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony default export */ __webpack_exports__["default"] = ("    \r\n    <h2 *ngFor=\"let category of categories\">\r\n      \r\n      <!-- set the statedata servive's value for current category-->\r\n      <a routerLink=\"questions\" (click)=\"setqCatState( category )\"> {{ category }}  </a>\r\n\r\n    </h2>\r\n\r\n   ");
            /***/ 
        }),
        /***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/HelpByPros/Components/Category/questions/questions.component.html": 
        /*!*************************************************************************************************************************!*\
          !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/HelpByPros/Components/Category/questions/questions.component.html ***!
          \*************************************************************************************************************************/
        /*! exports provided: default */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony default export */ __webpack_exports__["default"] = ("\r\n<h1> {{ category }} </h1>\r\n\r\n <a routerLink=\"postquestion\" (click)=\"setqCatState( category )\"> <h3> Ask a Question  </h3></a>\r\n\r\n<h2 *ngFor=\"let question of questionList\">\r\n      <!-- <code>{{ question | json }}</code> -->\r\n      <p> {{ question.username }} asks </p>\r\n      <h3>{{question.userQuestion }}</h3>\r\n      <ul style=\"list-style-type: none;\"><li>{{ question.questionBody }} </li></ul>\r\n        \r\n");
            /***/ 
        }),
        /***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/HelpByPros/Components/postquestion/postquestion.component.html": 
        /*!**********************************************************************************************************************!*\
          !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/HelpByPros/Components/postquestion/postquestion.component.html ***!
          \**********************************************************************************************************************/
        /*! exports provided: default */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony default export */ __webpack_exports__["default"] = ("<pre *ngIf=\"auth.userProfile$ | async as profile\">\r\n      \r\n       \r\n<div class=\"container\" [hidden]= \"submitted\">\r\n        <h1>Question Form</h1>\r\n        <form (ngSubmit)=\"onSubmit()\" #Postquestion=\"ngForm\">\r\n\r\n\r\n          <div class=\"form-group\">\r\n            <label for=\"UserQuestion\">Question Header</label>\r\n            <input type=\"text\" class=\"form-control\" id=\"UserQuestion\" \r\n            required\r\n            [(ngModel)]=\"model.UserQuestion\" \r\n            name =\"UserQuestion\" >\r\n          </div>\r\n          <div class=\"form-group\">\r\n                <label for=\"Category\">Category</label>\r\n                <select class=\"form-control\" id=\"Category\" required\r\n                \r\n                [(ngModel)]=\"model.Category\" name=\"Category\">\r\n\r\n               \r\n                  <option *ngFor=\"let item of items\" [value]=\"item\"></option>\r\n                </select>\r\n              </div>\r\n    \r\n          <div class=\"form-group\">\r\n            <label for=\"QuestionBody\">Elaborate on Question</label>\r\n            <input type=\"text\" class=\"form-control\" id=\"QuestionBody\"\r\n            [(ngModel)]=\"model.QuestionBody\" name=\"QuestionBody\">\r\n\r\n          </div>\r\n    \r\n          <button type=\"submit\" class=\"btn btn-success\"\r\n          [disabled] =!Postquestion.form.valid\r\n          \r\n          >Submit</button>\r\n\r\n          \r\n    \r\n        </form>\r\n    </div>\r\n\r\n    <div  *ngIf=\"!submitted\" >\r\n            <h2>You submitted the following:</h2>\r\n            <div class=\"row\">\r\n              <div class=\"col-xs-3\">header</div>\r\n              <div class=\"col-xs-9\">{{ model.UserQuestion }}</div>\r\n            </div>\r\n            <div class=\"row\">\r\n              <div class=\"col-xs-3\">body</div>\r\n              <div class=\"col-xs-9\">{{ model.QuestionBody }}</div>\r\n            </div>\r\n            <div class=\"row\">\r\n              <div class=\"col-xs-3\">category</div>\r\n              <div class=\"col-xs-9\">{{ model.Category }}</div>\r\n              <div class=\"col-xs-9\">{{submitted }}</div>\r\n            </div>\r\n            <br>\r\n            <button class=\"btn btn-primary\" (click)=\"submitted=false\">Go Back</button>\r\n          </div> \r\n\r\n</pre>");
            /***/ 
        }),
        /***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/HelpByPros/Components/register/register.component.html": 
        /*!**************************************************************************************************************!*\
          !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/HelpByPros/Components/register/register.component.html ***!
          \**************************************************************************************************************/
        /*! exports provided: default */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony default export */ __webpack_exports__["default"] = ("<p>register works!</p>\r\n");
            /***/ 
        }),
        /***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/app.component.html": 
        /*!**************************************************************************!*\
          !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/app.component.html ***!
          \**************************************************************************/
        /*! exports provided: default */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony default export */ __webpack_exports__["default"] = ("<!-- this is the \"index\", it serves as the home-page for the website-->\r\n\r\n<!-- top navbar -->\r\n<app-navbar></app-navbar>\r\n\r\n\r\n<!-- category only displayes if logged in -->\r\n<!-- moved to it's own component-->\r\n<!-- <app-category></app-category> \r\n\r\n    <div id= \"category\">    <app-category ></app-category>\r\n    </div>\r\n\r\n    <div id =\"pq\">\r\n            <app-postquestion></app-postquestion>\r\n\r\n    </div>\r\n-->\r\n\r\n\r\n<!-- containers show up here beneith the navbar-->\r\n<div class=\"container\">\r\n    <router-outlet></router-outlet>\r\n</div>");
            /***/ 
        }),
        /***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/home/home.component.html": 
        /*!********************************************************************************!*\
          !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/home/home.component.html ***!
          \********************************************************************************/
        /*! exports provided: default */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony default export */ __webpack_exports__["default"] = ("<h2 id=\"news\">\r\n        Welcome to Help-By-Pros, a question and answer service.<br>\r\n        Log in and start viewing questions and answers by category.\r\n</h2>");
            /***/ 
        }),
        /***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/navbar/navbar.component.html": 
        /*!************************************************************************************!*\
          !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/navbar/navbar.component.html ***!
          \************************************************************************************/
        /*! exports provided: default */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony default export */ __webpack_exports__["default"] = ("<a routerLink=\"\"><h1>Help By Pros</h1></a>\r\n\r\n<!--Auth - button to login, etc-->\r\n<header>\r\n\r\n    <button routerLink=\"categories\" *ngIf=\"auth.loggedIn\">Browse Questions</button>\r\n\r\n    <!-- does not display if not logged in ! -->\r\n    <button routerLink=\"profile\" *ngIf=\"auth.loggedIn\">Profile</button>\r\n    \r\n\r\n    <!-- displays if not logged in-->\r\n    <button id=\"login\" (click)=\"auth.login()\" *ngIf=\"!auth.loggedIn\">Log In</button>\r\n    \r\n    <!-- displayes if logged in -->\r\n    <button (click)=\"auth.logout()\" *ngIf=\"auth.loggedIn\">Log Out</button>\r\n  \r\n    \r\n    \r\n</header>\r\n\r\n");
            /***/ 
        }),
        /***/ "./node_modules/raw-loader/dist/cjs.js!./src/app/profile/profile.component.html": 
        /*!**************************************************************************************!*\
          !*** ./node_modules/raw-loader/dist/cjs.js!./src/app/profile/profile.component.html ***!
          \**************************************************************************************/
        /*! exports provided: default */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony default export */ __webpack_exports__["default"] = ("<pre *ngIf=\"auth.userProfile$ | async as profile\">\r\n        {{ profile.email }}\r\n    <!--<code>{{ profile | json }}</code>-->\r\n</pre>");
            /***/ 
        }),
        /***/ "./node_modules/tslib/tslib.es6.js": 
        /*!*****************************************!*\
          !*** ./node_modules/tslib/tslib.es6.js ***!
          \*****************************************/
        /*! exports provided: __extends, __assign, __rest, __decorate, __param, __metadata, __awaiter, __generator, __exportStar, __values, __read, __spread, __spreadArrays, __await, __asyncGenerator, __asyncDelegator, __asyncValues, __makeTemplateObject, __importStar, __importDefault */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__extends", function () { return __extends; });
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__assign", function () { return __assign; });
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__rest", function () { return __rest; });
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__decorate", function () { return __decorate; });
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__param", function () { return __param; });
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__metadata", function () { return __metadata; });
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__awaiter", function () { return __awaiter; });
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__generator", function () { return __generator; });
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__exportStar", function () { return __exportStar; });
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__values", function () { return __values; });
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__read", function () { return __read; });
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__spread", function () { return __spread; });
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__spreadArrays", function () { return __spreadArrays; });
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__await", function () { return __await; });
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__asyncGenerator", function () { return __asyncGenerator; });
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__asyncDelegator", function () { return __asyncDelegator; });
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__asyncValues", function () { return __asyncValues; });
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__makeTemplateObject", function () { return __makeTemplateObject; });
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__importStar", function () { return __importStar; });
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "__importDefault", function () { return __importDefault; });
            /*! *****************************************************************************
            Copyright (c) Microsoft Corporation. All rights reserved.
            Licensed under the Apache License, Version 2.0 (the "License"); you may not use
            this file except in compliance with the License. You may obtain a copy of the
            License at http://www.apache.org/licenses/LICENSE-2.0
            
            THIS CODE IS PROVIDED ON AN *AS IS* BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
            KIND, EITHER EXPRESS OR IMPLIED, INCLUDING WITHOUT LIMITATION ANY IMPLIED
            WARRANTIES OR CONDITIONS OF TITLE, FITNESS FOR A PARTICULAR PURPOSE,
            MERCHANTABLITY OR NON-INFRINGEMENT.
            
            See the Apache Version 2.0 License for specific language governing permissions
            and limitations under the License.
            ***************************************************************************** */
            /* global Reflect, Promise */
            var extendStatics = function (d, b) {
                extendStatics = Object.setPrototypeOf ||
                    ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
                    function (d, b) { for (var p in b)
                        if (b.hasOwnProperty(p))
                            d[p] = b[p]; };
                return extendStatics(d, b);
            };
            function __extends(d, b) {
                extendStatics(d, b);
                function __() { this.constructor = d; }
                d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
            }
            var __assign = function () {
                __assign = Object.assign || function __assign(t) {
                    for (var s, i = 1, n = arguments.length; i < n; i++) {
                        s = arguments[i];
                        for (var p in s)
                            if (Object.prototype.hasOwnProperty.call(s, p))
                                t[p] = s[p];
                    }
                    return t;
                };
                return __assign.apply(this, arguments);
            };
            function __rest(s, e) {
                var t = {};
                for (var p in s)
                    if (Object.prototype.hasOwnProperty.call(s, p) && e.indexOf(p) < 0)
                        t[p] = s[p];
                if (s != null && typeof Object.getOwnPropertySymbols === "function")
                    for (var i = 0, p = Object.getOwnPropertySymbols(s); i < p.length; i++) {
                        if (e.indexOf(p[i]) < 0 && Object.prototype.propertyIsEnumerable.call(s, p[i]))
                            t[p[i]] = s[p[i]];
                    }
                return t;
            }
            function __decorate(decorators, target, key, desc) {
                var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
                if (typeof Reflect === "object" && typeof Reflect.decorate === "function")
                    r = Reflect.decorate(decorators, target, key, desc);
                else
                    for (var i = decorators.length - 1; i >= 0; i--)
                        if (d = decorators[i])
                            r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
                return c > 3 && r && Object.defineProperty(target, key, r), r;
            }
            function __param(paramIndex, decorator) {
                return function (target, key) { decorator(target, key, paramIndex); };
            }
            function __metadata(metadataKey, metadataValue) {
                if (typeof Reflect === "object" && typeof Reflect.metadata === "function")
                    return Reflect.metadata(metadataKey, metadataValue);
            }
            function __awaiter(thisArg, _arguments, P, generator) {
                return new (P || (P = Promise))(function (resolve, reject) {
                    function fulfilled(value) { try {
                        step(generator.next(value));
                    }
                    catch (e) {
                        reject(e);
                    } }
                    function rejected(value) { try {
                        step(generator["throw"](value));
                    }
                    catch (e) {
                        reject(e);
                    } }
                    function step(result) { result.done ? resolve(result.value) : new P(function (resolve) { resolve(result.value); }).then(fulfilled, rejected); }
                    step((generator = generator.apply(thisArg, _arguments || [])).next());
                });
            }
            function __generator(thisArg, body) {
                var _ = { label: 0, sent: function () { if (t[0] & 1)
                        throw t[1]; return t[1]; }, trys: [], ops: [] }, f, y, t, g;
                return g = { next: verb(0), "throw": verb(1), "return": verb(2) }, typeof Symbol === "function" && (g[Symbol.iterator] = function () { return this; }), g;
                function verb(n) { return function (v) { return step([n, v]); }; }
                function step(op) {
                    if (f)
                        throw new TypeError("Generator is already executing.");
                    while (_)
                        try {
                            if (f = 1, y && (t = op[0] & 2 ? y["return"] : op[0] ? y["throw"] || ((t = y["return"]) && t.call(y), 0) : y.next) && !(t = t.call(y, op[1])).done)
                                return t;
                            if (y = 0, t)
                                op = [op[0] & 2, t.value];
                            switch (op[0]) {
                                case 0:
                                case 1:
                                    t = op;
                                    break;
                                case 4:
                                    _.label++;
                                    return { value: op[1], done: false };
                                case 5:
                                    _.label++;
                                    y = op[1];
                                    op = [0];
                                    continue;
                                case 7:
                                    op = _.ops.pop();
                                    _.trys.pop();
                                    continue;
                                default:
                                    if (!(t = _.trys, t = t.length > 0 && t[t.length - 1]) && (op[0] === 6 || op[0] === 2)) {
                                        _ = 0;
                                        continue;
                                    }
                                    if (op[0] === 3 && (!t || (op[1] > t[0] && op[1] < t[3]))) {
                                        _.label = op[1];
                                        break;
                                    }
                                    if (op[0] === 6 && _.label < t[1]) {
                                        _.label = t[1];
                                        t = op;
                                        break;
                                    }
                                    if (t && _.label < t[2]) {
                                        _.label = t[2];
                                        _.ops.push(op);
                                        break;
                                    }
                                    if (t[2])
                                        _.ops.pop();
                                    _.trys.pop();
                                    continue;
                            }
                            op = body.call(thisArg, _);
                        }
                        catch (e) {
                            op = [6, e];
                            y = 0;
                        }
                        finally {
                            f = t = 0;
                        }
                    if (op[0] & 5)
                        throw op[1];
                    return { value: op[0] ? op[1] : void 0, done: true };
                }
            }
            function __exportStar(m, exports) {
                for (var p in m)
                    if (!exports.hasOwnProperty(p))
                        exports[p] = m[p];
            }
            function __values(o) {
                var m = typeof Symbol === "function" && o[Symbol.iterator], i = 0;
                if (m)
                    return m.call(o);
                return {
                    next: function () {
                        if (o && i >= o.length)
                            o = void 0;
                        return { value: o && o[i++], done: !o };
                    }
                };
            }
            function __read(o, n) {
                var m = typeof Symbol === "function" && o[Symbol.iterator];
                if (!m)
                    return o;
                var i = m.call(o), r, ar = [], e;
                try {
                    while ((n === void 0 || n-- > 0) && !(r = i.next()).done)
                        ar.push(r.value);
                }
                catch (error) {
                    e = { error: error };
                }
                finally {
                    try {
                        if (r && !r.done && (m = i["return"]))
                            m.call(i);
                    }
                    finally {
                        if (e)
                            throw e.error;
                    }
                }
                return ar;
            }
            function __spread() {
                for (var ar = [], i = 0; i < arguments.length; i++)
                    ar = ar.concat(__read(arguments[i]));
                return ar;
            }
            function __spreadArrays() {
                for (var s = 0, i = 0, il = arguments.length; i < il; i++)
                    s += arguments[i].length;
                for (var r = Array(s), k = 0, i = 0; i < il; i++)
                    for (var a = arguments[i], j = 0, jl = a.length; j < jl; j++, k++)
                        r[k] = a[j];
                return r;
            }
            ;
            function __await(v) {
                return this instanceof __await ? (this.v = v, this) : new __await(v);
            }
            function __asyncGenerator(thisArg, _arguments, generator) {
                if (!Symbol.asyncIterator)
                    throw new TypeError("Symbol.asyncIterator is not defined.");
                var g = generator.apply(thisArg, _arguments || []), i, q = [];
                return i = {}, verb("next"), verb("throw"), verb("return"), i[Symbol.asyncIterator] = function () { return this; }, i;
                function verb(n) { if (g[n])
                    i[n] = function (v) { return new Promise(function (a, b) { q.push([n, v, a, b]) > 1 || resume(n, v); }); }; }
                function resume(n, v) { try {
                    step(g[n](v));
                }
                catch (e) {
                    settle(q[0][3], e);
                } }
                function step(r) { r.value instanceof __await ? Promise.resolve(r.value.v).then(fulfill, reject) : settle(q[0][2], r); }
                function fulfill(value) { resume("next", value); }
                function reject(value) { resume("throw", value); }
                function settle(f, v) { if (f(v), q.shift(), q.length)
                    resume(q[0][0], q[0][1]); }
            }
            function __asyncDelegator(o) {
                var i, p;
                return i = {}, verb("next"), verb("throw", function (e) { throw e; }), verb("return"), i[Symbol.iterator] = function () { return this; }, i;
                function verb(n, f) { i[n] = o[n] ? function (v) { return (p = !p) ? { value: __await(o[n](v)), done: n === "return" } : f ? f(v) : v; } : f; }
            }
            function __asyncValues(o) {
                if (!Symbol.asyncIterator)
                    throw new TypeError("Symbol.asyncIterator is not defined.");
                var m = o[Symbol.asyncIterator], i;
                return m ? m.call(o) : (o = typeof __values === "function" ? __values(o) : o[Symbol.iterator](), i = {}, verb("next"), verb("throw"), verb("return"), i[Symbol.asyncIterator] = function () { return this; }, i);
                function verb(n) { i[n] = o[n] && function (v) { return new Promise(function (resolve, reject) { v = o[n](v), settle(resolve, reject, v.done, v.value); }); }; }
                function settle(resolve, reject, d, v) { Promise.resolve(v).then(function (v) { resolve({ value: v, done: d }); }, reject); }
            }
            function __makeTemplateObject(cooked, raw) {
                if (Object.defineProperty) {
                    Object.defineProperty(cooked, "raw", { value: raw });
                }
                else {
                    cooked.raw = raw;
                }
                return cooked;
            }
            ;
            function __importStar(mod) {
                if (mod && mod.__esModule)
                    return mod;
                var result = {};
                if (mod != null)
                    for (var k in mod)
                        if (Object.hasOwnProperty.call(mod, k))
                            result[k] = mod[k];
                result.default = mod;
                return result;
            }
            function __importDefault(mod) {
                return (mod && mod.__esModule) ? mod : { default: mod };
            }
            /***/ 
        }),
        /***/ "./src/app/HelpByPros/Components/Category/category.component.css": 
        /*!***********************************************************************!*\
          !*** ./src/app/HelpByPros/Components/Category/category.component.css ***!
          \***********************************************************************/
        /*! exports provided: default */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony default export */ __webpack_exports__["default"] = (".example-container {\r\n    position: absolute;\r\n    top: 60px;\r\n    bottom: 60px;\r\n    left: 0;\r\n    right: 0;\r\n  }\r\n  \r\n  .example-sidenav {\r\n    display: flex;\r\n    align-items: center;\r\n    justify-content: center;\r\n    width: 200px;\r\n    background: rgba(255, 0, 0, 0.5);\r\n  }\r\n  \r\n  .example-header {\r\n    position: fixed;\r\n    top: 0;\r\n    left: 0;\r\n    right: 0;\r\n  }\r\n  \r\n  .example-footer {\r\n    position: fixed;\r\n    bottom: 0;\r\n    left: 0;\r\n    right: 0;\r\n  }\r\n  \r\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNyYy9hcHAvSGVscEJ5UHJvcy9Db21wb25lbnRzL0NhdGVnb3J5L2NhdGVnb3J5LmNvbXBvbmVudC5jc3MiXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IkFBQUE7SUFDSSxrQkFBa0I7SUFDbEIsU0FBUztJQUNULFlBQVk7SUFDWixPQUFPO0lBQ1AsUUFBUTtFQUNWOztFQUVBO0lBQ0UsYUFBYTtJQUNiLG1CQUFtQjtJQUNuQix1QkFBdUI7SUFDdkIsWUFBWTtJQUNaLGdDQUFnQztFQUNsQzs7RUFFQTtJQUNFLGVBQWU7SUFDZixNQUFNO0lBQ04sT0FBTztJQUNQLFFBQVE7RUFDVjs7RUFFQTtJQUNFLGVBQWU7SUFDZixTQUFTO0lBQ1QsT0FBTztJQUNQLFFBQVE7RUFDViIsImZpbGUiOiJzcmMvYXBwL0hlbHBCeVByb3MvQ29tcG9uZW50cy9DYXRlZ29yeS9jYXRlZ29yeS5jb21wb25lbnQuY3NzIiwic291cmNlc0NvbnRlbnQiOlsiLmV4YW1wbGUtY29udGFpbmVyIHtcclxuICAgIHBvc2l0aW9uOiBhYnNvbHV0ZTtcclxuICAgIHRvcDogNjBweDtcclxuICAgIGJvdHRvbTogNjBweDtcclxuICAgIGxlZnQ6IDA7XHJcbiAgICByaWdodDogMDtcclxuICB9XHJcbiAgXHJcbiAgLmV4YW1wbGUtc2lkZW5hdiB7XHJcbiAgICBkaXNwbGF5OiBmbGV4O1xyXG4gICAgYWxpZ24taXRlbXM6IGNlbnRlcjtcclxuICAgIGp1c3RpZnktY29udGVudDogY2VudGVyO1xyXG4gICAgd2lkdGg6IDIwMHB4O1xyXG4gICAgYmFja2dyb3VuZDogcmdiYSgyNTUsIDAsIDAsIDAuNSk7XHJcbiAgfVxyXG4gIFxyXG4gIC5leGFtcGxlLWhlYWRlciB7XHJcbiAgICBwb3NpdGlvbjogZml4ZWQ7XHJcbiAgICB0b3A6IDA7XHJcbiAgICBsZWZ0OiAwO1xyXG4gICAgcmlnaHQ6IDA7XHJcbiAgfVxyXG4gIFxyXG4gIC5leGFtcGxlLWZvb3RlciB7XHJcbiAgICBwb3NpdGlvbjogZml4ZWQ7XHJcbiAgICBib3R0b206IDA7XHJcbiAgICBsZWZ0OiAwO1xyXG4gICAgcmlnaHQ6IDA7XHJcbiAgfVxyXG4gICJdfQ== */");
            /***/ 
        }),
        /***/ "./src/app/HelpByPros/Components/Category/category.component.ts": 
        /*!**********************************************************************!*\
          !*** ./src/app/HelpByPros/Components/Category/category.component.ts ***!
          \**********************************************************************/
        /*! exports provided: CategoryComponent */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "CategoryComponent", function () { return CategoryComponent; });
            /* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
            /* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
            /* harmony import */ var src_app_HelpByPros_HelpByPros_api_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! src/app/HelpByPros/HelpByPros-api.service */ "./src/app/HelpByPros/HelpByPros-api.service.ts");
            /* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm2015/forms.js");
            /* harmony import */ var src_app_statedata_service__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! src/app/statedata.service */ "./src/app/statedata.service.ts");
            var CategoryComponent = /** @class */ (function () {
                // if ctor param has access modifier,
                // TS will put that value into a same-name property of the class
                function CategoryComponent(sdService, helpbypros, fb) {
                    this.sdService = sdService;
                    this.helpbypros = helpbypros;
                    //declare variables
                    this.categories = null;
                    this.questionItem = null;
                    this.getCategoryList();
                    if (this.categoryStr != null) {
                        this.getACategoryQuestionList(this.categoryStr);
                    }
                }
                // this is like a C# getter-only property
                CategoryComponent.prototype.getCategoryList = function () {
                    var _this = this;
                    this.helpbypros.getCategoryList().then(function (items) { return _this.categories = items; });
                };
                CategoryComponent.prototype.getACategoryQuestionList = function (x) {
                    var _this = this;
                    this.helpbypros.getACategoryQuestioList(x).then(function (questionItem) { return _this.questionItem = questionItem; });
                };
                //set the current question-list type
                CategoryComponent.prototype.setqCatState = function (val) {
                    this.sdService.setqListType(val);
                };
                CategoryComponent.prototype.ngOnInit = function () {
                };
                return CategoryComponent;
            }());
            CategoryComponent.ctorParameters = function () { return [
                { type: src_app_statedata_service__WEBPACK_IMPORTED_MODULE_4__["StatedataService"] },
                { type: src_app_HelpByPros_HelpByPros_api_service__WEBPACK_IMPORTED_MODULE_2__["HelpByProsAPISerivce"] },
                { type: _angular_forms__WEBPACK_IMPORTED_MODULE_3__["FormBuilder"] }
            ]; };
            CategoryComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
                Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
                    selector: 'app-category,',
                    template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./category.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/HelpByPros/Components/Category/category.component.html")).default,
                    styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./category.component.css */ "./src/app/HelpByPros/Components/Category/category.component.css")).default]
                })
            ], CategoryComponent);
            /***/ 
        }),
        /***/ "./src/app/HelpByPros/Components/Category/questions/questions.component.css": 
        /*!**********************************************************************************!*\
          !*** ./src/app/HelpByPros/Components/Category/questions/questions.component.css ***!
          \**********************************************************************************/
        /*! exports provided: default */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony default export */ __webpack_exports__["default"] = ("\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL0hlbHBCeVByb3MvQ29tcG9uZW50cy9DYXRlZ29yeS9xdWVzdGlvbnMvcXVlc3Rpb25zLmNvbXBvbmVudC5jc3MifQ== */");
            /***/ 
        }),
        /***/ "./src/app/HelpByPros/Components/Category/questions/questions.component.ts": 
        /*!*********************************************************************************!*\
          !*** ./src/app/HelpByPros/Components/Category/questions/questions.component.ts ***!
          \*********************************************************************************/
        /*! exports provided: QuestionsComponent */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "QuestionsComponent", function () { return QuestionsComponent; });
            /* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
            /* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
            /* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm2015/router.js");
            /* harmony import */ var src_app_statedata_service__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! src/app/statedata.service */ "./src/app/statedata.service.ts");
            /* harmony import */ var src_app_HelpByPros_HelpByPros_api_service__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! src/app/HelpByPros/HelpByPros-api.service */ "./src/app/HelpByPros/HelpByPros-api.service.ts");
            //import { category } from './HelpByPros/Components/category';
            var QuestionsComponent = /** @class */ (function () {
                function QuestionsComponent(route, helpbypros, sdService) {
                    this.route = route;
                    this.helpbypros = helpbypros;
                    this.sdService = sdService;
                }
                QuestionsComponent.prototype.getACategoryQuestionList = function (x) {
                    var _this = this;
                    this.helpbypros.getACategoryQuestioList(x).then(function (questionList) { return _this.questionList = questionList; });
                };
                QuestionsComponent.prototype.ngOnInit = function () {
                    //set the question-list type.
                    this.category = this.sdService.getqListType();
                    //get the list
                    this.getACategoryQuestionList(this.category);
                };
                return QuestionsComponent;
            }());
            QuestionsComponent.ctorParameters = function () { return [
                { type: _angular_router__WEBPACK_IMPORTED_MODULE_2__["ActivatedRoute"] },
                { type: src_app_HelpByPros_HelpByPros_api_service__WEBPACK_IMPORTED_MODULE_4__["HelpByProsAPISerivce"] },
                { type: src_app_statedata_service__WEBPACK_IMPORTED_MODULE_3__["StatedataService"] }
            ]; };
            QuestionsComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
                Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
                    selector: 'app-questions',
                    template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./questions.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/HelpByPros/Components/Category/questions/questions.component.html")).default,
                    styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./questions.component.css */ "./src/app/HelpByPros/Components/Category/questions/questions.component.css")).default]
                })
            ], QuestionsComponent);
            /***/ 
        }),
        /***/ "./src/app/HelpByPros/Components/postquestion/postquestion.component.css": 
        /*!*******************************************************************************!*\
          !*** ./src/app/HelpByPros/Components/postquestion/postquestion.component.css ***!
          \*******************************************************************************/
        /*! exports provided: default */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony default export */ __webpack_exports__["default"] = ("\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL0hlbHBCeVByb3MvQ29tcG9uZW50cy9wb3N0cXVlc3Rpb24vcG9zdHF1ZXN0aW9uLmNvbXBvbmVudC5jc3MifQ== */");
            /***/ 
        }),
        /***/ "./src/app/HelpByPros/Components/postquestion/postquestion.component.ts": 
        /*!******************************************************************************!*\
          !*** ./src/app/HelpByPros/Components/postquestion/postquestion.component.ts ***!
          \******************************************************************************/
        /*! exports provided: PostquestionComponent */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "PostquestionComponent", function () { return PostquestionComponent; });
            /* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
            /* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
            /* harmony import */ var src_app_HelpByPros_Models_question_items__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! src/app/HelpByPros/Models/question-items */ "./src/app/HelpByPros/Models/question-items.ts");
            /* harmony import */ var _HelpByPros_api_service__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../../HelpByPros-api.service */ "./src/app/HelpByPros/HelpByPros-api.service.ts");
            /* harmony import */ var src_app_auth_service__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! src/app/auth.service */ "./src/app/auth.service.ts");
            /* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm2015/router.js");
            var PostquestionComponent = /** @class */ (function () {
                function PostquestionComponent(route, helpbypros, auth) {
                    this.route = route;
                    this.helpbypros = helpbypros;
                    this.auth = auth;
                    this.items = null;
                    this.getCategoryList();
                    if (this.items != null) {
                        this.model = new src_app_HelpByPros_Models_question_items__WEBPACK_IMPORTED_MODULE_2__["default"](this.items[0].name, "Type Your Question", "Additional Informatino", "member2", 0);
                        console.log(this.items[0].name);
                    }
                    else {
                        this.model = new src_app_HelpByPros_Models_question_items__WEBPACK_IMPORTED_MODULE_2__["default"]("ComputerScience", "Do androids dream of electric sheep?", "Or do they lay silent as they sleep?", "fds", 0);
                    }
                    this.submitted = false;
                }
                PostquestionComponent.prototype.getCategoryList = function () {
                    var _this = this;
                    this.helpbypros.getCategoryList().then(function (items) { return _this.items = items; });
                };
                PostquestionComponent.prototype.AddQuection = function (QuestionItems) {
                    this.helpbypros.createQuestion(QuestionItems);
                };
                PostquestionComponent.prototype.onSubmit = function () { this.submitted = true; this.AddQuection(this.model); };
                PostquestionComponent.prototype.ngOnInit = function () {
                    if (this.items != null) {
                        this.model = new src_app_HelpByPros_Models_question_items__WEBPACK_IMPORTED_MODULE_2__["default"](this.items[0].name, "Type Your Question", "Additional Informatino", "member2", 0);
                    }
                };
                return PostquestionComponent;
            }());
            PostquestionComponent.ctorParameters = function () { return [
                { type: _angular_router__WEBPACK_IMPORTED_MODULE_5__["ActivatedRoute"] },
                { type: _HelpByPros_api_service__WEBPACK_IMPORTED_MODULE_3__["HelpByProsAPISerivce"] },
                { type: src_app_auth_service__WEBPACK_IMPORTED_MODULE_4__["AuthService"] }
            ]; };
            PostquestionComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
                Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
                    selector: 'app-postquestion',
                    template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./postquestion.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/HelpByPros/Components/postquestion/postquestion.component.html")).default,
                    styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./postquestion.component.css */ "./src/app/HelpByPros/Components/postquestion/postquestion.component.css")).default]
                })
            ], PostquestionComponent);
            /***/ 
        }),
        /***/ "./src/app/HelpByPros/Components/register/register.component.css": 
        /*!***********************************************************************!*\
          !*** ./src/app/HelpByPros/Components/register/register.component.css ***!
          \***********************************************************************/
        /*! exports provided: default */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony default export */ __webpack_exports__["default"] = ("\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL0hlbHBCeVByb3MvQ29tcG9uZW50cy9yZWdpc3Rlci9yZWdpc3Rlci5jb21wb25lbnQuY3NzIn0= */");
            /***/ 
        }),
        /***/ "./src/app/HelpByPros/Components/register/register.component.ts": 
        /*!**********************************************************************!*\
          !*** ./src/app/HelpByPros/Components/register/register.component.ts ***!
          \**********************************************************************/
        /*! exports provided: RegisterComponent */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "RegisterComponent", function () { return RegisterComponent; });
            /* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
            /* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
            var RegisterComponent = /** @class */ (function () {
                function RegisterComponent() {
                    this.user = null;
                }
                RegisterComponent.prototype.getCategoryList = function () {
                    // this.helpbypros.getCategoryList().then(items => this.items= items);
                };
                RegisterComponent.prototype.ngOnInit = function () {
                };
                return RegisterComponent;
            }());
            RegisterComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
                Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
                    selector: 'app-register',
                    template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./register.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/HelpByPros/Components/register/register.component.html")).default,
                    styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./register.component.css */ "./src/app/HelpByPros/Components/register/register.component.css")).default]
                })
            ], RegisterComponent);
            /***/ 
        }),
        /***/ "./src/app/HelpByPros/HelpByPros-api.service.ts": 
        /*!******************************************************!*\
          !*** ./src/app/HelpByPros/HelpByPros-api.service.ts ***!
          \******************************************************/
        /*! exports provided: HelpByProsAPISerivce */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "HelpByProsAPISerivce", function () { return HelpByProsAPISerivce; });
            /* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
            /* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
            /* harmony import */ var src_environments_environment__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! src/environments/environment */ "./src/environments/environment.ts");
            /* harmony import */ var _auth_service__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../auth.service */ "./src/app/auth.service.ts");
            /* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm2015/http.js");
            var HelpByProsAPISerivce = /** @class */ (function () {
                function HelpByProsAPISerivce(httpClient, auth) {
                    var _this = this;
                    this.httpClient = httpClient;
                    this.userC = null;
                    console.log("getting");
                    auth.userProfile$.subscribe(function (user) {
                        if (user) {
                            _this.getUser(user.nickname).catch(function (err) {
                                console.log("getting email");
                                console.log(err.status);
                                if (err.status === 404 || err.status == 0 || err.status == 500) {
                                    // if user does not exist, create
                                    console.log("erro 404");
                                    //return this.createUser({email: user.nickname});
                                }
                                else {
                                    throw err;
                                }
                            }).then(function (apiUser) {
                                //this.userC= apiUser;
                            });
                        }
                    });
                }
                //Get a list of categories
                HelpByProsAPISerivce.prototype.getCategoryList = function () {
                    var url = src_environments_environment__WEBPACK_IMPORTED_MODULE_2__["environment"].HelpBYProsApiBaseUrl + "/forum/category";
                    return this.httpClient.get(url).toPromise();
                };
                HelpByProsAPISerivce.prototype.getACategoryQuestioList = function (category) {
                    var url = src_environments_environment__WEBPACK_IMPORTED_MODULE_2__["environment"].HelpBYProsApiBaseUrl + "/home/category/" + category;
                    return this.httpClient.get(url).toPromise();
                };
                HelpByProsAPISerivce.prototype.getUser = function (username) {
                    var url = src_environments_environment__WEBPACK_IMPORTED_MODULE_2__["environment"].HelpBYProsApiBaseUrl + "/user/" + username;
                    return this.httpClient.get(url).toPromise();
                };
                HelpByProsAPISerivce.prototype.createUser = function (user) {
                    var url = src_environments_environment__WEBPACK_IMPORTED_MODULE_2__["environment"].HelpBYProsApiBaseUrl + "/user/CreateUser";
                    return this.httpClient.post(url, user).toPromise();
                };
                HelpByProsAPISerivce.prototype.createQuestion = function (q) {
                    var url = src_environments_environment__WEBPACK_IMPORTED_MODULE_2__["environment"].HelpBYProsApiBaseUrl + "/forum/AddQuestion";
                    return this.httpClient.post(url, q).toPromise();
                };
                return HelpByProsAPISerivce;
            }());
            HelpByProsAPISerivce.ctorParameters = function () { return [
                { type: _angular_common_http__WEBPACK_IMPORTED_MODULE_4__["HttpClient"] },
                { type: _auth_service__WEBPACK_IMPORTED_MODULE_3__["AuthService"] }
            ]; };
            HelpByProsAPISerivce = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
                Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])({
                    providedIn: 'root'
                })
            ], HelpByProsAPISerivce);
            /***/ 
        }),
        /***/ "./src/app/HelpByPros/Models/question-items.ts": 
        /*!*****************************************************!*\
          !*** ./src/app/HelpByPros/Models/question-items.ts ***!
          \*****************************************************/
        /*! exports provided: default */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "default", function () { return QuestionItems; });
            /* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
            var QuestionItems = /** @class */ (function () {
                function QuestionItems(Category, UserQuestion, QuestionBody, Username, QuestionID) {
                    this.Category = Category;
                    this.UserQuestion = UserQuestion;
                    this.QuestionBody = QuestionBody;
                    this.Username = Username;
                    this.QuestionID = QuestionID;
                }
                return QuestionItems;
            }());
            /***/ 
        }),
        /***/ "./src/app/app-routing.module.ts": 
        /*!***************************************!*\
          !*** ./src/app/app-routing.module.ts ***!
          \***************************************/
        /*! exports provided: AppRoutingModule */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AppRoutingModule", function () { return AppRoutingModule; });
            /* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
            /* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
            /* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm2015/router.js");
            /* harmony import */ var _profile_profile_component__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./profile/profile.component */ "./src/app/profile/profile.component.ts");
            /* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm2015/http.js");
            /* harmony import */ var _interceptor_service__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./interceptor.service */ "./src/app/interceptor.service.ts");
            /* harmony import */ var _HelpByPros_Components_Category_category_component__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./HelpByPros/Components/Category/category.component */ "./src/app/HelpByPros/Components/Category/category.component.ts");
            var routes = [
                { path: 'category', component: _HelpByPros_Components_Category_category_component__WEBPACK_IMPORTED_MODULE_6__["CategoryComponent"] },
                { path: 'profile', component: _profile_profile_component__WEBPACK_IMPORTED_MODULE_3__["ProfileComponent"] },
            ];
            var AppRoutingModule = /** @class */ (function () {
                function AppRoutingModule() {
                }
                return AppRoutingModule;
            }());
            AppRoutingModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
                Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["NgModule"])({
                    imports: [_angular_router__WEBPACK_IMPORTED_MODULE_2__["RouterModule"].forRoot(routes)],
                    exports: [_angular_router__WEBPACK_IMPORTED_MODULE_2__["RouterModule"]],
                    providers: [
                        {
                            provide: _angular_common_http__WEBPACK_IMPORTED_MODULE_4__["HTTP_INTERCEPTORS"],
                            useClass: _interceptor_service__WEBPACK_IMPORTED_MODULE_5__["InterceptorService"],
                            multi: true
                        }
                    ]
                })
            ], AppRoutingModule);
            /***/ 
        }),
        /***/ "./src/app/app.component.css": 
        /*!***********************************!*\
          !*** ./src/app/app.component.css ***!
          \***********************************/
        /*! exports provided: default */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony default export */ __webpack_exports__["default"] = ("app-category{\r\n    background-color: brown;\r\n}\r\n\r\n#category {\r\n    float: left;\r\n    width: 20%;\r\n    overflow: hidden;\r\n  }\r\n\r\n#pq {\r\n    overflow: hidden;\r\n  }\r\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbInNyYy9hcHAvYXBwLmNvbXBvbmVudC5jc3MiXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IkFBQUE7SUFDSSx1QkFBdUI7QUFDM0I7O0FBRUE7SUFDSSxXQUFXO0lBQ1gsVUFBVTtJQUNWLGdCQUFnQjtFQUNsQjs7QUFFQTtJQUNFLGdCQUFnQjtFQUNsQiIsImZpbGUiOiJzcmMvYXBwL2FwcC5jb21wb25lbnQuY3NzIiwic291cmNlc0NvbnRlbnQiOlsiYXBwLWNhdGVnb3J5e1xyXG4gICAgYmFja2dyb3VuZC1jb2xvcjogYnJvd247XHJcbn1cclxuXHJcbiNjYXRlZ29yeSB7XHJcbiAgICBmbG9hdDogbGVmdDtcclxuICAgIHdpZHRoOiAyMCU7XHJcbiAgICBvdmVyZmxvdzogaGlkZGVuO1xyXG4gIH1cclxuICBcclxuICAjcHEge1xyXG4gICAgb3ZlcmZsb3c6IGhpZGRlbjtcclxuICB9Il19 */");
            /***/ 
        }),
        /***/ "./src/app/app.component.ts": 
        /*!**********************************!*\
          !*** ./src/app/app.component.ts ***!
          \**********************************/
        /*! exports provided: AppComponent */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AppComponent", function () { return AppComponent; });
            /* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
            /* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
            /* harmony import */ var _auth_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./auth.service */ "./src/app/auth.service.ts");
            var AppComponent = /** @class */ (function () {
                function AppComponent(auth) {
                    this.auth = auth;
                    this.title = 'helpbypros-app';
                }
                AppComponent.prototype.ngOnInit = function () {
                    this.auth.localAuthSetup();
                    this.auth.handleAuthCallback();
                };
                return AppComponent;
            }());
            AppComponent.ctorParameters = function () { return [
                { type: _auth_service__WEBPACK_IMPORTED_MODULE_2__["AuthService"] }
            ]; };
            AppComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
                Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
                    selector: 'app-root',
                    template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./app.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/app.component.html")).default,
                    styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./app.component.css */ "./src/app/app.component.css")).default]
                })
            ], AppComponent);
            /***/ 
        }),
        /***/ "./src/app/app.module.ts": 
        /*!*******************************!*\
          !*** ./src/app/app.module.ts ***!
          \*******************************/
        /*! exports provided: AppModule */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AppModule", function () { return AppModule; });
            /* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
            /* harmony import */ var _angular_platform_browser__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/platform-browser */ "./node_modules/@angular/platform-browser/fesm2015/platform-browser.js");
            /* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
            /* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/forms */ "./node_modules/@angular/forms/fesm2015/forms.js");
            /* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm2015/router.js");
            /* harmony import */ var _app_routing_module__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./app-routing.module */ "./src/app/app-routing.module.ts");
            /* harmony import */ var _app_component__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./app.component */ "./src/app/app.component.ts");
            /* harmony import */ var _navbar_navbar_component__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ./navbar/navbar.component */ "./src/app/navbar/navbar.component.ts");
            /* harmony import */ var _profile_profile_component__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! ./profile/profile.component */ "./src/app/profile/profile.component.ts");
            /* harmony import */ var _app_HelpByPros_Components_register_register_component__WEBPACK_IMPORTED_MODULE_9__ = __webpack_require__(/*! ../app/HelpByPros/Components/register/register.component */ "./src/app/HelpByPros/Components/register/register.component.ts");
            /* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_10__ = __webpack_require__(/*! @angular/common/http */ "./node_modules/@angular/common/fesm2015/http.js");
            /* harmony import */ var _angular_platform_browser_animations__WEBPACK_IMPORTED_MODULE_11__ = __webpack_require__(/*! @angular/platform-browser/animations */ "./node_modules/@angular/platform-browser/fesm2015/animations.js");
            /* harmony import */ var _HelpByPros_Components_Category_category_component__WEBPACK_IMPORTED_MODULE_12__ = __webpack_require__(/*! ./HelpByPros/Components/Category/category.component */ "./src/app/HelpByPros/Components/Category/category.component.ts");
            /* harmony import */ var _angular_material_sidenav__WEBPACK_IMPORTED_MODULE_13__ = __webpack_require__(/*! @angular/material/sidenav */ "./node_modules/@angular/material/esm2015/sidenav.js");
            /* harmony import */ var _angular_material__WEBPACK_IMPORTED_MODULE_14__ = __webpack_require__(/*! @angular/material */ "./node_modules/@angular/material/esm2015/material.js");
            /* harmony import */ var _angular_material_slider__WEBPACK_IMPORTED_MODULE_15__ = __webpack_require__(/*! @angular/material/slider */ "./node_modules/@angular/material/esm2015/slider.js");
            /* harmony import */ var _angular_cdk_layout__WEBPACK_IMPORTED_MODULE_16__ = __webpack_require__(/*! @angular/cdk/layout */ "./node_modules/@angular/cdk/esm2015/layout.js");
            /* harmony import */ var _angular_material_button__WEBPACK_IMPORTED_MODULE_17__ = __webpack_require__(/*! @angular/material/button */ "./node_modules/@angular/material/esm2015/button.js");
            /* harmony import */ var _angular_material_icon__WEBPACK_IMPORTED_MODULE_18__ = __webpack_require__(/*! @angular/material/icon */ "./node_modules/@angular/material/esm2015/icon.js");
            /* harmony import */ var _angular_material_list__WEBPACK_IMPORTED_MODULE_19__ = __webpack_require__(/*! @angular/material/list */ "./node_modules/@angular/material/esm2015/list.js");
            /* harmony import */ var _home_home_component__WEBPACK_IMPORTED_MODULE_20__ = __webpack_require__(/*! ./home/home.component */ "./src/app/home/home.component.ts");
            /* harmony import */ var _HelpByPros_Components_Category_questions_questions_component__WEBPACK_IMPORTED_MODULE_21__ = __webpack_require__(/*! ./HelpByPros/Components/Category/questions/questions.component */ "./src/app/HelpByPros/Components/Category/questions/questions.component.ts");
            /* harmony import */ var _statedata_service__WEBPACK_IMPORTED_MODULE_22__ = __webpack_require__(/*! ./statedata.service */ "./src/app/statedata.service.ts");
            /* harmony import */ var _HelpByPros_Components_postquestion_postquestion_component__WEBPACK_IMPORTED_MODULE_23__ = __webpack_require__(/*! ./HelpByPros/Components/postquestion/postquestion.component */ "./src/app/HelpByPros/Components/postquestion/postquestion.component.ts");
            var AppModule = /** @class */ (function () {
                function AppModule() {
                }
                return AppModule;
            }());
            AppModule = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
                Object(_angular_core__WEBPACK_IMPORTED_MODULE_2__["NgModule"])({
                    declarations: [
                        _app_component__WEBPACK_IMPORTED_MODULE_6__["AppComponent"],
                        _navbar_navbar_component__WEBPACK_IMPORTED_MODULE_7__["NavbarComponent"],
                        _profile_profile_component__WEBPACK_IMPORTED_MODULE_8__["ProfileComponent"],
                        _app_HelpByPros_Components_register_register_component__WEBPACK_IMPORTED_MODULE_9__["RegisterComponent"],
                        _HelpByPros_Components_Category_category_component__WEBPACK_IMPORTED_MODULE_12__["CategoryComponent"],
                        _home_home_component__WEBPACK_IMPORTED_MODULE_20__["HomeComponent"],
                        _HelpByPros_Components_Category_questions_questions_component__WEBPACK_IMPORTED_MODULE_21__["QuestionsComponent"],
                        _HelpByPros_Components_postquestion_postquestion_component__WEBPACK_IMPORTED_MODULE_23__["PostquestionComponent"],
                    ],
                    imports: [
                        _angular_platform_browser__WEBPACK_IMPORTED_MODULE_1__["BrowserModule"],
                        _angular_forms__WEBPACK_IMPORTED_MODULE_3__["FormsModule"],
                        _angular_router__WEBPACK_IMPORTED_MODULE_4__["RouterModule"].forRoot([
                            { path: '', component: _home_home_component__WEBPACK_IMPORTED_MODULE_20__["HomeComponent"] },
                            { path: 'profile', component: _profile_profile_component__WEBPACK_IMPORTED_MODULE_8__["ProfileComponent"] },
                            { path: 'categories', component: _HelpByPros_Components_Category_category_component__WEBPACK_IMPORTED_MODULE_12__["CategoryComponent"] },
                            { path: 'categories/questions', component: _HelpByPros_Components_Category_questions_questions_component__WEBPACK_IMPORTED_MODULE_21__["QuestionsComponent"] },
                            { path: 'categories/questions/postquestion', component: _HelpByPros_Components_postquestion_postquestion_component__WEBPACK_IMPORTED_MODULE_23__["PostquestionComponent"] }
                        ]),
                        _app_routing_module__WEBPACK_IMPORTED_MODULE_5__["AppRoutingModule"],
                        _angular_common_http__WEBPACK_IMPORTED_MODULE_10__["HttpClientModule"],
                        _angular_forms__WEBPACK_IMPORTED_MODULE_3__["ReactiveFormsModule"],
                        _angular_platform_browser_animations__WEBPACK_IMPORTED_MODULE_11__["BrowserAnimationsModule"],
                        _angular_material_sidenav__WEBPACK_IMPORTED_MODULE_13__["MatSidenavModule"],
                        _angular_material__WEBPACK_IMPORTED_MODULE_14__["MatToolbarModule"],
                        _angular_material__WEBPACK_IMPORTED_MODULE_14__["MatCheckboxModule"],
                        _angular_material__WEBPACK_IMPORTED_MODULE_14__["MatFormFieldModule"],
                        _angular_material_slider__WEBPACK_IMPORTED_MODULE_15__["MatSliderModule"],
                        _angular_material__WEBPACK_IMPORTED_MODULE_14__["MatOptionModule"],
                        _angular_cdk_layout__WEBPACK_IMPORTED_MODULE_16__["LayoutModule"],
                        _angular_material_button__WEBPACK_IMPORTED_MODULE_17__["MatButtonModule"],
                        _angular_material_icon__WEBPACK_IMPORTED_MODULE_18__["MatIconModule"],
                        _angular_material_list__WEBPACK_IMPORTED_MODULE_19__["MatListModule"],
                        _angular_forms__WEBPACK_IMPORTED_MODULE_3__["FormsModule"],
                    ],
                    //subscribe to different services
                    providers: [_HelpByPros_Components_Category_category_component__WEBPACK_IMPORTED_MODULE_12__["CategoryComponent"], _statedata_service__WEBPACK_IMPORTED_MODULE_22__["StatedataService"]],
                    bootstrap: [_app_component__WEBPACK_IMPORTED_MODULE_6__["AppComponent"]]
                })
            ], AppModule);
            /***/ 
        }),
        /***/ "./src/app/auth.service.ts": 
        /*!*********************************!*\
          !*** ./src/app/auth.service.ts ***!
          \*********************************/
        /*! exports provided: AuthService */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "AuthService", function () { return AuthService; });
            /* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
            /* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
            /* harmony import */ var _auth0_auth0_spa_js__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @auth0/auth0-spa-js */ "./node_modules/@auth0/auth0-spa-js/dist/auth0-spa-js.production.js");
            /* harmony import */ var _auth0_auth0_spa_js__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/ __webpack_require__.n(_auth0_auth0_spa_js__WEBPACK_IMPORTED_MODULE_2__);
            /* harmony import */ var rxjs__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! rxjs */ "./node_modules/rxjs/_esm2015/index.js");
            /* harmony import */ var rxjs_operators__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! rxjs/operators */ "./node_modules/rxjs/_esm2015/operators/index.js");
            /* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! @angular/router */ "./node_modules/@angular/router/fesm2015/router.js");
            var AuthService = /** @class */ (function () {
                function AuthService(router) {
                    var _this = this;
                    this.router = router;
                    // Create an observable of Auth0 instance of client
                    this.auth0Client$ = Object(rxjs__WEBPACK_IMPORTED_MODULE_3__["from"])(_auth0_auth0_spa_js__WEBPACK_IMPORTED_MODULE_2___default()({
                        domain: "revproj2.auth0.com",
                        client_id: "pFUfW3NH39l60iA7i56JZxHXp4yOIVNK",
                        redirect_uri: "" + window.location.origin,
                        audience: "https://revproj2.auth0.com/api/v2/"
                    })).pipe(Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_4__["shareReplay"])(1), // Every subscription receives the same shared value
                    Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_4__["catchError"])(function (err) { return Object(rxjs__WEBPACK_IMPORTED_MODULE_3__["throwError"])(err); }));
                    // Define observables for SDK methods that return promises by default
                    // For each Auth0 SDK method, first ensure the client instance is ready
                    // concatMap: Using the client instance, call SDK method; SDK returns a promise
                    // from: Convert that resulting promise into an observable
                    this.isAuthenticated$ = this.auth0Client$.pipe(Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_4__["concatMap"])(function (client) { return Object(rxjs__WEBPACK_IMPORTED_MODULE_3__["from"])(client.isAuthenticated()); }), Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_4__["tap"])(function (res) { return _this.loggedIn = res; }));
                    this.handleRedirectCallback$ = this.auth0Client$.pipe(Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_4__["concatMap"])(function (client) { return Object(rxjs__WEBPACK_IMPORTED_MODULE_3__["from"])(client.handleRedirectCallback()); }));
                    // Create subject and public observable of user profile data
                    this.userProfileSubject$ = new rxjs__WEBPACK_IMPORTED_MODULE_3__["BehaviorSubject"](null);
                    this.userProfile$ = this.userProfileSubject$.asObservable();
                    // Create a local property for login status
                    this.loggedIn = null;
                }
                // When calling, options can be passed if desired
                // https://auth0.github.io/auth0-spa-js/classes/auth0client.html#getuser
                AuthService.prototype.getUser$ = function (options) {
                    var _this = this;
                    return this.auth0Client$.pipe(Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_4__["concatMap"])(function (client) { return Object(rxjs__WEBPACK_IMPORTED_MODULE_3__["from"])(client.getUser(options)); }), Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_4__["tap"])(function (user) { return _this.userProfileSubject$.next(user); }));
                };
                AuthService.prototype.localAuthSetup = function () {
                    var _this = this;
                    // This should only be called on app initialization
                    // Set up local authentication streams
                    var checkAuth$ = this.isAuthenticated$.pipe(Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_4__["concatMap"])(function (loggedIn) {
                        if (loggedIn) {
                            // If authenticated, get user and set in app
                            // NOTE: you could pass options here if needed
                            return _this.getUser$();
                        }
                        // If not authenticated, return stream that emits 'false'
                        return Object(rxjs__WEBPACK_IMPORTED_MODULE_3__["of"])(loggedIn);
                    }));
                    checkAuth$.subscribe();
                };
                AuthService.prototype.login = function (redirectPath) {
                    if (redirectPath === void 0) { redirectPath = '/'; }
                    // A desired redirect path can be passed to login method
                    // (e.g., from a route guard)
                    // Ensure Auth0 client instance exists
                    this.auth0Client$.subscribe(function (client) {
                        // Call method to log in
                        client.loginWithRedirect({
                            redirect_uri: "" + window.location.origin,
                            appState: { target: redirectPath }
                        });
                    });
                };
                AuthService.prototype.handleAuthCallback = function () {
                    var _this = this;
                    // Call when app reloads after user logs in with Auth0
                    var params = window.location.search;
                    if (params.includes('code=') && params.includes('state=')) {
                        var targetRoute_1; // Path to redirect to after login processsed
                        var authComplete$ = this.handleRedirectCallback$.pipe(
                        // Have client, now call method to handle auth callback redirect
                        Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_4__["tap"])(function (cbRes) {
                            // Get and set target redirect route from callback results
                            targetRoute_1 = cbRes.appState && cbRes.appState.target ? cbRes.appState.target : '/';
                        }), Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_4__["concatMap"])(function () {
                            // Redirect callback complete; get user and login status
                            return Object(rxjs__WEBPACK_IMPORTED_MODULE_3__["combineLatest"])([
                                _this.getUser$(),
                                _this.isAuthenticated$
                            ]);
                        }));
                        // Subscribe to authentication completion observable
                        // Response will be an array of user and login status
                        authComplete$.subscribe(function (_a) {
                            var user = _a[0], loggedIn = _a[1];
                            // Redirect to target route after callback processing
                            _this.router.navigate([targetRoute_1]);
                        });
                    }
                };
                AuthService.prototype.logout = function () {
                    // Ensure Auth0 client instance exists
                    this.auth0Client$.subscribe(function (client) {
                        // Call method to log out
                        client.logout({
                            client_id: "pFUfW3NH39l60iA7i56JZxHXp4yOIVNK",
                            returnTo: "" + window.location.origin
                        });
                    });
                };
                AuthService.prototype.getTokenSilently$ = function (options) {
                    return this.auth0Client$.pipe(Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_4__["concatMap"])(function (client) { return Object(rxjs__WEBPACK_IMPORTED_MODULE_3__["from"])(client.getTokenSilently(options)); }));
                };
                return AuthService;
            }());
            AuthService.ctorParameters = function () { return [
                { type: _angular_router__WEBPACK_IMPORTED_MODULE_5__["Router"] }
            ]; };
            AuthService = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
                Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])({
                    providedIn: 'root'
                })
            ], AuthService);
            /***/ 
        }),
        /***/ "./src/app/home/home.component.css": 
        /*!*****************************************!*\
          !*** ./src/app/home/home.component.css ***!
          \*****************************************/
        /*! exports provided: default */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony default export */ __webpack_exports__["default"] = ("\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL2hvbWUvaG9tZS5jb21wb25lbnQuY3NzIn0= */");
            /***/ 
        }),
        /***/ "./src/app/home/home.component.ts": 
        /*!****************************************!*\
          !*** ./src/app/home/home.component.ts ***!
          \****************************************/
        /*! exports provided: HomeComponent */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "HomeComponent", function () { return HomeComponent; });
            /* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
            /* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
            var HomeComponent = /** @class */ (function () {
                function HomeComponent() {
                }
                HomeComponent.prototype.ngOnInit = function () {
                };
                return HomeComponent;
            }());
            HomeComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
                Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
                    selector: 'app-home',
                    template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./home.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/home/home.component.html")).default,
                    styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./home.component.css */ "./src/app/home/home.component.css")).default]
                })
            ], HomeComponent);
            /***/ 
        }),
        /***/ "./src/app/interceptor.service.ts": 
        /*!****************************************!*\
          !*** ./src/app/interceptor.service.ts ***!
          \****************************************/
        /*! exports provided: InterceptorService */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "InterceptorService", function () { return InterceptorService; });
            /* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
            /* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
            /* harmony import */ var _auth_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./auth.service */ "./src/app/auth.service.ts");
            /* harmony import */ var rxjs__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! rxjs */ "./node_modules/rxjs/_esm2015/index.js");
            /* harmony import */ var rxjs_operators__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! rxjs/operators */ "./node_modules/rxjs/_esm2015/operators/index.js");
            var InterceptorService = /** @class */ (function () {
                function InterceptorService(auth) {
                    this.auth = auth;
                }
                InterceptorService.prototype.intercept = function (req, next) {
                    return this.auth.getTokenSilently$().pipe(Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_4__["mergeMap"])(function (token) {
                        var tokenReq = req.clone({
                            setHeaders: { Authorization: "Bearer " + token }
                        });
                        return next.handle(tokenReq);
                    }), Object(rxjs_operators__WEBPACK_IMPORTED_MODULE_4__["catchError"])(function (err) { return Object(rxjs__WEBPACK_IMPORTED_MODULE_3__["throwError"])(err); }));
                };
                return InterceptorService;
            }());
            InterceptorService.ctorParameters = function () { return [
                { type: _auth_service__WEBPACK_IMPORTED_MODULE_2__["AuthService"] }
            ]; };
            InterceptorService = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
                Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])({
                    providedIn: 'root'
                })
            ], InterceptorService);
            /***/ 
        }),
        /***/ "./src/app/navbar/navbar.component.css": 
        /*!*********************************************!*\
          !*** ./src/app/navbar/navbar.component.css ***!
          \*********************************************/
        /*! exports provided: default */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony default export */ __webpack_exports__["default"] = ("\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL25hdmJhci9uYXZiYXIuY29tcG9uZW50LmNzcyJ9 */");
            /***/ 
        }),
        /***/ "./src/app/navbar/navbar.component.ts": 
        /*!********************************************!*\
          !*** ./src/app/navbar/navbar.component.ts ***!
          \********************************************/
        /*! exports provided: NavbarComponent */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "NavbarComponent", function () { return NavbarComponent; });
            /* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
            /* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
            /* harmony import */ var _auth_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../auth.service */ "./src/app/auth.service.ts");
            /* harmony import */ var _HelpByPros_HelpByPros_api_service__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../HelpByPros/HelpByPros-api.service */ "./src/app/HelpByPros/HelpByPros-api.service.ts");
            var NavbarComponent = /** @class */ (function () {
                function NavbarComponent(auth, HelpByProsApi) {
                    this.auth = auth;
                    this.HelpByProsApi = HelpByProsApi;
                    this.items = null;
                }
                NavbarComponent.prototype.ngOnInit = function () {
                };
                Object.defineProperty(NavbarComponent.prototype, "user", {
                    get: function () {
                        return this.HelpByProsApi.userC;
                    },
                    enumerable: true,
                    configurable: true
                });
                return NavbarComponent;
            }());
            NavbarComponent.ctorParameters = function () { return [
                { type: _auth_service__WEBPACK_IMPORTED_MODULE_2__["AuthService"] },
                { type: _HelpByPros_HelpByPros_api_service__WEBPACK_IMPORTED_MODULE_3__["HelpByProsAPISerivce"] }
            ]; };
            NavbarComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
                Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
                    selector: 'app-navbar',
                    template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./navbar.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/navbar/navbar.component.html")).default,
                    styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./navbar.component.css */ "./src/app/navbar/navbar.component.css")).default]
                })
            ], NavbarComponent);
            /***/ 
        }),
        /***/ "./src/app/profile/profile.component.css": 
        /*!***********************************************!*\
          !*** ./src/app/profile/profile.component.css ***!
          \***********************************************/
        /*! exports provided: default */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony default export */ __webpack_exports__["default"] = ("\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL3Byb2ZpbGUvcHJvZmlsZS5jb21wb25lbnQuY3NzIn0= */");
            /***/ 
        }),
        /***/ "./src/app/profile/profile.component.ts": 
        /*!**********************************************!*\
          !*** ./src/app/profile/profile.component.ts ***!
          \**********************************************/
        /*! exports provided: ProfileComponent */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "ProfileComponent", function () { return ProfileComponent; });
            /* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
            /* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
            /* harmony import */ var _auth_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../auth.service */ "./src/app/auth.service.ts");
            var ProfileComponent = /** @class */ (function () {
                function ProfileComponent(auth) {
                    this.auth = auth;
                }
                ProfileComponent.prototype.ngOnInit = function () {
                };
                return ProfileComponent;
            }());
            ProfileComponent.ctorParameters = function () { return [
                { type: _auth_service__WEBPACK_IMPORTED_MODULE_2__["AuthService"] }
            ]; };
            ProfileComponent = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
                Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Component"])({
                    selector: 'app-profile',
                    template: tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! raw-loader!./profile.component.html */ "./node_modules/raw-loader/dist/cjs.js!./src/app/profile/profile.component.html")).default,
                    styles: [tslib__WEBPACK_IMPORTED_MODULE_0__["__importDefault"](__webpack_require__(/*! ./profile.component.css */ "./src/app/profile/profile.component.css")).default]
                })
            ], ProfileComponent);
            /***/ 
        }),
        /***/ "./src/app/statedata.service.ts": 
        /*!**************************************!*\
          !*** ./src/app/statedata.service.ts ***!
          \**************************************/
        /*! exports provided: StatedataService */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "StatedataService", function () { return StatedataService; });
            /* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
            /* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
            //Stores state-related data as a service.
            var StatedataService = /** @class */ (function () {
                function StatedataService() {
                    this.qList = "";
                }
                //set question-list type
                StatedataService.prototype.setqListType = function (qLType) {
                    this.qList = qLType;
                };
                StatedataService.prototype.getqListType = function () {
                    return this.qList;
                };
                return StatedataService;
            }());
            StatedataService = tslib__WEBPACK_IMPORTED_MODULE_0__["__decorate"]([
                Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["Injectable"])({
                    providedIn: 'root'
                })
            ], StatedataService);
            /***/ 
        }),
        /***/ "./src/environments/environment.ts": 
        /*!*****************************************!*\
          !*** ./src/environments/environment.ts ***!
          \*****************************************/
        /*! exports provided: environment */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "environment", function () { return environment; });
            /* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
            // This file can be replaced during build by using the `fileReplacements` array.
            // `ng build --prod` replaces `environment.ts` with `environment.prod.ts`.
            // The list of file replacements can be found in `angular.json`.
            var environment = {
                // fridgeApiBaseUrl: 'https://1909nickproject2api.azurewebsites.net',
                HelpBYProsApiBaseUrl: 'https://localhost:44328',
                Category: 'https://localhost:44328/Category',
                production: false
            };
            /*
             * For easier debugging in development mode, you can import the following file
             * to ignore zone related error stack frames such as `zone.run`, `zoneDelegate.invokeTask`.
             *
             * This import should be commented out in production mode because it will have a negative impact
             * on performance if an error is thrown.
             */
            // import 'zone.js/dist/zone-error';  // Included with Angular CLI.
            /***/ 
        }),
        /***/ "./src/main.ts": 
        /*!*********************!*\
          !*** ./src/main.ts ***!
          \*********************/
        /*! no exports provided */
        /***/ (function (module, __webpack_exports__, __webpack_require__) {
            "use strict";
            __webpack_require__.r(__webpack_exports__);
            /* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "./node_modules/tslib/tslib.es6.js");
            /* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "./node_modules/@angular/core/fesm2015/core.js");
            /* harmony import */ var _angular_platform_browser_dynamic__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/platform-browser-dynamic */ "./node_modules/@angular/platform-browser-dynamic/fesm2015/platform-browser-dynamic.js");
            /* harmony import */ var _app_app_module__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./app/app.module */ "./src/app/app.module.ts");
            /* harmony import */ var _environments_environment__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./environments/environment */ "./src/environments/environment.ts");
            /* harmony import */ var hammerjs__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! hammerjs */ "./node_modules/hammerjs/hammer.js");
            /* harmony import */ var hammerjs__WEBPACK_IMPORTED_MODULE_5___default = /*#__PURE__*/ __webpack_require__.n(hammerjs__WEBPACK_IMPORTED_MODULE_5__);
            if (_environments_environment__WEBPACK_IMPORTED_MODULE_4__["environment"].production) {
                Object(_angular_core__WEBPACK_IMPORTED_MODULE_1__["enableProdMode"])();
            }
            Object(_angular_platform_browser_dynamic__WEBPACK_IMPORTED_MODULE_2__["platformBrowserDynamic"])().bootstrapModule(_app_app_module__WEBPACK_IMPORTED_MODULE_3__["AppModule"])
                .catch(function (err) { return console.error(err); });
            /***/ 
        }),
        /***/ 0: 
        /*!***************************!*\
          !*** multi ./src/main.ts ***!
          \***************************/
        /*! no static exports found */
        /***/ (function (module, exports, __webpack_require__) {
            module.exports = __webpack_require__(/*! C:\revature\tcj-proj2\test\src\main.ts */ "./src/main.ts");
            /***/ 
        })
    }, [[0, "runtime", "vendor"]]]);
//# sourceMappingURL=main-es2015.js.map
//# sourceMappingURL=main-es5.js.map
//# sourceMappingURL=main-es5.js.map