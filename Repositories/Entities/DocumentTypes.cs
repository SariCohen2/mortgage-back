using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Entities
{
    public class DocumentTypes
    {
        public int Id { get; set; }
        public Transaction_Type TransactionType { get; set; }
        public string Document_name { get; set; }
        public bool Required { get; set; }
    }
}
