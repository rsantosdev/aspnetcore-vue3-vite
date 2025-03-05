<script setup lang="ts">
import { ref, onMounted } from 'vue';
import axios from 'axios';

type Organization = {
  id: string;
  name: string;
  selected: boolean;
}

type Organizations = Organization[];

const _orgs = ref<Organizations | null>(null);
const _org = ref<Organization | null>(null);

const fetchData = async function () {
  _orgs.value = null;
  _org.value = null;

  const response = await axios.get<Organizations>("/api/organizations");
  _orgs.value = response.data;
  _org.value = (response.data.length === 1 ? response.data[0] : response.data.find(x => x.selected)) || null;
};

const switchOrganization = function (org: Organization) {
  _org.value = org;
}

onMounted(async () => {
  await fetchData();
});
</script>

<template>
  <div class="dropdown-center px-4 py-2 mx-n2 position-relative">
    <button type="button"
      class="w-100 px-2 py-2 text-start border-0 bg-transparent shadow-none bg-accent-hover rounded d-flex gap-3 align-items-center"
      data-bs-toggle="dropdown">
      <img src="https://assets.webpixels.io/img/logos/clever-dark-sm.svg" class="logo-dark avatar avatar-sm"
        alt="..." />
      <img src="https://assets.webpixels.io/img/logos/clever-light-sm.svg" class="logo-light avatar avatar-sm"
        alt="..." />
      <div class="d-grid flex-grow-1 ls-tight text-sm">
        <span class="text-truncate text-heading fw-semibold">{{ _org?.name }}</span>
        <span class="text-truncate text-xs text-body-secondary mt-n1">Business</span>
      </div>
      <span class="ms-auto" role="button">
        <i class="bi bi-chevron-expand"></i>
      </span>
    </button>
    <div class="dropdown-menu " style="--x-dropdown-min-width: 88%;">
      <div class="dropdown-header px-2">
        <span class="d-block text-xs text-muted">Switch workspace</span>
      </div>
      <div class="vstack gap-1">
        <a href="#" class="dropdown-item px-2" v-for="org in _orgs" :key="org.id" @click="switchOrganization(org)">
          <div class="position-relative d-flex align-items-center gap-3">
            <img src="https://assets.webpixels.io/img/clients/square/logo-1.png" class="avatar avatar-xs" alt="..." />
            <div class="me-auto">
              <span class="d-inline-block text-sm fw-semibold">
                {{ org.name }}
              </span>
            </div>
            <span v-if="org.id === _org?.id"
              class="badge badge-xs bg-success-subtle text-success border border-success-subtle rounded-pill ms-6">Active</span>
          </div>
        </a>
      </div>
      <div class="dropdown-divider"></div>
      <a class="dropdown-item" href="#">
        <i class="bi bi-plus-circle me-3"></i>Add workspace
      </a>
    </div>
  </div>
</template>

<style scoped></style>
