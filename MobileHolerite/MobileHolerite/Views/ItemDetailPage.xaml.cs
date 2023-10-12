using MobileHolerite.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MobileHolerite.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}