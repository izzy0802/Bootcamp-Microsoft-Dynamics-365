using System.Text;
using Hospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa("Isis","Santos");
Pessoa p2 = new Pessoa("sla","teste");

hospedes.Add(p1);
hospedes.Add(p2);

Suite suite = new Suite("premium", 3, 20);

Reserva reserva = new Reserva(5);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
