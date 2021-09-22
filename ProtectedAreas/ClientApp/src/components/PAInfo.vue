<template>
  <div class="pa-info">
    <div class="blocks">
      <div class="block">
        <table class="table-without-header">
          <tr>
            <td>Порядковый номер кадастрового дела</td>
            <td>5646</td>
          </tr>
          <tr>
            <td>Статус</td>
            <td>Действующая</td>
          </tr>
          <tr>
            <td>Полное наименование <div class="question question__gray" /></td>
            <td></td>
          </tr>
          <tr>
            <td>Краткое наименование <div class="question question__gray" /></td>
            <td>Сочинский</td>
          </tr>
        </table>
      </div>
      <label class="block-label">Устаревшее наименование <div class="question question__gray" /></label>
      <div class="block">
        <table class="table-with-header">
          <thead>
            <tr>
              <th>№</th>
              <th>Устаревшее наименование ООПТ</th>
            </tr>
          </thead>
          <tbody>
            <tr>
              <td>1</td>
              <td>Старый Сочинский</td>
            </tr>
            <tr>
              <td>2</td>
              <td>Новый Сочинский</td>
            </tr>
          </tbody>
        </table>
      </div>
      <div class="block">
        <table class="table-without-header">
          <tr>
            <td>Категория ООПТ</td>
            <td>Государственные природные заказники</td>
          </tr>
          <tr>
            <td>Значение ООПТ</td>
            <td>федеральное</td>
          </tr>
          <tr>
            <td>Профиль</td>
            <td>комплексный</td>
          </tr>
          <tr>
            <td>Дата создания <div class="question question__gray" /></td>
            <td>03.12.1993</td>
          </tr>
          <tr>
            <td>Дата восстановления <div class="question question__gray" /></td>
            <td></td>
          </tr>
        </table>
      </div>
      <label class="block-label">Международный статус</label>
      <div class="block">
        <table class="table-with-header dropdown-table">
          <thead>
            <tr>
              <th></th>
              <th>№</th>
              <th>Международный статус</th>
            </tr>
          </thead>
          <tbody>
            <tr>
              <td
                class="dropdown-table__arrow-btn"
                @click="toggleTableDropdown(0, internationalStatusOpened)"
              >
                <div
                  class="dropdown-table__row-arrow"
                  :class="{
                    'dropdown-table__row-arrow__inverted': internationalStatusOpened.includes(0)
                  }"
                />
              </td>
              <td>1</td>
              <td>Водно-болотное угодье международного значения</td>
            </tr>
            <tr
              v-if="internationalStatusOpened.includes(0)"
              :key="0 + '_dropdown-table__row__expanded'"
              class="dropdown-table__row__expanded"
            >
              <td :colspan="internationalStatusColumnCount">
                <div class="dropdown-table__info-block">
                  <div class="dropdown-table__info-title">
                    Наименование объекта международного значения
                  </div>
                  <div class="dropdown-table__info-value">
                    Водно-болотное угодье
                  </div>
                </div>
                <div class="dropdown-table__info-block">
                  <div class="dropdown-table__info-title">
                    Документ <div class="question question__gray" />
                  </div>
                  <div class="dropdown-table__info-value">
                    Пример документа
                  </div>
                </div>
              </td>
            </tr>
          </tbody>
        </table>
      </div>
      <label class="block-label">Ликвидация и реорганизация ООПТ</label>
      <div class="block">
        <table class="table-with-header dropdown-table">
          <thead>
            <tr>
              <th></th>
              <th>№</th>
              <th>Дата <div class="question question__white" /></th>
              <th>Тип <div class="question question__white" /></th>
            </tr>
          </thead>
          <tbody>
            <tr>
              <td
                class="dropdown-table__arrow-btn"
                @click="toggleTableDropdown(0, liquidationOpened)"
              >
                <div
                  class="dropdown-table__row-arrow"
                  :class="{
                    'dropdown-table__row-arrow__inverted': liquidationOpened.includes(0)
                  }"
                />
              </td>
              <td>1</td>
              <td>15.01.82</td>
              <td>реорганизация</td>
            </tr>
            <tr
              v-if="liquidationOpened.includes(0)"
              :key="0 + '_dropdown-table__row__expanded'"
              class="dropdown-table__row__expanded"
            >
              <td :colspan="liquidationColumnCount">
              </td>
            </tr>
            <tr>
              <td
                class="dropdown-table__arrow-btn"
                @click="toggleTableDropdown(1, liquidationOpened)"
              >
                <div
                  class="dropdown-table__row-arrow"
                  :class="{
                    'dropdown-table__row-arrow__inverted': liquidationOpened.includes(1)
                  }"
                />
              </td>
              <td>2</td>
              <td>15.01.20</td>
              <td>реорганизация</td>
            </tr>
            <tr
              v-if="liquidationOpened.includes(1)"
              :key="0 + '_dropdown-table__row__expanded'"
              class="dropdown-table__row__expanded"
            >
              <td :colspan="liquidationColumnCount">
              </td>
            </tr>
          </tbody>
        </table>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  name: "PAInfo",
  data() {
    return {
      internationalStatusOpened: [],
      internationalStatusColumnCount: 3,
      liquidationOpened: [],
      liquidationColumnCount: 4
    }
  },
  methods: {
    toggleTableDropdown(id, array) {
      const index = array.indexOf(id)
      if (index > -1) {
        array.splice(index, 1)
      } else {
        array.push(id)
      }
    }
  },
}
</script>

<style lang="scss" scoped>
.pa-info {
  flex: 1;
  height: 100%;
  overflow-y: auto;
}

.blocks {
  .block {
    background-color: #fff;
    border: 1px solid #e4e4e4;
    border-radius: 5px 0 0 5px;
    padding: 10px 0 10px 10px;
    margin: 10px 0;

    &:first-child {
      margin-top: 0px;
    }

    table {
      width: 100%;
      border-radius: 5px 0 0 5px;
      border: 1px solid #e4e4e4;
      border-right: none;
      border-spacing: 0;
      overflow: hidden;
    }
  }

  .block-label {
    display: block;
    padding-left: 15px;
    margin-top: 15px;
    font-weight: 600;
  }
}

.table-without-header {
  tr {
    td {
      border-bottom: 1px solid #f5f5f5;
      padding: 7px 8px;

      &:first-child {
        width: 25% ;
        font-weight: 600;
        color: #434343;
      }
    }

    &:last-child td {
      border-bottom: 0;
    }
  }
}

.table-with-header {
  thead {
    background-color: #b5b5b5;
    color: white;

    th {
      text-align: left;
    }
    th:first-child {
      text-align: center;
      padding: 0;
      width: 60px;
    }
  }

  tbody {
    tr {
      td {
        border-bottom: 1px solid #f5f5f5;
        &:first-child {
          text-align: center;
        }
      }
      
      &:last-child td {
        border-bottom: 0;
      }
    }
  }

  th, td {
    font-weight: 600;
    padding: 7px 8px;
  }
}

.dropdown-table {
  &__row__expanded {
    td {
      padding: 0;
    }
  }

  th:nth-child(2), td:nth-child(2) {
    width: 60px;
    text-align: center;
    padding: 7px 0;
  }

  th:nth-child(3):not(:last-child) {
    width: 300px;
  }

  &__arrow-btn {
    cursor: pointer;
  }

  &__info-block {
    border-top: 1px solid #e5e5e5;
    text-align: left;

    &:last-child {
      border-bottom: 1px solid #e5e5e5;
    }
  }

  &__info-title {
    padding: 7px 20px;
    background: #f7f7f7;
  }

  &__info-value {
    padding: 12px 20px;
    font-weight: 400;
  }

  &__row-arrow {
    background: url("../assets/angle-arrow-dark.svg") no-repeat center;
    height: 20px;
    &__inverted {
      transform: scale(1, -1);
    }
  }
}

.question {
  display: inline-block;
  cursor: pointer;
  width: 17px;
  height: 17px;

  &__gray {
    background: url("../assets/question-gray.svg") no-repeat center;
  }

  &__white {
    background: url("../assets/question-white.svg") no-repeat center;
  }
}
</style>