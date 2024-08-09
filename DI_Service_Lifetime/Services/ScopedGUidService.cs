namespace DI_Service_Lifetime.Services
{
    public class ScopedGUidService : IScopedGuidService
    {
        private readonly Guid Id;
        public ScopedGUidService()
        {
            Id = Guid.NewGuid();
        }

        public string GetGuid()
        {
            return Id.ToString();
        }
    }
}
