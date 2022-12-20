"use strict";
exports.__esModule = true;
exports.System = exports.Hd4k = exports.BluetoothConnector = exports.WifiConnector = void 0;
var WifiConnector = /** @class */ (function () {
    function WifiConnector() {
    }
    WifiConnector.prototype.connector = function () {
        console.log("Wifi connector");
        return true;
    };
    return WifiConnector;
}());
exports.WifiConnector = WifiConnector;
var BluetoothConnector = /** @class */ (function () {
    function BluetoothConnector() {
    }
    BluetoothConnector.prototype.connector = function () {
        console.log(" Bluetooth Connector");
        return true;
    };
    return BluetoothConnector;
}());
exports.BluetoothConnector = BluetoothConnector;
var Hd4k = /** @class */ (function () {
    function Hd4k() {
    }
    Hd4k.prototype.connector = function () {
        throw new Error("Method not implemented.");
    };
    return Hd4k;
}());
exports.Hd4k = Hd4k;
var System = /** @class */ (function () {
    function System(connector) {
        this.connector = connector;
    }
    return System;
}());
exports.System = System;
var wifi = new WifiConnector();
var Bluetooth = new BluetoothConnector();
var system = new System(wifi);
var system2 = new System(Bluetooth);
