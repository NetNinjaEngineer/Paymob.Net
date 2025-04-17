namespace Paymob.Net
{
    /// <summary>
    /// Options for configuring the PaymobClient.
    /// </summary>
    public class PaymobClientOptions
    {
        /// <summary>
        /// The base URL for the Paymob API.
        /// </summary>
        public string BaseUrl { get; set; } = "https://accept.paymob.com/api/";

        /// <summary>
        /// The API key to use for authentication.
        /// </summary>
        public string? ApiKey { get; set; }

        /// <summary>
        /// The timeout for HTTP requests in seconds.
        /// </summary>
        public int TimeoutSeconds { get; set; } = 30;
    }

}
