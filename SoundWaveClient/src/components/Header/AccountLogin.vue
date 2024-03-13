<template>
    <div class="account-login">
       <p class="account-login--username">dsfsdfdf</p>
       <span class="circle-image">
	        <img :src="'../../../public/Default_Transform_your_streaming_service_into_a_visual_experie_2_6a7ee247-1b90-4f62-adbe-fec4dfa63121_0.png'"/>
	   </span>
       <v-icon @click="ShowMenu"  name="io-ellipsis-horizontal"  scale="1" /> 
       <Menu v-show="this.ShowMenuStatus"></Menu>
  
    </div>
</template>

<script>
export default{
    name:'AccountLogin',
    data(){
        return{
        ShowMenuStatus:false
    }
    },
    methods:{
        ShowMenu(){
            if(this.ShowMenuStatus==true){
                this.ShowMenuStatus=false;
            }
            else{
                this.ShowMenuStatus=true;
            } 
        }
    }
}

</script>

<style>
    
   .account-login{
        padding: 7px 10px;
        background-color: #4d4c4c;
        border-radius: 15px;
        display: flex;
        justify-content: center;
        align-items: center;
        gap: 10px;
   }
   .account-login--username{
    color: white;
    font-size: 15px;
    margin: 0px;
   }
   .circle-image{
	  display: inline-block;
	  border-radius: 50%;
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