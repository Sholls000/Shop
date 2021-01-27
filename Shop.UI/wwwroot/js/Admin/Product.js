var app = new Vue({
    el: '#app',
    data: {
        
            editing: false,
            loading: false,
            //The Vue declaration for the data input GUI objects

            objectIndex: 0,

            productModel: {
                id: 0,
                name: "Product Name",
                description: "Product Description",
                value: 1.99

            },
            products: []
        
    },
    mounted() {
        this.getProducts();
    },
    methods: {


        getProduct(id) {
            this.loading = true;
            //picks the API route to fetch GetProducts data from the backend as provided by the controller.
            axios.get('/products/' + id)
                .then(res => {
                    //posting the results to the browser console
                    console.log(res);
                    //declaring variable product and binding it to productModel
                    var product = res.data;
                    this.productModel = {
                        id: product.id,
                        name: product.name,
                        description: product.description,
                        value: product.value,
                    };
                })
                //Catching errors and displaying them on browser console
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },

        getProducts() {
            this.loading = true;
            //picks the API route to fetch GetProducts data from the backend as provided by the controller.
            axios.get('/products')
                .then(res => {
                    //posting the results to the browser console
                    console.log(res);
                    //Setting result data to array(prodcuts)
                    this.products = res.data
                })
                //Catching errors and displaying them on browser console
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },
        createProduct() {
            this.loading = true;
            //posting to the API using axios
            axios.post('products', this.productModel)
                .then(res => {

                    //posting the results to the browser console
                    console.log(res.data);
                    this.products.push(res.data);
                })
                //Catching errors and displaying them on browser console
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                    this.editing = false;
                });
        },

        updateProduct() {
            this.loading = true;
            //posting to the API using axios
            axios.put('products', this.productModel)
                .then(res => {

                    //posting the results to the browser console
                    console.log(res.data);
                    this.products.splice(this.objectIndex, 1, res.data);
                })
                //Catching errors and displaying them on browser console
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },

        deleteProduct(id, index) {
            this.loading = true;
            //picks the API route to fetch GetProducts data from the backend as provided by the controller.
            axios.delete('/products/' + id)
                .then(res => {
                    //posting the results to the browser console
                    console.log(res);
                    //Setting result data to array(prodcuts)
                    this.products.splice(index, 1);
                })
                //Catching errors and displaying them on browser console
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },
        newProduct() {
            this.editing = true;
            this.productModel.id = 0;
        },

        editProduct(id, index) {
            this.objectIndex = index;
            this.getProduct(id);
            this.editing = true;

        },
        cancel() {
            this.editing = false;
        }

    },
    computed: {

    }
    
}); 