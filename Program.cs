﻿double percentualDeBonus, percentualDeRetorno, pontosATransferir;
double pontosAReduzir, pontosAAcresentar;
 
Console.Clear();
 
 
Console.WriteLine("--- Milhas Bumerangue ---\n");
 
Console.Write("Percentual de bônus.....: ");
percentualDeBonus = Convert.ToDouble(Console.ReadLine());
 
Console.Write("Percentual de retorno.....: ");
percentualDeRetorno = Convert.ToDouble(Console.ReadLine());
 
Console.Write("Pontos a transferir.....: ");
pontosATransferir = Convert.ToDouble(Console.ReadLine());
 
pontosAReduzir = pontosATransferir - (pontosATransferir * percentualDeRetorno)/100;
pontosAAcresentar = pontosATransferir + (pontosATransferir * percentualDeBonus)/100;
 
Console.WriteLine($"Pontos a reduzir na origem........: {pontosAReduzir}");
Console.WriteLine($"Pontos a acrescentar no destino...: {pontosAAcresentar}");
