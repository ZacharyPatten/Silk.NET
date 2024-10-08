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
using Silk.NET.OpenXR;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenXR.Extensions.QCOM
{
    [Extension("XR_QCOM_tracking_optimization_settings")]
    public unsafe partial class QComTrackingOptimizationSettings : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_QCOM_tracking_optimization_settings";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrSetTrackingOptimizationSettingsHintQCOM", Convention = CallingConvention.Winapi)]
        public partial Result SetTrackingOptimizationSettingsHint([Count(Count = 0)] Session session, [Count(Count = 0)] TrackingOptimizationSettingsDomainQCOM domain, [Count(Count = 0)] TrackingOptimizationSettingsHintQCOM hint);

        public QComTrackingOptimizationSettings(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

