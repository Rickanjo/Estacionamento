Console.Write("Informe o tamanho do veículo [P]equeno ou [G]rande: ");
string tamanho = Console.ReadLine()!;

Console.Write("Informe o tempo de permanência (em minutos): ");
int tempo = Convert.ToInt32(Console.ReadLine());

Console.Write("Foi utilizado o serviço de valet? [S]im ou [N]ão: ");
string valet = Console.ReadLine()!;

Console.Write("Deseja incluir o serviço de lavagem? [S]im ou [N]ão: ");
string lavagem = Console.ReadLine()!;

double valorHoraAdicional = (tamanho == "G") ? 20.0 : 10.0;

double valorDiaria = (tamanho == "G") ? 80.0 : 50.0;

double valorLavagem = (tamanho == "G") ? 100.0 : 50.0;

double valorFinal = 0.0;

 if (tempo <= 60) 
{
    valorFinal += 20.0;
} else if (tempo <= 720) 
{ 
    int horasAdicionais = (int)Math.Ceiling((double)(tempo - 60) / 60);
    valorFinal += 20.0 + (horasAdicionais * valorHoraAdicional);

    if (horasAdicionais >= 5) 
    {
        valorFinal = valorDiaria;
    }
    } else 
    {
      valorFinal = valorDiaria;
    }

    if (valet == "S") 
    {
      valorFinal += valorFinal * 0.2; // 20% adicional
    }
    if (lavagem == "S") 
    {
      valorFinal += valorLavagem;
    }

    Console.WriteLine("Valor final a ser pago: R$ " + valorFinal.ToString("0.00"));
