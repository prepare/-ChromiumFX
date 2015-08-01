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



using System;
using System.Collections.Generic;

namespace Chromium.Remote {
    internal class RemoteWeakCache {

        private class CacheKey {
            internal class Comparer : IEqualityComparer<CacheKey> {
                public bool Equals(CacheKey x, CacheKey y) {
                    return x.connection == y.connection && x.proxyId == y.proxyId;
                }
                public int GetHashCode(CacheKey obj) {
                    unchecked {
                        return obj.connection.GetHashCode() + obj.proxyId.GetHashCode();
                    }
                }
            }
            internal readonly RemoteConnection connection;
            internal readonly IntPtr proxyId;
            internal CacheKey(IntPtr proxyId) {
                this.connection = CfxRemoteCallContext.CurrentContext.connection;
                this.proxyId = proxyId;
            }
        }

        private readonly Dictionary<CacheKey, WeakReference> cache;

        public RemoteWeakCache() {
            cache = new Dictionary<CacheKey, WeakReference>(new CacheKey.Comparer());
        }

        public void Add(IntPtr proxyId, object obj) {
            // always locked by caller
            cache.Add(new CacheKey(proxyId), new WeakReference(obj, false));
        }

        public object Get(IntPtr proxyId) {
            // always locked by caller
            WeakReference r;
            var key = new CacheKey(proxyId);
            if(cache.TryGetValue(key, out r)) {
                var retval = r.Target;
                if(retval == null) {
                    // Happens if the object was collected but not yet finalized.
                    // Remove the key so the subsequent call to Add won't fail.
                    cache.Remove(new CacheKey(proxyId));
                }
                return r.Target;
            }
            return null;
        }


        public void Remove(IntPtr proxyId) {
            lock (this) {
                cache.Remove(new CacheKey(proxyId));
            }
        }
    }
}
