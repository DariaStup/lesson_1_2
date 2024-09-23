Console.WriteLine("Введите первое число");
//преобразуем введенное значение из строки в вещественное
double first_number = Convert.ToDouble(Console.ReadLine());
first_number = Convert.ToDouble(first_number * 1.0);
Console.WriteLine("Введите второе число");
//преобразуем введенное значение из строки в вещественное
double second_number = Convert.ToDouble(Console.ReadLine());
second_number = Convert.ToDouble(second_number * 1.0);
Console.WriteLine("Введите оператор");
char action = Convert.ToChar(Console.ReadLine());
double result;
switch (action)
{
    //если введен оператор деления
    //добавить обработку ошибок...
    case '/':
        result = first_number / second_number;
        Console.WriteLine("Результат: " + result);
        break;
    //если введен оператор сложения
    case '+':
        result = first_number + second_number;
        Console.WriteLine("Результат: " + result);
        break;
    //если введен оператор вычитания
    case '-':
        result = first_number - second_number;
        Console.WriteLine("Результат: " + result);
        break;
    //если введен оператор умножения
    case '*':
        result = first_number * second_number;
        Console.WriteLine("Результат: " + result);
        break;
    //если оператор не подошел
    default:
        Console.WriteLine("Введен неверный оператор!");
        break;
}
Console.ReadKey();