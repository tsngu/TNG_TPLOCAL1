using Microsoft.AspNetCore.Mvc;
using TPLOCAL1.Models;

//Subject is find at the root of the project and the logo in the wwwroot/ressources folders of the solution
//--------------------------------------------------------------------------------------
//Careful, the MVC model is a so-called convention model instead of configuration,
//The controller must imperatively be name with "Controller" at the end !!!
namespace TPLOCAL1.Controllers
{
    public class HomeController : Controller
    {
        //methode "naturally" call by router
        public ActionResult Index(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                //retourn to the Index view (see routing in Program.cs)
                return View("Index", new Information());
            else
            {
                //Call different pages, according to the id pass as parameter
                switch (id)
                {
                    case "OpinionList":
                        //TODO : code reading of the xml files provide
                        OpinionList avis = new OpinionList();
                        List<Opinion> opinions = avis.GetAvis("XlmFile/DataAvis.xml");
                        return View(id, opinions);
                    case "Form":
                        //TODO : call the Form view with data model empty
                        return View(id);
                    default:
                        //retourn to the Index view (see routing in Program.cs)
                        return View("Index", new Information());
                }
            }
        }


        //methode to send datas from form to validation page
        [HttpPost]
        public ActionResult ValidationFormulaire(Information model)
        {
            if (ModelState.IsValid)
            {
                // Tout est valide → page de confirmation
                return View("FormValidation", model);
            }
            else
            {
                // Erreur de validation → retour au formulaire
                return View("Form", model);

            }
        }
    }
}