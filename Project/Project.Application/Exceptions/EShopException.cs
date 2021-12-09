using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Utilities.Exceptions
{
    public class ProjectException : Exception
    {
        public ProjectException()
        {
        }

        public ProjectException(string message)
            : base(message)
        {
        }

        public ProjectException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
