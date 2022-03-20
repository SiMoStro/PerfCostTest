using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PerfTest
{
    internal static class Win32
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct FILETIME
        {
            public uint DateTimeLow;
            public uint DateTimeHigh;

            public ulong ToQuad()
            {
                return (((ulong)DateTimeHigh) << 32) + DateTimeLow;
            }
        }


        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool GetSystemTimes(out FILETIME lpIdleTime, out FILETIME lpKernelTime, out FILETIME lpUserTime);
    }
}
