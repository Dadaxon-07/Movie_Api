using LinqToDB.Mapping;

namespace Movie_Api.Model
{
    public class Author
    {
        [Identity]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
