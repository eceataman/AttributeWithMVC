using AttributeWithMVC;
using MVCClassLibrary;

namespace AttributeWithMVC.Models
{
    public class Person
    {
        [RequiredField]
        public string Name { get; set; }
        [RequiredField]
        public string Surname { get; set; }
        [RequiredField]
        public string City { get; set; }
    }
}
