<script setup>
import {Head} from '@inertiajs/vue3';
import MainLayout from '@/Layouts/MainLayout.vue';
import Title from '@/Components/Title.vue';
import Text from '@/Components/Text.vue';

</script>

<template>
    <Head title="About Expensly" />
    <MainLayout>
        <div class="ml-16 md:ml-24">
            <Title
                title="About"
                class="text-7xl font-extraBold italic"
            />
            <Text class="text-2xl md:text-3xl text-stone-50 max-w-[470px] md:max-w-[750px] text-balance">
                This is about page. You can learn more about this app in here.
            </Text>
        </div>
    </MainLayout>
</template>

<style scoped>

</style>