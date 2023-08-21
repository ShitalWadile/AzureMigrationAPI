using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ctrlspec.Models;
using ctrlspec.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ctrlspec.Controllers
{
    [Route("[controller]")]
    public class AdminAppController : Controller
    {
        
        // private readonly ILogger<AdminAppController> _logger;

        // public AdminAppController(ILogger<AdminAppController> logger)
        // {
        //     _logger = logger;
        // }

        // public IActionResult Index()
        // {
        //     return View();
        // }

        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error()
        // {
        //     return View("Error!");
        // }
        private readonly ServerAppData _admin;
         private readonly IAdmin _context;
        public AdminAppController(IAdmin context)
        {
            _context = context;
        }

         [HttpGet]
        public async Task<ActionResult> GetAllApp()
        {
            var admins = await _context.GetAllApp();
            if (admins == null)
            {
                return NotFound();
            }
            return Ok(admins);
        }
       

        [HttpGet("{Id}")]
        public async Task<ActionResult<Application>> GetByIDApp(int Id)
        {
            var app = await _context.GetByIDApp(Id);
            if (app == null)
            {
                return NotFound();
            }
            return Ok(app);
        }
        
      
        [HttpDelete("{Id}")]
        public async Task<ActionResult> DeleteApp(int Id)
        {
            await _context.DeleteApp(Id);
            return Ok();
        }

       


        

    //     [HttpGet("InnerJoin")]
    //     public IActionResult InnerJoin()
    //     {
    //         var result = from a in _context.ApplicationList
    //                      join s in _context.ServerList
    //                      on a.ApplicationId equals s.ApplicationId
    //                      select new
    //                      {
    //                          a.ApplicationId,
    //                          a.ApplicationName,
    //                          s.ServerId,
    //                          s.ServerName
    //                      };

    //         return Ok(result.ToList());
    //     }
     }
}

    //     [HttpPost("InsertApplicationAndServer")]
    // public async Task<IActionResult> InsertApplicationAndServer(ApplicationList application, ServerList server)
    // {
    //     // Insert data into ApplicationList
    //     _Context.ApplicationList.Add(application);

    //     // Set the ApplicationId for the server before inserting into ServerList
    //     server.ApplicationId = application.ApplicationId;
    //     _Conext.ServerList.Add(server);

    //     await _context.SaveChangesAsync();
    //     return Ok("Data inserted successfully");
    // }

    