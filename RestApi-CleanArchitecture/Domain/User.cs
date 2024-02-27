namespace RestApi_CleanArchitecture.Domain
{
    public class User
    {
        public User()
        {
            IsDeleted = false;
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsDeleted { get; set; }

        public void Update(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void Deleted()
        {
            IsDeleted = true;
        }
    }
}
