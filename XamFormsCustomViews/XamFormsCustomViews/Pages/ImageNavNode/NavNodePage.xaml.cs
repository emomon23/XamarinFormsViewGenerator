using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamFormsCustomViews.Pages.ImageNavNode
{
    public partial class NavNodePage : ContentPage
    {
        public NavNodePage(NavNodeViewModel vm)
        {
            InitializeComponent();
            this.BindingContext = vm;

            foreach (var navNode in vm.NavigationNodes)
            {
                ImgBtnGenerator.AddButton(navNodesContainer, vm.ShowDetailPage, StyleSheet.Button_List_Width, StyleSheet.Button_List_Height, navNode, "expand_right.png", StyleSheet.Default_Label_Font_Size, Color.Olive, AlignImageEnumeration.Right);
            }
        }
    }
}
