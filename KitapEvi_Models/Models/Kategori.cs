using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapEvi_Models.Models
{
    [Table("tb_Kategori")]
    //table data annotations: veri tabanında tablo adını düzenlemek için kullanılır.
    public class Kategori
    { 
        public int KategoriID { get; set; }       
        [Column("Ad")]// column annotations: veritabanında yer alan tablo içindeki kolon adını değiştirmek için kullanılır.
        [Required(ErrorMessage ="Bu alan boş geçilemez!")] //bu mesaj görünümle ilgilidir. yani bunu veritabanına kayıt etmeye gerek yoktur. o yüzden bu işlemi veritabanına kayıt etmeyiz.

       
        public string KategoriAd { get; set; }

        public List<Kitap> Kitaplar { get; }




    }
}
