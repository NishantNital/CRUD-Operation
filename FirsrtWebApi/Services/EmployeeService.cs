using FirstWebApi.Services.Interfaces;
using System.Collections.Generic;
using FirsrtWebApi.Models;
using System.Linq;

namespace FirstWebApi.Services;

public class EmployeeService : IEmployeeServices
{
    private  List<Employee> _employees;

    public EmployeeService()
    {

        _employees = new List<Employee>()
    {
        new Employee() { Id=1, Name= "Nishant"},
        new Employee() { Id =2, Name = "Nital"}
    };
    }

    //Create 
    public void CreateEmployee(Employee employee)
    {
        _employees.Add(employee);
    }

    // Delete
    public bool DeleteEmployee(int id)
    {
        
        _employees = _employees.Where(x => x.Id != id).ToList();
        return true;
    }

   

    // Read
    public Employee GetEmployeeById(int id)
    {
        return _employees.Where(x => x.Id == id).FirstOrDefault();
    }

    public IEnumerable<Employee> GetEmployees()
    {
        return _employees;
    }

    //Update
    public void UpdateEmployee(Employee employee)
    {
        var originalEmployee = GetEmployeeById(employee.Id);
        if (originalEmployee != null)
        {

            _employees.ForEach(item =>
            {
                if (item.Id == employee.Id)
                {
                    item.Name = employee.Name;
                }
            }
            );
            
               
            }
            
        
        else
        {
            _employees.Add(employee);
        }
    }
}
