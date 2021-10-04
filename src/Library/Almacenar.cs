using System;

namespace SRP
{
    
public class Almacenar {

        public string SectorBiblioteca { get ; }
        public string EstanteBiblioteca { get ; }

        public void AlmacenarLibro(String sector, String estante)
        {
            this.SectorBiblioteca = sector;
            this.EstanteBiblioteca = estante;
        }
    
    }
}