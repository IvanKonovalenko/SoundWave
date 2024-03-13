<template>
    <div class="top-charts">
        <MusicItem :name="music.name" :author="music.author"
        :duration="music.duration" :imgUrl="music.imgUrl"
        :musicId="music.id" v-for="music in musics"></MusicItem>
    </div>
</template>

<script>
export default{
    name:'TopCharts',
    data(){
        return{
            musics:[{name:'Название',duration:'12:30',author:'Автор',imgUrl:'./../public/Default_Transform_your_streaming_service_into_a_visual_experie_2_6a7ee247-1b90-4f62-adbe-fec4dfa63121_0.png'},{name:'Название',duration:'12:30',author:'Автор',imgUrl:'./../public/Default_Transform_your_streaming_service_into_a_visual_experie_2_6a7ee247-1b90-4f62-adbe-fec4dfa63121_0.png'},{name:'Название',duration:'12:30',author:'Автор',imgUrl:'./../public/Default_Transform_your_streaming_service_into_a_visual_experie_2_6a7ee247-1b90-4f62-adbe-fec4dfa63121_0.png'},{name:'Название',duration:'12:30',author:'Автор',imgUrl:'./../public/Default_Transform_your_streaming_service_into_a_visual_experie_2_6a7ee247-1b90-4f62-adbe-fec4dfa63121_0.png'},{name:'Название',duration:'12:30',author:'Автор',imgUrl:'./../public/Default_Transform_your_streaming_service_into_a_visual_experie_2_6a7ee247-1b90-4f62-adbe-fec4dfa63121_0.png'},{name:'Название',duration:'12:30',author:'Автор',imgUrl:'./../public/Default_Transform_your_streaming_service_into_a_visual_experie_2_6a7ee247-1b90-4f62-adbe-fec4dfa63121_0.png'},{name:'Название',duration:'12:30',author:'Автор',imgUrl:'./../public/Default_Transform_your_streaming_service_into_a_visual_experie_2_6a7ee247-1b90-4f62-adbe-fec4dfa63121_0.png'},{name:'Название',duration:'12:30',author:'Автор',imgUrl:'./../public/Default_Transform_your_streaming_service_into_a_visual_experie_2_6a7ee247-1b90-4f62-adbe-fec4dfa63121_0.png'},{name:'Название',duration:'12:30',author:'Автор',imgUrl:'./../public/Default_Transform_your_streaming_service_into_a_visual_experie_2_6a7ee247-1b90-4f62-adbe-fec4dfa63121_0.png'},{name:'Название',duration:'12:30',author:'Автор',imgUrl:'./../public/Default_Transform_your_streaming_service_into_a_visual_experie_2_6a7ee247-1b90-4f62-adbe-fec4dfa63121_0.png'},{name:'Название',duration:'12:30',author:'Автор',imgUrl:'./../public/Default_Transform_your_streaming_service_into_a_visual_experie_2_6a7ee247-1b90-4f62-adbe-fec4dfa63121_0.png'},{name:'Название',duration:'12:30',author:'Автор',imgUrl:'./../public/Default_Transform_your_streaming_service_into_a_visual_experie_2_6a7ee247-1b90-4f62-adbe-fec4dfa63121_0.png'},]
        }
    },
    methods:{

    }
}

</script>

<style>
    .top-charts{
        padding: 10px;
        display: flex;
        flex-direction: column;
        gap:20px;
        border-right: 1px solid white;
        height: 100%;
        width: 20%;
        background-color: rgb(0, 0, 0);
    }
</style>