using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.StoreReview;
using Xamarin.Forms;

namespace AppRatingTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            CrossStoreReview.Current.RequestReview(false);

        }
    }
}

