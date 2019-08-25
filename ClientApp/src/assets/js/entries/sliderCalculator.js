function dc(a) {
    r = a,
    jQuery("#loanproduct").val(r),
    "active" != jQuery("li#" + r).attr("class") && jQuery("li#" + r).addClass("active").siblings().removeClass("active"),
    jQuery("ul.loanproduct-nav li").click(function() {
        return "active" != jQuery(this).attr("class") && (jQuery(this).addClass("active").siblings().removeClass("active"),
        r = jQuery(this).attr("id"),
        jQuery("#loanproduct").val(r),
        "home-loan" == r ? ic("Home Loan Amount", 5000000, 10000, 5e6, 20, 2500000, 30, .5, 240) : "personal-loan" == r ? ic("Personal Loan Amount", 15e5, 1e4, 35e4, 25, 17.5, 5, .25, 36) : "car-loan" == r && ic("Car Loan Amount", 2e6, 1e4, 4e5, 20, 12.5, 7, .25, 60))
        !1
    })
}
function kc() {
    jQuery("#loanamount").blur(function() {
        jQuery("#loanamount").val(Globalize.format(Math.round(jQuery("#loanamount").val().replace(/[^\d\.]/g, "")), "n", "en-IN"))
    }),
    jQuery("#loanamount_one").blur(function() {
        jQuery("#loanamount_one").val(Globalize.format(Math.round(jQuery("#loanamount_one").val().replace(/[^\d\.]/g, "")), "n", "en-IN"))
    }),
    jQuery("#loanamount_two").blur(function() {
        jQuery("#loanamount_two").val(Globalize.format(Math.round(jQuery("#loanamount_two").val().replace(/[^\d\.]/g, "")), "n", "en-IN"))
    }),
    jQuery("#loanamount_three").blur(function() {
        jQuery("#loanamount_three").val(Globalize.format(Math.round(jQuery("#loanamount_three").val().replace(/[^\d\.]/g, "")), "n", "en-IN"))
    }),
    jQuery("#Homeloanamount_one").blur(function() {
        jQuery("#Homeloanamount_one").val(Globalize.format(Math.round(jQuery("#Homeloanamount_one").val().replace(/[^\d\.]/g, "")), "n", "en-IN"))
    }),
    jQuery("#Homeloanamount_two").blur(function() {
        jQuery("#Homeloanamount_two").val(Globalize.format(Math.round(jQuery("#Homeloanamount_two").val().replace(/[^\d\.]/g, "")), "n", "en-IN"))
    }),
    jQuery("#Homeloanamount_three").blur(function() {
        jQuery("#Homeloanamount_three").val(Globalize.format(Math.round(jQuery("#Homeloanamount_three").val().replace(/[^\d\.]/g, "")), "n", "en-IN"))
    }),
    
    jQuery("#loaninterest").blur(function() {
        jQuery("#loaninterest").val(Math.round(1e3 * jQuery("#loaninterest").val().replace(/[^\d\.]/g, "")) / 1e3)
    }),
    jQuery("#loanterm").blur(function() {
        jQuery("#loanterm").val(jQuery("#emicalculatorform input[name='loantenure']")[0].checked ? Math.round(Math.round(12 * jQuery("#loanterm").val().replace(/[^\d\.]/g, "")) / 12 * 100) / 100 : jQuery("#loanterm").val().replace(/[^\d\.]/g, ""))
    })
}
function gc(a) {
    var e = jQuery("#emicalculatorform").find(":input").get();
    return "object" != typeof a ? (a = {},
    jQuery.each(e, function() {
        this.name && (this.checked || /select|textarea/i.test(this.nodeName) || /text|hidden|password/i.test(this.type)) && "loandata" != this.name && (a[this.name] = jQuery(this).val())
    }),
    a) : (jQuery.each(e, function() {
        this.name && a[this.name] ? "checkbox" == this.type || "radio" == this.type ? (jQuery(this).prop("checked", a[this.name] == jQuery(this).val()),
        a[this.name] == jQuery(this).val() ? (jQuery(this).parent(".btn").addClass("active"),
        jQuery(this).parent(".btn").siblings("input[name=" + this.name + "]").removeClass("active")) : (jQuery(this).parent(".btn").removeClass("active"),
        jQuery(this).parent(".btn").siblings("input[name=" + this.name + "]").addClass("active"))) : jQuery(this).val(a[this.name]) : "checkbox" == this.type && jQuery(this).prop("checked", !1)
    }),
    jQuery(this))
}


function nc(a, e, s, n, t) {
    Tb = jQuery("#loanamountslider").slider({
        range: "min",
        value: 50000,
        min: 0,
        max: a,
        step: e,
        slide: function(a, e) {
            if(e.value< s)
            {
                return false;
            }

            jQuery("#loanamount").val(Globalize.format(Math.round(e.value), "n", "en-IN"));
        },
        change: function(a) {
            a.originalEvent 
        }
    }),
    Tb.slider("value", Tb.slider("value"))
    jQuery("#loanamount").val(s);
   
}

function PersonalloanSlider(max,step,minval){
    Ub = jQuery("#loanamounttslider_one").slider({
        range: "min",
        value: 50000,
        min: 0,
        max: max,
        step: step,
        slide: function(max, step) {
            if(step.value< minval)
            {
                return false;
            }
            jQuery("#loanamount_one").val(Globalize.format(Math.round(step.value), "n", "en-IN"));
        },
        change: function(a) {
            max.originalEvent
        }
    }),
    Ub.slider("value", Ub.slider("value"))
    jQuery("#loanamount_one").val(minval);
}
function sliderTwo(max,step,minval){
    St = jQuery("#loanamounttslider_two").slider({
        range: "min",
        value: 50000,
        min: 0,
        max: max,
        step: step,
        slide: function(max, step) {
            if(step.value< minval)
            {
                return false;
            }
            jQuery("#loanamount_two").val(Globalize.format(Math.round(step.value), "n", "en-IN"));
        },
        change: function(a) {
            max.originalEvent
        }
    }),
    St.slider("value", St.slider("value"))
    jQuery("#loanamount_two").val(minval);
}

function sliderThree(max,step,minval){
    Sh = jQuery("#loanamounttslider_three").slider({
        range: "min",
        value: 50000,
        min: 0,
        max: max,
        step: step,
        slide: function(max, step) {
            if(step.value< minval)
            {
                return false;
            }
            jQuery("#loanamount_three").val(Globalize.format(Math.round(step.value), "n", "en-IN"))
        },
        change: function(a) {
            max.originalEvent
        }
    }),
    Sh.slider("value", Sh.slider("value"));
    jQuery("#loanamount_three").val(minval);
}


function HomeLoanSliderOne(max,step,minval){
    Hs = jQuery("#Homeloanamounttslider_one").slider({
        range: "min",
        value: 1000000,
        min: 0,
        max: max,
        step: step,
        slide: function(max, step) {
            if(step.value< minval)
            {
                return false;
            }
            jQuery("#Homeloanamount_one").val(Globalize.format(Math.round(step.value), "n", "en-IN"))
           
        },
        change: function(a) {
            max.originalEvent
        }
    }),
    Hs.slider("value", Hs.slider("value"))
    jQuery("#Homeloanamounttslider_one").val(1000000);
}


function HomeLoanSlidertwo(max,step,minval){
    Ht = jQuery("#Homeloanamounttslider_two").slider({
        range: "min",
        value: 1000000,
        min: 0,
        max: max,
        step: step,
        slide: function(max, step) {
            if(step.value< minval)
            {
                return false;
            }
            jQuery("#Homeloanamount_two").val(Globalize.format(Math.round(step.value), "n", "en-IN"))
        },
        change: function(a) {
            max.originalEvent
        }
    }),
    Ht.slider("value", Ht.slider("value"))
    jQuery("#Homeloanamounttslider_two").val(1000000);
}


function HomeLoanSliderthree(max,step,minval){
    Hl = jQuery("#Homeloanamounttslider_three").slider({
        range: "min",
        value: 1000000,
        min: 0,
        max: max,
        step: step,
        slide: function(max, step) {
            if(step.value< minval)
            {
                return false;
            }
            jQuery("#Homeloanamount_three").val(Globalize.format(Math.round(step.value), "n", "en-IN"))
        },
        change: function(a) {
            max.originalEvent
        }
    }),
    Hl.slider("value", Hl.slider("value"))
    jQuery("#Homeloanamounttslider_three").val(1000000);
}

function hc() {
    jQuery("#loanamount").change(function() {
        Tb.slider("value", this.value.replace(/[^\d\.]/g, ""))
    })

    jQuery("#loanamount_one").change(function() {
        Ub.slider("value", this.value.replace(/[^\d\.]/g, ""))
    })

    jQuery("#loanamount_two").change(function() {
        St.slider("value", this.value.replace(/[^\d\.]/g, ""))
    })

    jQuery("#loanamount_three").change(function() {
        Sh.slider("value", this.value.replace(/[^\d\.]/g, ""))
    })
    jQuery("#Homeloanamount_one").change(function() {
        Hs.slider("value", this.value.replace(/[^\d\.]/g, ""))
    })
    jQuery("#Homeloanamount_two").change(function() {
        Ht.slider("value", this.value.replace(/[^\d\.]/g, ""))
    })
    jQuery("#Homeloanamount_three").change(function() {
        Hl.slider("value", this.value.replace(/[^\d\.]/g, ""))
    })
    
}
function ic(a, e, s, n, t, l, c, i, o) {
    jQuery("label[for=loanamount]").html("<strong>" + a + "</strong>"),
    jQuery("#loanamount").val(Globalize.format(n, "n", "en-IN")),
    jQuery("#loaninterest").val(1e3 * l / 1e3),
      nc(e, s, n, c, i),
    hc(),
    pc(),
    "car-loan" == r ? jQuery(".toggle-hidden").removeClass("toggle-hidden").addClass("toggle-visible") : jQuery(".toggle-visible").removeClass("toggle-visible").addClass("toggle-hidden"),
    "home-loan" == r ? (jQuery(".bbhomeloan").removeClass("hide_element").addClass("show_element"),
    jQuery(".bbpersonalloan").removeClass("show_element").addClass("hide_element"),
    jQuery(".bbcarloan").removeClass("show_element").addClass("hide_element")) : "personal-loan" == r ? (jQuery(".bbpersonalloan").removeClass("hide_element").addClass("show_element"),
    jQuery(".bbhomeloan").removeClass("show_element").addClass("hide_element"),
    jQuery(".bbcarloan").removeClass("show_element").addClass("hide_element")) : "car-loan" == r && (jQuery(".bbcarloan").removeClass("hide_element").addClass("show_element"),
    jQuery(".bbhomeloan").removeClass("show_element").addClass("hide_element"),
    jQuery(".bbpersonalloan").removeClass("show_element").addClass("hide_element"))
}
function pc() {
     jQuery("#loanamountsteps").html('<span class="tick" style="left: 0%;">|<br/><span class="marker">0</span></span><span class="tick hidden-xs" style="left: 10%;">|<br/><span class="marker">5L</span></span><span class="tick" style="left: 20%;">|<br/><span class="marker">10L</span></span><span class="tick hidden-xs" style="left: 30%;">|<br/><span class="marker">15L</span></span><span class="tick" style="left: 40%;">|<br/><span class="marker">20L</span></span><span class="tick hidden-xs" style="left: 50%;">|<br/><span class="marker">25L</span></span><span class="tick" style="left: 60%;">|<br/><span class="marker">30L</span></span><span class="tick hidden-xs" style="left: 70%;">|<br/><span class="marker">35L</span></span><span class="tick" style="left: 80%;">|<br/><span class="marker">40L</span></span><span class="tick hidden-xs" style="left: 90%;">|<br/><span class="marker">45L</span></span><span class="tick" style="left: 100%;">|<br/><span class="marker">50L</span></span>')
     jQuery("#loanamounttslider_onesteps").html('<span class="tick" style="left: 0%;">|<br/><span class="marker">0</span></span><span class="tick hidden-xs" style="left: 10%;">|<br/><span class="marker">5L</span></span><span class="tick" style="left: 20%;">|<br/><span class="marker">10L</span></span><span class="tick hidden-xs" style="left: 30%;">|<br/><span class="marker">15L</span></span><span class="tick" style="left: 40%;">|<br/><span class="marker">20L</span></span><span class="tick hidden-xs" style="left: 50%;">|<br/><span class="marker">25L</span></span><span class="tick" style="left: 60%;">|<br/><span class="marker">30L</span></span><span class="tick hidden-xs" style="left: 70%;">|<br/><span class="marker">35L</span></span><span class="tick" style="left: 80%;">|<br/><span class="marker">40L</span></span><span class="tick hidden-xs" style="left: 90%;">|<br/><span class="marker">45L</span></span><span class="tick" style="left: 100%;">|<br/><span class="marker">50L</span></span>')
     jQuery("#loanamounttslider_twosteps").html('<span class="tick" style="left: 0%;">|<br/><span class="marker">0</span></span><span class="tick hidden-xs" style="left: 10%;">|<br/><span class="marker">5L</span></span><span class="tick" style="left: 20%;">|<br/><span class="marker">10L</span></span><span class="tick hidden-xs" style="left: 30%;">|<br/><span class="marker">15L</span></span><span class="tick" style="left: 40%;">|<br/><span class="marker">20L</span></span><span class="tick hidden-xs" style="left: 50%;">|<br/><span class="marker">25L</span></span><span class="tick" style="left: 60%;">|<br/><span class="marker">30L</span></span><span class="tick hidden-xs" style="left: 70%;">|<br/><span class="marker">35L</span></span><span class="tick" style="left: 80%;">|<br/><span class="marker">40L</span></span><span class="tick hidden-xs" style="left: 90%;">|<br/><span class="marker">45L</span></span><span class="tick" style="left: 100%;">|<br/><span class="marker">50L</span></span>')
    jQuery("#loanamounttslider_threesteps").html('<span class="tick" style="left: 0%;">|<br/><span class="marker">0</span></span><span class="tick hidden-xs" style="left: 10%;">|<br/><span class="marker">5L</span></span><span class="tick" style="left: 20%;">|<br/><span class="marker">10L</span></span><span class="tick hidden-xs" style="left: 30%;">|<br/><span class="marker">15L</span></span><span class="tick" style="left: 40%;">|<br/><span class="marker">20L</span></span><span class="tick hidden-xs" style="left: 50%;">|<br/><span class="marker">25L</span></span><span class="tick" style="left: 60%;">|<br/><span class="marker">30L</span></span><span class="tick hidden-xs" style="left: 70%;">|<br/><span class="marker">35L</span></span><span class="tick" style="left: 80%;">|<br/><span class="marker">40L</span></span><span class="tick hidden-xs" style="left: 90%;">|<br/><span class="marker">45L</span></span><span class="tick" style="left: 100%;">|<br/><span class="marker">50L</span></span>')
    jQuery("#Homeloanamounttslider_onesteps").html('<span class="tick" style="left: 0%;">|<br /><span class="marker">0</span></span><span class="tick hidden-xs" style="left: 10%;">|<br /> <span class="marker">10L</span></span><span class="tick" style="left: 20%;">|<br /><span class="marker">20L</span></span><span class="tick hidden-xs" style="left: 30%;">|<br /><span class="marker">30L</span></span><span class="tick" style="left: 40%;">|<br /><span class="marker">40L</span></span><span class="tick hidden-xs" style="left: 50%;">|<br /><span class="marker">50L</span></span><span class="tick" style="left: 60%;">|<br /><span class="marker">60L</span></span><span class="tick hidden-xs" style="left: 70%;">|<br /><span class="marker">70L</span></span><span class="tick" style="left: 80%;">|<br /><span class="marker">80L</span></span><span class="tick hidden-xs" style="left: 90%;">|<br /><span class="marker">90L</span></span><span class="tick" style="left: 100%;">|<br /><span class="marker">1CR</span></span>')
    jQuery("#Homeloanamounttslider_twosteps").html('<span class="tick" style="left: 0%;">|<br /><span class="marker">0</span></span><span class="tick hidden-xs" style="left: 10%;">|<br /> <span class="marker">10L</span></span><span class="tick" style="left: 20%;">|<br /><span class="marker">20L</span></span><span class="tick hidden-xs" style="left: 30%;">|<br /><span class="marker">30L</span></span><span class="tick" style="left: 40%;">|<br /><span class="marker">40L</span></span><span class="tick hidden-xs" style="left: 50%;">|<br /><span class="marker">50L</span></span><span class="tick" style="left: 60%;">|<br /><span class="marker">60L</span></span><span class="tick hidden-xs" style="left: 70%;">|<br /><span class="marker">70L</span></span><span class="tick" style="left: 80%;">|<br /><span class="marker">80L</span></span><span class="tick hidden-xs" style="left: 90%;">|<br /><span class="marker">90L</span></span><span class="tick" style="left: 100%;">|<br /><span class="marker">1CR</span></span>')
    jQuery("#Homeloanamounttslider_threesteps").html('<span class="tick" style="left: 0%;">|<br /><span class="marker">0</span></span><span class="tick hidden-xs" style="left: 10%;">|<br /> <span class="marker">10L</span></span><span class="tick" style="left: 20%;">|<br /><span class="marker">20L</span></span><span class="tick hidden-xs" style="left: 30%;">|<br /><span class="marker">30L</span></span><span class="tick" style="left: 40%;">|<br /><span class="marker">40L</span></span><span class="tick hidden-xs" style="left: 50%;">|<br /><span class="marker">50L</span></span><span class="tick" style="left: 60%;">|<br /><span class="marker">60L</span></span><span class="tick hidden-xs" style="left: 70%;">|<br /><span class="marker">70L</span></span><span class="tick" style="left: 80%;">|<br /><span class="marker">80L</span></span><span class="tick hidden-xs" style="left: 90%;">|<br /><span class="marker">90L</span></span><span class="tick" style="left: 100%;">|<br /><span class="marker">1CR</span></span>')
    
     
}

function loanIntereststeps() {
    jQuery("#loanamounttslidersteps").html('<span class="tick" style="left: 0%;">|<br/><span class="marker">0</span></span><span class="tick hidden-xs" style="left: 10%;">|<br/><span class="marker">5L</span></span><span class="tick" style="left: 20%;">|<br/><span class="marker">10L</span></span><span class="tick hidden-xs" style="left: 30%;">|<br/><span class="marker">15L</span></span><span class="tick" style="left: 40%;">|<br/><span class="marker">20L</span></span><span class="tick hidden-xs" style="left: 50%;">|<br/><span class="marker">25L</span></span><span class="tick" style="left: 60%;">|<br/><span class="marker">30L</span></span><span class="tick hidden-xs" style="left: 70%;">|<br/><span class="marker">35L</span></span><span class="tick" style="left: 80%;">|<br/><span class="marker">40L</span></span><span class="tick hidden-xs" style="left: 90%;">|<br/><span class="marker">45L</span></span><span class="tick" style="left: 100%;">|<br/><span class="marker">50L</span></span>')
    // jQuery("#loanamounttslidersteps").html('<span class="tick" style="left: 0%;">|<br/><span class="marker">0L</span></span><span class="tick hidden-xs" style="left: 5%;">|<br/><span class="marker">25L</span></span><span class="tick" style="left: 10%;">|<br/><span class="marker">50L</span></span><span class="tick hidden-xs" style="left: 15%;">|<br/><span class="marker">75L</span></span><span class="tick" style="left: 20%;">|<br/><span class="marker">100L</span></span><span class="tick hidden-xs" style="left: 25%;">|<br/><span class="marker">125L</span></span><span class="tick" style="left: 30%;">|<br/><span class="marker">150L</span></span><span class="tick hidden-xs" style="left: 35%;">|<br/><span class="marker">175L</span></span><span class="tick" style="left: 40%;">|<br/><span class="marker">200L</span></span><span class="tick hidden-xs" style="left: 45%;">|<br/><span class="marker">225L</span></span><span class="tick" style="left: 50%;">|<br/><span class="marker">250L</span></span><span class="tick hidden-xs" style="left: 55%;">|<br/><span class="marker">275L</span></span><span class="tick" style="left: 60%;">|<br/><span class="marker">300L</span></span><span class="tick hidden-xs" style="left: 65%;">|<br/><span class="marker">325L</span></span><span class="tick" style="left: 70%;">|<br/><span class="marker">350L</span></span><span class="tick hidden-xs" style="left: 75%;">|<br/><span class="marker">375L</span></span><span class="tick" style="left: 80%;">|<br/><span class="marker">400L</span></span><span class="tick hidden-xs" style="left: 85%;">|<br/><span class="marker">425L</span></span><span class="tick" style="left: 90%;">|<br/><span class="marker">450L</span></span><span class="tick hidden-xs" style="left: 95%;">|<br/><span class="marker">475L</span></span><span class="tick" style="left: 100%;">|<br/><span class="marker">500L</span></span>');
   
}

function lc() {
    jQuery(".ecalprint").click(function() {
        return window.print(),
        !1
    })
}

function tc() {
    var a = []
      , e = []
      , s = []
      , n = []
      , t = 0;
    t = 0;
    for (var l = v.length; l > t; t++) {
        var r = v[t];
        a[t] = r,
        e[t] = w[r],
        s[t] = x[r],
        n[t] = Zb[r]
    }
    new Highcharts.Chart({
        chart: {
            renderTo: "emibarchart",
            backgroundColor: "transparent",
            plotBackgroundColor: "transparent",
            defaultSeriesType: "column",
            borderWidth: 0,
            C: 0,
            G: 0
        },
        title: {
            text: ""
        },
        xAxis: {
            categories: a,
            minorTickInterval: "auto",
            tickmarkPlacement: "on",
            labels: {
                rotation: -45,
                align: "right",
                step: 8 < v.length ? 2 : 1,
                style: {
                    font: "normal 9px Verdana, sans-serif"
                },
                formatter: function() {
                    return this.value
                }
            }
        },
        yAxis: [{
            min: 0,
            title: {
                text: "EMI Payment / year"
            },
            stackLabels: {
                enabled: !1,
                style: {
                    fontWeight: "bold",
                    color: Highcharts.theme && Highcharts.theme.j || "gray"
                }
            },
            opposite: !0,
            labels: {
                formatter: function() {
                    return "? " + Globalize.format(this.value, "n", "en-IN")
                }
            }
        }, {
            min: 0,
            title: {
                text: "Balance"
            },
            stackLabels: {
                enabled: !1,
                style: {
                    fontWeight: "bold",
                    color: Highcharts.theme && Highcharts.theme.j || "gray"
                }
            },
            labels: {
                formatter: function() {
                    return "? " + Globalize.format(this.value, "n", "en-IN")
                }
            }
        }],
        legend: {
            align: "center",
            itemMarginBottom: 2,
            itemMarginTop: 2,
            verticalAlign: "bottom",
            floating: !1,
            backgroundColor: "#EEEEEE",
            shadow: !1
        },
        tooltip: {
            formatter: function() {
                return "Balance" == this.series.name ? "<b>Year: " + this.x + "</b><br/>" + this.series.name + " : ? " + Globalize.format(this.y, "n", "en-IN") + "<br/>Loan Paid To Date : " + Globalize.format((d - this.y) / d * 100, "n2", "en-IN") + "%" : "<b>Year : " + this.x + "</b><br/>" + this.series.name + " : ? " + Globalize.format(this.y, "n", "en-IN") + "<br/>Total Payment : ? " + Globalize.format(this.point.stackTotal, "n", "en-IN")
            }
        },
        plotOptions: {
            column: {
                borderWidth: 0,
                stacking: "normal",
                dataLabels: {
                    enabled: !1,
                    color: Highcharts.theme && Highcharts.theme.u || "white"
                }
            }
        },
        series: [{
            name: "Interest",
            data: s,
            yAxis: 0,
            legendIndex: 2,
            color: "#ED8C2B"
        }, {
            name: "Principal",
            data: e,
            yAxis: 0,
            legendIndex: 1,
            color: "#88A825"
        }, {
            name: "Balance",
            data: n,
            type: "spline",
            yAxis: 1,
            legendIndex: 3,
            color: "#B8204C"
        }]
    })
}
function uc() {
    q = '<table><tr><th class="col-xs-2 col-md-1" id="yearheader">Year</th><th class="col-sm-2 hidden-xs" id="principalheader">Principal<br/>(A)</th><th class="col-xs-3 col-sm-2 visible-xs" id="principalheader">Principal</th><th class="col-sm-2 hidden-xs" id="interestheader">Interest<br/>(B)</th><th class="col-xs-3 col-sm-2 visible-xs" id="interestheader">Interest</th><th class="col-sm-3 hidden-xs" id="totalheader">Total Payment<br/>(A + B)</th><th class="col-xs-4 col-sm-3" id="balanceheader">Balance</th><th class="col-md-1 hidden-xs hidden-sm" id="paidtodateheader">Loan Paid To Date</th></tr>';
    for (var a = 0, e = 0, s = v.length; s > e; e++) {
        var n = v[e];
        q += '<tr class="yearlypaymentdetails"><td id="year' + n + '" class="col-xs-2 col-md-1 paymentyear toggle">' + n + '</td><td class="col-xs-3 col-sm-2 currency">? ' + Globalize.format(w[n], "n", "en-IN") + '</td><td class="col-xs-3 col-sm-2 currency">? ' + Globalize.format(x[n], "n", "en-IN") + '</td><td class="col-sm-3 hidden-xs currency">? ' + Globalize.format(w[n] + x[n], "n", "en-IN") + '</td><td class="col-xs-4 col-sm-3 currency">? ' + Globalize.format(Zb[n], "n", "en-IN") + '</td><td class="col-md-1 hidden-xs hidden-sm paidtodateyear">' + Globalize.format($b[n], "n2", "en-IN") + "%</td></tr>",
        q += '<tr id="monthyear' + n + '" class="monthlypaymentdetails"><td class="row monthyearwrapper" colspan="6"><div class="monthlypaymentcontainer"><table>';
        for (var t = y.length; t > a && y[a].getFullYear() == n; )
            q += '<tr><td class="col-xs-2 col-md-1 paymentmonthyear">' + cc[y[a].getMonth()] + '</td><td class="col-xs-3 col-sm-2 currency">? ' + Globalize.format(z[a], "n", "en-IN") + '</td><td class="col-xs-3 col-sm-2 currency">? ' + Globalize.format(U[a], "n", "en-IN") + '</td><td class="col-sm-3 hidden-xs currency">? ' + Globalize.format(z[a] + U[a], "n", "en-IN") + '</td><td class="col-xs-4 col-sm-3 currency">? ' + Globalize.format(V[a], "n", "en-IN") + '</td><td class="col-md-1 hidden-xs hidden-sm paidtodatemonthyear">' + Globalize.format(bc[a++], "n2", "en-IN") + "%</td></tr>";
        q += "</table></div></td></tr>"
    }
    q += "</table>",
    jQuery("#emipaymenttable").html(q),
    jQuery("#emipaymenttable tr.monthlypaymentdetails").find("div").hide(),
    jQuery("#emipaymenttable td.toggle").click(function() {
        var a = jQuery(this).attr("id");
        jQuery(this).toggleClass("toggle-open"),
        jQuery("tr#month" + a).find("div").slideToggle()
    })
}
function sc() {
    new Highcharts.Chart({
        chart: {
            renderTo: "emipiechart",
            backgroundColor: "transparent",
            plotBackgroundColor: "transparent",
            borderWidth: null,
            plotBorderWidth: null,
            plotShadow: !1
        },
        title: {
            text: "Break-up of Total Payment"
        },
        tooltip: {
            formatter: function() {
                return "<b>" + this.point.name + ": " + Math.round(10 * this.percentage) / 10 + "%</b>"
            }
        },
        plotOptions: {
            pie: {
                borderWidth: 0,
                startAngle: 0,
                allowPointSelect: !0,
                cursor: "pointer",
                dataLabels: {
                    style: {
                        textShadow: !1
                    },
                    enabled: !0,
                    distance: -30,
                    color: "#FFFFFF",
                    formatter: function() {
                        return "<b>" + Math.round(10 * this.percentage) / 10 + "%</b>"
                    }
                },
                showInLegend: !0
            }
        },
        series: [{
            type: "pie",
            name: "Principal Loan Amount vs. Total Interest",
            data: [{
                name: "Principal Loan Amount",
                y: d,
                color: "#88A825"
            }, {
                name: "Total Interest",
                y: n * k - d,
                sliced: !0,
                selected: !0,
                color: "#ED8C2B"
            }]
        }]
    })
}
var d, f, k, n, cb, db = {
    c: new Date
}, q, r, Tb, Ub, Vb, Xb, Yb, v = [], w = [], x = [], Zb = [], $b = [], y = [], z = [], U = [], V = [], bc = [], cc = "Jan Feb Mar Apr May Jun Jul Aug Sep Oct Nov Dec".split(" ");

