namespace MyShopCore.Web.Api.Brokers.DateTimes
{
    public class DateTimeBroker : IDateTimeBroker
    {
        //public DateTimeOffset GetCurrentDatetme()
        //{
        //    throw new NotImplementedException();
        //}
        public DateTimeOffset GetCurrentDatetime() => DateTime.UtcNow;
        
    }
}
