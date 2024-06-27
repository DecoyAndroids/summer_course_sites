<template >
    <div>
        <input id="UsId" type="text" placeholder="Input your UserId" v-model="InputUsId"/>
        <input id="Titl" type="text" placeholder="Input title for post" v-model="InputTitl"/><br/>
        <input id="Text" type="text" placeHolder="Input text for post" v-model="InputText"/><br/>
        <RouterLink to="/home"><button @click="sendData">Create post</button></RouterLink>
        
    </div>
</template>
<script>
export default {
    name:"crpost-component",
    data(){
        return{
        InputUsId:0,
        InputTitl:'',
        InputText:'',  
        }  
    },
    methods:{
        sendData(){
            this.$emit('datatr',this.InputUsId,this.InputTitl,this.InputText);
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