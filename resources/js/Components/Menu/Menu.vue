<script setup>
import MenuIcon from '@/Components/Menu/MenuIcon.vue';
import {useMenuStore} from '@/stores/MenuStore.js';
import NavMenuLink from '@/Components/Menu/Nav/NavMenuLink.vue';
import Links from '@/Components/Menu/Links.vue';
import NavBar from '@/Components/Menu/Nav/NavBar.vue';

const menu = useMenuStore();
</script>

<template>
    <main>
        <Transition
            name="open-menu"
            enter-from-class="opacity-0"
            enter-active-class="ease-linear transition-all"
            enter-to-class="opacity-1"
            leave-from-class="opacity-1"
            leave-active-class="ease-linear transition-all"
            leave-to-class="opacity-0"
            :duration="150"
            appear
        >
            <div
                v-if="menu.getShowMenu()"
                class="absolute top-0 left-0 h-screen w-screen bg-stone-950 z-10"
            >
                <NavBar />

                <Transition
                    leave-active-class="ease-linear transition-all"
                    leave-to-class="-ml-28"
                    :duration="150"
                    appear
                >
                    <section class="w-fit flex flex-col ml-28 gap-10 mt-12">
                        <Links />
                    </section>
                </Transition>
            </div>
        </Transition>

        <MenuIcon @click="menu.toggleMenu()" />
    </main>
</template>

<style scoped>

</style>
