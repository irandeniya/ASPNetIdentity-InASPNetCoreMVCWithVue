<template>
    <div id="product">
        <h1>Product Create -Vue</h1>
        <h3>Are you sure you want to delete this?</h3>
        <dl class="row">
            <dt class="col-sm-2">
                <label>Name</label>
            </dt>
            <dd class="col-sm-10">
                {{Product.Name}}
            </dd>
            <dt class="col-sm-2">
                <label>Price</label>
            </dt>
            <dd class="col-sm-10">
                {{Product.Price}}
            </dd>
        </dl>

        <form :action="DeleteUrl" method="post">
            <input type="hidden" name="Id" :value="Product.Id" />
            <input type="submit" value="Delete" class="btn btn-danger" /> |
            <a :href="IndexUrl">Back to List</a>
        </form>
    </div>
</template>
<script>
    export default {
        name: "product-create-component",
        props: {
            DeleteUrl: String,
            IndexUrl: String,
            Product: Object
        }
    };
</script>