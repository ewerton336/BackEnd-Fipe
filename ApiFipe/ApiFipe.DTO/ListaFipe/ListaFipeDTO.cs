using ApiFipe.Domain.Fabricante.Carros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ApiFipe.DTO.ListaFipe
{
    public static class ListaFipeDTO
    {

        public static List<Carro> Carros { get; set; }

        public static List<Carro>  GetListaCarros()
        {
            return Carros;
        }

        public static List<Carro> AddCarro(Carro carro)
        {
            Carros.Add(carro);
            return Carros;
        }

        public static List<Carro> RemoveCarro(Carro carro)
        {
            Carros.Remove(carro);
            return Carros;
        }

        public static List<Carro> EditCarro(Carro carro)
        {
            var carroOld = Carros.First(x => x.IdCarro == carro.IdCarro);
            Carros.Remove(carroOld);
            Carros.Add(carro);
            return Carros;
        }


    }
}
