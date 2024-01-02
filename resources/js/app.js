import './bootstrap';
import '../css/app.css';

import { createApp, h } from 'vue';
import { createInertiaApp } from '@inertiajs/vue3';
import { resolvePageComponent } from 'laravel-vite-plugin/inertia-helpers';
import { ZiggyVue } from '../../vendor/tightenco/ziggy/dist/vue.m';
import { createPinia } from 'pinia';
import MainLayout from '@/Layouts/MainLayout.vue';

const appName = import.meta.env.VITE_APP_NAME || 'Expensly';

createInertiaApp({
    title: (title) => `${title} - ${appName}`,
    resolve: (name) => resolvePageComponent(`./Pages/${name}.vue`, import.meta.glob('./Pages/**/*.vue')),
    // resolve: async name => {
    //     const pages = import.meta.glob('./Pages/**/*.vue')
    //     let page = await pages[`./Pages/${name}.vue`]()
    //     page.default.layout = page.default.layout || MainLayout
    //     return page
    // },
    setup({ el, App, props, plugin }) {
        return createApp({ render: () => h(App, props) })
            .use(plugin)
            .use(ZiggyVue)
            .use(createPinia())
            .mount(el);
    },
    progress: {
        color: 'lime',
        showSpinner: true,
    },
});
