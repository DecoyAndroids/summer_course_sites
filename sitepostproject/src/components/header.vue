vue <template>
    <div class="homePage">
    <RouterLink to="/home"><button>На главную</button></RouterLink>
    Home
    <RouterLink to="/crpost"><button>Создать пост</button></RouterLink>  
    </div>
</template>
<script>
export default {
    name: "header-component",    
}
</script>
<style>
    .homePage{
        border:2px solid black;
        margin-bottom:2px;
        width: 100%;
    }
    
</style>