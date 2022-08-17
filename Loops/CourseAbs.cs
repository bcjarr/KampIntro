using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
        public interface ICourseAbs
    {

        public string InstructorName { get; set; }
        public string InstructorLastName { get; set; }

        public int InstructorAge { get; set; }
        public int InstructorNationalIdentity { get; set; }

        public long InstructorPhoneNumber { get; set; }
        public string InstructorBirthPlace { get; set; }
    }
    
}
