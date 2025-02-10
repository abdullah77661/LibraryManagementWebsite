namespace LMS_APIs.Models
{
    public class Response
    {
        public int StatusCode { get; set; }
        public string StatusMessage { get; set; }
        public string Branches { get; set; }
        public List<Branch> isBranch { get; set; }
    }
}
