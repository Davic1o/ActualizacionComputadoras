using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNNOrdenadores
{


    public class Ordenador
    {
        private int id;
        private static int contador;
        private int tamanioGB;
        private int tamanioGBMax;
        private bool encendido;

        private const int TAMANIO_DEFECTO = 100;

        public int getId()
        {
            return this.id;
        }
        public int gettamanioGBMax()
        {
            return this.tamanioGBMax;
        }

        public int gettamanioGB()
        {
           return this.tamanioGB;
        }
        public Ordenador(int tamanioGBMax)
        {
            id = contador++;
            this.tamanioGB = 0;
            this.encendido = false;

            if (tamanioGBMax <= 0)
            {
                this.tamanioGBMax = TAMANIO_DEFECTO;
            }
            else
            {
                this.tamanioGBMax = tamanioGBMax;
            }
        }


        public String aniadirDatos(int datos)
        {
            if (this.encendido)
            {
                if (datos <= 0)
                {
                    return "Los GB tienen que ser mayor que 0";
                }
                else
                {
                    if (this.tamanioGB + datos >= this.tamanioGBMax)
                    {
                        this.tamanioGB = this.tamanioGBMax;
                        return "Disco duro lleno";
                    }
                    else
                    {
                        this.tamanioGB += datos;
                        return "Se ha añadido informacion, actual: " + this.tamanioGB;
                    }
                }
            }
            else
            {
                return "El ordenador debe estar encendido";
            }
        }

        public String eliminarDatos(int datos)
        {
            if (this.encendido)
            {
                if (datos <= 0)
                {
                    return "Los GB tienen que ser mayor que 0";
                }
                else
                {
                    if (this.tamanioGB - datos <= 0)
                    {
                        this.tamanioGB = 0;
                        return "Disco duro vacio";
                    }
                    else
                    {
                        this.tamanioGB -= datos;
                        return "Se ha eliminado informacion, actual: " + this.tamanioGB;
                    }
                }
            }
            else
            {
                return "El ordenador debe estar encendido";
            }
        }

        public void encender()
        {
            this.encendido = true;
        }

        public void apagar()
        {
            this.encendido = false;
        }

    }
}
