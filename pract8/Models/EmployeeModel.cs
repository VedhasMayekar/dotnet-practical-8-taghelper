using Microsoft.AspNetCore.Mvc.Rendering;

namespace pract8.Models
{
    public class EmployeeModel
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Bio { get; set; }
        public string? SelectedCountry { get; set; }
        public List<SelectListItem> Countries { get; set; } = new();
        public bool IsSubscribed { get; set; }
        public string? Password { get; set; }
        public bool IsAdmin { get; set; }
        public List<string> SelectedHobbies { get; set; } = new();
    }
}
