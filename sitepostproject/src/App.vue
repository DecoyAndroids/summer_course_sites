<template>
  <header-component/>
  <router-view/>
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
    
  }    
}
</script>

<style>

</style>
