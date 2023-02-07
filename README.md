#SELECT products.name as product_name, categories.name as category_name
FROM products
LEFT JOIN categories
ON products.category_id = categories.id
# Проект покрыт юнит-тестами
# Добавление других фигур: создать класс фигуры, реализовать интерфейс IFigure
# Вычисление площади фигуры без знания типа фигуры в compile-time: в качестве параметра в метод GetFigureArea передается тип IFigure, который может содержать любой тип фигуры
# Добавлена проверка на то, является ли треугольник прямоугольным
