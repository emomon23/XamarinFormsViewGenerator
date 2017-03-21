using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamFormsCustomViews.Pages.DynamicAccordian
{
    public partial class DynamicAccordionPage : ContentPage
    {
        private DynamicAccordionViewModel _vm;

        public DynamicAccordionPage(DynamicAccordionViewModel vm)
        {
            InitializeComponent();
            this.BindingContext = vm;
            _vm = vm;

            foreach (var category in vm.Categories)
            {
                var content = CreateMenuCategoryContent(category);
                var menuCategoryNode = AccordionFactory.CreateNewNode(
                    new AcNodeConfiguration()
                    {
                        HeaderText = category,
                        HeaderBackGroundColor = StyleSheet.Button_BackColor,
                        HeaderTextColor = StyleSheet.Button_TextColor,
                        FontSize = StyleSheet.AccordionNode_HeaderFontSize,
                        HeaderFontAttributes = StyleSheet.AccordNode_HeaderFontAttributes,
                        ExpandedContentHeight = 100
                    },
                    content);

                accordionContainer.Children.Add(menuCategoryNode);
            }
        }

        private ScrollView CreateMenuCategoryContent(string category)
        {
            StackLayout stackLayout = new StackLayout();

            foreach (var mi in _vm.GetMenuItems(category))
            {
                Label lbl = new Label() {Text = $"{mi.Name} - {mi.Price}"};
                ImgBtnGenerator.GetInstance().SetTapGestureRecognizer(lbl, _vm.MenuItemSelected, mi.Name);

                stackLayout.Children.Add(lbl);
            }

            return new ScrollView() {Content = stackLayout };
        }
    }
}
