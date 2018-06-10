using Assisticant;
using Assisticant.Fields;
using HerrNyani.KanaBenkyou.Models.Characters;
using HerrNyani.KanaBenkyou_WPF.ViewModels.Consulting;
using HerrNyani.KanaBenkyou_WPF.ViewModels.Practising;

namespace HerrNyani.KanaBenkyou_WPF.ViewModels
{
    public class MainWindowViewModel :
        ViewModelLocatorBase
    {
        Observable<object> _activeViewModel = new Observable<object>();

        public MainWindowViewModel()
        {
            SetStartPageViewModel();
        }

        public void SetStartPageViewModel()
        {
            _activeViewModel.Value = new StartPageViewModel(this);
        }

        public void SetHiraganaChartViewModel()
        {
            _activeViewModel.Value = new KanaChartViewModel(this, Hiragana.Collection)
            {
                ChartTitle = "ひらがな - Hiragana"
            };
        }
        
        public void SetRomajiToHiraganaQuizViewModel()
        {
            _activeViewModel.Value = new KanaQuizViewModel(this, Hiragana.Collection, false);
        }

        public void SetHiraganaToRomajiQuizViewModel()
        {
            _activeViewModel.Value = new KanaQuizViewModel(this, Hiragana.Collection, true);
        }


        public void SetKatakanaChartViewModel()
        {
            _activeViewModel.Value = new KanaChartViewModel(this, Katakana.Collection)
            {
                ChartTitle = "カタカナ - Katakana"
            };
        }

        public void SetRomajiToKatakanaQuizViewModel()
        {
            _activeViewModel.Value = new KanaQuizViewModel(this, Katakana.Collection, false);
        }

        public void SetKatakanaToRomajiQuizViewModel()
        {
            _activeViewModel.Value = new KanaQuizViewModel(this, Katakana.Collection, true);
        }

        public object ActiveViewModel => ForView.Wrap(_activeViewModel.Value);
    }
}
