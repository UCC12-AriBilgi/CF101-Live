namespace P02_CF_wData.Entities
{
    public class Teacher
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; } // öğretmen aktif/pasif
        public bool IsRetired { get; set; } // öğretmen emekli/değil

        public IEnumerable<Student> Students { get; set; } // Öğrenci sınıf/tablosu ile bağlantı
    }
}
