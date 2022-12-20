namespace CoursWebTokens.Interfaces
{
    public interface ITokenService
    {
        public string Authenticate(string username, string password);
    }
}
