vue <template>
    <div>
        
        <table>
            <tr>
                <th> Введен. число в разных степенях=></th>
                <th v-for="num in numbers" :key="num">
                    {{ inputNumber**num }}
                </th>
            </tr>
        </table>
        
    </div>
</template>
<script>
export default {
    name: "tablestep-component",
    data(){
        return{
            numbers :[1,2,3,4,5,6,7,8,9,10]    
        }
    },
   

    props:{
        inputNumber: Number,

    },
    
}
</script>
<style scoped>
       th{
        width: 50px;
        height: 50px;
        border: 2px solid black;
    }
        titl{
            width: 180px;
        }
    
</style>