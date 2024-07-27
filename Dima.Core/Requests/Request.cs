namespace Dima.Core.Requests
{
    public abstract class Request// padronização dos requests 
    {
        public string UserId { get; set; } = string.Empty;
    }
}