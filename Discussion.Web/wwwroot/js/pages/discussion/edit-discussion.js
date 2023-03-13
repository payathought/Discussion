(() => {
    const _formHelper = new FormHelper();
    const _form = document.getElementById('form');
    const _comboBoxHelper = new ComboBoxHelper();

    const _id = $('#Id').val();

    const attachEvents = () => {
        _form.addEventListener('submit', onFormSubmitted);
    };
    let onFormSubmitted = async (e) => {
        e.preventDefault();
        let submitButton = document.getElementById('submit');

            submitButton.disabled = true;

            let data = _formHelper.toJsonString(_form);
             data.ColleaugesId = $("#ColleaugesId").data("kendoMultiSelect").value();
             var response = await _apiService.Discussions.update(data);

            if (response.ok) {
                window.location = '/Home/Index/'
            }
            else {
                toastr.error('An error has occurred');
            }

            submitButton.disabled = false;
        
    };

    let getDiscussion = async () => {
        let response = await _apiService.Discussions.get(_id);

      
        if (response.ok) {
            let data = await response.json();
            _formHelper.populateForm(data);
            $("#ColleaugesId").data("kendoMultiSelect").value(data.colleaugesId);
        }
    };

    let renderComboBoxes = () => {
        _comboBoxHelper.render('ObserverId', {
            dataValueField: "id",
            dataTextField: "name",
            placeholder: "Select One"
        });
    };
    let renderWidgets = () => {
        renderComboBoxes();
        renderDatePickers();
        renderMultiSelect();
      
    };
    let renderMultiSelect = () => {

        $("#ColleaugesId").kendoMultiSelect({
            placeholder: "Select Colleagues...",
            dataTextField: "name",
            dataValueField: "id",
            filter: "contains",
            height: 180,
            dataSource: [],
            animation: {
                close: {
                    effects: "fadeOut",
                    duration: 10
                },
                open: {
                    effects: "fadeIn",
                    duration: 10
                }
            },
            dataBound: () => {

            }

        });
    }
    let getEmployees = async () => {
        let response = await _apiService.Users.filter();

        if (response.ok) {
            let data = await response.json();
            _comboBoxHelper.setDataSource('ObserverId', data);
            let multiselect = $("#ColleaugesId").data("kendoMultiSelect");
            multiselect.value('');
            multiselect.setDataSource(data);
        }
    };
    let renderDatePickers = () => {
        $("#Date").kendoDatePicker({
           
        });
    };

    const onWindowLoaded = async () => {
        attachEvents();
       await renderWidgets();
        await getEmployees();
        await getDiscussion();
    };

    window.addEventListener('load', onWindowLoaded);
})();