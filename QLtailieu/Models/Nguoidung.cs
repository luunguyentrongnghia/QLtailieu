using System.ComponentModel.DataAnnotations.Schema;

namespace QLtailieu.Models
{
    public class Nguoidung
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NguoidungID { get; set; }
        public string NameNguoidung { get; set; }
        

        public ICollection<TaileuNguoidung> TaileuNguoidung { get; set; }
    }
}
