using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountEx.Entities.Exceptions
{
    public class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message){
            
        }
    }
}