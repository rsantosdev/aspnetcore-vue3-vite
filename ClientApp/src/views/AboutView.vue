<script setup lang="ts">
import { ref, onMounted, watch } from 'vue';
import { useRoute } from 'vue-router';

// Define the type for the forecast data
type Forecast = {
  date: string;
  temperatureC: string;
  temperatureF: string;
  summary: string;
};

type Forecasts = Forecast[];

// Create reactive state variables
const loading = ref(false);
const post = ref<Forecasts | null>(null);

// Define the asynchronous function to fetch data
async function fetchData() {
  post.value = null;
  loading.value = true;

  const response = await fetch('/weather/forecast');
  if (response.ok) {
    post.value = await response.json();
  }
  loading.value = false;
}

// Fetch data when the component is mounted
onMounted(async () => {
  await fetchData();
});

// Re-fetch data whenever the route changes
const route = useRoute();
watch(
  () => route.fullPath,
  async () => {
    await fetchData();
  }
);
</script>


<template>
  <h1>Weather forecast</h1>
  <p>This component demonstrates fetching data from the server.</p>

  <div v-if="loading" class="loading">
    Loading... Please refresh once the ASP.NET backend has started. See <a
      href="https://aka.ms/jspsintegrationvue">https://aka.ms/jspsintegrationvue</a> for more details.
  </div>

  <div v-if="post" class="content">
    <table class="table table-striped">
      <thead>
        <tr>
          <th>Date</th>
          <th>Temp. (C)</th>
          <th>Temp. (F)</th>
          <th>Summary</th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="forecast in post" :key="forecast.date">
          <td>{{ forecast.date }}</td>
          <td>{{ forecast.temperatureC }}</td>
          <td>{{ forecast.temperatureF }}</td>
          <td>{{ forecast.summary }}</td>
        </tr>
      </tbody>
    </table>
  </div>
</template>

<style scoped></style>
