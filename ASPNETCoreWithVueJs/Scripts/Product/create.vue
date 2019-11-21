<template>
    <div id="product">
        <h1>Product Create -Vue</h1>
        <form :action="CreateProductUrl" method="post">
            <div class="row">
                <div class="col-md-4">
                    <div class="text-danger"></div>
                    <div class="form-group">
                        <label for="Name" class="control-label">Product Name</label>
                        <input name="Name" class="form-control" />
                    </div>
                    <div class="form-group">
                        <label for="Price" class="control-label">Price</label>
                        <input name="Price" class="form-control" />
                    </div>
                    <div class="form-group">
                        <input type="submit" value="Create" class="btn btn-primary" />
                    </div>
                </div>
            </div>
        </form>
    </div>
</template>
<script>
    export default {
        name: "product-create-component",
        props: {
            CreateProductUrl: String
        }
    };
</script>