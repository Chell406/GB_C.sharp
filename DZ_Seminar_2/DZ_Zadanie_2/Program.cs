string number;
while(true){
    Console.WriteLine("Введите число");
    number = Console.ReadLine();
    if(Convert.ToInt32(number) != 0)
        break;
}
if(number.Length >= 3)
    Console.WriteLine(number[2]);
else
    Console.WriteLine("У числа нет третей цифры");
