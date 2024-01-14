<script setup>
import {Link} from '@inertiajs/vue3';
import {useMenuStore} from '@/stores/MenuStore.js';

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

const menu = useMenuStore();

</script>

<template>
    <Transition
        name="open-menu"
        enter-from-class="opacity-0 -ml-28"
        enter-active-class="ease-linear transition-all"
        enter-to-class="opacity-1"
        leave-from-class="opacity-1"
        leave-active-class="ease-linear transition-all"
        leave-to-class="opacity-0 -ml-28"
        :duration="150"
        appear
    >
        <main class="relative w-fit grid items-center group cursor-pointer">
            <Link
                :href="props.to"
                class="text-stone-50 font-semiBold text-7xl"
                @click="menu.toggleMenu()"
            >
                {{ props.name.toUpperCase() }}
            </Link>
            <div
                class="group-hover:absolute group-hover:w-full group-hover:h-6 group-hover:bg-green-300 group-hover:bg-opacity-40 transition-all duration-150"
                :class="props.active ? 'absolute w-full h-6 bg-green-300 transition-all' : 'w-0'"
            />
        </main>
    </Transition>
</template>

<style scoped>

</style>