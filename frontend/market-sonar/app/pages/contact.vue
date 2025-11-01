<script setup lang="ts">
import {BField, BInput} from "buefy";

definePageMeta({
  layout:'fullpage'
})
</script>

<template>
  <div class="container">
    <div class="columns is-centered">
      <div class="column is-6">
        <div class="section">
          <h1 class="title is-4">Contact Us</h1>
          <hr>
          <b-field label="Name" >
            <b-input name="name" type="text"></b-input>
          </b-field>
          <b-field label="Email" >
            <b-input name="email" type="email"></b-input>
          </b-field>
          <b-field label="Message" >
            <b-input name="message" type="textarea"></b-input>
          </b-field>
          <button class="button mx-1">Send</button>
          <a class="button is-link" href="/">Back</a>
        </div>
      </div>
    </div>

  </div>

</template>



<style scoped>

</style>