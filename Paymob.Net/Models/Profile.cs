namespace Paymob.Net.Models
{
    public sealed class Profile
    {
        public int Id { get; set; }

        public User User { get; set; } = null!;

        public DateTime CreatedAt { get; set; }

        public bool Active { get; set; }

        public string ProfileType { get; set; } = null!;

        public List<string> Phones { get; set; } = [];

        public List<string> CompanyEmails { get; set; } = [];

        public string CompanyName { get; set; } = null!;

        public string State { get; set; } = null!;

        public string Country { get; set; } = null!;

        public string City { get; set; } = null!;

        public string PostalCode { get; set; } = null!;

        public string Street { get; set; } = null!;

        public bool EmailNotification { get; set; }

        public object OrderRetrievalEndpoint { get; set; } = null!;

        public object DeliveryUpdateEndpoint { get; set; } = null!;

        public object LogoUrl { get; set; } = null!;

        public bool IsMobadra { get; set; }

        public object Sector { get; set; } = null!;

        public bool Is2faEnabled { get; set; }

        public string OtpSentTo { get; set; } = null!;

        public int ActivationMethod { get; set; }
        public object SignedUpThrough { get; set; } = null!;

        public object FailedAttempts { get; set; } = null!;

        public List<object> CustomExportColumns { get; set; } = null!;

        public List<object> ServerIP { get; set; } = null!;

        public object Username { get; set; } = null!;
        public string PrimaryPhoneNumber { get; set; } = null!;

        public bool PrimaryPhoneVerified { get; set; }

        public bool IsTempPassword { get; set; }

        public object Otp2faSentAt { get; set; } = null!;

        public object Otp2faAttempt { get; set; } = null!;

        public DateTime OtpSentAt { get; set; }

        public DateTime OtpValidatedAt { get; set; }

        public object AwbBanner { get; set; } = null!;

        public object EmailBanner { get; set; } = null!;

        public object IdentificationNumber { get; set; } = null!;
        public string DeliveryStatusCallback { get; set; } = null!;

        public object MerchantExternalLink { get; set; } = null!;

        public object MerchantStatus { get; set; } = null!;

        public bool DeactivatedByBank { get; set; }
        public object BankDeactivationReason { get; set; } = null!;

        public object BankMerchantStatus { get; set; } = null!;

        public object NationalId { get; set; } = null!;

        public object SuperAgent { get; set; } = null!;

        public object WalletLimitProfile { get; set; } = null!;
        public object Address { get; set; } = null!;

        public object CommercialRegistration { get; set; } = null!;

        public object CommercialRegistrationArea { get; set; } = null!;
        public object DistributorCode { get; set; } = null!;
        public object DistributorBranchCode { get; set; } = null!;
        public bool AllowTerminalOrderId { get; set; }
        public bool AllowEncryptionBypass { get; set; }
        public object WalletPhoneNumber { get; set; } = null!;
        public object Suspicious { get; set; } = null!;
        public object Latitude { get; set; } = null!;
        public object Longitude { get; set; } = null!;
        public BankStaffs BankStaffs { get; set; } = null!;
        public object BankRejectionReason { get; set; } = null!;
        public bool BankReceivedDocuments { get; set; }

        public object BankMerchantDigitalStatus { get; set; } = null!;
        public object BankDigitalRejectionReason { get; set; } = null!;

        public bool FilledBusinessData { get; set; }
        public string DayStartTime { get; set; } = null!;
        public object DayEndTime { get; set; } = null!;
        public bool WithholdTransfers { get; set; }
        public bool ManualSettlement { get; set; }
        public string SmsSenderName { get; set; } = null!;
        public object WithholdTransfersReason { get; set; } = null!;
        public object WithholdTransfersNotes { get; set; } = null!;
        public bool CanBillDepositWithCard { get; set; }
        public bool CanTopupMerchants { get; set; }
        public object TopupTransferId { get; set; } = null!;
        public bool ReferralEligible { get; set; }
        public bool IsEligibleToBeRanger { get; set; }

        public bool IsRanger { get; set; }

        public bool IsPoaching { get; set; }
        public bool PaymobAppMerchant { get; set; }
        public object SettlementFrequency { get; set; } = null!;
        public object DayOfTheWeek { get; set; } = null!;
        public object DayOfTheMonth { get; set; } = null!;
        public bool AllowTransactionNotifications { get; set; }

        public bool AllowTransferNotifications { get; set; }

        public object SallefnyAmountWhole { get; set; } = null!;
        public object SallefnyFeesWhole { get; set; } = null!;
        public DateTime PaymobAppFirstLogin { get; set; }
        public DateTime PaymobAppLastActivity { get; set; }
        public bool PayoutEnabled { get; set; }
        public bool PayoutTerms { get; set; }
        public bool IsBillsNew { get; set; }
        public bool CanProcessMultipleRefunds { get; set; }
        public object SettlementClassification { get; set; } = null!;
        public bool InstantSettlementEnabled { get; set; }
        public bool InstantSettlementTransactionOtpVerified { get; set; }
        public string PreferredLanguage { get; set; } = null!;

        public bool IgnoreFlashCallbacks { get; set; }

        public object AcqPartner { get; set; } = null!;

        public object Dom { get; set; } = null!;

        public object BankRelated { get; set; } = null!;
        public List<object> Permissions { get; set; } = null!;
    }



}
