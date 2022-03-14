using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Practical2.pages
{   [BindProperties]
    public class ReceiveDetailsModel : PageModel
    {   public string Title{get;set;}
        public string Name{get;set;}
        public string Address{get;set;}
        public void OnGet()
        {
        }

        public void OnPost()
        {
            ViewData["NameLabel"]=$"Thank u {Title} {Name}";
            ViewData["NameLabel"]=$"Your address is {Address}";
        }
    }
}
