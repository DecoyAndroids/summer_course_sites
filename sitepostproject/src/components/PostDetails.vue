<template>
    <div>    
    <div class="title">Title: {{ showTitle }}<br/></div>
    <div class="text">Main text: {{ showText }}</div>    
    </div>
</template>
<script>
export default {
    data(){
        return{
            showTitle:'',
            showText:'',
            i:0,
            idReal:0,
        
        }
    },
    props:{listPost:Array,
           id:Number,
           maxId:Number 
    },

    mounted(){
        
        for (this.i in this.listPost ){
            this.idReal = this.id;
            if (this.id > 100){   
                this.idReal = this.maxId - this.id ;
 
                if (this.i == this.idReal){ 
                    this.showTitle = this.listPost[this.i].title;
                    this.showText = this.listPost[this.i].body;
                    console.log(this.idReal);
                }               
            }else{ 
                if (this.maxId > 100){              
                    if (this.i == parseInt(this.idReal)+parseInt((this.maxId - 101))){ 
                        console.log(parseInt(this.idReal)+parseInt((this.maxId - 100)));
                        this.showTitle = this.listPost[this.i].title;
                        this.showText = this.listPost[this.i].body;
                    }
                }else{
                    if (this.i == this.idReal-1){ 
                        console.log(this.idReal);
                        this.showTitle = this.listPost[this.i].title;
                        this.showText = this.listPost[this.i].body;
                    }    
                }
            }
            
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