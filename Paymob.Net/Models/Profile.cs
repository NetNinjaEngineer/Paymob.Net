using System.Text.Json.Serialization;

namespace Paymob.Net.Models
{
    public sealed class Profile
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("user")]
        public User User { get; set; } = null!;

        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("active")]
        public bool Active { get; set; }

        [JsonPropertyName("profile_type")]
        public string ProfileType { get; set; } = null!;

        [JsonPropertyName("phones")]
        public List<string> Phones { get; set; } = [];

        [JsonPropertyName("company_emails")]
        public List<string> CompanyEmails { get; set; } = [];

        [JsonPropertyName("company_name")]
        public string CompanyName { get; set; } = null!;

        [JsonPropertyName("state")]
        public string State { get; set; } = null!;

        [JsonPropertyName("country")]
        public string Country { get; set; } = null!;

        [JsonPropertyName("city")]
        public string City { get; set; } = null!;

        [JsonPropertyName("postal_code")]
        public string PostalCode { get; set; } = null!;

        [JsonPropertyName("street")]
        public string Street { get; set; } = null!;

        [JsonPropertyName("email_notification")]
        public bool EmailNotification { get; set; }

        [JsonPropertyName("order_retrieval_endpoint")]
        public object OrderRetrievalEndpoint { get; set; } = null!;

        [JsonPropertyName("delivery_update_endpoint")]
        public object DeliveryUpdateEndpoint { get; set; } = null!;

        [JsonPropertyName("logo_url")]
        public object LogoUrl { get; set; } = null!;

        [JsonPropertyName("is_mobadra")]
        public bool IsMobadra { get; set; }

        [JsonPropertyName("sector")]
        public object Sector { get; set; } = null!;

        [JsonPropertyName("is_2fa_enabled")]
        public bool Is2faEnabled { get; set; }

        [JsonPropertyName("otp_sent_to")]
        public string OtpSentTo { get; set; } = null!;

        [JsonPropertyName("activation_method")]
        public int ActivationMethod { get; set; }

        [JsonPropertyName("signed_up_through")]
        public object SignedUpThrough { get; set; } = null!;

        [JsonPropertyName("failed_attempts")]
        public object FailedAttempts { get; set; } = null!;

        [JsonPropertyName("custom_export_columns")]
        public List<object> CustomExportColumns { get; set; } = null!;

        [JsonPropertyName("server_IP")]
        public List<object> ServerIP { get; set; } = null!;

        [JsonPropertyName("username")]
        public object Username { get; set; } = null!;

        [JsonPropertyName("primary_phone_number")]
        public string PrimaryPhoneNumber { get; set; } = null!;

        [JsonPropertyName("primary_phone_verified")]
        public bool PrimaryPhoneVerified { get; set; }

        [JsonPropertyName("is_temp_password")]
        public bool IsTempPassword { get; set; }

        [JsonPropertyName("otp_2fa_sent_at")]
        public object Otp2faSentAt { get; set; } = null!;

        [JsonPropertyName("otp_2fa_attempt")]
        public object Otp2faAttempt { get; set; } = null!;

        [JsonPropertyName("otp_sent_at")]
        public DateTime OtpSentAt { get; set; }

        [JsonPropertyName("otp_validated_at")]
        public DateTime OtpValidatedAt { get; set; }

        [JsonPropertyName("awb_banner")]
        public object AwbBanner { get; set; } = null!;

        [JsonPropertyName("email_banner")]
        public object EmailBanner { get; set; } = null!;

        [JsonPropertyName("identification_number")]
        public object IdentificationNumber { get; set; } = null!;

        [JsonPropertyName("delivery_status_callback")]
        public string DeliveryStatusCallback { get; set; } = null!;

        [JsonPropertyName("merchant_external_link")]
        public object MerchantExternalLink { get; set; } = null!;

        [JsonPropertyName("merchant_status")]
        public object MerchantStatus { get; set; } = null!;

        [JsonPropertyName("deactivated_by_bank")]
        public bool DeactivatedByBank { get; set; }

        [JsonPropertyName("bank_deactivation_reason")]
        public object BankDeactivationReason { get; set; } = null!;

        [JsonPropertyName("bank_merchant_status")]
        public object BankMerchantStatus { get; set; } = null!;

        [JsonPropertyName("national_id")]
        public object NationalId { get; set; } = null!;

        [JsonPropertyName("super_agent")]
        public object SuperAgent { get; set; } = null!;

        [JsonPropertyName("wallet_limit_profile")]
        public object WalletLimitProfile { get; set; } = null!;

        [JsonPropertyName("address")]
        public object Address { get; set; } = null!;

        [JsonPropertyName("commercial_registration")]
        public object CommercialRegistration { get; set; } = null!;

        [JsonPropertyName("commercial_registration_area")]
        public object CommercialRegistrationArea { get; set; } = null!;

        [JsonPropertyName("distributor_code")]
        public object DistributorCode { get; set; } = null!;

        [JsonPropertyName("distributor_branch_code")]
        public object DistributorBranchCode { get; set; } = null!;

        [JsonPropertyName("allow_terminal_order_id")]
        public bool AllowTerminalOrderId { get; set; }

        [JsonPropertyName("allow_encryption_bypass")]
        public bool AllowEncryptionBypass { get; set; }

        [JsonPropertyName("wallet_phone_number")]
        public object WalletPhoneNumber { get; set; } = null!;

        [JsonPropertyName("suspicious")]
        public object Suspicious { get; set; } = null!;

        [JsonPropertyName("latitude")]
        public object Latitude { get; set; } = null!;

        [JsonPropertyName("longitude")]
        public object Longitude { get; set; } = null!;

        [JsonPropertyName("bank_staffs")]
        public BankStaffs BankStaffs { get; set; } = null!;

        [JsonPropertyName("bank_rejection_reason")]
        public object BankRejectionReason { get; set; } = null!;

        [JsonPropertyName("bank_received_documents")]
        public bool BankReceivedDocuments { get; set; }

        [JsonPropertyName("bank_merchant_digital_status")]
        public object BankMerchantDigitalStatus { get; set; } = null!;

        [JsonPropertyName("bank_digital_rejection_reason")]
        public object BankDigitalRejectionReason { get; set; } = null!;

        [JsonPropertyName("filled_business_data")]
        public bool FilledBusinessData { get; set; }

        [JsonPropertyName("day_start_time")]
        public string DayStartTime { get; set; } = null!;

        [JsonPropertyName("day_end_time")]
        public object DayEndTime { get; set; } = null!;

        [JsonPropertyName("withhold_transfers")]
        public bool WithholdTransfers { get; set; }

        [JsonPropertyName("manual_settlement")]
        public bool ManualSettlement { get; set; }

        [JsonPropertyName("sms_sender_name")]
        public string SmsSenderName { get; set; } = null!;

        [JsonPropertyName("withhold_transfers_reason")]
        public object WithholdTransfersReason { get; set; } = null!;

        [JsonPropertyName("withhold_transfers_notes")]
        public object WithholdTransfersNotes { get; set; } = null!;

        [JsonPropertyName("can_bill_deposit_with_card")]
        public bool CanBillDepositWithCard { get; set; }

        [JsonPropertyName("can_topup_merchants")]
        public bool CanTopupMerchants { get; set; }

        [JsonPropertyName("topup_transfer_id")]
        public object TopupTransferId { get; set; } = null!;

        [JsonPropertyName("referral_eligible")]
        public bool ReferralEligible { get; set; }

        [JsonPropertyName("is_eligible_to_be_ranger")]
        public bool IsEligibleToBeRanger { get; set; }

        [JsonPropertyName("is_ranger")]
        public bool IsRanger { get; set; }

        [JsonPropertyName("is_poaching")]
        public bool IsPoaching { get; set; }

        [JsonPropertyName("paymob_app_merchant")]
        public bool PaymobAppMerchant { get; set; }

        [JsonPropertyName("settlement_frequency")]
        public object SettlementFrequency { get; set; } = null!;

        [JsonPropertyName("day_of_the_week")]
        public object DayOfTheWeek { get; set; } = null!;

        [JsonPropertyName("day_of_the_month")]
        public object DayOfTheMonth { get; set; } = null!;

        [JsonPropertyName("allow_transaction_notifications")]
        public bool AllowTransactionNotifications { get; set; }

        [JsonPropertyName("allow_transfer_notifications")]
        public bool AllowTransferNotifications { get; set; }

        [JsonPropertyName("sallefny_amount_whole")]
        public object SallefnyAmountWhole { get; set; } = null!;

        [JsonPropertyName("sallefny_fees_whole")]
        public object SallefnyFeesWhole { get; set; } = null!;

        [JsonPropertyName("paymob_app_first_login")]
        public DateTime PaymobAppFirstLogin { get; set; }

        [JsonPropertyName("paymob_app_last_activity")]
        public DateTime PaymobAppLastActivity { get; set; }

        [JsonPropertyName("payout_enabled")]
        public bool PayoutEnabled { get; set; }

        [JsonPropertyName("payout_terms")]
        public bool PayoutTerms { get; set; }

        [JsonPropertyName("is_bills_new")]
        public bool IsBillsNew { get; set; }

        [JsonPropertyName("can_process_multiple_refunds")]
        public bool CanProcessMultipleRefunds { get; set; }

        [JsonPropertyName("settlement_classification")]
        public object SettlementClassification { get; set; } = null!;

        [JsonPropertyName("instant_settlement_enabled")]
        public bool InstantSettlementEnabled { get; set; }

        [JsonPropertyName("instant_settlement_transaction_otp_verified")]
        public bool InstantSettlementTransactionOtpVerified { get; set; }

        [JsonPropertyName("preferred_language")]
        public string PreferredLanguage { get; set; } = null!;

        [JsonPropertyName("ignore_flash_callbacks")]
        public bool IgnoreFlashCallbacks { get; set; }

        [JsonPropertyName("acq_partner")]
        public object AcqPartner { get; set; } = null!;

        [JsonPropertyName("dom")]
        public object Dom { get; set; } = null!;

        [JsonPropertyName("bank_related")]
        public object BankRelated { get; set; } = null!;

        [JsonPropertyName("permissions")]
        public List<object> Permissions { get; set; } = null!;
    }



}
