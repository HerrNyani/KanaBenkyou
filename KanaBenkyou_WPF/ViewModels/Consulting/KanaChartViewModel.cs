using HerrNyani.KanaBenkyou.Models.Characters;
using System.Collections.Generic;
using System.Linq;

namespace HerrNyani.KanaBenkyou_WPF.ViewModels.Consulting
{
    public class KanaChartViewModel
    {
        private readonly MainWindowViewModel _mainWindowViewModel;

        public KanaChartViewModel(MainWindowViewModel mainWindowViewModel, IEnumerable<Kana> kanaList)
        {
            _mainWindowViewModel = mainWindowViewModel;
            Kana = kanaList.Select(k => new KanaChartItemViewModel(k));
        }

        public string ChartTitle { get; set; }

        public IEnumerable<KanaChartItemViewModel> Kana { get; }

        public bool CanReturnToStartPage => true;

        public void ReturnToStartPage()
        {
            _mainWindowViewModel.SetStartPageViewModel();
        }
    }
}
