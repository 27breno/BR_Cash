﻿//using BR_Cash.estidades;
//using BR_Cash.interfaces;

//Console.WriteLine("### Criar Conta 1 ###");
//Console.Write("Digite o tipo de conta (1 - Simples / 2 - Poupança): ");
//int tipoConta1 = int.Parse(Console.ReadLine());

//IConta conta1;
//if (tipoConta1 == 1)
//{
//    conta1 = new Conta();
//}
//else
//{
//    conta1 = new Conta_Poupanca();
//    Console.Write("Digite a taxa de juros da poupança: ");
//    double taxaDeJuros1 = double.Parse(Console.ReadLine());
//    ((Conta_Poupanca)conta1).DefinirTaxaDeJuros(taxaDeJuros1);  // Definir a taxa de juros para a conta poupança
//}

//// Criar a segunda conta
//Console.WriteLine("### Criar Conta 2 ###");
//Console.Write("Digite o tipo de conta (1 - Simples / 2 - Poupança): ");
//int tipoConta2 = int.Parse(Console.ReadLine());

//IConta conta2;
//if (tipoConta2 == 1)
//{
//    conta2 = new Conta();
//}
//else
//{
//    conta2 = new Conta_Poupanca();
//    Console.Write("Digite a taxa de juros da poupança: ");
//    double taxaDeJuros2 = double.Parse(Console.ReadLine());
//    ((Conta_Poupanca)conta2).TaxaDeJuros(taxaDeJuros2);  // Definir a taxa de juros para a conta poupança
//}

//// Realizar depósito na primeira conta
//Console.WriteLine("### Realizar Depósito na Conta 1 ###");
//Console.Write("Digite o valor do depósito: ");
//double deposito1 = double.Parse(Console.ReadLine());
//conta1.Depositar(deposito1);

//// Realizar depósito na segunda conta
//Console.WriteLine("### Realizar Depósito na Conta 2 ###");
//Console.Write("Digite o valor do depósito: ");
//double deposito2 = double.Parse(Console.ReadLine());
//conta2.Depositar(deposito2);

//// Realizar transferência entre contas
//Console.WriteLine("### Realizar Transferência ###");
//Console.Write("Digite o valor a ser transferido da Conta 1 para a Conta 2: ");
//double transferencia = double.Parse(Console.ReadLine());

//if (conta1.GetSaldo() >= transferencia)
//{
//    conta1.Depositar(-transferencia);  // Retira o valor da Conta 1
//    conta2.Depositar(transferencia);   // Adiciona o valor na Conta 2
//    Console.WriteLine($"Transferência de {transferencia:C} realizada com sucesso!");
//}
//else
//{
//    Console.WriteLine("Saldo insuficiente para a transferência.");
//}

//// Exibir as informações de ambas as contas
//Console.WriteLine("\n### Informações das Contas ###");
//Console.WriteLine("Conta 1:");
//conta1.ExibirInformacoe();
//Console.WriteLine("Conta 2:");
//conta2.ExibirInformacoe();
Console.WriteLine();