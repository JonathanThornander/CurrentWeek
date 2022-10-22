namespace Mindash.Countdown.Web.Models
{
    public class CountDownViewModel
    {
        public CountDownViewModel(string title, string hexColor, DateTime dateUTC)
        {
            Title = title;
            HexColor = hexColor;
            DateUTC = dateUTC;
        }

        public string Title { get; set; }

        public string HexColor { get; set; }

        public DateTime DateUTC { get; set; }

        public virtual string InfoText { get => GetTimeLeftDisplay(); }

        private string GetTimeLeftDisplay()
        {
            var spanBeteen = DateUTC - DateTime.UtcNow;

            if (spanBeteen > TimeSpan.Zero)
            {
                if (spanBeteen.TotalHours < 1)
                {
                    return $"{spanBeteen.Minutes} Minutes Left";
                }
                if (spanBeteen.TotalDays < 1)
                {
                    return $"{spanBeteen.Hours} Hours Left";
                }
                else
                {
                    return $"{spanBeteen.Days} Days Left";
                }
            }
            else
            {
                if (spanBeteen.TotalHours > -1)
                {
                    return $"{Math.Abs(spanBeteen.Minutes)} Minutes Since";
                }
                if (spanBeteen.TotalDays > -1)
                {
                    return $"{Math.Abs(spanBeteen.Hours)} Hours Since";
                }
                else
                {
                    return $"{Math.Abs(spanBeteen.Days)} Days Since";
                }
            }

            
        }
    }

    public class LoadingCountDownViewModel : CountDownViewModel
    {
        public override string InfoText { get => "..."; }

        public LoadingCountDownViewModel() : base("Loading...", "gray", DateTime.UtcNow)
        {
        }
    }

    public class EmptyCountDownViewModel : CountDownViewModel
    {
        public override string InfoText { get => "📆"; }

        public EmptyCountDownViewModel() : base("Click anywhere to begin", "gray", DateTime.UtcNow)
        {

        }
    }
}
