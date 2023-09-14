namespace HMS.Helpers
{
    public class ServiceResponse<T>
    {
        public T? Data { get; set; }
        public bool Status { get; set; } = false;
        public String Message { get; set; }=string.Empty;
    }
}
