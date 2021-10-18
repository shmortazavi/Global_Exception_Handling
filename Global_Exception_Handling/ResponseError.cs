using System.Text.Json;

namespace Global_Exception_Handling
{
    public class ResponseError
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
