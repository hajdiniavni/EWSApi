namespace EWSApi.Models.Indexing
{
    public class ElasticSearchReportList
    {
        public string Id { get; set; } = null!;
        public int ReportRegisterId { get; set; }
        public string? UniqueNumber { get; set; }
        public string? PersonalNumber { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? Age { get; set; }

        public DateTime? TreatmentStartDate { get; set; }
        public int? DiseaseDataEncrypted { get; set; }
        public int? DiseaseId { get; set; }
        public string? Disease { get; set; }
        public string? SyndromeType { get; set; }
        public string? PatientStatus { get; set; }

        public DateTime? ReportInsertedDate { get; set; }
        public DateTime? ReportRegisterStatusInsertedDate { get; set; }
        public string? ReportRegisterStatusInsertedFrom { get; set; }
        public string? ReportRegisterInsertedFrom { get; set; }

        public DateTime? ConsultingDate { get; set; }
        public int? ReportRegisterStatusTypeID { get; set; }

        public string? TrackingStatusType { get; set; }
        public int? TrackingStatusID { get; set; }

        public int? CitizenCityId { get; set; }
        public int? CitizenRegionId { get; set; }
        public string? CitizenCity { get; set; }
        public string? CitizenRegion { get; set; }
        public int? CitizenForeign { get; set; }

        public int? HealthInstitutionId { get; set; }
        public int? HealthInstitutionCityId { get; set; }
        public int? HealthInstitutionRegionId { get; set; }
        public string? HealthInstitutionCity { get; set; }
        public string? HealthInstitution { get; set; }

        public string? MedicalStaff { get; set; }
        public string? PatientCodeHiv { get; set; }

        public int? ReferenceHealthInstitutionToID { get; set; }
        public int? HasContact { get; set; }
        public int? HasSurvey { get; set; }
        public int? HasReportTreatment { get; set; }

        public int? IsTB { get; set; }
    }
}
