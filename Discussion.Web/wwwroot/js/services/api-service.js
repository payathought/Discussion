class ApiService {

    Discussions = {
        filter: params => _apiHelper.get({ url: `discussions?${this.createUrlParam(params)}` }),
        add: params => _apiHelper.post({ url: 'discussions/create', data: params }),
        update: params => _apiHelper.put({
            url: `discussions/update/${params.id || params.Id}`,
            data: params
        }),
        delete: id => _apiHelper.delete({ url: `discussions/${id}` }),
        get: id => _apiHelper.get({ url: `discussions/${id}` }),
    };
    Users = {
        filter: params => _apiHelper.get({ url: `users?${this.createUrlParam(params)}` }),
    };

    createUrlParam(params) {
        var str = "";
        for (var key in params) {


            if ((params[key] || params[key] === 0)) {
                if (str != "") {
                    str += "&";
                }

                str += key + "=" + encodeURIComponent(params[key]);
            }
        }

        return str;
    }
}
