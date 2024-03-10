<template>
    <div class ="my-header">
        <svg>

        </svg>
        <my-player></my-player>
        <my-search></my-search>
        <my-auth></my-auth>
    </div>
</template>

<script>
export default{
    name:'my-header',
    data(){

    },
    methods:{

    }
}

</script>

<style scoped>
    .my-header{
        padding: 20px 0px;
        display: flex;
        justify-content: center;
        gap: 20px;
        background-color: aqua;
        border-radius: 10px;
        
    }
</style>