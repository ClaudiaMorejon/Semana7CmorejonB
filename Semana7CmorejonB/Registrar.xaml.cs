using Semana7CmorejonB.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana7CmorejonB
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registrar : ContentPage
    {
        private SQLiteAsyncConnection _conn;
        public Registrar()
        {
            InitializeComponent();
            _conn = DependencyService.Get<Database>().GetConnection();
            
        }

        private void btn_agregar_Clicked(object sender, EventArgs e)
        {
            try
            {
                var DatosRegistro = new Estudiante { Nombre = Nombre.Text, Usuario = Usuario.Text, Clave = Clave.Text };
                _conn.InsertAsync(DatosRegistro);
                limpiarFormulario();

            }catch(Exception ex)
            {
                DisplayAlert("Alerta", ex.Message, "OK");
            }


        }

        void limpiarFormulario()
        {
            Nombre.Text = "";
            Usuario.Text = "";
            Clave.Text = "";
            DisplayAlert("Alerta", "Se agregó correctamente", "OK");
        }
    }
}