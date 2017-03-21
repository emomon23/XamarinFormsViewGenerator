using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamFormsCustomViews.Pages.ImageNavNode
{
    public class NavNodeViewModel : BaseViewModel
    {
        public NavNodeViewModel(IMyNavigationService navService) : base(navService) { }

        public async Task ShowDetailPage(string btnText)
        {
            _myNavigationService.NavigateToDetailPage(btnText);
        }

        public List<string> NavigationNodes
        {
            get
            {
                return new List<string>() {"My Tacklebox", "Boats", "My Fish", "Preferences"};
            }
        }
    }
}
