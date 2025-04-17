using Microsoft.Extensions.Options;
using Paymob.Net.Models;

namespace Paymob.Net;

/// <summary>
/// Implementation of the Paymob authentication service.
/// </summary>
/// <remarks>
/// Initializes a new instance of the <see cref="PaymobService"/> class.
/// </remarks>
/// <param name="client">The Paymob client.</param>
/// <param name="paymobOptions"></param>
public sealed class PaymobService(PaymobClient client, IOptions<PaymobClientOptions> paymobOptions) : IPaymobService
{
    private readonly PaymobClientOptions _paymobOptions = paymobOptions.Value;

    /// <inheritdoc/>
    public async Task<AuthResponse> AuthenticateAsync(CancellationToken cancellationToken = default)
        => await client.AuthenticateAsync(new AuthRequest { ApiKey = _paymobOptions.ApiKey! }, cancellationToken);

    /// <inheritdoc/>
    public async Task<OrderRegistrationResponse> RegisterOrderAsync(OrderRegistrationRequest request)
        => await client.RegisterOrderAsync(request);

    /// <inheritdoc/>
    public async Task<PaymentKeyResponse> RequestPaymentKeyAsync(PaymentKeyRequest request)
        => await client.RequestPaymentKeyAsync(request);

    /// <inheritdoc/>
    public async Task<PaymentResponse> ProcessPaymentAsync(PaymentRequest request)
        => await client.ProcessPaymentAsync(request);

    /// <inheritdoc/>
    public async Task<TransactionResponse> GetTransactionAsync(string transactionId)
        => await client.GetTransactionAsync(transactionId);

    /// <inheritdoc/>
    public async Task<RefundResponse> RefundTransactionAsync(RefundRequest request)
        => await client.RefundTransactionAsync(request);
}
