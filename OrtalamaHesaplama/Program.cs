Console.Write("Derinlik değeri giriniz: ");
int n=Convert.ToInt32(Console.ReadLine());
int[] fibonacci= new int[n];
fibonacci[0] = 1;
fibonacci[1] = 1;
for(int i=0;i<n;i++)
{
	if (i==0)
	{
        fibonacci[i + 2] = fibonacci[i+1] + fibonacci[i];
    }
	else if(i+1==n)
	{
        fibonacci[i] = fibonacci[i];
    }
    else
    {
        fibonacci[i + 1] = fibonacci[i] + fibonacci[i - 1];
    }
}
int total = 0;
foreach (int i in fibonacci)
  total += i;
double ortalama = total / fibonacci.Length;
foreach (var item in fibonacci)
{
    Console.Write(item+"-");
}
Console.WriteLine("\nfibonacci dizisi ortalama: "+ortalama);
Console.Read()
;