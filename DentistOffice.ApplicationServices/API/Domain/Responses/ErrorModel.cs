namespace DentistOffice.ApplicationServices.API.Domain.Responses
{
    public class ErrorModel
    {
        public string Error { get; }

        public ErrorModel(string error)
        {
            this.Error = error;
        }
    }
}
