using System;

//Napisz program, który za pomocą pętli for dla danych wartości x zmieniających się w przedziale od 0 do 10
//obliczy wartość funkcji y = root(3^2)*x. Wynik wyświetl w konsoli.

class PetlaFor{
    static void Main(string[] args)
    {
        Console.WriteLine("Obliczanie wartości funkcji y = √(3^2) * x, dla x w przedziale od 0 do 10: ");

        for (int x= 0; x <= 10; x++)
        {
            double y = Math.Sqrt(Math.Pow(3, 2)) * x;
            Console.WriteLine($"Dla x = {x}, y wynosi {y}");
        }
    }
}