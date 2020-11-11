using System;
//using System.Text.RegularExpressions;
//using System.Net;
using System.Diagnostics;

// OLD: Get IP address from http://checkip.dyn.com or website in command line arg.
// Useful for PIA VPN - set this executable as a split tunnel application to bypass the VPN.
// Resulting IP can be used to see if the server's IP has changed by Comcast (using DirectUpdate app)
// and then set the server's DNS to the new IP using DiscountAsp.net's DNS API.

// The piactl tool now has a GET PUBIP command to get the IP.

namespace GetMyIp
{
    class Program
    {
        static void Main(string[] args)
        {
            //using var webClient = new WebClient {BaseAddress = args.Length == 0 ? "http://checkip.dyn.com" : args[0]};
            //var result = webClient.DownloadString("");
            //var m = Regex.Match(result, @"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}");
            //Console.WriteLine(m.Value);
            var fileName = @"C:\Program Files\Private Internet Access\piactl.exe"; 
            var arguments = "get pubip";
            var startinfo = new ProcessStartInfo(fileName, arguments)
            {
                UseShellExecute = false,
                RedirectStandardOutput = true
            };
            var p = Process.Start(startinfo);

            var ipAddress = p.StandardOutput.ReadLine();
            p.WaitForExit();

            Console.WriteLine(ipAddress);
        }
    }
}
