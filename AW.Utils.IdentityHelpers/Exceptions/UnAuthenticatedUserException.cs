using System;
using System.Collections.Generic;
using System.Text;


namespace AW.Utils.IdentityHelpers.Exceptions
{
  public class UnAuthenticatedUserException : Exception
  {
    public UnAuthenticatedUserException()
    {

    }

    public UnAuthenticatedUserException(string message) : base(message)
    {

    }

    public UnAuthenticatedUserException(string message, Exception innerException)
      : base(message, innerException)
    {

    }    
  }
}
