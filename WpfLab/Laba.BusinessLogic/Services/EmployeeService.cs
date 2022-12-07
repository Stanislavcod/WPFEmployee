using Lab.Model;

namespace Laba.BusinessLogic.Services
{
    public class EmployeeService
    {
        private readonly DataBaseContext _context;
        public EmployeeService()
        {
            _context = new DataBaseContext();
        }
        public IEnumerable<Employee> Get()
        {
            return _context.Employees.ToList();
        }
        public void Deleted(Employee employee)
        {
            _context.Employees.Remove(employee);
            _context.SaveChanges();
        }
        public void Update(Employee employee)
        {
            _context.Update(employee);
            _context.SaveChanges();
        }
        public void Create(Employee employee)
        {
            _context.Add(employee);
            _context.SaveChanges();
        }
    }
}
