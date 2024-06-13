// See https://aka.ms/new-console-template for more information
// - Esercizio 1
// Scrivi un programma che definisca un array di interi e calcoli la somma di tutti gli elementi dell'array.

int[] num = new int[]{1,2,3,4,5};
int somma = 0;
foreach (var item in num)
{
    somma += item;
}
Console.WriteLine(somma);
// - Esercizio 2
// Scrivi un programma che definisca un array di stringhe e cerchi un valore specifico nell'array. 
//Stampa un messaggio se il valore viene trovato o se non viene trovato.

string[] parole = new string[]{"pippo","pluto","topolino","paperino"};
bool trovato = false;
foreach (var item in parole)
{
    if (!trovato == true && item == "pippo")
    {
        trovato = true;
    }
}
if (trovato)
{
  Console.WriteLine("bravo hai trovato pippo");  
}else
{
    Console.WriteLine("mi dispiace non credo si trovi qui");
}
// - Esercizio 3
// Scrivi un programma che definisca un array di interi e crei una copia dell'array originale in un nuovo array.

int[] num1 = new int[]{1,2,3,};
int[] num2 = new int[num1.Length];
num1.CopyTo(num2, 0);
foreach (var item in num2)
{
    Console.WriteLine(item);
}

// - Esercizio 4
// Scrivi un programma che definisca un array di numeri interi e li ordini in modo crescente.

int[] ints= new int[]{2,3,4,6,1,23,45,68};
  Array.Sort(ints);
  for (int i = 0; i < ints.Length; i++)
  { 
      Console.WriteLine(ints[i].ToString());
  }
// - Esercizio 5
// Scrivi un programma che definisca un array di numeri interi e trovi il valore massimo presente nell'array.

  int[] interi = new int[] { 2, 3, 4, 6, 1, 23, 45, 68 };
        
        int max = interi[0];

        for (int i = 1; i < interi.Length; i++)
        {
            if (interi[i] > max)
            {
                max = interi[i];
            }
        }
        
        Console.WriteLine("Il valore massimo nell'array è: " + max);

// - Esercizio 6
// Scrivi un programma che definisca una matrice quadrata di numeri interi e calcoli la somma degli elementi presenti sulla diagonale principale.

 int[,] matrix = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        int sum = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, i];
        }

        Console.WriteLine("La somma degli elementi sulla diagonale principale è: " + sum);

// - Esercizio 7
// Scrivi un programma che definisca una lista di numeri interi e trovi il valore minimo presente nella lista.

   int[] interimin = new int[] { 2, 3, 4, 6, 1, 23, 45, 68 };

        int min = interimin[0];

        for (int i = 0; i < interimin.Length; i++)
        {
            if (interimin[i] < min)
            {
                min = interimin[i];
            }
        }

        Console.WriteLine("Il valore minimo nell'array è: " + min);

// - Esercizio 8
// Scrivi un programma che definisca un array di stringhe e conti quante volte un valore specifico compare nell'array.

 string[] strings = new string[] { "apple", "banana", "apple", "orange", "banana", "apple" };
        
            string valueToCount = "apple";
            int count = 0;
            for (int i = 0; i < strings.Length; i++)
            {
                if (strings[i] == valueToCount)
                {
                    count++;
                }
            }

Console.WriteLine($"Il valore '{valueToCount}' compare {count} volte nell'array.");

// - Esercizio 9
// Scrivi un programma che definisca due array di numeri interi e li concateni in un nuovo array.

 int[] array1 = new int[] { 1, 2, 3, 4 };
        int[] array2 = new int[] { 5, 6, 7, 8 };

        int[] concatenatedArray = new int[array1.Length + array2.Length];

        for (int i = 0; i < array1.Length; i++)
        {
            concatenatedArray[i] = array1[i];
        }

        for (int i = 0; i < array2.Length; i++)
        {
            concatenatedArray[array1.Length + i] = array2[i];
        }

        Console.WriteLine("Il nuovo array concatenato è:");
        for (int i = 0; i < concatenatedArray.Length; i++)
        {
            Console.WriteLine(concatenatedArray[i]);
        }
