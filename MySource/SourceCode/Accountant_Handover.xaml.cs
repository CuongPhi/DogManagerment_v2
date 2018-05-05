using System;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace SourceCode
{
    /// <summary>
    /// Interaction logic for Accountant_Handover.xaml
    /// </summary>
    public partial class Accountant_Handover : UserControl
    {
        public Accountant_Handover()
        {
            InitializeComponent();
            this.TvBox.ItemsSource = new MovieData[]
        {
            new MovieData{Title="Movie 1", ImageData=LoadImage("image.jpg")},
            new MovieData{Title="Movie 2", ImageData=LoadImage("image.jpg")},
            new MovieData{Title="Movie 3", ImageData=LoadImage("image.jpg")},
            new MovieData{Title="Movie 4", ImageData=LoadImage("image.jpg")},
            new MovieData{Title="Movie 5", ImageData=LoadImage("image.jpg")},
            new MovieData{Title="Movie 6", ImageData=LoadImage("image.jpg")}
        };
        }

        // for this code image needs to be a project resource
        private BitmapImage LoadImage(string filename)
        {
            return null;
               // new BitmapImage(new Uri("pack://application:,,,/" + filename));
        }

    }
    public class MovieData
    {
        private string _Title;
        public string Title
        {
            get { return this._Title; }
            set { this._Title = value; }
        }

        private BitmapImage _ImageData;
        public BitmapImage ImageData
        {
            get { return this._ImageData; }
            set { this._ImageData = value; }
        }

    }
}
