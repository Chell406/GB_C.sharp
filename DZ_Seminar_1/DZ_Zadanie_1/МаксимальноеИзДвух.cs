Console.WriteLine("Введите первое чило: ");
int num_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе чило: ");
int num_2 = Convert.ToInt32(Console.ReadLine());

if(num_1 < num_2){
    Console.WriteLine($"{num_1} < {num_2}");
}
else{
    Console.WriteLine($"{num_1} > {num_2}");
}

//Вариант с промежуточной переменной max
// int max;
// if(num_1 < num_2)
// {
//     max = num_2;
//     Console.WriteLine(max);
// }
// else
// {
//     max = num_1;
//     Console.WriteLine(max);
// }