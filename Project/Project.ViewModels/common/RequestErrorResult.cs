using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ViewModels.common
{
    public class RequestErrorResult<T> :RequestResult<T>
    {
        public string[] ValidationErrors { get; set; }

        public RequestErrorResult()
        {
        }

        public RequestErrorResult(string message)
        {
            IsSuccessed = false;
            Message = message;
        }

        public RequestErrorResult(string[] validationErrors)
        {
            IsSuccessed = false;
            ValidationErrors = validationErrors;
        }
    }
}
