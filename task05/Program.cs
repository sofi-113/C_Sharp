Console.Clear();
Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int count = -num1;
while (count <= num1){
    Console.Write($"{count},");
    count = count +1 ;
}   
