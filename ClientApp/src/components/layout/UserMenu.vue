<script setup lang="ts">
import { ref, onMounted } from 'vue';
import axios from 'axios';

type User = {
  id: string;
  name: string;
  email: string;
}

const _user = ref<User | null>(null);

const fetchData = async function () {
  _user.value = null;

  const response = await axios.get<User>("/api/user");
  _user.value = response.data;
};

onMounted(async () => {
  await fetchData();
});
</script>

<template>
  <div class="dropup-center px-4 py-2 mx-n2">
    <button type="button"
      class="w-100 px-2 py-2 text-start border-0 bg-transparent shadow-none bg-accent-hover rounded d-flex gap-3 align-items-center"
      data-bs-toggle="dropdown">
      <img src="https://assets.webpixels.io/img/memoji/memoji-2.svg" class="avatar" alt="..." />
      <div class="d-grid flex-grow-1 ls-tight text-sm">
        <span class="text-truncate text-heading fw-semibold">{{ _user?.name }}</span>
        <span class="text-truncate text-xs text-body-secondary mt-n1">Developer</span>
      </div>
      <span class="ms-auto" role="button">
        <i class="bi bi-chevron-expand"></i>
      </span>
    </button>
    <div class="dropdown-menu ">
      <div class="dropdown-header">
        <span class="d-block text-xs text-muted mb-1">Signed in as:</span>
        <span class="d-block text-heading fw-semibold">{{ _user?.name }}</span>
      </div>
      <div class="dropdown-divider"></div>
      <a class="dropdown-item" href="#">
        <i class="bi bi-house me-3"></i>Home
      </a>
      <a class="dropdown-item" href="#">
        <i class="bi bi-pencil me-3"></i>Edit profile
      </a>
      <div class="dropdown-divider"></div>
      <a class="dropdown-item" href="#">
        <i class="bi bi-gear me-3"></i>Settings
      </a>
      <a class="dropdown-item" href="#">
        <i class="bi bi-image me-3"></i>Media
      </a>
      <a class="dropdown-item" href="#">
        <i class="bi bi-box-arrow-up me-3"></i>Share
      </a>
      <div class="dropdown-divider"></div>
      <a class="dropdown-item" href="#">
        <i class="bi bi-person me-3"></i>Login
      </a>
    </div>
  </div>
</template>

<style scoped></style>
