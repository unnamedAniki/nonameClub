using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace nonameClub.Models
{
    public class Servers
    {
        [Key]        
        public int ServerId { get; set; }
        public string ServerName { get; set; }
        public string ServerInfo { get; set; }
        public string ServerVersion { get; set; }
        public int AdminId { get; set; }
        public Users Users { get; set; }
    }
}
