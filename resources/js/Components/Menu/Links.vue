<script setup>
import MenuLink from '@/Components/Menu/MenuLink.vue';
import {computed} from 'vue';
import {usePage} from '@inertiajs/vue3';

const page = usePage();

const isActiveLink = computed(() => (name) => {
    return page.component === name;
});
</script>

<template>
    <MenuLink
        to="/"
        name="home"
        :active="isActiveLink('Home')"
    />
    <MenuLink
        to="/features"
        name="features"
        :active="isActiveLink('Features')"
    />
    <MenuLink
        to="/expenses"
        name="expenses"
        :active="isActiveLink('Expenses')"
    />
    <MenuLink
        to="/about"
        name="about"
        :active="isActiveLink('About')"
    />
    <MenuLink
        to="/logout"
        name="logout"
        method="post"
    />
</template>

<style scoped>

</style>