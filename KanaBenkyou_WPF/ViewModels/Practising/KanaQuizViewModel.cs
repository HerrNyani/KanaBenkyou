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
    public class KanaQuizViewModel
    {
        private readonly Brush _positiveResultBrush = (Brush)new BrushConverter().ConvertFrom("#AAE49C");
        private readonly Brush _negativeResultBrush = (Brush)new BrushConverter().ConvertFrom("#DF7181");

        private readonly MainWindowViewModel _mainWindowViewModel;
        private readonly Observable<KanaChartItemViewModel> _selectedKanaItemViewModel = new Observable<KanaChartItemViewModel>();
        private readonly Observable<KanaChartItemViewModel> _questionKanaItemViewModel = new Observable<KanaChartItemViewModel>();

        private readonly Observable<Visibility> _answerVisibility = new Observable<Visibility>();
        private readonly Observable<bool> _canSelectAnswer = new Observable<bool>();
        private readonly Observable<Brush> _backgroundBrush = new Observable<Brush>();
        private readonly Observable<int> _correctAnswerCount = new Observable<int>(0);
        private readonly Observable<int> _totalAnswerCount = new Observable<int>(0);

        private readonly bool _isKanaToRomajiMode;

        private readonly Random _randomGenerator = new Random();

        public KanaQuizViewModel(MainWindowViewModel mainWindowViewModel, IEnumerable<Kana> kanaList, bool isKanaToRomajiMode)
        {
            _mainWindowViewModel = mainWindowViewModel;
            Kana = kanaList.Select(k => new KanaChartItemViewModel(k)).ToList();
            
            _isKanaToRomajiMode = isKanaToRomajiMode;

            SetNextQuestion();
        }

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

        public Brush BackgroundBrush => _backgroundBrush.Value;

        public Visibility AnswerButtonRomajiVisibility => _isKanaToRomajiMode ?
            Visibility.Visible : Visibility.Collapsed;

        public Visibility AnswerButtonKanaVisibility => _isKanaToRomajiMode ?
            Visibility.Collapsed : Visibility.Visible;

        public Visibility KanaAnswerVisibility => _isKanaToRomajiMode ?
            Visibility.Visible : AnswerVisibility;

        public Visibility RomajiAnswerVisibility => _isKanaToRomajiMode ?
            AnswerVisibility : Visibility.Visible;

        public int CorrectAnswerCount => _correctAnswerCount.Value;
        public int TotalAnswerCount => _totalAnswerCount.Value;
        public double CorrectPercentage => TotalAnswerCount == 0 ? 
            0 : 
            (double)CorrectAnswerCount / (double)TotalAnswerCount * 100.0;

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
            if (SelectedKana == null)
            {
                return;
            }

            _canSelectAnswer.Value = false;
            _totalAnswerCount.Value += 1;

            if(QuestionKana.Equals(SelectedKana))
            {
                _correctAnswerCount.Value += 1;
                _backgroundBrush.Value = _positiveResultBrush;
            }
            else
            {
                _backgroundBrush.Value = _negativeResultBrush;
            }

            _answerVisibility.Value = Visibility.Visible;
        }
    }
}
