using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Management;
using System.Windows.Forms;

namespace WMI
{
    public class DrivePNP
    {
        public string[] FPnpID = new string[24];

        public DrivePNP()
        { 
            Refresh();
        }

        private void Refresh()
        {
            for (int i = 0; i < 24; i++)
                FPnpID[i] = string.Empty;
            try
            {
                foreach (ManagementObject Drive in 
                    new ManagementObjectSearcher("select * from Win32_DiskDrive ").Get())
                {
                    foreach (ManagementObject Partition in
                        new ManagementObjectSearcher(
                            "ASSOCIATORS OF {Win32_DiskDrive.DeviceID='" + Drive["DeviceID"] +
                            "'} WHERE AssocClass = Win32_DiskDriveToDiskPartition").Get())
                    {
                        foreach (ManagementObject LogicalDisk in new ManagementObjectSearcher(
                            "ASSOCIATORS OF {Win32_DiskPartition.DeviceID='" + Partition["DeviceID"] +
                            "'} WHERE AssocClass = Win32_LogicalDiskToPartition").Get())
                        {
                            string S = LogicalDisk["Name"].ToString();
                            if (!S.Equals(string.Empty))
                            {
                                int index = (int)S[0] - 65;
                                FPnpID[index] = Drive["PNPDeviceID"].ToString();
                            }
                        }
                    }
                }
            }
            catch(Exception Ex)
            {
                throw new Exception(Ex.Message);
            }

        }

        private int Last(string what, string where)
        {
            int reuslt = 0;

            for (int i = where.Length - what.Length; i >= 0; i--)
                if (where.Substring(i, what.Length) == what)
                    return i;

            return reuslt;
        }

        public string GetPnpIDNormal(char driverLetter)
        {
            driverLetter = driverLetter.ToString().ToUpper()[0];
            int index = (int)driverLetter - 65;

            if (index > -1 && index < 24)
            {
                int startPos = Last(@"\", FPnpID[index]);
                return FPnpID[index].Substring(startPos + 1,  FPnpID[index].Length - startPos - 1);
            }
            else
                return string.Empty;
        }
    }
}