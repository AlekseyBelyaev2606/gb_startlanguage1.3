Console.Clear();
Console.WriteLine("Введите первое число");
int first = int.Parse(Console.ReadLine());
if(first%2 == 0){
    Console.WriteLine("Число четное");
}
else{
    Console.WriteLine("Число нечетное");
}