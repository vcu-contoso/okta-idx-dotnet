﻿using TechTalk.SpecFlow;

namespace embedded_auth_with_sdk.E2ETests.Steps
{
    [Binding]
    public class DirectAuthSocialLoginWith1SocialIDPSteps : BaseTestSteps
    {
        public DirectAuthSocialLoginWith1SocialIDPSteps(ITestContext context) : base(context)
        { }
        [Given(@"a SPA, WEB APP or MOBILE Policy that defines Password as the only factor required for authentication")]
        public void GivenASPAWEBAPPOrMOBILEPolicyThatDefinesPasswordAsTheOnlyFactorRequiredForAuthentication()
        { }

        [Given(@"a configured IDP object for Okta")]
        public void GivenAConfiguredIDPObjectForOkta()
        { }

        [Given(@"an IDP routing rule defined to allow users in the Sample App to use the IDP")]
        public void GivenAnIDPRoutingRuleDefinedToAllowUsersInTheSampleAppToUseTheIDP()
        { }

        [Given(@"a user named Mary does not have an account in the org but has an Okta OIDC IDP account")]
        public void GivenMaryDoesNotHaveAnAccountInTheOrgButHasAnOktaOIDCIDPaccount()
        {
            _context.SetActiveUserWithOktaOidcIdpAccount("Mary");
        }

    }
}
