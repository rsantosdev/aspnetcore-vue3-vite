<script setup lang="ts">
import { RouterLink } from 'vue-router'
import OrganizationSwitcher from './OrganizationSwitcher.vue';
import UserMenu from './UserMenu.vue';
</script>

<template>
  <div class="offcanvas-lg offcanvas-start w-rem-80 w-lg-auto border-end-lg" data-bs-scroll="true" tabindex="-1"
    id="sidebarOffcanvas" aria-labelledby="sidebarOffcanvasLabel">
    <nav class="sidebar w-100 w-rem-lg-64 d-flex flex-column flex-shrink-0 position-relative z-2 h-100 ">
      <OrganizationSwitcher />
      <div class="d-flex flex-column px-4 py-4 flex-fill overflow-y-auto scrollbar">
        <div class="vstack gap-5">
          <div>
            <div class="d-flex align-items-center px-3 px-lg-0 mb-1">
              <span class="d-block text-xs text-body-secondary fw-semibold me-auto">Main Menu</span>
            </div>
            <ul class="navbar-nav navbar-vertical-nav gap-0.5 mx-lg-n2">
              <li class="nav-item">
                <RouterLink to="/" class="nav-link">
                  <i class="bi bi-house"></i> Dashboard
                </RouterLink>
              </li>
              <li class="nav-item">
                <RouterLink to="/about" class="nav-link">
                  <i class="bi bi-pie-chart"></i> Analytics
                </RouterLink>
              </li>
            </ul>
          </div>
        </div>
      </div>
      <UserMenu />
    </nav>
  </div>
</template>

<style scoped></style>
