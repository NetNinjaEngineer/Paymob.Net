using System.Net;

namespace Paymob.Net
{
    /// <summary>
    /// Exception thrown when a Paymob API request fails.
    /// </summary>
    /// <remarks>
    /// Initializes a new instance of the <see cref="PaymobApiException"/> class.
    /// </remarks>
    public class PaymobApiException(string message, HttpStatusCode statusCode, string responseContent) : Exception(message)
    {
        /// <summary>
        /// The HTTP status code of the failed request.
        /// </summary>
        public HttpStatusCode StatusCode { get; } = statusCode;

        /// <summary>
        /// The raw response content from the API.
        /// </summary>
        public string ResponseContent { get; } = responseContent;
    }
}
