<template >
    <div>    
    <table>  
        <tr class="give-style" v-for="i in  dataresp" :key="i">
            <RouterLink :to="{path:`/post/${i.id}`, query: { id: i.id}}">
            <button>
            <th> 
                <div>
                {{ i.title }} <br/>
                {{ i.body.slice(0,10) +"..." }}
                </div>     
            </th>
            </button>
            </RouterLink>   
        </tr>
    </table>
        
    </div>
</template>
<script>
import axios from "axios"
export default {
    name: "home-component",

    data(){
        return{
            dataresp: Array,
            maxIdpost:0
        }
    },
    props:{inputpost:Array}
    ,



   async mounted() {
        try{
            const response = await axios.get('https://jsonplaceholder.typicode.com/posts');
            this.dataresp = response.data;
            if (this.inputpost != null){
                this.dataresp = this.inputpost.concat(this.dataresp);
                this.maxIdpost = this.dataresp[0].id; 
                this.$emit('sendDataperc',this.dataresp,this.maxIdpost);   
            }
           
        }   catch(error){
            console.error('axios error:', error);
        }
        
    },
        
    
}
</script>
<style>
    table{
        text-align :center;
        width: 100%;
        height: 500px;
        border: 2px solid black;
    }
    th{
        width: 5000px;
        height: 50px;
        border: 2px solid rgb(54, 49, 49);  
        background: rgb(238, 232, 232);  
    }
    
</style>