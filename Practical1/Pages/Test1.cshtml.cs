using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Practical1.Pages
{
    public class Test1Model : PageModel
    {
        public int result{get; set;}
        
    }
    public void OnGet()
    {
        int a=4;
        int b=8;
        result = a + b;
    }
}
