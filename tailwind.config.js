import defaultTheme from 'tailwindcss/defaultTheme';
import forms from '@tailwindcss/forms';

/** @type {import('tailwindcss').Config} */
export default {
    content: [
        './vendor/laravel/framework/src/Illuminate/Pagination/resources/views/*.blade.php',
        './storage/framework/views/*.php',
        './resources/views/**/*.blade.php',
        './resources/js/**/*.vue',
    ],

    theme: {
        extend: {
            fontFamily: {
                sans: ['Figtree', ...defaultTheme.fontFamily.sans],
                thin: ['JetBrains Mono Thin', ...defaultTheme.fontFamily.mono],
                extraLight: ['JetBrains Mono ExtraLight', ...defaultTheme.fontFamily.mono],
                regular: ['JetBrains Mono Regular', ...defaultTheme.fontFamily.mono],
                semiBold: ['JetBrains Mono SemiBold', ...defaultTheme.fontFamily.mono],
                extraBold: ['JetBrains Mono ExtraBold', ...defaultTheme.fontFamily.mono],
            },
            colors: {
                main: '#0E0E0E',
            },
            backgroundImage: {
                'hero-pattern': "url('/assets/green-blur.svg')",
            },
        },
    },

    plugins: [forms],
};
