using System;
class Program
{
    static void Main()
    {
        string[] pocoes = { "Cura", "Mana" };

        // Verifique se pocoes.Length > 0
        // Se sim: Console.WriteLine("Poção consumida!");
        // Senão: Console.WriteLine("Inventário Vazio!");
        if (pocoes.Length > 0)
        {
            Console.WriteLine("Poção consumida!");
        }
        else
        {
            Console.WriteLine("Iventário Vazio!");
        }

        int nivelJogador = 55;

        // Se nivelJogador >= 50: "Porta VIP liberada!"
        // Senão: "Vá para treinamento!"
        if(nivelJogador>=50)
        {
            Console.WriteLine("Porta VIP liberada!");
        }
        else
        {
            Console.WriteLine("Vá para treinamento!");
        }

        int noAtual = 50;
        int valorProcurado = 85;

        // Compare valorProcurado com noAtual
        // Maior: "Ir para DIREITA"
        // Menor: "Ir para ESQUERDA"
        if(valorProcurado>noAtual)
        {
            Console.WriteLine("Ir para DIREITA");
        }
        else
        {
            Console.WriteLine("Ir para ESQUERDA");
        }     
    }
}