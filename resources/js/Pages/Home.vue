<script setup>
import Title from '@/Components/Home/Title.vue';
import Nav from '@/Components/Home/Nav.vue';
import Text from '@/Components/Home/Text.vue';
import MainLayout from '@/Layouts/MainLayout.vue';
</script>

<template>
    <MainLayout>
        <div class="flex flex-col z-10 ml-24 gap-14">
            <div class="flex flex-col">
                <Title title="EXPENSLY" />
                <Text>Manage Your expenses easily</Text>
            </div>

            <Nav />
        </div>
    </MainLayout>
</template>
