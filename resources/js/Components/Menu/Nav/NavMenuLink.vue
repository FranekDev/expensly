<script setup>
import {Link} from '@inertiajs/vue3';

const props = defineProps({
    name: {
        type: String,
        default: '',
    },
});
</script>

<template>
    <Link class="text-stone-50 font-semiBold text-lg hover:text-green-300 transition-all">
        {{ props.name.toUpperCase() }}
    </Link>
</template>

<style scoped>

</style>