# GetMyIp - .NET 5.0

This app issues a web request to a website that returns the current IP address as seen
by the external website. An optional command-line argument is the web site being called.
If omitted, http://checkip.dyn.com is used.

This app may be used by a server running a VPN client where this app executable is added
as a split tunnel program set to bypass the VPN.

Update to use the piactl command line tool to get the pubip.

Called via web with http://GetMyIpApi.lcl/GetMyIpApi and used by Direct Update to get IP and tell DiscountAsp.net.

Use Build->Publish to copy Release to E:\Data\Tools\GetMyIp