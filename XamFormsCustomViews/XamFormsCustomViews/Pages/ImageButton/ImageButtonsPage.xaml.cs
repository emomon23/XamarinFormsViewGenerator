using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamFormsCustomViews.Pages.ImageButton
{
    public partial class ImageButtonsPage : ContentPage
    {
        public ImageButtonsPage(ImageButtonsViewModel vm)
        {
            InitializeComponent();
            this.BindingContext = vm;

            foreach (var fish in vm.AvailableFishSpecies)
            {
                ImgBtnGenerator.AddButton(btnContainer, vm.FishSelected, StyleSheet.Button_List_Width, StyleSheet.Button_List_Height, fish.Name, fish.Icon, StyleSheet.Default_Label_Font_Size, Color.Blue);
            }
        }
    }
}
