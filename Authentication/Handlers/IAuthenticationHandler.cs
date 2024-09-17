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

#region Imports

using Sidub.Platform.Core;

#endregion

namespace Sidub.Platform.Authentication.Handlers
{

    //// <summary>
    /// Represents an authentication handler.
    /// </summary>
    public interface IAuthenticationHandler
    {

    }

    /// <summary>
    /// Represents an authentication handler for a specific client request type.
    /// </summary>
    /// <typeparam name="TClientRequest">The type of the client request.</typeparam>
    public interface IAuthenticationHandler<TClientRequest> : IAuthenticationHandler
    {

        #region Interface methods

        /// <summary>
        /// Handles the client request.
        /// </summary>
        /// <param name="serviceReference">The service reference.</param>
        /// <param name="clientRequest">The client request.</param>
        /// <returns>The modified client request.</returns>
        TClientRequest Handle(ServiceReference serviceReference, TClientRequest clientRequest);

        #endregion

    }

    /// <summary>
    /// Static helper class providing IAuthenticationHandler extensions.
    /// </summary>
    public static class IAuthenticationHandlerExtensions
    {

        /// <summary>
        /// Checks if the authentication handler can handle the specified client request type.
        /// </summary>
        /// <typeparam name="TClientRequest">The type of the client request.</typeparam>
        /// <param name="handler">The authentication handler.</param>
        /// <returns><c>true</c> if the authentication handler can handle the specified client request type; otherwise, <c>false</c>.</returns>
        public static bool IsHandledType<TClientRequest>(this IAuthenticationHandler handler)
        {
            return handler is IAuthenticationHandler<TClientRequest>;
        }

    }

}
