// @ts-check
import tailwindcss from '@tailwindcss/vite';
import { defineConfig } from 'astro/config';
import astroIcon from 'astro-icon';

// https://astro.build/config
export default defineConfig({
    integrations: [astroIcon()],
    vite: {
        plugins: [tailwindcss()]
    }
});
