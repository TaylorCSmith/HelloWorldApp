using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorldInfrastructure.Model
{
    public class ErrorModel
    {
        public string ErrorName { get; set; }
        public string ErrorMessage { get; set; }
        public string ExceptionType { get; set; }
        public string FullExceptionName { get; set; }
    }
}
