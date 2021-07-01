using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace nonameClub.Models
{
    public class Users
    {
        public Users()
        {
            Servers = new Collection<Servers>();
        }
        [Key]
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public virtual Roles Roles { get; set; }
        public ICollection<Servers> Servers { get; set; }
    }
}
