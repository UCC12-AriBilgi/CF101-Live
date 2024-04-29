namespace P01_CF.Entities
{
    public class Person
    {
        // Olmayan bir DB üzerinde yer alacak bir tableın(Person) görünümünü code tarafında gerçekleştiriyorum.

        public int PersonId { get; set; }
        public string PFName { get; set; }
        public string PLName { get; set; }
        public string PEMail {  get; set; }
        public string PPhone { get; set; }
        public string PAddress { get; set; }
        public string PPostCode { get; set; }
        public string PCity { get; set; }
        public GenderENum PGender { get; set; }
    }
}
