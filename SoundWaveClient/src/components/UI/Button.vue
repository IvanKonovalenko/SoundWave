<template>
    <div>
       
        <button class="btn"><slot></slot></button>
    </div>
</template>

<script>
export default{
    name:'Button',
    data(){

    },
    methods:{

    }
}

</script>

<style>
    
    .btn{
        color: white;
        border-radius: 10px;
        font-size: 20px;
        border: none;
        padding: 0px 20px;
        background-color: blue;
    }
    .btn:hover{
        background-color: rgb(40, 72, 231);
    }
    
</style>