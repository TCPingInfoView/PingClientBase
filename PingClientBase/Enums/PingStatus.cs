namespace PingClientBase.Enums
{
	public enum PingStatus
	{
		/// <summary>
		/// 未知错误
		/// </summary>
		Unknown,

		/// <summary>
		/// 成功
		/// </summary>
		Success,

		/// <summary>
		/// 超时
		/// </summary>
		TimedOut,

		/// <summary>
		/// 协议错误
		/// </summary>
		ProtocolError,

		/// <summary>
		/// IP 错误
		/// </summary>
		DestinationError,

		/// <summary>
		/// 端口错误
		/// </summary>
		PortError
	}
}
