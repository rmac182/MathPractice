using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPractice.ViewModels
{
    public class ResultViewModel: ObservableObject
    {
        public Random rnd = new Random();
        public string result;
        public string defaultImage = "C:\\Users\\McPherson\\source\\repos\\MathPractice\\MathPractice\\Images\\Default.jpg";
        private string ImageIndex;
        private string _imagePath;

        public string ImagePath
        {
            get { return _imagePath; }
            set
            {
                _imagePath = value;
                OnPropertyChanged("ImagePath");
            }
        }

        public string GetImagePath(string _result)
        {
            ImageIndex = rnd.Next(1, 7).ToString();
            ImagePath = $"C:\\Users\\McPherson\\source\\repos\\MathPractice\\MathPractice\\Images\\{result}{ImageIndex}.jpg";
            return ImagePath;
        }
        public void DefaultImage()
        {
            ImagePath = defaultImage;
        }

    }
}
