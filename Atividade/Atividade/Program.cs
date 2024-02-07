
Console.WriteLine("Digite o seu peso em kg:");

var peso = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Digite a sua altura em metros:");

var altura = Convert.ToDouble(Console.ReadLine());

var imc = (peso / (altura * altura));

Console.WriteLine("Seu IMC é:" + imc);

if (imc < 18.5)

    Console.WriteLine("Abaixo do peso");

if (imc >= 18.5 && imc < 24.9)

    Console.WriteLine("Peso ideal");

if (imc >= 25 && imc < 30)

    Console.WriteLine("Levemente acima do peso");

if (imc >= 30 && imc < 35)

    Console.WriteLine("Peso ideal");


if (imc >= 35 && imc < 40)

    Console.WriteLine("Obesidade II");

if (imc >= 40)

    Console.WriteLine("Obesidade III");
