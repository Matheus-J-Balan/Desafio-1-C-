void calcularMedia(){
double preMedia = 0;

try{
Console.WriteLine("Qual a quantidade de notas deseja inserir? ");

    int numNotas = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <= numNotas; i++){

    Console.WriteLine($"Digite a {i}º nota:");

    double notas = Convert.ToDouble(Console.ReadLine());
    
    preMedia = preMedia + notas;

}

double media = (preMedia) / numNotas;
Console.WriteLine($"A média do aluno foi: {media}");

if(media >= 6){
    Console.WriteLine("Aluno aprovado");
}else{
    Console.WriteLine("Aluno reprovado");
}

Console.WriteLine("Deseja calcular outra média? (Digite 1 se SIM):");
  
  int opcoes = Convert.ToInt32(Console.ReadLine());

if(opcoes == 1)
    calcularMedia();
}
catch
{
    Console.WriteLine("Valor invalido inserido");
    calcularMedia();
}
}
calcularMedia();