using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {

    [Route("/form")] // annotation
    public ActionResult Form() // method (ActionResult = type)
    {
      return View();
    }
    [Route ("/postcard")] // should be the same as form action
    public ActionResult Postcard (string recipient, string sender, string location) // Postcard method name should match cshtml name
    {
      LetterVariable myLetterVariable = new LetterVariable ();
      myLetterVariable.SetRecipient (recipient);
      myLetterVariable. SetSender (sender);
      myLetterVariable.SetLocation (location);
      return View (myLetterVariable);
    }
    [Route ("/hello")]
    public string Hello()
    {
      return "Hello friend!" ;
    }

    [Route ("/goodbye")]
    public string Goodbye()
     {
       return "Goodbye,friend!" ;
     }



    [Route ("/journal")]
    public ActionResult Journal()
    {
      return View();
    }
  }
}
