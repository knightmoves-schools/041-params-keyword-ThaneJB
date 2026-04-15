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

   public string AddHobbies(params string[] hobbies){
    Hobbies = hobbies;

   }
   
}