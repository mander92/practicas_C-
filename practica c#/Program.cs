//Ejercicios de tipos de datos 

//Leer los valores

Console.Write("Proporciona tu nombre: ");
var nombre = Console.ReadLine();
Console.Write("Proporcina tu edad: ");
var edad = Convert.ToInt32(Console.ReadLine());
Console.Write("Proporciona un sueldo: ");
var sueldo = Convert.ToInt32(Console.ReadLine());
Console.Write("Eres un empleado de confianza (true/false): ");
var confianza = Convert.ToBoolean(Console.ReadLine());
Console.WriteLine($"El nombre es {nombre}, el sueldo es {sueldo}, la edad es {edad}, eres empleado de confianza? {confianza}");
