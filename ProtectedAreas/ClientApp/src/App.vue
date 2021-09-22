<template>
  <div id="app">
    <LeftSidebar />
    <div class="main">
      <PAHeader />
      <PAContainer />
      <PAFooter />
    </div>
  </div>
</template>

<script>
import PAHeader from "./components/PAHeader.vue"
import PAFooter from "./components/PAFooter.vue"
import PAContainer from "./components/PAContainer.vue"
import LeftSidebar from "./components/LeftSidebar.vue"
export default {
  name: 'App',
  components: {
    PAHeader,
    PAFooter,
    PAContainer,
    LeftSidebar
  }
}
</script>

<style lang="scss">
html, body {
  height: 100%;
}
body {
  margin: 0;
  background-color: #f5f5f5;
}
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  display: flex;
  height: 100%;
  color: #434343;
}
.main {
  min-width: 0;
  display: flex;
  flex-direction: column;
  flex: 1;
}
</style>
