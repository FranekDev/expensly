<script setup>

import NavMenuLink from '@/Components/Menu/Nav/NavMenuLink.vue';
</script>

<template>
    <Transition
        enter-from-class="-mt-8"
        enter-active-class="ease-linear transition-all"
        appear
    >
        <nav class="flex justify-between items-center m-4">
            <h1 class="font-semiBold text-stone-50 italic text-xl">
                Expensly
            </h1>
            <div class="flex justify-between gap-6">
                <NavMenuLink
                    href="/login"
                    name="log in"
                />
                <NavMenuLink
                    href="/register"
                    name="register"
                />
            </div>
        </nav>
    </Transition>
</template>

<style scoped>

</style>