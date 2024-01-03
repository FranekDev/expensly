import {describe, it} from 'vitest';
import {useMenuStore} from '@/stores/MenuStore.js';
import {setActivePinia, createPinia} from 'pinia';

describe('MenuStore', () => {

    beforeEach(() => {
        setActivePinia(createPinia());
    });

    it('should be defined', () => {
        const menu = useMenuStore();
        expect(menu).toBeDefined();
    });

    it('should have showMenu value as false by default', () => {
        const menu = useMenuStore();
        expect(menu.showMenu).toBe(false);
    });

    it('should change showMenu value', () => {
        const menu = useMenuStore();
        expect(menu.getShowMenu()).toBe(false);
        menu.toggleMenu();
        expect(menu.getShowMenu()).toBe(true);
    });

    it('should return showMenu, toggleMenu and getShowMenu', () => {
        const menu = useMenuStore();
        expect(menu.showMenu).toBeDefined();
        expect(menu.toggleMenu).toBeDefined();
        expect(menu.getShowMenu).toBeDefined();
    });
});
