class ApiHelper {

    constructor() {
        this.baseApiUrl = document.getElementById('base-api-url').value;
    }

    jsonRequest = async (method, params) => {
        let response = await fetch(`${this.baseApiUrl}/${params.url}`, {
            method: method,
            headers: {
                'Content-Type': 'application/json',
            },
            body: JSON.stringify(params.data)
        });

        if (response.status === 401) {
            this.logOut();
        }

        return response;
    };

    get = async params => await this.jsonRequest('GET', params);

    post = async params => await this.jsonRequest('POST', params);

    put = async params => await this.jsonRequest('PUT', params);

    patch = async params => await this.jsonRequest('PATCH', params);

    delete = async params => await this.jsonRequest('DELETE', params);

}