using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace nmct.own.httpresponse
{
    public class HttpResponseHelper
    {
        public static HttpResponseMessage ReturnSuccesfulMessage<T>(T item, string format = ContentNegotiation.JSON_RESULT)
        {
            return GetSuccesfulMessage(JsonConvert.SerializeObject(item), format);
        }

        private static HttpResponseMessage GetSuccesfulMessage(string content, string format)
        {
            HttpResponseMessage message = new HttpResponseMessage(HttpStatusCode.OK);
            message.Content = new StringContent(content, Encoding.UTF8, format);
            return message;
        }

        public static HttpResponseMessage ReturnBadRequest(string format = ContentNegotiation.JSON_RESULT)
        {
            return GetBadRequestMessage(JsonConvert.SerializeObject(ErrorMessage.ERROR_BADREQUEST), format);
        }

        private static HttpResponseMessage GetBadRequestMessage(string content, string format)
        {
            HttpResponseMessage message = new HttpResponseMessage(HttpStatusCode.BadRequest);
            message.Content = new StringContent(content, Encoding.UTF8, format);
            return message;
        }
    }
}
