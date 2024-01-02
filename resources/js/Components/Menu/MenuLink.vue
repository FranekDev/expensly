<script setup>
import {Link} from '@inertiajs/vue3';
import {ref} from 'vue';

const props = defineProps({
    name: {
        type: String,
        default: '',
    },
    active: {
        type: Boolean,
        default: false,
    },
    to: {
        type: String,
        default: '',
    },
});

const isHovered = ref(false);

const handleHover = (hover) => {
    isHovered.value = hover;
};
</script>

<template>
    <Transition
        name="open-menu"
        enter-from-class="opacity-0 -ml-28"
        enter-active-class="ease-linear transition-all"
        enter-to-class="opacity-1"
        leave-from-class="opacity-1"
        leave-active-class="ease-linear transition-all"
        leave-to-class="opacity-0"
        :duration="150"
        appear
    >
        <main class="relative w-fit grid items-center group cursor-pointer">
            <Link
                :href="props.to"
                class="text-stone-50 font-semiBold text-7xl"
                :class="{ 'pointer-events-none': isHovered }"
            >
                {{ props.name.toUpperCase() }}
            </Link>
            <div
                class="group-hover:absolute group-hover:w-full group-hover:h-6 group-hover:bg-green-300 group-hover:bg-opacity-40 transition-all"
                :class="{'absolute w-full h-6 bg-green-300 transition-all' : props.active}"
                @mouseover="() => handleHover(true)"
                @mouseleave="() => handleHover(false)"
            />
        </main>
    </Transition>
</template>

<style scoped>

</style>