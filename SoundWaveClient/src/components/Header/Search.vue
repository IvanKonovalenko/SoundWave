<template>
    <div class="search-container">
        <v-icon  name="fa-search"  scale="2" />
            <input class="input"/>
        
        <button class="btn-Search" @click="add">Search</button>
    </div>
</template>

<script>
export default{
    name:'Search',
    data(){

    },
    methods:{

    }
}

</script>

<style>
    .search-container{

        height: 100%;
        width: 40%;
        padding: 7px 10px;
        background-color: #4d4c4c;
        border-radius: 15px;
        display: flex;
        justify-content: center;
        align-items: center;
        gap:  10px;
    }
    .input{
        color: white;
        font-size: 25px;
        width: 90%;
        background-color: #717070;
        border: none;
        border-bottom: 4px solid white;
        border-radius: 10px;
        outline: none;
    }
    .btn-Search{
        color: white;
        border-radius: 10px;
        font-size: 25px;
        border: none;
        padding: 0px 20px;
        background-color: blue;
    }
    .btn-Search:hover{
        background-color: rgb(40, 72, 231);
    }
    
</style>