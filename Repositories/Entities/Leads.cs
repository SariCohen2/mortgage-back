using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Entities
{
    public class Leads
    {
        public int Id { get; set; }
        public string First_Name {  get; set; }
        public string Phone {  get; set; }
        public string Email { get; set; }
        public DateTime? created_at { get; set; }
        public DateTime? updated_at { get;set; }
    }
}
