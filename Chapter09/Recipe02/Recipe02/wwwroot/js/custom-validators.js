$(function ($) {
    "use strict";
    $.validator.addMethod('confirmvalue',
        function (value, element, params) {
            var expectedValue = params.expectedvalue;
            if (!expectedValue) return false;
            var actual;
            if (element.type === "checkbox") {
                actual = element.checked;
                expectedValue = expectedValue === "True" ? true : false;
            } else {
                actual = element.value;
            }

            if (expectedValue === actual) {
                return true;
            }
            return false;
        });

    $.validator.unobtrusive.adapters.add('confirmvalue',
        ['expectedvalue'],
        function (options) {
            options.rules['confirmvalue'] = { expectedvalue : options.params['expectedvalue'] };
            options.messages['confirmvalue'] = options.message;
        });
}(jQuery));