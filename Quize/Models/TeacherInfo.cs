using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quize.Models
{
    public class TeacherInfo
    {
        //[JsonProperty("username")]
        public string UserName { get; set; }

        //[JsonProperty("name")]
        public string Name { get; set; }

        //[JsonProperty("surname")]
        public string Surname { get; set; }

        //[JsonProperty("email")]
        public string Email { get; set; }

        //[JsonProperty("parol")]
        public string Parol { get; set; }
    }
}
