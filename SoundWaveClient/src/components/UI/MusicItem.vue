<template>
    <div class="music-item">
        <div class="image-nameauthor">
        <span class="circle-image">
	        <img :src="imgUrl"/>
	   </span>
       <div>
            <p class="name">{{ this.name }}</p>
            <p class="author">{{ this.author }}</p>
       </div>
       </div>
       <div class="play-duration">
       <v-icon name="la-play-solid"  scale="1" /> 
       <p class="duration">{{ this.duration }}</p>
    </div>
    </div>
</template>

<script>
export default{
    name:'MusicItem',
    props:{
        name:'',
        author:'',
        duration:'',
        imgUrl:'',
        musicId:''
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
.music-item{  
    padding: 0px 10px;
    display: flex;
    justify-content: space-between;
    align-items: center;
    gap:20px;
    background-color: rgb(81, 81, 81);
    border: 1px solid blue;
    border-radius: 10px;
}
.name{
    color: white;
    margin: 0px;
    font-size: 20px;

}
.author{
    color: rgb(201, 192, 192);
    margin: 0px;
    font-size: 15px;
}
.duration{
    color: white;
    margin: 0px;
}
.image-nameauthor{
    display:flex;
    align-items: center;
    gap: 10px;
}
.play-duration{
    display: flex;
    align-items: center;
    gap: 2px;
}


.circle-image{
	  display: inline-block;
	  
	  overflow: hidden;
	  width: 30px;
	  height: 30px;
	}
	.circle-image img{
	  width:100%;
	  height:100%;
	  object-fit: cover;
	}
</style>