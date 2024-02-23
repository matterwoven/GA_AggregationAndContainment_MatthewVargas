namespace GA_AggregationAndContainment_MatthewVargas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> students = new List<string>();

            Instructor will = new Instructor("Will", "Cram");
            SchoolProgram prog124 = new SchoolProgram("Programming", "124", "J102", will);
            prog124.AddStudent("Ana","Mendes",100,100);


            Console.WriteLine($"{prog124.ToString}");
            prog124.StudentsInfo();
        }   
    }
}
