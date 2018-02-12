namespace ByteNuts.PrimaveraBss.JasminSdk.Core.Models
{
    public class ApiResponse<T>
    {
        public bool Success { get; set; }
        public string Error { get; set; }
        public int HttpStatusCode { get; set; }
        public string HttpStatusCodeDesc { get; set; }
        public T Response { get; set; }
    }
}
