﻿

int n = Convert.Toint32(Console.ReadLine());
int sum = 0;
int mul = 1;
while(n>0)
{
    sum += (n % 10);
    mul *= (n % 10);
    n /= 10;
}
return mul - sum;

Console.ReadLine(sum);
Console.ReadLine(mul);