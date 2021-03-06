﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HostHelpers.cs" company="Chromely">
//   Copyright (c) 2017-2018 Kola Oyewumi
// </copyright>
// <license>
// MIT License
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
// </license>
// <note>
// Chromely project is licensed under MIT License. CefGlue, CefSharp, Winapi may have additional licensing.
// </note>
// --------------------------------------------------------------------------------------------------------------------

namespace Chromely.CefGlue.Gtk
{
    using System;
    using Chromely.Core.Infrastructure;

    /// <summary>
    /// The host helpers.
    /// </summary>
    public static class HostHelpers
    {
        /// <summary>
        /// Initializes static members of the <see cref="HostHelpers"/> class.
        /// </summary>
        static HostHelpers()
        {
            DefaultUnhandledExceptionHandler =
                (sender, eventArgs) =>
                {
                    Log.Error(eventArgs.ExceptionObject as Exception);
                };
        }

        /// <summary>
        /// Gets the default unhandled exception handler.
        /// </summary>
        public static UnhandledExceptionEventHandler DefaultUnhandledExceptionHandler { get; }

        /// <summary>
        /// The setup default exception handlers.
        /// </summary>
        public static void SetupDefaultExceptionHandlers()
        {
            AppDomain.CurrentDomain.UnhandledException += DefaultUnhandledExceptionHandler;
        }
    }
}