using System;

namespace FedE_PR2EJ1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
			1 - Leer tres números que denoten una fecha(día, mes, año). Comprobar que es una fecha válida.
			Si no es válida escribir un mensaje de error.
			Si es válida escribir la fecha cambiando el número del
			mes por su nombre.
			Ej.Si se introduce 1 2 2006, se deberá imprimir “1 de febrero de 2006”.
			TENER EN CUENTA LA CANTIDAD DE DIAS QUE TIENE LOS MESES Y LOS AÑOS BISIESTOS*/



			Console.WriteLine("Introduce el dia: ");
			int dia = Int32.Parse(Console.ReadLine());
			Console.WriteLine("Introduce el mes: ");
			int mes = Int32.Parse(Console.ReadLine());
			Console.WriteLine("Introduce el año: ");
			int año = Int32.Parse(Console.ReadLine());

			if ((dia <= 31 && dia > 0) && (mes <= 12 && mes > 0) && (año > 0))
			{
				Console.Write(dia);
				switch (mes)
				{
					case 1:
						Console.Write(" de Enero del año ");
						break;
					case 2:
						Console.Write(" de Febrero del año ");
						break;
					case 3:
						Console.Write(" de Marzo del año ");
						break;
					case 4:
						Console.Write(" de Abril del año ");
						break;
					case 5:
						Console.Write(" de Mayo del año ");
						break;
					case 6:
						Console.Write(" de Junio del año ");
						break;
					case 7:
						Console.Write(" de Julio del año ");
						break;
					case 8:
						Console.Write(" de Agosto del año ");
						break;
					case 9:
						Console.Write(" de Setiembre del año ");
						break;
					case 10:
						Console.Write(" de Octubre del año ");
						break;
					case 11:
						Console.Write(" de Noviembre del año ");
						break;
					case 12:
						Console.Write(" de Diciembre del año ");
						break;
				}
				Console.WriteLine(año);
			}

			else
			{
				Console.WriteLine("ERROR");
			}
		}


	}
}
