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
        public const int ProcessorInformation = 11;
        public const uint STATUS_SUCCESS = 0;

        [StructLayout(LayoutKind.Sequential)]
        public struct PROCESSOR_POWER_INFORMATION
        {
            public uint Number;
            public uint MaxMhz;
            public uint CurrentMhz;
            public uint MhzLimit;
            public uint MaxIdleState;
            public uint CurrentIdleState;
        }

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

        [DllImport("powrprof.dll", SetLastError = true)]
        public static extern UInt32 CallNtPowerInformation(int InformationLevel,
        IntPtr lpInputBuffer,
        int nInputBufferSize,
        [Out] PROCESSOR_POWER_INFORMATION[] lpOutputBuffer,
        int nOutputBufferSize);
    }
}
