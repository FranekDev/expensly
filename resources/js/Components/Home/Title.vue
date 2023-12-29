<script setup>
const props = defineProps({
    title: {
        type: String,
        required: true
    }
})
</script>

<template>
    <h1 class="text-white text-9xl font-extraBold italic">{{ props.title }}</h1>
</template>
