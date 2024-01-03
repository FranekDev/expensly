import {describe, it} from "vitest";
import Menu from '@/Components/Menu/Menu.vue';
import {mount} from '@vue/test-utils';
import {useMenuStore} from "@/stores/MenuStore.js";
import {createPinia} from "pinia";
import NavBar from "@/Components/Menu/Nav/NavBar.vue";

describe('Menu', () => {
    const pinia = createPinia();
    const wrapper = mount(Menu, {
        global: {
            plugins: [pinia],
        },
    });

    it('should render', () => {
        expect(wrapper.findComponent({name: 'Menu'}).exists()).toBe(true);
    });

    it('should render Menu icon', () => {
        expect(wrapper.findComponent({name: 'MenuIcon'}).exists()).toBe(true);
    });

    it('should change showMenu value', () => {
        const menu = useMenuStore();
        expect(menu.getShowMenu()).toBe(false);

        const menuIcon = wrapper.findComponent({name: 'MenuIcon'});
        menuIcon.trigger('click');
        expect(menu.getShowMenu()).toBe(true);
    });

    it('should contain NavBar', () => {
        const menu = useMenuStore();
        menu.showMenu = true;
        expect(menu.getShowMenu()).toBe(true);
        expect(wrapper.findComponent({name: 'NavBar'}).isVisible()).toBe(true);
    });
});
