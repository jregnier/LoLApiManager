namespace Team7.LoLApiManager.Core
{
    public enum LoLApiErrors
    {
        BadRequest = 400,
        Unauthorized = 401,
        DataNotFound = 404,
        RateLimitExceeded = 429,
        InternalServerError = 500,
        ServiceUnavailable = 503
    }
}