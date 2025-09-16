using System.Collections.Generic;
using System;
using ParkingSystemApi.Models;
using System.Linq;


namespace ParkingSystemApi.Services
{
    public class EstacionamentoService
    {
        private readonly List<Veiculo> veiculos = new();
        private readonly decimal precoPorHora = 5.0m;

        public void AdicionarVeiculo(string placa)
        {
            veiculos.Add(new Veiculo { Placa = placa });
        }

        public decimal? RemoverVeiculo(string placa)
        {
            var veiculo = veiculos.FirstOrDefault(v => v.Placa == placa);
            if (veiculo == null) return null;

            var tempo = DateTime.Now - veiculo.Entrada;
            var valor = (decimal)Math.Ceiling(tempo.TotalHours) * precoPorHora;

            veiculos.Remove(veiculo);
            return valor;
        }

        public List<Veiculo> ListarVeiculos()
        {
            return veiculos;
        }
    }
}
