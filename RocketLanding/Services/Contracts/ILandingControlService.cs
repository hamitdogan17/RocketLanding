namespace RocketLanding.Services.Contracts
{
    public interface ILandingControlService
    {
        string LandingPlatformControl(int[,] landingPlatform, int x, int y);
    }
}
