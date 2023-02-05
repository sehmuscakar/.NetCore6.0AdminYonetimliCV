

using System.ComponentModel.DataAnnotations;

namespace AdminYonetimliCV.Models.Siniflar
{
    public class Anasayfa
    {
        [Key]
        public int id { get; set; }
        public string isim { get; set; }
        public string unvan { get; set; }
        public string acıklama { get; set; }
        public string iletisim { get; set; }
    }
}
