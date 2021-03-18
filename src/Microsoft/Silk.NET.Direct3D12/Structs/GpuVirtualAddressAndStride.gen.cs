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

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_GPU_VIRTUAL_ADDRESS_AND_STRIDE")]
    public unsafe partial struct GpuVirtualAddressAndStride
    {
        public GpuVirtualAddressAndStride
        (
            ulong? startAddress = null,
            ulong? strideInBytes = null
        ) : this()
        {
            if (startAddress is not null)
            {
                StartAddress = startAddress.Value;
            }

            if (strideInBytes is not null)
            {
                StrideInBytes = strideInBytes.Value;
            }
        }


        [NativeName("Type", "D3D12_GPU_VIRTUAL_ADDRESS")]
        [NativeName("Type.Name", "D3D12_GPU_VIRTUAL_ADDRESS")]
        [NativeName("Name", "StartAddress")]
        public ulong StartAddress;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "StrideInBytes")]
        public ulong StrideInBytes;
    }
}
