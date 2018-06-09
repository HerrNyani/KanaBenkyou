using Assisticant.Fields;
using HerrNyani.KanaBenkyou.Models.Characters;
using HerrNyani.KanaBenkyou_WPF.ViewModels.Consulting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Media;

namespace HerrNyani.KanaBenkyou_WPF.ViewModels.Practising
{
    public class RomajiToKanaQuizViewModel
    {
        private readonly Brush _positiveResultBrush = (Brush)new BrushConverter().ConvertFrom("#AAE49C");
        private readonly Brush _negativeResultBrush = (Brush)new BrushConverter().ConvertFrom("#DF7181");

        private readonly MainWindowViewModel _mainWindowViewModel;
        private readonly Observable<KanaChartItemViewModel> _selectedKanaItemViewModel;
        private readonly Observable<KanaChartItemViewModel> _questionKanaItemViewModel;
        private readonly Observable<Visibility> _answerVisibility;
        private readonly Observable<bool> _canSelectAnswer;
        private readonly Observable<Brush> _backgroundBrush;

        private readonly Random _randomGenerator = new Random();

        public RomajiToKanaQuizViewModel(MainWindowViewModel mainWindowViewModel, IEnumerable<Kana> kanaList)
        {
            _mainWindowViewModel = mainWindowViewModel;
            Kana = kanaList.Select(k => new KanaChartItemViewModel(k)).ToList();

            _selectedKanaItemViewModel = new Observable<KanaChartItemViewModel>();
            _questionKanaItemViewModel = new Observable<KanaChartItemViewModel>();
            _answerVisibility = new Observable<Visibility>();
            _canSelectAnswer = new Observable<bool>();
            _backgroundBrush = new Observable<Brush>();

            SetNextQuestion();
        }

        public Brush BackgroundBrush => _backgroundBrush.Value;

        public IList<KanaChartItemViewModel> Kana { get; }

        public KanaChartItemViewModel QuestionKana => _questionKanaItemViewModel.Value;

        public KanaChartItemViewModel SelectedKana
        {
            get
            {
                return _selectedKanaItemViewModel.Value;
            }
            set
            {
                _selectedKanaItemViewModel.Value = value;
            }
        }

        public Visibility AnswerVisibility => _answerVisibility.Value;

        public bool CanSelectAnswer => _canSelectAnswer.Value;

        public bool CanSetNextQuestion => !CanSelectAnswer;

        public void SetNextQuestion()
        {
            SelectedKana = null;

            _answerVisibility.Value = Visibility.Collapsed;
            _backgroundBrush.Value = null;

            int questionIndex = _randomGenerator.Next(0, Kana.Count());
            _questionKanaItemViewModel.Value = Kana[questionIndex];

            _canSelectAnswer.Value = true;
        }

        public bool CanReturnToStartPage => true;

        public void ReturnToStartPage()
        {
            _mainWindowViewModel.SetStartPageViewModel();
        }

        public bool CanVerifyAnswer => CanSelectAnswer;

        public void VerifyAnswer()
        {
            if(SelectedKana == null)
            {
                return;
            }

            _canSelectAnswer.Value = false;

            _backgroundBrush.Value = QuestionKana.Equals(SelectedKana) ? 
                _positiveResultBrush :
                _negativeResultBrush;

            _answerVisibility.Value = Visibility.Visible;
        }
    }
}
