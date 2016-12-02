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
        int Count = RepeatCounter.CountRepeats(Request.Form["word"], Request.Form["sentence"]);
        return View["results.cshtml", Count];
      };
    }
  }
}
