// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using Silk.NET.Core.Contexts;

namespace Silk.NET.GLFW
{
    /// <summary>
    /// A IGLContext using GLFW and a window handle.
    /// </summary>
    public class GlfwContext : IGLContext
    {
        private readonly Glfw _glfw;
        private readonly unsafe WindowHandle* _window;

        /// <summary>
        /// Creates a GlfwContext using the given API instance and window handle.
        /// </summary>
        /// <param name="glfw">The GLFW API instance to use.</param>
        /// <param name="window">The window handle to source context info from.</param>
        /// <param name="source">A <see cref="IGLContextSource"/> to associate this context to, if any.</param>
        public unsafe GlfwContext(Glfw glfw, WindowHandle* window, IGLContextSource? source = null)
        {
            _window = window;
            _glfw = glfw;
            Source = source;
        }

        /// <inheritdoc />
        public nint GetProcAddress(string proc, int? slot = default) => _glfw.GetProcAddress(proc);

        /// <inheritdoc />
        public unsafe nint Handle => (nint) _window;

        /// <inheritdoc cref="IGLContext" />
        public IGLContextSource? Source { get; }

        /// <inheritdoc />
        public unsafe bool IsCurrent => _glfw.GetCurrentContext() == _window;

        /// <inheritdoc />
        public void SwapInterval(int interval) => _glfw.SwapInterval(interval);

        /// <inheritdoc />
        public unsafe void SwapBuffers() => _glfw.SwapBuffers(_window);

        /// <inheritdoc />
        public unsafe void MakeCurrent() => _glfw.MakeContextCurrent(_window);

        /// <inheritdoc />
        public unsafe void Clear()
        {
            if (IsCurrent)
            {
                _glfw.MakeContextCurrent(null);
            }
        }

        /// <inheritdoc />
        public void Dispose()
        {
        }
    }
}
