using PingClientBase.Enums;
using System;

namespace PingClientBase
{
	public record PingResult
	{
		/// <summary>
		/// 延迟，单位毫秒
		/// </summary>
		public double Latency { get; set; }

		/// <summary>
		/// 状态
		/// </summary>
		public PingStatus Status { get; set; }

		/// <summary>
		/// 返回的信息
		/// </summary>
		public string? Info { get; set; }

		public PingResult(double latency = -1.0, PingStatus status = default, string? info = default)
		{
			Latency = latency;
			Status = status;
			Info = info;
		}

		public override string ToString()
		{
			return $@"{Status}: {Latency} ms{(string.IsNullOrEmpty(Info) ? string.Empty : Environment.NewLine)}{Info}";
		}
	}
}
