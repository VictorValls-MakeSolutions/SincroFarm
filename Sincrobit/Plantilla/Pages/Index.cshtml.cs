using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Plantilla.Data;
using VisitasECI.Clases;

namespace Plantilla.Pages
{
    public class IndexModel : PageModel
    {
        private readonly PlantillaContext _eciContext;
        private readonly FuncionesComunes fc;

        public IndexModel(PlantillaContext eciContext)
        {
            //_balContext = new BalContext();
            _eciContext = eciContext;
            fc = new FuncionesComunes();
        }


        public void OnGet(string? centroselect)
        {

        }

        public IActionResult OnPost()
        {
            //return RedirectToPage("/Index", new { centroselect = centroSelect });
            return RedirectToPage("/Index");
        }
    }
}
