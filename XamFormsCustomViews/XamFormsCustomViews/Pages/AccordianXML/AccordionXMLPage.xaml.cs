using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamFormsCustomViews.Pages.AccordianXML
{
    public partial class AccordionXMLPage : ContentPage
    {
        public AccordionXMLPage(AccordionXMLViewModel vm)
        {
            InitializeComponent();
            this.BindingContext = vm;
        }
    }
}
