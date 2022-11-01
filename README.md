Селюжицкий Олег 20ИТ-2 Лабораторная работа №1 ВСРПП.
Приложение калькулятор, разработанное в Windows Forms на C#.

https://raw.githubusercontent.com/Zusith/Calculator-windowsforms/master/Cal.pngSimple calculator windows forms.
Калькулятор используется для вычисления арифметических операций, таких как сложение, вычитание, умножение и деление. Добавлена кнопка +/- и удалена кнопка "," т.к. заказчик изменил требования и он не будет работать с дробными числами.
Для удобства заказчику нужна кнопка для изменения отрицательности числа (+/-).
Инструкция по эксплуатации:
После запуска калькулятора, вы можете вводить числа, менять их знак.
После ввода первого числа выражения, нажмите кнопку нужного вам знака +,-,x,/ Если был выбран не тот знак, просто нажмите на другой.
https://github.com/Zusith/Calculator-windowsforms/blob/master/image.png?raw=true


После выбора знака введите второе число. Затем вы можете либо нажать на кнопку = и закончить вычисления, либо нажать на кнопку занака +,-,x,/ и вычисление сразу закончится и начнется новое с выбранного вами нового знака.
https://github.com/Zusith/Calculator-windowsforms/blob/master/test0.png?raw=true


После нажатия кнопки = результат выведется в поле.
https://github.com/Zusith/Calculator-windowsforms/blob/master/test2.png?raw=true


Далее вы можете нажать кнопку знака +,-,х,/ или ввести новое число и начать новые вычисления.
Если вы нажали не кнопку = , а кнопку знака, то новые вычисления начнутся автоматически, первым числом будет число после вычисления, второе число введите в поле и нажмите равно или кнопку знака +,-,х,/ и так далее.
Если вам нужно сбросить все вычисления нажмите кнопку С.
https://raw.githubusercontent.com/Zusith/Calculator-windowsforms/6f0300c4ab2fb93eba05fc4a705d3fe3fa796680/test3.png


Для изменения знака перед числом используйте кнопку +/-.
https://github.com/Zusith/Calculator-windowsforms/blob/master/test4.png?raw=true



Описание классов и методов:
В проекте используются два класса: Util - для вычисления, Form1 - для создания графического интерфейса. Также в проекте присутствует класс для Unit тестов.
Все методы для вычисления собраны в классе Util:
Метод formload используется для кнопки сброса. Также используется при запуске калькулятора.
Метод Sign используется для кнопок знаков (+,-,х,/). Происходит выбор знака для вычисления.
Метод Number используется для введения чисел. Для кнопок от 0 до 9.
Метод Ask используется для вызова метода для ответа. Для кнопки =.
Метод Num используется для конвертации строк в числа.
Метод Askmet используется для вывода ответа в поле в методе Ask.
Метод Calculate используется для вычисления ответа.
Метод PlusMinus используется для изменения знака перед числом. Для кнопки +/-.
В классе Form1 собраны все кнопки используемые в калькуляторе.
Юнит тесты представлены на картинке
https://github.com/Zusith/Calculator-windowsforms/blob/master/Юнит%20тесты.png?raw=true


![image](https://user-images.githubusercontent.com/116071330/197416135-61e50bae-4bbc-4c68-a06b-0e27b5450f71.png)
