using Paymob.Net.Models;

namespace Paymob.Net;

/// <summary>
/// Service for handling Paymob authentication.
/// </summary>
public interface IPaymobService
{
    /// <summary>
    /// Authenticates with the Paymob API and retrieves an authentication token.
    /// </summary>
    /// <param name="cancellationToken">A token to cancel the operation.</param>
    /// <returns>The authentication response containing the token.</returns>
    Task<AuthResponse> AuthenticateAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Registers a new order with Paymob.
    /// </summary>
    /// <param name="request">The request containing order registration details.</param>
    /// <returns>The response containing order registration result.</returns>
    Task<OrderRegistrationResponse> RegisterOrderAsync(OrderRegistrationRequest request);

    /// <summary>
    /// Requests a payment key used for initiating the payment process.
    /// </summary>
    /// <param name="request">The request containing payment key details.</param>
    /// <returns>The response containing the generated payment key.</returns>
    Task<PaymentKeyResponse> RequestPaymentKeyAsync(PaymentKeyRequest request);

    /// <summary>
    /// Processes a payment using the specified payment request details.
    /// </summary>
    /// <param name="request">The payment request containing necessary transaction data.</param>
    /// <returns>The response of the payment operation.</returns>
    Task<PaymentResponse> ProcessPaymentAsync(PaymentRequest request);

    /// <summary>
    /// Retrieves details of a specific transaction by its ID.
    /// </summary>
    /// <param name="transactionId">The ID of the transaction to retrieve.</param>
    /// <returns>The response containing transaction details.</returns>
    Task<TransactionResponse> GetTransactionAsync(string transactionId);

    /// <summary>
    /// Initiates a refund request for a previously completed transaction.
    /// </summary>
    /// <param name="request">The refund request containing transaction and refund details.</param>
    /// <returns>The response indicating the result of the refund request.</returns>
    Task<RefundResponse> RefundTransactionAsync(RefundRequest request);
}
