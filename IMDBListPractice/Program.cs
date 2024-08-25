using IMDBListPractice;
using System;
using System.Collections.Generic;

class Movie
{
    public string Name { get; set; }
    public double ImdbPoint { get; set; }
}

class Program
{
    static void Main()
    {
        List<Movie> Movies = new List<Movie>(); // Film isimlerini ve IMDb puanlarını saklamak için liste.

        while (true)
        {
            Console.WriteLine("Please write the movie you want to rate:");
            string movieName = Console.ReadLine(); // Kullanıcıdan film adı alınıyor.

            Console.WriteLine("Please enter your IMDB point:");
            double imdbPoint;
            while (!double.TryParse(Console.ReadLine(), out imdbPoint)) // IMDb puanı alınıyor ve kontrol ediliyor.
            {
                Console.WriteLine("Wrong choice! Please enter a valid IMDB point:");
            }

            // Yeni film nesnesi oluşturuluyor ve listeye ekleniyor.
            Movies.Add(new Movie { Name = movieName, ImdbPoint = imdbPoint });

            // Kullanıcıya başka bir film eklemek isteyip istemediği soruluyor.
            Console.WriteLine("Would you like to add another movie? (Y/N)");
            string choose = Console.ReadLine().ToUpper();

            if (choose != "Y")
            {
                break; // Eğer kullanıcı 'Y' yazmazsa döngüden çıkılır.
            }
        }

        Console.WriteLine("-------------ALL MOVIES------------");
        foreach (var movie in Movies)
        {
            Console.WriteLine($"Film: {movie.Name}, IMDB Puanı: {movie.ImdbPoint}");
        }

        Console.WriteLine("IMDB POINTS BETWEEN 4-9:");
        foreach (var movie in Movies)
        {
            if (movie.ImdbPoint >= 4 && movie.ImdbPoint <= 9)
            {
                Console.WriteLine($"Film: {movie.Name}, IMDB Puanı: {movie.ImdbPoint}");
            }
        }

        Console.WriteLine("Start with A ");
       
        foreach(var movie in Movies)
        if (movie.Name.StartsWith("A", StringComparison.OrdinalIgnoreCase)) // İsim 'A' ile başlıyorsa
        {
            Console.WriteLine($"Film: {movie.Name}, IMDB Puanı: {movie.ImdbPoint}");
        }


    }
}