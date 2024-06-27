<template>
  Введите число
  <input type ="number" v-model="number"/>
  <br>
  <table-component :inputNumber = 'number'/>
  <tableStep-component :inputNumber = 'number'/>

</template>

<script>
import tableComponent from "@/components/table.vue"
import tableStepComponent from "@/components/table_step.vue"

export default {
  name: 'App',
  components:{
    tableComponent,
    tableStepComponent,
  },
  data(){
    return{
      number: 1,
      number_step: 1,
    }
  }

}
</script>

<style>
</style>
