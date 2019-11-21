<template>
    <div id="product">
        <h1>Product Edit -Vue</h1>
        <form :action="EditUrl" method="post">
            <input type="hidden" name="Id" :value="Product.Id" />
            <div class="row">
                <div class="col-md-4">
                    <div class="text-danger"></div>
                    <div class="form-group">
                        <label for="Name" class="control-label">Product Name</label>
                        <input name="Name" class="form-control" :value="Product.Name" />
                    </div>
                    <div class="form-group">
                        <label for="Price" class="control-label">Price</label>
                        <input name="Price" class="form-control" :value="Product.Price" />
                    </div>
                    <div class="form-group">
                        <input type="submit" value="Save" class="btn btn-primary" />
                    </div>
                </div>
            </div>
        </form>
    </div>
</template>
<script>
    export default {
        name: "product-edit-component",
        props: {
            EditUrl: String,
            Product: Object
        },
        mounted: function () {
            console.log(this.EditUrl);
            console.log(this.Product);
        }
    };
</script>