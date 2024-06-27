import {createRouter, createWebHistory } from "vue-router"
import home from "@/components/home.vue"
import crpost from "@/components/crpost.vue"
import PostDetails from "@/components/PostDetails.vue"

const routes =[{
    path: "/home", component: home},
    {path:"/crpost", component: crpost},
    {path:"/post/:id", component: PostDetails, props:true}
]

const router = createRouter({
    routes: routes,
    history:createWebHistory()
})

export default router;