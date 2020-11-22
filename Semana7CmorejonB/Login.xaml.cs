using Semana7CmorejonB.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana7CmorejonB
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
       
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Clicked(object sender, EventArgs e)
        {

        }

        private async void btn_registrar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Registrar());
        }

        public static IEnumerable<Estudiante> SELECT_WHERE(SQLiteConnection db,string usuario, string clave)
        {
            return db.Query<Estudiante>(SELECT * from Estudiante where Usuario =? and Clave =? usuario, clave);
        }
    }
}