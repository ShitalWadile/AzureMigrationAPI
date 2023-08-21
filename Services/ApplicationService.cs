using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ctrlspec.Data;
using ctrlspec.Models;

namespace ctrlspec.Services
{
    public class ApplicationService
    {
        private readonly CtrlSpecDbContext _dbContext;

        public ApplicationService(CtrlSpecDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Application> GetApplications()
        {
            return _dbContext.Applications.ToList();
            
        }

         public List<ApplicationList> GetApplicationLists()
        {
            return _dbContext.ApplicationLists.ToList();
            
        }

        public List<ServerList> GetServerLists()
        {
            return _dbContext.ServerLists.ToList();
            
        }


    }
}