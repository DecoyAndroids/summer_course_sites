<template >
    <div>    
    <table>  
        <tr class="give-style" v-for="i in  dataresp" :key="i">
                <RouterLink :to="{path:`/post/${i.id}`}">
                <button>
                    <th>
                    <div>
                    {{ i.title }} <br/>
                    {{ i.body.slice(0,10) +"..." }}<br/> 
                    <button @click="deleter(i.id)">Delete post</button>
                    </div>     
                    </th>
                </button>
                </RouterLink>
                
            <br/>
            
              
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
            maxIdpost:0,
            willdel:[],
            id:Number
        }
    },
    methods:{
        async fetchPost(){
            try{
                const response = await axios.get('http://localhost:5078/api/Posts');
                this.dataresp = response.data;     
            }   catch(error){
            console.error('axios error:', error);
            }
        },
        async deleter(id){
            const response = await axios.delete(`http://localhost:5078/api/Posts/${id}`);
            console.log(response);
        }
    },
    async beforeRouteEnter(to, from, next) {
            next(async (vm) => {
            await vm.fetchPost();
        });
    },
    async mounted() {
        await this.fetchPost();  
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