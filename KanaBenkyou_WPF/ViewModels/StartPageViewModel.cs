namespace HerrNyani.KanaBenkyou_WPF.ViewModels
{
    public class StartPageViewModel
    {
        private readonly MainWindowViewModel _mainWindowViewModel;
        
        public StartPageViewModel(MainWindowViewModel mainWindowViewModel)
        {
            _mainWindowViewModel = mainWindowViewModel;
        }

        public bool CanSetHiraganaChartViewModel => true;

        public void SetHiraganaChartViewModel()
        {
            _mainWindowViewModel.SetHiraganaChartViewModel();
        }

        public bool CanSetRomajiToHiraganaQuizViewModel => true;

        public void SetRomajiToHiraganaQuizViewModel()
        {
            _mainWindowViewModel.SetRomajiToHiraganaQuizViewModel();
        }

        public bool CanSetHiraganaToRomajiQuizViewModel => true;

        public void SetHiraganaToRomajiQuizViewModel()
        {
            _mainWindowViewModel.SetHiraganaToRomajiQuizViewModel();
        }
    }
}
