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
    [NativeName("Name", "D3D12_INDEX_BUFFER_VIEW")]
    public unsafe partial struct IndexBufferView
    {
        public IndexBufferView
        (
            ulong? bufferLocation = null,
            uint? sizeInBytes = null,
            Silk.NET.DXGI.Format? format = null
        ) : this()
        {
            if (bufferLocation is not null)
            {
                BufferLocation = bufferLocation.Value;
            }

            if (sizeInBytes is not null)
            {
                SizeInBytes = sizeInBytes.Value;
            }

            if (format is not null)
            {
                Format = format.Value;
            }
        }


        [NativeName("Type", "D3D12_GPU_VIRTUAL_ADDRESS")]
        [NativeName("Type.Name", "D3D12_GPU_VIRTUAL_ADDRESS")]
        [NativeName("Name", "BufferLocation")]
        public ulong BufferLocation;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "SizeInBytes")]
        public uint SizeInBytes;

        [NativeName("Type", "DXGI_FORMAT")]
        [NativeName("Type.Name", "DXGI_FORMAT")]
        [NativeName("Name", "Format")]
        public Silk.NET.DXGI.Format Format;
    }
}
