using Semana7CmorejonB.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana7CmorejonB
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConsultaRegistro : ContentPage
    {
        private SQLiteAsyncConnection _conn;
        private ObservableCollection<Estudiante> _Tablaestudiante;
        public ConsultaRegistro()
        {
            InitializeComponent();
            _conn = DependencyService.Get<Database>().GetConnection();
            NavigationPage.SetHasBackButton(this, false);
        }
        protected async override void OnAppearing()
        {
            var ResulRegistros = await _conn.Table<Estudiante>().ToListAsync();
            _Tablaestudiante = new ObservableCollection<Estudiante>(ResulRegistros);
            ListaUsuario.ItemsSource = _Tablaestudiante;
            base.OnAppearing();        
        }

        void OnSelection(object sender,SelectedItemChangedEventArgs e)
        {
            var obj = (Estudiante)e.SelectedItem;
            var item = obj.Id.ToString();
            int ID = Convert.ToInt32(item);
            try
            {
                Navigation.PushAsync(new Elemento(ID));
            }
            catch(Exception )
            {
                throw;
            }
        }
        private void ListaUsuario_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }

        
    }
}