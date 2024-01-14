<script setup>
import Menu from '@/Components/Menu/Menu.vue';
</script>

<template>
    <main class="h-screen w-screen bg-main flex items-center selection:bg-green-300 selection:bg-opacity-40 selection:text-white bg-hero-pattern">
        <slot />

        <Menu />
    </main>
</template>

<style scoped>

</style>