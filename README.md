# lab10
  # Заполнение массива в 4 потока
В  коде используется `Parallel.For`, что позволяет ускорить заполнение массива случайными данными.
  # Параллельная сортировка массива по выбранному полю
  Используется `ParallelSortItems` , 
который разделяет массив на подмассивы и сортирует их параллельно.
  # Создание нескольких потоков и выполнение сортировок параллельно
В коде есть методы `ParallelSortItemsByName` и `ParallelSortItemsByQuantity`, которые выполняют параллельную сортировку.
Также, в методе Run вы можете выбирать действия 7 и 8 для выполнения параллельной сортировки.
  # Замер времени выполнения сортировки для разного количества потоков и сравнение результатов
В методе `MeasureExecutionTime` замеряется время выполнения для различных сценариев, включая параллельную сортировку. 
Время параллельной сортировки анимает от 0.1 до 1 секунды, что является очень хороший результатом.
