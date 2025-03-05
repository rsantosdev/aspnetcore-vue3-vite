<script setup lang="ts">
import { RouterView } from 'vue-router'
</script>

<template>
  <div class="flex-lg-fill overflow-x-auto vstack vh-100" data-x-inject="navbar">
    <div class="flex-fill h-100 d-flex flex-column">
      <div class="flex-fill overflow-y-lg-auto scrollbar bg-body border-top" data-x-inject="page">
        <main>
          <div class="py-4 px-3 mx-auto">
            <RouterView />
          </div>
        </main>
      </div>
    </div>
  </div>
</template>

<style scoped></style>
