using System.Net;

namespace Test.Helpers
{
    public class ApiCallResult<X> where X : class
    {
        public HttpStatusCode StatusCode { get; set; }
        public string ReasonPhrase { get; set; }

        public bool IsError { get; set; }
        public bool IsException { get; set; }
        public string Message { get; set; }

        public X ResponseObject { get; set; } //deserialized object, could be List, int string or just a single object
    }
}
