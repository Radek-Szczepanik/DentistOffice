using System.ComponentModel.DataAnnotations;

namespace DentistOffice.DataAccess.Entities
{
    public class UserCard : EntityBase
    {
        [Required]
        public bool IsAllergy { get; set; }
        [Required]
        public bool IsDiabetes { get; set; }
        [Required]
        public bool IsHypertension { get; set; }
        [Required]
        public bool IsHeartDiseases { get; set; }
        [Required]
        public bool IsJaundice { get; set; }
        [Required]
        public bool IsPregnancy { get; set; }
        [Required]
        public bool IsCough { get; set; }
        [Required]
        public bool IsQuarantine { get; set; }
        [Required]
        public decimal BodyTemperature  { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}