<template>
    <div>    
    <div class="title">Title: {{ showTitle }}<br/></div>
    <div class="text">Main text: {{ showText }}</div>    
    </div>
</template>
<script>
import axios from "axios"
export default {
    data(){
        return{
            showTitle:'',
            showText:'',
            i:0,
            idReal:0,
        
        }
    },
    props:{
           id:Number,
    },

   async mounted(){
        try{
            const response = await axios.get(`http://localhost:5078/api/Posts/${this.id}`);
            console.log(response.data);
            this.showTitle = response.data.title;
            this.showText = response.data.body; 
        }catch(error){
            console.log('Axios error: ', error);
            
        }
    }
}

</script>
<style>
.title{
    width: 100%;
    border:2px solid black;
    margin-bottom:2px;
    background: rgb(212, 209, 209);
    font-size:17pt;
}  
.text{
    border:2px solid black;
    width: 100%;
    background: rgb(231, 228, 228);
    font-size:15pt;
}
  
</style>