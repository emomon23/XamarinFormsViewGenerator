using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamFormsCustomViews.Pages.AccordianXML
{
    public class AccordionXMLViewModel : BaseViewModel
    {
        public AccordionXMLViewModel(IMyNavigationService navService) : base(navService) {
            VeggiesAccordionNode = new AccordionNodeViewModel("Veggies", 200, Color.Aqua, Color.Maroon, Color.Fuchsia);
            FruitAccordionNode = new AccordionNodeViewModel("Fruit", 55, Color.Green, Color.Black);
        }

        public AccordionNodeViewModel VeggiesAccordionNode { get; private set; }
        public AccordionNodeViewModel FruitAccordionNode { get; private set; }

        public string[] VeggieList
        {
            get
            {
                return new string[] { "Carrots", "Potatos", "Onions", "Beans" };
            }
        }
    }
}
