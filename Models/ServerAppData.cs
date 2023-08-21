using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ctrlspec.Models
{
    public class ServerAppData
    {
        [Key]
        public int Id {get;set;}
        public int ServerId { get; set; }
        public string ServerLabel {get;set;}
        public int AppId { get; set; }
    }
}