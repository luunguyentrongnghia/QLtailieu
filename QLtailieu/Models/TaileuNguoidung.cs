using System.ComponentModel.DataAnnotations;

namespace QLtailieu.Models
{
    
        public enum Grade
        {
            A, B, C, D, F
        }

        public class TaileuNguoidung
    {
            public int TaileuNguoidungID { get; set; }
            public int NguoidungID { get; set; }
            public int TailieuID { get; set; }
            [DisplayFormat(NullDisplayText = "No grade")]
            public Grade? Grade { get; set; }

            public Nguoidung Nguoidung { get; set; }
            public Tailieu Tailieu { get; set; }
        }
    
}
