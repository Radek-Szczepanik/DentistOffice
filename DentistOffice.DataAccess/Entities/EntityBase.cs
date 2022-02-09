using System.ComponentModel.DataAnnotations;

namespace DentistOffice.DataAccess.Entities
{
    public abstract class EntityBase
    {
        [Key]
        public int MyProperty { get; set; }
    }
}
