using System.ComponentModel.DataAnnotations;

namespace DentistOffice.DataAccess.Entities
{
    public class EntityBase
    {
        [Key]
        public int Id { get; set; }
    }
}
