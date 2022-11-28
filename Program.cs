Random r = new Random();
string[] Firstnames = new string[10] {"Emma", "Jasmine", "Rose", "Luna", "Aron", "Vicente", "Ed", "Ron", "Kylian", "Andy"};
string[]Middlenames = new string [10] {" Ann", " Lyn", " Franci", " Irene", " Mae", " Jane", " Marie"," Eve", " Kay", " Dawn"};
string[]Lastnames = new string [10] {" Carrasco", " Trejo", " Jimenez"," Larsen", " Smith", " Lee", " Day",  " Lune", " Clair", " Sol", };
for (int x = 0; x<Firstnames.Length; x++)
{
   for (int y = 0; y < Middlenames.Length; y++)
   {

      for (int z = 0; z < Lastnames.Length;   z++)
      {

       string Peoplesnames = Firstnames[x] + Middlenames[y] + Lastnames[z];
        

        Console.WriteLine($" Name: {Peoplesnames}  ");

      }






   }
}