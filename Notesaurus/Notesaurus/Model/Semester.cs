using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notesaurus.Model
{
    public class Semester
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Classes> SemesterClasses { get; set; } = new List<Classes>();
    }
}
