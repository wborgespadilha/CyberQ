import Home from './views/PaginaInicial.vue'
import Login from './views/PaginaLogin.vue'
import Leitor from './views/PaginaLeitor.vue'
import Redator from './views/PaginaRedator.vue'
import Admin from './views/PaginaAdmin.vue'

import { createRouter, createWebHistory } from 'vue-router'

const routes = [
  {
    path:"/",
    name:"home",
    component:Home
  },
  {
    path:"/login",
    name:"login",
    component:Login
  },
  {
    path:"/leitor",
    name:"leitor",
    component:Leitor
  },
  {
    path:"/redator",
    name:"redator",
    component:Redator
  },
  {
    path:"/admin",
    name:"admin",
    component:Admin
  }
]

const router = createRouter({
  history:createWebHistory(),
  routes: routes,
});

export default router;