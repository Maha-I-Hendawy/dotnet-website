using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace mywebapp.Pages
{
    public class aboutModel : PageModel
    {   
        public string Myname;

    
        public void OnGet()
        {
            Myname = "Kiki";
           
        }
    }
}
