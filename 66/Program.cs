// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120

// M = 4; N = 8. -> 30

int SumFromMToN(int M, int N){
    if(M>N){
        if(M==N){return N;}
        return SumFromMToN(M-1,N)+M;
    }
    else if(M<N){
        if(M==N){return M;}
        return SumFromMToN(M,N-1)+N;
    }
    else{return N;}
}

Console.WriteLine();

Console.WriteLine("Введите M: ");
int M = Convert.ToInt32(Console.ReadLine());


Console.WriteLine();

Console.WriteLine("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());


Console.WriteLine();
Console.WriteLine("Сумма элементов от M до N равна "+SumFromMToN(M,N));
Console.WriteLine();