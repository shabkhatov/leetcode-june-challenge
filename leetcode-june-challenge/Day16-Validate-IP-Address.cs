using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode_june_challenge
{
    class Day16_Validate_IP_Address
    {
        public string ValidIPAddress(string IP)
        {
            var ip4 = IP.Split('.');
            var ip8 = IP.Split(':');
            bool ok = true;
            if (ip4.Length == 4) {
                for (int i = 0; ok && i < ip4.Length; i++) {
                    ok = ip4[i].Length > 0;
                    for (int j = 0; ok && j < ip4[i].Length; j++) { 
                        if((j == 0 && ip4[i][j] == '0') || ip4[i][j] < '0' || ip4[i][j] > '9')
                            ok = false;
                    }
                    if (ok)
                    {
                        var digit = int.Parse(ip4[i]);
                        if (digit > 255) ok = false;
                    }
                }

                if (ok) return "IPv4";
            }

            if (ip8.Length == 8) {
                for (int i = 0; ok && i < ip8.Length; i++)
                {
                    ok = System.Text.RegularExpressions.Regex.IsMatch(ip8[i], @"\A\b[0-9a-fA-F]+\b\Z")
                        && ip8[i].Length > 0 && ip8[0][0] != '0';
                }
                if (ok) return "IPv6";
            }
            return "Neither";
        }
    }
}
