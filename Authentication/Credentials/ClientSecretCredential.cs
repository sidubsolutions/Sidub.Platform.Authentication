/*
 * Sidub Platform - Authentication
 * Copyright (C) 2024 Sidub Inc.
 * All rights reserved.
 *
 * This file is part of Sidub Platform - Authentication (the "Product").
 *
 * The Product is dual-licensed under:
 * 1. The GNU Affero General Public License version 3 (AGPLv3)
 * 2. Sidub Inc.'s Proprietary Software License Agreement (PSLA)
 *
 * You may choose to use, redistribute, and/or modify the Product under
 * the terms of either license.
 *
 * The Product is provided "AS IS" and "AS AVAILABLE," without any
 * warranties or conditions of any kind, either express or implied, including
 * but not limited to implied warranties or conditions of merchantability and
 * fitness for a particular purpose. See the applicable license for more
 * details.
 *
 * See the LICENSE.txt file for detailed license terms and conditions or
 * visit https://sidub.ca/licensing for a copy of the license texts.
 */

namespace Sidub.Platform.Authentication.Credentials
{

    /// <summary>
    /// Represents a client secret credential used for authentication.
    /// </summary>
    public class ClientSecretCredential : IClientCredential
    {

        #region Public properties

        /// <summary>
        /// Gets the tenant ID associated with the credential.
        /// </summary>
        public string TenantId { get; }

        /// <summary>
        /// Gets the client ID associated with the credential.
        /// </summary>
        public string ClientId { get; }

        /// <summary>
        /// Gets the secret key associated with the credential.
        /// </summary>
        public string Secret { get; }

        /// <summary>
        /// Gets the scope associated with the credential.
        /// </summary>
        public string? Scope { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSecretCredential"/> class.
        /// </summary>
        /// <param name="tenantId">The tenant ID.</param>
        /// <param name="clientId">The client ID.</param>
        /// <param name="secretKey">The secret key.</param>
        /// <param name="scope">The scope.</param>
        public ClientSecretCredential(string tenantId, string clientId, string secretKey, string? scope = null)
        {
            TenantId = tenantId;
            ClientId = clientId;
            Secret = secretKey;
            Scope = scope;
        }

        #endregion

    }

}
