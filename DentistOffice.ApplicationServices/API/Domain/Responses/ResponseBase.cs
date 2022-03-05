namespace DentistOffice.ApplicationServices.API.Domain.Responses
{
    public class ResponseBase<T> : ErrorResponseBase
    {
        public T Data { get; set; }
    }
}
