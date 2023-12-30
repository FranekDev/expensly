import {mount} from '@vue/test-utils';
import {describe, test} from "vitest";
import Home from "@/Pages/Home.vue";

describe('Home test', () => {
    const wrapper = mount(Home);

    test('should render the Home component', () => {
        expect(wrapper.exists()).toBe(true);
        expect(Home).toBeDefined();
    });

    test('should contain Title component', () => {
        expect(wrapper.findComponent({name: 'Title'}).exists()).toBe(true);
    });

    test('should contain Text component', () => {
        expect(wrapper.findComponent({name: 'Text'}).exists()).toBe(true);
    });

    it('should contain BackgroundBlur component', () => {
        expect(wrapper.findComponent({name: 'BackgroundBlur'}).exists()).toBe(true);
    });
});
