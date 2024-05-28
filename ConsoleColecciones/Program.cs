// See https://aka.ms/new-console-template for more information

using ConsoleColecciones;
using NHibernate.Criterion;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using NHibernate.SqlCommand;
using System.Reflection.Emit;

//int[] arrayInts = [5, 5, 6, 7, 2, 19, 100];

//var consulta = //Aqui NO se ejecuta la "consulta"
//    from entero in arrayInts  //para cada elemento llamado entero en arrayInts que sea par sme lo ordenas y selecionas el numero
//    where (entero % 2 == 0 && entero > 4)
//    orderby (entero) descending
//    select entero;

//arrayInts.Append(8);


//foreach (var item in consulta) //Aqui es cuando se ejecuta la "consulta"
//{
//    Console.WriteLine(item);
//}

//List<Tablon> Balsa =
//    [
//        new Tablon() { dureza = 8, madera = "pino" },
//        new Tablon() { dureza = 7, madera = "caoba" },
//        new Tablon() { dureza = 23, madera = "caoba" }
//    ];

//var consulta2 =
//    from item in Balsa
//    where (item.dureza>2)
//    orderby (item.madera)
//    select (item.madera);

//foreach (var item in consulta2)
//{
//    Console.WriteLine(item);
//}

//IEnumerable<string> consulta3;
//consulta3 = Balsa.
//    Where (x => x.locojo()).
//    OrderBy (x=>x.madera).
//    Select (x=>x.madera);


int[] arrayDeEnteros = [1, 4, 5, 6, 1, 2, 6, 7];
var consulta1 = //Aqui NO se ejecuta la "consulta"
    from entero in arrayDeEnteros  //para cada elemento llamado entero en arrayInts que sea par sme lo ordenas y selecionas el numero
    where entero > 2
    orderby entero
    select entero;
Console.WriteLine("Mostrar aquellos que son mayores que 2");
foreach (var item in consulta1) //Aqui es cuando se ejecuta la "consulta"
{
    Console.WriteLine(item);

}
Console.WriteLine("");
var consulta2 = //Aqui NO se ejecuta la "consulta"
    from entero in arrayDeEnteros  //para cada elemento llamado entero en arrayInts que sea par sme lo ordenas y selecionas el numero
    where entero < 5
    orderby entero
    select entero;
Console.WriteLine("Mostrar aquellos que son menores que 5");

foreach (var item in consulta2) //Aqui es cuando se ejecuta la "consulta"
{
    Console.WriteLine(item);
}
Console.WriteLine("");

var consulta3 = //Aqui NO se ejecuta la "consulta"
    from entero in arrayDeEnteros  //para cada elemento llamado entero en arrayInts que sea par sme lo ordenas y selecionas el numero
    where entero > 2
    orderby entero descending
    select entero;
Console.WriteLine("Mostrar aquellos que son mayores que 2, ordenados de mayor a menor");

foreach (var item in consulta3) //Aqui es cuando se ejecuta la "consulta"
{
    Console.WriteLine(item);
}
Console.WriteLine("");

//var consulta4 = //Aqui NO se ejecuta la "consulta"
//    from entero in arrayDeEnteros  //para cada elemento llamado entero en arrayInts que sea par sme lo ordenas y selecionas el numero
//    where entero is Distinct
//    orderby entero 
//    select entero;
Console.WriteLine("Mostrar aquellos que son distintos");

IEnumerable<int> consulta4;
consulta4 = from entero in arrayDeEnteros.Distinct()
            select entero;
foreach (var item in consulta4) //Aqui es cuando se ejecuta la "consulta"
{
    Console.WriteLine(item);
}
Console.WriteLine("");

var consulta5 = //Aqui NO se ejecuta la "consulta"
    from entero in arrayDeEnteros  //para cada elemento llamado entero en arrayInts que sea par sme lo ordenas y selecionas el numero
    where (entero % 2 == 0)
    orderby (entero)
    select entero;
Console.WriteLine("Mostrar aquellos que son pares");

foreach (var item in consulta5) //Aqui es cuando se ejecuta la "consulta"
{
    Console.WriteLine(item);
}
Console.WriteLine("");
var consulta6 = //Aqui NO se ejecuta la "consulta"
    from entero in arrayDeEnteros  //para cada elemento llamado entero en arrayInts que sea par sme lo ordenas y selecionas el numero
    where (entero % 2 == 0 && entero > 4)
    orderby (entero) descending
    select entero;
Console.WriteLine("Mostrar aquellos que son pares > 4 de mayor a menor");

foreach (var item in consulta6) //Aqui es cuando se ejecuta la "consulta"
{
    Console.WriteLine(item);
}
Console.WriteLine("");

string[] arrayDeCadenas = ["Alberto", "Jacinto", "Adrian", "Merche", "Eva", "Maria"];

var consulta7 = //Aqui NO se ejecuta la "consulta"
    from text in arrayDeCadenas  //para cada elemento llamado entero en arrayInts que sea par sme lo ordenas y selecionas el numero
    orderby (text)
    select text;
Console.WriteLine("Ordenar la lista alfabeticamente");

foreach (var item in consulta7) //Aqui es cuando se ejecuta la "consulta"
{
    Console.WriteLine(item);
}
Console.WriteLine("");
var consulta8 = //Aqui NO se ejecuta la "consulta"
    from text in arrayDeCadenas  //para cada elemento llamado entero en arrayInts que sea par sme lo ordenas y selecionas el numero
    orderby (text) descending
    select text;
Console.WriteLine("Ordenar la lista alfabeticamente al reves");

foreach (var item in consulta8) //Aqui es cuando se ejecuta la "consulta"
{
    Console.WriteLine(item);
}
Console.WriteLine("");
var consulta9 = //Aqui NO se ejecuta la "consulta"
    from text in arrayDeCadenas  //para cada elemento llamado entero en arrayInts que sea par sme lo ordenas y selecionas el numero
    orderby (text.Length)
    select text;
Console.WriteLine("Ordenar la lista por cuantas letras tiene cada palabra");

foreach (var item in consulta9) //Aqui es cuando se ejecuta la "consulta"
{
    Console.WriteLine(item);
}
Console.WriteLine("");
var consulta10 = //Aqui NO se ejecuta la "consulta"
    from text in arrayDeCadenas
    where text.StartsWith("a", StringComparison.OrdinalIgnoreCase) && (text.EndsWith("o", StringComparison.OrdinalIgnoreCase) || text.EndsWith("n"))//para cada elemento llamado entero en arrayInts que sea par sme lo ordenas y selecionas el numero
    orderby (text.Length)
    select text;
Console.WriteLine("Seleccionar aquellas cadenas que comiencen por a y terminen por o u n.ç");

foreach (var item in consulta10) //Aqui es cuando se ejecuta la "consulta"
{
    Console.WriteLine(item);
}
Console.WriteLine("");
var consulta11 = //Aqui NO se ejecuta la "consulta"
    from text in arrayDeCadenas
    where text.Length > 4
    orderby (text.Length)
    select text;
Console.WriteLine("Seleccionar aquellas cadenas que tengan mas de 4 caracteres");

foreach (var item in consulta11) //Aqui es cuando se ejecuta la "consulta"
{
    Console.WriteLine(item);
}
Console.WriteLine("");
// CLASE PERSONA
List<Persona> Persona =
    [
        new Persona() { nombre = "Manolo", fechaNacimiento = new DateTime(1978, 6, 26), sueldo = 2400 },
        new Persona() { nombre = "Ana", fechaNacimiento = new DateTime(1982, 07,27), sueldo = 3200 },
        new Persona() { nombre = "Felipe", fechaNacimiento = new DateTime(1995,06,29), sueldo = 2100 },
        new Persona() { nombre = "Ambrosio", fechaNacimiento = new DateTime(1994,06,28), sueldo = 2000 },
        new Persona() { nombre = "Raquel", fechaNacimiento = new DateTime(2000, 05,5), sueldo = 1500 },
        new Persona() { nombre = "Luisa", fechaNacimiento = new DateTime(2002,02,02), sueldo = 1600 },
        new Persona() { nombre = "Ernesto", fechaNacimiento = new DateTime(2010,1,10), sueldo = 600 }
];



var consulta12 = 
    from text in Persona
    orderby (text.sueldo)
    select text;
Console.WriteLine("Ordenar la colección por sueldo de menos a más.");

foreach (var item in consulta12) 
{
    Console.WriteLine($"{item.nombre} nacido el {item.fechaNacimiento.ToShortDateString()} con sueldo: {item.sueldo}");
}
Console.WriteLine("");

    var consulta13 = 
        from text in Persona
        where text.fechaNacimiento.Year < (2024 - 18) 
        orderby (text.nombre)
        select text;
Console.WriteLine("Seleccionar aquellos que sean mayores de edad.");

foreach (var item in consulta13) 
{
    Console.WriteLine($"{item.nombre} nacido el {item.fechaNacimiento.ToShortDateString()} con sueldo: {item.sueldo}");
}
Console.WriteLine("");

var consulta14 =
    from text in Persona
    orderby (text.fechaNacimiento) descending
    select text;
Console.WriteLine("Ordenar por edad de más joven a menos joven.");

foreach (var item in consulta14)
{
    Console.WriteLine($"{item.nombre} nacido el {item.fechaNacimiento.ToShortDateString()} con sueldo: {item.sueldo}");
}
Console.WriteLine("");
var consulta15 =
    from text in Persona
    where text.nombre.StartsWith("A") || text.nombre.StartsWith("E")
    orderby (text.nombre) 
    select text;
Console.WriteLine("Seleccionar aquellos cuyo nombre comienza por A o por E.");

foreach (var item in consulta15)
{
    Console.WriteLine($"{item.nombre} nacido el {item.fechaNacimiento.ToShortDateString()} con sueldo: {item.sueldo}");
}
Console.WriteLine("");
Console.WriteLine("Suma de sueldos.");

var sueldosJuntos = Persona.Where(x=>x.sueldo == x.sueldo).Sum(x=>x.sueldo);
Console.WriteLine(sueldosJuntos);
Console.WriteLine("");
Console.WriteLine("Saber cual es el sueldo medio.");

var sueldoMedio = Persona.Where(x => x.sueldo == x.sueldo).Average(x => x.sueldo);
Console.WriteLine(sueldoMedio);


var consulta16 =
    from text in Persona
    where text.fechaNacimiento.Year < (2024 - 18) && text.sueldo % 2 == 0
    orderby (text.sueldo) 
    select text;
Console.WriteLine("");
Console.WriteLine("Ordenar por sueldo, para aquellos mayores de edad que tienen un sueldo par.");

foreach (var item in consulta16)
{
    Console.WriteLine($"{item.nombre} nacido el {item.fechaNacimiento.ToShortDateString()} con sueldo: {item.sueldo}");
}
Console.WriteLine("");