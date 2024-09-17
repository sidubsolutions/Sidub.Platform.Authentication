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

namespace Sidub.Platform.Authentication
{

    /// <summary>
    /// Specifies that the decorated class or method allows anonymous access.
    /// </summary>
    public class AllowAnonymousAttribute : Attribute
    {

        #region Public properties

        /// <summary>
        /// Gets a value indicating whether anonymous access is enabled.
        /// </summary>
        public bool Enabled { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AllowAnonymousAttribute"/> class with anonymous access enabled.
        /// </summary>
        public AllowAnonymousAttribute()
        {
            Enabled = true;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AllowAnonymousAttribute"/> class with the specified value indicating whether anonymous access is enabled.
        /// </summary>
        /// <param name="enabled">A value indicating whether anonymous access is enabled.</param>
        public AllowAnonymousAttribute(bool enabled)
        {
            Enabled = enabled;
        }

        #endregion

    }

}
