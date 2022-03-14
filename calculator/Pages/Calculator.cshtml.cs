using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Practical2.pages
{
    [BindProperties]
    public class CalculatorModel : PageModel
    {

        public double First{get;set;}
        public double Second{get;set;}
        public string Command{get;set;}
        public double Result{get;set;}
        public void OnGet()
        {
        }
        private void PrintToScreen(){
            ViewData["First"]=$"{First}";
            ViewData["Second"]=$"{Second}";
            ViewData["Result"]=$"{Result}";
        }
        public void OnPost(){
            if(Command.Equals("add")){
                Result=First+Second;
                PrintToScreen();
            }
            else if(Command.Equals("sub")){
                Result=First-Second;
                PrintToScreen();
            }
            else if(Command.Equals("mul")){
                Result=First*Second;
                PrintToScreen();
            }
            else if(Command.Equals("div")){
                Result=First/Second;
                PrintToScreen();
            }
            else{
                ModelState.Clear();
            }
        }
    }
}
