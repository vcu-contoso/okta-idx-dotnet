﻿using Okta.Idx.Sdk;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace embedded_auth_with_sdk.Models
{
    public class LoginViewModel
    {
        public LoginViewModel()
        {
            this.ShouldRenderPasswordField = true;
        }

        [Required]
        [Display(Name = "Username")]
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; } = false;

        public List<IdpOption> IdpOptions { get; set; } = new List<IdpOption>();

        public bool ShouldRenderPasswordField { get; set; }
    }
}