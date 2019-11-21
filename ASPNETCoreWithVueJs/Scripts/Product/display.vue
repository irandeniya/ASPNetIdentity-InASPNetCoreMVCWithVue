<template>
    <div id="product">
        <h1>Product Details -Vue</h1>
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
        <div>
            <a :href="EditUrl">Edit</a> |
            <a :href="IndexUrl">Back to List</a>
        </div>

    </div>
</template>
<script>
    export default {
        name: "product-create-component",
        props: {
            EditUrl: String,
            IndexUrl: String,
            Product: Object
        }
    };
</script>