Console.Write("Üçgenin kenar uzunluğu : ");
int kenarUzunluk=int.Parse(Console.ReadLine());
for(int i=0;i<=kenarUzunluk;i++)
{
	for (int k = 0; k <=kenarUzunluk-i; k++)
	{
		Console.Write(" ");
	}
	for (int j = 0; j<=i*2 ; j++)
	{
		Console.Write("*");
	}
	Console.Write("\n");
}
Console.Read();