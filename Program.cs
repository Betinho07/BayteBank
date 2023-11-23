using BayteBank;

Cliente clienteAlberto = new();
clienteAlberto.Nome = "Alberto Trindade";
clienteAlberto.Cpf = "158.636.594-58";
clienteAlberto.Proficao = "Programador";

ContaCorrente contaDoAlberto = new (2504, "820814-56");
contaDoAlberto.Titular = clienteAlberto;
contaDoAlberto.Saldo = 100;

Cliente clienteJataniele = new();
clienteJataniele.Nome = "Jatanile";
clienteJataniele.Cpf = "152.585.784-78 ";
clienteJataniele.Proficao = "Analista De Dados";
  
ContaCorrente contaDaJataniele = new (2588,"271120-22");
contaDaJataniele.Titular = clienteJataniele;
contaDaJataniele.Saldo = 500;

ContaCorrente condaDaLucia = new(2525,"8844455-85");
condaDaLucia.Titular = new Cliente();
condaDaLucia.Titular.Nome = "Lucia Maria";
condaDaLucia.Titular.Cpf = "785.848.894-14";
condaDaLucia.Titular.Proficao = "Preguiça";
condaDaLucia.Saldo = -100;

contaDoAlberto.ExibiContaCorrete();
contaDaJataniele.ExibiContaCorrete();
condaDaLucia.ExibiContaCorrete();
Console.WriteLine($"Total de conta criada{ContaCorrente.TotalDeContaCriada}");