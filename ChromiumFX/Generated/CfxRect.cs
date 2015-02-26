// Copyright (c) 2014-2015 Wolfgang Borgsmüller
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without 
// modification, are permitted provided that the following conditions 
// are met:
// 
// 1. Redistributions of source code must retain the above copyright 
//    notice, this list of conditions and the following disclaimer.
// 
// 2. Redistributions in binary form must reproduce the above copyright 
//    notice, this list of conditions and the following disclaimer in the 
//    documentation and/or other materials provided with the distribution.
// 
// 3. Neither the name of the copyright holder nor the names of its 
//    contributors may be used to endorse or promote products derived 
//    from this software without specific prior written permission.
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS 
// "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT 
// LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS 
// FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE 
// COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, 
// INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, 
// BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS 
// OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND 
// ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR 
// TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE 
// USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

// Generated file. Do not edit.


using System;

namespace Chromium {
    /// <summary>
    /// Structure representing a rectangle.
    /// </summary>
    public sealed class CfxRect : CfxStructure {

        internal static CfxRect Wrap(IntPtr nativePtr) {
            if(nativePtr == IntPtr.Zero) return null;
            return new CfxRect(nativePtr);
        }

        internal static CfxRect WrapOwned(IntPtr nativePtr) {
            if(nativePtr == IntPtr.Zero) return null;
            return new CfxRect(nativePtr, true);
        }

        private int m_X;
        private int m_Y;
        private int m_Width;
        private int m_Height;

        public CfxRect() : base(CfxApi.cfx_rect_ctor, CfxApi.cfx_rect_dtor) {}
        internal CfxRect(IntPtr nativePtr) : base(nativePtr, CfxApi.cfx_rect_ctor, CfxApi.cfx_rect_dtor) {}
        internal CfxRect(IntPtr nativePtr, bool owned) : base(nativePtr, CfxApi.cfx_rect_ctor, CfxApi.cfx_rect_dtor, owned) {}

        public int X {
            get {
                return m_X;
            }
            set {
                m_X = value;
            }
        }

        public int Y {
            get {
                return m_Y;
            }
            set {
                m_Y = value;
            }
        }

        public int Width {
            get {
                return m_Width;
            }
            set {
                m_Width = value;
            }
        }

        public int Height {
            get {
                return m_Height;
            }
            set {
                m_Height = value;
            }
        }

        protected override void CopyToNative() {
            CfxApi.cfx_rect_copy_to_native(nativePtrUnchecked, m_X, m_Y, m_Width, m_Height);
        }

        protected override void CopyToManaged(IntPtr nativePtr) {
            CfxApi.cfx_rect_copy_to_managed(nativePtr, out m_X, out m_Y, out m_Width, out m_Height);
        }
    }
}
