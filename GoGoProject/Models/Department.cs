namespace CompanyProjectVer2.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public Guid ParentDepartmentID { get; set; }

        public Department(int id, string name, string code, Guid parentDepartmentID) 
        {
            Id = id;
            Name = name;
            Code = code;
            ParentDepartmentID = parentDepartmentID;
        }
        //
    }
}
