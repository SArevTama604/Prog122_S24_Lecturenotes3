using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prog122_S24_Lecturenotes3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Product[] myMovies = new Product[4];

        public MainWindow()
        {
            InitializeComponent();

            // Creating instances of the Product class
            Product movie1 = new Product("The Shawshank Redemption", "Frank Darabont", 9.3, 9.99);
            myMovies[0] = movie1;

            Product movie2 = new Product("The Godfather", "Francis Ford Coppola", 9.2, 12.99);
            myMovies[1] = movie2;

            Product movie3 = new Product("The Dark Knight", "Christopher Nolan", 9.0, 14.99);
            myMovies[2] = movie3;

            Product movie4 = new Product("Inception", "Christopher Nolan", 8.8, 9.99);
            myMovies[3] = movie4;

            Product movie5 = new Product("Forrest Gump", "Robert Zemeckis", 8.8, 7.99);
            myMovies[4] = movie5;

            Product movie6 = new Product("The Matrix", "Lana and Lilly Wachowski", 8.7, 8.99);
            myMovies[5] = movie6;

            // showing movie information
            for (int i = 0; i < myMovies.Length; i++)
            {
                DisplayMovie(myMovies[i]);
            }
        }

        // a way to display movie information
        public void DisplayMovie(Product movie)
        {
            string movieInfo = $"Title: {movie.Title}\n" +
                               $"Director: {movie.Director}\n" +
                               $"Rating: {movie.Rating}\n" +
                               $"Price: ${movie.Price}\n\n";

            runDisplay.AppendText(movieInfo);
        }
    }

    // Product class definition
    public class Product
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public double Rating { get; set; }
        public double Price { get; set; }

        public Product(string title, string director, double rating, double price)
        {
            Title = title;
            Director = director;
            Rating = rating;
            Price = price;
        }
    }
}