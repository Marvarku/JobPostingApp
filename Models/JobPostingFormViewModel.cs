namespace JobPostingApp.Models
{
    /// <summary>
    /// View model for creating or editing a job posting.
    /// Only frontend/form fields for now.
    /// </summary>
    public class JobPostingFormViewModel
    {
        // Company / Unternehmen
        public string? CompanyName { get; set; }
        public int? EmployeeCount { get; set; }
        public string? CompanyLocations { get; set; } // comma-separated
        public string? LogoUrl { get; set; }
        public string? BannerUrl { get; set; }
        public string? CompanyDescription { get; set; }
        public string? Benefits { get; set; } // comma-separated

        // Contact person / Ansprechpartner
        public string? Salutation { get; set; }
        public string? ContactFirstName { get; set; }
        public string? ContactLastName { get; set; }
        public string? ContactPhone { get; set; }
        public string? ContactEmail { get; set; }

        // Billing address / Rechnungsadresse
        public string? BillingStreet { get; set; }
        public string? BillingHouseNumber { get; set; }
        public string? BillingPostalCode { get; set; }
        public string? BillingCity { get; set; }
        public string? Iban { get; set; }
        public string? Bic { get; set; }

        // Job posting / Stelle
        public string? JobTitle { get; set; }
        public string? Departments { get; set; } // comma-separated Fachbereiche
        public string? ContractType { get; set; } // Temporary / Permanent
        public string? PositionType { get; set; } // Art der Stelle
        public string? WorkScope { get; set; }    // Fulltime / Parttime
        public DateTime? StartDate { get; set; }
        public string? ItSkills { get; set; }     // comma-separated
        public string? JobPostalCodes { get; set; } // comma-separated PLZ
        public string? GermanLevel { get; set; }  // A1–C2
        public string? JobDescription { get; set; } // Markup/HTML text
        public string? DrivingLicenseClass { get; set; }

        // Additional fields / Weitere Felder
        public int? YearsOfExperience { get; set; }
        public bool Remote { get; set; }
        public bool OpenToRelocation { get; set; }
        public bool WillingToTravel { get; set; }
    }
}

