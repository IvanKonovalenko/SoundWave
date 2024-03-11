<template>
    <div class="search-container">
        <v-icon  name="fa-search"  scale="1" />
         <input class="input" placeholder="Search music"/>
        
        <Button>Search</Button>
    </div>
</template>

<script>
export default{
    name:'Search',
    data(){
        return{
        
    }
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
        font-size: 15px;
        width: 90%;
        background-color: #717070;
        border: none;
        border-bottom: 2px solid white;
        border-radius: 10px;
        outline: none;
    }
    .input::placeholder{
        color: rgb(179, 169, 169);
    }
    
</style>