<script setup lang="ts">
import { RouterLink } from 'vue-router'
import OrganizationSwitcher from './OrganizationSwitcher.vue';
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
      <div class="dropup-center px-4 py-2 mx-n2">
        <button type="button"
          class="w-100 px-2 py-2 text-start border-0 bg-transparent shadow-none bg-accent-hover rounded d-flex gap-3 align-items-center"
          data-bs-toggle="dropdown">
          <img src="https://assets.webpixels.io/img/memoji/memoji-2.svg" class="avatar" alt="..." />
          <div class="d-grid flex-grow-1 ls-tight text-sm">
            <span class="text-truncate text-heading fw-semibold">Alexis Enache</span>
            <span class="text-truncate text-xs text-body-secondary mt-n1">Developer</span>
          </div>
          <span class="ms-auto" role="button">
            <i class="bi bi-chevron-expand"></i>
          </span>
        </button>
        <div class="dropdown-menu ">
          <div class="dropdown-header">
            <span class="d-block text-xs text-muted mb-1">Signed in as:</span>
            <span class="d-block text-heading fw-semibold">Alexis Enache</span>
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
    </nav>
  </div>
</template>

<style scoped></style>
