using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XamFormsCustomViews.Pages.AccordianXML;
using XamFormsCustomViews.Pages.DynamicAccordian;
using XamFormsCustomViews.Pages.ImageButton;
using XamFormsCustomViews.Pages.ImageNavNode;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamFormsCustomViews.Pages.DetailPage;

namespace XamFormsCustomViews
{
    public interface IMyNavigationService
    {
        Task NavigateToAccordionXMLPage();
        Task NavigateToDynamicAccordionListPage();
        Task NavigateToImageButtonsPage();
        Task NavigateToImageNavNode();
        Task NavigateToDetailPage(string btnPage);
    }

    public class MyNavigationService : IMyNavigationService
    {
        private INavigation _navigator;
       
        public MyNavigationService(INavigation navigator)
        {
            _navigator = navigator;
        }

        public async Task NavigateToAccordionXMLPage()
        {
            AccordionXMLViewModel vm = new AccordionXMLViewModel(this);
            var newPage = new AccordionXMLPage(vm);

            await _navigator.PushAsync(newPage);
        }

        public async Task NavigateToDynamicAccordionListPage()
        {
            DynamicAccordionViewModel vm = new DynamicAccordionViewModel(this);
            var newPage = new DynamicAccordionPage(vm);

            await _navigator.PushAsync(newPage);
        }

        public async Task NavigateToImageButtonsPage()
        {
            ImageButtonsViewModel vm = new ImageButtonsViewModel(this);
            var newPage = new ImageButtonsPage(vm);

            await _navigator.PushAsync(newPage);
        }

        public async Task NavigateToImageNavNode()
        {
            var vm = new NavNodeViewModel(this);
            var page = new NavNodePage(vm);

           await  _navigator.PushAsync(page);
        }

        public async Task NavigateToDetailPage(string pageText)
        {
            await _navigator.PushAsync(new DetailPage(pageText));
        }

        public async Task NavigateBackToMainPage()
        {
            await _navigator.PopAsync();
        }
    }
}
