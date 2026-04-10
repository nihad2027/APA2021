using System;
using System.Collections.Generic;
using System.Text;

namespace _08_StatiClassExtensionMethodsExceptions;

public class InvalidUsernameException : Exception
{
    public InvalidUsernameException(string message) : base(message) { }
}
