import vue from '@vitejs/plugin-vue';
import { defineConfig } from 'vitest/config';

export default defineConfig({
    plugins: [vue()],
    test: {
        include: ['**/*.test.js', '/tests/JS/**/*.test.js'],
        globals: true
    },
    resolve: {
        alias: {
            '@': '/resources/js'
        }
    }
});
