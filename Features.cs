
// Variable Scope and Braces
static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      {
        var theVariable = "I'm the variable";
        Console.WriteLine(theVariable);
      }
|   }

// When

private static string evaluateScore(int score)
{
  var result = "";

  switch (score)
  {
    case int n when (n < 6):
      result = "Your score doesn't look good...";
      break;

    case int n when (n >= 6 && n <= 7):
      result = "Your score is not bad!";
      break;
    
    case int n when (n > 7 && n <= 9):
      result = "Your score is pretty good!";
      break;
    
    case int n when (n > 9):
      result = "Your score is awesome!";
      break;
  }

  return result;
}


public static async Task<string> MakeRequest()
{
  var client = new System.Net.Http.HttpClient();
  var streamTask = client.GetStringAsync("https://auth0.com/this-page-doesnt-exist");

  try
  {
    var responseText = await streamTask;
    return responseText;
  }
  catch (HttpRequestException e) when (e.StatusCode == HttpStatusCode.MovedPermanently)
  {
    return "The page moved.";
  }
  catch (HttpRequestException e) when (e.StatusCode == HttpStatusCode.NotFound)
  {
    return "The page was not found";
  }
  catch (HttpRequestException e)
  {
    return e.Message;
  }
}

