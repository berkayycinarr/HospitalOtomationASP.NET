using System.ComponentModel.DataAnnotations;

namespace HospitalASystem.Models
{
    public class AnaBilimDali
    {
        
        public int Id { get; set; }

        [Display(Name = "Doktor Adı")]
        public string Ad { get; set; }
    }
}
