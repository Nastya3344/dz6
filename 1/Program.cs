// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.Clear ();

Console.WriteLine (" Подсчет чисел в строке больше 0");

string tempStr = "";
int j = 0;
int count = 0;

// Создаем метод для ввода строки

string InputStr (string message)
{
    Console.Write (message);
    return (Console.ReadLine ());
}

string str = InputStr ($"Введите числа через запятую: ");

int [] numStr = new int [str.Length];

// Создаем метод перевода строки в числа

int [] ConvertStrToNum (string str)
{
    for (int i = 0; i < str.Length; i++)
    {
        if (Convert.ToInt32 (str [i]) != 44) // проверка запятой
        {
            tempStr += str [i]; // записываем цифры во временную строку пока не встретим запятую
        }
        else 
        {
            numStr [j] = Convert.ToInt32 (tempStr); // переводим цифры в число
            j++;
            tempStr = ""; // обнуляем временную строку
        }
        if (i == str.Length - 1) // запоминаем последнее число
        {
            numStr [j] = Convert.ToInt32 (tempStr);
        }
    }
    return numStr;
}

int [] numbers = ConvertStrToNum (str);



// Console.Write ("Это введенные числа: ");

for (int i = 0; i < numbers.Length; i++)
{
//    Console.Write (numbers [i] + " ");
    if (numbers [i] > 0)
    {
        count++;
    }
}
 Console.WriteLine ();

Console.WriteLine ($"Чисел больше нуля: {count}");