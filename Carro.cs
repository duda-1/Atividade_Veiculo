using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Veiculo
{
    public  class Carro : Veiculo 
    {
        public string tipo { get; set; }   

        public override void ExibirDetalhes()
        {
          Console.WriteLine("------------------------Carro----------------------------");
          base.ExibirDetalhes();
          Console.WriteLine($"Tipo: {tipo}");
        }
        public override double CalcularConsumo(double distancia)
        {
            double gasto = base.CalcularConsumo(distancia);
            if (tipo == "Híbrido")
            {
                gasto *= 0.5;
            }
            return gasto;
        }
    }
}
