namespace OOP_amnt3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>{
                new Student("Mahmoud","Ahmed",21,"Forth Level"),
                new Student("Nour","Ahmed",20,"Level Four"),
                new Teacher("Rana","Hatem",28,"Dot Net Core"),
                new Admin("Mira","Hesham",23,"Coordinator")

            };


            foreach (Person person in list) {
                person.GetDetails();
            }
        }
    }
}
