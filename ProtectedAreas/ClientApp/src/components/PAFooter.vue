<template>
  <footer class="pa-footer">
    <button class="pa-footer__settings-btn pa-footer__settings-btn__active">Редактировать</button>
    <button class="pa-footer__settings-btn">Утвердить</button>
    <button class="pa-footer__settings-btn">Удалить</button>
    <button class="pa-footer__settings-btn">Перейти к списку</button>
    <a class="pa-footer__history-link" href="">История изменений</a>
  </footer>
</template>

<script>
export default {
  name: "PAFooter"
}
</script>

<style lang="scss" scoped>
.pa-footer {
  display: flex;
  align-items: center;
  height: 75px;
  padding: 0 10px;

  &__settings-btn {
    border: 2px solid #42a62a;
    border-radius: 5px;
    padding: 8px 15px;
    font-size: 14px;
    margin-right: 10px;
    min-width: 110px;
    cursor: pointer;
    height: 37px;

    &:hover {
      background-color: #c0ebb6;
    }

    &__active, &__active:hover {
      background-color: #42a62a;
      color: #fff;
      cursor: default;
    }
  }

  &__history-link {
    margin-left: auto;
    color: #676767;
    text-decoration: none;
    font-size: 12px;

    &:hover {
      text-decoration: underline;
    }
  }
}
</style>