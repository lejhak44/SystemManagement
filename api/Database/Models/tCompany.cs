using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class tCompany
    {
        public tCompany()
        {
            BillingInvoiceWalkInList = new HashSet<BillingInvoiceWalkInList>();
            _tDatabaseMemoryLog = new HashSet<_tDatabaseMemoryLog>();
            _tModelReport = new HashSet<_tModelReport>();
            tAppointment = new HashSet<tAppointment>();
            tAppointmentRequest = new HashSet<tAppointmentRequest>();
            tAppointmentSchedule = new HashSet<tAppointmentSchedule>();
            tAppointmentStatusLog = new HashSet<tAppointmentStatusLog>();
            tBillingInvoice = new HashSet<tBillingInvoice>();
            tBillingInvoiceWalkIn = new HashSet<tBillingInvoiceWalkIn>();
            tBillingInvoiceWalkInList = new HashSet<tBillingInvoiceWalkInList>();
            tBillingInvoice_Detail = new HashSet<tBillingInvoice_Detail>();
            tBillingInvoice_Patient = new HashSet<tBillingInvoice_Patient>();
            tBreedSpecie = new HashSet<tBreedSpecie>();
            tCardType = new HashSet<tCardType>();
            tCaseType = new HashSet<tCaseType>();
            tClient = new HashSet<tClient>();
            tClientDeposit = new HashSet<tClientDeposit>();
            tClientWithdraw_ = new HashSet<tClientWithdraw_>();
            tClient_CreditLogs = new HashSet<tClient_CreditLogs>();
            tCompanyInfo = new HashSet<tCompanyInfo>();
            tCompanyTextBlastTemplate = new HashSet<tCompanyTextBlastTemplate>();
            tCompany_SMSSetting = new HashSet<tCompany_SMSSetting>();
            tCompany_Subscription = new HashSet<tCompany_Subscription>();
            tCountry = new HashSet<tCountry>();
            tCustomDetailViewRoute = new HashSet<tCustomDetailViewRoute>();
            tCustomNavigationLink = new HashSet<tCustomNavigationLink>();
            tDentalExamination = new HashSet<tDentalExamination>();
            tDentition = new HashSet<tDentition>();
            tDocumentStatus = new HashSet<tDocumentStatus>();
            tEmployeeInfo = new HashSet<tEmployeeInfo>();
            tEmploymentStatus = new HashSet<tEmploymentStatus>();
            tEmplyee = new HashSet<tEmplyee>();
            tExpenseCategory = new HashSet<tExpenseCategory>();
            tFilingStatus = new HashSet<tFilingStatus>();
            tForBilling = new HashSet<tForBilling>();
            tHelpDeskVideoTutorial = new HashSet<tHelpDeskVideoTutorial>();
            tITextMoAPISMSStatus = new HashSet<tITextMoAPISMSStatus>();
            tInventoryStatus = new HashSet<tInventoryStatus>();
            tInventorySummary = new HashSet<tInventorySummary>();
            tInventoryTrail = new HashSet<tInventoryTrail>();
            tIssueTracker = new HashSet<tIssueTracker>();
            tItem = new HashSet<tItem>();
            tItemCategory = new HashSet<tItemCategory>();
            tItemInventoriable = new HashSet<tItemInventoriable>();
            tItemService = new HashSet<tItemService>();
            tItemType = new HashSet<tItemType>();
            tItem_UnitCostLog = new HashSet<tItem_UnitCostLog>();
            tItem_UnitPriceLog = new HashSet<tItem_UnitPriceLog>();
            tLocalShippingPermitIssuance = new HashSet<tLocalShippingPermitIssuance>();
            tLocalShippingPermitIssuance_Item = new HashSet<tLocalShippingPermitIssuance_Item>();
            tLocalShippingPermitIssuance_Requirement = new HashSet<tLocalShippingPermitIssuance_Requirement>();
            tMedicalHistoryQuestionnaire = new HashSet<tMedicalHistoryQuestionnaire>();
            tMedicationRoute = new HashSet<tMedicationRoute>();
            tMessage = new HashSet<tMessage>();
            tPatientAppointment = new HashSet<tPatientAppointment>();
            tPatientSOAPList = new HashSet<tPatientSOAPList>();
            tPatientWaitingList = new HashSet<tPatientWaitingList>();
            tPatientWaitingList_Logs = new HashSet<tPatientWaitingList_Logs>();
            tPatient_BirthDateSMSGreetingLog = new HashSet<tPatient_BirthDateSMSGreetingLog>();
            tPatient_Confinement = new HashSet<tPatient_Confinement>();
            tPatient_Confinement_ItemsServices = new HashSet<tPatient_Confinement_ItemsServices>();
            tPatient_Confinement_Patient = new HashSet<tPatient_Confinement_Patient>();
            tPatient_CreditLogs = new HashSet<tPatient_CreditLogs>();
            tPatient_DentalExamination_Image = new HashSet<tPatient_DentalExamination_Image>();
            tPatient_DentalExamination_MedicalHistory = new HashSet<tPatient_DentalExamination_MedicalHistory>();
            tPatient_DentalExamination_ToothInfo = new HashSet<tPatient_DentalExamination_ToothInfo>();
            tPatient_Lodging = new HashSet<tPatient_Lodging>();
            tPatient_SOAP = new HashSet<tPatient_SOAP>();
            tPatient_SOAP_Prescription = new HashSet<tPatient_SOAP_Prescription>();
            tPatient_SOAP_SMSStatus = new HashSet<tPatient_SOAP_SMSStatus>();
            tPatient_SOAP_Treatment = new HashSet<tPatient_SOAP_Treatment>();
            tPatient_Vaccination = new HashSet<tPatient_Vaccination>();
            tPatient_Vaccination_Schedule = new HashSet<tPatient_Vaccination_Schedule>();
            tPatient_Vaccination_Schedule_SMSStatus = new HashSet<tPatient_Vaccination_Schedule_SMSStatus>();
            tPatient_Wellness = new HashSet<tPatient_Wellness>();
            tPatient_Wellness_Detail = new HashSet<tPatient_Wellness_Detail>();
            tPatient_Wellness_Schedule = new HashSet<tPatient_Wellness_Schedule>();
            tPatient_Wellness_Schedule_SMSStatus = new HashSet<tPatient_Wellness_Schedule_SMSStatus>();
            tPayable = new HashSet<tPayable>();
            tPayablePayment = new HashSet<tPayablePayment>();
            tPayable_Detail = new HashSet<tPayable_Detail>();
            tPaymentMethod = new HashSet<tPaymentMethod>();
            tPaymentTransaction = new HashSet<tPaymentTransaction>();
            tPurchaseOrder = new HashSet<tPurchaseOrder>();
            tQuestionType = new HashSet<tQuestionType>();
            tReceivingReport = new HashSet<tReceivingReport>();
            tReceivingReport_Detail = new HashSet<tReceivingReport_Detail>();
            tRecurScheduleType = new HashSet<tRecurScheduleType>();
            tSMSPatientSOAP_Company = new HashSet<tSMSPatientSOAP_Company>();
            tSOAPType = new HashSet<tSOAPType>();
            tSalesReturn = new HashSet<tSalesReturn>();
            tSalesReturn_Detail = new HashSet<tSalesReturn_Detail>();
            tSchedule = new HashSet<tSchedule>();
            tServiceType = new HashSet<tServiceType>();
            tStudent = new HashSet<tStudent>();
            tSupplier = new HashSet<tSupplier>();
            tTaxScheme = new HashSet<tTaxScheme>();
            tTeacher = new HashSet<tTeacher>();
            tTeethQuandrant = new HashSet<tTeethQuandrant>();
            tTextBlast = new HashSet<tTextBlast>();
            tTextBlast_Client = new HashSet<tTextBlast_Client>();
            tTextBlast_Client_SMSStatus = new HashSet<tTextBlast_Client_SMSStatus>();
            tToothInfo = new HashSet<tToothInfo>();
            tToothStatus = new HashSet<tToothStatus>();
            tToothStatusType = new HashSet<tToothStatusType>();
            tToothSurface = new HashSet<tToothSurface>();
            tUnitOfMeasure = new HashSet<tUnitOfMeasure>();
            tVeterinaryCertificate = new HashSet<tVeterinaryCertificate>();
            tVeterinaryHealthCertificate = new HashSet<tVeterinaryHealthCertificate>();
            tViewType = new HashSet<tViewType>();
        }

        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public string Comment { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public int? ID_CreatedBy { get; set; }
        public int? ID_LastModifiedBy { get; set; }
        public int? ID_Country { get; set; }
        public string Address { get; set; }
        public string ImageLogoFilename { get; set; }
        public string ContactNumber { get; set; }
        public string ImageHeaderFilename { get; set; }
        public string Email { get; set; }
        public bool? IsShowPOSReceiptLogo { get; set; }
        public string SOAPPlanSMSMessage { get; set; }
        public bool? IsRemoveBoldText { get; set; }
        public bool? IsShowHeader { get; set; }
        public string POSReceiptFontSize { get; set; }
        public string SecurityPIN { get; set; }
        public bool? IsShowPaymentLabel { get; set; }
        public bool? IsShowPaymentWarningLabel { get; set; }
        public int? ID_PackagePlan { get; set; }

        public virtual tUser ID_CreatedByNavigation { get; set; }
        public virtual tUser ID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<BillingInvoiceWalkInList> BillingInvoiceWalkInList { get; set; }
        public virtual ICollection<_tDatabaseMemoryLog> _tDatabaseMemoryLog { get; set; }
        public virtual ICollection<_tModelReport> _tModelReport { get; set; }
        public virtual ICollection<tAppointment> tAppointment { get; set; }
        public virtual ICollection<tAppointmentRequest> tAppointmentRequest { get; set; }
        public virtual ICollection<tAppointmentSchedule> tAppointmentSchedule { get; set; }
        public virtual ICollection<tAppointmentStatusLog> tAppointmentStatusLog { get; set; }
        public virtual ICollection<tBillingInvoice> tBillingInvoice { get; set; }
        public virtual ICollection<tBillingInvoiceWalkIn> tBillingInvoiceWalkIn { get; set; }
        public virtual ICollection<tBillingInvoiceWalkInList> tBillingInvoiceWalkInList { get; set; }
        public virtual ICollection<tBillingInvoice_Detail> tBillingInvoice_Detail { get; set; }
        public virtual ICollection<tBillingInvoice_Patient> tBillingInvoice_Patient { get; set; }
        public virtual ICollection<tBreedSpecie> tBreedSpecie { get; set; }
        public virtual ICollection<tCardType> tCardType { get; set; }
        public virtual ICollection<tCaseType> tCaseType { get; set; }
        public virtual ICollection<tClient> tClient { get; set; }
        public virtual ICollection<tClientDeposit> tClientDeposit { get; set; }
        public virtual ICollection<tClientWithdraw_> tClientWithdraw_ { get; set; }
        public virtual ICollection<tClient_CreditLogs> tClient_CreditLogs { get; set; }
        public virtual ICollection<tCompanyInfo> tCompanyInfo { get; set; }
        public virtual ICollection<tCompanyTextBlastTemplate> tCompanyTextBlastTemplate { get; set; }
        public virtual ICollection<tCompany_SMSSetting> tCompany_SMSSetting { get; set; }
        public virtual ICollection<tCompany_Subscription> tCompany_Subscription { get; set; }
        public virtual ICollection<tCountry> tCountry { get; set; }
        public virtual ICollection<tCustomDetailViewRoute> tCustomDetailViewRoute { get; set; }
        public virtual ICollection<tCustomNavigationLink> tCustomNavigationLink { get; set; }
        public virtual ICollection<tDentalExamination> tDentalExamination { get; set; }
        public virtual ICollection<tDentition> tDentition { get; set; }
        public virtual ICollection<tDocumentStatus> tDocumentStatus { get; set; }
        public virtual ICollection<tEmployeeInfo> tEmployeeInfo { get; set; }
        public virtual ICollection<tEmploymentStatus> tEmploymentStatus { get; set; }
        public virtual ICollection<tEmplyee> tEmplyee { get; set; }
        public virtual ICollection<tExpenseCategory> tExpenseCategory { get; set; }
        public virtual ICollection<tFilingStatus> tFilingStatus { get; set; }
        public virtual ICollection<tForBilling> tForBilling { get; set; }
        public virtual ICollection<tHelpDeskVideoTutorial> tHelpDeskVideoTutorial { get; set; }
        public virtual ICollection<tITextMoAPISMSStatus> tITextMoAPISMSStatus { get; set; }
        public virtual ICollection<tInventoryStatus> tInventoryStatus { get; set; }
        public virtual ICollection<tInventorySummary> tInventorySummary { get; set; }
        public virtual ICollection<tInventoryTrail> tInventoryTrail { get; set; }
        public virtual ICollection<tIssueTracker> tIssueTracker { get; set; }
        public virtual ICollection<tItem> tItem { get; set; }
        public virtual ICollection<tItemCategory> tItemCategory { get; set; }
        public virtual ICollection<tItemInventoriable> tItemInventoriable { get; set; }
        public virtual ICollection<tItemService> tItemService { get; set; }
        public virtual ICollection<tItemType> tItemType { get; set; }
        public virtual ICollection<tItem_UnitCostLog> tItem_UnitCostLog { get; set; }
        public virtual ICollection<tItem_UnitPriceLog> tItem_UnitPriceLog { get; set; }
        public virtual ICollection<tLocalShippingPermitIssuance> tLocalShippingPermitIssuance { get; set; }
        public virtual ICollection<tLocalShippingPermitIssuance_Item> tLocalShippingPermitIssuance_Item { get; set; }
        public virtual ICollection<tLocalShippingPermitIssuance_Requirement> tLocalShippingPermitIssuance_Requirement { get; set; }
        public virtual ICollection<tMedicalHistoryQuestionnaire> tMedicalHistoryQuestionnaire { get; set; }
        public virtual ICollection<tMedicationRoute> tMedicationRoute { get; set; }
        public virtual ICollection<tMessage> tMessage { get; set; }
        public virtual ICollection<tPatientAppointment> tPatientAppointment { get; set; }
        public virtual ICollection<tPatientSOAPList> tPatientSOAPList { get; set; }
        public virtual ICollection<tPatientWaitingList> tPatientWaitingList { get; set; }
        public virtual ICollection<tPatientWaitingList_Logs> tPatientWaitingList_Logs { get; set; }
        public virtual ICollection<tPatient_BirthDateSMSGreetingLog> tPatient_BirthDateSMSGreetingLog { get; set; }
        public virtual ICollection<tPatient_Confinement> tPatient_Confinement { get; set; }
        public virtual ICollection<tPatient_Confinement_ItemsServices> tPatient_Confinement_ItemsServices { get; set; }
        public virtual ICollection<tPatient_Confinement_Patient> tPatient_Confinement_Patient { get; set; }
        public virtual ICollection<tPatient_CreditLogs> tPatient_CreditLogs { get; set; }
        public virtual ICollection<tPatient_DentalExamination_Image> tPatient_DentalExamination_Image { get; set; }
        public virtual ICollection<tPatient_DentalExamination_MedicalHistory> tPatient_DentalExamination_MedicalHistory { get; set; }
        public virtual ICollection<tPatient_DentalExamination_ToothInfo> tPatient_DentalExamination_ToothInfo { get; set; }
        public virtual ICollection<tPatient_Lodging> tPatient_Lodging { get; set; }
        public virtual ICollection<tPatient_SOAP> tPatient_SOAP { get; set; }
        public virtual ICollection<tPatient_SOAP_Prescription> tPatient_SOAP_Prescription { get; set; }
        public virtual ICollection<tPatient_SOAP_SMSStatus> tPatient_SOAP_SMSStatus { get; set; }
        public virtual ICollection<tPatient_SOAP_Treatment> tPatient_SOAP_Treatment { get; set; }
        public virtual ICollection<tPatient_Vaccination> tPatient_Vaccination { get; set; }
        public virtual ICollection<tPatient_Vaccination_Schedule> tPatient_Vaccination_Schedule { get; set; }
        public virtual ICollection<tPatient_Vaccination_Schedule_SMSStatus> tPatient_Vaccination_Schedule_SMSStatus { get; set; }
        public virtual ICollection<tPatient_Wellness> tPatient_Wellness { get; set; }
        public virtual ICollection<tPatient_Wellness_Detail> tPatient_Wellness_Detail { get; set; }
        public virtual ICollection<tPatient_Wellness_Schedule> tPatient_Wellness_Schedule { get; set; }
        public virtual ICollection<tPatient_Wellness_Schedule_SMSStatus> tPatient_Wellness_Schedule_SMSStatus { get; set; }
        public virtual ICollection<tPayable> tPayable { get; set; }
        public virtual ICollection<tPayablePayment> tPayablePayment { get; set; }
        public virtual ICollection<tPayable_Detail> tPayable_Detail { get; set; }
        public virtual ICollection<tPaymentMethod> tPaymentMethod { get; set; }
        public virtual ICollection<tPaymentTransaction> tPaymentTransaction { get; set; }
        public virtual ICollection<tPurchaseOrder> tPurchaseOrder { get; set; }
        public virtual ICollection<tQuestionType> tQuestionType { get; set; }
        public virtual ICollection<tReceivingReport> tReceivingReport { get; set; }
        public virtual ICollection<tReceivingReport_Detail> tReceivingReport_Detail { get; set; }
        public virtual ICollection<tRecurScheduleType> tRecurScheduleType { get; set; }
        public virtual ICollection<tSMSPatientSOAP_Company> tSMSPatientSOAP_Company { get; set; }
        public virtual ICollection<tSOAPType> tSOAPType { get; set; }
        public virtual ICollection<tSalesReturn> tSalesReturn { get; set; }
        public virtual ICollection<tSalesReturn_Detail> tSalesReturn_Detail { get; set; }
        public virtual ICollection<tSchedule> tSchedule { get; set; }
        public virtual ICollection<tServiceType> tServiceType { get; set; }
        public virtual ICollection<tStudent> tStudent { get; set; }
        public virtual ICollection<tSupplier> tSupplier { get; set; }
        public virtual ICollection<tTaxScheme> tTaxScheme { get; set; }
        public virtual ICollection<tTeacher> tTeacher { get; set; }
        public virtual ICollection<tTeethQuandrant> tTeethQuandrant { get; set; }
        public virtual ICollection<tTextBlast> tTextBlast { get; set; }
        public virtual ICollection<tTextBlast_Client> tTextBlast_Client { get; set; }
        public virtual ICollection<tTextBlast_Client_SMSStatus> tTextBlast_Client_SMSStatus { get; set; }
        public virtual ICollection<tToothInfo> tToothInfo { get; set; }
        public virtual ICollection<tToothStatus> tToothStatus { get; set; }
        public virtual ICollection<tToothStatusType> tToothStatusType { get; set; }
        public virtual ICollection<tToothSurface> tToothSurface { get; set; }
        public virtual ICollection<tUnitOfMeasure> tUnitOfMeasure { get; set; }
        public virtual ICollection<tVeterinaryCertificate> tVeterinaryCertificate { get; set; }
        public virtual ICollection<tVeterinaryHealthCertificate> tVeterinaryHealthCertificate { get; set; }
        public virtual ICollection<tViewType> tViewType { get; set; }
    }
}
