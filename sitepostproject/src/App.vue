<template>
  <header-component/>
  <router-view @datatr="DataParc" @sendDataperc="GoToPostDetail" @dataDel="dataDelSave" :inputpost = "inputdataparc" :listPost="listParc" :maxId="maxId" :delPostSave="delPost"/>
</template>

<script>
import headerComponent from "@/components/header.vue" 

 export default {
  name: 'App',
  components:{
    headerComponent,

  },
  data(){
    return{
      InputUsIdAp:'',
      InputTitlAp:'',
      InputTextAp:'',
      inputdataparc:[], 
      idcode:100,
      listParc:[],
      maxId:0,
      delPost:[] 
    }
  },
  methods:{
    dataDelSave(willdel){
      this.delPost=willdel;
    },
    DataParc(UserId,Titl,Text){
      this.InputUsIdAp = UserId;
      this.InputTitlAp = Titl;
      this.InputTextAp = Text;
      if (this.inputdataparc == null){
        this.idcode = 100;
      }
      else{
        this.idcode++;
      }
      this.inputdataparc.splice(0,0,{
      "userId": this.InputUsIdAp,
      "id": this.idcode,
      "title": this.InputTitlAp,
      "body": this.InputTextAp
      });
    },    
    GoToPostDetail(dataPacrList, maxPostId){
      this.listParc = dataPacrList;
      this.maxId = maxPostId;
    }
  }    
}
</script>

<style>

</style>
