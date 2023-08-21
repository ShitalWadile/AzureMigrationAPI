using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ctrlspec.Models;
// using ctrlspec.Interfaces; // Import the namespace containing IAdmin

namespace ctrlspec.Repository
{
    public interface IAdmin
    {
       // Task<List<Login>> GetAll();
       // Task<Login> GetByID(int Id);

         Task<List<Application>> GetAllApp();
         Task<Application> GetByIDApp(int Id);
         
         Task DeleteApp(int Id);

    }
}