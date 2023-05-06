using CleverCore.Application.ViewModels.Common;
using System.Collections.Generic;

namespace CleverCore.Application.Interfaces
{
    public interface ICommonService
    {
        FooterViewModel GetFooter();

        List<SlideViewModel> GetSlides(string groupAlias);

        SystemConfigViewModel GetSystemConfig(string code);
    }
}