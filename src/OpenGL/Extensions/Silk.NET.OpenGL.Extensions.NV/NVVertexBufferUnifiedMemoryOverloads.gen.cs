// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.NV
{
    public static class NVVertexBufferUnifiedMemoryOverloads
    {
        public static unsafe void GetIntegerui64(this NVVertexBufferUnifiedMemory thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV value, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Computed = "value"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> result)
        {
            // SpanOverloader
            thisApi.GetIntegerui64(value, index, out result.GetPinnableReference());
        }

    }
}

