# Контрольный срез

## Задача :

 Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

Примеры: 

 ["hello", "2", "world", ":-)"] -> ["2", ":-)"] 

 ["1234", "1567", "-2", "com.puter science"] -> ["-2"]

 ["Russia", "Denmark", "Кazan"] -> []


## Описание алгоритма решения:

Для начала необходимо чётко определить задачу. Далее задаём метод вывода массива ( так как будем использовать 2 массива и исключить повторения действий). Выводим "Приглашение" для пользователя с предложением ввести количество желаемых переменных, затем выполняем проверку ( вводимое число отвечает за длину массива и не может быть меньше 0, в противном случае программа выдаст уведомление о некорректности вводимого числа ). Выполнив проверку программа перехожит на ветку "else", где начинается процесс создания 2-х массивов ( arrStr1 и arrStr2 ), в первый данные заполняются с помощью клавиатуры и фантазии пользователя, 2-й заполняется исходя из требуемых значений по условию ( а именно "...формирует массив из строк, длина которых меньше либо равна 3 символам" ). Пользователь начинает вводить значения, вводится переменная "temp" для временного хранения значений, которая в последствии отправляет на проверку условия ( не более 3-х символов), затем переходит ко 2-му массиву, если удовлетворяет записывается во 2-й массив, иначе переходит к началу цикла и продолжает его до тех пор пока индекс не будет = длине массива arrStr1. После выполнения цикла осуществляется вывод 1-го массива ( arrStr1 ) и 2-го ( arrStr2 ). Конец.