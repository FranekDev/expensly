import About from '@/Pages/About.vue';
import {shallowMount} from '@vue/test-utils';

describe('About', () => {
    it('should render the About component', () => {
        const wrapper = shallowMount(About);
        expect(wrapper.exists()).toBe(true);
        expect(About).toBeDefined();
    });
});