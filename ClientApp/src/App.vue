<script setup lang="ts">
import { RouterLink, RouterView } from 'vue-router'
</script>

<template>
  <div class="d-flex flex-column flex-lg-row h-lg-100 bg-body-tertiary">
    <div class="offcanvas-lg offcanvas-start w-rem-80 w-lg-auto border-end-lg" data-bs-scroll="true" tabindex="-1"
      id="sidebarOffcanvas" aria-labelledby="sidebarOffcanvasLabel">
      <nav class="sidebar w-100 w-rem-lg-64 d-flex flex-column flex-shrink-0 position-relative z-2 h-100 ">
        <div class="dropdown-center px-4 py-2 mx-n2 position-relative">
          <button type="button"
            class="w-100 px-2 py-2 text-start border-0 bg-transparent shadow-none bg-accent-hover rounded d-flex gap-3 align-items-center"
            data-bs-toggle="dropdown">
            <img src="https://assets.webpixels.io/img/logos/clever-dark-sm.svg" class="logo-dark avatar avatar-sm"
              alt="..." />
            <img src="https://assets.webpixels.io/img/logos/clever-light-sm.svg" class="logo-light avatar avatar-sm"
              alt="..." />
            <div class="d-grid flex-grow-1 ls-tight text-sm">
              <span class="text-truncate text-heading fw-semibold">Clever Inc</span>
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
              <a href="#" class="dropdown-item px-2">
                <div class="position-relative d-flex align-items-center gap-3">
                  <img src="https://assets.webpixels.io/img/clients/square/logo-1.png" class="avatar avatar-xs"
                    alt="..." />
                  <div class="me-auto">
                    <span class="d-inline-block text-sm fw-semibold">
                      Nexora
                    </span>
                  </div>
                  <span
                    class="badge badge-xs bg-success-subtle text-success border border-success-subtle rounded-pill ms-6">Active</span>
                </div>
              </a>
              <a href="#" class="dropdown-item px-2">
                <div class="position-relative d-flex align-items-center gap-3">
                  <img src="https://assets.webpixels.io/img/clients/square/logo-2.png" class="avatar avatar-xs"
                    alt="..." />
                  <div>
                    <span class="d-inline-block text-sm fw-semibold">
                      Fusion Hive
                    </span>
                  </div>
                </div>
              </a>
              <a href="#" class="dropdown-item px-2">
                <div class="position-relative d-flex align-items-center gap-3">
                  <img src="https://assets.webpixels.io/img/clients/square/logo-3.png" class="avatar avatar-xs"
                    alt="..." />
                  <div>
                    <span class="d-inline-block text-sm fw-semibold">
                      Elevate Labs
                    </span>
                  </div>
                </div>
              </a>
            </div>
            <div class="dropdown-divider"></div>
            <a class="dropdown-item" href="#">
              <i class="bi bi-plus-circle me-3"></i>Add workspace
            </a>
          </div>
        </div>
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
  </div>
</template>

<style scoped></style>
