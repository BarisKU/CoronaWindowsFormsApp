using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaApp.Models
{
    class Kisi
    {
        public int Id { get; set; }
        public string AdSoyad { get; set; }
        public int SehirId { get; set; }
        public Byte Yas { get; set; }
        public Cinsiyet Cinsiyet { get; set; }
        public DateTime DogumTarihi { get; set; }
    }
}
