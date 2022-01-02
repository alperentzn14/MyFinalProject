using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //basic Void //success and Message result 
   public interface IResult
    {
        bool Success { get; }
        string Message { get; } 
    }
}
