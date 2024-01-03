<script setup>
import Menu from '@/Components/Menu/Menu.vue';
import BackgroundBlur from '@/Components/BackgroundBlur.vue';
</script>

<template>
    <main class="h-screen w-screen bg-main flex items-center selection:bg-green-300 selection:bg-opacity-40 selection:text-white">
        <slot />

        <Menu />
        <BackgroundBlur />
    </main>
</template>

<style scoped>

</style>