namespace CompanyProjectVer2.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public Guid DepartmentId { get; set; }
        public string SurName { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }
        public DateTime DayOfBirth { get; set; }
        public string DocSeries { get; set; }
        public string DocNumber { get; set; }
        public string Position { get; set; }
        //
        public Employee(int id, Guid departmentId, string surName, string firstName, string patronymic, DateTime dateOfBirth, string docSeries, string docNumber, string position)
        {
            Id = id;
            DepartmentId = departmentId;
            SurName = surName;
            FirstName = firstName;
            Patronymic = patronymic;
            DayOfBirth = dateOfBirth;
            DocSeries = docSeries;
            DocNumber = docNumber;
            Position = position;
        }


    }
}
