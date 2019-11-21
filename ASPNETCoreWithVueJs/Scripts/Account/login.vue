<template>
    <div id="login">
        <h1>Login -Vue</h1>
        <form :action="LoginUrl" method="post">
            <div class="row">
                <div class="col-md-4">
                    <div class="text-danger"></div>
                    <div class="form-group">
                        <label for="Username" class="control-label">Username</label>
                        <input name="Username" class="form-control" />
                    </div>
                    <div class="form-group">
                        <label for="Password" class="control-label">Password</label>
                        <input name="Password" class="form-control" />
                    </div>
                    <div class="form-group">
                        <input type="submit" value="Login" class="btn btn-primary" />
                    </div>
                </div>
            </div>
        </form>
    </div>
</template>
<script>
    export default {
        name: "login-component",
        props: {
            LoginUrl: String
        }
    };
</script>