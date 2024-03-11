import { createApp } from 'vue'
import App from './App.vue'
import components from './components'


const app = createApp(App);
import { OhVueIcon, addIcons } from "oh-vue-icons";
import { FaSearch, RiZhihuFill } from "oh-vue-icons/icons";

addIcons(FaSearch, RiZhihuFill);

app.component("v-icon", OhVueIcon);
components.forEach(component =>{
    app.component(component.name, component)});
app.mount('#app');
