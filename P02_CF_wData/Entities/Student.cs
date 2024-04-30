namespace P02_CF_wData.Entities
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string StudentNo { get; set; }
        public bool IsActive { get; set; } // Öğrenci aktif/pasif

        public Teacher Teacher { get; set; } // Öğrencinin bağlı olduğu öğretmen
    }
}
