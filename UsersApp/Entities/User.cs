using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class User
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public DateTime Birthdate { get; set; }
        public TipoSex Sex  { get; set; }
    }

    public enum TipoSex
    {
        F,
        M
    }
}
