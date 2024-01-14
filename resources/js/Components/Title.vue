<script setup>
const props = defineProps({
    title: {
        type: String,
        required: true
    }
});
</script>

<template>
    <h1 class="text-white">
        {{ props.title }}
    </h1>
</template>
