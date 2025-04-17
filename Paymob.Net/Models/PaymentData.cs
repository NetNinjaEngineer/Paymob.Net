using System.Text.Json.Serialization;

namespace Paymob.Net.Models;

public sealed class PaymentData
{
    [JsonPropertyName("klass")]
    public string Klass { get; set; } = null!;

    [JsonPropertyName("gateway_integration_pk")]
    public int GatewayIntegrationPk { get; set; }

    [JsonPropertyName("amount")]
    public int Amount { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }

    [JsonPropertyName("currency")]
    public string Currency { get; set; } = null!;

    [JsonPropertyName("error_occured")]
    public bool ErrorOccured { get; set; }

    [JsonPropertyName("has_parent_transaction")]
    public bool HasParentTransaction { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("integration_id")]
    public int IntegrationId { get; set; }

    [JsonPropertyName("is_3d_secure")]
    public bool Is3dSecure { get; set; }

    [JsonPropertyName("is_auth")]
    public bool IsAuth { get; set; }

    [JsonPropertyName("is_capture")]
    public bool IsCapture { get; set; }

    [JsonPropertyName("is_refunded")]
    public bool IsRefunded { get; set; }

    [JsonPropertyName("is_standalone_payment")]
    public bool IsStandalonePayment { get; set; }

    [JsonPropertyName("is_voided")]
    public bool IsVoided { get; set; }

    [JsonPropertyName("order")]
    public int Order { get; set; }

    [JsonPropertyName("owner")]
    public int Owner { get; set; }

    [JsonPropertyName("pending")]
    public bool Pending { get; set; }

    [JsonPropertyName("source_data_pan")]
    public string SourceDataPan { get; set; } = null!;

    [JsonPropertyName("source_data_sub_type")]
    public string SourceDataSubType { get; set; } = null!;

    [JsonPropertyName("source_data_type")]
    public string SourceDataType { get; set; } = null!;

    [JsonPropertyName("success")]
    public bool Success { get; set; }
}
