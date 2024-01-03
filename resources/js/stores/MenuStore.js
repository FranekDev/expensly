import {defineStore} from 'pinia';
import {ref} from 'vue';

export const useMenuStore = defineStore('menu', () => {
    const showMenu = ref(false);
    const toggleMenu = () => {
        showMenu.value = !showMenu.value;
    };

    const getShowMenu = () => showMenu.value;

    return {
        showMenu,
        toggleMenu,
        getShowMenu
    };
});

