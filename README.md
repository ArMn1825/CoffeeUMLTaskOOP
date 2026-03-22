Запуск после сборки: CoffeeUML.exe < input.json

Формат входных данных:
type: water, ice, milk, syrup, coffeebeen (ингредиенты);
      add, mix, boil, whip, grind, pour (действия)
(элементы)

Для всех ингредиентов передаётся mass (double), помимо этого:
Для воды: salinity (double), для молока: fat_content (double), для льда: shape, для сиропа: syrup_type, для кофе: sort
Если не указано иного, типы значений этих полей string
Указание всех полей на данный момент обязательно.

Для действий: elements - массив элементов

Пример входных данных (рецепт капучино): input_1.json
