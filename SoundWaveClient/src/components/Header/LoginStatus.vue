<template>
    <div>
        <Button v-if="status==false">Login</Button>
        <AccountLogin v-else></AccountLogin>
    </div>
</template>

<script>

export default{
    name:'LoginStatus',
    data(){
        return{
            status:true
    }
 
    },
    methods:{

    }
}

</script>

<style scoped>

</style>