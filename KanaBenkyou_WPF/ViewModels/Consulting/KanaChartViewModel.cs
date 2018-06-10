using Assisticant;
using Assisticant.Fields;
using HerrNyani.KanaBenkyou.Models.Characters;
using System.Collections.Generic;
using System.Linq;

namespace HerrNyani.KanaBenkyou_WPF.ViewModels.Consulting
{
    public class KanaChartViewModel
    {
        private readonly MainWindowViewModel _mainWindowViewModel;
        private Observable<KanaChartItemViewModel> _selectedKana;

        public KanaChartViewModel(MainWindowViewModel mainWindowViewModel, IEnumerable<Kana> kanaList)
        {
            _mainWindowViewModel = mainWindowViewModel;
            _selectedKana = new Observable<KanaChartItemViewModel>();
            Kana = kanaList.Select(k => new KanaChartItemViewModel(k));

            SelectedKana = Kana.FirstOrDefault();
        }

        public string ChartTitle { get; set; }

        public IEnumerable<KanaChartItemViewModel> Kana { get; }

        public KanaChartItemViewModel SelectedKana
        {
            get { return _selectedKana.Value; }
            set { _selectedKana.Value = value; }
        }

        public object KanaDetailViewModel => SelectedKana == null ?
            null :
            ForView.Wrap(new KanaDetailViewModel(SelectedKana.Kana));

        public bool CanReturnToStartPage => true;

        public void ReturnToStartPage()
        {
            _mainWindowViewModel.SetStartPageViewModel();
        }


    }
}
