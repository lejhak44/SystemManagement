using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ngJSApp.Database.Models;

namespace ngJSApp.Database
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BeastfriendForImport> BeastfriendForImport { get; set; }
        public virtual DbSet<BillingInvoiceWalkInList> BillingInvoiceWalkInList { get; set; }
        public virtual DbSet<PetMedItem> PetMedItem { get; set; }
        public virtual DbSet<PetMedServices> PetMedServices { get; set; }
        public virtual DbSet<Petaholic_NewClient> Petaholic_NewClient { get; set; }
        public virtual DbSet<VetStreetServices> VetStreetServices { get; set; }
        public virtual DbSet<Vetline_Client_Import> Vetline_Client_Import { get; set; }
        public virtual DbSet<Vetline_Item> Vetline_Item { get; set; }
        public virtual DbSet<_TempTableForColumns> _TempTableForColumns { get; set; }
        public virtual DbSet<__vNavigation> __vNavigation { get; set; }
        public virtual DbSet<_tColumnAlignment> _tColumnAlignment { get; set; }
        public virtual DbSet<_tControlType> _tControlType { get; set; }
        public virtual DbSet<_tDatabaseMemoryLog> _tDatabaseMemoryLog { get; set; }
        public virtual DbSet<_tDetailView> _tDetailView { get; set; }
        public virtual DbSet<_tDetailView_Detail> _tDetailView_Detail { get; set; }
        public virtual DbSet<_tDetailView_Detail_Link> _tDetailView_Detail_Link { get; set; }
        public virtual DbSet<_tLabelLocation> _tLabelLocation { get; set; }
        public virtual DbSet<_tListView> _tListView { get; set; }
        public virtual DbSet<_tListView_Detail> _tListView_Detail { get; set; }
        public virtual DbSet<_tModel> _tModel { get; set; }
        public virtual DbSet<_tModelReport> _tModelReport { get; set; }
        public virtual DbSet<_tModel_Property> _tModel_Property { get; set; }
        public virtual DbSet<_tNavigation> _tNavigation { get; set; }
        public virtual DbSet<_tPropertyType> _tPropertyType { get; set; }
        public virtual DbSet<_tReport> _tReport { get; set; }
        public virtual DbSet<_tReport_Filters> _tReport_Filters { get; set; }
        public virtual DbSet<_tSummaryType> _tSummaryType { get; set; }
        public virtual DbSet<_tView> _tView { get; set; }
        public virtual DbSet<_tViewType> _tViewType { get; set; }
        public virtual DbSet<_vDetailView> _vDetailView { get; set; }
        public virtual DbSet<_vDetailView_Detail> _vDetailView_Detail { get; set; }
        public virtual DbSet<_vGenerateTSClass> _vGenerateTSClass { get; set; }
        public virtual DbSet<_vLastestMessageRecipient> _vLastestMessageRecipient { get; set; }
        public virtual DbSet<_vListView> _vListView { get; set; }
        public virtual DbSet<_vListViewLookUp> _vListViewLookUp { get; set; }
        public virtual DbSet<_vListView_Detail> _vListView_Detail { get; set; }
        public virtual DbSet<_vModel> _vModel { get; set; }
        public virtual DbSet<_vModelGetProcedures> _vModelGetProcedures { get; set; }
        public virtual DbSet<_vModelPropertiesCrud> _vModelPropertiesCrud { get; set; }
        public virtual DbSet<_vModelProperyDetail> _vModelProperyDetail { get; set; }
        public virtual DbSet<_vModelViews> _vModelViews { get; set; }
        public virtual DbSet<_vModel_Property> _vModel_Property { get; set; }
        public virtual DbSet<_vModuleViews> _vModuleViews { get; set; }
        public virtual DbSet<_vNavigation> _vNavigation { get; set; }
        public virtual DbSet<_vNavigationLookUp> _vNavigationLookUp { get; set; }
        public virtual DbSet<_vReportLookUp> _vReportLookUp { get; set; }
        public virtual DbSet<_vSetting> _vSetting { get; set; }
        public virtual DbSet<_vUserDefinedTypes> _vUserDefinedTypes { get; set; }
        public virtual DbSet<_vView> _vView { get; set; }
        public virtual DbSet<_vViewLookUp> _vViewLookUp { get; set; }
        public virtual DbSet<animallifeclinic_patientrecord> animallifeclinic_patientrecord { get; set; }
        public virtual DbSet<evgjuicopetcarecenter_appointment_2021_11_03> evgjuicopetcarecenter_appointment_2021_11_03 { get; set; }
        public virtual DbSet<tAppSetting> tAppSetting { get; set; }
        public virtual DbSet<tAppointment> tAppointment { get; set; }
        public virtual DbSet<tAppointmentRequest> tAppointmentRequest { get; set; }
        public virtual DbSet<tAppointmentSchedule> tAppointmentSchedule { get; set; }
        public virtual DbSet<tAppointmentStatusLog> tAppointmentStatusLog { get; set; }
        public virtual DbSet<tApproverMatrix> tApproverMatrix { get; set; }
        public virtual DbSet<tApproverMatrix_Detail> tApproverMatrix_Detail { get; set; }
        public virtual DbSet<tAuditTrail> tAuditTrail { get; set; }
        public virtual DbSet<tAuditTrailType> tAuditTrailType { get; set; }
        public virtual DbSet<tAuditTrail_Detail> tAuditTrail_Detail { get; set; }
        public virtual DbSet<tBillingInvoice> tBillingInvoice { get; set; }
        public virtual DbSet<tBillingInvoiceWalkIn> tBillingInvoiceWalkIn { get; set; }
        public virtual DbSet<tBillingInvoiceWalkInList> tBillingInvoiceWalkInList { get; set; }
        public virtual DbSet<tBillingInvoice_Detail> tBillingInvoice_Detail { get; set; }
        public virtual DbSet<tBillingInvoice_Patient> tBillingInvoice_Patient { get; set; }
        public virtual DbSet<tBreedSpecie> tBreedSpecie { get; set; }
        public virtual DbSet<tBusinessPartner> tBusinessPartner { get; set; }
        public virtual DbSet<tBusinessPartnerType> tBusinessPartnerType { get; set; }
        public virtual DbSet<tBusinessPartner_Contact> tBusinessPartner_Contact { get; set; }
        public virtual DbSet<tCardType> tCardType { get; set; }
        public virtual DbSet<tCaseType> tCaseType { get; set; }
        public virtual DbSet<tClient> tClient { get; set; }
        public virtual DbSet<tClientDeposit> tClientDeposit { get; set; }
        public virtual DbSet<tClientWithdraw_> tClientWithdraw_ { get; set; }
        public virtual DbSet<tClient_CreditLogs> tClient_CreditLogs { get; set; }
        public virtual DbSet<tCompany> tCompany { get; set; }
        public virtual DbSet<tCompanyInfo> tCompanyInfo { get; set; }
        public virtual DbSet<tCompanyTextBlastTemplate> tCompanyTextBlastTemplate { get; set; }
        public virtual DbSet<tCompany_SMSSetting> tCompany_SMSSetting { get; set; }
        public virtual DbSet<tCompany_Subscription> tCompany_Subscription { get; set; }
        public virtual DbSet<tCountry> tCountry { get; set; }
        public virtual DbSet<tCustomDetailViewRoute> tCustomDetailViewRoute { get; set; }
        public virtual DbSet<tCustomNavigationLink> tCustomNavigationLink { get; set; }
        public virtual DbSet<tDentalExamination> tDentalExamination { get; set; }
        public virtual DbSet<tDentition> tDentition { get; set; }
        public virtual DbSet<tDoc> tDoc { get; set; }
        public virtual DbSet<tDoc_Detail> tDoc_Detail { get; set; }
        public virtual DbSet<tDocumentSeries> tDocumentSeries { get; set; }
        public virtual DbSet<tDocumentStatus> tDocumentStatus { get; set; }
        public virtual DbSet<tEmployee> tEmployee { get; set; }
        public virtual DbSet<tEmployeeInfo> tEmployeeInfo { get; set; }
        public virtual DbSet<tEmployeePosition> tEmployeePosition { get; set; }
        public virtual DbSet<tEmployeeStatus> tEmployeeStatus { get; set; }
        public virtual DbSet<tEmploymentStatus> tEmploymentStatus { get; set; }
        public virtual DbSet<tEmplyee> tEmplyee { get; set; }
        public virtual DbSet<tExpenseCategory> tExpenseCategory { get; set; }
        public virtual DbSet<tFileUpload> tFileUpload { get; set; }
        public virtual DbSet<tFilingStatus> tFilingStatus { get; set; }
        public virtual DbSet<tForBilling> tForBilling { get; set; }
        public virtual DbSet<tGender> tGender { get; set; }
        public virtual DbSet<tHelpDeskVideoTutorial> tHelpDeskVideoTutorial { get; set; }
        public virtual DbSet<tITextMoAPISMSStatus> tITextMoAPISMSStatus { get; set; }
        public virtual DbSet<tInventoryStatus> tInventoryStatus { get; set; }
        public virtual DbSet<tInventorySummary> tInventorySummary { get; set; }
        public virtual DbSet<tInventoryTrail> tInventoryTrail { get; set; }
        public virtual DbSet<tIssueTracker> tIssueTracker { get; set; }
        public virtual DbSet<tItem> tItem { get; set; }
        public virtual DbSet<tItemCategory> tItemCategory { get; set; }
        public virtual DbSet<tItemInventoriable> tItemInventoriable { get; set; }
        public virtual DbSet<tItemService> tItemService { get; set; }
        public virtual DbSet<tItemType> tItemType { get; set; }
        public virtual DbSet<tItem_Supplier> tItem_Supplier { get; set; }
        public virtual DbSet<tItem_UnitCostLog> tItem_UnitCostLog { get; set; }
        public virtual DbSet<tItem_UnitPriceLog> tItem_UnitPriceLog { get; set; }
        public virtual DbSet<tLocalShippingPermitIssuance> tLocalShippingPermitIssuance { get; set; }
        public virtual DbSet<tLocalShippingPermitIssuance_Item> tLocalShippingPermitIssuance_Item { get; set; }
        public virtual DbSet<tLocalShippingPermitIssuance_Requirement> tLocalShippingPermitIssuance_Requirement { get; set; }
        public virtual DbSet<tMedicalHistoryQuestionnaire> tMedicalHistoryQuestionnaire { get; set; }
        public virtual DbSet<tMedicationRoute> tMedicationRoute { get; set; }
        public virtual DbSet<tMessage> tMessage { get; set; }
        public virtual DbSet<tMessageConversation> tMessageConversation { get; set; }
        public virtual DbSet<tMessageRoom> tMessageRoom { get; set; }
        public virtual DbSet<tMessageRoom_User> tMessageRoom_User { get; set; }
        public virtual DbSet<tMessageRoom_User_Message> tMessageRoom_User_Message { get; set; }
        public virtual DbSet<tMessageThread> tMessageThread { get; set; }
        public virtual DbSet<tPatient> tPatient { get; set; }
        public virtual DbSet<tPatientAppointment> tPatientAppointment { get; set; }
        public virtual DbSet<tPatientSOAPList> tPatientSOAPList { get; set; }
        public virtual DbSet<tPatientWaitingList> tPatientWaitingList { get; set; }
        public virtual DbSet<tPatientWaitingList_Logs> tPatientWaitingList_Logs { get; set; }
        public virtual DbSet<tPatient_BirthDateSMSGreetingLog> tPatient_BirthDateSMSGreetingLog { get; set; }
        public virtual DbSet<tPatient_Confinement> tPatient_Confinement { get; set; }
        public virtual DbSet<tPatient_Confinement_ItemsServices> tPatient_Confinement_ItemsServices { get; set; }
        public virtual DbSet<tPatient_Confinement_Patient> tPatient_Confinement_Patient { get; set; }
        public virtual DbSet<tPatient_CreditLogs> tPatient_CreditLogs { get; set; }
        public virtual DbSet<tPatient_DentalExamination> tPatient_DentalExamination { get; set; }
        public virtual DbSet<tPatient_DentalExamination_Image> tPatient_DentalExamination_Image { get; set; }
        public virtual DbSet<tPatient_DentalExamination_MedicalHistory> tPatient_DentalExamination_MedicalHistory { get; set; }
        public virtual DbSet<tPatient_DentalExamination_ToothInfo> tPatient_DentalExamination_ToothInfo { get; set; }
        public virtual DbSet<tPatient_History> tPatient_History { get; set; }
        public virtual DbSet<tPatient_Lodging> tPatient_Lodging { get; set; }
        public virtual DbSet<tPatient_SOAP> tPatient_SOAP { get; set; }
        public virtual DbSet<tPatient_SOAP_Plan> tPatient_SOAP_Plan { get; set; }
        public virtual DbSet<tPatient_SOAP_Prescription> tPatient_SOAP_Prescription { get; set; }
        public virtual DbSet<tPatient_SOAP_RegularConsoltation> tPatient_SOAP_RegularConsoltation { get; set; }
        public virtual DbSet<tPatient_SOAP_SMSStatus> tPatient_SOAP_SMSStatus { get; set; }
        public virtual DbSet<tPatient_SOAP_Treatment> tPatient_SOAP_Treatment { get; set; }
        public virtual DbSet<tPatient_Vaccination> tPatient_Vaccination { get; set; }
        public virtual DbSet<tPatient_Vaccination_Schedule> tPatient_Vaccination_Schedule { get; set; }
        public virtual DbSet<tPatient_Vaccination_Schedule_SMSStatus> tPatient_Vaccination_Schedule_SMSStatus { get; set; }
        public virtual DbSet<tPatient_Wellness> tPatient_Wellness { get; set; }
        public virtual DbSet<tPatient_Wellness_Detail> tPatient_Wellness_Detail { get; set; }
        public virtual DbSet<tPatient_Wellness_Schedule> tPatient_Wellness_Schedule { get; set; }
        public virtual DbSet<tPatient_Wellness_Schedule_SMSStatus> tPatient_Wellness_Schedule_SMSStatus { get; set; }
        public virtual DbSet<tPayable> tPayable { get; set; }
        public virtual DbSet<tPayablePayment> tPayablePayment { get; set; }
        public virtual DbSet<tPayable_Detail> tPayable_Detail { get; set; }
        public virtual DbSet<tPaymentMethod> tPaymentMethod { get; set; }
        public virtual DbSet<tPaymentTransaction> tPaymentTransaction { get; set; }
        public virtual DbSet<tPosition> tPosition { get; set; }
        public virtual DbSet<tPurchaseOrder> tPurchaseOrder { get; set; }
        public virtual DbSet<tPurchaseOrder_Detail> tPurchaseOrder_Detail { get; set; }
        public virtual DbSet<tQuestionType> tQuestionType { get; set; }
        public virtual DbSet<tReceivingReport> tReceivingReport { get; set; }
        public virtual DbSet<tReceivingReport_Detail> tReceivingReport_Detail { get; set; }
        public virtual DbSet<tRecurScheduleType> tRecurScheduleType { get; set; }
        public virtual DbSet<tSMSPatientSOAP_Company> tSMSPatientSOAP_Company { get; set; }
        public virtual DbSet<tSOAPType> tSOAPType { get; set; }
        public virtual DbSet<tSalesReturn> tSalesReturn { get; set; }
        public virtual DbSet<tSalesReturn_Detail> tSalesReturn_Detail { get; set; }
        public virtual DbSet<tSample> tSample { get; set; }
        public virtual DbSet<tSample1> tSample1 { get; set; }
        public virtual DbSet<tSchedule> tSchedule { get; set; }
        public virtual DbSet<tScheduleType> tScheduleType { get; set; }
        public virtual DbSet<tSchedule_PatientAppointment> tSchedule_PatientAppointment { get; set; }
        public virtual DbSet<tServiceType> tServiceType { get; set; }
        public virtual DbSet<tSetting> tSetting { get; set; }
        public virtual DbSet<tStudent> tStudent { get; set; }
        public virtual DbSet<tSupplier> tSupplier { get; set; }
        public virtual DbSet<tTaxScheme> tTaxScheme { get; set; }
        public virtual DbSet<tTeacher> tTeacher { get; set; }
        public virtual DbSet<tTeethQuandrant> tTeethQuandrant { get; set; }
        public virtual DbSet<tTextBlast> tTextBlast { get; set; }
        public virtual DbSet<tTextBlast_Client> tTextBlast_Client { get; set; }
        public virtual DbSet<tTextBlast_Client_SMSStatus> tTextBlast_Client_SMSStatus { get; set; }
        public virtual DbSet<tTooth> tTooth { get; set; }
        public virtual DbSet<tToothInfo> tToothInfo { get; set; }
        public virtual DbSet<tToothStatus> tToothStatus { get; set; }
        public virtual DbSet<tToothStatusType> tToothStatusType { get; set; }
        public virtual DbSet<tToothSurface> tToothSurface { get; set; }
        public virtual DbSet<tUnitOfMeasure> tUnitOfMeasure { get; set; }
        public virtual DbSet<tUser> tUser { get; set; }
        public virtual DbSet<tUserComment> tUserComment { get; set; }
        public virtual DbSet<tUserGroup> tUserGroup { get; set; }
        public virtual DbSet<tUserRole> tUserRole { get; set; }
        public virtual DbSet<tUserRole_Detail> tUserRole_Detail { get; set; }
        public virtual DbSet<tUserRole_Reports> tUserRole_Reports { get; set; }
        public virtual DbSet<tUserSession> tUserSession { get; set; }
        public virtual DbSet<tUser_Favorite> tUser_Favorite { get; set; }
        public virtual DbSet<tUser_Roles> tUser_Roles { get; set; }
        public virtual DbSet<tVeterinaryCertificate> tVeterinaryCertificate { get; set; }
        public virtual DbSet<tVeterinaryHealthCertificate> tVeterinaryHealthCertificate { get; set; }
        public virtual DbSet<tViewType> tViewType { get; set; }
        public virtual DbSet<tWarehouse> tWarehouse { get; set; }
        public virtual DbSet<vActiveItem> vActiveItem { get; set; }
        public virtual DbSet<vAppSetting> vAppSetting { get; set; }
        public virtual DbSet<vAppointment> vAppointment { get; set; }
        public virtual DbSet<vAppointmentEvent> vAppointmentEvent { get; set; }
        public virtual DbSet<vAppointmentRequest> vAppointmentRequest { get; set; }
        public virtual DbSet<vAppointmentSchedule> vAppointmentSchedule { get; set; }
        public virtual DbSet<vAppointmentStatusLog> vAppointmentStatusLog { get; set; }
        public virtual DbSet<vAppointment_FilingStatus> vAppointment_FilingStatus { get; set; }
        public virtual DbSet<vApproverMatrix> vApproverMatrix { get; set; }
        public virtual DbSet<vApproverMatrix_Detail> vApproverMatrix_Detail { get; set; }
        public virtual DbSet<vAttendingVeterinarian> vAttendingVeterinarian { get; set; }
        public virtual DbSet<vAttendingVeterinarianForBillingINvoice> vAttendingVeterinarianForBillingINvoice { get; set; }
        public virtual DbSet<vAuditTrail> vAuditTrail { get; set; }
        public virtual DbSet<vAvailableModules> vAvailableModules { get; set; }
        public virtual DbSet<vBillingInvoice> vBillingInvoice { get; set; }
        public virtual DbSet<vBillingInvoiceWalkIn> vBillingInvoiceWalkIn { get; set; }
        public virtual DbSet<vBillingInvoiceWalkInList> vBillingInvoiceWalkInList { get; set; }
        public virtual DbSet<vBillingInvoice_Detail> vBillingInvoice_Detail { get; set; }
        public virtual DbSet<vBillingInvoice_Patient> vBillingInvoice_Patient { get; set; }
        public virtual DbSet<vBreedSpecie> vBreedSpecie { get; set; }
        public virtual DbSet<vCardType> vCardType { get; set; }
        public virtual DbSet<vCaseType> vCaseType { get; set; }
        public virtual DbSet<vClient> vClient { get; set; }
        public virtual DbSet<vClientDeposit> vClientDeposit { get; set; }
        public virtual DbSet<vClientWithdraw> vClientWithdraw { get; set; }
        public virtual DbSet<vClient_CreditLogs> vClient_CreditLogs { get; set; }
        public virtual DbSet<vClient_ListView> vClient_ListView { get; set; }
        public virtual DbSet<vCompany> vCompany { get; set; }
        public virtual DbSet<vCompanyInfo> vCompanyInfo { get; set; }
        public virtual DbSet<vCompanyTextBlastTemplate> vCompanyTextBlastTemplate { get; set; }
        public virtual DbSet<vCompany_Subscription> vCompany_Subscription { get; set; }
        public virtual DbSet<vCountry> vCountry { get; set; }
        public virtual DbSet<vCustomDetailViewRoute> vCustomDetailViewRoute { get; set; }
        public virtual DbSet<vCustomNavigationLink> vCustomNavigationLink { get; set; }
        public virtual DbSet<vDatabaseMemoryLog> vDatabaseMemoryLog { get; set; }
        public virtual DbSet<vDentalExamination> vDentalExamination { get; set; }
        public virtual DbSet<vDentition> vDentition { get; set; }
        public virtual DbSet<vDetailView_Detail> vDetailView_Detail { get; set; }
        public virtual DbSet<vDetailView_Detail_Link> vDetailView_Detail_Link { get; set; }
        public virtual DbSet<vDocumentSeries> vDocumentSeries { get; set; }
        public virtual DbSet<vDocumentStatus> vDocumentStatus { get; set; }
        public virtual DbSet<vEmployee> vEmployee { get; set; }
        public virtual DbSet<vEmployeeInfo> vEmployeeInfo { get; set; }
        public virtual DbSet<vEmployeePosition> vEmployeePosition { get; set; }
        public virtual DbSet<vEmployee_ListView> vEmployee_ListView { get; set; }
        public virtual DbSet<vEmploymentStatus> vEmploymentStatus { get; set; }
        public virtual DbSet<vExpenseCategory> vExpenseCategory { get; set; }
        public virtual DbSet<vFileUpload> vFileUpload { get; set; }
        public virtual DbSet<vFilingStatus> vFilingStatus { get; set; }
        public virtual DbSet<vForBilling> vForBilling { get; set; }
        public virtual DbSet<vForBilling_ListView> vForBilling_ListView { get; set; }
        public virtual DbSet<vHelpDeskVideoTutorial> vHelpDeskVideoTutorial { get; set; }
        public virtual DbSet<vITextMoAPISMSStatus> vITextMoAPISMSStatus { get; set; }
        public virtual DbSet<vInventory> vInventory { get; set; }
        public virtual DbSet<vInventoryStatus> vInventoryStatus { get; set; }
        public virtual DbSet<vInventorySummary> vInventorySummary { get; set; }
        public virtual DbSet<vInventoryTrail> vInventoryTrail { get; set; }
        public virtual DbSet<vIssueTracker> vIssueTracker { get; set; }
        public virtual DbSet<vItem> vItem { get; set; }
        public virtual DbSet<vItemCategory> vItemCategory { get; set; }
        public virtual DbSet<vItemInventoriable> vItemInventoriable { get; set; }
        public virtual DbSet<vItemInventoriableForBillingLookUp> vItemInventoriableForBillingLookUp { get; set; }
        public virtual DbSet<vItemInventoriableLookUp> vItemInventoriableLookUp { get; set; }
        public virtual DbSet<vItemInventoriable_ListvIew> vItemInventoriable_ListvIew { get; set; }
        public virtual DbSet<vItemService> vItemService { get; set; }
        public virtual DbSet<vItemServiceLookUp> vItemServiceLookUp { get; set; }
        public virtual DbSet<vItemService_Listview> vItemService_Listview { get; set; }
        public virtual DbSet<vItemType> vItemType { get; set; }
        public virtual DbSet<vItem_UnitCostLog> vItem_UnitCostLog { get; set; }
        public virtual DbSet<vItem_UnitPriceLog> vItem_UnitPriceLog { get; set; }
        public virtual DbSet<vLastestMessageRecipient> vLastestMessageRecipient { get; set; }
        public virtual DbSet<vLastestPatientWaitingList> vLastestPatientWaitingList { get; set; }
        public virtual DbSet<vListView> vListView { get; set; }
        public virtual DbSet<vLocalShippingPermitIssuance> vLocalShippingPermitIssuance { get; set; }
        public virtual DbSet<vLocalShippingPermitIssuance_Item> vLocalShippingPermitIssuance_Item { get; set; }
        public virtual DbSet<vLocalShippingPermitIssuance_Requirement> vLocalShippingPermitIssuance_Requirement { get; set; }
        public virtual DbSet<vMedicalHistoryQuestionnaire> vMedicalHistoryQuestionnaire { get; set; }
        public virtual DbSet<vMedicationRoute> vMedicationRoute { get; set; }
        public virtual DbSet<vMessage> vMessage { get; set; }
        public virtual DbSet<vMessageThread> vMessageThread { get; set; }
        public virtual DbSet<vModelReport> vModelReport { get; set; }
        public virtual DbSet<vModel_Property> vModel_Property { get; set; }
        public virtual DbSet<vNavigation> vNavigation { get; set; }
        public virtual DbSet<vNonSystemUseEmployee> vNonSystemUseEmployee { get; set; }
        public virtual DbSet<vOverallLatestMessageRecipient> vOverallLatestMessageRecipient { get; set; }
        public virtual DbSet<vPatient> vPatient { get; set; }
        public virtual DbSet<vPatientAppointment> vPatientAppointment { get; set; }
        public virtual DbSet<vPatientSOAPList> vPatientSOAPList { get; set; }
        public virtual DbSet<vPatientWaitingList> vPatientWaitingList { get; set; }
        public virtual DbSet<vPatientWaitingList_ListView> vPatientWaitingList_ListView { get; set; }
        public virtual DbSet<vPatientWaitingList_Logs> vPatientWaitingList_Logs { get; set; }
        public virtual DbSet<vPatient_BirthDateSMSGreetingLog> vPatient_BirthDateSMSGreetingLog { get; set; }
        public virtual DbSet<vPatient_Confinement> vPatient_Confinement { get; set; }
        public virtual DbSet<vPatient_Confinement_ItemsServices> vPatient_Confinement_ItemsServices { get; set; }
        public virtual DbSet<vPatient_Confinement_Listview> vPatient_Confinement_Listview { get; set; }
        public virtual DbSet<vPatient_Confinement_MaxSOAP> vPatient_Confinement_MaxSOAP { get; set; }
        public virtual DbSet<vPatient_Confinement_Patient> vPatient_Confinement_Patient { get; set; }
        public virtual DbSet<vPatient_CreditLogs> vPatient_CreditLogs { get; set; }
        public virtual DbSet<vPatient_DentalExamination> vPatient_DentalExamination { get; set; }
        public virtual DbSet<vPatient_DentalExamination_Image> vPatient_DentalExamination_Image { get; set; }
        public virtual DbSet<vPatient_DentalExamination_MedicalHistory> vPatient_DentalExamination_MedicalHistory { get; set; }
        public virtual DbSet<vPatient_DentalExamination_ToothInfo> vPatient_DentalExamination_ToothInfo { get; set; }
        public virtual DbSet<vPatient_History> vPatient_History { get; set; }
        public virtual DbSet<vPatient_ListView> vPatient_ListView { get; set; }
        public virtual DbSet<vPatient_Lodging> vPatient_Lodging { get; set; }
        public virtual DbSet<vPatient_Lodging_Listview> vPatient_Lodging_Listview { get; set; }
        public virtual DbSet<vPatient_SOAP> vPatient_SOAP { get; set; }
        public virtual DbSet<vPatient_SOAP_LaboratoryImages> vPatient_SOAP_LaboratoryImages { get; set; }
        public virtual DbSet<vPatient_SOAP_LaboratoryImages_Count> vPatient_SOAP_LaboratoryImages_Count { get; set; }
        public virtual DbSet<vPatient_SOAP_ListView> vPatient_SOAP_ListView { get; set; }
        public virtual DbSet<vPatient_SOAP_Plan> vPatient_SOAP_Plan { get; set; }
        public virtual DbSet<vPatient_SOAP_Plan_Count> vPatient_SOAP_Plan_Count { get; set; }
        public virtual DbSet<vPatient_SOAP_Prescription> vPatient_SOAP_Prescription { get; set; }
        public virtual DbSet<vPatient_SOAP_Prescription_Count> vPatient_SOAP_Prescription_Count { get; set; }
        public virtual DbSet<vPatient_SOAP_SMSStatus> vPatient_SOAP_SMSStatus { get; set; }
        public virtual DbSet<vPatient_SOAP_Treatment> vPatient_SOAP_Treatment { get; set; }
        public virtual DbSet<vPatient_Vaccination> vPatient_Vaccination { get; set; }
        public virtual DbSet<vPatient_Vaccination_Listview> vPatient_Vaccination_Listview { get; set; }
        public virtual DbSet<vPatient_Vaccination_Schedule> vPatient_Vaccination_Schedule { get; set; }
        public virtual DbSet<vPatient_Wellness> vPatient_Wellness { get; set; }
        public virtual DbSet<vPatient_Wellness_Detail> vPatient_Wellness_Detail { get; set; }
        public virtual DbSet<vPatient_Wellness_DetailSchedule> vPatient_Wellness_DetailSchedule { get; set; }
        public virtual DbSet<vPatient_Wellness_Detail_Listview> vPatient_Wellness_Detail_Listview { get; set; }
        public virtual DbSet<vPatient_Wellness_Listview> vPatient_Wellness_Listview { get; set; }
        public virtual DbSet<vPatient_Wellness_Schedule> vPatient_Wellness_Schedule { get; set; }
        public virtual DbSet<vPayable> vPayable { get; set; }
        public virtual DbSet<vPayablePayment> vPayablePayment { get; set; }
        public virtual DbSet<vPayable_Detail> vPayable_Detail { get; set; }
        public virtual DbSet<vPayable_PayableDetail_Listview> vPayable_PayableDetail_Listview { get; set; }
        public virtual DbSet<vPaymentMethod> vPaymentMethod { get; set; }
        public virtual DbSet<vPaymentTransaction> vPaymentTransaction { get; set; }
        public virtual DbSet<vPosition> vPosition { get; set; }
        public virtual DbSet<vPurchaseOrder> vPurchaseOrder { get; set; }
        public virtual DbSet<vPurchaseOrder_Detail> vPurchaseOrder_Detail { get; set; }
        public virtual DbSet<vPurchaseOrder_Listview> vPurchaseOrder_Listview { get; set; }
        public virtual DbSet<vQuestionType> vQuestionType { get; set; }
        public virtual DbSet<vReceivingReport> vReceivingReport { get; set; }
        public virtual DbSet<vReceivingReport_Detail> vReceivingReport_Detail { get; set; }
        public virtual DbSet<vRecurScheduleType> vRecurScheduleType { get; set; }
        public virtual DbSet<vRemainingQuantityPurchaseOrderDetail> vRemainingQuantityPurchaseOrderDetail { get; set; }
        public virtual DbSet<vRpt_ItemList> vRpt_ItemList { get; set; }
        public virtual DbSet<vSMSCountPerCompany> vSMSCountPerCompany { get; set; }
        public virtual DbSet<vSMSCountPerCompany_Patient_SOAP_Plan> vSMSCountPerCompany_Patient_SOAP_Plan { get; set; }
        public virtual DbSet<vSMSCountPerCompany_Patient_Vaccination_Schedule> vSMSCountPerCompany_Patient_Vaccination_Schedule { get; set; }
        public virtual DbSet<vSMSList> vSMSList { get; set; }
        public virtual DbSet<vSMSList_Patient_SOAP_Plan> vSMSList_Patient_SOAP_Plan { get; set; }
        public virtual DbSet<vSMSList_Patient_Vaccination_Schedule> vSMSList_Patient_Vaccination_Schedule { get; set; }
        public virtual DbSet<vSMSList_Patient_Wellness_DetailSchedule> vSMSList_Patient_Wellness_DetailSchedule { get; set; }
        public virtual DbSet<vSMSPatientSOAP_Company> vSMSPatientSOAP_Company { get; set; }
        public virtual DbSet<vSOAPType> vSOAPType { get; set; }
        public virtual DbSet<vSalesReturn> vSalesReturn { get; set; }
        public virtual DbSet<vSalesReturn_Detail> vSalesReturn_Detail { get; set; }
        public virtual DbSet<vSalesReturn_ListView> vSalesReturn_ListView { get; set; }
        public virtual DbSet<vSchedule> vSchedule { get; set; }
        public virtual DbSet<vSentSMSRecord> vSentSMSRecord { get; set; }
        public virtual DbSet<vServiceType> vServiceType { get; set; }
        public virtual DbSet<vStudent> vStudent { get; set; }
        public virtual DbSet<vSupplier> vSupplier { get; set; }
        public virtual DbSet<vTaxScheme> vTaxScheme { get; set; }
        public virtual DbSet<vTeacher> vTeacher { get; set; }
        public virtual DbSet<vTeethQuandrant> vTeethQuandrant { get; set; }
        public virtual DbSet<vTextBlast> vTextBlast { get; set; }
        public virtual DbSet<vTextBlast_Client> vTextBlast_Client { get; set; }
        public virtual DbSet<vTextBlast_Client_SMSStatus> vTextBlast_Client_SMSStatus { get; set; }
        public virtual DbSet<vTooth> vTooth { get; set; }
        public virtual DbSet<vToothInfo> vToothInfo { get; set; }
        public virtual DbSet<vToothStatus> vToothStatus { get; set; }
        public virtual DbSet<vToothStatusType> vToothStatusType { get; set; }
        public virtual DbSet<vToothSurface> vToothSurface { get; set; }
        public virtual DbSet<vUnitOfMeasure> vUnitOfMeasure { get; set; }
        public virtual DbSet<vUser> vUser { get; set; }
        public virtual DbSet<vUserComment> vUserComment { get; set; }
        public virtual DbSet<vUserGroup> vUserGroup { get; set; }
        public virtual DbSet<vUserRole> vUserRole { get; set; }
        public virtual DbSet<vVeterinaryCertificate> vVeterinaryCertificate { get; set; }
        public virtual DbSet<vVeterinaryCertificate_ListView> vVeterinaryCertificate_ListView { get; set; }
        public virtual DbSet<vVeterinaryHealthCertificate> vVeterinaryHealthCertificate { get; set; }
        public virtual DbSet<vVeterinaryHealthCertificate_ListView> vVeterinaryHealthCertificate_ListView { get; set; }
        public virtual DbSet<vViewType> vViewType { get; set; }
        public virtual DbSet<vetsaveers_clientpatient_practo> vetsaveers_clientpatient_practo { get; set; }
        public virtual DbSet<villingInvoiceWalkInList> villingInvoiceWalkInList { get; set; }
        public virtual DbSet<vpivotBilledPatientConfinement> vpivotBilledPatientConfinement { get; set; }
        public virtual DbSet<vpivotBilledPatientSOAP> vpivotBilledPatientSOAP { get; set; }
        public virtual DbSet<vsample> vsample { get; set; }
        public virtual DbSet<vzAcknowledgementReport> vzAcknowledgementReport { get; set; }
        public virtual DbSet<vzAdmissionReport> vzAdmissionReport { get; set; }
        public virtual DbSet<vzAgreementForConfinement> vzAgreementForConfinement { get; set; }
        public virtual DbSet<vzBillingInvoiceAgingReport> vzBillingInvoiceAgingReport { get; set; }
        public virtual DbSet<vzBillingInvoicePaidListReport> vzBillingInvoicePaidListReport { get; set; }
        public virtual DbSet<vzBillingInvoiceReport> vzBillingInvoiceReport { get; set; }
        public virtual DbSet<vzClientDepositReport> vzClientDepositReport { get; set; }
        public virtual DbSet<vzClinicaVeterinariaAgainstMedicalAdvice> vzClinicaVeterinariaAgainstMedicalAdvice { get; set; }
        public virtual DbSet<vzConcentToOperation> vzConcentToOperation { get; set; }
        public virtual DbSet<vzDentalExamination> vzDentalExamination { get; set; }
        public virtual DbSet<vzDentalExaminatonPrescriptionReport> vzDentalExaminatonPrescriptionReport { get; set; }
        public virtual DbSet<vzEuthanasiaAuthorization> vzEuthanasiaAuthorization { get; set; }
        public virtual DbSet<vzInventoryDetailReport> vzInventoryDetailReport { get; set; }
        public virtual DbSet<vzInventorySummaryReport> vzInventorySummaryReport { get; set; }
        public virtual DbSet<vzPOSSummary> vzPOSSummary { get; set; }
        public virtual DbSet<vzPatientBillingInvoiceReport> vzPatientBillingInvoiceReport { get; set; }
        public virtual DbSet<vzPatientSOAP> vzPatientSOAP { get; set; }
        public virtual DbSet<vzPaymentTransactionReport> vzPaymentTransactionReport { get; set; }
        public virtual DbSet<vzPaymentTransactionSummaryReport> vzPaymentTransactionSummaryReport { get; set; }
        public virtual DbSet<vzPurchaseOrderReport> vzPurchaseOrderReport { get; set; }
        public virtual DbSet<vzReceiveDepositCredit> vzReceiveDepositCredit { get; set; }
        public virtual DbSet<vzReceivingReportReport> vzReceivingReportReport { get; set; }
        public virtual DbSet<vzSalesIncomentReport> vzSalesIncomentReport { get; set; }
        public virtual DbSet<vzVeterinaryHealthClinicReport> vzVeterinaryHealthClinicReport { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-GI3KT54;Database=db_vetcloudv3_IOS-Update_dev;User Id=backup;Password=sql123;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BeastfriendForImport>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CATEGORY).HasMaxLength(255);

                entity.Property(e => e.DESCRIPTION).HasMaxLength(255);

                entity.Property(e => e.ITEM_CODE)
                    .HasColumnName("ITEM CODE")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<BillingInvoiceWalkInList>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_BillingInvoiceWalkInList");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.BillingInvoiceWalkInList)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_BillingInvoiceWalkInList_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.BillingInvoiceWalkInListID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_BillingInvoiceWalkInList_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.BillingInvoiceWalkInListID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_BillingInvoiceWalkInList_ID_LastModifiedBy");
            });

            modelBuilder.Entity<PetMedItem>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.PRODUCTS).HasMaxLength(255);
            });

            modelBuilder.Entity<PetMedServices>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.F4).HasMaxLength(255);

                entity.Property(e => e.SERVICES_)
                    .HasColumnName("SERVICES ")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Petaholic_NewClient>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.F5).HasMaxLength(255);

                entity.Property(e => e.FirstName).HasMaxLength(255);

                entity.Property(e => e.LastName).HasMaxLength(255);

                entity.Property(e => e.PET).HasMaxLength(255);
            });

            modelBuilder.Entity<VetStreetServices>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DESCRIPTION).HasMaxLength(255);

                entity.Property(e => e.PRODUCT_NAME)
                    .HasColumnName("PRODUCT NAME")
                    .HasMaxLength(255);

                entity.Property(e => e.SUB_CATEGORY)
                    .HasColumnName("SUB-CATEGORY")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Vetline_Client_Import>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ARV_SCHEDULE)
                    .HasColumnName("ARV SCHEDULE")
                    .HasMaxLength(255);

                entity.Property(e => e.ContactNumber).HasMaxLength(255);

                entity.Property(e => e.ContactNumber2).HasMaxLength(255);

                entity.Property(e => e.DW_SCHEDULE__PRO_HEART)
                    .HasColumnName("DW SCHEDULE/ PRO HEART")
                    .HasMaxLength(255);

                entity.Property(e => e.KC_SCHEDULE)
                    .HasColumnName("KC SCHEDULE")
                    .HasMaxLength(255);

                entity.Property(e => e.NAME).HasMaxLength(255);

                entity.Property(e => e.NEXGARD).HasMaxLength(255);

                entity.Property(e => e.PET).HasMaxLength(255);

                entity.Property(e => e.Wellness).HasMaxLength(255);

                entity.Property(e => e._5in1_3CAT_SCHEDULE)
                    .HasColumnName("5in1/3CAT SCHEDULE")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Vetline_Item>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<_TempTableForColumns>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ApprovedBy_Name_User)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.CanceledBy_Name_User)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.Company)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy_Name_User)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.DateApprovedString)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateCanceled).HasColumnType("datetime");

                entity.Property(e => e.DateCanceledString)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateCreatedString)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateModifiedString)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateString)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.GrossAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.LastModifiedBy_Name_User)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_FilingStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Patient)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_TaxScheme)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NetAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Payment_Name_FilingStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RemainingAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.VatAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.VatPercentage).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<__vNavigation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("__vNavigation");

                entity.Property(e => e.Model)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Route)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Text)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.View)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.icon)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<_tColumnAlignment>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<_tControlType>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<_tDatabaseMemoryLog>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX__tDatabaseMemoryLog");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p._tDatabaseMemoryLog)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK__tDatabaseMemoryLog_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p._tDatabaseMemoryLogID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK__tDatabaseMemoryLog_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p._tDatabaseMemoryLogID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK__tDatabaseMemoryLog_ID_LastModifiedBy");
            });

            modelBuilder.Entity<_tDetailView>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Caption)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Height).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.JsController)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Width).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p._tDetailViewID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tDetailView_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p._tDetailViewID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tDetailView_ID_LastModifiedBy");

                entity.HasOne(d => d.ID_ModelNavigation)
                    .WithMany(p => p._tDetailView)
                    .HasForeignKey(d => d.ID_Model)
                    .HasConstraintName("FK_tDetailView_ID_Model");
            });

            modelBuilder.Entity<_tDetailView_Detail>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Caption)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DataSource)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DisplayExpr)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayProperty)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Format)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InputMask)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.LookUp_ListView_Caption)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LookUp_ListView_DataSource)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SearchExpr)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ValueExpr)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p._tDetailView_DetailID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tDetailView_Detail_ID_CreatedBy");

                entity.HasOne(d => d.ID_DetailViewNavigation)
                    .WithMany(p => p._tDetailView_Detail)
                    .HasForeignKey(d => d.ID_DetailView)
                    .HasConstraintName("FK_tDetailView_Detail_ID_DetailView");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p._tDetailView_DetailID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tDetailView_Detail_ID_LastModifiedBy");

                entity.HasOne(d => d.ID_ListViewNavigation)
                    .WithMany(p => p._tDetailView_DetailID_ListViewNavigation)
                    .HasForeignKey(d => d.ID_ListView)
                    .HasConstraintName("FK_tDetailView_Detail_ID_ListView");

                entity.HasOne(d => d.ID_LookUp_ListViewNavigation)
                    .WithMany(p => p._tDetailView_DetailID_LookUp_ListViewNavigation)
                    .HasForeignKey(d => d.ID_LookUp_ListView)
                    .HasConstraintName("FK_tDetailView_Detail_ID_LookUp_ListView");

                entity.HasOne(d => d.ID_ModelPropertyNavigation)
                    .WithMany(p => p._tDetailView_Detail)
                    .HasForeignKey(d => d.ID_ModelProperty)
                    .HasConstraintName("FK_tDetailView_Detail_ID_ModelProperty");

                entity.HasOne(d => d.ID_SectionNavigation)
                    .WithMany(p => p.InverseID_SectionNavigation)
                    .HasForeignKey(d => d.ID_Section)
                    .HasConstraintName("FK_tDetailView_Detail_ID_Section");

                entity.HasOne(d => d.ID_TabNavigation)
                    .WithMany(p => p.InverseID_TabNavigation)
                    .HasForeignKey(d => d.ID_Tab)
                    .HasConstraintName("FK_tDetailView_Detail_ID_Tab");
            });

            modelBuilder.Entity<_tDetailView_Detail_Link>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p._tDetailView_Detail_LinkID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tDetailView_Detail_Link_ID_CreatedBy");

                entity.HasOne(d => d.ID_DetailView_DetailNavigation)
                    .WithMany(p => p._tDetailView_Detail_LinkID_DetailView_DetailNavigation)
                    .HasForeignKey(d => d.ID_DetailView_Detail)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tDetailView_Detail_Link_ID_DetailView_Detail");

                entity.HasOne(d => d.ID_DetailView_Detail_LinkNavigation)
                    .WithMany(p => p._tDetailView_Detail_LinkID_DetailView_Detail_LinkNavigation)
                    .HasForeignKey(d => d.ID_DetailView_Detail_Link)
                    .HasConstraintName("FK_tDetailView_Detail_Link_ID_DetailView_Detail_Link");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p._tDetailView_Detail_LinkID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tDetailView_Detail_Link_ID_LastModifiedBy");
            });

            modelBuilder.Entity<_tLabelLocation>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<_tListView>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Caption)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DataSource)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.JsController)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p._tListViewID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tListView_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p._tListViewID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tListView_ID_LastModifiedBy");

                entity.HasOne(d => d.ID_ModelNavigation)
                    .WithMany(p => p._tListView)
                    .HasForeignKey(d => d.ID_Model)
                    .HasConstraintName("FK_tListView_ID_Model");
            });

            modelBuilder.Entity<_tListView_Detail>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Caption)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DataSource)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DisplayProperty)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FixedPosition)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Format)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Width)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_ColumnAlignmentNavigation)
                    .WithMany(p => p._tListView_Detail)
                    .HasForeignKey(d => d.ID_ColumnAlignment)
                    .HasConstraintName("FK_tListView_Detail_ID_ColumnAlignment");

                entity.HasOne(d => d.ID_ControlTypeNavigation)
                    .WithMany(p => p._tListView_Detail)
                    .HasForeignKey(d => d.ID_ControlType)
                    .HasConstraintName("FK_tListView_Detail_ID_ControlType");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p._tListView_Detail)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tListView_Detail_ID_CreatedBy");

                entity.HasOne(d => d.ID_ListViewNavigation)
                    .WithMany(p => p._tListView_Detail)
                    .HasForeignKey(d => d.ID_ListView)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tListView_Detail_ID_ListView");
            });

            modelBuilder.Entity<_tModel>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Caption)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Color1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Color2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Color3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ControllerPath)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Icon)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TableName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ViewSource)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p._tModelID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tModel_ID_CreatedBy");

                entity.HasOne(d => d.ID_DetailViewNavigation)
                    .WithMany(p => p._tModel)
                    .HasForeignKey(d => d.ID_DetailView)
                    .HasConstraintName("FK_tModel_ID_DetailView");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p._tModelID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tModel_ID_LastModifiedBy");
            });

            modelBuilder.Entity<_tModelReport>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX__tModelReport");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Oid_Model)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Oid_Report)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p._tModelReport)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK__tModelReport_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p._tModelReportID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK__tModelReport_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p._tModelReportID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK__tModelReport_ID_LastModifiedBy");
            });

            modelBuilder.Entity<_tModel_Property>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Caption)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DefaultValue)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayProperty)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p._tModel_Property)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tModel_Property_ID_CreatedBy");

                entity.HasOne(d => d.ID_ModelNavigation)
                    .WithMany(p => p._tModel_PropertyID_ModelNavigation)
                    .HasForeignKey(d => d.ID_Model)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tModel_Property__tModel");

                entity.HasOne(d => d.ID_ModelProperty_KeyNavigation)
                    .WithMany(p => p.InverseID_ModelProperty_KeyNavigation)
                    .HasForeignKey(d => d.ID_ModelProperty_Key)
                    .HasConstraintName("FK_tModel_Property_ID_ModelProperty_Key");

                entity.HasOne(d => d.ID_PropertyModelNavigation)
                    .WithMany(p => p._tModel_PropertyID_PropertyModelNavigation)
                    .HasForeignKey(d => d.ID_PropertyModel)
                    .HasConstraintName("FK_tModel_Property_ID_PropertyModel");
            });

            modelBuilder.Entity<_tNavigation>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Caption)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Icon)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Route)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p._tNavigationID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tNavigation_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p._tNavigationID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tNavigation_ID_LastModifiedBy");

                entity.HasOne(d => d.ID_ParentNavigation)
                    .WithMany(p => p.InverseID_ParentNavigation)
                    .HasForeignKey(d => d.ID_Parent)
                    .HasConstraintName("FK_tNavigation_ID_Parent");

                entity.HasOne(d => d.ID_ViewNavigation)
                    .WithMany(p => p._tNavigation)
                    .HasForeignKey(d => d.ID_View)
                    .HasConstraintName("FK_tNavigation_ID_View");
            });

            modelBuilder.Entity<_tPropertyType>(entity =>
            {
                entity.Property(e => e.Comment)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<_tReport>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Name)
                    .HasName("IX__tReport");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ReportPath)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<_tReport_Filters>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.HasIndex(e => e.Name)
                    .HasName("IX__tReport_Filters");

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Caption)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DataSource)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<_tSummaryType>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<_tView>(entity =>
            {
                entity.HasKey(e => e.Oid);

                entity.Property(e => e.Oid).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ControllerPath)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.CustomViewPath)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DataSource)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p._tViewID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tView_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p._tViewID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tView_ID_LastModifiedBy");

                entity.HasOne(d => d.ID_ModelNavigation)
                    .WithMany(p => p._tView)
                    .HasForeignKey(d => d.ID_Model)
                    .HasConstraintName("FK_tView_ID_Model");
            });

            modelBuilder.Entity<_tViewType>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<_vDetailView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_vDetailView");

                entity.Property(e => e.Caption)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Height).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.JsController)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Width).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<_vDetailView_Detail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_vDetailView_Detail");

                entity.Property(e => e.Caption)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ControlType)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DataSource)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DetailView)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayExpr)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayProperty)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Format)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InputMask)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LookUp_ListView_Caption)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LookUp_ListView_DataSource)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ModelProperty)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PropertyType)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SearchExpr)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SectionName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TabName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ValueExpr)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<_vGenerateTSClass>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_vGenerateTSClass");

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.Property(e => e.TS).HasMaxLength(139);

                entity.Property(e => e.TableName).HasMaxLength(128);
            });

            modelBuilder.Entity<_vLastestMessageRecipient>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_vLastestMessageRecipient");

                entity.Property(e => e.LastDateSent).HasColumnType("datetime");

                entity.Property(e => e.Recipient_Name_User)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<_vListView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_vListView");

                entity.Property(e => e.Caption)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DataSource)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.JsController)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryKey).HasMaxLength(128);

                entity.Property(e => e._DataSource)
                    .HasColumnName("$DataSource")
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<_vListViewLookUp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_vListViewLookUp");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<_vListView_Detail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_vListView_Detail");

                entity.Property(e => e.Caption)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DataSource)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DisplayProperty)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FixedPosition)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Format)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ModelProperty)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Width)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e._DataSource)
                    .HasColumnName("$DataSource")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<_vModel>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_vModel");

                entity.Property(e => e.Caption)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Color1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Color2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Color3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ControllerPath)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DetailView)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Icon)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryKey).HasMaxLength(128);

                entity.Property(e => e.TableName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ViewSource)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<_vModelGetProcedures>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_vModelGetProcedures");

                entity.Property(e => e.name)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<_vModelPropertiesCrud>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_vModelPropertiesCrud");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PropertyModel)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PropertyModel_Link)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PropertyModel_PrimaryKey).HasMaxLength(128);

                entity.Property(e => e.PropertyModel_TableName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TableName)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<_vModelProperyDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_vModelProperyDetail");

                entity.Property(e => e.FieldKey)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryKey).HasMaxLength(128);

                entity.Property(e => e.TableName)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<_vModelViews>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_vModelViews");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<_vModel_Property>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_vModel_Property");

                entity.Property(e => e.Caption)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DefaultValue)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayProperty)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PropertyModel)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PropertyType)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<_vModuleViews>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_vModuleViews");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<_vNavigation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_vNavigation");

                entity.Property(e => e.Caption)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Icon)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Route)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<_vNavigationLookUp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_vNavigationLookUp");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<_vReportLookUp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_vReportLookUp");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<_vSetting>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_vSetting");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<_vUserDefinedTypes>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_vUserDefinedTypes");

                entity.Property(e => e.ColumnName).HasMaxLength(128);

                entity.Property(e => e.DataType)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<_vView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_vView");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ControllerPath)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.CustomViewPath)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DataSource)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<_vViewLookUp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_vViewLookUp");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<animallifeclinic_patientrecord>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("animallifeclinic-patientrecord");

                entity.Property(e => e.Attending_Vet)
                    .HasColumnName("Attending Vet")
                    .HasMaxLength(255);

                entity.Property(e => e.Chief_Complaint)
                    .HasColumnName("Chief Complaint")
                    .HasMaxLength(255);

                entity.Property(e => e.Complete).HasMaxLength(255);

                entity.Property(e => e.Date).HasMaxLength(255);

                entity.Property(e => e.FollowupDate__SOAP_Plan_)
                    .HasColumnName("FollowupDate (SOAP Plan)")
                    .HasMaxLength(255);

                entity.Property(e => e.Patient).HasMaxLength(255);

                entity.Property(e => e.Prescription).HasMaxLength(255);

                entity.Property(e => e.Treatment).HasMaxLength(255);
            });

            modelBuilder.Entity<evgjuicopetcarecenter_appointment_2021_11_03>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("evgjuicopetcarecenter appointment 2021-11-03");

                entity.Property(e => e.cName).HasMaxLength(255);

                entity.Property(e => e.client_email).HasMaxLength(255);

                entity.Property(e => e.client_name).HasMaxLength(255);

                entity.Property(e => e.end).HasMaxLength(255);

                entity.Property(e => e.reason).HasMaxLength(255);

                entity.Property(e => e.start).HasMaxLength(255);

                entity.Property(e => e.status).HasMaxLength(255);

                entity.Property(e => e.title).HasMaxLength(255);

                entity.Property(e => e.vName).HasMaxLength(255);
            });

            modelBuilder.Entity<tAppSetting>(entity =>
            {
                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ColorValue)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateTimeValue).HasColumnType("datetime");

                entity.Property(e => e.DecimalValue).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ImageValue)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.StringValue)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tAppSettingID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tAppSetting_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tAppSettingID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tAppSetting_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tAppointment>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateStart).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tAppointment)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tAppointment_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tAppointmentID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tAppointment_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tAppointmentID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tAppointment_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tAppointmentRequest>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateStart).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Reason)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tAppointmentRequest)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tAppointmentRequest_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tAppointmentRequestID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tAppointmentRequest_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tAppointmentRequestID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tAppointmentRequest_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tAppointmentSchedule>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tAppointmentSchedule");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateStart).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tAppointmentSchedule)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tAppointmentSchedule_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tAppointmentScheduleID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tAppointmentSchedule_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tAppointmentScheduleID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tAppointmentSchedule_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tAppointmentStatusLog>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tAppointmentStatusLog");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Oid_Model)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tAppointmentStatusLog)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tAppointmentStatusLog_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tAppointmentStatusLogID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tAppointmentStatusLog_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tAppointmentStatusLogID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tAppointmentStatusLog_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tApproverMatrix>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tApproverMatrixID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tApproverMatrix_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tApproverMatrixID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tApproverMatrix_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tApproverMatrix_Detail>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_ApproverMatrixNavigation)
                    .WithMany(p => p.tApproverMatrix_Detail)
                    .HasForeignKey(d => d.ID_ApproverMatrix)
                    .HasConstraintName("FKtApproverMatrix_Detail_ID_ApproverMatrix");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tApproverMatrix_DetailID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tApproverMatrix_Detail_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tApproverMatrix_DetailID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tApproverMatrix_Detail_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tAuditTrail>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ID_CurrentObject)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<tAuditTrailType>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<tAuditTrail_Detail>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ID_CurrentObject)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.ModelProperty)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NewValue).HasColumnType("text");

                entity.Property(e => e.OldValue).HasColumnType("text");

                entity.HasOne(d => d.ID_AuditTrailNavigation)
                    .WithMany(p => p.tAuditTrail_Detail)
                    .HasForeignKey(d => d.ID_AuditTrail)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FKtAuditTrail_Detail_ID_AuditTrail");
            });

            modelBuilder.Entity<tBillingInvoice>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tBillingInvoice");

                entity.Property(e => e.BillingAddress)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.ConfinementDepositAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ConsumedDepositAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.DateCanceled).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Discount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DiscountRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.GrossAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.InitialSubtotalAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NetAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PatientNames)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.RemainingAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.RemainingDepositAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SubTotal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalItemDiscountAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.VatAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.VatPercentage).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.WalkInCustomerName)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tBillingInvoice)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tBillingInvoice_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tBillingInvoiceID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tBillingInvoice_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tBillingInvoiceID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tBillingInvoice_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tBillingInvoiceWalkIn>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tBillingInvoiceWalkIn");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tBillingInvoiceWalkIn)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tBillingInvoiceWalkIn_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tBillingInvoiceWalkInID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tBillingInvoiceWalkIn_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tBillingInvoiceWalkInID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tBillingInvoiceWalkIn_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tBillingInvoiceWalkInList>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tBillingInvoiceWalkInList");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tBillingInvoiceWalkInList)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tBillingInvoiceWalkInList_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tBillingInvoiceWalkInListID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tBillingInvoiceWalkInList_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tBillingInvoiceWalkInListID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tBillingInvoiceWalkInList_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tBillingInvoice_Detail>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tBillingInvoice_Detail");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateExpiration).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DiscountRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UnitCost).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.ID_BillingInvoiceNavigation)
                    .WithMany(p => p.tBillingInvoice_Detail)
                    .HasForeignKey(d => d.ID_BillingInvoice)
                    .HasConstraintName("FKtBillingInvoice_Detail_ID_BillingInvoice");

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tBillingInvoice_Detail)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tBillingInvoice_Detail_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tBillingInvoice_DetailID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tBillingInvoice_Detail_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tBillingInvoice_DetailID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tBillingInvoice_Detail_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tBillingInvoice_Patient>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tBillingInvoice_Patient");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_BillingInvoiceNavigation)
                    .WithMany(p => p.tBillingInvoice_Patient)
                    .HasForeignKey(d => d.ID_BillingInvoice)
                    .HasConstraintName("FKtBillingInvoice_Patient_ID_BillingInvoice");

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tBillingInvoice_Patient)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tBillingInvoice_Patient_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tBillingInvoice_PatientID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tBillingInvoice_Patient_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tBillingInvoice_PatientID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tBillingInvoice_Patient_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tBreedSpecie>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tBreedSpecie");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tBreedSpecie)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tBreedSpecie_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tBreedSpecieID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tBreedSpecie_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tBreedSpecieID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tBreedSpecie_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tBusinessPartner>(entity =>
            {
                entity.Property(e => e.AliasName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.MobilePhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TIN)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TelNoA)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TelNoB)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WebSite)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tBusinessPartnerID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tBusinessPartner_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tBusinessPartnerID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tBusinessPartner_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tBusinessPartnerType>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tBusinessPartnerTypeID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tBusinessPartnerType_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tBusinessPartnerTypeID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tBusinessPartnerType_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tBusinessPartner_Contact>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.LastName)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Position)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_BusinessPartnerNavigation)
                    .WithMany(p => p.tBusinessPartner_Contact)
                    .HasForeignKey(d => d.ID_BusinessPartner)
                    .HasConstraintName("FKtBusinessPartner_Contact_ID_BusinessPartner");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tBusinessPartner_ContactID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tBusinessPartner_Contact_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tBusinessPartner_ContactID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tBusinessPartner_Contact_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tCardType>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tCardType");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tCardType)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tCardType_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tCardTypeID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tCardType_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tCardTypeID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tCardType_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tCaseType>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tCaseType");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tCaseType)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tCaseType_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tCaseTypeID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tCaseType_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tCaseTypeID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tCaseType_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tClient>(entity =>
            {
                entity.Property(e => e.Address)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNumber2)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentCreditAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CustomCode)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateLastVisited).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.tempID)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tClient)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tClient_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tClientID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tClient_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tClientID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tClient_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tClientDeposit>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tClientDeposit");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.DateCanceled).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DepositAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tClientDeposit)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tClientDeposit_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tClientDepositID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tClientDeposit_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tClientDepositID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tClientDeposit_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tClientWithdraw_>(entity =>
            {
                entity.ToTable("tClientWithdraw ");

                entity.HasIndex(e => e.Name)
                    .HasName("IX_tClientWithdraw ");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.DateCanceled).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.WithdrawAmount).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tClientWithdraw_)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tClientWithdraw _ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tClientWithdraw_ID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tClientWithdraw _ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tClientWithdraw_ID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tClientWithdraw _ID_LastModifiedBy");
            });

            modelBuilder.Entity<tClient_CreditLogs>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tClient_CreditLogs");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreditAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tClient_CreditLogs)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tClient_CreditLogs_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tClient_CreditLogsID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tClient_CreditLogs_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tClient_CreditLogsID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tClient_CreditLogs_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tCompany>(entity =>
            {
                entity.Property(e => e.Address)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ImageHeaderFilename)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ImageLogoFilename)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsRemoveBoldText).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsShowHeader).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsShowPOSReceiptLogo).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.POSReceiptFontSize)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SOAPPlanSMSMessage)
                    .HasMaxLength(700)
                    .IsUnicode(false);

                entity.Property(e => e.SecurityPIN)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tCompanyID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tCompany_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tCompanyID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tCompany_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tCompanyInfo>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tCompanyInfo");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tCompanyInfo)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tCompanyInfo_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tCompanyInfoID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tCompanyInfo_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tCompanyInfoID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tCompanyInfo_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tCompanyTextBlastTemplate>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tCompanyTextBlastTemplate");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Template)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tCompanyTextBlastTemplate)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tCompanyTextBlastTemplate_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tCompanyTextBlastTemplateID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tCompanyTextBlastTemplate_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tCompanyTextBlastTemplateID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tCompanyTextBlastTemplate_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tCompany_SMSSetting>(entity =>
            {
                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tCompany_SMSSetting)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tCompany_SMSSetting_ID_Company");
            });

            modelBuilder.Entity<tCompany_Subscription>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tCompany_Subscription");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateStart).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tCompany_Subscription)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tCompany_Subscription_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tCompany_SubscriptionID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tCompany_Subscription_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tCompany_SubscriptionID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tCompany_Subscription_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tCountry>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tCountry)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tCountry_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tCountryID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tCountry_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tCountryID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tCountry_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tCustomDetailViewRoute>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tCustomDetailViewRoute");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Oid_DetailView)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.RouterLink)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tCustomDetailViewRoute)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tCustomDetailViewRoute_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tCustomDetailViewRouteID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tCustomDetailViewRoute_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tCustomDetailViewRouteID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tCustomDetailViewRoute_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tCustomNavigationLink>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tCustomNavigationLink");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Oid_ListView)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Oid_Report)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.RouterLink)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tCustomNavigationLink)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tCustomNavigationLink_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tCustomNavigationLinkID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tCustomNavigationLink_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tCustomNavigationLinkID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tCustomNavigationLink_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tDentalExamination>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tDentalExamination");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tDentalExamination)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tDentalExamination_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tDentalExaminationID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tDentalExamination_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tDentalExaminationID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tDentalExamination_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tDentition>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tDentition");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tDentition)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tDentition_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tDentitionID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tDentition_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tDentitionID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tDentition_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tDoc>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tDocID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tDoc_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tDocID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tDoc_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tDoc_Detail>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<tDocumentSeries>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Prefix)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tDocumentSeriesID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tDocumentSeries_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tDocumentSeriesID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tDocumentSeries_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tDocumentStatus>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tDocumentStatus)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tDocumentStatus_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tDocumentStatusID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tDocumentStatus_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tDocumentStatusID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tDocumentStatus_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tEmployee>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DatePRCExpiration).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.FullAddress)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ID_EmployeeStatus)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ID_Gender)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ImageFile)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.PRCLicenseNumber)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.PTR)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.S2)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.TINNumber)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tEmployee)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FKtEmployee_ID_LastModifiedBy");

                entity.HasOne(d => d.ID_PositionNavigation)
                    .WithMany(p => p.tEmployee)
                    .HasForeignKey(d => d.ID_Position)
                    .HasConstraintName("FKtEmployee_ID_Position");
            });

            modelBuilder.Entity<tEmployeeInfo>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tEmployeeInfo");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tEmployeeInfo)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tEmployeeInfo_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tEmployeeInfoID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tEmployeeInfo_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tEmployeeInfoID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tEmployeeInfo_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tEmployeePosition>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tEmployeePositionID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tEmployeePosition_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tEmployeePositionID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tEmployeePosition_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tEmployeeStatus>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<tEmploymentStatus>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tEmploymentStatus)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tEmploymentStatus_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tEmploymentStatusID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tEmploymentStatus_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tEmploymentStatusID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tEmploymentStatus_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tEmplyee>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tEmplyee)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tEmplyee_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tEmplyeeID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tEmplyee_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tEmplyeeID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tEmplyee_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tExpenseCategory>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tExpenseCategory");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tExpenseCategory)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tExpenseCategory_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tExpenseCategoryID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tExpenseCategory_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tExpenseCategoryID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tExpenseCategory_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tFileUpload>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.FileName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ID_CurrentObject)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Path)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tFileUploadID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tFileUpload_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tFileUploadID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tFileUpload_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tFilingStatus>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tFilingStatus)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tFilingStatus_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tFilingStatusID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tFilingStatus_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tFilingStatusID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tFilingStatus_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tForBilling>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tForBilling");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tForBilling)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tForBilling_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tForBillingID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tForBilling_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tForBillingID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tForBilling_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tGender>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<tHelpDeskVideoTutorial>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tHelpDeskVideoTutorial");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SearcgTag)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SearchTag)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ThumbnailImage)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.VideoLink)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tHelpDeskVideoTutorial)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tHelpDeskVideoTutorial_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tHelpDeskVideoTutorialID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tHelpDeskVideoTutorial_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tHelpDeskVideoTutorialID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tHelpDeskVideoTutorial_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tITextMoAPISMSStatus>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tITextMoAPISMSStatus");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tITextMoAPISMSStatus)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tITextMoAPISMSStatus_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tITextMoAPISMSStatusID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tITextMoAPISMSStatus_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tITextMoAPISMSStatusID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tITextMoAPISMSStatus_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tInventoryStatus>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tInventoryStatus");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tInventoryStatus)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tInventoryStatus_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tInventoryStatusID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tInventoryStatus_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tInventoryStatusID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tInventoryStatus_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tInventorySummary>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tInventorySummary");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tInventorySummary)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tInventorySummary_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tInventorySummaryID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tInventorySummary_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tInventorySummaryID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tInventorySummary_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tInventoryTrail>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tInventoryTrail");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateExpired).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tInventoryTrail)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tInventoryTrail_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tInventoryTrailID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tInventoryTrail_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tInventoryTrailID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tInventoryTrail_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tIssueTracker>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tIssueTracker");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DeveloperSide)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Issue)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Solution)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tIssueTracker)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tIssueTracker_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tIssueTrackerID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tIssueTracker_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tIssueTrackerID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tIssueTracker_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tItem>(entity =>
            {
                entity.Property(e => e.BarCode)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CustomCode)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OtherInfo_DateExpiration).HasColumnType("datetime");

                entity.Property(e => e.UnitCost).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e._tempSupplier)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tItem)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tItem_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tItemID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tItem_ID_CreatedBy");

                entity.HasOne(d => d.ID_ItemCategoryNavigation)
                    .WithMany(p => p.tItem)
                    .HasForeignKey(d => d.ID_ItemCategory)
                    .HasConstraintName("FKtItem_ID_ItemCategory");

                entity.HasOne(d => d.ID_ItemTypeNavigation)
                    .WithMany(p => p.tItem)
                    .HasForeignKey(d => d.ID_ItemType)
                    .HasConstraintName("FKtItem_ID_ItemType");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tItemID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tItem_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tItemCategory>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tItemCategory");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tItemCategory)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tItemCategory_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tItemCategoryID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tItemCategory_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tItemCategoryID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tItemCategory_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tItemInventoriable>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tItemInventoriable");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tItemInventoriable)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tItemInventoriable_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tItemInventoriableID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tItemInventoriable_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tItemInventoriableID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tItemInventoriable_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tItemService>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tItemService");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tItemService)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tItemService_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tItemServiceID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tItemService_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tItemServiceID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tItemService_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tItemType>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tItemType");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tItemType)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tItemType_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tItemTypeID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tItemType_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tItemTypeID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tItemType_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tItem_Supplier>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_ItemNavigation)
                    .WithMany(p => p.tItem_Supplier)
                    .HasForeignKey(d => d.ID_Item)
                    .HasConstraintName("FKtItem_Supplier_ID_Item");
            });

            modelBuilder.Entity<tItem_UnitCostLog>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tItem_UnitCostLog");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tItem_UnitCostLog)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tItem_UnitCostLog_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tItem_UnitCostLogID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tItem_UnitCostLog_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tItem_UnitCostLogID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tItem_UnitCostLog_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tItem_UnitPriceLog>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tItem_UnitPriceLog");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tItem_UnitPriceLog)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tItem_UnitPriceLog_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tItem_UnitPriceLogID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tItem_UnitPriceLog_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tItem_UnitPriceLogID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tItem_UnitPriceLog_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tLocalShippingPermitIssuance>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tLocalShippingPermitIssuance");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DestinationBarangay)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationContactNumber)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationEstablishment)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationFullAddress)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationMunicipality)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationProvince)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationSender)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.ModeOfTransfortationAirCarrierType)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ModeOfTransfortationAirPlateNumber)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ModeOfTransfortationLandCarrierType)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ModeOfTransfortationLandPlateNumber)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ModeOfTransfortationWaterCarrierType)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ModeOfTransfortationWaterPlateNumber)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OriginBarangay)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.OriginContactNumber)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.OriginEstablishment)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.OriginFullAddress)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.OriginMunicipality)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.OriginProvince)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.OriginSender)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ProposedArrivalDate).HasColumnType("datetime");

                entity.Property(e => e.ProposedShippingDate).HasColumnType("datetime");

                entity.Property(e => e.ShippingAccredationNumber)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingCategory)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingCountryOrigin)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingLicenceNumber)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingProductSource)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingPurpose)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingShipper)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingSource)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tLocalShippingPermitIssuance)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tLocalShippingPermitIssuance_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tLocalShippingPermitIssuanceID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tLocalShippingPermitIssuance_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tLocalShippingPermitIssuanceID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tLocalShippingPermitIssuance_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tLocalShippingPermitIssuance_Item>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tLocalShippingPermitIssuance_Item");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tLocalShippingPermitIssuance_Item)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tLocalShippingPermitIssuance_Item_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tLocalShippingPermitIssuance_ItemID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tLocalShippingPermitIssuance_Item_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tLocalShippingPermitIssuance_ItemID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tLocalShippingPermitIssuance_Item_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tLocalShippingPermitIssuance_Requirement>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tLocalShippingPermitIssuance_Requirement");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.ImageLocation)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IssuedBy)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PRCLicenseNo)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tLocalShippingPermitIssuance_Requirement)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tLocalShippingPermitIssuance_Requirement_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tLocalShippingPermitIssuance_RequirementID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tLocalShippingPermitIssuance_Requirement_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tLocalShippingPermitIssuance_RequirementID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tLocalShippingPermitIssuance_Requirement_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tMedicalHistoryQuestionnaire>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tMedicalHistoryQuestionnaire");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tMedicalHistoryQuestionnaire)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tMedicalHistoryQuestionnaire_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tMedicalHistoryQuestionnaireID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tMedicalHistoryQuestionnaire_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tMedicalHistoryQuestionnaireID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tMedicalHistoryQuestionnaire_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tMedicationRoute>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tMedicationRoute");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tMedicationRoute)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tMedicationRoute_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tMedicationRouteID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tMedicationRoute_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tMedicationRouteID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tMedicationRoute_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tMessage>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tMessage");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tMessage)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tMessage_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tMessageID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tMessage_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tMessageID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tMessage_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tMessageConversation>(entity =>
            {
                entity.Property(e => e.DateRead).HasColumnType("datetime");

                entity.Property(e => e.DateSent).HasColumnType("datetime");
            });

            modelBuilder.Entity<tMessageRoom>(entity =>
            {
                entity.Property(e => e.Name)
                    .HasMaxLength(400)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<tMessageRoom_User_Message>(entity =>
            {
                entity.Property(e => e.DateSent).HasColumnType("datetime");
            });

            modelBuilder.Entity<tMessageThread>(entity =>
            {
                entity.Property(e => e.DateRead).HasColumnType("datetime");

                entity.Property(e => e.DateSent).HasColumnType("datetime");

                entity.Property(e => e.Message)
                    .HasMaxLength(3000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<tPatient>(entity =>
            {
                entity.Property(e => e.AnimalWellness)
                    .HasMaxLength(7000)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentCreditAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CustomCode)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DateBirth).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateDeceased).HasColumnType("datetime");

                entity.Property(e => e.DateLastVisited).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.FullAddress)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.LastName)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Microchip)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProfileImageFile)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Species)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tPatientID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tPatient_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tPatientID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tPatient_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tPatientAppointment>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tPatientAppointment");

                entity.Property(e => e.Appointment_CancellationRemarks)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Appointment_ID_FilingStatus).HasDefaultValueSql("((2))");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCanceled).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateDone).HasColumnType("datetime");

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateStart).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tPatientAppointment)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tPatientAppointment_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tPatientAppointmentID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tPatientAppointment_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tPatientAppointmentID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tPatientAppointment_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tPatientSOAPList>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tPatientSOAPList");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tPatientSOAPList)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tPatientSOAPList_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tPatientSOAPListID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tPatientSOAPList_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tPatientSOAPListID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tPatientSOAPList_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tPatientWaitingList>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tPatientWaitingList");

                entity.Property(e => e.Code)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tPatientWaitingList)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tPatientWaitingList_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tPatientWaitingListID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tPatientWaitingList_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tPatientWaitingListID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tPatientWaitingList_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tPatientWaitingList_Logs>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tPatientWaitingList_Logs");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tPatientWaitingList_Logs)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tPatientWaitingList_Logs_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tPatientWaitingList_LogsID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tPatientWaitingList_Logs_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tPatientWaitingList_LogsID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tPatientWaitingList_Logs_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tPatient_BirthDateSMSGreetingLog>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tPatient_BirthDateSMSGreetingLog");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateSent).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Message)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tPatient_BirthDateSMSGreetingLog)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tPatient_BirthDateSMSGreetingLog_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tPatient_BirthDateSMSGreetingLogID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tPatient_BirthDateSMSGreetingLog_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tPatient_BirthDateSMSGreetingLogID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tPatient_BirthDateSMSGreetingLog_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tPatient_Confinement>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tPatient_Confinement");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateCanceled).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateDischarge).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PatientNames)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SubTotal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tPatient_Confinement)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tPatient_Confinement_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tPatient_ConfinementID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tPatient_Confinement_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tPatient_ConfinementID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tPatient_Confinement_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tPatient_Confinement_ItemsServices>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tPatient_Confinement_ItemsServices");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateExpiration).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Route)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.UnitCost).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tPatient_Confinement_ItemsServices)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tPatient_Confinement_ItemsServices_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tPatient_Confinement_ItemsServicesID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tPatient_Confinement_ItemsServices_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tPatient_Confinement_ItemsServicesID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tPatient_Confinement_ItemsServices_ID_LastModifiedBy");

                entity.HasOne(d => d.ID_Patient_ConfinementNavigation)
                    .WithMany(p => p.tPatient_Confinement_ItemsServices)
                    .HasForeignKey(d => d.ID_Patient_Confinement)
                    .HasConstraintName("FKtPatient_Confinement_ItemsServices_ID_Patient_Confinement");
            });

            modelBuilder.Entity<tPatient_Confinement_Patient>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tPatient_Confinement_Patient");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tPatient_Confinement_Patient)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tPatient_Confinement_Patient_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tPatient_Confinement_PatientID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tPatient_Confinement_Patient_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tPatient_Confinement_PatientID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tPatient_Confinement_Patient_ID_LastModifiedBy");

                entity.HasOne(d => d.ID_Patient_ConfinementNavigation)
                    .WithMany(p => p.tPatient_Confinement_Patient)
                    .HasForeignKey(d => d.ID_Patient_Confinement)
                    .HasConstraintName("FKtPatient_Confinement_Patient_ID_Patient_Confinement");
            });

            modelBuilder.Entity<tPatient_CreditLogs>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tPatient_CreditLogs");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreditAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tPatient_CreditLogs)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tPatient_CreditLogs_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tPatient_CreditLogsID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tPatient_CreditLogs_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tPatient_CreditLogsID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tPatient_CreditLogs_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tPatient_DentalExamination>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tPatient_DentalExamination");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.DateCanceled).HasColumnType("datetime");

                entity.Property(e => e.GUID)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_PatientNavigation)
                    .WithMany(p => p.tPatient_DentalExamination)
                    .HasForeignKey(d => d.ID_Patient)
                    .HasConstraintName("FKtPatient_DentalExamination_ID_Patient");
            });

            modelBuilder.Entity<tPatient_DentalExamination_Image>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tPatient_DentalExamination_Image");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.ImageValue)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tPatient_DentalExamination_Image)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tPatient_DentalExamination_Image_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tPatient_DentalExamination_ImageID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tPatient_DentalExamination_Image_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tPatient_DentalExamination_ImageID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tPatient_DentalExamination_Image_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tPatient_DentalExamination_MedicalHistory>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tPatient_DentalExamination_MedicalHistory");

                entity.Property(e => e.Answer)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tPatient_DentalExamination_MedicalHistory)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tPatient_DentalExamination_MedicalHistory_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tPatient_DentalExamination_MedicalHistoryID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tPatient_DentalExamination_MedicalHistory_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tPatient_DentalExamination_MedicalHistoryID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tPatient_DentalExamination_MedicalHistory_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tPatient_DentalExamination_ToothInfo>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tPatient_DentalExamination_ToothInfo");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.GUID)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.IDs_ToothSurface)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tPatient_DentalExamination_ToothInfo)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tPatient_DentalExamination_ToothInfo_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tPatient_DentalExamination_ToothInfoID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tPatient_DentalExamination_ToothInfo_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tPatient_DentalExamination_ToothInfoID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tPatient_DentalExamination_ToothInfo_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tPatient_History>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_PatientNavigation)
                    .WithMany(p => p.tPatient_History)
                    .HasForeignKey(d => d.ID_Patient)
                    .HasConstraintName("FKtPatient_History_ID_Patient");
            });

            modelBuilder.Entity<tPatient_Lodging>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tPatient_Lodging");

                entity.Property(e => e.AdvancedPaymentAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ChangeAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCheckIn).HasColumnType("datetime");

                entity.Property(e => e.DateCheckOut).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateStart).HasColumnType("datetime");

                entity.Property(e => e.HourCount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PayableAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PaymentAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.RateAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.RemainingAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tPatient_Lodging)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tPatient_Lodging_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tPatient_LodgingID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tPatient_Lodging_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tPatient_LodgingID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tPatient_Lodging_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tPatient_SOAP>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tPatient_SOAP");

                entity.Property(e => e.Assessment)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.CaseType)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ClientCommunication)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.ClinicalExamination)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.DateCanceled).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateDone).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Diagnosis)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.History)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Interpretation)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.LabImageFilePath01)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageFilePath02)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageFilePath03)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageFilePath04)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageFilePath05)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageFilePath06)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageFilePath07)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageFilePath08)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageFilePath09)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageFilePath10)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageFilePath11)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageFilePath12)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageFilePath13)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageFilePath14)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageFilePath15)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageRemark01)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageRemark02)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageRemark03)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageRemark04)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageRemark05)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageRemark06)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageRemark07)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageRemark08)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageRemark09)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageRemark10)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageRemark11)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageRemark12)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageRemark13)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageRemark14)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageRemark15)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageRowIndex01)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageRowIndex02)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageRowIndex03)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageRowIndex04)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageRowIndex05)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageRowIndex06)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageRowIndex07)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageRowIndex08)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageRowIndex09)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageRowIndex10)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageRowIndex11)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageRowIndex12)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageRowIndex13)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageRowIndex14)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageRowIndex15)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Objective)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Planning)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Prescription)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Subjective)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Treatment)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tPatient_SOAP)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tPatient_SOAP_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tPatient_SOAPID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tPatient_SOAP_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tPatient_SOAPID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tPatient_SOAP_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tPatient_SOAP_Plan>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tPatient_SOAP_Plan");

                entity.Property(e => e.Appointment_CancellationRemarks)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Appointment_ID_FilingStatus).HasDefaultValueSql("((2))");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CustomItem)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateReturn).HasColumnType("datetime");

                entity.Property(e => e.DateSent).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_Patient_SOAPNavigation)
                    .WithMany(p => p.tPatient_SOAP_Plan)
                    .HasForeignKey(d => d.ID_Patient_SOAP)
                    .HasConstraintName("FKtPatient_SOAP_Plan_ID_Patient_SOAP");
            });

            modelBuilder.Entity<tPatient_SOAP_Prescription>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tPatient_SOAP_Prescription");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateExpiration).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsCharged).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UnitCost).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tPatient_SOAP_Prescription)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tPatient_SOAP_Prescription_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tPatient_SOAP_PrescriptionID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tPatient_SOAP_Prescription_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tPatient_SOAP_PrescriptionID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tPatient_SOAP_Prescription_ID_LastModifiedBy");

                entity.HasOne(d => d.ID_Patient_SOAPNavigation)
                    .WithMany(p => p.tPatient_SOAP_Prescription)
                    .HasForeignKey(d => d.ID_Patient_SOAP)
                    .HasConstraintName("FKtPatient_SOAP_Prescription_ID_Patient_SOAP");
            });

            modelBuilder.Entity<tPatient_SOAP_RegularConsoltation>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_PatientNavigation)
                    .WithMany(p => p.tPatient_SOAP_RegularConsoltation)
                    .HasForeignKey(d => d.ID_Patient)
                    .HasConstraintName("FKtPatient_SOAP_RegularConsoltation_ID_Patient");
            });

            modelBuilder.Entity<tPatient_SOAP_SMSStatus>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tPatient_SOAP_SMSStatus");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tPatient_SOAP_SMSStatus)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tPatient_SOAP_SMSStatus_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tPatient_SOAP_SMSStatusID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tPatient_SOAP_SMSStatus_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tPatient_SOAP_SMSStatusID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tPatient_SOAP_SMSStatus_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tPatient_SOAP_Treatment>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tPatient_SOAP_Treatment");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateExpiration).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UnitCost).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tPatient_SOAP_Treatment)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tPatient_SOAP_Treatment_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tPatient_SOAP_TreatmentID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tPatient_SOAP_Treatment_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tPatient_SOAP_TreatmentID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tPatient_SOAP_Treatment_ID_LastModifiedBy");

                entity.HasOne(d => d.ID_Patient_SOAPNavigation)
                    .WithMany(p => p.tPatient_SOAP_Treatment)
                    .HasForeignKey(d => d.ID_Patient_SOAP)
                    .HasConstraintName("FKtPatient_SOAP_Treatment_ID_Patient_SOAP");
            });

            modelBuilder.Entity<tPatient_Vaccination>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tPatient_Vaccination");

                entity.Property(e => e.Appointment_CancellationRemarks)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Appointment_ID_FilingStatus).HasDefaultValueSql("((2))");

                entity.Property(e => e.AttendingPhysician)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateCanceled).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateExpiration).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.HeartRate)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Temparature)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.UnitCost).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Weight)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tPatient_Vaccination)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tPatient_Vaccination_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tPatient_VaccinationID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tPatient_Vaccination_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tPatient_VaccinationID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tPatient_Vaccination_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tPatient_Vaccination_Schedule>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tPatient_Vaccination_Schedule");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CustomItem)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateSent).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tPatient_Vaccination_Schedule)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tPatient_Vaccination_Schedule_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tPatient_Vaccination_ScheduleID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tPatient_Vaccination_Schedule_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tPatient_Vaccination_ScheduleID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tPatient_Vaccination_Schedule_ID_LastModifiedBy");

                entity.HasOne(d => d.ID_Patient_VaccinationNavigation)
                    .WithMany(p => p.tPatient_Vaccination_Schedule)
                    .HasForeignKey(d => d.ID_Patient_Vaccination)
                    .HasConstraintName("FKtPatient_Vaccination_Schedule_ID_Patient_Vaccination");
            });

            modelBuilder.Entity<tPatient_Vaccination_Schedule_SMSStatus>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tPatient_Vaccination_Schedule_SMSStatus)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tPatient_Vaccination_Schedule_SMSStatus_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tPatient_Vaccination_Schedule_SMSStatusID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tPatient_Vaccination_Schedule_SMSStatus_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tPatient_Vaccination_Schedule_SMSStatusID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tPatient_Vaccination_Schedule_SMSStatus_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tPatient_Wellness>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tPatient_Wellness");

                entity.Property(e => e.AttendingPhysician)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateCanceled).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tPatient_Wellness)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tPatient_Wellness_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tPatient_WellnessID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tPatient_Wellness_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tPatient_WellnessID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tPatient_Wellness_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tPatient_Wellness_Detail>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tPatient_Wellness_Detail");

                entity.Property(e => e.Appointment_CancellationRemarks)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Appointment_ID_FilingStatus).HasDefaultValueSql("((2))");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CustomItem)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateExpiration).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UnitCost).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tPatient_Wellness_Detail)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tPatient_Wellness_Detail_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tPatient_Wellness_DetailID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tPatient_Wellness_Detail_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tPatient_Wellness_DetailID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tPatient_Wellness_Detail_ID_LastModifiedBy");

                entity.HasOne(d => d.ID_Patient_WellnessNavigation)
                    .WithMany(p => p.tPatient_Wellness_Detail)
                    .HasForeignKey(d => d.ID_Patient_Wellness)
                    .HasConstraintName("FKtPatient_Wellness_Detail_ID_Patient_Wellness");
            });

            modelBuilder.Entity<tPatient_Wellness_Schedule>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tPatient_Wellness_Schedule");

                entity.Property(e => e.Appointment_CancellationRemarks)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Appointment_ID_FilingStatus).HasDefaultValueSql("((2))");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateSent).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tPatient_Wellness_Schedule)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tPatient_Wellness_Schedule_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tPatient_Wellness_ScheduleID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tPatient_Wellness_Schedule_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tPatient_Wellness_ScheduleID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tPatient_Wellness_Schedule_ID_LastModifiedBy");

                entity.HasOne(d => d.ID_Patient_WellnessNavigation)
                    .WithMany(p => p.tPatient_Wellness_Schedule)
                    .HasForeignKey(d => d.ID_Patient_Wellness)
                    .HasConstraintName("FKtPatient_Wellness_Schedule_ID_Patient_Wellness");
            });

            modelBuilder.Entity<tPatient_Wellness_Schedule_SMSStatus>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tPatient_Wellness_Schedule_SMSStatus)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tPatient_Wellness_Schedule_SMSStatus_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tPatient_Wellness_Schedule_SMSStatusID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tPatient_Wellness_Schedule_SMSStatus_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tPatient_Wellness_Schedule_SMSStatusID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tPatient_Wellness_Schedule_SMSStatus_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tPayable>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tPayable");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PaidAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.RemaningAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tPayable)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tPayable_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tPayableID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tPayable_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tPayableID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tPayable_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tPayablePayment>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tPayablePayment");

                entity.Property(e => e.CashAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tPayablePayment)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tPayablePayment_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tPayablePaymentID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tPayablePayment_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tPayablePaymentID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tPayablePayment_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tPayable_Detail>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tPayable_Detail");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tPayable_Detail)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tPayable_Detail_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tPayable_DetailID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tPayable_Detail_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tPayable_DetailID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tPayable_Detail_ID_LastModifiedBy");

                entity.HasOne(d => d.ID_PayableNavigation)
                    .WithMany(p => p.tPayable_Detail)
                    .HasForeignKey(d => d.ID_Payable)
                    .HasConstraintName("FKtPayable_Detail_ID_Payable");
            });

            modelBuilder.Entity<tPaymentMethod>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tPaymentMethod");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tPaymentMethod)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tPaymentMethod_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tPaymentMethodID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tPaymentMethod_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tPaymentMethodID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tPaymentMethod_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tPaymentTransaction>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tPaymentTransaction");

                entity.Property(e => e.CardAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CardHolderName)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.CashAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ChangeAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CheckAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CheckNumber)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreditAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.DateCanceled).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.GCashAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.GrossAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NetAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PayableAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PaymentAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ReferenceTransactionNumber)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.RemainingAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.VatAmount).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tPaymentTransaction)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tPaymentTransaction_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tPaymentTransactionID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tPaymentTransaction_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tPaymentTransactionID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tPaymentTransaction_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tPosition>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<tPurchaseOrder>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.DateCanceled).HasColumnType("datetime");

                entity.Property(e => e.DateCancelled).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateSubmitted).HasColumnType("datetime");

                entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DiscountRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DocumentDate).HasColumnType("date");

                entity.Property(e => e.GrossAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NetAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SubTotal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalGrossAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalNetAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalQuantity).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalVAT).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalVatAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.VatAmount).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.ID_ApprovedByNavigation)
                    .WithMany(p => p.tPurchaseOrderID_ApprovedByNavigation)
                    .HasForeignKey(d => d.ID_ApprovedBy)
                    .HasConstraintName("FKtPurchaseOrder_ID_ApprovedBy");

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tPurchaseOrder)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tPurchaseOrder_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tPurchaseOrderID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tPurchaseOrder_ID_CreatedBy");

                entity.HasOne(d => d.ID_FilingStatusNavigation)
                    .WithMany(p => p.tPurchaseOrder)
                    .HasForeignKey(d => d.ID_FilingStatus)
                    .HasConstraintName("FKtPurchaseOrder_ID_FilingStatus");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tPurchaseOrderID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tPurchaseOrder_ID_LastModifiedBy");

                entity.HasOne(d => d.ID_SupplierNavigation)
                    .WithMany(p => p.tPurchaseOrder)
                    .HasForeignKey(d => d.ID_Supplier)
                    .HasConstraintName("FKtPurchaseOrder_ID_Supplier");
            });

            modelBuilder.Entity<tPurchaseOrder_Detail>(entity =>
            {
                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.GrossAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NetAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UnitCost).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.VATAmount).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.ID_ItemNavigation)
                    .WithMany(p => p.tPurchaseOrder_Detail)
                    .HasForeignKey(d => d.ID_Item)
                    .HasConstraintName("FKtPurchaseOrder_Detail_ID_Item");

                entity.HasOne(d => d.ID_PurchaseOrderNavigation)
                    .WithMany(p => p.tPurchaseOrder_Detail)
                    .HasForeignKey(d => d.ID_PurchaseOrder)
                    .HasConstraintName("FKtPurchaseOrder_Detail_ID_PurchaseOrder");

                entity.HasOne(d => d.ID_UOMNavigation)
                    .WithMany(p => p.tPurchaseOrder_Detail)
                    .HasForeignKey(d => d.ID_UOM)
                    .HasConstraintName("FKtPurchaseOrder_Detail_ID_UOM");
            });

            modelBuilder.Entity<tQuestionType>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tQuestionType");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tQuestionType)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tQuestionType_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tQuestionTypeID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tQuestionType_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tQuestionTypeID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tQuestionType_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tReceivingReport>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tReceivingReport");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.DateCanceled).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DiscountRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.GrossAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NetAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SubTotal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.VatAmount).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tReceivingReport)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tReceivingReport_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tReceivingReportID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tReceivingReport_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tReceivingReportID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tReceivingReport_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tReceivingReport_Detail>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tReceivingReport_Detail");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tReceivingReport_Detail)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tReceivingReport_Detail_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tReceivingReport_DetailID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tReceivingReport_Detail_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tReceivingReport_DetailID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tReceivingReport_Detail_ID_LastModifiedBy");

                entity.HasOne(d => d.ID_ReceivingReportNavigation)
                    .WithMany(p => p.tReceivingReport_Detail)
                    .HasForeignKey(d => d.ID_ReceivingReport)
                    .HasConstraintName("FKtReceivingReport_Detail_ID_ReceivingReport");
            });

            modelBuilder.Entity<tRecurScheduleType>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tRecurScheduleType");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tRecurScheduleType)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tRecurScheduleType_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tRecurScheduleTypeID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tRecurScheduleType_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tRecurScheduleTypeID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tRecurScheduleType_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tSMSPatientSOAP_Company>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tSMSPatientSOAP_Company");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tSMSPatientSOAP_Company)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tSMSPatientSOAP_Company_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tSMSPatientSOAP_CompanyID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tSMSPatientSOAP_Company_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tSMSPatientSOAP_CompanyID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tSMSPatientSOAP_Company_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tSOAPType>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tSOAPType");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tSOAPType)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tSOAPType_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tSOAPTypeID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tSOAPType_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tSOAPTypeID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tSOAPType_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tSalesReturn>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tSalesReturn");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.DateCanceled).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tSalesReturn)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tSalesReturn_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tSalesReturnID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tSalesReturn_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tSalesReturnID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tSalesReturn_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tSalesReturn_Detail>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tSalesReturn_Detail");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DiscountRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tSalesReturn_Detail)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tSalesReturn_Detail_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tSalesReturn_DetailID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tSalesReturn_Detail_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tSalesReturn_DetailID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tSalesReturn_Detail_ID_LastModifiedBy");

                entity.HasOne(d => d.ID_SalesReturnNavigation)
                    .WithMany(p => p.tSalesReturn_Detail)
                    .HasForeignKey(d => d.ID_SalesReturn)
                    .HasConstraintName("FKtSalesReturn_Detail_ID_SalesReturn");
            });

            modelBuilder.Entity<tSample>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Code).IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.ContactNumber_Client).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateReturn).HasColumnType("datetime");

                entity.Property(e => e.DateSending).HasColumnType("datetime");

                entity.Property(e => e.Message).IsUnicode(false);

                entity.Property(e => e.Name_Client).IsUnicode(false);

                entity.Property(e => e.Name_Company).IsUnicode(false);

                entity.Property(e => e.Name_Item).IsUnicode(false);

                entity.Property(e => e.Oid_Model).IsUnicode(false);
            });

            modelBuilder.Entity<tSample1>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Code).IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.ContactNumber_Client).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateReturn).HasColumnType("datetime");

                entity.Property(e => e.DateSending).HasColumnType("datetime");

                entity.Property(e => e.Message).IsUnicode(false);

                entity.Property(e => e.Name_Client).IsUnicode(false);

                entity.Property(e => e.Name_Company).IsUnicode(false);

                entity.Property(e => e.Name_Item).IsUnicode(false);

                entity.Property(e => e.Oid_Model).IsUnicode(false);
            });

            modelBuilder.Entity<tSchedule>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateStart).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tSchedule)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tSchedule_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tScheduleID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tSchedule_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tScheduleID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tSchedule_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tScheduleType>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<tSchedule_PatientAppointment>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tSchedule_PatientAppointment");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.DateStart).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_ScheduleNavigation)
                    .WithMany(p => p.tSchedule_PatientAppointment)
                    .HasForeignKey(d => d.ID_Schedule)
                    .HasConstraintName("FKtSchedule_PatientAppointment_ID_Schedule");
            });

            modelBuilder.Entity<tServiceType>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tServiceType");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tServiceType)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tServiceType_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tServiceTypeID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tServiceType_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tServiceTypeID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tServiceType_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tSetting>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tSettingID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FKtSetting_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tSettingID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FKtSetting_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tStudent>(entity =>
            {
                entity.Property(e => e.Address)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.LastName)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tStudent)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tStudent_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tStudentID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tStudent_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tStudentID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tStudent_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tSupplier>(entity =>
            {
                entity.Property(e => e.Address)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.ContactDetail)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TINNumber)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tSupplier)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tSupplier_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tSupplierID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tSupplier_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tSupplierID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tSupplier_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tTaxScheme>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tTaxScheme)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tTaxScheme_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tTaxSchemeID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tTaxScheme_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tTaxSchemeID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tTaxScheme_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tTeacher>(entity =>
            {
                entity.Property(e => e.Address)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.LastName)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tTeacher)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tTeacher_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tTeacherID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tTeacher_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tTeacherID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tTeacher_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tTeethQuandrant>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tTeethQuandrant");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tTeethQuandrant)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tTeethQuandrant_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tTeethQuandrantID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tTeethQuandrant_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tTeethQuandrantID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tTeethQuandrant_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tTextBlast>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tTextBlast");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.DateCanceled).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Message)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tTextBlast)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tTextBlast_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tTextBlastID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tTextBlast_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tTextBlastID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tTextBlast_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tTextBlast_Client>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tTextBlast_Client");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateSent).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsSent).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tTextBlast_Client)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tTextBlast_Client_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tTextBlast_ClientID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tTextBlast_Client_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tTextBlast_ClientID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tTextBlast_Client_ID_LastModifiedBy");

                entity.HasOne(d => d.ID_TextBlastNavigation)
                    .WithMany(p => p.tTextBlast_Client)
                    .HasForeignKey(d => d.ID_TextBlast)
                    .HasConstraintName("FKtTextBlast_Client_ID_TextBlast");
            });

            modelBuilder.Entity<tTextBlast_Client_SMSStatus>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tTextBlast_Client_SMSStatus");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tTextBlast_Client_SMSStatus)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tTextBlast_Client_SMSStatus_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tTextBlast_Client_SMSStatusID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tTextBlast_Client_SMSStatus_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tTextBlast_Client_SMSStatusID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tTextBlast_Client_SMSStatus_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tTooth>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tTooth");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Location)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<tToothInfo>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tToothInfo");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IDs_ToothSurface)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tToothInfo)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tToothInfo_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tToothInfoID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tToothInfo_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tToothInfoID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tToothInfo_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tToothStatus>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tToothStatus");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tToothStatus)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tToothStatus_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tToothStatusID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tToothStatus_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tToothStatusID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tToothStatus_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tToothStatusType>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tToothStatusType");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tToothStatusType)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tToothStatusType_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tToothStatusTypeID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tToothStatusType_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tToothStatusTypeID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tToothStatusType_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tToothSurface>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tToothSurface");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tToothSurface)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tToothSurface_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tToothSurfaceID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tToothSurface_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tToothSurfaceID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tToothSurface_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tUnitOfMeasure>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tUnitOfMeasure)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tUnitOfMeasure_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tUnitOfMeasureID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tUnitOfMeasure_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tUnitOfMeasureID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tUnitOfMeasure_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tUser>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.InverseID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FKtUser_ID_CreatedBy");

                entity.HasOne(d => d.ID_EmployeeNavigation)
                    .WithMany(p => p.tUser)
                    .HasForeignKey(d => d.ID_Employee)
                    .HasConstraintName("FKtUser_ID_Employee");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.InverseID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FKtUser_ID_LastModifiedBy");

                entity.HasOne(d => d.ID_UserGroupNavigation)
                    .WithMany(p => p.tUser)
                    .HasForeignKey(d => d.ID_UserGroup)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKtUser_ID_UserGroup");
            });

            modelBuilder.Entity<tUserComment>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tUserCommentID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tUserComment_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tUserCommentID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tUserComment_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tUserGroup>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tUserGroupID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tUserGroup_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tUserGroupID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tUserGroup_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tUserRole>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tUserRoleID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tUserRole_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tUserRoleID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tUserRole_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tUserRole_Detail>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.ID_Model)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_UserRoleNavigation)
                    .WithMany(p => p.tUserRole_Detail)
                    .HasForeignKey(d => d.ID_UserRole)
                    .HasConstraintName("FKtUserRole_Detail_ID_UserRole");
            });

            modelBuilder.Entity<tUserRole_Reports>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tUserRole_Reports");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.ID_Report)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_UserRoleNavigation)
                    .WithMany(p => p.tUserRole_Reports)
                    .HasForeignKey(d => d.ID_UserRole)
                    .HasConstraintName("FKtUserRole_Reports_ID_UserRole");
            });

            modelBuilder.Entity<tUserSession>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_UserNavigation)
                    .WithMany(p => p.tUserSession)
                    .HasForeignKey(d => d.ID_User)
                    .HasConstraintName("FKtUserSession_ID_User");

                entity.HasOne(d => d.ID_WarehouseNavigation)
                    .WithMany(p => p.tUserSession)
                    .HasForeignKey(d => d.ID_Warehouse)
                    .HasConstraintName("FKtUserSession_ID_Warehouse");
            });

            modelBuilder.Entity<tUser_Favorite>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_NavigationNavigation)
                    .WithMany(p => p.tUser_Favorite)
                    .HasForeignKey(d => d.ID_Navigation)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKtUser_Favorite_ID_Navigation");

                entity.HasOne(d => d.ID_UserNavigation)
                    .WithMany(p => p.tUser_Favorite)
                    .HasForeignKey(d => d.ID_User)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKtUser_Favorite_ID_User");
            });

            modelBuilder.Entity<tUser_Roles>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tUser_Roles");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_UserNavigation)
                    .WithMany(p => p.tUser_Roles)
                    .HasForeignKey(d => d.ID_User)
                    .HasConstraintName("FKtUser_Roles_ID_User");

                entity.HasOne(d => d.ID_UserRoleNavigation)
                    .WithMany(p => p.tUser_Roles)
                    .HasForeignKey(d => d.ID_UserRole)
                    .HasConstraintName("FKtUser_Roles_ID_UserRole");
            });

            modelBuilder.Entity<tVeterinaryCertificate>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tVeterinaryCertificate");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateVaccinated).HasColumnType("datetime");

                entity.Property(e => e.DestinationAddress)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.LotNumber)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PatientDateBirth).HasColumnType("datetime");

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tVeterinaryCertificate)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tVeterinaryCertificate_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tVeterinaryCertificateID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tVeterinaryCertificate_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tVeterinaryCertificateID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tVeterinaryCertificate_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tVeterinaryHealthCertificate>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tVeterinaryHealthCertificate");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Color)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateCanceled).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateVaccinated).HasColumnType("datetime");

                entity.Property(e => e.DestinationAddress)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.LotNumber)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PatientDateBirth).HasColumnType("datetime");

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Weight)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tVeterinaryHealthCertificate)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tVeterinaryHealthCertificate_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tVeterinaryHealthCertificateID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tVeterinaryHealthCertificate_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tVeterinaryHealthCertificateID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tVeterinaryHealthCertificate_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tViewType>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("IX_tViewType");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CompanyNavigation)
                    .WithMany(p => p.tViewType)
                    .HasForeignKey(d => d.ID_Company)
                    .HasConstraintName("FK_tViewType_ID_Company");

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tViewTypeID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tViewType_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tViewTypeID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tViewType_ID_LastModifiedBy");
            });

            modelBuilder.Entity<tWarehouse>(entity =>
            {
                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.ID_CreatedByNavigation)
                    .WithMany(p => p.tWarehouseID_CreatedByNavigation)
                    .HasForeignKey(d => d.ID_CreatedBy)
                    .HasConstraintName("FK_tWarehouse_ID_CreatedBy");

                entity.HasOne(d => d.ID_LastModifiedByNavigation)
                    .WithMany(p => p.tWarehouseID_LastModifiedByNavigation)
                    .HasForeignKey(d => d.ID_LastModifiedBy)
                    .HasConstraintName("FK_tWarehouse_ID_LastModifiedBy");

                entity.HasOne(d => d.ID_WarehouseNavigation)
                    .WithMany(p => p.InverseID_WarehouseNavigation)
                    .HasForeignKey(d => d.ID_Warehouse)
                    .HasConstraintName("FKtWarehouse_ID_Warehouse");
            });

            modelBuilder.Entity<vActiveItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vActiveItem");

                entity.Property(e => e.BarCode)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy_Name_User)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CustomCode)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.FormattedCurrentInventoryCount).HasMaxLength(4000);

                entity.Property(e => e.LastModifiedBy_Name_User)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_InventoryStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_ItemCategory)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_ItemType)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OtherInfo_DateExpiration).HasColumnType("datetime");

                entity.Property(e => e.RemainingBeforeExpired).IsUnicode(false);

                entity.Property(e => e.UnitCost).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e._tempSupplier)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vAppSetting>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vAppSetting");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ColorValue)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateTimeValue).HasColumnType("datetime");

                entity.Property(e => e.DecimalValue).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ImageValue)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.StringValue)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vAppointment>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vAppointment");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateStart).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vAppointmentEvent>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vAppointmentEvent");

                entity.Property(e => e.Appointment_CancellationRemarks)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Appointment_Name_FilingStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNumber).IsUnicode(false);

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.DateStart).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.FormattedDateEnd).HasMaxLength(4000);

                entity.Property(e => e.FormattedDateEndTime).HasMaxLength(4000);

                entity.Property(e => e.FormattedDateStart).HasMaxLength(4000);

                entity.Property(e => e.FormattedDateStartTime).HasMaxLength(4000);

                entity.Property(e => e.ID).IsUnicode(false);

                entity.Property(e => e.Name_Client)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Name_FilingStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Model)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Patient)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Paticular)
                    .HasMaxLength(2203)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeCoverage)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueID).IsUnicode(false);
            });

            modelBuilder.Entity<vAppointmentRequest>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vAppointmentRequest");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateStart).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Patient)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Reason)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vAppointmentSchedule>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vAppointmentSchedule");

                entity.Property(e => e.AppointmentStatus_Name_FilingStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateStart).HasColumnType("datetime");

                entity.Property(e => e.Doctor)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_ServiceType)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Patient)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ScheduleType)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vAppointmentStatusLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vAppointmentStatusLog");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Oid_Model)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vAppointment_FilingStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vAppointment_FilingStatus");

                entity.Property(e => e.ID).ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vApproverMatrix>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vApproverMatrix");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vApproverMatrix_Detail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vApproverMatrix_Detail");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vAttendingVeterinarian>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vAttendingVeterinarian");

                entity.Property(e => e.Name)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Position)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vAttendingVeterinarianForBillingINvoice>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vAttendingVeterinarianForBillingINvoice");

                entity.Property(e => e.Name)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Position)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vAuditTrail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vAuditTrail");

                entity.Property(e => e.AuditType)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ID_CurrentObject)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.User)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vAvailableModules>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vAvailableModules");

                entity.Property(e => e.Name)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Oid)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vBillingInvoice>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vBillingInvoice");

                entity.Property(e => e.ApprovedBy_Name_User)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AttendingPhysician_Name_Employee)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.CanceledBy_Name_User)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.Company)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ConfinementDepositAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ConsumedDepositAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CreatedBy_Name_User)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.DateApprovedString)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateCanceled).HasColumnType("datetime");

                entity.Property(e => e.DateCanceledString)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateCreatedString)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateModifiedString)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateString)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Discount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DiscountRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.GrossAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.InitialSubtotalAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.LastModifiedBy_Name_User)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Client)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Name_FilingStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Patient)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Name_SOAPType)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_TaxScheme)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NetAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PatientNames)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Payment_Name_FilingStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RemainingAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.RemainingDepositAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Status)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SubTotal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalItemDiscountAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.VatAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.VatPercentage).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.WalkInCustomerName)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vBillingInvoiceWalkIn>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vBillingInvoiceWalkIn");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vBillingInvoiceWalkInList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vBillingInvoiceWalkInList");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vBillingInvoice_Detail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vBillingInvoice_Detail");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateExpiration).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DiscountRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Item)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UnitCost).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<vBillingInvoice_Patient>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vBillingInvoice_Patient");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Patient)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vBreedSpecie>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vBreedSpecie");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vCardType>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vCardType");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vCaseType>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vCaseType");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vClient>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vClient");

                entity.Property(e => e.Address)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNumber2)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentCreditAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateLastVisited).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.tempID)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vClientDeposit>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vClientDeposit");

                entity.Property(e => e.ApprovedBy_Name_User)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CanceledBy_Name_User)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Code_Patient_Confinement)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.DateCanceled).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DepositAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Client)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Name_FilingStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Patient)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vClientWithdraw>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vClientWithdraw");

                entity.Property(e => e.ApprovedBy_Name_User)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CanceledBy_Name_User)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Code_Patient_Confinement)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.DateCanceled).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Client)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Name_FilingStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Patient)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.WithdrawAmount).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<vClient_CreditLogs>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vClient_CreditLogs");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreditAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vClient_ListView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vClient_ListView");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNumbers)
                    .IsRequired()
                    .HasMaxLength(603)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateLastVisited).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(2000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vCompany>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vCompany");

                entity.Property(e => e.Address)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ImageHeaderFilename)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ImageHeaderLocationFilenamePath)
                    .HasMaxLength(352)
                    .IsUnicode(false);

                entity.Property(e => e.ImageHeaderThumbNameLocationFilenamePath)
                    .HasMaxLength(356)
                    .IsUnicode(false);

                entity.Property(e => e.ImageLogoFilename)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ImageLogoLocationFilenamePath)
                    .HasMaxLength(352)
                    .IsUnicode(false);

                entity.Property(e => e.ImageLogoThumbNameLocationFilenamePath)
                    .HasMaxLength(356)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.POSReceiptFontSize)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SOAPPlanSMSMessage)
                    .HasMaxLength(700)
                    .IsUnicode(false);

                entity.Property(e => e.SecurityPIN)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vCompanyInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vCompanyInfo");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vCompanyTextBlastTemplate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vCompanyTextBlastTemplate");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Template)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vCompany_Subscription>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vCompany_Subscription");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateStart).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vCountry>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vCountry");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vCustomDetailViewRoute>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vCustomDetailViewRoute");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Oid_DetailView)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.RouterLink)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vCustomNavigationLink>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vCustomNavigationLink");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Oid_ListView)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Oid_Report)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.RouterLink)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vDatabaseMemoryLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDatabaseMemoryLog");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vDentalExamination>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDentalExamination");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vDentition>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDentition");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vDetailView_Detail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDetailView_Detail");

                entity.Property(e => e.Caption)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DataSource)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DisplayExpr)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayProperty)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Format)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InputMask)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LookUp_ListView_Caption)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LookUp_ListView_DataSource)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ModelProperty)
                    .HasMaxLength(402)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SearchExpr)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ValueExpr)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vDetailView_Detail_Link>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDetailView_Detail_Link");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vDocumentSeries>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDocumentSeries");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Prefix)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vDocumentStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vDocumentStatus");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vEmployee>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vEmployee");

                entity.Property(e => e.Code)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DatePRCExpiration).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.FullAddress)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ID_EmployeeStatus)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ID_Gender)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ImageFile)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Position)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PRCLicenseNumber)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.PTR)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.S2)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.TINNumber)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vEmployeeInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vEmployeeInfo");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vEmployeePosition>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vEmployeePosition");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vEmployee_ListView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vEmployee_ListView");

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.FullAddress)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Position)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vEmploymentStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vEmploymentStatus");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vExpenseCategory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vExpenseCategory");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vFileUpload>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vFileUpload");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.FileName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ID_CurrentObject)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Path)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vFilingStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vFilingStatus");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vForBilling>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vForBilling");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vForBilling_ListView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vForBilling_ListView");

                entity.Property(e => e.BillingInvoice_Name_FilingStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Name_Client)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Patient)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.RefNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e._1)
                    .HasColumnName("1")
                    .HasMaxLength(4000);

                entity.Property(e => e._10)
                    .HasColumnName("10")
                    .HasMaxLength(4000);

                entity.Property(e => e._2)
                    .HasColumnName("2")
                    .HasMaxLength(4000);

                entity.Property(e => e._3)
                    .HasColumnName("3")
                    .HasMaxLength(4000);

                entity.Property(e => e._4)
                    .HasColumnName("4")
                    .HasMaxLength(4000);

                entity.Property(e => e._5)
                    .HasColumnName("5")
                    .HasMaxLength(4000);

                entity.Property(e => e._6)
                    .HasColumnName("6")
                    .HasMaxLength(4000);

                entity.Property(e => e._7)
                    .HasColumnName("7")
                    .HasMaxLength(4000);

                entity.Property(e => e._8)
                    .HasColumnName("8")
                    .HasMaxLength(4000);

                entity.Property(e => e._9)
                    .HasColumnName("9")
                    .HasMaxLength(4000);
            });

            modelBuilder.Entity<vHelpDeskVideoTutorial>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vHelpDeskVideoTutorial");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SearcgTag)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SearchTag)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ThumbnailImage)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.VideoLink)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vITextMoAPISMSStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vITextMoAPISMSStatus");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vInventory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vInventory");

                entity.Property(e => e.Name_InventoryStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Item)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.colorStatus)
                    .IsRequired()
                    .HasMaxLength(7)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vInventoryStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vInventoryStatus");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vInventorySummary>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vInventorySummary");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vInventoryTrail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vInventoryTrail");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateExpired).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateString)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_FilingStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Item)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<vIssueTracker>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vIssueTracker");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DeveloperSide)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Issue)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_ApprovedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_FilingStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Solution)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vItem");

                entity.Property(e => e.BarCode)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy_Name_User)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CustomCode)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy_Name_User)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_InventoryStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_ItemCategory)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_ItemType)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OtherInfo_DateExpiration).HasColumnType("datetime");

                entity.Property(e => e.UnitCost).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e._tempSupplier)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vItemCategory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vItemCategory");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy_Name_User)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy_Name_User)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vItemInventoriable>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vItemInventoriable");

                entity.Property(e => e.BarCode)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CustomCode)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.FormattedCurrentInventoryCount).HasMaxLength(4000);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OtherInfo_DateExpiration).HasColumnType("datetime");

                entity.Property(e => e.RemainingBeforeExpired).IsUnicode(false);

                entity.Property(e => e.UnitCost).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e._tempSupplier)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vItemInventoriableForBillingLookUp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vItemInventoriableForBillingLookUp");

                entity.Property(e => e.FormattedCurrentInventoryCount).HasMaxLength(4000);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OtherInfo_DateExpiration).HasColumnType("datetime");

                entity.Property(e => e.RemainingBeforeExpired).IsUnicode(false);

                entity.Property(e => e.UnitCost).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<vItemInventoriableLookUp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vItemInventoriableLookUp");

                entity.Property(e => e.FormattedCurrentInventoryCount).HasMaxLength(4000);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UnitCost).HasMaxLength(4000);

                entity.Property(e => e.UnitPrice).HasMaxLength(4000);
            });

            modelBuilder.Entity<vItemInventoriable_ListvIew>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vItemInventoriable_ListvIew");

                entity.Property(e => e.DateExpired).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_InventoryStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RemainingBeforeExpired).IsUnicode(false);
            });

            modelBuilder.Entity<vItemService>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vItemService");

                entity.Property(e => e.BarCode)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CustomCode)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OtherInfo_DateExpiration).HasColumnType("datetime");

                entity.Property(e => e.UnitCost).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e._tempSupplier)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vItemServiceLookUp>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vItemServiceLookUp");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UnitCost).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<vItemService_Listview>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vItemService_Listview");

                entity.Property(e => e.ID).ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<vItemType>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vItemType");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vItem_UnitCostLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vItem_UnitCostLog");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<vItem_UnitPriceLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vItem_UnitPriceLog");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<vLastestMessageRecipient>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vLastestMessageRecipient");

                entity.Property(e => e.LastDateSent).HasColumnType("datetime");

                entity.Property(e => e.Recipient_Name_User)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Sender_Name_User)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vLastestPatientWaitingList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vLastestPatientWaitingList");

                entity.Property(e => e.BillingInvoice_Name_FilingStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Client)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Patient)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.WaitingStatus_Name_FilingStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vListView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vListView");

                entity.Property(e => e.Caption)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DataSource)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.JsController)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vLocalShippingPermitIssuance>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vLocalShippingPermitIssuance");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DestinationBarangay)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationContactNumber)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationEstablishment)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationFullAddress)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationMunicipality)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationProvince)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationSender)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModeOfTransfortationAirCarrierType)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ModeOfTransfortationAirPlateNumber)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ModeOfTransfortationLandCarrierType)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ModeOfTransfortationLandPlateNumber)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ModeOfTransfortationWaterCarrierType)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ModeOfTransfortationWaterPlateNumber)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_FilingStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OriginBarangay)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.OriginContactNumber)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.OriginEstablishment)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.OriginFullAddress)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.OriginMunicipality)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.OriginProvince)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.OriginSender)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ProposedArrivalDate).HasColumnType("datetime");

                entity.Property(e => e.ProposedShippingDate).HasColumnType("datetime");

                entity.Property(e => e.ShippingAccredationNumber)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddress)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingCategory)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingCountryOrigin)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingLicenceNumber)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingProductSource)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingPurpose)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingShipper)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingSource)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vLocalShippingPermitIssuance_Item>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vLocalShippingPermitIssuance_Item");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vLocalShippingPermitIssuance_Requirement>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vLocalShippingPermitIssuance_Requirement");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.ImageLocation)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.IssuedBy)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PRCLicenseNo)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vMedicalHistoryQuestionnaire>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vMedicalHistoryQuestionnaire");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_QuestionType)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vMedicationRoute>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vMedicationRoute");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vMessage>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vMessage");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Recipient_Name_User)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vMessageThread>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vMessageThread");

                entity.Property(e => e.DateRead).HasColumnType("datetime");

                entity.Property(e => e.DateSent).HasColumnType("datetime");

                entity.Property(e => e.Message)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.Recipient_Name_User)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Sender_Name_User)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vModelReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vModelReport");

                entity.Property(e => e.Name_Company)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Model)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_ModelReport)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Report)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Oid_Model)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Oid_Report)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vModel_Property>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vModel_Property");

                entity.Property(e => e.Caption)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DefaultValue)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayProperty)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vNavigation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vNavigation");

                entity.Property(e => e.Caption)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Icon)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Route)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vNonSystemUseEmployee>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vNonSystemUseEmployee");

                entity.Property(e => e.Code)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DatePRCExpiration).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.FullAddress)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ID_EmployeeStatus)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ID_Gender)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ImageFile)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Position)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PRCLicenseNumber)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.PTR)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.S2)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.TINNumber)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vOverallLatestMessageRecipient>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vOverallLatestMessageRecipient");

                entity.Property(e => e.LastDateSent).HasColumnType("datetime");

                entity.Property(e => e.Recipient_Name_User)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Sender_Name_User)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vPatient>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPatient");

                entity.Property(e => e.AnimalWellness)
                    .HasMaxLength(7000)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentCreditAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CustomCode)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DateBirth).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateDeceased).HasColumnType("datetime");

                entity.Property(e => e.DateLastVisited).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.FullAddress)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .HasMaxLength(903)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Microchip)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Client)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Gender)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneCode_Country)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProfileImageFile)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ProfileImageLocationFile)
                    .IsRequired()
                    .HasMaxLength(352)
                    .IsUnicode(false);

                entity.Property(e => e.ProfileImageThumbnailLocationFile)
                    .IsRequired()
                    .HasMaxLength(356)
                    .IsUnicode(false);

                entity.Property(e => e.Species)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.WaitingStatus_Name_FilingStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vPatientAppointment>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPatientAppointment");

                entity.Property(e => e.Appointment_CancellationRemarks)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Appointment_Name_FilingStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCanceled).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateDone).HasColumnType("datetime");

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.DateEndString)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateStart).HasColumnType("datetime");

                entity.Property(e => e.DateStartString)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Client)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Name_FilingStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Patient)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_SOAPType)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vPatientSOAPList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPatientSOAPList");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vPatientWaitingList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPatientWaitingList");

                entity.Property(e => e.BillingInvoice_Name_FilingStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Client)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Patient)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.WaitingStatus_Name_FilingStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vPatientWaitingList_ListView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPatientWaitingList_ListView");

                entity.Property(e => e.BillingInvoice_Name_FilingStatus)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.Name_Client)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Patient)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.WaitingStatus_Name_FilingStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vPatientWaitingList_Logs>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPatientWaitingList_Logs");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vPatient_BirthDateSMSGreetingLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPatient_BirthDateSMSGreetingLog");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateSent).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Message)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vPatient_Confinement>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPatient_Confinement");

                entity.Property(e => e.BillingInvoice_Name_FilingStatus)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateCanceled).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateDischarge).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Client)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Name_FilingStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Patient)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.PatientNames)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.SubTotal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<vPatient_Confinement_ItemsServices>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPatient_Confinement_ItemsServices");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CommentHTML).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateExpiration).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Item)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Patient)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Route)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.UnitCost).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<vPatient_Confinement_Listview>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPatient_Confinement_Listview");

                entity.Property(e => e.BillingInvoice_Name_FilingStatus)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConfinementDays).IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateDischarge).HasColumnType("datetime");

                entity.Property(e => e.Name_Client)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Name_FilingStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Patient)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vPatient_Confinement_MaxSOAP>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPatient_Confinement_MaxSOAP");

                entity.Property(e => e.MaxDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<vPatient_Confinement_Patient>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPatient_Confinement_Patient");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Patient)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vPatient_CreditLogs>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPatient_CreditLogs");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreditAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vPatient_DentalExamination>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPatient_DentalExamination");

                entity.Property(e => e.ApprovedBy_Name_User)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateString)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Dentition)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Doctor)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Dentition)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Doctor)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Name_FilingStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Patient)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Patient)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vPatient_DentalExamination_Image>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPatient_DentalExamination_Image");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.ImageValue)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vPatient_DentalExamination_MedicalHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPatient_DentalExamination_MedicalHistory");

                entity.Property(e => e.Answer)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vPatient_DentalExamination_ToothInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPatient_DentalExamination_ToothInfo");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Code_ToothStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IDs_ToothSurface)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Location_Tooth)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_ToothStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vPatient_History>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPatient_History");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateString)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Doctor)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Name_FilingStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vPatient_ListView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPatient_ListView");

                entity.Property(e => e.Code)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DateLastVisited).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LabelActionQueue)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Client)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Gender)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProfileImageThumbnailLocationFile)
                    .IsRequired()
                    .HasMaxLength(356)
                    .IsUnicode(false);

                entity.Property(e => e.Species)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.WaitingStatus_Name_FilingStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vPatient_Lodging>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPatient_Lodging");

                entity.Property(e => e.AdvancedPaymentAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ChangeAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DateCheckIn).HasColumnType("datetime");

                entity.Property(e => e.DateCheckOut).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateStart).HasColumnType("datetime");

                entity.Property(e => e.HourCount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Client)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Name_FilingStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Patient)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PayableAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PaymentAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.RateAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.RemainingAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<vPatient_Lodging_Listview>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPatient_Lodging_Listview");

                entity.Property(e => e.DateCheckIn).HasColumnType("datetime");

                entity.Property(e => e.DateCheckOut).HasColumnType("datetime");

                entity.Property(e => e.HourCount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Name_Client)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Name_FilingStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Patient)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PayableAmount).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<vPatient_SOAP>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPatient_SOAP");

                entity.Property(e => e.Assessment)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.AttendingPhysician_Name_Employee)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.BillingInvoice_Name_FilingStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CaseType)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ClientCommunication)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.ClinicalExamination)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Code_Patient_Confinement)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.ContactNumber_Client)
                    .HasMaxLength(601)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.DateCanceled).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateDischarge_Patient_Confinement).HasColumnType("datetime");

                entity.Property(e => e.DateDone).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateString)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Date_Patient_Confinement).HasColumnType("datetime");

                entity.Property(e => e.Diagnosis)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.DiagnosisHTML)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.History)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Interpretation)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageFilePath01)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageFilePath02)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageFilePath03)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageFilePath04)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageFilePath05)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageFilePath06)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageFilePath07)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageFilePath08)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageFilePath09)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageFilePath10)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageFilePath11)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageFilePath12)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageFilePath13)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageFilePath14)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageFilePath15)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageRemark01)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageRemark02)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageRemark03)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageRemark04)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageRemark05)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageRemark06)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageRemark07)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageRemark08)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageRemark09)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageRemark10)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageRemark11)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageRemark12)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageRemark13)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageRemark14)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageRemark15)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageRowIndex01)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageRowIndex02)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageRowIndex03)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageRowIndex04)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageRowIndex05)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageRowIndex06)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageRowIndex07)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageRowIndex08)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageRowIndex09)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageRowIndex10)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageRowIndex11)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageRowIndex12)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageRowIndex13)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageRowIndex14)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LabImageRowIndex15)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_ApprovedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_CanceledBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Client)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Name_CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_FilingStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_FilingStatus_Patient_Confinement)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Patient)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_SOAPType)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Objective)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Planning)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Prescription)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Subjective)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Treatment)
                    .HasMaxLength(3000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vPatient_SOAP_LaboratoryImages>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPatient_SOAP_LaboratoryImages");

                entity.Property(e => e.FilePath)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.ID_Patient_SOAP).ValueGeneratedOnAdd();

                entity.Property(e => e.ImageNo)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ImageRowIndex)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasMaxLength(3000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vPatient_SOAP_LaboratoryImages_Count>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPatient_SOAP_LaboratoryImages_Count");

                entity.Property(e => e.ID_Patient_SOAP).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<vPatient_SOAP_ListView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPatient_SOAP_ListView");

                entity.Property(e => e.AttendingPhysician_Name_Employee)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ClientCommunication)
                    .IsRequired()
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.ClinicalExamination)
                    .IsRequired()
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Diagnosis)
                    .IsRequired()
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.History)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Interpretation)
                    .IsRequired()
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Client)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Name_FilingStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Patient)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_SOAPType)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Prescription)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.TooltipText).HasMaxLength(4000);

                entity.Property(e => e.Treatment)
                    .IsRequired()
                    .HasMaxLength(3000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vPatient_SOAP_Plan>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPatient_SOAP_Plan");

                entity.Property(e => e.Appointment_CancellationRemarks)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Appointment_Name_FilingStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CustomItem)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateReturn).HasColumnType("datetime");

                entity.Property(e => e.DateSent).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Item)
                    .HasMaxLength(503)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vPatient_SOAP_Plan_Count>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPatient_SOAP_Plan_Count");
            });

            modelBuilder.Entity<vPatient_SOAP_Prescription>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPatient_SOAP_Prescription");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateExpiration).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Item)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UnitCost).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<vPatient_SOAP_Prescription_Count>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPatient_SOAP_Prescription_Count");
            });

            modelBuilder.Entity<vPatient_SOAP_SMSStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPatient_SOAP_SMSStatus");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vPatient_SOAP_Treatment>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPatient_SOAP_Treatment");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateExpiration).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Item)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UnitCost).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<vPatient_Vaccination>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPatient_Vaccination");

                entity.Property(e => e.Appointment_CancellationRemarks)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.AttendingPhysician)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.AttendingPhysician_Name_Employee)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateCanceled).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateExpiration).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.HeartRate)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Client)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Name_FilingStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Item)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Patient)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Temparature)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.UnitCost).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Weight)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vPatient_Vaccination_Listview>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPatient_Vaccination_Listview");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateExpiration).HasColumnType("datetime");

                entity.Property(e => e.Name_Client)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Name_FilingStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Item)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Patient)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vPatient_Vaccination_Schedule>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPatient_Vaccination_Schedule");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CustomItem)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateSent).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vPatient_Wellness>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPatient_Wellness");

                entity.Property(e => e.AttendingPhysician)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.AttendingPhysician_Name_Employee)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateCanceled).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Client)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Name_FilingStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Patient)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vPatient_Wellness_Detail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPatient_Wellness_Detail");

                entity.Property(e => e.Appointment_CancellationRemarks)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CustomItem)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateExpiration).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Item)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UnitCost).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<vPatient_Wellness_DetailSchedule>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPatient_Wellness_DetailSchedule");

                entity.Property(e => e.Appointment_CancellationRemarks)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Appointment_Name_FilingStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment_Patient_Wellness_Detail).IsUnicode(false);

                entity.Property(e => e.DateCreated_Patient_Wellness_Detail).HasColumnType("datetime");

                entity.Property(e => e.DateSent).HasColumnType("datetime");

                entity.Property(e => e.Date_Patient_Wellness_Schedule).HasColumnType("datetime");

                entity.Property(e => e.Name_Item_Patient_Wellness_Detail).IsUnicode(false);
            });

            modelBuilder.Entity<vPatient_Wellness_Detail_Listview>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPatient_Wellness_Detail_Listview");

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Name_Item)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vPatient_Wellness_Listview>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPatient_Wellness_Listview");

                entity.Property(e => e.AttendingPhysician_Name_Employee)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Name_Client)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Name_FilingStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Patient)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vPatient_Wellness_Schedule>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPatient_Wellness_Schedule");

                entity.Property(e => e.Appointment_CancellationRemarks)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateSent).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vPayable>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPayable");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PaidAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Payment_Name_FilingStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RemaningAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<vPayablePayment>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPayablePayment");

                entity.Property(e => e.CashAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<vPayable_Detail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPayable_Detail");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vPayable_PayableDetail_Listview>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPayable_PayableDetail_Listview");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Name_ExpenseCategory)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Payable_Detail)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PaidAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Payment_Name_FilingStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RemaningAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<vPaymentMethod>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPaymentMethod");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vPaymentTransaction>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPaymentTransaction");

                entity.Property(e => e.ApprovedBy_Name_User)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CanceledBy_Name_User)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CardAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CardHolderName)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.CardNumber)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.CashAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ChangeAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CheckAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CheckNumber)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreditAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.DateApprovedString)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateCanceled).HasColumnType("datetime");

                entity.Property(e => e.DateCanceledString)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateCreatedString)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateModifiedString)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateString)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GCashAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.GrossAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.GrossAmount_BillingInvoice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_CardType)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Client)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Name_FilingStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Patient)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Name_PaymentMethod)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_TaxScheme)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NetAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.NetAmount_BillingInvoice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PayableAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PaymentAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ReferenceTransactionNumber)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.RemainingAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.RemainingAmount_BillingInvoice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.VatAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.VatAmount_BillingInvoice).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<vPosition>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPosition");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vPurchaseOrder>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPurchaseOrder");

                entity.Property(e => e.ApprovedBy_Name_User)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CanceledBy_Name_User)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy_Name_User)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.DateApprovedString)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateCanceled).HasColumnType("datetime");

                entity.Property(e => e.DateCanceledString)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateCancelled).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateCreatedString)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateModifiedString)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateString)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateSubmitted).HasColumnType("datetime");

                entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DiscountRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DocumentDate).HasColumnType("date");

                entity.Property(e => e.GrossAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.LastModifiedBy_Name_User)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_FilingStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Supplier)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_TaxScheme)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NetAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ServingStatus_Name_FilingStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SubTotal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalGrossAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalNetAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalQuantity).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalVAT).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalVatAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.VatAmount).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<vPurchaseOrder_Detail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPurchaseOrder_Detail");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.GrossAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Item)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Item)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_UOM)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NetAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UOM)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UnitCost).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.VATAmount).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<vPurchaseOrder_Listview>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPurchaseOrder_Listview");

                entity.Property(e => e.ApprovedBy_Name_User)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CanceledBy_Name_User)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy_Name_User)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.DateApprovedString)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateCanceled).HasColumnType("datetime");

                entity.Property(e => e.DateCanceledString)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateCreatedString)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateModifiedString)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateString)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.GrossAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.LastModifiedBy_Name_User)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_FilingStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Supplier)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NetAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ServingStatus_Name_FilingStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.VatAmount).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<vQuestionType>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vQuestionType");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vReceivingReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vReceivingReport");

                entity.Property(e => e.ApprovedBy_Name_User)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CanceledBy_Name_User)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Code_PurchaseOrder)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.Company)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy_Name_User)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.DateApprovedString)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateCanceled).HasColumnType("datetime");

                entity.Property(e => e.DateCanceledString)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateCreatedString)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateModifiedString)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DateString)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DiscountRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.GrossAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.LastModifiedBy_Name_User)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_FilingStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Supplier)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_TaxScheme)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NetAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ServingStatus_Name_FilingStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SubTotal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.VatAmount).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<vReceivingReport_Detail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vReceivingReport_Detail");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Item)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<vRecurScheduleType>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vRecurScheduleType");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vRemainingQuantityPurchaseOrderDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vRemainingQuantityPurchaseOrderDetail");

                entity.Property(e => e.Name_FilingStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Item)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ServingStatus_Name_FilingStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<vRpt_ItemList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vRpt_ItemList");

                entity.Property(e => e.Address_Company)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.ImageLogoLocationFilenamePath)
                    .HasMaxLength(352)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Company)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vSMSCountPerCompany>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSMSCountPerCompany");

                entity.Property(e => e.DateSchedule).HasColumnType("datetime");
            });

            modelBuilder.Entity<vSMSCountPerCompany_Patient_SOAP_Plan>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSMSCountPerCompany_Patient_SOAP_Plan");

                entity.Property(e => e.DateSent).HasColumnType("date");
            });

            modelBuilder.Entity<vSMSCountPerCompany_Patient_Vaccination_Schedule>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSMSCountPerCompany_Patient_Vaccination_Schedule");

                entity.Property(e => e.DateSent).HasColumnType("date");
            });

            modelBuilder.Entity<vSMSList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSMSList");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DateSending).HasColumnType("datetime");

                entity.Property(e => e.DateSent).HasColumnType("datetime");

                entity.Property(e => e.Message).IsUnicode(false);

                entity.Property(e => e.Name_Client)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Patient)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vSMSList_Patient_SOAP_Plan>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSMSList_Patient_SOAP_Plan");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DateSending).HasColumnType("datetime");

                entity.Property(e => e.DateSent).HasColumnType("datetime");

                entity.Property(e => e.Message).IsUnicode(false);

                entity.Property(e => e.Name_Client)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Patient)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vSMSList_Patient_Vaccination_Schedule>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSMSList_Patient_Vaccination_Schedule");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DateSending).HasColumnType("datetime");

                entity.Property(e => e.DateSent).HasColumnType("datetime");

                entity.Property(e => e.Message).IsUnicode(false);

                entity.Property(e => e.Name_Client)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Patient)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vSMSList_Patient_Wellness_DetailSchedule>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSMSList_Patient_Wellness_DetailSchedule");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DateSending).HasColumnType("datetime");

                entity.Property(e => e.DateSent).HasColumnType("datetime");

                entity.Property(e => e.Message).IsUnicode(false);

                entity.Property(e => e.Name_Client)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Patient)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vSMSPatientSOAP_Company>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSMSPatientSOAP_Company");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vSOAPType>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSOAPType");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vSalesReturn>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSalesReturn");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.DateCanceled).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_FilingStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vSalesReturn_Detail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSalesReturn_Detail");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DiscountRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Item)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<vSalesReturn_ListView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSalesReturn_ListView");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Name_Item)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<vSchedule>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSchedule");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateEnd).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateStart).HasColumnType("datetime");

                entity.Property(e => e.Doctor)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.FormattedDateEnd).HasMaxLength(4000);

                entity.Property(e => e.FormattedDateStart).HasMaxLength(4000);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_ServiceType)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ScheduleType)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vSentSMSRecord>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSentSMSRecord");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateSchedule).HasColumnType("datetime");

                entity.Property(e => e.DateSending).HasColumnType("date");

                entity.Property(e => e.DateSent).HasColumnType("date");
            });

            modelBuilder.Entity<vServiceType>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vServiceType");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vStudent>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vStudent");

                entity.Property(e => e.Address)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vSupplier>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vSupplier");

                entity.Property(e => e.Address)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.ContactDetail)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TINNumber)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vTaxScheme>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vTaxScheme");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vTeacher>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vTeacher");

                entity.Property(e => e.Address)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vTeethQuandrant>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vTeethQuandrant");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vTextBlast>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vTextBlast");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.DateCanceled).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Message)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_FilingStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vTextBlast_Client>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vTextBlast_Client");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateSent).HasColumnType("datetime");

                entity.Property(e => e.IsSent).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Client)
                    .HasMaxLength(2000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vTextBlast_Client_SMSStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vTextBlast_Client_SMSStatus");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vTooth>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vTooth");

                entity.Property(e => e.Bottom_Name_ToothSurface)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.Left_Name_ToothSurface)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Middle_Name_ToothSurface)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Dentition)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Right_Name_ToothSurface)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Top_Name_ToothSurface)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vToothInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vToothInfo");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.IDs_ToothSurface)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vToothStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vToothStatus");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_ToothStatusType)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ToothStatusType)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vToothStatusType>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vToothStatusType");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vToothSurface>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vToothSurface");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vUnitOfMeasure>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vUnitOfMeasure");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vUser");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Code_Company)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Employee)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Company)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Employee)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.UserGroup)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vUserComment>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vUserComment");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vUserGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vUserGroup");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vUserRole>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vUserRole");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vVeterinaryCertificate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vVeterinaryCertificate");

                entity.Property(e => e.AttendingPhysician_Name_Employee)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateVaccinated).HasColumnType("datetime");

                entity.Property(e => e.DestinationAddress)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LotNumber)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Client)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Item)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Patient)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PatientDateBirth).HasColumnType("datetime");

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vVeterinaryCertificate_ListView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vVeterinaryCertificate_ListView");

                entity.Property(e => e.AttendingPhysician_Name_Employee)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationAddress)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Client)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Item)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Patient)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vVeterinaryHealthCertificate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vVeterinaryHealthCertificate");

                entity.Property(e => e.AttendingPhysician_Name_Employee)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Color)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateCanceled).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateVaccinated).HasColumnType("datetime");

                entity.Property(e => e.DestinationAddress)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LotNumber)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Client)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Name_FilingStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Item)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Patient)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PatientDateBirth).HasColumnType("datetime");

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Weight)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vVeterinaryHealthCertificate_ListView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vVeterinaryHealthCertificate_ListView");

                entity.Property(e => e.AttendingPhysician_Name_Employee)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DestinationAddress)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Client)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Name_FilingStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Patient)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vViewType>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vViewType");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_ViewType)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vetsaveers_clientpatient_practo>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Address).HasMaxLength(255);

                entity.Property(e => e.Age).HasMaxLength(255);

                entity.Property(e => e.Anniversary_Date)
                    .HasColumnName("Anniversary Date")
                    .HasMaxLength(255);

                entity.Property(e => e.Blood_Group)
                    .HasColumnName("Blood Group")
                    .HasMaxLength(255);

                entity.Property(e => e.City).HasMaxLength(255);

                entity.Property(e => e.Contact_Number)
                    .HasColumnName("Contact Number")
                    .HasMaxLength(255);

                entity.Property(e => e.Date_of_Birth)
                    .HasColumnName("Date of Birth")
                    .HasMaxLength(255);

                entity.Property(e => e.Email_Address)
                    .HasColumnName("Email Address")
                    .HasMaxLength(255);

                entity.Property(e => e.F22).HasMaxLength(255);

                entity.Property(e => e.F23).HasMaxLength(255);

                entity.Property(e => e.Gender).HasMaxLength(255);

                entity.Property(e => e.Groups).HasMaxLength(255);

                entity.Property(e => e.Locality).HasMaxLength(255);

                entity.Property(e => e.Medical_History)
                    .HasColumnName("Medical History")
                    .HasMaxLength(255);

                entity.Property(e => e.Mobile_Number)
                    .HasColumnName("Mobile Number")
                    .HasMaxLength(255);

                entity.Property(e => e.National_Id)
                    .HasColumnName("National Id")
                    .HasMaxLength(255);

                entity.Property(e => e.Patient_Name)
                    .HasColumnName("Patient Name")
                    .HasMaxLength(255);

                entity.Property(e => e.Patient_Notes)
                    .HasColumnName("Patient Notes")
                    .HasMaxLength(255);

                entity.Property(e => e.Patient_Number)
                    .HasColumnName("Patient Number")
                    .HasMaxLength(255);

                entity.Property(e => e.Pincode).HasMaxLength(255);

                entity.Property(e => e.Referred_By)
                    .HasColumnName("Referred By")
                    .HasMaxLength(255);

                entity.Property(e => e.Remarks).HasMaxLength(255);

                entity.Property(e => e.Secondary_Mobile)
                    .HasColumnName("Secondary Mobile")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<villingInvoiceWalkInList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("villingInvoiceWalkInList");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vpivotBilledPatientConfinement>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vpivotBilledPatientConfinement");

                entity.Property(e => e._1)
                    .HasColumnName("1")
                    .HasMaxLength(4000);

                entity.Property(e => e._10)
                    .HasColumnName("10")
                    .HasMaxLength(4000);

                entity.Property(e => e._2)
                    .HasColumnName("2")
                    .HasMaxLength(4000);

                entity.Property(e => e._3)
                    .HasColumnName("3")
                    .HasMaxLength(4000);

                entity.Property(e => e._4)
                    .HasColumnName("4")
                    .HasMaxLength(4000);

                entity.Property(e => e._5)
                    .HasColumnName("5")
                    .HasMaxLength(4000);

                entity.Property(e => e._6)
                    .HasColumnName("6")
                    .HasMaxLength(4000);

                entity.Property(e => e._7)
                    .HasColumnName("7")
                    .HasMaxLength(4000);

                entity.Property(e => e._8)
                    .HasColumnName("8")
                    .HasMaxLength(4000);

                entity.Property(e => e._9)
                    .HasColumnName("9")
                    .HasMaxLength(4000);
            });

            modelBuilder.Entity<vpivotBilledPatientSOAP>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vpivotBilledPatientSOAP");

                entity.Property(e => e._1)
                    .HasColumnName("1")
                    .HasMaxLength(4000);

                entity.Property(e => e._10)
                    .HasColumnName("10")
                    .HasMaxLength(4000);

                entity.Property(e => e._2)
                    .HasColumnName("2")
                    .HasMaxLength(4000);

                entity.Property(e => e._3)
                    .HasColumnName("3")
                    .HasMaxLength(4000);

                entity.Property(e => e._4)
                    .HasColumnName("4")
                    .HasMaxLength(4000);

                entity.Property(e => e._5)
                    .HasColumnName("5")
                    .HasMaxLength(4000);

                entity.Property(e => e._6)
                    .HasColumnName("6")
                    .HasMaxLength(4000);

                entity.Property(e => e._7)
                    .HasColumnName("7")
                    .HasMaxLength(4000);

                entity.Property(e => e._8)
                    .HasColumnName("8")
                    .HasMaxLength(4000);

                entity.Property(e => e._9)
                    .HasColumnName("9")
                    .HasMaxLength(4000);
            });

            modelBuilder.Entity<vsample>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vsample");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UnitCost).HasMaxLength(4000);
            });

            modelBuilder.Entity<vzAcknowledgementReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vzAcknowledgementReport");

                entity.Property(e => e.Address_Client)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Address_Company)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Age_Patient).IsUnicode(false);

                entity.Property(e => e.ContactNumber2_Client)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNumber_Client)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNumber_Company)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Email_Client)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.HeaderInfo_Company)
                    .HasMaxLength(924)
                    .IsUnicode(false);

                entity.Property(e => e.ImageLogoLocationFilenamePath)
                    .HasMaxLength(352)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Client)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Company)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Gender)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Patient)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Species)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vzAdmissionReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vzAdmissionReport");

                entity.Property(e => e.Address_Client)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Address_Company)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Age_Patient).IsUnicode(false);

                entity.Property(e => e.ContactNumber2_Client)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNumber_Client)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNumber_Company)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Email_Client)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.HeaderInfo_Company)
                    .HasMaxLength(929)
                    .IsUnicode(false);

                entity.Property(e => e.ImageLogoLocationFilenamePath)
                    .HasMaxLength(352)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Client)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Company)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Gender)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Patient)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Species)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vzAgreementForConfinement>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vzAgreementForConfinement");

                entity.Property(e => e.Address_Client)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Address_Company)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Age_Patient).IsUnicode(false);

                entity.Property(e => e.ContactNumber2_Client)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNumber_Client)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNumber_Company)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Email_Client)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.HeaderInfo_Company)
                    .HasMaxLength(924)
                    .IsUnicode(false);

                entity.Property(e => e.ImageLogoLocationFilenamePath)
                    .HasMaxLength(352)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Client)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Company)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Gender)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Patient)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Species)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vzBillingInvoiceAgingReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vzBillingInvoiceAgingReport");

                entity.Property(e => e.Address_Company)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Age).IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNumber_Company)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Date_BillingInvoice).HasColumnType("datetime");

                entity.Property(e => e.HeaderInfo_Company)
                    .HasMaxLength(924)
                    .IsUnicode(false);

                entity.Property(e => e.ImageLogoLocationFilenamePath)
                    .HasMaxLength(352)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Client)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Company)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RemainingAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Status)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<vzBillingInvoicePaidListReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vzBillingInvoicePaidListReport");

                entity.Property(e => e.Address_Company)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.AttendingPhysician_Name_Employee)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Code_BillingInvoice)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Date_BillingInvoice).HasColumnType("datetime");

                entity.Property(e => e.Date_PaymentTransaction).HasColumnType("datetime");

                entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.HeaderInfo_Company)
                    .HasMaxLength(924)
                    .IsUnicode(false);

                entity.Property(e => e.ImageLogoLocationFilenamePath)
                    .HasMaxLength(352)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Client)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Company)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Patient)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Payment_Name_FilingStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<vzBillingInvoiceReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vzBillingInvoiceReport");

                entity.Property(e => e.Address_Company)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ApprovedBy_Name_User)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy_Name_User)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DiscountRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.GrossAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ImageLogoLocationFilenamePath)
                    .HasMaxLength(352)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Company)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_FilingStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Item)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Patient)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Name_TaxScheme)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NetAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SubTotal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.VatAmount).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<vzClientDepositReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vzClientDepositReport");

                entity.Property(e => e.Address_Company)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedBy_Name_User)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Code_Patient_Confinement)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNumber_Company)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DepositAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.FormattedDepositAmount).HasMaxLength(4000);

                entity.Property(e => e.HeaderInfo_Company)
                    .HasMaxLength(924)
                    .IsUnicode(false);

                entity.Property(e => e.ImageLogoLocationFilenamePath)
                    .HasMaxLength(352)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Client)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Company)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_FilingStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Patient)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vzClinicaVeterinariaAgainstMedicalAdvice>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vzClinicaVeterinariaAgainstMedicalAdvice");

                entity.Property(e => e.Address_Client)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Address_Company)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Age_Patient).IsUnicode(false);

                entity.Property(e => e.ContactNumber2_Client)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNumber_Client)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNumber_Company)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Email_Client)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.HeaderInfo_Company)
                    .HasMaxLength(924)
                    .IsUnicode(false);

                entity.Property(e => e.ImageLogoLocationFilenamePath)
                    .HasMaxLength(352)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Client)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Company)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Gender)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Patient)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Species)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vzConcentToOperation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vzConcentToOperation");

                entity.Property(e => e.Address_Client)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Address_Company)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Age_Patient).IsUnicode(false);

                entity.Property(e => e.ContactNumber2_Client)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNumber_Client)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNumber_Company)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Email_Client)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.HeaderInfo_Company)
                    .HasMaxLength(924)
                    .IsUnicode(false);

                entity.Property(e => e.ImageLogoLocationFilenamePath)
                    .HasMaxLength(352)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Client)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Company)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Gender)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Patient)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Species)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vzDentalExamination>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vzDentalExamination");

                entity.Property(e => e.Address_Company)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedBy_Name_User)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.ImageLogoLocationFilenamePath)
                    .HasMaxLength(352)
                    .IsUnicode(false);

                entity.Property(e => e.Location_Tooth)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Company)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Doctor)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Name_FilingStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Patient)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_ToothStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ToothLocationSurfaceString).IsUnicode(false);

                entity.Property(e => e.ToothSurfaceNames)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vzDentalExaminatonPrescriptionReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vzDentalExaminatonPrescriptionReport");

                entity.Property(e => e.Address_Company)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedBy_Name_User)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.ImageLogoLocationFilenamePath)
                    .HasMaxLength(352)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Company)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Doctor)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Name_FilingStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Patient)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vzEuthanasiaAuthorization>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vzEuthanasiaAuthorization");

                entity.Property(e => e.Address_Client)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Address_Company)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Age_Patient).IsUnicode(false);

                entity.Property(e => e.ContactNumber2_Client)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNumber_Client)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNumber_Company)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Email_Client)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.HeaderInfo_Company)
                    .HasMaxLength(924)
                    .IsUnicode(false);

                entity.Property(e => e.ImageLogoLocationFilenamePath)
                    .HasMaxLength(352)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Client)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Company)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Gender)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Patient)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Species)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vzInventoryDetailReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vzInventoryDetailReport");

                entity.Property(e => e.Address_Company)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateExpired).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateString)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.HeaderInfo_Company)
                    .HasMaxLength(924)
                    .IsUnicode(false);

                entity.Property(e => e.ImageLogoLocationFilenamePath)
                    .HasMaxLength(352)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Company)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_FilingStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_InventoryStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Item)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<vzInventorySummaryReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vzInventorySummaryReport");

                entity.Property(e => e.Address_Company)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.DateLastIn).HasColumnType("datetime");

                entity.Property(e => e.DateLastOut).HasColumnType("datetime");

                entity.Property(e => e.HeaderInfo_Company)
                    .HasMaxLength(924)
                    .IsUnicode(false);

                entity.Property(e => e.ImageLogoLocationFilenamePath)
                    .HasMaxLength(352)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Company)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_InventoryStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Item)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RemainingBeforeExpired).IsUnicode(false);

                entity.Property(e => e.UnitCost).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<vzPOSSummary>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vzPOSSummary");

                entity.Property(e => e.Address_Company)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Date1).HasColumnType("datetime");

                entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.HeaderInfo_Company)
                    .HasMaxLength(924)
                    .IsUnicode(false);

                entity.Property(e => e.ImageLogoLocationFilenamePath)
                    .HasMaxLength(352)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Company)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Item)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_ItemType)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<vzPatientBillingInvoiceReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vzPatientBillingInvoiceReport");

                entity.Property(e => e.Address_Company)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ApprovedBy_Name_User)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Code_Patient_Confinement)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConfinementDepositAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ConsumedDepositAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ContactNumber_Company)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy_Name_User)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.Date_Patient_Confinement_ItemsServices).HasMaxLength(4000);

                entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DiscountAmount_BillingInvoice_Detail).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DiscountRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DiscountRate_BillingInvoice_Detail).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.GrossAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.HeaderInfo_Company)
                    .HasMaxLength(924)
                    .IsUnicode(false);

                entity.Property(e => e.ImageLogoLocationFilenamePath)
                    .HasMaxLength(352)
                    .IsUnicode(false);

                entity.Property(e => e.InitialSubtotalAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Name_Client)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Company)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_FilingStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Item)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Patient)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Name_TaxScheme)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NetAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.RemainingDepositAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SubTotal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalItemDiscountAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.VatAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.WalkInCustomerName)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vzPatientSOAP>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vzPatientSOAP");

                entity.Property(e => e.Address_Company)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Age_Patient).IsUnicode(false);

                entity.Property(e => e.Assessment)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.AttendingPhysician_Name_Employee)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.AttendingPhysician_PRCLicenseNumber_Employee)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.AttendingPhysician_PTR_Employee)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.AttendingPhysician_S2_Employee)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.AttendingPhysician_TINNumber_Employee)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ClientCommunication)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.ClinicalExamination)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.ContactNumber_Company)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Diagnosis)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.HeaderInfo_Company)
                    .HasMaxLength(924)
                    .IsUnicode(false);

                entity.Property(e => e.History)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.ImageLogoLocationFilenamePath)
                    .HasMaxLength(352)
                    .IsUnicode(false);

                entity.Property(e => e.LaboratoryRemarks).IsUnicode(false);

                entity.Property(e => e.Name_Client)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Company)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_FilingStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Gender)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Patient)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Objective)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Planning).IsUnicode(false);

                entity.Property(e => e.Prescription).IsUnicode(false);

                entity.Property(e => e.Species)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Subjective)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Treatment).IsUnicode(false);
            });

            modelBuilder.Entity<vzPaymentTransactionReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vzPaymentTransactionReport");

                entity.Property(e => e.Address_Company)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedBy_Name_User)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddress)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.ChangeAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.CheckNumber)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Code_BillingInvoice)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.ImageLogoLocationFilenamePath)
                    .HasMaxLength(352)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Client)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Company)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_FilingStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Patient)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Name_PaymentMethod)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PayableAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PaymentAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PaymentAmountString).HasMaxLength(4000);

                entity.Property(e => e.RemainingAmount).HasColumnType("decimal(19, 4)");
            });

            modelBuilder.Entity<vzPaymentTransactionSummaryReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vzPaymentTransactionSummaryReport");

                entity.Property(e => e.Address_Company)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.AttendingPhysician_Name_Employee)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.BalanceAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Code_BillingInvoice)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Code_PaymentTransaction)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Date_BillingInvoice).HasColumnType("datetime");

                entity.Property(e => e.Date_PaymentTransaction).HasColumnType("datetime");

                entity.Property(e => e.HeaderInfo_Company)
                    .HasMaxLength(924)
                    .IsUnicode(false);

                entity.Property(e => e.ImageLogoLocationFilenamePath)
                    .HasMaxLength(352)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Client)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Company)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Patient)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Name_PaymentMethod)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Position)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PayableAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PaymentAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.RemainingAmount).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<vzPurchaseOrderReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vzPurchaseOrderReport");

                entity.Property(e => e.Address_Company)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ApprovedBy_Name_User)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy_Name_User)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.GrossAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ImageLogoLocationFilenamePath)
                    .HasMaxLength(352)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Company)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_FilingStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Item)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Supplier)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_TaxScheme)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NetAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.VatAmount).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<vzReceiveDepositCredit>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vzReceiveDepositCredit");

                entity.Property(e => e.Address_Company)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.ContactNumber_Company)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.CreditAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.HeaderInfo_Company)
                    .HasMaxLength(924)
                    .IsUnicode(false);

                entity.Property(e => e.ImageLogoLocationFilenamePath)
                    .HasMaxLength(352)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Client)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Company)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<vzReceivingReportReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vzReceivingReportReport");

                entity.Property(e => e.Address_Company)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ApprovedBy_Name_User)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Code_PurchaseOrder)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy_Name_User)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DateApproved).HasColumnType("datetime");

                entity.Property(e => e.GrossAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ImageLogoLocationFilenamePath)
                    .HasMaxLength(352)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Company)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_FilingStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Item)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Supplier)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_TaxScheme)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NetAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.VatAmount).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<vzSalesIncomentReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vzSalesIncomentReport");

                entity.Property(e => e.Address_Company)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.AttendingPhysician_Name_Employee)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Date_BillingInvoice).HasColumnType("date");

                entity.Property(e => e.GrossSales).HasColumnType("decimal(29, 4)");

                entity.Property(e => e.HeaderInfo_Company)
                    .HasMaxLength(924)
                    .IsUnicode(false);

                entity.Property(e => e.ImageLogoLocationFilenamePath)
                    .HasMaxLength(352)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Client)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Company)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Item)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NetCost).HasColumnType("decimal(30, 4)");

                entity.Property(e => e.UnitCost).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<vzVeterinaryHealthClinicReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vzVeterinaryHealthClinicReport");

                entity.Property(e => e.Address_Client)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Address_Company)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Age_Patient).IsUnicode(false);

                entity.Property(e => e.AttendingPhysician_Name_Employee)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Color)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNumber2_Client)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNumber_Client)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNumber_Company)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DatePRCExpiration).HasColumnType("datetime");

                entity.Property(e => e.DestinationAddress)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Email_Client)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.HeaderInfo_Company)
                    .HasMaxLength(924)
                    .IsUnicode(false);

                entity.Property(e => e.ImageLogoLocationFilenamePath)
                    .HasMaxLength(352)
                    .IsUnicode(false);

                entity.Property(e => e.LotNumber)
                    .HasMaxLength(325)
                    .IsUnicode(false);

                entity.Property(e => e.Microchip)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Client)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Company)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Gender)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Item)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Patient)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name_Species)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.PRCLicenseNumber)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.PTR)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.TINNumber)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Weight)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
