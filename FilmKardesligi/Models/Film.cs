using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmKardesligi.Models
{
    [Table("Filmler")]
    public class Film
    {
        [Column(Order = 1)]
        public int Id { get; set; }
        
        [Column("Derece")]
        public int Puan { get; set; }


        [Required]
        [MaxLength(200)]
        [Column(Order = 2)]
        public string FilmAd { get; set; }

        //[NotMapped] //databasede oluşturma sadece burda oluştur demek
        public string Kunye { get { return $"{Utilities.Yildizla(Puan)}{" "}{FilmAd}"+$"({ Turler.Select(x=>x.TurAd).Virgulle() })"; } }


        public virtual ICollection<Tur> Turler { get; set; } //birden fazla filme ait aynı tür olabilir veya birden fazla türe ait bir film olabilir bu yüzden tür ve filme bunu yapıyoruz ki birbiri arasında ara tablo oluşturup ilişki kurabilsin.

    }
}
