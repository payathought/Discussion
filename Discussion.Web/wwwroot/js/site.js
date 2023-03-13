(() => {
    const _dateHelper = new DateHelper();
    const attachEvents = () => {
        $('body').on('click', '#add-discussion', onAddButtonClicked);
        $('#grid').on('click', '.edit-icon', onEditIconClicked);
        $('#grid').on('click', '.delete-icon', onDeleteIconClicked);
    };
    let setRequestFilters = options => {
        let searchBar = $('#grid-search-bar');
        let searchKeyword = searchBar.val();
        let previousKeyword = searchBar.data('previous');

        if (searchKeyword !== previousKeyword) {
            searchBar.data('previous', searchKeyword);
        }

        if (searchKeyword) {
            options.searchKeyword = searchKeyword;
            options.data.search = searchKeyword;
        }
    };

    let onAddButtonClicked = () => {
        window.location = '/Home/Add';
    };
    let onEditIconClicked = event => {
        let id = event.currentTarget.dataset.id

        window.location = `/Home/Edit/${id}`;
    };
    let onDeleteIconClicked = event => {
        let id = event.currentTarget.dataset.id

        swal.fire({
            title: 'Delete Discussion?',
            text: "Are you sure you want to delete this discussion?",
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            cancelButtonText: 'Cancel',
            confirmButtonText: 'Confirm'
        }).then(async (result) => {
            if (result.isConfirmed) {
                await _apiService.Discussions.delete(id).then(() => {
                    updateGridData();
                });
            }
        });
    };

    let updateGridData = () => {
        let grid = $('#grid').data('kendoGrid');

        grid.dataSource.page(1);
        grid.dataSource.read();
    };

    renderTable = () => {
        $('#grid').kendoGrid({
            dataSource: {
                transport: {
                    read: async (options) => {

                        setRequestFilters(options);
                        let response = await _apiService.Discussions.filter(options.data);

                        if (response.ok) {
                            let data = await response.json();

                            options.success(data);

                        }
                    }
                },
                schema: {
                    data: 'discussion',
                    total: 'total',
                },
                pageSize: 20,
                serverPaging: true,
            },
            pageable: true,
            columns: [
                {
                    title: 'Date',
                    template: data => {
                        return _dateHelper.formatShortLocalDate(data.date);
                    }
                },
                {
                    title: 'Subject',
                    field: 'subject'
                },
                {
                    title: 'Location',
                    field: 'location'
                },
                {
                    title: 'Outcome',
                    field: 'outcomes'
                },
                {
                    title: 'Colleagues',
                    template: data => {
                        console.log(data.colleagues);
                        let users = data.colleagues.map(u => u.name).slice(0, 2).join(', ');
                        console.log(users);

                        if (data.colleagues.length > 2) {
                            users = users + "...";

                            return `
                              <div class="reason-container">
                                    <a  class="reason" href="#" title="${data.colleagues.map(u => u.name).join(', ')}">${users}</a><br />
                                </div>
    
                                `
                        } else {

                            return `
                              <div class="reason-container">
                                    <a  class="reason" href="#" title="${data.colleagues.map(u => u.name).join(', ')}">${users}</a><br />
                                </div>
    
                                `
                        }
                    }
                },
                {
                    title: "Actions",
                    template: data => {

                        return `<i class="action-icon edit-icon fas fa-pencil-alt" data-id="${data.id}" data-toggle="tooltip" title="Edit" ></i>
                            <i class="action-icon delete-icon fa fa-trash-alt" data-id="${data.id}" data-toggle="tooltip" title="Delete" ></i>`;
                    },
                    width: 130
                }],
            dataBound: function (data) {

                $(".reason-container").kendoTooltip({
                    filter: "a[title]",
                    width: "fit-content",
                });


            },
            noRecords: {
                template: "No available data"
            }
        });
    }
    const onWindowLoaded = async () => {
        renderTable();
        attachEvents();
    };


    window.addEventListener('load', onWindowLoaded);
})();