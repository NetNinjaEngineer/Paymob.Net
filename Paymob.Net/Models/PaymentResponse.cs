using System.Text.Json.Serialization;

namespace Paymob.Net.Models;

public sealed class PaymentResponse
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("pending")]
    public bool Pending { get; set; }

    [JsonPropertyName("amount_cents")]
    public int AmountCents { get; set; }

    [JsonPropertyName("success")]
    public bool Success { get; set; }

    [JsonPropertyName("is_auth")]
    public bool IsAuth { get; set; }

    [JsonPropertyName("is_capture")]
    public bool IsCapture { get; set; }

    [JsonPropertyName("is_standalone_payment")]
    public bool IsStandalonePayment { get; set; }

    [JsonPropertyName("is_voided")]
    public bool IsVoided { get; set; }

    [JsonPropertyName("is_refunded")]
    public bool IsRefunded { get; set; }

    [JsonPropertyName("is_3d_secure")]
    public bool Is3dSecure { get; set; }

    [JsonPropertyName("integration_id")]
    public int IntegrationId { get; set; }

    [JsonPropertyName("profile_id")]
    public int ProfileId { get; set; }

    [JsonPropertyName("has_parent_transaction")]
    public bool HasParentTransaction { get; set; }

    [JsonPropertyName("order")]
    public PaymentOrder Order { get; set; } = null!;

    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }

    [JsonPropertyName("transaction_processed_callback_responses")]
    public List<object> TransactionProcessedCallbackResponses { get; set; } = [];

    [JsonPropertyName("currency")]
    public string Currency { get; set; } = null!;

    [JsonPropertyName("source_data")]
    public SourceData SourceData { get; set; } = null!;

    [JsonPropertyName("api_source")]
    public string ApiSource { get; set; } = null!;

    [JsonPropertyName("terminal_id")]
    public string TerminalId { get; set; } = null!;

    [JsonPropertyName("merchant_commission")]
    public int MerchantCommission { get; set; }

    [JsonPropertyName("installment")]
    public string Installment { get; set; } = null!;

    [JsonPropertyName("discount_fees")]
    public int DiscountFees { get; set; }

    [JsonPropertyName("is_void")]
    public bool IsVoid { get; set; }

    [JsonPropertyName("is_refund")]
    public bool IsRefund { get; set; }

    [JsonPropertyName("data")]
    public PaymentData Data { get; set; } = null!;

    [JsonPropertyName("is_hidden")]
    public bool IsHidden { get; set; }

    [JsonPropertyName("payment_key_claims")]
    public PaymentKeyClaims PaymentKeyClaims { get; set; } = null!;

    [JsonPropertyName("error_occured")]
    public bool ErrorOccured { get; set; }

    [JsonPropertyName("is_live")]
    public bool IsLive { get; set; }

    [JsonPropertyName("other_endpoint_reference")]
    public string OtherEndpointReference { get; set; } = null!;

    [JsonPropertyName("refunded_amount_cents")]
    public int RefundedAmountCents { get; set; }

    [JsonPropertyName("source_id")]
    public int SourceId { get; set; }

    [JsonPropertyName("is_captured")]
    public bool IsCaptured { get; set; }

    [JsonPropertyName("captured_amount")]
    public int CapturedAmount { get; set; }

    [JsonPropertyName("merchant_staff_tag")]
    public string MerchantStaffTag { get; set; } = null!;

    [JsonPropertyName("updated_at")]
    public DateTime UpdatedAt { get; set; }

    [JsonPropertyName("owner")]
    public int Owner { get; set; }

    [JsonPropertyName("parent_transaction")]
    public object ParentTransaction { get; set; } = null!;
}
