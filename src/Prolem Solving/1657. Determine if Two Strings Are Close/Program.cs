


string s = Console.ReadLine();
string p = Console.ReadLine();

bool flag = true;
if (s.Length != p.Length)
{
    flag = false;
}


int[] arr = new int[26];
int[] arr1 = new int[26];

for (int i = 0; i < s.Length; i++)
{
    int d = s[i] - 97;
    arr[d]++;

}

for (int i = 0; i < p.Length; i++)
{

    int f = p[i] - 97;
    arr[f]++;

}


int sum = 0;
int sum1 = 0;
for (int i = 0; i < 26; i++)
{
    sum += arr[i];
    sum1 += arr1[i];
}
if (sum != sum1)
{
    flag = false;
}


Console.WriteLine(flag);
