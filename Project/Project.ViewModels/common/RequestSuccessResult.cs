using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ViewModels.common
{
    public class RequestSuccessResult<T> : RequestResult<T>
    {
        public RequestSuccessResult(T resultObj)
        {
            IsSuccessed = true;
            ResultObj = resultObj;
        }

        public RequestSuccessResult()
        {
            IsSuccessed = true;
        }
    }
}
