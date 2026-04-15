namespace knightmoves;

public class Person{
   public string FirstName;
   public string LastName;
   public string[] Hobbies;

   public Person(string firstName, string lastName){
      FirstName = firstName;
      LastName = lastName;
      Hobbies = new string[0];
   }

   public void AddHobbies(params string[] hobbies){
    string[] combined = new string[Hobbies.Length + hobbies.Length];

      for (int i = 0; i < Hobbies.Length; i++)
      {
         combined[i] = Hobbies[i];
      }

      for (int i = 0; i < hobbies.Length; i++)
      {
         combined[Hobbies.Length + i] = hobbies[i];
      }

      Hobbies = combined;
   }

   }
   
