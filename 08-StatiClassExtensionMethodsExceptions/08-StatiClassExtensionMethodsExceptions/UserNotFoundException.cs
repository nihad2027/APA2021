using System;
using System.Collections.Generic;
using System.Text;

namespace _08_StatiClassExtensionMethodsExceptions
{
    public class UserNotFoundException : Exception
    {
        public UserNotFoundException(string username) : base($"{username} adli istifadeci sistemde movcud deyil") {}
    }
}
