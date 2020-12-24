using System;
using System.Net.NetworkInformation;

namespace PingClientBase
{
	public record PingResult
	{
		/// <summary>
		/// 延迟，单位秒
		/// </summary>
		public double Latency { get; set; }

		/// <summary>
		/// 状态
		/// </summary>
		public IPStatus Status { get; set; }

		/// <summary>
		/// 返回的信息
		/// </summary>
		public string? Info { get; set; }

		public override string ToString()
		{
			return $@"{Status}: {Latency} s{(string.IsNullOrEmpty(Info) ? string.Empty : Environment.NewLine)}{Info}";
		}
	}
}
