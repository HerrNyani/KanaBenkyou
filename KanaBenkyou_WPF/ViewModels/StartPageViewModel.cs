namespace HerrNyani.KanaBenkyou_WPF.ViewModels
{
    public class StartPageViewModel
    {
        private readonly MainWindowViewModel _mainWindowViewModel;
        
        public StartPageViewModel(MainWindowViewModel mainWindowViewModel)
        {
            _mainWindowViewModel = mainWindowViewModel;
        }
        
        public void SetHiraganaChartViewModel()
        {
            _mainWindowViewModel.SetHiraganaChartViewModel();
        }
        
        public void SetRomajiToHiraganaQuizViewModel()
        {
            _mainWindowViewModel.SetRomajiToHiraganaQuizViewModel();
        }
        
        public void SetHiraganaToRomajiQuizViewModel()
        {
            _mainWindowViewModel.SetHiraganaToRomajiQuizViewModel();
        }
        
        public void SetKatakanaChartViewModel()
        {
            _mainWindowViewModel.SetKatakanaChartViewModel();
        }
        
        public void SetRomajiToKatakanaQuizViewModel()
        {
            _mainWindowViewModel.SetRomajiToKatakanaQuizViewModel();
        }
        
        public void SetKatakanaToRomajiQuizViewModel()
        {
            _mainWindowViewModel.SetKatakanaToRomajiQuizViewModel();
        }
    }
}
