using System.IO.Compression;
using System.Xml.Schema;
using DotnetFundamental.Common.Models;


// Lists
List<string> listString = new List<string>();

listString.Add("SP");
listString.Add("BA");
listString.Add("MG");
listString.Add("RJ");

// Listas t em seus tamanhos redimensionados automaticamente, diferente de arrays.
Console.WriteLine($"Itens na lista: {listString.Count} - Capacidade: {listString.Capacity}");

listString.Add("SC");

Console.WriteLine($"Itens na lista: {listString.Count} - Capacidade: {listString.Capacity}");

listString.Remove("SP");

Console.WriteLine($"Itens na lista: {listString.Count} - Capacidade: {listString.Capacity}");

// Console.WriteLine("Percorrendo lista com for:");
// for (int index = 0; index < listString.Count(); index++)
// {
// 	Console.WriteLine($"Posição N° {index} - {listString[index]}");
// }

// Console.WriteLine("\nPercorrendo lista com foreach:");
// int i =0;
// foreach (string item in listString)
// {
// 	Console.WriteLine($"Posição N° {i} - {item}");
// 	i++;
// }



// Array
// int[] arrayInteger = new int[3];

// arrayInteger[0] = 32;
// arrayInteger[1] = 64;
// arrayInteger[2] = 128;


// int[] arrayIntegerDouble = new int[arrayInteger.Length * 2];
// Array.Copy(arrayInteger, arrayIntegerDouble, arrayInteger.Length);

// Cria um novo array com a capacidade definida pelo parâmetro, e copia os elementos do array antigo para o novo
// Array.Resize(ref arrayInteger, arrayInteger.Length * 2);

// for (int index = 0; index < arrayInteger.Length; index++)
// {
// 	Console.WriteLine($"Position N° {index} - {arrayInteger[index]}");
// }

// "foreach" is only used for lists and arrays
// int i = 0;
// foreach (int value in arrayInteger) // For each position assign the position value to "value" | 
// {
// 	Console.WriteLine($"Position N° {i} - {value}");
// 	i++;
// }

// Person person1 = new()
// {
// 	Name = "Loena",
// 	Age = 22
// };


// person1.Introduce();

// string introduce = "Tipos de dados";

// int amount = 0;

// double height = 1.10;

// decimal price = 1.80M;

// bool status = true;

// Console.WriteLine(introduce);
// Console.WriteLine(amount);
// Console.WriteLine(height);
// Console.WriteLine(price);
// Console.WriteLine(status);






// int a = 5;
// double b = a;

// long a = long.MaxValue;
// int b = Convert.ToInt32(a);

// int a = int.MaxValue;
// long b = a;





// int quantity = 10;

// int getQuantity = 4;

// if (quantity >= getQuantity)
// {
// 	// Do something 
// }
// else
// {
// 	// Do something
// }

// Console.WriteLine("Digite uma letra: ");
// string? letter = Console.ReadLine();






// switch (letter)
// {
// 	case "a":
// 	case "e":
// 	case "i":
// 	case "o":
// 	case "u":
// 		Console.WriteLine("Vogal");
// 		break;
// 	default:
// 		Console.WriteLine("Não é vogal");
// 		break;
// }






// Calculator calculator = new();

// calculator.Sum(10, 10);




// int number = 10;

// for (int index = 0; index <= 10; index++)
// {
// 	Console.WriteLine($"{number} x {index} = {number * index}");
// }






// int number = 5;
// int index = 0;

// while (index <= number)
// {
// 	Console.WriteLine($"{number} x {index} = {number * index}");
// 	index++;

// 	if (index == 5)
// 		break;
// }




// int sum = 0, number = 0;

// do
// {
// 	Console.WriteLine("Add a number (0 to stop)");
// 	number = Convert.ToInt32(Console.ReadLine());

// 	sum += number;

// } while (number != 0);








// string? option = null;
// bool showMenu = true;

// while (showMenu)
// {
// 	Console.Clear(); //Limpar Console
// 	Console.WriteLine("Digite sua opção: ");
// 	Console.WriteLine("1 - Cadastrar");
// 	Console.WriteLine("2 - Buscar");
// 	Console.WriteLine("3 - Apagar");
// 	Console.WriteLine("4 - Encerrar");

// 	option = Console.ReadLine();

// 	switch (option)
// 	{
// 		case "1":
// 			Console.WriteLine("Cadastrando");
// 			break;

// 		case "2":
// 			Console.WriteLine("Buscando");
// 			break;

// 		case "3":
// 			Console.WriteLine("Apagando");
// 			break;

// 		case "4":
// 			Console.WriteLine("Encerrando");
// 			showMenu = false;
// 			break;

// 		default:
// 			Console.WriteLine("Opção inválida");
// 			break;
// 	}
// }











