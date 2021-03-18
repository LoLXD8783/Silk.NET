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
using Silk.NET.OpenGL.Legacy;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIS
{
    [Extension("SGIS_texture_filter4")]
    public unsafe partial class SgisTextureFilter4 : NativeExtension<GL>
    {
        public const string ExtensionName = "SGIS_texture_filter4";
        [NativeApi(EntryPoint = "glGetTexFilterFuncSGIS")]
        public unsafe partial void GetTexFilterFunc([Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] SGIS filter, [Count(Computed = "target, filter"), Flow(FlowDirection.Out)] float* weights);

        [NativeApi(EntryPoint = "glGetTexFilterFuncSGIS")]
        public partial void GetTexFilterFunc([Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] SGIS filter, [Count(Computed = "target, filter"), Flow(FlowDirection.Out)] out float weights);

        [NativeApi(EntryPoint = "glGetTexFilterFuncSGIS")]
        public unsafe partial void GetTexFilterFunc([Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] TextureFilterSGIS filter, [Count(Computed = "target, filter"), Flow(FlowDirection.Out)] float* weights);

        [NativeApi(EntryPoint = "glGetTexFilterFuncSGIS")]
        public partial void GetTexFilterFunc([Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] TextureFilterSGIS filter, [Count(Computed = "target, filter"), Flow(FlowDirection.Out)] out float weights);

        [NativeApi(EntryPoint = "glGetTexFilterFuncSGIS")]
        public unsafe partial void GetTexFilterFunc([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] SGIS filter, [Count(Computed = "target, filter"), Flow(FlowDirection.Out)] float* weights);

        [NativeApi(EntryPoint = "glGetTexFilterFuncSGIS")]
        public partial void GetTexFilterFunc([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] SGIS filter, [Count(Computed = "target, filter"), Flow(FlowDirection.Out)] out float weights);

        [NativeApi(EntryPoint = "glGetTexFilterFuncSGIS")]
        public unsafe partial void GetTexFilterFunc([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureFilterSGIS filter, [Count(Computed = "target, filter"), Flow(FlowDirection.Out)] float* weights);

        [NativeApi(EntryPoint = "glGetTexFilterFuncSGIS")]
        public partial void GetTexFilterFunc([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureFilterSGIS filter, [Count(Computed = "target, filter"), Flow(FlowDirection.Out)] out float weights);

        [NativeApi(EntryPoint = "glTexFilterFuncSGIS")]
        public unsafe partial void TexFilterFunc([Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] SGIS filter, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] float* weights);

        [NativeApi(EntryPoint = "glTexFilterFuncSGIS")]
        public partial void TexFilterFunc([Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] SGIS filter, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in float weights);

        [NativeApi(EntryPoint = "glTexFilterFuncSGIS")]
        public unsafe partial void TexFilterFunc([Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] TextureFilterSGIS filter, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] float* weights);

        [NativeApi(EntryPoint = "glTexFilterFuncSGIS")]
        public partial void TexFilterFunc([Flow(FlowDirection.In)] SGIS target, [Flow(FlowDirection.In)] TextureFilterSGIS filter, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in float weights);

        [NativeApi(EntryPoint = "glTexFilterFuncSGIS")]
        public unsafe partial void TexFilterFunc([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] SGIS filter, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] float* weights);

        [NativeApi(EntryPoint = "glTexFilterFuncSGIS")]
        public partial void TexFilterFunc([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] SGIS filter, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in float weights);

        [NativeApi(EntryPoint = "glTexFilterFuncSGIS")]
        public unsafe partial void TexFilterFunc([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureFilterSGIS filter, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] float* weights);

        [NativeApi(EntryPoint = "glTexFilterFuncSGIS")]
        public partial void TexFilterFunc([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureFilterSGIS filter, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in float weights);

        public SgisTextureFilter4(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

