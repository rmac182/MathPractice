using MathPractice.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MathPractice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
   
    public partial class MainWindow : Window
    {
        public Random rnd = new Random();
        bool Adding = true;
        bool Subtracting = false;
        bool Multiplying = false;
        bool Dividing = false;

        MainViewModel _main = new MainViewModel();
        MediaPlayer mediaPlayer = new MediaPlayer();
        public MainWindow()
        {
            InitializeComponent();
            InputTextBox.Focus();
            _main.Result.DefaultImage();
            DataContext = _main;
        }
            
           
           
            
            
        private void NewProblemButton_Click(object sender, RoutedEventArgs e)
        {
            if (Adding)
            {
                _main.Equation.NewAdditionExpression();
                InputTextBox.Text = "";
                InputTextBox.Focus();
                _main.Result.DefaultImage();

            }
            else if (Subtracting)
            {
                _main.Equation.NewSubtractionExpression();
                InputTextBox.Text = "";
                InputTextBox.Focus();
                _main.Result.DefaultImage();

            }
            else if (Multiplying)
            {
                _main.Equation.NewMultiplicationExpression();
                InputTextBox.Text = "";
                InputTextBox.Focus();
                _main.Result.DefaultImage();

            }
            else if(Dividing)
            {
                _main.Equation.NewDivisionExpression();
                InputTextBox.Text = "";
                InputTextBox.Focus();
                _main.Result.DefaultImage();

            }



        }

        private void SubmitAnswerButton_Click(object sender, RoutedEventArgs e)
        {

            if (Adding)
            {
                if(_main.Equation.GetSum() == _main.Equation.UserInput)
                {
                   _main.Result.GetImagePath(_main.Result.result = "Correct");
                    mediaPlayer.Open(new Uri("C:\\Users\\McPherson\\source\\repos\\MathPractice\\MathPractice\\SoundFx\\CorrectAudio.mp3"));
                    mediaPlayer.Play();
                }
                else
                {
                    _main.Result.GetImagePath(_main.Result.result = "Incorrect");
                    mediaPlayer.Open(new Uri("C:\\Users\\McPherson\\source\\repos\\MathPractice\\MathPractice\\SoundFx\\IncorrectAudio.mp3"));
                    mediaPlayer.Play();
                }

                

            }
            else if (Subtracting)
            {
                if (_main.Equation.GetDifference() == _main.Equation.UserInput)
                {
                    _main.Result.GetImagePath(_main.Result.result = "Correct");
                    mediaPlayer.Open(new Uri("C:\\Users\\McPherson\\source\\repos\\MathPractice\\MathPractice\\SoundFx\\CorrectAudio.mp3"));
                    mediaPlayer.Play();
                }
                else
                {
                    _main.Result.GetImagePath(_main.Result.result = "Incorrect");
                    mediaPlayer.Open(new Uri("C:\\Users\\McPherson\\source\\repos\\MathPractice\\MathPractice\\SoundFx\\IncorrectAudio.mp3"));
                    mediaPlayer.Play();

                }
            }
            else if (Multiplying)
            {
                if (_main.Equation.GetProduct() == _main.Equation.UserInput)
                {
                    _main.Result.GetImagePath(_main.Result.result = "Correct");
                    mediaPlayer.Open(new Uri("C:\\Users\\McPherson\\source\\repos\\MathPractice\\MathPractice\\SoundFx\\CorrectAudio.mp3"));
                    mediaPlayer.Play();
                }
                else
                {
                    _main.Result.GetImagePath(_main.Result.result = "Incorrect");
                    mediaPlayer.Open(new Uri("C:\\Users\\McPherson\\source\\repos\\MathPractice\\MathPractice\\SoundFx\\IncorrectAudio.mp3"));
                    mediaPlayer.Play();
                }
            }
            else if (Dividing)
            {
                if (_main.Equation.GetQuotient() == _main.Equation.UserInput)
                {
                    _main.Result.GetImagePath(_main.Result.result = "Correct");
                    mediaPlayer.Open(new Uri("C:\\Users\\McPherson\\source\\repos\\MathPractice\\MathPractice\\SoundFx\\CorrectAudio.mp3"));
                    mediaPlayer.Play();
                    if (_main.Equation.GetRemainder() != "0" )
                    {
                        MessageBox.Show($"With a Remainder of {_main.Equation.GetRemainder()}\n GREAT JOB!!!!!");
                    }
                }
                else
                {
                    _main.Result.GetImagePath(_main.Result.result = "Incorrect");
                    mediaPlayer.Open(new Uri("C:\\Users\\McPherson\\source\\repos\\MathPractice\\MathPractice\\SoundFx\\IncorrectAudio.mp3"));
                    mediaPlayer.Play();

                }
            }
        }

        private void Additon_Click(object sender, RoutedEventArgs e)
        {
            Adding = true;
            Subtracting = false;
            Multiplying = false;
            Dividing = false;
        }

        private void Subtraction_Click(object sender, RoutedEventArgs e)
        {
            Adding = false;
            Subtracting = true;
            Multiplying = false;
            Dividing = false;
        }

        private void Multiplication_Click(object sender, RoutedEventArgs e)
        {
            Adding = false;
            Subtracting = false;
            Multiplying = true;
            Dividing = false;
        }

        private void Division_Click(object sender, RoutedEventArgs e)
        {
            Adding = false;
            Subtracting = false;
            Multiplying = false;
            Dividing = true;
        }
    }
}


       

        
            
            
            
            
             

