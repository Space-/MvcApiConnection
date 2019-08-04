using System.ComponentModel.DataAnnotations;

namespace MvcApiConnection.Models
{
    public class Person
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public int Height { get; set; }

        public bool IsAdmin()
        {
            var adminPerson = new Person { Name = "bruce", Height = 173 };
            return Name == adminPerson.Name && Height == adminPerson.Height;
        }
    }
}