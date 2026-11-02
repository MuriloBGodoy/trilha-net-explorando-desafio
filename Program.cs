using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hóspede 1");
Pessoa p2 = new Pessoa(nome: "Hóspede 2");

hospedes.Add(p1);
hospedes.Add(p2);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 5);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");

// Exemplo: reserva com 10 dias ou mais recebe 10% de desconto
Reserva reservaLonga = new Reserva(diasReservados: 10);
reservaLonga.CadastrarSuite(suite);
reservaLonga.CadastrarHospedes(hospedes);

Console.WriteLine();
Console.WriteLine($"Reserva de {reservaLonga.DiasReservados} dias (com 10% de desconto)");
Console.WriteLine($"Hóspedes: {reservaLonga.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reservaLonga.CalcularValorDiaria()}");

// Exemplo: suíte com capacidade menor que a quantidade de hóspedes gera exception
try
{
    List<Pessoa> muitosHospedes = new List<Pessoa>(hospedes) { new Pessoa(nome: "Hóspede 3") };
    Reserva reservaInvalida = new Reserva(diasReservados: 3);
    reservaInvalida.CadastrarSuite(suite);
    reservaInvalida.CadastrarHospedes(muitosHospedes);
}
catch (InvalidOperationException ex)
{
    Console.WriteLine();
    Console.WriteLine($"Erro ao cadastrar hóspedes: {ex.Message}");
}