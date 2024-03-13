import { createApp } from 'vue'
import App from './App.vue'
import components from './components'


const app = createApp(App);
import { OhVueIcon, addIcons } from "oh-vue-icons";
import { FaSearch, RiZhihuFill,IoEllipsisHorizontal,LaPlaySolid } from "oh-vue-icons/icons";


addIcons(FaSearch, RiZhihuFill,IoEllipsisHorizontal,LaPlaySolid);
console.log(LaPlaySolid.name);
app.component("v-icon", OhVueIcon);
components.forEach(component =>{
    app.component(component.name, component)});
app.mount('#app');
