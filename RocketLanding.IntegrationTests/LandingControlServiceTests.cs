using RocketLanding.Enums;
using RocketLanding.Services;
using RocketLanding.Services.Contracts;
using System;
using Xunit;

namespace RocketLanding.IntegrationTests
{
    public class LandingControlServiceTests
    {
        private ILandingControlService _landingControlService;

        public LandingControlServiceTests()
        {
            _landingControlService = new LandingControlService();
        }

        [Fact]
        public void GetTopDocumentWithUnauthorizedUser_ShouldThrowAccessDeniedException()
        {
            int[,] landingPlatform = new int[100,100];
            
            var res = _landingControlService.LandingPlatformControl(landingPlatform, 5, 5);
            if (res != LandingResponse.OKFORLANDING) { throw new Exception(""); }

            res = _landingControlService.LandingPlatformControl(landingPlatform, 6, 6);
            if (res != LandingResponse.CLASH) { throw new Exception(""); }

            res = _landingControlService.LandingPlatformControl(landingPlatform, 16, 6);
            if (res != LandingResponse.OUTOFPLATFORM) { throw new Exception(""); }


        }
    }
}
