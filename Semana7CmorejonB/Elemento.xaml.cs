using Semana7CmorejonB.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana7CmorejonB
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Elemento : ContentPage
    {
        public int IdSeleccionado;
        private SQLiteAsyncConnection _conn;
        IEnumerable<Estudiante> ResultadoDelete;
        IEnumerable<Estudiante> ResultadoUpdate;
        public Elemento(int id)
        {
            InitializeComponent();
            _conn = DependencyService.Get<Database>().GetConnection();
            IdSeleccionado = id;
        }

        private void btn_actualizar_Clicked(object sender, EventArgs e)
        {
            try
            {
                var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "uisrael.db");
                var db = new SQLiteConnection(databasePath);
                ResultadoUpdate = Update(db, Nombre.Text,Usuario.Text,Clave.Text,IdSeleccionado);
                DisplayAlert("Alerta", "Se actualizó correctamente", "Ok");
            }
            catch (Exception ex)
            {
                DisplayAlert("Alerta", "Error" + ex.Message, "OK");
            }
        }

        private void btn_eliminar_Clicked(object sender, EventArgs e)
        {
            try
            {
                var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "uisrael.db");
                var db = new SQLiteConnection(databasePath);
                ResultadoDelete = Delete(db, IdSeleccionado);
                DisplayAlert("Alerta", "Se eliminó correctamente", "Ok");
            }
            catch(Exception ex)
            {
                DisplayAlert("Alerta", "Error" + ex.Message,"OK");
            }
          
        }

        public static IEnumerable<Estudiante> Delete(SQLiteConnection db,int id)
        {
            return db.Query<Estudiante>("DELETE FROM Estudiante where Id= ?", id);
        }

        public static IEnumerable<Estudiante> Update(SQLiteConnection db, string nombre,string usuario,string clave,int id)
        {
            return db.Query<Estudiante>("UPDATE FROM Estudiante SET Nombre= ? , Usuario =? ,"+
                "Clave =? where Id =?",nombre,usuario,clave,id);
        }
    }
}