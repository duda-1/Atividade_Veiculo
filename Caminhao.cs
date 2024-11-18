using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Veiculo
{
    public class Caminhao : Veiculo 
    {
        public double carro { get; set; }

        public override void ExibirDetalhes()
        {
            Console.WriteLine("------------------------Caminhao----------------------------");
            base.ExibirDetalhes();
            Console.WriteLine($"Tipo: {carro}");
        }
        public override double CalcularConsumo(double distancia)
        {
            double gasto = base.CalcularConsumo(distancia);
            if (carro > 10)
            {
                gasto *= 0.10;
            }
            return gasto;
        }
    }
}
