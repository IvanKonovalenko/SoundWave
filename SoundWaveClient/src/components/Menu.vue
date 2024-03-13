<template>
    
        <ul class="hidden-menu">
            <li><Button>Главная</Button></li>  
            <li><Button>Плейлисты</Button></li>  
            <li><Button>Моя Музыка</Button></li>  
            
        </ul>
   
</template>

<script>

export default{
    name:'Menu',
    data(){
        return{
            
    }
 
    },
    methods:{

    }
}

</script>

<style>
    .hidden-menu{
        list-style-type:  none;
        position: absolute;
        right: 0px;
        top: 85px;
        height: 100%;
        width: 10%;
        background-color: rgb(0, 0, 0);
        display: flex;
        flex-direction: column;
        justify-content: start;
        gap: 30px;
        border-radius: 30px 0px 0px 30px;
        border-left: 1px solid white;

        animation-duration: 1s;
        animation-name: slidein;

    }
    @keyframes slidein {
    from {
        right: -100px;
        
    }

    to {
        right: 0px;
       
    }
}
</style>