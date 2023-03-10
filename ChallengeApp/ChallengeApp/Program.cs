using ChallengeApp;

Employee employee1 = new Employee("Kamil", "Kowalski", 40);
Employee employee2 = new Employee("Ania", "Daszek", 33);
Employee employee3 = new Employee("Ewa", "Zielińska", 28);

employee1.AddScore(5);
employee1.AddScore(9);
employee1.AddScore(9);
employee1.AddScore(7);
employee1.AddScore(6);

employee2.AddScore(7);
employee2.AddScore(3);
employee2.AddScore(1);
employee2.AddScore(5);
employee2.AddScore(9);

employee3.AddScore(6);
employee3.AddScore(1);
employee3.AddScore(3);
employee3.AddScore(7);
employee3.AddScore(5);


List<Employee> employees = new List<Employee>()
{

    employee1, employee2, employee3

};
int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var Employee in employees)
{
    if (Employee.Result > maxResult)
    {
        maxResult = Employee.Result;
        employeeWithMaxResult = Employee;
    }

}

Console.WriteLine("Najlepszy pracownik"  + employeeWithMaxResult.Name + " " + employeeWithMaxResult.Surname + " " + maxResult + "punktów");

