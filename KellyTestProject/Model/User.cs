using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KellyTestProject.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public List<Visit> Visits { get; set; }
    }
}
