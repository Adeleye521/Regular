<template>
  <div class="app">
    <h1>{{ title }}</h1>
    <p class="lead">{{ message }}</p>
    <button class="btn" @click="increment">Clicked {{ count }} times</button>
  </div>
</template>

<script setup>
import { ref } from 'vue'

const title = 'Vue Starter Component'
const message = 'Edit App.vue to start building your app.'
const count = ref(0)

function increment() {
    count.value += 1
}
</script>

<style scoped>
.app {
  max-width: 420px;
  margin: 3rem auto;
  padding: 1.5rem;
  border-radius: 12px;
  background: #f7f8fb;
  box-shadow: 0 10px 30px rgba(0, 0, 0, 0.06);
  text-align: center;
  font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', sans-serif;
}

.lead {
  color: #555;
  margin: 0.5rem 0 1.5rem;
}

.btn {
  border: none;
  padding: 0.75rem 1.4rem;
  border-radius: 999px;
  background: linear-gradient(135deg, #42b883, #3b82f6);
  color: #fff;
  font-weight: 600;
  cursor: pointer;
  transition: transform 120ms ease, box-shadow 120ms ease;
}

.btn:hover {
  transform: translateY(-1px);
  box-shadow: 0 6px 18px rgba(59, 130, 246, 0.3);
}
</style>
