using RocketLanding.Enums;
using RocketLanding.Services.Contracts;
using System;

namespace RocketLanding.Services
{
    public class LandingControlService : ILandingControlService
    {
        public string LandingPlatformControl(int[,] landingPlatform, int x, int y)
        {
            if (x < 5 || y < 5 || x > 15 || y > 15)
            {
                return LandingResponse.OUTOFPLATFORM;
            }

            if (landingPlatform[x, y] == (int)RocketPosition.AvailableForLand)
            {
                landingPlatform[x, y] = (int)RocketPosition.AskedPosiion;
                for (int a = x - 1; a <= x + 1; a++)
                {
                    for (int b = y - 1; b <= y + 1; b++)
                    {
                        if (a < 5 || b < 5 || a > 15 || b > 15 || (a == x && b == y))
                        {
                            continue;
                        }
                        landingPlatform[a, b] = (int)RocketPosition.ClashPositions;
                    }
                }
                return LandingResponse.OKFORLANDING;
            }
            else if (landingPlatform[x, y] == (int)RocketPosition.AskedPosiion)
            {
                return LandingResponse.CLASH;
            }
            else if (landingPlatform[x, y] == (int)RocketPosition.ClashPositions)
            {
                return LandingResponse.CLASH;
            }

            return LandingResponse.OUTOFPLATFORM;
        }
    }
}
