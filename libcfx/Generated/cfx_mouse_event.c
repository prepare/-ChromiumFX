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


// cef_mouse_event

#ifdef __cplusplus
extern "C" {
#endif

CFX_EXPORT cef_mouse_event_t* cfx_mouse_event_ctor() {
    return (cef_mouse_event_t*)calloc(1, sizeof(cef_mouse_event_t));
}

CFX_EXPORT void cfx_mouse_event_dtor(cef_mouse_event_t* self) {
    free(self);
}

// cef_mouse_event_t->x
CFX_EXPORT void cfx_mouse_event_set_x(cef_mouse_event_t *self, int x) {
    self->x = x;
}
CFX_EXPORT void cfx_mouse_event_get_x(cef_mouse_event_t *self, int* x) {
    *x = self->x;
}

// cef_mouse_event_t->y
CFX_EXPORT void cfx_mouse_event_set_y(cef_mouse_event_t *self, int y) {
    self->y = y;
}
CFX_EXPORT void cfx_mouse_event_get_y(cef_mouse_event_t *self, int* y) {
    *y = self->y;
}

// cef_mouse_event_t->modifiers
CFX_EXPORT void cfx_mouse_event_set_modifiers(cef_mouse_event_t *self, uint32 modifiers) {
    self->modifiers = modifiers;
}
CFX_EXPORT void cfx_mouse_event_get_modifiers(cef_mouse_event_t *self, uint32* modifiers) {
    *modifiers = self->modifiers;
}


#ifdef __cplusplus
} // extern "C"
#endif

