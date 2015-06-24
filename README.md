# nmct.own.httpresponse
A Http Response Helper for your API

Sample API

´´´
public class PersonApiController : ApiController
{
  public HttpResponseMessage Get()
  {
    try
    {
      return HttpResponseHelper.ReturnSuccesfulMessage();
    }
    catch(Exception ex)
    {
      return HttpResponseHelper.ReturnBadRequest();
    }
  }
}
´´´
