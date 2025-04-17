using System.Text.Json.Serialization;

namespace Paymob.Net.Models;

public sealed class OrderRegistrationResponse
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }

    [JsonPropertyName("delivery_needed")]
    public bool DeliveryNeeded { get; set; }

    [JsonPropertyName("merchant")]
    public Merchant Merchant { get; set; }

    [JsonPropertyName("collector")]
    public object Collector { get; set; } = null!;

    [JsonPropertyName("amount_cents")]
    public int AmountCents { get; set; }

    [JsonPropertyName("shipping_data")]
    public ShippingData ShippingData { get; set; } = null!;

    [JsonPropertyName("shipping_details")]
    public ShippingDetails ShippingDetails { get; set; } = null!;

    [JsonPropertyName("currency")]
    public string Currency { get; set; } = null!;

    [JsonPropertyName("is_payment_locked")]
    public bool IsPaymentLocked { get; set; }

    [JsonPropertyName("is_return")]
    public bool IsReturn { get; set; }

    [JsonPropertyName("is_cancel")]
    public bool IsCancel { get; set; }

    [JsonPropertyName("is_returned")]
    public bool IsReturned { get; set; }

    [JsonPropertyName("is_canceled")]
    public bool IsCanceled { get; set; }

    [JsonPropertyName("merchant_order_id")]
    public string MerchantOrderId { get; set; } = null!;

    [JsonPropertyName("wallet_notification")]
    public object WalletNotification { get; set; } = null!;

    [JsonPropertyName("paid_amount_cents")]
    public int PaidAmountCents { get; set; }

    [JsonPropertyName("notify_user_with_email")]
    public bool NotifyUserWithEmail { get; set; }

    [JsonPropertyName("items")]
    public List<OrderItem> Items { get; set; } = [];

    [JsonPropertyName("order_url")]
    public string OrderUrl { get; set; } = null!;

    [JsonPropertyName("commission_fees")]
    public int CommissionFees { get; set; }

    [JsonPropertyName("delivery_fees_cents")]
    public int DeliveryFeesCents { get; set; }

    [JsonPropertyName("delivery_vat_cents")]
    public int DeliveryVatCents { get; set; }

    [JsonPropertyName("payment_method")]
    public string PaymentMethod { get; set; } = null!;

    [JsonPropertyName("merchant_staff_tag")]
    public object MerchantStaffTag { get; set; } = null!;

    [JsonPropertyName("api_source")]
    public string ApiSource { get; set; } = null!;

    [JsonPropertyName("pickup_data")]
    public object PickupData { get; set; } = null!;

    [JsonPropertyName("delivery_status")]
    public List<object> DeliveryStatus { get; set; } = [];
}
