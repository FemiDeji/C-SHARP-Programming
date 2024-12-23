namespace LoginAuthAPI.Models
{
    public class Login 
    {
        public string? Staff_ID { get; set; }
        
        public string? Password { get; set; }

        public string? UserMessage {get; set; }

        public string? UserToken {get; set; }

    }
}