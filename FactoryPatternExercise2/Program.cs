namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool isData;
            Console.WriteLine("Welcome. Please select your database. It's much less fun than selecting a mage or fighter, but who am I to complain?");
            Console.WriteLine("-------------------------------");
            do
            {
                Console.WriteLine("Please choose between SQL, List or Mongo.");
                var ans = Console.ReadLine().ToLower();
                if(ans == "sql" || ans == "list" || ans == "mongo")
                {
                    isData = true;
                    var data = DataAccessFactory.GetDataAccessType(ans);
                    data.SaveData();
                    data.LoadData();
                }
                else
                {
                    Console.WriteLine("Come on, buddy. I don't want to be here any more than you do. Stop messing about.");
                    isData = false;
                }
            }
            while (isData== false);
        }
    }
}
