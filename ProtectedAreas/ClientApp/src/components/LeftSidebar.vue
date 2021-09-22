<template>
  <div class="left-sidebar">
    <div class="top-buttons">
      <button class="btn show-more" />
      <button class="btn logout" />
      <button class="btn trees" />
      <button class="btn document" />
      <button class="btn portfolio" />
      <button class="btn report" />
      <button class="btn map" />
    </div>
    <div class="bottom-buttons">
      <button class="btn info" />
      <button class="btn bell" />
      <button class="btn comment" />
      <button class="btn logo" />
    </div>
  </div>
</template>

<script>
export default {
  name: "LeftSidebar"
}
</script>

<style lang="scss" scoped>
.left-sidebar {
  background-color: #434343;
  min-width: 70px;
  display: flex;
  flex-direction: column;
  padding: 10px 0 30px;

  .top-buttons,
  .bottom-buttons {
    display: flex;
    flex-direction: column;
    align-items: center;
  }

  .bottom-buttons {
    margin-top: auto;

    .btn {
      margin: 20px 0 0;
    }
  }

  .btn {
    width: 35px;
    height: 35px;
    margin: 0 0 20px;
    border: 0;
    cursor: pointer;

    &.show-more {
      background: transparent url("../assets/show-more.svg") no-repeat center;
    }
    &.logout {
      background: transparent url("../assets/logout-green.svg") no-repeat -7px 3px;
      background-size: 42px;
    }
    &.trees {
      background: transparent url("../assets/trees.svg") no-repeat center;
    }
    &.document {
      background: transparent url("../assets/documents.svg") no-repeat center;
    }
    &.portfolio {
      background: transparent url("../assets/portfolio-outline.svg") no-repeat center;
    }
    &.report {
      background: transparent url("../assets/report.svg") no-repeat 5px -3px;
      background-size: 42px;
    }
    &.map {
      background: transparent url("../assets/map.svg") no-repeat 6px center;
    }
    &.info {
      background: transparent url("../assets/information.svg") no-repeat center;
    }
    &.bell {
      background: transparent url("../assets/bell.svg") no-repeat 4px -3px;
    }
    &.comment {
      background: transparent url("../assets/comment.svg") no-repeat center;
    }
    &.logo {
      background: transparent url("../assets/logo.svg") no-repeat center;
    }
  }
}
</style>