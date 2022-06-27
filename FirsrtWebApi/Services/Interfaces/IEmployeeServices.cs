using System.Collections.Generic;
using FirsrtWebApi.Models;




namespace FirstWebApi.Services.Interfaces;

public interface IEmployeeServices  
{
    // Create
    void CreateEmployee(Employee employee); 

    //Read
    Employee GetEmployeeById(int id);
    IEnumerable<Employee> GetEmployees();

    // Update
    void UpdateEmployee(Employee employee);

    //Delete
    bool DeleteEmployee(int id);
}
