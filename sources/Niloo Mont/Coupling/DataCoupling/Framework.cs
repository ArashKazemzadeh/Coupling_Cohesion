namespace DataCoupling;
public class Framework
{
    public void ExceptionHandling(string ip, Action<string> function)
    {
        try
        {
            if (ip is "Iran")
                throw new BannedIPException(ip);
            else
                function(ip);
        }
        catch (BannedIPException ex)
        {
            ex.Message.Dump();
        }
    }

    public void Authentication(string ip, Action<string> function)
    {
        $"Authentication Started for {ip}".Dump();
        function(ip);
        $"Authentication Ended for {ip}".Dump();
    }
}