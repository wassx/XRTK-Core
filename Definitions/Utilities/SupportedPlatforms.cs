﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System;

namespace XRTK.Definitions.Utilities
{
    /// <summary>
    /// The supported platforms for Mixed Reality Toolkit Components and Features.
    /// </summary>
    [Flags]
    public enum SupportedPlatforms
    {
        WindowsStandalone = 1 << 0,
        MacStandalone = 1 << 1,
        LinuxStandalone = 1 << 2,
        WindowsUniversal = 1 << 3,
        Lumin = 1 << 4,
        Android = 1 << 5,
        iOS = 1 << 6
    }
}