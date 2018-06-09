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
    }
}
