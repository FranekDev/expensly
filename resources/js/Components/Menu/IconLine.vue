<script setup>
import {computed} from 'vue';

const props = defineProps({
    width: {
        type: String,
        default: 'lg',
    },
});

const sizes = {
    'sm': 'w-6',
    'md': 'w-7',
    'lg': 'w-9'
};

const widthClass = computed(() => {
    return sizes[props.width];
}).value;

</script>

<template>
    <div :class="['h-1', 'bg-stone-50', widthClass]" />
</template>

<style scoped>

</style>
