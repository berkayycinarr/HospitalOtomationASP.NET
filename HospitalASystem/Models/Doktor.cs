namespace HospitalASystem.Models
{
    public class Doktor
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int PoliklinikId { get; set; }
        public Poliklinik Poliklinik { get; set; }
    }
}
