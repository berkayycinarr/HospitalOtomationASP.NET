namespace HospitalASystem.Models
{
    public class Poliklinik
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public int AnaBilimDaliId { get; set; } 
        // Poliklinik nesnesinin hangi ana bilim dalı nesnesine ait olduğunu gösterir.
        public AnaBilimDali AnaBilimDali { get; set; } 
        // Polinik nesnesinin bağlı olduğu AnaBilimDali özelliği AnaBilimDali nesnesini referans içerir.
    }
}
