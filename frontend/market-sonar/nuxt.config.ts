// https://nuxt.com/docs/api/configuration/nuxt-config
export default defineNuxtConfig({
    css:['buefy/dist/css/buefy.css'],
  compatibilityDate: '2025-07-15', 
    ssr: false,
  devtools: { enabled: true },
    nitro:{
          preset:"static"
    },
  modules: [
    '@nuxt/eslint',
    '@nuxt/fonts',
    '@nuxt/image',
    '@nuxt/scripts',
    '@pinia/nuxt'
  ]
})