// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
namespace Microsoft.AspNetCore.Http.RequestDelegateGenerator.StaticRouteHandlerModel.Emitters;

internal sealed class EmitterContext
{
    public bool HasJsonBodyOrService { get; set; }
    public bool HasJsonBody { get; set; }
    public bool HasFormBody { get; set; }
    public bool HasRouteOrQuery { get; set; }
    public bool HasBindAsync { get; set; }
    public bool HasParsable { get; set; }
    public bool HasJsonResponse { get; set; }
    public bool RequiresLoggingHelper { get; set; }
}
