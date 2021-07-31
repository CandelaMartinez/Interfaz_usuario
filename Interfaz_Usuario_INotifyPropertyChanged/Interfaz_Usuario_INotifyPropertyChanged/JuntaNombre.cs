using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz_Usuario_INotifyPropertyChanged
{
    public class JuntaNombre: INotifyPropertyChanged
    {

        private string nombre, apellido, nombreCompleto;

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value;

                //a que propiedad tengo que llamar al haber un cambio
                OnPropertyChanged("Nombre_Completo");
            }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value;

                OnPropertyChanged("Nombre_Completo");
            }
            

        }

        public string Nombre_Completo
        {
            get { nombreCompleto = Nombre + " " + Apellido;
                return nombreCompleto;
            }
            set {  }
        }
    }
}
