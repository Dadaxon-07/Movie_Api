using LinqToDB.Mapping;

namespace Movie_Api.Model
{
    public class Moveis
    {
        [Identity]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Discreption { get; set; }
        public string Image { get; set; }
        public virtual Author? Authors { get; set; }
    }
}
