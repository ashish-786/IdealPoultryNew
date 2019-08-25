/*!
 * jQuery UI Slider 1.11.4
 * http://jqueryui.com
 *
 * Copyright jQuery Foundation and other contributors
 * Released under the MIT license.
 * http://jquery.org/license
 *
 * http://api.jqueryui.com/slider/
 */
!function(a) {
    "function" == typeof define && define.amd ? define(["jquery", "./core", "./mouse", "./widget"], a) : a(jQuery)
}(function(a) {
    return a.widget("ui.slider", a.ui.mouse, {
        version: "1.11.4",
        widgetEventPrefix: "slide",
        options: {
            animate: !1,
            distance: 0,
            max: 100,
            min: 0,
            orientation: "horizontal",
            range: !1,
            step: 1,
            value: 0,
            values: null,
            change: null,
            slide: null,
            start: null,
            stop: null
        },
        numPages: 5,
        _create: function() {
            this._keySliding = !1,
            this._mouseSliding = !1,
            this._animateOff = !0,
            this._handleIndex = null,
            this._detectOrientation(),
            this._mouseInit(),
            this._calculateNewMax(),
            this.element.addClass("ui-slider ui-slider-" + this.orientation + " ui-widget ui-widget-content ui-corner-all"),
            this._refresh(),
            this._setOption("disabled", this.options.disabled),
            this._animateOff = !1
        },
        _refresh: function() {
            this._createRange(),
            this._createHandles(),
            this._setupEvents(),
            this._refreshValue()
        },
        _createHandles: function() {
            var b, c, d = this.options, e = this.element.find(".ui-slider-handle").addClass("ui-state-default ui-corner-all"), f = "<span class='ui-slider-handle ui-state-default ui-corner-all' tabindex='0'></span>", g = [];
            for (c = d.values && d.values.length || 1,
            e.length > c && (e.slice(c).remove(),
            e = e.slice(0, c)),
            b = e.length; b < c; b++)
                g.push(f);
            this.handles = e.add(a(g.join("")).appendTo(this.element)),
            this.handle = this.handles.eq(0),
            this.handles.each(function(b) {
                a(this).data("ui-slider-handle-index", b)
            })
        },
        _createRange: function() {
            var b = this.options
              , c = "";
            b.range ? (b.range === !0 && (b.values ? b.values.length && 2 !== b.values.length ? b.values = [b.values[0], b.values[0]] : a.isArray(b.values) && (b.values = b.values.slice(0)) : b.values = [this._valueMin(), this._valueMin()]),
            this.range && this.range.length ? this.range.removeClass("ui-slider-range-min ui-slider-range-max").css({
                left: "",
                bottom: ""
            }) : (this.range = a("<div></div>").appendTo(this.element),
            c = "ui-slider-range ui-widget-header ui-corner-all"),
            this.range.addClass(c + ("min" === b.range || "max" === b.range ? " ui-slider-range-" + b.range : ""))) : (this.range && this.range.remove(),
            this.range = null)
        },
        _setupEvents: function() {
            this._off(this.handles),
            this._on(this.handles, this._handleEvents),
            this._hoverable(this.handles),
            this._focusable(this.handles)
        },
        _destroy: function() {
            this.handles.remove(),
            this.range && this.range.remove(),
            this.element.removeClass("ui-slider ui-slider-horizontal ui-slider-vertical ui-widget ui-widget-content ui-corner-all"),
            this._mouseDestroy()
        },
        _mouseCapture: function(b) {
            var c, d, e, f, g, h, i, j, k = this, l = this.options;
            return !l.disabled && (this.elementSize = {
                width: this.element.outerWidth(),
                height: this.element.outerHeight()
            },
            this.elementOffset = this.element.offset(),
            c = {
                x: b.pageX,
                y: b.pageY
            },
            d = this._normValueFromMouse(c),
            e = this._valueMax() - this._valueMin() + 1,
            this.handles.each(function(b) {
                var c = Math.abs(d - k.values(b));
                (e > c || e === c && (b === k._lastChangedValue || k.values(b) === l.min)) && (e = c,
                f = a(this),
                g = b)
            }),
            h = this._start(b, g),
            h !== !1 && (this._mouseSliding = !0,
            this._handleIndex = g,
            f.addClass("ui-state-active").focus(),
            i = f.offset(),
            j = !a(b.target).parents().addBack().is(".ui-slider-handle"),
            this._clickOffset = j ? {
                left: 0,
                top: 0
            } : {
                left: b.pageX - i.left - f.width() / 2,
                top: b.pageY - i.top - f.height() / 2 - (parseInt(f.css("borderTopWidth"), 10) || 0) - (parseInt(f.css("borderBottomWidth"), 10) || 0) + (parseInt(f.css("marginTop"), 10) || 0)
            },
            this.handles.hasClass("ui-state-hover") || this._slide(b, g, d),
            this._animateOff = !0,
            !0))
        },
        _mouseStart: function() {
            return !0
        },
        _mouseDrag: function(a) {
            var b = {
                x: a.pageX,
                y: a.pageY
            }
              , c = this._normValueFromMouse(b);
            return this._slide(a, this._handleIndex, c),
            !1
        },
        _mouseStop: function(a) {
            return this.handles.removeClass("ui-state-active"),
            this._mouseSliding = !1,
            this._stop(a, this._handleIndex),
            this._change(a, this._handleIndex),
            this._handleIndex = null,
            this._clickOffset = null,
            this._animateOff = !1,
            !1
        },
        _detectOrientation: function() {
            this.orientation = "vertical" === this.options.orientation ? "vertical" : "horizontal"
        },
        _normValueFromMouse: function(a) {
            var b, c, d, e, f;
            return "horizontal" === this.orientation ? (b = this.elementSize.width,
            c = a.x - this.elementOffset.left - (this._clickOffset ? this._clickOffset.left : 0)) : (b = this.elementSize.height,
            c = a.y - this.elementOffset.top - (this._clickOffset ? this._clickOffset.top : 0)),
            d = c / b,
            d > 1 && (d = 1),
            d < 0 && (d = 0),
            "vertical" === this.orientation && (d = 1 - d),
            e = this._valueMax() - this._valueMin(),
            f = this._valueMin() + d * e,
            this._trimAlignValue(f)
        },
        _start: function(a, b) {
            var c = {
                handle: this.handles[b],
                value: this.value()
            };
            return this.options.values && this.options.values.length && (c.value = this.values(b),
            c.values = this.values()),
            this._trigger("start", a, c)
        },
        _slide: function(a, b, c) {
            var d, e, f;
            this.options.values && this.options.values.length ? (d = this.values(b ? 0 : 1),
            2 === this.options.values.length && this.options.range === !0 && (0 === b && c > d || 1 === b && c < d) && (c = d),
            c !== this.values(b) && (e = this.values(),
            e[b] = c,
            f = this._trigger("slide", a, {
                handle: this.handles[b],
                value: c,
                values: e
            }),
            d = this.values(b ? 0 : 1),
            f !== !1 && this.values(b, c))) : c !== this.value() && (f = this._trigger("slide", a, {
                handle: this.handles[b],
                value: c
            }),
            f !== !1 && this.value(c))
        },
        _stop: function(a, b) {
            var c = {
                handle: this.handles[b],
                value: this.value()
            };
            this.options.values && this.options.values.length && (c.value = this.values(b),
            c.values = this.values()),
            this._trigger("stop", a, c)
        },
        _change: function(a, b) {
            if (!this._keySliding && !this._mouseSliding) {
                var c = {
                    handle: this.handles[b],
                    value: this.value()
                };
                this.options.values && this.options.values.length && (c.value = this.values(b),
                c.values = this.values()),
                this._lastChangedValue = b,
                this._trigger("change", a, c)
            }
        },
        value: function(a) {
            return arguments.length ? (this.options.value = this._trimAlignValue(a),
            this._refreshValue(),
            void this._change(null, 0)) : this._value()
        },
        values: function(b, c) {
            var d, e, f;
            if (arguments.length > 1)
                return this.options.values[b] = this._trimAlignValue(c),
                this._refreshValue(),
                void this._change(null, b);
            if (!arguments.length)
                return this._values();
            if (!a.isArray(arguments[0]))
                return this.options.values && this.options.values.length ? this._values(b) : this.value();
            for (d = this.options.values,
            e = arguments[0],
            f = 0; f < d.length; f += 1)
                d[f] = this._trimAlignValue(e[f]),
                this._change(null, f);
            this._refreshValue()
        },
        _setOption: function(b, c) {
            var d, e = 0;
            switch ("range" === b && this.options.range === !0 && ("min" === c ? (this.options.value = this._values(0),
            this.options.values = null) : "max" === c && (this.options.value = this._values(this.options.values.length - 1),
            this.options.values = null)),
            a.isArray(this.options.values) && (e = this.options.values.length),
            "disabled" === b && this.element.toggleClass("ui-state-disabled", !!c),
            this._super(b, c),
            b) {
            case "orientation":
                this._detectOrientation(),
                this.element.removeClass("ui-slider-horizontal ui-slider-vertical").addClass("ui-slider-" + this.orientation),
                this._refreshValue(),
                this.handles.css("horizontal" === c ? "bottom" : "left", "");
                break;
            case "value":
                this._animateOff = !0,
                this._refreshValue(),
                this._change(null, 0),
                this._animateOff = !1;
                break;
            case "values":
                for (this._animateOff = !0,
                this._refreshValue(),
                d = 0; d < e; d += 1)
                    this._change(null, d);
                this._animateOff = !1;
                break;
            case "step":
            case "min":
            case "max":
                this._animateOff = !0,
                this._calculateNewMax(),
                this._refreshValue(),
                this._animateOff = !1;
                break;
            case "range":
                this._animateOff = !0,
                this._refresh(),
                this._animateOff = !1
            }
        },
        _value: function() {
            var a = this.options.value;
            return a = this._trimAlignValue(a)
        },
        _values: function(a) {
            var b, c, d;
            if (arguments.length)
                return b = this.options.values[a],
                b = this._trimAlignValue(b);
            if (this.options.values && this.options.values.length) {
                for (c = this.options.values.slice(),
                d = 0; d < c.length; d += 1)
                    c[d] = this._trimAlignValue(c[d]);
                return c
            }
            return []
        },
        _trimAlignValue: function(a) {
            if (a <= this._valueMin())
                return this._valueMin();
            if (a >= this._valueMax())
                return this._valueMax();
            var b = this.options.step > 0 ? this.options.step : 1
              , c = (a - this._valueMin()) % b
              , d = a - c;
            return 2 * Math.abs(c) >= b && (d += c > 0 ? b : -b),
            parseFloat(d.toFixed(5))
        },
        _calculateNewMax: function() {
            var a = this.options.max
              , b = this._valueMin()
              , c = this.options.step
              , d = Math.floor(+(a - b).toFixed(this._precision()) / c) * c;
            a = d + b,
            this.max = parseFloat(a.toFixed(this._precision()))
        },
        _precision: function() {
            var a = this._precisionOf(this.options.step);
            return null !== this.options.min && (a = Math.max(a, this._precisionOf(this.options.min))),
            a
        },
        _precisionOf: function(a) {
            var b = a.toString()
              , c = b.indexOf(".");
            return c === -1 ? 0 : b.length - c - 1
        },
        _valueMin: function() {
            return this.options.min
        },
        _valueMax: function() {
            return this.max
        },
        _refreshValue: function() {
            var b, c, d, e, f, g = this.options.range, h = this.options, i = this, j = !this._animateOff && h.animate, k = {};
            this.options.values && this.options.values.length ? this.handles.each(function(d) {
                c = (i.values(d) - i._valueMin()) / (i._valueMax() - i._valueMin()) * 100,
                k["horizontal" === i.orientation ? "left" : "bottom"] = c + "%",
                a(this).stop(1, 1)[j ? "animate" : "css"](k, h.animate),
                i.options.range === !0 && ("horizontal" === i.orientation ? (0 === d && i.range.stop(1, 1)[j ? "animate" : "css"]({
                    left: c + "%"
                }, h.animate),
                1 === d && i.range[j ? "animate" : "css"]({
                    width: c - b + "%"
                }, {
                    queue: !1,
                    duration: h.animate
                })) : (0 === d && i.range.stop(1, 1)[j ? "animate" : "css"]({
                    bottom: c + "%"
                }, h.animate),
                1 === d && i.range[j ? "animate" : "css"]({
                    height: c - b + "%"
                }, {
                    queue: !1,
                    duration: h.animate
                }))),
                b = c
            }) : (d = this.value(),
            e = this._valueMin(),
            f = this._valueMax(),
            c = f !== e ? (d - e) / (f - e) * 100 : 0,
            k["horizontal" === this.orientation ? "left" : "bottom"] = c + "%",
            this.handle.stop(1, 1)[j ? "animate" : "css"](k, h.animate),
            "min" === g && "horizontal" === this.orientation && this.range.stop(1, 1)[j ? "animate" : "css"]({
                width: c + "%"
            }, h.animate),
            "max" === g && "horizontal" === this.orientation && this.range[j ? "animate" : "css"]({
                width: 100 - c + "%"
            }, {
                queue: !1,
                duration: h.animate
            }),
            "min" === g && "vertical" === this.orientation && this.range.stop(1, 1)[j ? "animate" : "css"]({
                height: c + "%"
            }, h.animate),
            "max" === g && "vertical" === this.orientation && this.range[j ? "animate" : "css"]({
                height: 100 - c + "%"
            }, {
                queue: !1,
                duration: h.animate
            }))
        },
        _handleEvents: {
            keydown: function(b) {
                var c, d, e, f, g = a(b.target).data("ui-slider-handle-index");
                switch (b.keyCode) {
                case a.ui.keyCode.HOME:
                case a.ui.keyCode.END:
                case a.ui.keyCode.PAGE_UP:
                case a.ui.keyCode.PAGE_DOWN:
                case a.ui.keyCode.UP:
                case a.ui.keyCode.RIGHT:
                case a.ui.keyCode.DOWN:
                case a.ui.keyCode.LEFT:
                    if (b.preventDefault(),
                    !this._keySliding && (this._keySliding = !0,
                    a(b.target).addClass("ui-state-active"),
                    c = this._start(b, g),
                    c === !1))
                        return
                }
                switch (f = this.options.step,
                d = e = this.options.values && this.options.values.length ? this.values(g) : this.value(),
                b.keyCode) {
                case a.ui.keyCode.HOME:
                    e = this._valueMin();
                    break;
                case a.ui.keyCode.END:
                    e = this._valueMax();
                    break;
                case a.ui.keyCode.PAGE_UP:
                    e = this._trimAlignValue(d + (this._valueMax() - this._valueMin()) / this.numPages);
                    break;
                case a.ui.keyCode.PAGE_DOWN:
                    e = this._trimAlignValue(d - (this._valueMax() - this._valueMin()) / this.numPages);
                    break;
                case a.ui.keyCode.UP:
                case a.ui.keyCode.RIGHT:
                    if (d === this._valueMax())
                        return;
                    e = this._trimAlignValue(d + f);
                    break;
                case a.ui.keyCode.DOWN:
                case a.ui.keyCode.LEFT:
                    if (d === this._valueMin())
                        return;
                    e = this._trimAlignValue(d - f)
                }
                this._slide(b, g, e)
            },
            keyup: function(b) {
                var c = a(b.target).data("ui-slider-handle-index");
                this._keySliding && (this._keySliding = !1,
                this._stop(b, c),
                this._change(b, c),
                a(b.target).removeClass("ui-state-active"))
            }
        }
    })
});
