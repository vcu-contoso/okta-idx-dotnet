﻿using embedded_sign_in_widget.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Okta.Idx.Sdk;
using System.Security.Claims;

namespace embedded_sign_in_widget.Controllers
{
    public class InteractionCodeController : Controller
    {
        private readonly IIdxClient _idxClient;

        public InteractionCodeController(IIdxClient idxClient)
        {
            this._idxClient = idxClient;
        }

        /// <summary>
        /// This method is called by a 302 browser redirect back to the application from Okta after successful authentication to an external
        /// identity provider.
        /// </summary>
        /// <param name="state">The state handle.</param>
        /// <param name="interaction_code">The interaction code.  This is the value that is exchanged for tokens.</param>
        /// <param name="error">The error if an error occurred.</param>
        /// <param name="error_description">The error description if an error occurred.</param>
        /// <returns></returns>
        public async Task<ActionResult> Callback(string state = null, string interaction_code = null, string error = null, string error_description = null)
        {
            try
            {
                IdxContext? idxContext = await HttpContext.GetIdxContextAsync(state);

                if ("interaction_required".Equals(error))
                {
                    return Redirect($"/Account/SignInWidget?state={state}");
                }

                if (!string.IsNullOrEmpty(error))
                {
                    return View("Error", new InteractionCodeErrorViewModel { Error = error, ErrorDescription = error_description });
                }

                if (string.IsNullOrEmpty(interaction_code))
                {
                    return View("Error", new InteractionCodeErrorViewModel { Error = "null_interaction_code", ErrorDescription = "interaction_code was not specified" });
                }

                Okta.Idx.Sdk.TokenResponse tokens = await _idxClient.RedeemInteractionCodeAsync(idxContext, interaction_code);

                ClaimsIdentity identity = await AuthenticationHelper.GetIdentityFromTokenResponseAsync(_idxClient.Configuration, tokens);
                await HttpContext.SignInAsync(new ClaimsPrincipal(identity));

                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                return View("Error", new InteractionCodeErrorViewModel { Error = ex.GetType().Name, ErrorDescription = ex.Message });
            }
        }
    }
}