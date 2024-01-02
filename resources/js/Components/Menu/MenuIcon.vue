<script setup>
import IconLine from '@/Components/Menu/IconLine.vue';
import {useMenuStore} from '@/stores/MenuStore.js';
import CloseMenuIcon from '@/Components/Menu/CloseMenuIcon.vue';
import OpenMenuIcon from '@/Components/Menu/OpenMenuIcon.vue';

const menu = useMenuStore();
</script>

<template>
    <main class="fixed bottom-6 left-6 cursor-pointer h-auto w-auto z-50">
        <OpenMenuIcon v-if="!menu.getShowMenu()" />
        <CloseMenuIcon v-else />
    </main>
</template>

<style scoped>

</style>
