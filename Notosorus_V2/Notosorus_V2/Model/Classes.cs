using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notosorus_V2.Model
{
    public class Classes
    {
        public int IdSemestre { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Teacher { get; set; }
        public string NbGroup { get; set; }
        public IList<Notes> Note { get; set; } = new List<Notes>();
        public IList<Grades> Notes { get; set; } = new List<Grades>();

        public IList<string> Section { get; set; } = new List<string>();

    }
}
