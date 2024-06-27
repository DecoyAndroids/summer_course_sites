vue <template>
    <div>
        <br>
        <button @click="incrementValuesPlus">Увеличить на один</button>
        <button @click="incrementValuesMinus">Уменьшить на один</button>
         <table>
                <tr>
                    <th>Числовая последовательность => </th>
                    <th v-for="num in numbers" :key="num">
                        {{ num }}
                    </th>
                </tr>
                <tr>
                    <th>Числ. послед. * введен. число =></th>
                    <th v-for="num in numbers" :key="num">
                        {{ num*inputNumber }}
                    </th>
                </tr>
                
        </table>
        </div>
</template>

<script>

export default {
    name: "table-component",
    
    data(){
        return{
            numbers :[1,2,3,4,5,6,7,8,9,10]    
        }
    },

    props:{
        inputNumber: Number,

    },

    methods:{
        incrementValuesPlus(){
            for (let i = 0; i < 10; i++){
                this.numbers[i]++;
            }
        },
        incrementValuesMinus(){
            for (let i = 0; i < 10; i++){
                this.numbers[i]--;
            }
        },
    }    
}
</script>

<style scoped>
    th{
        width: 50px;
        height: 50px;
        border: 2px solid black;
    }
    
</style>