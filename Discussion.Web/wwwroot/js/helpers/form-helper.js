class FormHelper {
    _dateHelper = new DateHelper();
    _stringHelper = new StringHelper();

    toJsonString = form => {
        let obj = {};
        let elements = form.querySelectorAll("input, select, textarea");

        for (let element of elements) {
            let name = element.name;
            let value = element.value;

            if (name) {
                obj[name] = value;
            }
        }

        return obj;
    }

    populateForm = data => {
        for (let key in data) {
            let element = $(`#${this._stringHelper.camelToPascal(key)}`);

            switch (element.data('role')) {
                case 'datepicker':
                    element.data('kendoDatePicker').value(data[key]);
                    break;
                case 'dropdownlist':
                    element.data('kendoDropDownList').value(data[key]);
                    break;
                case 'combobox':
                    element.data('kendoComboBox').value(data[key]);
                    break;
                case 'datetimepicker':
                    element.data('kendoDateTimePicker').value(data[key]);
                    break;
                case 'timepicker':
                    element.data('kendoTimePicker').value(data[key]);
                    break;
                default:
                    if (element.is(':checkbox') || element.is(':radio'))
                        element.prop('checked', data[key])
                    else
                        element.val(data[key]);
            }
        }
    }
}