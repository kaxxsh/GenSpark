using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorAppointmentBLLibrary.Exceptions
{
    public class DuplicateDoctorException : Exception
    {
        string msg;
        public DuplicateDoctorException()
        {
            msg = "Doctor already exists";
        }

        [ExcludeFromCodeCoverage]
        public override string Message => msg;
    }
}
