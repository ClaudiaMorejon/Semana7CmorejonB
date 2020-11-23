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
    public partial class ConsultaRegistro : ContentPage
    {
        public ConsultaRegistro()
        {
            InitializeComponent();
        }

        private void ListaUsuario_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}