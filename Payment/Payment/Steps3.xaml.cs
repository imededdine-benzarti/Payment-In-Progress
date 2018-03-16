using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Payment
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Steps3 : ContentPage
	{

        List<Products> ListProduct = new List<Products>()
            {
                new Products{ ProductName ="Gucci Hand Bag Light Brown", Status="New", Price="3000.00 SAR", Image="handbag.png", Brand="PRADA", Delete="delete.png"},
                new Products{ ProductName= "Gucci Hand Bag Light Brown",Status="New",Price="3000.00 SAR", Image="handbag.png", Brand="PRADA", Delete="delete.png"},
                new Products{ ProductName= "Gucci Hand Bag Light Brown",Status="New",Price="3000.00 SAR", Image="handbag.png", Brand="PRADA", Delete="delete.png"},
                 new Products{ ProductName= "Gucci Hand Bag Light Brown",Status="New",Price="3000.00 SAR", Image="handbag.png", Brand="PRADA", Delete="delete.png"},
                  new Products{ ProductName= "Gucci Hand Bag Light Brown",Status="New",Price="3000.00 SAR", Image="handbag.png", Brand="PRADA", Delete="delete.png"}

            };

        public Steps3 ()
		{
			InitializeComponent ();
          

            ListProductMenu.ItemsSource = ListProduct;
                
        }

        //void OnSelection(object sender, SelectedItemChangedEventArgs e)
        //{
        //    if (e.SelectedItem == null)
        //    {
        //        return; //ItemSelected is called on deselection, which results in SelectedItem being set to null
        //    }
        //    DisplayAlert("Item Selected", e.SelectedItem.ToString(), "Ok");

        //}

        private void Delete()
        {
            if (ListProduct.Count > 0)
            {
                ListProduct.RemoveAt(ListProduct.Count - 1);
            }
        }
    }
}