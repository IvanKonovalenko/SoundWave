<template>
    <div>
        <Button v-if="logStatus==false">Login</Button>
        <AccountLogin v-else></AccountLogin>
    </div>
</template>

<script>

export default{
    name:'LoginStatus',
    props:{
        logStatus:{
            type:Boolean,
            required:true
        }
    },
    data(){
        return{
            
        }
 
    },
    methods:{

    }
}

</script>

<style scoped>

</style>