<template>
    <div>
        <SerachResult :searchQuery="searchQuery"></SerachResult>
    </div>
</template>

<script>
export default{
    name:'MainBody',
    props:{
        searchQuery:{
            type:String,
            requierd:true
        },
        idContent:{
            type:Number,
            requierd:true
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

<style>
</style>