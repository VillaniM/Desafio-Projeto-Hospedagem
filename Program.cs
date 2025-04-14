using Hospedagem.Models;

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa pessoa1 = new Pessoa(nome: "Hospede1");
Pessoa pessoa2 = new Pessoa(nome: "Hospede1");

hospedes.Add(pessoa1);
hospedes.Add(pessoa2);

Suite suite= new Suite(tipoSuite: "Premium", capacidade: 3, valorDiaria: 30);

Reserva reserva = new Reserva(diasReservados: 5);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);


Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
