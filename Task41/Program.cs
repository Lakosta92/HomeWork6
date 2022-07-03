// Пользователь вводит с клавиатуры числа через запятую. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int[] StringToArray(string input)
{
    int countNumber = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',')
        {
            countNumber++;
        }
    }

    int[] numbers = new int[countNumber];
    int index =0;

    for (int i = 0; i < input.Length; i++)
    {
        string temp = "";

        while(input[i] !=',')
        { 
            temp+=input[i].ToString();

            if (i!=input.Length-1)
            i++;
            else
            break;
            
        }
       numbers[index] = Convert.ToInt32(temp);
       index++;
    }
    return numbers;
}
Console.WriteLine("Введите числа через запятую: ");
int[] numbers = StringToArray(Console.ReadLine());

Console.WriteLine();

int positiveNumber=0;

for (int i = 0; i < numbers.Length; i++)
{
    if(numbers[i]>0)
    {
        positiveNumber++;
    }
}
Console.WriteLine(positiveNumber);

