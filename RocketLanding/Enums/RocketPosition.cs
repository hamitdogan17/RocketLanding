namespace RocketLanding.Enums
{
    public enum RocketPosition
    {
        AvailableForLand = 0,
        AskedPosiion = 1,
        ClashPositions = 2,
    }
    public class LandingResponse
    {
        public const string OUTOFPLATFORM = "Out Of Platform";
        public const string OKFORLANDING = "Ok For Landing";
        public const string CLASH = "Clash";

    }
}
