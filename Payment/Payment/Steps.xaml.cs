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
	public partial class Steps : ContentPage
	{
		public Steps ()
		{
			InitializeComponent ();
		}

        private void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
        {
            if (sender.Equals(CreditCard))
            {
                CreditCard.BackgroundColor = Color.Black;
                Credit.BackgroundColor = Color.White;
            }

        }

        private void BankTransfer_OnTapped(object sender, EventArgs e)
        {
            if (sender.Equals(BankTransfer))
            {
                BankTransfer.BackgroundColor = Color.Black;
                Bank.BackgroundColor = Color.White;
            }

        }

        private void Express_OnTapped(object sender, EventArgs e)
        {
            if (sender.Equals(Express))
            {
                Express.BackgroundColor = Color.Black;
                Expresses.BackgroundColor = Color.White;
            }

        }

        private void Normal_OnTapped(object sender, EventArgs e)
        {
            if (sender.Equals(Normal))
            {
                Normal.BackgroundColor = Color.Black;
                Normals.BackgroundColor = Color.White;
            }

        }





    }
}
