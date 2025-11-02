using System.Security.AccessControl;

namespace SharpKnP231.Exceptions;

internal class ExceptionsDemo
{
    public ExceptionsDemo()
    {
        return;
    }

    public void Run()
    {
        Console.WriteLine("Exception");

        try
        {
            this.ThrowableCode();
        }
        catch (ApplicationException ex)
        {
            Console.WriteLine("Application Exception" + ex.Message);
        }
        catch (Exception)
        {
            Console.WriteLine("Exception");
        }
    }

    private void ThrowableCode()
    {
        throw new ApplicationException("Launch of throwable code");
    }
}