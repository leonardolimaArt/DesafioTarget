using DesafioTarget.Model;

//1
Console.WriteLine("\n1---------");
Soma soma = new Soma();
Console.WriteLine($"Soma: {soma.calcularSoma()}");
 
//2
Console.WriteLine("\n2---------");
Fibbo fibbo = new Fibbo();
fibbo.calcularFibbo(11);

//3
Console.WriteLine("\n3---------");
Logica logica = new Logica();
logica.calcularLogica();

//5
Console.WriteLine("\n\n5---------");
StringInvert s = new StringInvert();
s.inverterString("Leonardo");