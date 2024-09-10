using System.Text;
using HOSPEDAGEM_DE_HOTEL.models;

Console.OutputEncoding = Encoding.UTF8;

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Kaio de Jesus Santana");
Pessoa p2 = new Pessoa(nome: "Angélica Aparecida Praça");

hospedes.Add(p1);
hospedes.Add(p2);

Suite suite = new Suite(tipoSuite: "Premium", capacidade: 3, valorDiaria: 30);

Reserva reserva = new Reserva(diasReservados: 5);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"Hóspedes : {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária : {reserva.CalcularValorDiaria()}");




