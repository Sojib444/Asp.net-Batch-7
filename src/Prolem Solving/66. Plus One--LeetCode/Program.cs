


int[] digits = {2,3,9};



int carry = 1;
int[] result = new int[digits.Length];
for (int incr = digits.Length - 1; incr >= 0; incr--)
{
    int total = digits[incr] + carry;

    carry = total == 10 ? 1 : 0;

    result[incr] = total % 10;

}

if (carry == 1)
{
    result = new int[digits.Length + 1];
    result[0] = 1;
}

foreach(var item in result)
{
    Console.WriteLine(item);
}