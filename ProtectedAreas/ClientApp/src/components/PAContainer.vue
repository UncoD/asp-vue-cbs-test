<template>
  <div v-if="protectedArea" class="pa-container">
    <h2>{{ protectedArea.shortName }}</h2>
    <div class="info-container">
      <PAInfo :protected-area="protectedArea"/>
      <RightSidebar />
    </div>
  </div>
</template>

<script>
import axios from 'axios'
import PAInfo from "./PAInfo.vue"
import RightSidebar from "./RightSidebar.vue"
export default {
  name: 'PAContainer',
  components: {
    PAInfo,
    RightSidebar
  },
  data() {
    return {
      protectedArea: null
    }
  },
  created() {
    axios.get('/api/ProtectedArea')
    .then(res => {this.protectedArea = res.data; console.log(res.data)})
  },
}
</script>

<style lang="scss">
.pa-container {
  flex: 1;
  overflow-y: hidden;
  display: flex;
  flex-direction: column;

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
