﻿// <copyright file="OktaVerifyVerifyAuthenticatorOptions.cs" company="Okta, Inc">
// Copyright (c) 2020 - present Okta, Inc. All rights reserved.
// Licensed under the Apache 2.0 license. See the LICENSE file in the project root for full license information.
// </copyright>

namespace Okta.Idx.Sdk
{
    /// <summary>
    /// Okta Verify authenticator options.
    /// </summary>
    public class OktaVerifyVerifyAuthenticatorOptions
    {
        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        public string TotpCode { get; set; }
    }
}
