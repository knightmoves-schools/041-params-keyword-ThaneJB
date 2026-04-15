namespace knightmoves;

public class Person{
   public string FirstName;
   public string LastName;
   public string[] Hobbies;

   public Person(string firstName, string lastName){
      FirstName = firstName;
      LastName = lastName;
   }

   public string AddHobbies(params string[] Hobbies){
         string output = "";
         foreach(string Hobbie in Hobbies){
            if(output.Length > 0){
               output += ", ";
            }
               output += Hobbie;
         }
         return $"{output}";
   }
   
   
}