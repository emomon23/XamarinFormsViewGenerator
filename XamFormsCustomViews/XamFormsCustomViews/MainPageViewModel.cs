using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamFormsCustomViews
{
    public class MainPageViewModel : BaseViewModel
    {
        public MainPageViewModel(IMyNavigationService navService) : base(navService) { }

        public ICommand ToAccordionXML
        {
            get
            {
                return new Command (async () =>
                {
                    await _myNavigationService.NavigateToAccordionXMLPage();
                });
            }
        }

        public ICommand ToDynamicAccordion
        {
            get
            {
                return new Command(async () =>
                {
                    await _myNavigationService.NavigateToDynamicAccordionListPage();
                });
            }
        }

        public ICommand ToImageButtons
        {
            get
            {
                return new Command(async () =>
                {
                    await _myNavigationService.NavigateToImageButtonsPage();
                });
            }
        }

        public ICommand ToImageNavNode
        {
            get
            {
                return new Command(async () =>
                {
                    await _myNavigationService.NavigateToImageNavNode();
                });
            }
        }
    }
}
