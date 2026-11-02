# DIO - Trilha .NET - Explorando a linguagem C#
www.dio.me

## Desafio de projeto
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de explorando a linguagem C#, da trilha .NET da DIO.

## Contexto
Você foi contratado para construir um sistema de hospedagem, que será usado para realizar uma reserva em um hotel. Você precisará usar a classe Pessoa, que representa o hóspede, a classe Suíte, e a classe Reserva, que fará um relacionamento entre ambos.

O seu programa deverá cálcular corretamente os valores dos métodos da classe Reserva, que precisará trazer a quantidade de hóspedes e o valor da diária, concedendo um desconto de 10% para caso a reserva seja para um período maior que 10 dias.

## Regras e validações
1. Não deve ser possível realizar uma reserva de uma suíte com capacidade menor do que a quantidade de hóspedes. Exemplo: Se é uma suíte capaz de hospedar 2 pessoas, então ao passar 3 hóspedes deverá retornar uma exception.
2. O método ObterQuantidadeHospedes da classe Reserva deverá retornar a quantidade total de hóspedes, enquanto que o método CalcularValorDiaria deverá retornar o valor da diária (Dias reservados x valor da diária).
3. Caso seja feita uma reserva igual ou maior que 10 dias, deverá ser concedido um desconto de 10% no valor da diária.


![Diagrama de classe estacionamento](diagrama_classe_hotel.png)

## Solução
O código está pela metade, e você deverá dar continuidade obedecendo as regras descritas acima, para que no final, tenhamos um programa funcional. Procure pela palavra comentada "TODO" no código, em seguida, implemente conforme as regras acima.

## ✅ Implementação realizada
Todos os "TODO" da classe `Reserva` foram implementados:

- **CadastrarHospedes**: verifica se a capacidade da suíte comporta a quantidade de hóspedes; caso contrário, lança uma `InvalidOperationException` com mensagem explicativa.
- **ObterQuantidadeHospedes**: retorna a quantidade total de hóspedes cadastrados.
- **CalcularValorDiaria**: calcula `DiasReservados x Suite.ValorDiaria` e aplica **10% de desconto** quando a reserva é de 10 dias ou mais.

O `Program.cs` demonstra os três cenários: reserva normal, reserva com desconto e tentativa de reserva acima da capacidade.

```
Hóspedes: 2
Valor diária: 150

Reserva de 10 dias (com 10% de desconto)
Hóspedes: 2
Valor diária: 270,00

Erro ao cadastrar hóspedes: A suíte Premium comporta no máximo 2 hóspede(s), mas foram informados 3.
```

O projeto foi atualizado para **.NET 8** (com `RollForward` para rodar em versões mais novas do runtime).

### Como executar
```bash
dotnet run
```
