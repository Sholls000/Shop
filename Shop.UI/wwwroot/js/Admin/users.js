var app = new Vue({
    el: '#app',
    data: {
        username: ""
    },
    mounted() {
        //TODO: get all users
    },
    methods: {
        createUser() {
            this.loading = true;
            //picks the API route to fetch GetProducts data from the backend as provided by the controller.
            axios.post('/users', { username: this.username })
                .then(res => {
                    //posting the results to the browser console
                    console.log(res);
                })
                //Catching errors and displaying them on browser console
                .catch(err => {
                    console.log(err);
                });
        }
    }

})
