using System;
using System.Net.NetworkInformation;

namespace TCPingInfoView.PingClientBase
{
	public class PingResult
	{
		public double Latency { get; set; }
		public IPStatus Status { get; set; }
		public string Info { get; set; }

		public override string ToString()
		{
			return $@"{Status}: {Latency} ms{(string.IsNullOrEmpty(Info) ? string.Empty : Environment.NewLine)}{Info}";
		}
	}
}
