using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace PingClientBase
{
	public interface IPingClient : IDisposable, IAsyncDisposable
	{
		/// <summary>
		/// 协议名
		/// </summary>
		string ProtocolName { get; }

		/// <summary>
		/// 超时时间
		/// </summary>
		TimeSpan Timeout { get; set; }

		/// <summary>
		/// 参数
		/// </summary>
		string Arguments { get; set; }

		/// <summary>
		/// 节点
		/// </summary>
		IPEndPoint EndPoint { get; set; }

		ValueTask<PingResult> PingAsync(CancellationToken token);
		PingResult Ping();
	}
}
