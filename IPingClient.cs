using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace PingClientBase
{
	public interface IPingClient : IAsyncDisposable
	{
		string ProtocolName { get; }
		TimeSpan Timeout { get; set; }
		string Arguments { get; set; }
		IPEndPoint EndPoint { get; set; }
		ValueTask<PingResult> PingAsync(CancellationToken token);
	}
}
