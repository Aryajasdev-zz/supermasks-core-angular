/*global angular */
(function (angular) {
    'use strict';
    angular.module('countdownTimer', [])
        .directive('countdown', function ($interval, dateFilter) {
            return {
                restrict: 'A',
                transclude: true,
                link: function (scope, element, attrs) {
                    var countDownInterval;
                    function displayString() {                        
                        attrs.units = angular.isArray(attrs.units) ?  attrs.units : attrs.units.split('|');
                        var lastUnit = attrs.units[attrs.units.length - 1],
                            unitConstantForMillisecs = {
                                weeks: (1000 * 60 * 60 * 24 * 7),
                                days: (1000 * 60 * 60 * 24),
                                hours: (1000 * 60 * 60),
                                minutes: (1000 * 60),
                                seconds: 1000,
                                milliseconds: 1
                            },
                            unitsLeft = {},
                            returnString = '',
                            totalMillisecsLeft = new Date(attrs.endDate) - new Date(),
                            i,
                            unit;
                            for (i in attrs.units) {
                                //added by HM Dadou 
                                if(new Date(attrs.endDate) - new Date()<= 0) {
                                    returnString = "<ul class=\"sidebar-timer hidden-xs\"><li class=\"timer-end vs info\"><i class=\"fa fa-truck\"></i>&nbsp;&nbsp;  Your order  will be dispatched on Thursday</li></ul>";
                                }else{
                                    if (attrs.units.hasOwnProperty(i)) {
                                        //validation
                                        unit = attrs.units[i].trim();
                                        if (unitConstantForMillisecs[unit.toLowerCase()] === false) {
                                            $interval.cancel(countDownInterval);
                                            throw new Error('Cannot repeat unit: ' + unit);
                                        }
                                        if (unitConstantForMillisecs.hasOwnProperty(unit.toLowerCase()) === false) {
                                            $interval.cancel(countDownInterval);
                                            throw new Error('Unit: ' + unit + ' is not supported. Please use following units: weeks, days, hours, minutes, seconds, milliseconds');
                                        }

                                        //saving unit left into object
                                        unitsLeft[unit] = totalMillisecsLeft / unitConstantForMillisecs[unit.toLowerCase()];
                                        //precise rounding
                                        if (lastUnit === unit) {
                                            unitsLeft[unit] = Math.ceil(unitsLeft[unit]);
                                        } else {
                                            unitsLeft[unit] = Math.floor(unitsLeft[unit]);
                                        }
                                        //updating total time left
                                        totalMillisecsLeft -= unitsLeft[unit] * unitConstantForMillisecs[unit.toLowerCase()];
                                        //setting this value to false for validation of repeated units
                                        unitConstantForMillisecs[unit.toLowerCase()] = false;
                                        //adding verbage
                                        var percentminus = 100 - (Math.floor((unitsLeft[unit]*100)/60));
                                        var percent = Math.floor((unitsLeft[unit]*100)/60);
                                        var degrees = Math.floor((percentminus* 360)/100);
                                        returnString +=' <div class="col-xs-4"><div class="c100 p'+percent+' center"><span>'+unitsLeft[unit]+'</span><div class="slice"><div class="bar"></div><div class="fill"></div></div></div><small>'+unit+'</small></div>';
                                }
                            }
                        }
                        return returnString;
                    }

                    function updateCountDown() {
                        element.html(displayString());
                    }
                    element.on('$destroy', function () {
                        $interval.cancel(countDownInterval);
                    });
                    countDownInterval = $interval(function () {
                        updateCountDown();
                    }, 1);
                }
            };
        });
}(angular));