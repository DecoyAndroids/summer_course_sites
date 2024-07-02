<template >
    <div>
        <input id="UsId" type="text" placeholder="Input your UserId" v-model="InputUsId"/>
        <input id="Titl" type="text" placeholder="Input title for post" v-model="InputTitl"/><br/>
        <input id="Text" type="text" placeHolder="Input text for post" v-model="InputText"/><br/>
        <RouterLink to="/home"><button @click="sendData">Create post</button></RouterLink>
        
    </div>
</template>
<script>
import axios from "axios"
export default {
    name:"crpost-component",
    data(){
        return{
        InputUsId:0,
        InputTitl:'',
        InputText:'',  
        maxId:0,
        maxIdAr:[]
        }  
    },
    async mounted(){
        try{
            const response = await axios.get('http://localhost:5078/api/Posts');
            console.log(response.data)
        }catch(error){
            console.log('Axios error:',axios);
        }
    },
    methods:{

        async sendData(){
            try{
                const response = await axios.post('http://localhost:5078/api/Posts',{
                    userId:this.InputUsId,
                    id:111,
                    title:this.InputTitl,
                    body:this.InputText,
                });
                console.log(response);
            }catch(error){
                console.log('Axios error:', error);
            }
            

        }

    }
    
}
</script>
<style >
#Usid{
    width: 150px;
}
#Titl{
    width: 150px;
}
#Text{
    width: 327px;
    height: 500px;
}
div{
    text-align:center;
}    
</style>