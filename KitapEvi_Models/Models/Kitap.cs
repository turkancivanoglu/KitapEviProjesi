using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapEvi_Models.Models
{
    [Table("tb_Kitap")]
    public class Kitap
    {
        public int KitapID { get; set; }
        [Required]
        public string KitapAdi { get; set; }
        [Required] //boş geçilemez, gerekli
        public double Fiyat { get; set; }
        [Required, MaxLength(13)]
        public string ISBN { get; set; }
        [NotMapped] //veri tabanına yansıtma yapmaz
        public double indirimlifiyat { get; set; }



        [ForeignKey("Kategori")]
        public int? KategoriID { get; set; } // ? işareti ile boş geçilebilir demiş olduk
        public Kategori Kategori { get; set; }



        [ForeignKey("Yayinevi")]
        public int YayineviID { get; set; }
        public Yayinevi Yayinevi { get; set; }


        public int? KitapDetayID { get; set; }
        public KitapDetay KitapDetay {get; set; }


        public ICollection<KitapİYazarlar> KitapİYazarlar { get; set; }


    }
}
