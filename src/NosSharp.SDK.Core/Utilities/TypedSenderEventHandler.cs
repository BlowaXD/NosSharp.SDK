// NosSharp
// TypedSenderEventHandler.cs

using System;

namespace NosSharp.SDK.Core.Utilities
{
    public delegate void TypedSenderEventHandler<in TSender, in TEventArgs>(TSender sender, TEventArgs e)
        where TSender : class
        where TEventArgs : EventArgs;
}