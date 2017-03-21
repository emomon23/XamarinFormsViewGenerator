using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamFormsCustomViews.Pages.DetailPage
{
    public partial class DetailPage : ContentPage
    {
        public DetailPage(string pageText)
        {
            InitializeComponent();
            txtDetailPage.Text = $"This is the detail page for {pageText}";
        }
    }
}
