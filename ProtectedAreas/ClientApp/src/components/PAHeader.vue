<template>
  <header class="pa-header">
    <select class="pa-header__select-section">
      <option selected value="lk">Личный кабинет</option>
    </select>
    <div class="name-container user">
      <span>Иванов Иван Иванович</span>
    </div>
    <div class="name-container organization">
      <span>Федеральное государственное бюджетное образовательное учреждение высшего образования "Казанский государственный медицинский университет" Министерства здравоохранения Российской Федерации</span>
    </div>
    <div class="buttons">
      <button class="buttons__btn buttons__settings" />
      <button class="buttons__btn buttons__burger" />
    </div>
  </header>
</template>

<script>
export default {
  name: 'PAHeader'
}
</script>

<style lang="scss" scoped>
.pa-header {
  display: flex;
  color: #fff;
  padding: 10px;
  font-size: 12px;

  div, select {
    border-radius: 5px;
    height: 30px;
    margin-right: 8px;
  }

  &__select-section {
    padding: 0 30px 0 15px;
    color: #fff;
    border: none;
    outline: none;
    -moz-appearance: none;
    -webkit-appearance: none;
    appearance: none;
    cursor: pointer;
    background: #42a62a url("../assets/arrow-down.svg") calc(100% - 10px) no-repeat;
    background-size: 12px;

    &:hover {
      background-color: #399024;
    }
    &:active {
      background-color: #61b64c;
    }
  }
}

.name-container {
  display: flex;
  align-items: center;
  padding: 0 15px 0 45px;
  flex: 1;

  &.user {
    background: #434343 url("../assets/user-green.svg") 15px 5px no-repeat;
    background-size: 15px;

    span {
      white-space: nowrap;
    }
  }

  &.organization {
    background: #434343 url("../assets/portfolio-green.svg") 15px 8px no-repeat;
    background-size: 15px;
    min-width: 0;
    flex: 7;
    min-width: 150px;

    span {
      text-overflow: ellipsis;
      overflow: hidden;
      white-space: nowrap;
    }
  }
}

.buttons {
  display: flex;
  &__btn {
    border-radius: 5px;
    border: none;
    width: 30px;
    height: 30px;
    cursor: pointer;

    &:hover {
      background-color: #399024;
    }
    &:active {
      background-color: #61b64c;
    }
  }

  &__settings {
    background: #42a62a url("../assets/settings.svg") no-repeat center;
    margin-right: 10px;
  }

  &__burger {
    background: #42a62a url("../assets/burger.svg") no-repeat 3px center;
  }
}
</style>