<script setup lang="ts">
import SidebarMenu from './components/layout/SidebarMenu.vue';
import MainContent from './components/layout/MainContent.vue';
</script>

<template>
  <div class="d-flex flex-column flex-lg-row h-lg-100 bg-body-tertiary">
    <SidebarMenu />
    <MainContent />
  </div>
</template>

<style scoped></style>
