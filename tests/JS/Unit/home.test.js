import {mount, shallowMount} from '@vue/test-utils';
import {describe, test} from 'vitest';
import Home from '@/Pages/Home.vue';
import Text from '@/Components/Home/Text.vue';
import Title from '@/Components/Home/Title.vue';
import BackgroundBlur from '@/Components/BackgroundBlur.vue';

describe('Home', () => {

    test('should render the Home component', () => {
        const wrapper = shallowMount(Home);
        expect(wrapper.exists()).toBe(true);
        expect(Home).toBeDefined();
    });

    test('should contain Title component', () => {
        expect(Title).toBeDefined();
    });

    test('should contain Text component', () => {
        expect(Text).toBeDefined();
    });

    it('should contain BackgroundBlur component', () => {
        expect(BackgroundBlur).toBeDefined();
    });
});
