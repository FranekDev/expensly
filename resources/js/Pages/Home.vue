<script setup>
import BackgroundBlur from "@/Components/BackgroundBlur.vue";
import Title from "@/Components/Home/Title.vue";
import Nav from "@/Components/Home/Nav.vue";
import Text from "@/Components/Home/Text.vue";
</script>

<template>
    <main class="h-screen w-screen bg-main flex items-center selection:bg-green-300 selection:bg-opacity-40 selection:text-white">
        <div class="flex flex-col z-10 ml-24 gap-14">
            <div class="flex flex-col">
                <Title title="EXPENSLY"/>
                <Text>Magange Your expenses easily</Text>
            </div>

            <Nav/>
        </div>

        <BackgroundBlur/>
    </main>
</template>
