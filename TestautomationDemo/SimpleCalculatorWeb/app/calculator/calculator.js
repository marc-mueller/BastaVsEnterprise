(function () {
    'use strict';
    var controllerId = 'calculator';
    angular.module('app').controller(controllerId, ['common', 'datacontext', calculator]);

    function calculator(common, datacontext) {
        var getLogFn = common.logger.getLogFn;
        var log = getLogFn(controllerId);

        var vm = this;
        vm.title = 'Calculator';
        vm.firstnumber = 0;
        vm.secondnumber = 0;
        vm.result = 0;
        vm.add = add;
        vm.subtract = subtract;
        vm.multiply = multiply;
        vm.divide = divide;

        activate();

        function activate() {
            var promises = [resetResult()];
            common.activateController(promises, controllerId)
                .then(function () { log('Activated Calculator View'); });
        }

        function resetResult() {
            vm.result = 0;
        }

        function add()
        {
            vm.result = vm.firstnumber + vm.secondnumber;
        }
        function subtract() {
            vm.result = vm.firstnumber - vm.secondnumber;
        }
        function multiply() {
            vm.result = vm.firstnumber * vm.secondnumber;
        }
        function divide() {
            vm.result = vm.firstnumber / vm.secondnumber;
        }

        
    }
})();