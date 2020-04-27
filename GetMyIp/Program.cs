using System;
using System.Text.RegularExpressions;
using System.Net;

// Get IP address from http://checkip.dyn.com or website in command line arg.
// Useful for PIA VPN - set this executable as a split tunnel application to bypass the VPN.
// Resulting IP can be used to see if the server's IP has changed by Comcast (using DirectUpdate app)
// and then set the server's DNS to the new IP using DiscountAsp.net's DNS API.

namespace GetMyIp
{
    class Program
    {
        static void Main(string[] args)
        {
            using var webClient = new WebClient {BaseAddress = args.Length == 0 ? "http://checkip.dyn.com" : args[0]};
            var result = webClient.DownloadString("");
            var m = Regex.Match(result, @"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}");
            Console.WriteLine(m.Value);
        }
    }
}
