/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9 */

int m = 2;
int n = 3;
int RecAcFunction(int M, int N) 
{
    int ackFunction = 0;
    if (M < 0 || N < 0) Console.Write("Введено отрицательное число. Значение ");
    else    if (M == 0) ackFunction = N + 1;
            else    if (N == 0) ackFunction = RecAcFunction(M-1, 1); 
                    if (M > 0 && N > 0) ackFunction = RecAcFunction(M-1, RecAcFunction(M, N - 1)); 
                    return ackFunction;
}
Console.WriteLine($"{RecAcFunction(m, n)}");