using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace PerfTest
{
    public partial class FormMain : Form
    {
        private PerformanceCounter _cpuCounter;
        private Timer _timer;
        ulong _lastIdle;
        ulong _lastKernel;
        ulong _lastUser;
        Stopwatch _stopWatch;
        const long _ns = 1000L * 1000L * 1000L;

        MiniChart _apiChart, _perfCountersChart;

        public FormMain()
        {
            InitializeComponent();

            _cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            _apiChart = new MiniChart();
            _apiChart.Dock = DockStyle.Fill;

            _perfCountersChart = new MiniChart();
            _perfCountersChart.Dock = DockStyle.Fill;
            _table.Controls.Add(_apiChart, 3, 1);
            _table.Controls.Add(_perfCountersChart, 3, 2);

            _timer = new Timer();
            _timer.Interval = 1000;
            _timer.Tick += HandleTimerTick;
            _timer.Start();
        }

        double _perfCountersCpu, _apiCpu;
        long _perfCountersCost, _apiCost;
        long _iteration;

        private void HandleTimerTick(object sender, EventArgs e)
        {
            _iteration++;
            _perfCountersCpu = Calculate(ref _perfCountersCost, CalcPerfCounters);
            _apiCpu = Calculate(ref _apiCost, CalcWin32);

            _apiChart.AddValue((float)_apiCpu);
            _perfCountersChart.AddValue((float)_perfCountersCpu);

            _lblCpuApi.Text = _apiCpu.ToString("#.00") + "%";
            _lblCostApi.Text = GetCost(_apiCost, _iteration);
            _lblCpuPerf.Text = _perfCountersCpu.ToString("#.00") + "%";
            _lblCostPerf.Text = GetCost(_perfCountersCost , _iteration);
        }

        private string GetCost(long nanosecs, long iter)
        {
            double micro = nanosecs / 100000.0d;
            return (micro / iter).ToString("#.00");
        }

        private double Calculate(ref long cost, Func<double> oper)
        {
            var freq = Stopwatch.Frequency;
            _stopWatch = Stopwatch.StartNew();
            double d = oper();
            _stopWatch.Stop();
            long nanosecPerTick = _ns / freq;
            cost += _stopWatch.ElapsedTicks * nanosecPerTick;
            return d;
        }

        private double CalcPerfCounters()
        {
            float s = _cpuCounter.NextValue();
            return s;
        }

        private double CalcWin32()
        {
            Win32.GetSystemTimes(out var idle, out var kernel, out var user);

            ulong currUser = user.ToQuad();
            ulong currKernel = kernel.ToQuad();
            ulong currIdle = idle.ToQuad();

            ulong u = currUser - _lastUser;
            ulong k = currKernel - _lastKernel;
            ulong i = currIdle - _lastIdle;

            ulong sys = k + u; // k includes idle
            double cpu = ((sys - i) * 100.0 / sys);

            _lastIdle = currIdle;
            _lastKernel = currKernel;
            _lastUser = currUser;
            return cpu;
        }
    }
}
