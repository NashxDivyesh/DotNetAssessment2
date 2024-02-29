using System.Security.Cryptography.X509Certificates;

public static class Program{
    public static void Main(){
        var personList = new List<string>();
        Console.WriteLine("Enter names of people:");
        while(true){
            var personName = Console.ReadLine();
            if(string.IsNullOrWhiteSpace(personName))
                break;
            else{
                personList.Add(personName);
            }
        }
        Display(personList);
        
    }

    public static void Display(List<string> listOfPersons){
        if(listOfPersons.Count == 0){
            return;
        }
        if(listOfPersons.Count == 1){
            Console.WriteLine($"{listOfPersons[0]} liked your post");
        }
        else if(listOfPersons.Count == 2){
            Console.WriteLine($"{listOfPersons[0]} and {listOfPersons[1]} liked your post");
        }
        else{
            Console.WriteLine($"{listOfPersons[0]}, {listOfPersons[1]} and {listOfPersons.Count - 2} others liked your post");
        }
    }
}