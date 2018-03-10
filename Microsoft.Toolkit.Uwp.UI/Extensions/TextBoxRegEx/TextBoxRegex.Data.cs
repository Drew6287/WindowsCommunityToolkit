﻿// ******************************************************************
// Copyright (c) Microsoft. All rights reserved.
// This code is licensed under the MIT License (MIT).
// THE CODE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
// INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
// TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH
// THE CODE OR THE USE OR OTHER DEALINGS IN THE CODE.
// ******************************************************************

namespace Microsoft.Toolkit.Uwp.UI.Extensions
{
    /// <summary>
    /// TextBoxRegex allows text validation using a regular expression.
    /// </summary>
    /// <remarks>
    /// If <see cref="ValidationMode"> is set to Normal then IsValid will be set according to whether the regex is valid.</see>
    /// If <see cref="ValidationMode"> is set to Forced, the input will be validated if the TextBox loses focus.</see>
    /// If <see cref="ValidationMode"> is set to Dynamic, the input will be validated immediately, if it is invalid, the newest character at input of the Textbox will be deleted.</see>
    /// </remarks>
    public partial class TextBoxRegex
    {
        /// <summary>
        /// Regex validation mode
        /// </summary>
        public enum ValidationMode
        {
            /// <summary>
            /// Update IsValid property with validation result
            /// </summary>
            Normal,

            /// <summary>
            /// Update IsValid property instantly with validation result and clear the newest character at input which is not valid
            /// </summary>
            Dynamic
        }

        /// <summary>
        /// Specify the type of validation required
        /// </summary>
        public enum ValidationType
        {
            /// <summary>
            /// The default validation that required property Regex to be setted
            /// </summary>
            Custom,

            /// <summary>
            /// Email validation
            /// </summary>
            Email,

            /// <summary>
            /// Number validation
            /// </summary>
            Number,

            /// <summary>
            /// Decimal validation
            /// </summary>
            Decimal,

            /// <summary>
            /// Text only validation
            /// </summary>
            Characters,

            /// <summary>
            /// Phone number validation
            /// </summary>
            PhoneNumber
        }
    }
}