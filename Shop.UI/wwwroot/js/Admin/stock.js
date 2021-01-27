var app = new Vue({
    el: '#app',
    data: {
        products: [],
        selectedProduct: null,
        newStock: {
            productId: 0,
            description: "Size",
            qty: 10
        }
    },
    mounted() {
        this.getStock();
    },
    methods: {
        getStock() {
            this.loading = true;
            //picks the API route to fetch GetProducts data from the backend as provided by the controller.
            axios.get('/stocks')
                .then(res => {
                    //posting the results to the browser console
                    console.log(res);
                    //Setting result data to array(prodcuts)
                    this.products = res.data;
                })
                //Catching errors and displaying them on browser console
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },
        updateStock() {
            this.loading = true;

            //picks the API route to fetch GetProducts data from the backend as provided by the controller.
            axios.put('/stocks', {
                stock: this.selectedProduct.stock.map(x => {
                    return {
                        id: x.id,
                        description: x.description,
                        qty: x.qty,
                        productId: this.selectedProduct.id
                    };
                })
            })
                .then(res => {
                    //posting the results to the browser console
                    console.log(res);
                    //Setting result data to array(prodcuts)
                    this.selectedProduct.stock.splice(index, 1);
                })
                //Catching errors and displaying them on browser console
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });

        },
        deleteStock(id, index) {
            this.loading = true;

            //picks the API route to fetch GetProducts data from the backend as provided by the controller.
            axios.delete('/stocks/' + id)
                .then(res => {
                    //posting the results to the browser console
                    console.log(res);
                    //Setting result data to array(prodcuts)
                    this.selectedProduct.stock.splice(index, 1);
                })
                //Catching errors and displaying them on browser console
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },
        addStock() {
            this.loading = true;

            //picks the API route to fetch GetProducts data from the backend as provided by the controller.
            axios.post('/stocks', this.newStock)
                .then(res => {
                    //posting the results to the browser console
                    console.log(res);
                    //Setting result data to array(prodcuts)
                    this.selectedProduct.stock.push(res.data);
                })
                //Catching errors and displaying them on browser console
                .catch(err => {
                    console.log(err);
                })
                .then(() => {
                    this.loading = false;
                });
        },

        selectProduct(product) {
            this.selectedProduct = product;
            this.newStock.productId = product.id;
        },
    }

});


