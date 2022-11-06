using System;
using System.Collections.Generic;

namespace ngJSApp.Database.Models
{
    public partial class tUser
    {
        public tUser()
        {
            BillingInvoiceWalkInListID_CreatedByNavigation = new HashSet<BillingInvoiceWalkInList>();
            BillingInvoiceWalkInListID_LastModifiedByNavigation = new HashSet<BillingInvoiceWalkInList>();
            InverseID_CreatedByNavigation = new HashSet<tUser>();
            InverseID_LastModifiedByNavigation = new HashSet<tUser>();
            _tDatabaseMemoryLogID_CreatedByNavigation = new HashSet<_tDatabaseMemoryLog>();
            _tDatabaseMemoryLogID_LastModifiedByNavigation = new HashSet<_tDatabaseMemoryLog>();
            _tDetailViewID_CreatedByNavigation = new HashSet<_tDetailView>();
            _tDetailViewID_LastModifiedByNavigation = new HashSet<_tDetailView>();
            _tDetailView_DetailID_CreatedByNavigation = new HashSet<_tDetailView_Detail>();
            _tDetailView_DetailID_LastModifiedByNavigation = new HashSet<_tDetailView_Detail>();
            _tDetailView_Detail_LinkID_CreatedByNavigation = new HashSet<_tDetailView_Detail_Link>();
            _tDetailView_Detail_LinkID_LastModifiedByNavigation = new HashSet<_tDetailView_Detail_Link>();
            _tListViewID_CreatedByNavigation = new HashSet<_tListView>();
            _tListViewID_LastModifiedByNavigation = new HashSet<_tListView>();
            _tListView_Detail = new HashSet<_tListView_Detail>();
            _tModelID_CreatedByNavigation = new HashSet<_tModel>();
            _tModelID_LastModifiedByNavigation = new HashSet<_tModel>();
            _tModelReportID_CreatedByNavigation = new HashSet<_tModelReport>();
            _tModelReportID_LastModifiedByNavigation = new HashSet<_tModelReport>();
            _tModel_Property = new HashSet<_tModel_Property>();
            _tNavigationID_CreatedByNavigation = new HashSet<_tNavigation>();
            _tNavigationID_LastModifiedByNavigation = new HashSet<_tNavigation>();
            _tViewID_CreatedByNavigation = new HashSet<_tView>();
            _tViewID_LastModifiedByNavigation = new HashSet<_tView>();
            tAppSettingID_CreatedByNavigation = new HashSet<tAppSetting>();
            tAppSettingID_LastModifiedByNavigation = new HashSet<tAppSetting>();
            tAppointmentID_CreatedByNavigation = new HashSet<tAppointment>();
            tAppointmentID_LastModifiedByNavigation = new HashSet<tAppointment>();
            tAppointmentRequestID_CreatedByNavigation = new HashSet<tAppointmentRequest>();
            tAppointmentRequestID_LastModifiedByNavigation = new HashSet<tAppointmentRequest>();
            tAppointmentScheduleID_CreatedByNavigation = new HashSet<tAppointmentSchedule>();
            tAppointmentScheduleID_LastModifiedByNavigation = new HashSet<tAppointmentSchedule>();
            tAppointmentStatusLogID_CreatedByNavigation = new HashSet<tAppointmentStatusLog>();
            tAppointmentStatusLogID_LastModifiedByNavigation = new HashSet<tAppointmentStatusLog>();
            tApproverMatrixID_CreatedByNavigation = new HashSet<tApproverMatrix>();
            tApproverMatrixID_LastModifiedByNavigation = new HashSet<tApproverMatrix>();
            tApproverMatrix_DetailID_CreatedByNavigation = new HashSet<tApproverMatrix_Detail>();
            tApproverMatrix_DetailID_LastModifiedByNavigation = new HashSet<tApproverMatrix_Detail>();
            tBillingInvoiceID_CreatedByNavigation = new HashSet<tBillingInvoice>();
            tBillingInvoiceID_LastModifiedByNavigation = new HashSet<tBillingInvoice>();
            tBillingInvoiceWalkInID_CreatedByNavigation = new HashSet<tBillingInvoiceWalkIn>();
            tBillingInvoiceWalkInID_LastModifiedByNavigation = new HashSet<tBillingInvoiceWalkIn>();
            tBillingInvoiceWalkInListID_CreatedByNavigation = new HashSet<tBillingInvoiceWalkInList>();
            tBillingInvoiceWalkInListID_LastModifiedByNavigation = new HashSet<tBillingInvoiceWalkInList>();
            tBillingInvoice_DetailID_CreatedByNavigation = new HashSet<tBillingInvoice_Detail>();
            tBillingInvoice_DetailID_LastModifiedByNavigation = new HashSet<tBillingInvoice_Detail>();
            tBillingInvoice_PatientID_CreatedByNavigation = new HashSet<tBillingInvoice_Patient>();
            tBillingInvoice_PatientID_LastModifiedByNavigation = new HashSet<tBillingInvoice_Patient>();
            tBreedSpecieID_CreatedByNavigation = new HashSet<tBreedSpecie>();
            tBreedSpecieID_LastModifiedByNavigation = new HashSet<tBreedSpecie>();
            tBusinessPartnerID_CreatedByNavigation = new HashSet<tBusinessPartner>();
            tBusinessPartnerID_LastModifiedByNavigation = new HashSet<tBusinessPartner>();
            tBusinessPartnerTypeID_CreatedByNavigation = new HashSet<tBusinessPartnerType>();
            tBusinessPartnerTypeID_LastModifiedByNavigation = new HashSet<tBusinessPartnerType>();
            tBusinessPartner_ContactID_CreatedByNavigation = new HashSet<tBusinessPartner_Contact>();
            tBusinessPartner_ContactID_LastModifiedByNavigation = new HashSet<tBusinessPartner_Contact>();
            tCardTypeID_CreatedByNavigation = new HashSet<tCardType>();
            tCardTypeID_LastModifiedByNavigation = new HashSet<tCardType>();
            tCaseTypeID_CreatedByNavigation = new HashSet<tCaseType>();
            tCaseTypeID_LastModifiedByNavigation = new HashSet<tCaseType>();
            tClientDepositID_CreatedByNavigation = new HashSet<tClientDeposit>();
            tClientDepositID_LastModifiedByNavigation = new HashSet<tClientDeposit>();
            tClientID_CreatedByNavigation = new HashSet<tClient>();
            tClientID_LastModifiedByNavigation = new HashSet<tClient>();
            tClientWithdraw_ID_CreatedByNavigation = new HashSet<tClientWithdraw_>();
            tClientWithdraw_ID_LastModifiedByNavigation = new HashSet<tClientWithdraw_>();
            tClient_CreditLogsID_CreatedByNavigation = new HashSet<tClient_CreditLogs>();
            tClient_CreditLogsID_LastModifiedByNavigation = new HashSet<tClient_CreditLogs>();
            tCompanyID_CreatedByNavigation = new HashSet<tCompany>();
            tCompanyID_LastModifiedByNavigation = new HashSet<tCompany>();
            tCompanyInfoID_CreatedByNavigation = new HashSet<tCompanyInfo>();
            tCompanyInfoID_LastModifiedByNavigation = new HashSet<tCompanyInfo>();
            tCompanyTextBlastTemplateID_CreatedByNavigation = new HashSet<tCompanyTextBlastTemplate>();
            tCompanyTextBlastTemplateID_LastModifiedByNavigation = new HashSet<tCompanyTextBlastTemplate>();
            tCompany_SubscriptionID_CreatedByNavigation = new HashSet<tCompany_Subscription>();
            tCompany_SubscriptionID_LastModifiedByNavigation = new HashSet<tCompany_Subscription>();
            tCountryID_CreatedByNavigation = new HashSet<tCountry>();
            tCountryID_LastModifiedByNavigation = new HashSet<tCountry>();
            tCustomDetailViewRouteID_CreatedByNavigation = new HashSet<tCustomDetailViewRoute>();
            tCustomDetailViewRouteID_LastModifiedByNavigation = new HashSet<tCustomDetailViewRoute>();
            tCustomNavigationLinkID_CreatedByNavigation = new HashSet<tCustomNavigationLink>();
            tCustomNavigationLinkID_LastModifiedByNavigation = new HashSet<tCustomNavigationLink>();
            tDentalExaminationID_CreatedByNavigation = new HashSet<tDentalExamination>();
            tDentalExaminationID_LastModifiedByNavigation = new HashSet<tDentalExamination>();
            tDentitionID_CreatedByNavigation = new HashSet<tDentition>();
            tDentitionID_LastModifiedByNavigation = new HashSet<tDentition>();
            tDocID_CreatedByNavigation = new HashSet<tDoc>();
            tDocID_LastModifiedByNavigation = new HashSet<tDoc>();
            tDocumentSeriesID_CreatedByNavigation = new HashSet<tDocumentSeries>();
            tDocumentSeriesID_LastModifiedByNavigation = new HashSet<tDocumentSeries>();
            tDocumentStatusID_CreatedByNavigation = new HashSet<tDocumentStatus>();
            tDocumentStatusID_LastModifiedByNavigation = new HashSet<tDocumentStatus>();
            tEmployee = new HashSet<tEmployee>();
            tEmployeeInfoID_CreatedByNavigation = new HashSet<tEmployeeInfo>();
            tEmployeeInfoID_LastModifiedByNavigation = new HashSet<tEmployeeInfo>();
            tEmployeePositionID_CreatedByNavigation = new HashSet<tEmployeePosition>();
            tEmployeePositionID_LastModifiedByNavigation = new HashSet<tEmployeePosition>();
            tEmploymentStatusID_CreatedByNavigation = new HashSet<tEmploymentStatus>();
            tEmploymentStatusID_LastModifiedByNavigation = new HashSet<tEmploymentStatus>();
            tEmplyeeID_CreatedByNavigation = new HashSet<tEmplyee>();
            tEmplyeeID_LastModifiedByNavigation = new HashSet<tEmplyee>();
            tExpenseCategoryID_CreatedByNavigation = new HashSet<tExpenseCategory>();
            tExpenseCategoryID_LastModifiedByNavigation = new HashSet<tExpenseCategory>();
            tFileUploadID_CreatedByNavigation = new HashSet<tFileUpload>();
            tFileUploadID_LastModifiedByNavigation = new HashSet<tFileUpload>();
            tFilingStatusID_CreatedByNavigation = new HashSet<tFilingStatus>();
            tFilingStatusID_LastModifiedByNavigation = new HashSet<tFilingStatus>();
            tForBillingID_CreatedByNavigation = new HashSet<tForBilling>();
            tForBillingID_LastModifiedByNavigation = new HashSet<tForBilling>();
            tHelpDeskVideoTutorialID_CreatedByNavigation = new HashSet<tHelpDeskVideoTutorial>();
            tHelpDeskVideoTutorialID_LastModifiedByNavigation = new HashSet<tHelpDeskVideoTutorial>();
            tITextMoAPISMSStatusID_CreatedByNavigation = new HashSet<tITextMoAPISMSStatus>();
            tITextMoAPISMSStatusID_LastModifiedByNavigation = new HashSet<tITextMoAPISMSStatus>();
            tInventoryStatusID_CreatedByNavigation = new HashSet<tInventoryStatus>();
            tInventoryStatusID_LastModifiedByNavigation = new HashSet<tInventoryStatus>();
            tInventorySummaryID_CreatedByNavigation = new HashSet<tInventorySummary>();
            tInventorySummaryID_LastModifiedByNavigation = new HashSet<tInventorySummary>();
            tInventoryTrailID_CreatedByNavigation = new HashSet<tInventoryTrail>();
            tInventoryTrailID_LastModifiedByNavigation = new HashSet<tInventoryTrail>();
            tIssueTrackerID_CreatedByNavigation = new HashSet<tIssueTracker>();
            tIssueTrackerID_LastModifiedByNavigation = new HashSet<tIssueTracker>();
            tItemCategoryID_CreatedByNavigation = new HashSet<tItemCategory>();
            tItemCategoryID_LastModifiedByNavigation = new HashSet<tItemCategory>();
            tItemID_CreatedByNavigation = new HashSet<tItem>();
            tItemID_LastModifiedByNavigation = new HashSet<tItem>();
            tItemInventoriableID_CreatedByNavigation = new HashSet<tItemInventoriable>();
            tItemInventoriableID_LastModifiedByNavigation = new HashSet<tItemInventoriable>();
            tItemServiceID_CreatedByNavigation = new HashSet<tItemService>();
            tItemServiceID_LastModifiedByNavigation = new HashSet<tItemService>();
            tItemTypeID_CreatedByNavigation = new HashSet<tItemType>();
            tItemTypeID_LastModifiedByNavigation = new HashSet<tItemType>();
            tItem_UnitCostLogID_CreatedByNavigation = new HashSet<tItem_UnitCostLog>();
            tItem_UnitCostLogID_LastModifiedByNavigation = new HashSet<tItem_UnitCostLog>();
            tItem_UnitPriceLogID_CreatedByNavigation = new HashSet<tItem_UnitPriceLog>();
            tItem_UnitPriceLogID_LastModifiedByNavigation = new HashSet<tItem_UnitPriceLog>();
            tLocalShippingPermitIssuanceID_CreatedByNavigation = new HashSet<tLocalShippingPermitIssuance>();
            tLocalShippingPermitIssuanceID_LastModifiedByNavigation = new HashSet<tLocalShippingPermitIssuance>();
            tLocalShippingPermitIssuance_ItemID_CreatedByNavigation = new HashSet<tLocalShippingPermitIssuance_Item>();
            tLocalShippingPermitIssuance_ItemID_LastModifiedByNavigation = new HashSet<tLocalShippingPermitIssuance_Item>();
            tLocalShippingPermitIssuance_RequirementID_CreatedByNavigation = new HashSet<tLocalShippingPermitIssuance_Requirement>();
            tLocalShippingPermitIssuance_RequirementID_LastModifiedByNavigation = new HashSet<tLocalShippingPermitIssuance_Requirement>();
            tMedicalHistoryQuestionnaireID_CreatedByNavigation = new HashSet<tMedicalHistoryQuestionnaire>();
            tMedicalHistoryQuestionnaireID_LastModifiedByNavigation = new HashSet<tMedicalHistoryQuestionnaire>();
            tMedicationRouteID_CreatedByNavigation = new HashSet<tMedicationRoute>();
            tMedicationRouteID_LastModifiedByNavigation = new HashSet<tMedicationRoute>();
            tMessageID_CreatedByNavigation = new HashSet<tMessage>();
            tMessageID_LastModifiedByNavigation = new HashSet<tMessage>();
            tPatientAppointmentID_CreatedByNavigation = new HashSet<tPatientAppointment>();
            tPatientAppointmentID_LastModifiedByNavigation = new HashSet<tPatientAppointment>();
            tPatientID_CreatedByNavigation = new HashSet<tPatient>();
            tPatientID_LastModifiedByNavigation = new HashSet<tPatient>();
            tPatientSOAPListID_CreatedByNavigation = new HashSet<tPatientSOAPList>();
            tPatientSOAPListID_LastModifiedByNavigation = new HashSet<tPatientSOAPList>();
            tPatientWaitingListID_CreatedByNavigation = new HashSet<tPatientWaitingList>();
            tPatientWaitingListID_LastModifiedByNavigation = new HashSet<tPatientWaitingList>();
            tPatientWaitingList_LogsID_CreatedByNavigation = new HashSet<tPatientWaitingList_Logs>();
            tPatientWaitingList_LogsID_LastModifiedByNavigation = new HashSet<tPatientWaitingList_Logs>();
            tPatient_BirthDateSMSGreetingLogID_CreatedByNavigation = new HashSet<tPatient_BirthDateSMSGreetingLog>();
            tPatient_BirthDateSMSGreetingLogID_LastModifiedByNavigation = new HashSet<tPatient_BirthDateSMSGreetingLog>();
            tPatient_ConfinementID_CreatedByNavigation = new HashSet<tPatient_Confinement>();
            tPatient_ConfinementID_LastModifiedByNavigation = new HashSet<tPatient_Confinement>();
            tPatient_Confinement_ItemsServicesID_CreatedByNavigation = new HashSet<tPatient_Confinement_ItemsServices>();
            tPatient_Confinement_ItemsServicesID_LastModifiedByNavigation = new HashSet<tPatient_Confinement_ItemsServices>();
            tPatient_Confinement_PatientID_CreatedByNavigation = new HashSet<tPatient_Confinement_Patient>();
            tPatient_Confinement_PatientID_LastModifiedByNavigation = new HashSet<tPatient_Confinement_Patient>();
            tPatient_CreditLogsID_CreatedByNavigation = new HashSet<tPatient_CreditLogs>();
            tPatient_CreditLogsID_LastModifiedByNavigation = new HashSet<tPatient_CreditLogs>();
            tPatient_DentalExamination_ImageID_CreatedByNavigation = new HashSet<tPatient_DentalExamination_Image>();
            tPatient_DentalExamination_ImageID_LastModifiedByNavigation = new HashSet<tPatient_DentalExamination_Image>();
            tPatient_DentalExamination_MedicalHistoryID_CreatedByNavigation = new HashSet<tPatient_DentalExamination_MedicalHistory>();
            tPatient_DentalExamination_MedicalHistoryID_LastModifiedByNavigation = new HashSet<tPatient_DentalExamination_MedicalHistory>();
            tPatient_DentalExamination_ToothInfoID_CreatedByNavigation = new HashSet<tPatient_DentalExamination_ToothInfo>();
            tPatient_DentalExamination_ToothInfoID_LastModifiedByNavigation = new HashSet<tPatient_DentalExamination_ToothInfo>();
            tPatient_LodgingID_CreatedByNavigation = new HashSet<tPatient_Lodging>();
            tPatient_LodgingID_LastModifiedByNavigation = new HashSet<tPatient_Lodging>();
            tPatient_SOAPID_CreatedByNavigation = new HashSet<tPatient_SOAP>();
            tPatient_SOAPID_LastModifiedByNavigation = new HashSet<tPatient_SOAP>();
            tPatient_SOAP_PrescriptionID_CreatedByNavigation = new HashSet<tPatient_SOAP_Prescription>();
            tPatient_SOAP_PrescriptionID_LastModifiedByNavigation = new HashSet<tPatient_SOAP_Prescription>();
            tPatient_SOAP_SMSStatusID_CreatedByNavigation = new HashSet<tPatient_SOAP_SMSStatus>();
            tPatient_SOAP_SMSStatusID_LastModifiedByNavigation = new HashSet<tPatient_SOAP_SMSStatus>();
            tPatient_SOAP_TreatmentID_CreatedByNavigation = new HashSet<tPatient_SOAP_Treatment>();
            tPatient_SOAP_TreatmentID_LastModifiedByNavigation = new HashSet<tPatient_SOAP_Treatment>();
            tPatient_VaccinationID_CreatedByNavigation = new HashSet<tPatient_Vaccination>();
            tPatient_VaccinationID_LastModifiedByNavigation = new HashSet<tPatient_Vaccination>();
            tPatient_Vaccination_ScheduleID_CreatedByNavigation = new HashSet<tPatient_Vaccination_Schedule>();
            tPatient_Vaccination_ScheduleID_LastModifiedByNavigation = new HashSet<tPatient_Vaccination_Schedule>();
            tPatient_Vaccination_Schedule_SMSStatusID_CreatedByNavigation = new HashSet<tPatient_Vaccination_Schedule_SMSStatus>();
            tPatient_Vaccination_Schedule_SMSStatusID_LastModifiedByNavigation = new HashSet<tPatient_Vaccination_Schedule_SMSStatus>();
            tPatient_WellnessID_CreatedByNavigation = new HashSet<tPatient_Wellness>();
            tPatient_WellnessID_LastModifiedByNavigation = new HashSet<tPatient_Wellness>();
            tPatient_Wellness_DetailID_CreatedByNavigation = new HashSet<tPatient_Wellness_Detail>();
            tPatient_Wellness_DetailID_LastModifiedByNavigation = new HashSet<tPatient_Wellness_Detail>();
            tPatient_Wellness_ScheduleID_CreatedByNavigation = new HashSet<tPatient_Wellness_Schedule>();
            tPatient_Wellness_ScheduleID_LastModifiedByNavigation = new HashSet<tPatient_Wellness_Schedule>();
            tPatient_Wellness_Schedule_SMSStatusID_CreatedByNavigation = new HashSet<tPatient_Wellness_Schedule_SMSStatus>();
            tPatient_Wellness_Schedule_SMSStatusID_LastModifiedByNavigation = new HashSet<tPatient_Wellness_Schedule_SMSStatus>();
            tPayableID_CreatedByNavigation = new HashSet<tPayable>();
            tPayableID_LastModifiedByNavigation = new HashSet<tPayable>();
            tPayablePaymentID_CreatedByNavigation = new HashSet<tPayablePayment>();
            tPayablePaymentID_LastModifiedByNavigation = new HashSet<tPayablePayment>();
            tPayable_DetailID_CreatedByNavigation = new HashSet<tPayable_Detail>();
            tPayable_DetailID_LastModifiedByNavigation = new HashSet<tPayable_Detail>();
            tPaymentMethodID_CreatedByNavigation = new HashSet<tPaymentMethod>();
            tPaymentMethodID_LastModifiedByNavigation = new HashSet<tPaymentMethod>();
            tPaymentTransactionID_CreatedByNavigation = new HashSet<tPaymentTransaction>();
            tPaymentTransactionID_LastModifiedByNavigation = new HashSet<tPaymentTransaction>();
            tPurchaseOrderID_ApprovedByNavigation = new HashSet<tPurchaseOrder>();
            tPurchaseOrderID_CreatedByNavigation = new HashSet<tPurchaseOrder>();
            tPurchaseOrderID_LastModifiedByNavigation = new HashSet<tPurchaseOrder>();
            tQuestionTypeID_CreatedByNavigation = new HashSet<tQuestionType>();
            tQuestionTypeID_LastModifiedByNavigation = new HashSet<tQuestionType>();
            tReceivingReportID_CreatedByNavigation = new HashSet<tReceivingReport>();
            tReceivingReportID_LastModifiedByNavigation = new HashSet<tReceivingReport>();
            tReceivingReport_DetailID_CreatedByNavigation = new HashSet<tReceivingReport_Detail>();
            tReceivingReport_DetailID_LastModifiedByNavigation = new HashSet<tReceivingReport_Detail>();
            tRecurScheduleTypeID_CreatedByNavigation = new HashSet<tRecurScheduleType>();
            tRecurScheduleTypeID_LastModifiedByNavigation = new HashSet<tRecurScheduleType>();
            tSMSPatientSOAP_CompanyID_CreatedByNavigation = new HashSet<tSMSPatientSOAP_Company>();
            tSMSPatientSOAP_CompanyID_LastModifiedByNavigation = new HashSet<tSMSPatientSOAP_Company>();
            tSOAPTypeID_CreatedByNavigation = new HashSet<tSOAPType>();
            tSOAPTypeID_LastModifiedByNavigation = new HashSet<tSOAPType>();
            tSalesReturnID_CreatedByNavigation = new HashSet<tSalesReturn>();
            tSalesReturnID_LastModifiedByNavigation = new HashSet<tSalesReturn>();
            tSalesReturn_DetailID_CreatedByNavigation = new HashSet<tSalesReturn_Detail>();
            tSalesReturn_DetailID_LastModifiedByNavigation = new HashSet<tSalesReturn_Detail>();
            tScheduleID_CreatedByNavigation = new HashSet<tSchedule>();
            tScheduleID_LastModifiedByNavigation = new HashSet<tSchedule>();
            tServiceTypeID_CreatedByNavigation = new HashSet<tServiceType>();
            tServiceTypeID_LastModifiedByNavigation = new HashSet<tServiceType>();
            tSettingID_CreatedByNavigation = new HashSet<tSetting>();
            tSettingID_LastModifiedByNavigation = new HashSet<tSetting>();
            tStudentID_CreatedByNavigation = new HashSet<tStudent>();
            tStudentID_LastModifiedByNavigation = new HashSet<tStudent>();
            tSupplierID_CreatedByNavigation = new HashSet<tSupplier>();
            tSupplierID_LastModifiedByNavigation = new HashSet<tSupplier>();
            tTaxSchemeID_CreatedByNavigation = new HashSet<tTaxScheme>();
            tTaxSchemeID_LastModifiedByNavigation = new HashSet<tTaxScheme>();
            tTeacherID_CreatedByNavigation = new HashSet<tTeacher>();
            tTeacherID_LastModifiedByNavigation = new HashSet<tTeacher>();
            tTeethQuandrantID_CreatedByNavigation = new HashSet<tTeethQuandrant>();
            tTeethQuandrantID_LastModifiedByNavigation = new HashSet<tTeethQuandrant>();
            tTextBlastID_CreatedByNavigation = new HashSet<tTextBlast>();
            tTextBlastID_LastModifiedByNavigation = new HashSet<tTextBlast>();
            tTextBlast_ClientID_CreatedByNavigation = new HashSet<tTextBlast_Client>();
            tTextBlast_ClientID_LastModifiedByNavigation = new HashSet<tTextBlast_Client>();
            tTextBlast_Client_SMSStatusID_CreatedByNavigation = new HashSet<tTextBlast_Client_SMSStatus>();
            tTextBlast_Client_SMSStatusID_LastModifiedByNavigation = new HashSet<tTextBlast_Client_SMSStatus>();
            tToothInfoID_CreatedByNavigation = new HashSet<tToothInfo>();
            tToothInfoID_LastModifiedByNavigation = new HashSet<tToothInfo>();
            tToothStatusID_CreatedByNavigation = new HashSet<tToothStatus>();
            tToothStatusID_LastModifiedByNavigation = new HashSet<tToothStatus>();
            tToothStatusTypeID_CreatedByNavigation = new HashSet<tToothStatusType>();
            tToothStatusTypeID_LastModifiedByNavigation = new HashSet<tToothStatusType>();
            tToothSurfaceID_CreatedByNavigation = new HashSet<tToothSurface>();
            tToothSurfaceID_LastModifiedByNavigation = new HashSet<tToothSurface>();
            tUnitOfMeasureID_CreatedByNavigation = new HashSet<tUnitOfMeasure>();
            tUnitOfMeasureID_LastModifiedByNavigation = new HashSet<tUnitOfMeasure>();
            tUserCommentID_CreatedByNavigation = new HashSet<tUserComment>();
            tUserCommentID_LastModifiedByNavigation = new HashSet<tUserComment>();
            tUserGroupID_CreatedByNavigation = new HashSet<tUserGroup>();
            tUserGroupID_LastModifiedByNavigation = new HashSet<tUserGroup>();
            tUserRoleID_CreatedByNavigation = new HashSet<tUserRole>();
            tUserRoleID_LastModifiedByNavigation = new HashSet<tUserRole>();
            tUserSession = new HashSet<tUserSession>();
            tUser_Favorite = new HashSet<tUser_Favorite>();
            tUser_Roles = new HashSet<tUser_Roles>();
            tVeterinaryCertificateID_CreatedByNavigation = new HashSet<tVeterinaryCertificate>();
            tVeterinaryCertificateID_LastModifiedByNavigation = new HashSet<tVeterinaryCertificate>();
            tVeterinaryHealthCertificateID_CreatedByNavigation = new HashSet<tVeterinaryHealthCertificate>();
            tVeterinaryHealthCertificateID_LastModifiedByNavigation = new HashSet<tVeterinaryHealthCertificate>();
            tViewTypeID_CreatedByNavigation = new HashSet<tViewType>();
            tViewTypeID_LastModifiedByNavigation = new HashSet<tViewType>();
            tWarehouseID_CreatedByNavigation = new HashSet<tWarehouse>();
            tWarehouseID_LastModifiedByNavigation = new HashSet<tWarehouse>();
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
        public int? ID_Employee { get; set; }
        public string Username { get; set; }
        public int ID_UserGroup { get; set; }
        public string Password { get; set; }
        public bool? IsRequiredPasswordChangedOnLogin { get; set; }
        public int? ID_Patient { get; set; }

        public virtual tUser ID_CreatedByNavigation { get; set; }
        public virtual tEmployee ID_EmployeeNavigation { get; set; }
        public virtual tUser ID_LastModifiedByNavigation { get; set; }
        public virtual tUserGroup ID_UserGroupNavigation { get; set; }
        public virtual ICollection<BillingInvoiceWalkInList> BillingInvoiceWalkInListID_CreatedByNavigation { get; set; }
        public virtual ICollection<BillingInvoiceWalkInList> BillingInvoiceWalkInListID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tUser> InverseID_CreatedByNavigation { get; set; }
        public virtual ICollection<tUser> InverseID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<_tDatabaseMemoryLog> _tDatabaseMemoryLogID_CreatedByNavigation { get; set; }
        public virtual ICollection<_tDatabaseMemoryLog> _tDatabaseMemoryLogID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<_tDetailView> _tDetailViewID_CreatedByNavigation { get; set; }
        public virtual ICollection<_tDetailView> _tDetailViewID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<_tDetailView_Detail> _tDetailView_DetailID_CreatedByNavigation { get; set; }
        public virtual ICollection<_tDetailView_Detail> _tDetailView_DetailID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<_tDetailView_Detail_Link> _tDetailView_Detail_LinkID_CreatedByNavigation { get; set; }
        public virtual ICollection<_tDetailView_Detail_Link> _tDetailView_Detail_LinkID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<_tListView> _tListViewID_CreatedByNavigation { get; set; }
        public virtual ICollection<_tListView> _tListViewID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<_tListView_Detail> _tListView_Detail { get; set; }
        public virtual ICollection<_tModel> _tModelID_CreatedByNavigation { get; set; }
        public virtual ICollection<_tModel> _tModelID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<_tModelReport> _tModelReportID_CreatedByNavigation { get; set; }
        public virtual ICollection<_tModelReport> _tModelReportID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<_tModel_Property> _tModel_Property { get; set; }
        public virtual ICollection<_tNavigation> _tNavigationID_CreatedByNavigation { get; set; }
        public virtual ICollection<_tNavigation> _tNavigationID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<_tView> _tViewID_CreatedByNavigation { get; set; }
        public virtual ICollection<_tView> _tViewID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tAppSetting> tAppSettingID_CreatedByNavigation { get; set; }
        public virtual ICollection<tAppSetting> tAppSettingID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tAppointment> tAppointmentID_CreatedByNavigation { get; set; }
        public virtual ICollection<tAppointment> tAppointmentID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tAppointmentRequest> tAppointmentRequestID_CreatedByNavigation { get; set; }
        public virtual ICollection<tAppointmentRequest> tAppointmentRequestID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tAppointmentSchedule> tAppointmentScheduleID_CreatedByNavigation { get; set; }
        public virtual ICollection<tAppointmentSchedule> tAppointmentScheduleID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tAppointmentStatusLog> tAppointmentStatusLogID_CreatedByNavigation { get; set; }
        public virtual ICollection<tAppointmentStatusLog> tAppointmentStatusLogID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tApproverMatrix> tApproverMatrixID_CreatedByNavigation { get; set; }
        public virtual ICollection<tApproverMatrix> tApproverMatrixID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tApproverMatrix_Detail> tApproverMatrix_DetailID_CreatedByNavigation { get; set; }
        public virtual ICollection<tApproverMatrix_Detail> tApproverMatrix_DetailID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tBillingInvoice> tBillingInvoiceID_CreatedByNavigation { get; set; }
        public virtual ICollection<tBillingInvoice> tBillingInvoiceID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tBillingInvoiceWalkIn> tBillingInvoiceWalkInID_CreatedByNavigation { get; set; }
        public virtual ICollection<tBillingInvoiceWalkIn> tBillingInvoiceWalkInID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tBillingInvoiceWalkInList> tBillingInvoiceWalkInListID_CreatedByNavigation { get; set; }
        public virtual ICollection<tBillingInvoiceWalkInList> tBillingInvoiceWalkInListID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tBillingInvoice_Detail> tBillingInvoice_DetailID_CreatedByNavigation { get; set; }
        public virtual ICollection<tBillingInvoice_Detail> tBillingInvoice_DetailID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tBillingInvoice_Patient> tBillingInvoice_PatientID_CreatedByNavigation { get; set; }
        public virtual ICollection<tBillingInvoice_Patient> tBillingInvoice_PatientID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tBreedSpecie> tBreedSpecieID_CreatedByNavigation { get; set; }
        public virtual ICollection<tBreedSpecie> tBreedSpecieID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tBusinessPartner> tBusinessPartnerID_CreatedByNavigation { get; set; }
        public virtual ICollection<tBusinessPartner> tBusinessPartnerID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tBusinessPartnerType> tBusinessPartnerTypeID_CreatedByNavigation { get; set; }
        public virtual ICollection<tBusinessPartnerType> tBusinessPartnerTypeID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tBusinessPartner_Contact> tBusinessPartner_ContactID_CreatedByNavigation { get; set; }
        public virtual ICollection<tBusinessPartner_Contact> tBusinessPartner_ContactID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tCardType> tCardTypeID_CreatedByNavigation { get; set; }
        public virtual ICollection<tCardType> tCardTypeID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tCaseType> tCaseTypeID_CreatedByNavigation { get; set; }
        public virtual ICollection<tCaseType> tCaseTypeID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tClientDeposit> tClientDepositID_CreatedByNavigation { get; set; }
        public virtual ICollection<tClientDeposit> tClientDepositID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tClient> tClientID_CreatedByNavigation { get; set; }
        public virtual ICollection<tClient> tClientID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tClientWithdraw_> tClientWithdraw_ID_CreatedByNavigation { get; set; }
        public virtual ICollection<tClientWithdraw_> tClientWithdraw_ID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tClient_CreditLogs> tClient_CreditLogsID_CreatedByNavigation { get; set; }
        public virtual ICollection<tClient_CreditLogs> tClient_CreditLogsID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tCompany> tCompanyID_CreatedByNavigation { get; set; }
        public virtual ICollection<tCompany> tCompanyID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tCompanyInfo> tCompanyInfoID_CreatedByNavigation { get; set; }
        public virtual ICollection<tCompanyInfo> tCompanyInfoID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tCompanyTextBlastTemplate> tCompanyTextBlastTemplateID_CreatedByNavigation { get; set; }
        public virtual ICollection<tCompanyTextBlastTemplate> tCompanyTextBlastTemplateID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tCompany_Subscription> tCompany_SubscriptionID_CreatedByNavigation { get; set; }
        public virtual ICollection<tCompany_Subscription> tCompany_SubscriptionID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tCountry> tCountryID_CreatedByNavigation { get; set; }
        public virtual ICollection<tCountry> tCountryID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tCustomDetailViewRoute> tCustomDetailViewRouteID_CreatedByNavigation { get; set; }
        public virtual ICollection<tCustomDetailViewRoute> tCustomDetailViewRouteID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tCustomNavigationLink> tCustomNavigationLinkID_CreatedByNavigation { get; set; }
        public virtual ICollection<tCustomNavigationLink> tCustomNavigationLinkID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tDentalExamination> tDentalExaminationID_CreatedByNavigation { get; set; }
        public virtual ICollection<tDentalExamination> tDentalExaminationID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tDentition> tDentitionID_CreatedByNavigation { get; set; }
        public virtual ICollection<tDentition> tDentitionID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tDoc> tDocID_CreatedByNavigation { get; set; }
        public virtual ICollection<tDoc> tDocID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tDocumentSeries> tDocumentSeriesID_CreatedByNavigation { get; set; }
        public virtual ICollection<tDocumentSeries> tDocumentSeriesID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tDocumentStatus> tDocumentStatusID_CreatedByNavigation { get; set; }
        public virtual ICollection<tDocumentStatus> tDocumentStatusID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tEmployee> tEmployee { get; set; }
        public virtual ICollection<tEmployeeInfo> tEmployeeInfoID_CreatedByNavigation { get; set; }
        public virtual ICollection<tEmployeeInfo> tEmployeeInfoID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tEmployeePosition> tEmployeePositionID_CreatedByNavigation { get; set; }
        public virtual ICollection<tEmployeePosition> tEmployeePositionID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tEmploymentStatus> tEmploymentStatusID_CreatedByNavigation { get; set; }
        public virtual ICollection<tEmploymentStatus> tEmploymentStatusID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tEmplyee> tEmplyeeID_CreatedByNavigation { get; set; }
        public virtual ICollection<tEmplyee> tEmplyeeID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tExpenseCategory> tExpenseCategoryID_CreatedByNavigation { get; set; }
        public virtual ICollection<tExpenseCategory> tExpenseCategoryID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tFileUpload> tFileUploadID_CreatedByNavigation { get; set; }
        public virtual ICollection<tFileUpload> tFileUploadID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tFilingStatus> tFilingStatusID_CreatedByNavigation { get; set; }
        public virtual ICollection<tFilingStatus> tFilingStatusID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tForBilling> tForBillingID_CreatedByNavigation { get; set; }
        public virtual ICollection<tForBilling> tForBillingID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tHelpDeskVideoTutorial> tHelpDeskVideoTutorialID_CreatedByNavigation { get; set; }
        public virtual ICollection<tHelpDeskVideoTutorial> tHelpDeskVideoTutorialID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tITextMoAPISMSStatus> tITextMoAPISMSStatusID_CreatedByNavigation { get; set; }
        public virtual ICollection<tITextMoAPISMSStatus> tITextMoAPISMSStatusID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tInventoryStatus> tInventoryStatusID_CreatedByNavigation { get; set; }
        public virtual ICollection<tInventoryStatus> tInventoryStatusID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tInventorySummary> tInventorySummaryID_CreatedByNavigation { get; set; }
        public virtual ICollection<tInventorySummary> tInventorySummaryID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tInventoryTrail> tInventoryTrailID_CreatedByNavigation { get; set; }
        public virtual ICollection<tInventoryTrail> tInventoryTrailID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tIssueTracker> tIssueTrackerID_CreatedByNavigation { get; set; }
        public virtual ICollection<tIssueTracker> tIssueTrackerID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tItemCategory> tItemCategoryID_CreatedByNavigation { get; set; }
        public virtual ICollection<tItemCategory> tItemCategoryID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tItem> tItemID_CreatedByNavigation { get; set; }
        public virtual ICollection<tItem> tItemID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tItemInventoriable> tItemInventoriableID_CreatedByNavigation { get; set; }
        public virtual ICollection<tItemInventoriable> tItemInventoriableID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tItemService> tItemServiceID_CreatedByNavigation { get; set; }
        public virtual ICollection<tItemService> tItemServiceID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tItemType> tItemTypeID_CreatedByNavigation { get; set; }
        public virtual ICollection<tItemType> tItemTypeID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tItem_UnitCostLog> tItem_UnitCostLogID_CreatedByNavigation { get; set; }
        public virtual ICollection<tItem_UnitCostLog> tItem_UnitCostLogID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tItem_UnitPriceLog> tItem_UnitPriceLogID_CreatedByNavigation { get; set; }
        public virtual ICollection<tItem_UnitPriceLog> tItem_UnitPriceLogID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tLocalShippingPermitIssuance> tLocalShippingPermitIssuanceID_CreatedByNavigation { get; set; }
        public virtual ICollection<tLocalShippingPermitIssuance> tLocalShippingPermitIssuanceID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tLocalShippingPermitIssuance_Item> tLocalShippingPermitIssuance_ItemID_CreatedByNavigation { get; set; }
        public virtual ICollection<tLocalShippingPermitIssuance_Item> tLocalShippingPermitIssuance_ItemID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tLocalShippingPermitIssuance_Requirement> tLocalShippingPermitIssuance_RequirementID_CreatedByNavigation { get; set; }
        public virtual ICollection<tLocalShippingPermitIssuance_Requirement> tLocalShippingPermitIssuance_RequirementID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tMedicalHistoryQuestionnaire> tMedicalHistoryQuestionnaireID_CreatedByNavigation { get; set; }
        public virtual ICollection<tMedicalHistoryQuestionnaire> tMedicalHistoryQuestionnaireID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tMedicationRoute> tMedicationRouteID_CreatedByNavigation { get; set; }
        public virtual ICollection<tMedicationRoute> tMedicationRouteID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tMessage> tMessageID_CreatedByNavigation { get; set; }
        public virtual ICollection<tMessage> tMessageID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tPatientAppointment> tPatientAppointmentID_CreatedByNavigation { get; set; }
        public virtual ICollection<tPatientAppointment> tPatientAppointmentID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tPatient> tPatientID_CreatedByNavigation { get; set; }
        public virtual ICollection<tPatient> tPatientID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tPatientSOAPList> tPatientSOAPListID_CreatedByNavigation { get; set; }
        public virtual ICollection<tPatientSOAPList> tPatientSOAPListID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tPatientWaitingList> tPatientWaitingListID_CreatedByNavigation { get; set; }
        public virtual ICollection<tPatientWaitingList> tPatientWaitingListID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tPatientWaitingList_Logs> tPatientWaitingList_LogsID_CreatedByNavigation { get; set; }
        public virtual ICollection<tPatientWaitingList_Logs> tPatientWaitingList_LogsID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tPatient_BirthDateSMSGreetingLog> tPatient_BirthDateSMSGreetingLogID_CreatedByNavigation { get; set; }
        public virtual ICollection<tPatient_BirthDateSMSGreetingLog> tPatient_BirthDateSMSGreetingLogID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tPatient_Confinement> tPatient_ConfinementID_CreatedByNavigation { get; set; }
        public virtual ICollection<tPatient_Confinement> tPatient_ConfinementID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tPatient_Confinement_ItemsServices> tPatient_Confinement_ItemsServicesID_CreatedByNavigation { get; set; }
        public virtual ICollection<tPatient_Confinement_ItemsServices> tPatient_Confinement_ItemsServicesID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tPatient_Confinement_Patient> tPatient_Confinement_PatientID_CreatedByNavigation { get; set; }
        public virtual ICollection<tPatient_Confinement_Patient> tPatient_Confinement_PatientID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tPatient_CreditLogs> tPatient_CreditLogsID_CreatedByNavigation { get; set; }
        public virtual ICollection<tPatient_CreditLogs> tPatient_CreditLogsID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tPatient_DentalExamination_Image> tPatient_DentalExamination_ImageID_CreatedByNavigation { get; set; }
        public virtual ICollection<tPatient_DentalExamination_Image> tPatient_DentalExamination_ImageID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tPatient_DentalExamination_MedicalHistory> tPatient_DentalExamination_MedicalHistoryID_CreatedByNavigation { get; set; }
        public virtual ICollection<tPatient_DentalExamination_MedicalHistory> tPatient_DentalExamination_MedicalHistoryID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tPatient_DentalExamination_ToothInfo> tPatient_DentalExamination_ToothInfoID_CreatedByNavigation { get; set; }
        public virtual ICollection<tPatient_DentalExamination_ToothInfo> tPatient_DentalExamination_ToothInfoID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tPatient_Lodging> tPatient_LodgingID_CreatedByNavigation { get; set; }
        public virtual ICollection<tPatient_Lodging> tPatient_LodgingID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tPatient_SOAP> tPatient_SOAPID_CreatedByNavigation { get; set; }
        public virtual ICollection<tPatient_SOAP> tPatient_SOAPID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tPatient_SOAP_Prescription> tPatient_SOAP_PrescriptionID_CreatedByNavigation { get; set; }
        public virtual ICollection<tPatient_SOAP_Prescription> tPatient_SOAP_PrescriptionID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tPatient_SOAP_SMSStatus> tPatient_SOAP_SMSStatusID_CreatedByNavigation { get; set; }
        public virtual ICollection<tPatient_SOAP_SMSStatus> tPatient_SOAP_SMSStatusID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tPatient_SOAP_Treatment> tPatient_SOAP_TreatmentID_CreatedByNavigation { get; set; }
        public virtual ICollection<tPatient_SOAP_Treatment> tPatient_SOAP_TreatmentID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tPatient_Vaccination> tPatient_VaccinationID_CreatedByNavigation { get; set; }
        public virtual ICollection<tPatient_Vaccination> tPatient_VaccinationID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tPatient_Vaccination_Schedule> tPatient_Vaccination_ScheduleID_CreatedByNavigation { get; set; }
        public virtual ICollection<tPatient_Vaccination_Schedule> tPatient_Vaccination_ScheduleID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tPatient_Vaccination_Schedule_SMSStatus> tPatient_Vaccination_Schedule_SMSStatusID_CreatedByNavigation { get; set; }
        public virtual ICollection<tPatient_Vaccination_Schedule_SMSStatus> tPatient_Vaccination_Schedule_SMSStatusID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tPatient_Wellness> tPatient_WellnessID_CreatedByNavigation { get; set; }
        public virtual ICollection<tPatient_Wellness> tPatient_WellnessID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tPatient_Wellness_Detail> tPatient_Wellness_DetailID_CreatedByNavigation { get; set; }
        public virtual ICollection<tPatient_Wellness_Detail> tPatient_Wellness_DetailID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tPatient_Wellness_Schedule> tPatient_Wellness_ScheduleID_CreatedByNavigation { get; set; }
        public virtual ICollection<tPatient_Wellness_Schedule> tPatient_Wellness_ScheduleID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tPatient_Wellness_Schedule_SMSStatus> tPatient_Wellness_Schedule_SMSStatusID_CreatedByNavigation { get; set; }
        public virtual ICollection<tPatient_Wellness_Schedule_SMSStatus> tPatient_Wellness_Schedule_SMSStatusID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tPayable> tPayableID_CreatedByNavigation { get; set; }
        public virtual ICollection<tPayable> tPayableID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tPayablePayment> tPayablePaymentID_CreatedByNavigation { get; set; }
        public virtual ICollection<tPayablePayment> tPayablePaymentID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tPayable_Detail> tPayable_DetailID_CreatedByNavigation { get; set; }
        public virtual ICollection<tPayable_Detail> tPayable_DetailID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tPaymentMethod> tPaymentMethodID_CreatedByNavigation { get; set; }
        public virtual ICollection<tPaymentMethod> tPaymentMethodID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tPaymentTransaction> tPaymentTransactionID_CreatedByNavigation { get; set; }
        public virtual ICollection<tPaymentTransaction> tPaymentTransactionID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tPurchaseOrder> tPurchaseOrderID_ApprovedByNavigation { get; set; }
        public virtual ICollection<tPurchaseOrder> tPurchaseOrderID_CreatedByNavigation { get; set; }
        public virtual ICollection<tPurchaseOrder> tPurchaseOrderID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tQuestionType> tQuestionTypeID_CreatedByNavigation { get; set; }
        public virtual ICollection<tQuestionType> tQuestionTypeID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tReceivingReport> tReceivingReportID_CreatedByNavigation { get; set; }
        public virtual ICollection<tReceivingReport> tReceivingReportID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tReceivingReport_Detail> tReceivingReport_DetailID_CreatedByNavigation { get; set; }
        public virtual ICollection<tReceivingReport_Detail> tReceivingReport_DetailID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tRecurScheduleType> tRecurScheduleTypeID_CreatedByNavigation { get; set; }
        public virtual ICollection<tRecurScheduleType> tRecurScheduleTypeID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tSMSPatientSOAP_Company> tSMSPatientSOAP_CompanyID_CreatedByNavigation { get; set; }
        public virtual ICollection<tSMSPatientSOAP_Company> tSMSPatientSOAP_CompanyID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tSOAPType> tSOAPTypeID_CreatedByNavigation { get; set; }
        public virtual ICollection<tSOAPType> tSOAPTypeID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tSalesReturn> tSalesReturnID_CreatedByNavigation { get; set; }
        public virtual ICollection<tSalesReturn> tSalesReturnID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tSalesReturn_Detail> tSalesReturn_DetailID_CreatedByNavigation { get; set; }
        public virtual ICollection<tSalesReturn_Detail> tSalesReturn_DetailID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tSchedule> tScheduleID_CreatedByNavigation { get; set; }
        public virtual ICollection<tSchedule> tScheduleID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tServiceType> tServiceTypeID_CreatedByNavigation { get; set; }
        public virtual ICollection<tServiceType> tServiceTypeID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tSetting> tSettingID_CreatedByNavigation { get; set; }
        public virtual ICollection<tSetting> tSettingID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tStudent> tStudentID_CreatedByNavigation { get; set; }
        public virtual ICollection<tStudent> tStudentID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tSupplier> tSupplierID_CreatedByNavigation { get; set; }
        public virtual ICollection<tSupplier> tSupplierID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tTaxScheme> tTaxSchemeID_CreatedByNavigation { get; set; }
        public virtual ICollection<tTaxScheme> tTaxSchemeID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tTeacher> tTeacherID_CreatedByNavigation { get; set; }
        public virtual ICollection<tTeacher> tTeacherID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tTeethQuandrant> tTeethQuandrantID_CreatedByNavigation { get; set; }
        public virtual ICollection<tTeethQuandrant> tTeethQuandrantID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tTextBlast> tTextBlastID_CreatedByNavigation { get; set; }
        public virtual ICollection<tTextBlast> tTextBlastID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tTextBlast_Client> tTextBlast_ClientID_CreatedByNavigation { get; set; }
        public virtual ICollection<tTextBlast_Client> tTextBlast_ClientID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tTextBlast_Client_SMSStatus> tTextBlast_Client_SMSStatusID_CreatedByNavigation { get; set; }
        public virtual ICollection<tTextBlast_Client_SMSStatus> tTextBlast_Client_SMSStatusID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tToothInfo> tToothInfoID_CreatedByNavigation { get; set; }
        public virtual ICollection<tToothInfo> tToothInfoID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tToothStatus> tToothStatusID_CreatedByNavigation { get; set; }
        public virtual ICollection<tToothStatus> tToothStatusID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tToothStatusType> tToothStatusTypeID_CreatedByNavigation { get; set; }
        public virtual ICollection<tToothStatusType> tToothStatusTypeID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tToothSurface> tToothSurfaceID_CreatedByNavigation { get; set; }
        public virtual ICollection<tToothSurface> tToothSurfaceID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tUnitOfMeasure> tUnitOfMeasureID_CreatedByNavigation { get; set; }
        public virtual ICollection<tUnitOfMeasure> tUnitOfMeasureID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tUserComment> tUserCommentID_CreatedByNavigation { get; set; }
        public virtual ICollection<tUserComment> tUserCommentID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tUserGroup> tUserGroupID_CreatedByNavigation { get; set; }
        public virtual ICollection<tUserGroup> tUserGroupID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tUserRole> tUserRoleID_CreatedByNavigation { get; set; }
        public virtual ICollection<tUserRole> tUserRoleID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tUserSession> tUserSession { get; set; }
        public virtual ICollection<tUser_Favorite> tUser_Favorite { get; set; }
        public virtual ICollection<tUser_Roles> tUser_Roles { get; set; }
        public virtual ICollection<tVeterinaryCertificate> tVeterinaryCertificateID_CreatedByNavigation { get; set; }
        public virtual ICollection<tVeterinaryCertificate> tVeterinaryCertificateID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tVeterinaryHealthCertificate> tVeterinaryHealthCertificateID_CreatedByNavigation { get; set; }
        public virtual ICollection<tVeterinaryHealthCertificate> tVeterinaryHealthCertificateID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tViewType> tViewTypeID_CreatedByNavigation { get; set; }
        public virtual ICollection<tViewType> tViewTypeID_LastModifiedByNavigation { get; set; }
        public virtual ICollection<tWarehouse> tWarehouseID_CreatedByNavigation { get; set; }
        public virtual ICollection<tWarehouse> tWarehouseID_LastModifiedByNavigation { get; set; }
    }
}
