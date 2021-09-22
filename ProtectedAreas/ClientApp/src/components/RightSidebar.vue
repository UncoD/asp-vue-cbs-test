<template>
  <div class="right-sidebar">
    <ul class="menu">
      <li class="active">Установочные данные</li>
      <li>Местоположение, площадь, границы</li>
      <li>Задачи ООПТ</li>
      <li>НПО функционирования ООПТ</li>
      <li>Природные особенности ООПТ</li>
      <li>Природные ресурсы ООПТ</li>
      <li>Охранная зона ООПТ</li>
      <li>Режим и функциональное зонирование ООПТ</li>
      <li>Объекты инфраструктуры ООПТ</li>
      <li>Транспортная доступность</li>
      <li>Карта</li>
    </ul>
  </div>
</template>

<script>
export default {
  name: "RightSidebar"
}
</script>

<style lang="scss" scoped>
.right-sidebar {
  background-color: #fff;
  max-width: 420px;
  border: 1px solid #e4e4e4;
  border-radius: 5px;
  padding: 20px;
  box-sizing: border-box;
  margin-left: 10px;

  .menu {
    list-style: none;
    padding: 0;
    margin: 0;

    li {
      border: 1px solid #b5b5b5;
      border-radius: 5px;
      margin-bottom: 20px;
      padding: 7px 10px;
      font-size: 13px;
      cursor: pointer;

      &:last-child {
        margin-bottom: 0;
      }

      &:hover {
        background-color: #c0ebb6;
      }

      &.active {
        background-color: #42a62a;
        color: #fff;
        cursor: default;
      }
    }
  }
}
</style>