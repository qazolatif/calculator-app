using System;

class Calculator
{
	static void Main(string[] args)
	{
		Console.WriteLine("Pilih menu Calculator:\n1. Penambahan\n2. Pengurangan\n3. Perkalian\n4. Pembagian");
		Console.Write("Input nomor menu [1..4]: ");
        	int c = int.Parse(Console.ReadLine());    

		if (c == 1)
		{
		Console.Write("Inputkan nilai a = ");
		int a = int.Parse(Console.ReadLine());
		Console.Write("Inputkan nilai b = ");
		int b = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Hasil Penambahan {0} + {1} = {2}", a, b, Penambahan(a,b));
		}
		else if (c == 2)
		{
		Console.Write("Inputkan nilai a = ");
		int a = int.Parse(Console.ReadLine());
		Console.Write("Inputkan nilai b = ");
		int b = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a,b));
		}
		else if (c == 3)
		{
		Console.Write("Inputkan nilai a = ");
		int a = int.Parse(Console.ReadLine());
		Console.Write("Inputkan nilai b = ");
		int b = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a,b));
		}
		else if (c == 4)
		{
		Console.Write("Inputkan nilai a = ");
		int a = int.Parse(Console.ReadLine());
		Console.Write("Inputkan nilai b = ");
		int b = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a,b));
		}
		else
		{
		Console.WriteLine("Maaf, menu yang Anda pilih tidak tersedia");
		}
		
		Console.Write("\nTekan sembarang key untuk keluar");
		Console.ReadKey();
	}
	
	static int Penambahan(int a, int b)
	{
		return a + b;
	}
	
	static int Pengurangan(int a, int b)
	{
		return a - b;
	}
	static int Perkalian(int a, int b)
	{
		return a * b;
	}
	
	static int Pembagian(int a, int b)
	{
		return a / b;
	}
}
