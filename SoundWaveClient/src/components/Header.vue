<template>
    <div class="header">
        
        <img src="../../public/Default_Transform_your_streaming_service_into_a_visual_experie_2_6a7ee247-1b90-4f62-adbe-fec4dfa63121_0.png" alt="">
        <Player></Player>
        <Search></Search>
        <LoginStatus :logStatus="logStatus"></LoginStatus>
    </div>
</template>

<script>

export default{
    name:'Header',
    props:{
        logStatus:{
            type:Boolean,
            required:true
        }
    },
    data(){

    },
    methods:{

    }
}

</script>

<style>
    .header{
        background-color: black;
        display: flex;
        gap: 100px;
        justify-content:space-evenly;
        align-items: center;
        border: 3px solid white;
        border-radius: 10px;
    }
    img{
        width: 143px;
        height: 85px;
    }
</style>