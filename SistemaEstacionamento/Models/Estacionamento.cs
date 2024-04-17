using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaEstacionamento.Models
{
    public class Estacionamento
    {
     private decimal precoInicial = 0 ;
     private decimal precoPorHora = 0 ;
     
     private List<String> veiculos =  new List<String>() ;
     public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

     public void AdicionarVeiculo(){
        System.Console.WriteLine("Digite a placa do veículo para estacionar"); 
        string placa =  Console.ReadLine();
        veiculos.Add(placa.ToUpper());
     }

     public void RemoverVeiculo(){
      Console.WriteLine("Digite a placa do veículo para remover:");
      string placa =  Console.ReadLine();
       string result = veiculos.Find(x=> x.ToUpper() == placa.ToUpper());
       int horasPermanecidas = 0;
       decimal valorTotal = 0;
       if (result != null){
         System.Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
         horasPermanecidas = int.Parse(Console.ReadLine());
         valorTotal = precoInicial + (precoPorHora * horasPermanecidas);
         veiculos.Remove(placa.ToUpper());
         Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
       }else{
        Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
       }

     }
     public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (string item in veiculos)
                {
                    System.Console.WriteLine(item); 
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}