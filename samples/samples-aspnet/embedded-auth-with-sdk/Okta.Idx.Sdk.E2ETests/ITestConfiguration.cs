﻿namespace embedded_auth_with_sdk.E2ETests
{
    public interface ITestConfiguration
    {
        string UserPassword { get; set; }
        string A18nApiKey { get; set; }
        string A18nProfileId { get; set; }
        string A18nProfileTag { get; set; }
        int IisPort { get; set; }
        string SiteUrl { get; set; }
        string MfaRequiredGroup { get; set; }
        string PhoneEnrollmentRequiredGroup { get; set; }
        string ScreenshotsFolder { get; set; }
        string OktaSocialIdpMfaUserEmail { get; set; }
        string OktaSocialIdpMfaUserPassword { get; set; }
        string OktaOidcIdpDomain { get; set; }
        string OktaOidcIdpToken { get; set; }
    }
}
