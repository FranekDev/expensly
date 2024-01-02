import {mount} from '@vue/test-utils';
import {describe, test} from "vitest";
import Home from "@/Pages/Home.vue";
import {createPinia} from "pinia";
import Text from "@/Components/Home/Text.vue";

describe('Home test', () => {

    const pinia = createPinia();
    const wrapper = mount(Home, {
        global: {
            plugins: [pinia],
        },
    });

    test('should render the Home component', () => {
        expect(wrapper.exists()).toBe(true);
        expect(Home).toBeDefined();
    });

    test('should contain Title component', () => {
        expect(wrapper.findComponent({name: 'Title'}).exists()).toBe(true);
    });

    test('should contain Text component', () => {
        expect(Text).toBeDefined()
    });

    it('should contain BackgroundBlur component', () => {
        expect(wrapper.findComponent({name: 'BackgroundBlur'}).exists()).toBe(true);
    });
});
