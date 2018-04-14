﻿namespace Titanium.Web.Proxy.Exceptions
{
    /// <summary>
    ///     An expception thrown when body is unexpectedly empty
    /// </summary>
    public class BodyNotFoundException : ProxyException
    {
        /// <summary>
        ///     Constructor.
        /// </summary>
        /// <param name="message"></param>
        internal BodyNotFoundException(string message) : base(message)
        {
        }
    }
}
