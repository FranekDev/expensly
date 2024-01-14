import {describe, test, expect} from 'vitest';
import Title from '@/Components/Title.vue';
import {mount} from '@vue/test-utils';

describe('Title test', () => {

    const wrapper = mount(Title, {
        propsData: {
            title: 'Title'
        }
    });

    test('should mount component', () => {
        expect(wrapper.exists()).toBe(true);
    });

    test('should receive title prop', () => {
        expect(wrapper.props('title')).toBe('Title');
    });
});
