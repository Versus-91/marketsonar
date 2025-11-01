<script setup lang="ts">
import {BField, BInput} from "buefy";
definePageMeta({
  layout:'fullpage'
})
const username = ref('');
const password = ref('');

</script>

<template>
  <div class="container">
    <div class="columns is-centered">
      <div class="column is-6">
        <div class="section">
          <h1 class="title is-4">Register</h1>
          <hr>
          <b-field label="Username" >
            <b-input v-model="username" type="text"></b-input>
          </b-field>
          <b-field  label="Password">
            <b-input v-model="password" type="password"></b-input>
          </b-field>
          <button class="button is-primary mr-2">Register</button>
          <a class="button is-link" href="/">Back</a>
          <br>
          {{username}}
          {{password}}
        </div>
      </div>
  </div>
  </div>
</template>

<style scoped>

</style>