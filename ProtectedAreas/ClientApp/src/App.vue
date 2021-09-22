<template>
  <div id="app">
    <LeftSidebar />
    <div class="main">
      <PAHeader />
      <h2>ООПТ Сочинский</h2>
      <div class="info-container">
        <PAInfo />
        <RightSidebar />
      </div>
      <PAFooter />
    </div>
  </div>
</template>

<script>
import PAHeader from "./components/PAHeader.vue"
import PAFooter from "./components/PAFooter.vue"
import PAInfo from "./components/PAInfo.vue"
import LeftSidebar from "./components/LeftSidebar.vue"
import RightSidebar from "./components/RightSidebar.vue"
export default {
  name: 'App',
  components: {
    PAHeader,
    PAFooter,
    PAInfo,
    LeftSidebar,
    RightSidebar
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

  & > h2 {
    padding: 0 10px;
    font-weight: 400;
    margin: 5px 0 15px;
  }
}
.info-container {
  flex: 1;
  display: flex;
  padding: 0 10px;
  overflow-y: hidden;
}
</style>
