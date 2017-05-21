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
            // Add validation rule for HTML elements that contain data-confirmvalue attribute
            options.rules['confirmvalue'] = {
                // pass the data from data-confirmvalue-expectedvalue to 
                // the params argument of the confirmvalue method
                expectedvalue: options.params['expectedvalue']
            };
            // get the error message from data-confirmvalue-expectedvalue
            // so that unobtrusive validation can use it when validation rule fails
            options.messages['confirmvalue'] = options.message;
        });
}(jQuery));