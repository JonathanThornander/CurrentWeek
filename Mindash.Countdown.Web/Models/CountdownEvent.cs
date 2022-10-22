namespace Mindash.Countdown.Web.Data.DTOS
{
    public class CountdownEvent
    {
        private CountdownEvent()
        {

        }

        public CountdownEvent(string title, DateTime dateTime, string hexColor)
        {
            Title = title;
            DateTime = dateTime;
            HexColor = hexColor;
        }

        public Guid ID { get; set; } = Guid.NewGuid();

        public string Title { get; set; } = string.Empty;

        public string HexColor { get; set; } = string.Empty;

        public DateTime DateTime { get; set; }
    }
}
