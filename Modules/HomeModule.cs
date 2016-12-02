using Nancy;
using WordCounter.Objects;

namespace WordCounter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/score"] = _ => {
        int Count = RepeatCounter.CountRepeats(Request.Form["sentence"], Request.Form["word"]);
        return View["results.cshtml", Count];
      };
    }
  }
}
