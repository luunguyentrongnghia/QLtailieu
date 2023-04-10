namespace QLtailieu.Models
{
    public class Tailieu
    {
        public int ID { get; set; }
        public string Nametailieu { get; set; }
        public string NameNSX { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public ICollection<TaileuNguoidung> TaileuNguoidung { get; set; }
    }
}
