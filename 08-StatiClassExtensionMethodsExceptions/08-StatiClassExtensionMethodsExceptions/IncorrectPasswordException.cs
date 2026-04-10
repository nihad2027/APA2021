using System;
using System.Collections.Generic;
using System.Text;

namespace _08_StatiClassExtensionMethodsExceptions
{
   public class IncorrectPasswordException : Exception
    {
        public int AttemptsLeft { get; set; }
        public IncorrectPasswordException(int attemptsLeft):base($"Sifre yalnisdir. Qalan cehd sayi: {attemptsLeft}")
        {
            AttemptsLeft = attemptsLeft;
        }
    }
}
