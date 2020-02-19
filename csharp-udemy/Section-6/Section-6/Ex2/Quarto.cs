using System;
namespace Ex2
{
    public class Quarto
    {
        public bool Ocupado { get; set; }
        public Estudante Ocupante { get; set; }

        public Quarto()
        {
        }

        public Quarto(bool ocupado)
        {
            Ocupado = ocupado;
            Ocupante = null;
        }

        public override string ToString()
        {
            if (Ocupado == true)
                return "Quarto ocupado por:\n" + Ocupante;
            else
                return "Quarto desocupado";
        }
    }
}
