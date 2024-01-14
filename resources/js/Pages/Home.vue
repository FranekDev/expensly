<script setup>
import Title from '@/Components/Title.vue';
import Nav from '@/Components/Home/Nav.vue';
import Text from '@/Components/Text.vue';
import MainLayout from '@/Layouts/MainLayout.vue';
import {Head} from '@inertiajs/vue3';
</script>

<template>
    <Head title="Expensly" />
    <MainLayout>
        <div class="flex flex-col z-10 ml-24 gap-14">
            <div class="flex flex-col">
                <Title
                    title="EXPENSLY"
                    class="text-9xl font-extraBold italic"
                />
                <Text class="text-green-300 text-4xl">Manage Your expenses easily</Text>
            </div>

            <Nav />
        </div>
    </MainLayout>
</template>
