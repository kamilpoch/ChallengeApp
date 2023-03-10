
using System.Security.Cryptography.X509Certificates;

namespace ChallengeApp
{
    public class Employee
    {
        public List<int> score = new List<int>();
        public Employee(string name, string surename, int age)

        {
            this.Name = name;
            this.Surname = surename;
            this.Age = age;

        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }

        public int Result
        {
            get
            {
                return score.Sum();
            }
        }

        public void AddScore(int score)
        {

            this.score.Add(score);
        }

    }
}
