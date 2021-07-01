using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace nonameClub.Models
{
    public class Roles
    {
        public Roles()
        {
            Users = new Collection<Users>();
        }
        [Key]
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public int RolePriority { get; set; }
        public ICollection<Users> Users { get; set; }
    }
}
