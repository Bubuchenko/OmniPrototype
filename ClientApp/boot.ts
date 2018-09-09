import "./css/site.css";
import Vue from "vue";
import VueRouter from "vue-router";
import antd from "ant-design-vue";
import "ant-design-vue/dist/antd.css";
import Axios from "axios";

Vue.use(VueRouter);
Vue.use(antd);
Vue.prototype.$http = Axios;

let vm = new Vue({
    el: "#app-root",
    router: new VueRouter({ mode: "history" }),
    render: h => h(require("./components/app/app.vue.html"))
});
