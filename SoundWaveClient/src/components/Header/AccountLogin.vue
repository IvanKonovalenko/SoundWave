<template>
    <div class="account-login">
       <p class="account-login--username">dsfsdfdf</p>
       <span class="circle-image">
	        <img src="../../../public/Default_Transform_your_streaming_service_into_a_visual_experie_2_6a7ee247-1b90-4f62-adbe-fec4dfa63121_0.png"/>
	   </span>
       <v-icon @click="ShowMenu"  name="io-ellipsis-horizontal"  scale="2" />
       <div class="menuitem">
        <ul>
            <li></li>
        </ul>
       </div>
       
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
        border-radius: 5px;
        display: flex;
        justify-content: center;
        align-items: center;
        gap: 10px;
        border: 2px solid white;
   }
   .account-login--username{
    color: white;
    margin: 0px;
   }
   .circle-image{
	  display: inline-block;
	  border-radius: 50%;
	  overflow: hidden;
	  width: 50px;
	  height: 50px;
	}
	.circle-image img{
	  width:100%;
	  height:100%;
	  object-fit: cover;
	}
    .menuitem{
        display: none;
    }
    
</style>