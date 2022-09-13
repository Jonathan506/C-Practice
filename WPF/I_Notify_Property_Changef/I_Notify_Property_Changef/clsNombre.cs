using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_Notify_Property_Changef
{
    public  class clsNombre : INotifyPropertyChanged
    {
        private string nombre;
        private string apellido;
        private string nombreCompleto;

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
                OnPropertyChanged("NombreCompleto");   }
        }
        public string Apellido 
        {
            get { return apellido; }
            set { apellido = value;
                OnPropertyChanged("NombreCompleto");
            }
        }
        public string NombreCompleto 
        {
            get { nombreCompleto=Nombre + " " + Apellido;
                return nombreCompleto;
            }
            set { nombreCompleto = value;
                nombre = nombreCompleto.Split(' ')[0];
                apellido = nombreCompleto.Split(' ')[1];
                OnPropertyChanged("Nombre");
                OnPropertyChanged("Apellido");
            }
        }
    }
}
