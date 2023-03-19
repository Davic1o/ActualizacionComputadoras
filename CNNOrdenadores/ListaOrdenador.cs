using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNNOrdenadores
{
	public class ListaOrdenador
	{
		//Atributos
		private ArrayList ListA;

		//Constructores
		public ListaOrdenador()
		{
			ListA = new ArrayList();
		}
		public void setListaOrdenador(ArrayList a)
		{
			ListA = a;
		}

		//Propiedades
		public ArrayList getListaOrdenador()
		{
			return ListA;
		}



		//Metodos de objeto
		public void AgregarOrdenador(Ordenador a)
		{
			ListA.Add(a);
		}


		public Ordenador BuscarOrdenador(int id)
		{
			foreach (Ordenador a in ListA)
			{
				if (id == a.getId())
				{
					return a;
				}
			}
			return null;
		}

		public void eliminarOrdenador(int id)
		{
			foreach (Ordenador a in ListA)
			{
				if (id == a.getId())
				{
					ListA.Remove(a);
				}
			}
		}
		public void OrdenadoresTamanioMaximo()
        {
			foreach (Ordenador a in ListA)
			{
				if (a.gettamanioGB() == a.gettamanioGBMax())
                {
				

                }
                
                
				
			}
		}




	}
}
