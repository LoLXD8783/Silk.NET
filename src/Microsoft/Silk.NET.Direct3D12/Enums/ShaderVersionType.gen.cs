// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_SHADER_VERSION_TYPE")]
    public enum ShaderVersionType : int
    {
        [NativeName("Name", "D3D12_SHVER_PIXEL_SHADER")]
        ShverPixelShader = 0x0,
        [NativeName("Name", "D3D12_SHVER_VERTEX_SHADER")]
        ShverVertexShader = 0x1,
        [NativeName("Name", "D3D12_SHVER_GEOMETRY_SHADER")]
        ShverGeometryShader = 0x2,
        [NativeName("Name", "D3D12_SHVER_HULL_SHADER")]
        ShverHullShader = 0x3,
        [NativeName("Name", "D3D12_SHVER_DOMAIN_SHADER")]
        ShverDomainShader = 0x4,
        [NativeName("Name", "D3D12_SHVER_COMPUTE_SHADER")]
        ShverComputeShader = 0x5,
        [NativeName("Name", "D3D12_SHVER_RESERVED0")]
        ShverReserved0 = 0xFFF0,
    }
}