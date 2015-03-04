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
    using Event;

    /// <summary>
    /// Implement this structure to handle events when window rendering is disabled.
    /// The functions of this structure will be called on the UI thread.
    /// </summary>
    public class CfxRenderHandler : CfxBase {

        internal static CfxRenderHandler Wrap(IntPtr nativePtr) {
            if(nativePtr == IntPtr.Zero) return null;
            var handlePtr = CfxApi.cfx_render_handler_get_gc_handle(nativePtr);
            return (CfxRenderHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(handlePtr).Target;
        }


        internal static void get_root_screen_rect(IntPtr gcHandlePtr, out int __retval, IntPtr browser, IntPtr rect) {
            var self = (CfxRenderHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                __retval = default(int);
                return;
            }
            var e = new CfxGetRootScreenRectEventArgs(browser, rect);
            var eventHandler = self.m_GetRootScreenRect;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            if(e.m_browser_wrapped == null) CfxApi.cfx_release(e.m_browser);
            __retval = e.m_returnValue;
        }

        internal static void get_view_rect(IntPtr gcHandlePtr, out int __retval, IntPtr browser, IntPtr rect) {
            var self = (CfxRenderHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                __retval = default(int);
                return;
            }
            var e = new CfxGetViewRectEventArgs(browser, rect);
            var eventHandler = self.m_GetViewRect;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            if(e.m_browser_wrapped == null) CfxApi.cfx_release(e.m_browser);
            __retval = e.m_returnValue ? 1 : 0;
        }

        internal static void get_screen_point(IntPtr gcHandlePtr, out int __retval, IntPtr browser, int viewX, int viewY, out int screenX, out int screenY) {
            var self = (CfxRenderHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                __retval = default(int);
                screenX = default(int);
                screenY = default(int);
                return;
            }
            var e = new CfxGetScreenPointEventArgs(browser, viewX, viewY);
            var eventHandler = self.m_GetScreenPoint;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            if(e.m_browser_wrapped == null) CfxApi.cfx_release(e.m_browser);
            screenX = e.m_screenX;
            screenY = e.m_screenY;
            __retval = e.m_returnValue ? 1 : 0;
        }

        internal static void get_screen_info(IntPtr gcHandlePtr, out int __retval, IntPtr browser, IntPtr screen_info) {
            var self = (CfxRenderHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                __retval = default(int);
                return;
            }
            var e = new CfxGetScreenInfoEventArgs(browser, screen_info);
            var eventHandler = self.m_GetScreenInfo;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            if(e.m_browser_wrapped == null) CfxApi.cfx_release(e.m_browser);
            __retval = e.m_returnValue ? 1 : 0;
        }

        internal static void on_popup_show(IntPtr gcHandlePtr, IntPtr browser, int show) {
            var self = (CfxRenderHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                return;
            }
            var e = new CfxOnPopupShowEventArgs(browser, show);
            var eventHandler = self.m_OnPopupShow;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            if(e.m_browser_wrapped == null) CfxApi.cfx_release(e.m_browser);
        }

        internal static void on_popup_size(IntPtr gcHandlePtr, IntPtr browser, IntPtr rect) {
            var self = (CfxRenderHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                return;
            }
            var e = new CfxOnPopupSizeEventArgs(browser, rect);
            var eventHandler = self.m_OnPopupSize;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            if(e.m_browser_wrapped == null) CfxApi.cfx_release(e.m_browser);
        }

        internal static void on_paint(IntPtr gcHandlePtr, IntPtr browser, CfxPaintElementType type, int dirtyRectsCount, IntPtr dirtyRects, IntPtr buffer, int width, int height) {
            var self = (CfxRenderHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                return;
            }
            var e = new CfxOnPaintEventArgs(browser, type, dirtyRects, dirtyRectsCount, buffer, width, height);
            var eventHandler = self.m_OnPaint;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            if(e.m_browser_wrapped == null) CfxApi.cfx_release(e.m_browser);
        }

        internal static void on_cursor_change(IntPtr gcHandlePtr, IntPtr browser, IntPtr cursor, CfxCursorType type, IntPtr custom_cursor_info) {
            var self = (CfxRenderHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                return;
            }
            var e = new CfxOnCursorChangeEventArgs(browser, cursor, type, custom_cursor_info);
            var eventHandler = self.m_OnCursorChange;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            if(e.m_browser_wrapped == null) CfxApi.cfx_release(e.m_browser);
        }

        internal static void start_dragging(IntPtr gcHandlePtr, out int __retval, IntPtr browser, IntPtr drag_data, CfxDragOperationsMask allowed_ops, int x, int y) {
            var self = (CfxRenderHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                __retval = default(int);
                return;
            }
            var e = new CfxStartDraggingEventArgs(browser, drag_data, allowed_ops, x, y);
            var eventHandler = self.m_StartDragging;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            if(e.m_browser_wrapped == null) CfxApi.cfx_release(e.m_browser);
            if(e.m_drag_data_wrapped == null) CfxApi.cfx_release(e.m_drag_data);
            __retval = e.m_returnValue ? 1 : 0;
        }

        internal static void update_drag_cursor(IntPtr gcHandlePtr, IntPtr browser, CfxDragOperationsMask operation) {
            var self = (CfxRenderHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                return;
            }
            var e = new CfxUpdateDragCursorEventArgs(browser, operation);
            var eventHandler = self.m_UpdateDragCursor;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            if(e.m_browser_wrapped == null) CfxApi.cfx_release(e.m_browser);
        }

        internal static void on_scroll_offset_changed(IntPtr gcHandlePtr, IntPtr browser) {
            var self = (CfxRenderHandler)System.Runtime.InteropServices.GCHandle.FromIntPtr(gcHandlePtr).Target;
            if(self == null) {
                return;
            }
            var e = new CfxOnScrollOffsetChangedEventArgs(browser);
            var eventHandler = self.m_OnScrollOffsetChanged;
            if(eventHandler != null) eventHandler(self, e);
            e.m_isInvalid = true;
            if(e.m_browser_wrapped == null) CfxApi.cfx_release(e.m_browser);
        }

        internal CfxRenderHandler(IntPtr nativePtr) : base(nativePtr) {}
        public CfxRenderHandler() : base(CfxApi.cfx_render_handler_ctor) {}

        /// <summary>
        /// Called to retrieve the root window rectangle in screen coordinates. Return
        /// true (1) if the rectangle was provided.
        /// </summary>
        public event CfxGetRootScreenRectEventHandler GetRootScreenRect {
            add {
                if(m_GetRootScreenRect == null) {
                    CfxApi.cfx_render_handler_activate_callback(NativePtr, 0, 1);
                }
                m_GetRootScreenRect += value;
            }
            remove {
                m_GetRootScreenRect -= value;
                if(m_GetRootScreenRect == null) {
                    CfxApi.cfx_render_handler_activate_callback(NativePtr, 0, 0);
                }
            }
        }

        private CfxGetRootScreenRectEventHandler m_GetRootScreenRect;

        /// <summary>
        /// Called to retrieve the view rectangle which is relative to screen
        /// coordinates. Return true (1) if the rectangle was provided.
        /// </summary>
        public event CfxGetViewRectEventHandler GetViewRect {
            add {
                if(m_GetViewRect == null) {
                    CfxApi.cfx_render_handler_activate_callback(NativePtr, 1, 1);
                }
                m_GetViewRect += value;
            }
            remove {
                m_GetViewRect -= value;
                if(m_GetViewRect == null) {
                    CfxApi.cfx_render_handler_activate_callback(NativePtr, 1, 0);
                }
            }
        }

        private CfxGetViewRectEventHandler m_GetViewRect;

        /// <summary>
        /// Called to retrieve the translation from view coordinates to actual screen
        /// coordinates. Return true (1) if the screen coordinates were provided.
        /// </summary>
        public event CfxGetScreenPointEventHandler GetScreenPoint {
            add {
                if(m_GetScreenPoint == null) {
                    CfxApi.cfx_render_handler_activate_callback(NativePtr, 2, 1);
                }
                m_GetScreenPoint += value;
            }
            remove {
                m_GetScreenPoint -= value;
                if(m_GetScreenPoint == null) {
                    CfxApi.cfx_render_handler_activate_callback(NativePtr, 2, 0);
                }
            }
        }

        private CfxGetScreenPointEventHandler m_GetScreenPoint;

        /// <summary>
        /// Called to allow the client to fill in the CfxScreenInfo object with
        /// appropriate values. Return true (1) if the |ScreenInfo| structure has been
        /// modified.
        /// If the screen info rectangle is left NULL the rectangle from GetViewRect
        /// will be used. If the rectangle is still NULL or invalid popups may not be
        /// drawn correctly.
        /// </summary>
        public event CfxGetScreenInfoEventHandler GetScreenInfo {
            add {
                if(m_GetScreenInfo == null) {
                    CfxApi.cfx_render_handler_activate_callback(NativePtr, 3, 1);
                }
                m_GetScreenInfo += value;
            }
            remove {
                m_GetScreenInfo -= value;
                if(m_GetScreenInfo == null) {
                    CfxApi.cfx_render_handler_activate_callback(NativePtr, 3, 0);
                }
            }
        }

        private CfxGetScreenInfoEventHandler m_GetScreenInfo;

        /// <summary>
        /// Called when the browser wants to show or hide the popup widget. The popup
        /// should be shown if |Show| is true (1) and hidden if |Show| is false (0).
        /// </summary>
        public event CfxOnPopupShowEventHandler OnPopupShow {
            add {
                if(m_OnPopupShow == null) {
                    CfxApi.cfx_render_handler_activate_callback(NativePtr, 4, 1);
                }
                m_OnPopupShow += value;
            }
            remove {
                m_OnPopupShow -= value;
                if(m_OnPopupShow == null) {
                    CfxApi.cfx_render_handler_activate_callback(NativePtr, 4, 0);
                }
            }
        }

        private CfxOnPopupShowEventHandler m_OnPopupShow;

        /// <summary>
        /// Called when the browser wants to move or resize the popup widget. |Rect|
        /// contains the new location and size.
        /// </summary>
        public event CfxOnPopupSizeEventHandler OnPopupSize {
            add {
                if(m_OnPopupSize == null) {
                    CfxApi.cfx_render_handler_activate_callback(NativePtr, 5, 1);
                }
                m_OnPopupSize += value;
            }
            remove {
                m_OnPopupSize -= value;
                if(m_OnPopupSize == null) {
                    CfxApi.cfx_render_handler_activate_callback(NativePtr, 5, 0);
                }
            }
        }

        private CfxOnPopupSizeEventHandler m_OnPopupSize;

        /// <summary>
        /// Called when an element should be painted. |Type| indicates whether the
        /// element is the view or the popup widget. |Buffer| contains the pixel data
        /// for the whole image. |DirtyRects| contains the set of rectangles that need
        /// to be repainted. |Buffer| will be |Width|*|Height|*4 bytes in size and
        /// represents a BGRA image with an upper-left origin.
        /// </summary>
        public event CfxOnPaintEventHandler OnPaint {
            add {
                if(m_OnPaint == null) {
                    CfxApi.cfx_render_handler_activate_callback(NativePtr, 6, 1);
                }
                m_OnPaint += value;
            }
            remove {
                m_OnPaint -= value;
                if(m_OnPaint == null) {
                    CfxApi.cfx_render_handler_activate_callback(NativePtr, 6, 0);
                }
            }
        }

        private CfxOnPaintEventHandler m_OnPaint;

        /// <summary>
        /// Called when the browser's cursor has changed. If |Type| is CT_CUSTOM then
        /// |CustomCursorInfo| will be populated with the custom cursor information.
        /// </summary>
        public event CfxOnCursorChangeEventHandler OnCursorChange {
            add {
                if(m_OnCursorChange == null) {
                    CfxApi.cfx_render_handler_activate_callback(NativePtr, 7, 1);
                }
                m_OnCursorChange += value;
            }
            remove {
                m_OnCursorChange -= value;
                if(m_OnCursorChange == null) {
                    CfxApi.cfx_render_handler_activate_callback(NativePtr, 7, 0);
                }
            }
        }

        private CfxOnCursorChangeEventHandler m_OnCursorChange;

        /// <summary>
        /// Called when the user starts dragging content in the web view. Contextual
        /// information about the dragged content is supplied by |DragData|. OS APIs
        /// that run a system message loop may be used within the StartDragging call.
        /// Return false (0) to abort the drag operation. Don't call any of
        /// CfxBrowserHost.DragSource*Ended* functions after returning false (0).
        /// Return true (1) to handle the drag operation. Call
        /// CfxBrowserHost.DragSourceEndedAt and DragSourceSystemDragEnded either
        /// synchronously or asynchronously to inform the web view that the drag
        /// operation has ended.
        /// </summary>
        public event CfxStartDraggingEventHandler StartDragging {
            add {
                if(m_StartDragging == null) {
                    CfxApi.cfx_render_handler_activate_callback(NativePtr, 8, 1);
                }
                m_StartDragging += value;
            }
            remove {
                m_StartDragging -= value;
                if(m_StartDragging == null) {
                    CfxApi.cfx_render_handler_activate_callback(NativePtr, 8, 0);
                }
            }
        }

        private CfxStartDraggingEventHandler m_StartDragging;

        /// <summary>
        /// Called when the web view wants to update the mouse cursor during a drag &amp;
        /// drop operation. |Operation| describes the allowed operation (none, move,
        /// copy, link).
        /// </summary>
        public event CfxUpdateDragCursorEventHandler UpdateDragCursor {
            add {
                if(m_UpdateDragCursor == null) {
                    CfxApi.cfx_render_handler_activate_callback(NativePtr, 9, 1);
                }
                m_UpdateDragCursor += value;
            }
            remove {
                m_UpdateDragCursor -= value;
                if(m_UpdateDragCursor == null) {
                    CfxApi.cfx_render_handler_activate_callback(NativePtr, 9, 0);
                }
            }
        }

        private CfxUpdateDragCursorEventHandler m_UpdateDragCursor;

        /// <summary>
        /// Called when the scroll offset has changed.
        /// </summary>
        public event CfxOnScrollOffsetChangedEventHandler OnScrollOffsetChanged {
            add {
                if(m_OnScrollOffsetChanged == null) {
                    CfxApi.cfx_render_handler_activate_callback(NativePtr, 10, 1);
                }
                m_OnScrollOffsetChanged += value;
            }
            remove {
                m_OnScrollOffsetChanged -= value;
                if(m_OnScrollOffsetChanged == null) {
                    CfxApi.cfx_render_handler_activate_callback(NativePtr, 10, 0);
                }
            }
        }

        private CfxOnScrollOffsetChangedEventHandler m_OnScrollOffsetChanged;

        internal override void OnDispose(IntPtr nativePtr) {
            if(m_GetRootScreenRect != null) {
                m_GetRootScreenRect = null;
                CfxApi.cfx_render_handler_activate_callback(NativePtr, 0, 0);
            }
            if(m_GetViewRect != null) {
                m_GetViewRect = null;
                CfxApi.cfx_render_handler_activate_callback(NativePtr, 1, 0);
            }
            if(m_GetScreenPoint != null) {
                m_GetScreenPoint = null;
                CfxApi.cfx_render_handler_activate_callback(NativePtr, 2, 0);
            }
            if(m_GetScreenInfo != null) {
                m_GetScreenInfo = null;
                CfxApi.cfx_render_handler_activate_callback(NativePtr, 3, 0);
            }
            if(m_OnPopupShow != null) {
                m_OnPopupShow = null;
                CfxApi.cfx_render_handler_activate_callback(NativePtr, 4, 0);
            }
            if(m_OnPopupSize != null) {
                m_OnPopupSize = null;
                CfxApi.cfx_render_handler_activate_callback(NativePtr, 5, 0);
            }
            if(m_OnPaint != null) {
                m_OnPaint = null;
                CfxApi.cfx_render_handler_activate_callback(NativePtr, 6, 0);
            }
            if(m_OnCursorChange != null) {
                m_OnCursorChange = null;
                CfxApi.cfx_render_handler_activate_callback(NativePtr, 7, 0);
            }
            if(m_StartDragging != null) {
                m_StartDragging = null;
                CfxApi.cfx_render_handler_activate_callback(NativePtr, 8, 0);
            }
            if(m_UpdateDragCursor != null) {
                m_UpdateDragCursor = null;
                CfxApi.cfx_render_handler_activate_callback(NativePtr, 9, 0);
            }
            if(m_OnScrollOffsetChanged != null) {
                m_OnScrollOffsetChanged = null;
                CfxApi.cfx_render_handler_activate_callback(NativePtr, 10, 0);
            }
            base.OnDispose(nativePtr);
        }
    }


    namespace Event {

        public delegate void CfxGetRootScreenRectEventHandler(object sender, CfxGetRootScreenRectEventArgs e);

        /// <summary>
        /// Called to retrieve the root window rectangle in screen coordinates. Return
        /// true (1) if the rectangle was provided.
        /// </summary>
        public class CfxGetRootScreenRectEventArgs : CfxEventArgs {

            internal IntPtr m_browser;
            internal CfxBrowser m_browser_wrapped;
            internal IntPtr m_rect;
            internal CfxRect m_rect_wrapped;

            internal int m_returnValue;
            private bool returnValueSet;

            internal CfxGetRootScreenRectEventArgs(IntPtr browser, IntPtr rect) {
                m_browser = browser;
                m_rect = rect;
            }

            public CfxBrowser Browser {
                get {
                    CheckAccess();
                    if(m_browser_wrapped == null) m_browser_wrapped = CfxBrowser.Wrap(m_browser);
                    return m_browser_wrapped;
                }
            }
            public CfxRect Rect {
                get {
                    CheckAccess();
                    if(m_rect_wrapped == null) m_rect_wrapped = CfxRect.Wrap(m_rect);
                    return m_rect_wrapped;
                }
            }
            public void SetReturnValue(int returnValue) {
                CheckAccess();
                if(returnValueSet) {
                    throw new CfxException("The return value has already been set");
                }
                returnValueSet = true;
                this.m_returnValue = returnValue;
            }

            public override string ToString() {
                return String.Format("Browser={{{0}}}, Rect={{{1}}}", Browser, Rect);
            }
        }

        public delegate void CfxGetViewRectEventHandler(object sender, CfxGetViewRectEventArgs e);

        /// <summary>
        /// Called to retrieve the view rectangle which is relative to screen
        /// coordinates. Return true (1) if the rectangle was provided.
        /// </summary>
        public class CfxGetViewRectEventArgs : CfxEventArgs {

            internal IntPtr m_browser;
            internal CfxBrowser m_browser_wrapped;
            internal IntPtr m_rect;
            internal CfxRect m_rect_wrapped;

            internal bool m_returnValue;
            private bool returnValueSet;

            internal CfxGetViewRectEventArgs(IntPtr browser, IntPtr rect) {
                m_browser = browser;
                m_rect = rect;
            }

            public CfxBrowser Browser {
                get {
                    CheckAccess();
                    if(m_browser_wrapped == null) m_browser_wrapped = CfxBrowser.Wrap(m_browser);
                    return m_browser_wrapped;
                }
            }
            public CfxRect Rect {
                get {
                    CheckAccess();
                    if(m_rect_wrapped == null) m_rect_wrapped = CfxRect.Wrap(m_rect);
                    return m_rect_wrapped;
                }
            }
            public void SetReturnValue(bool returnValue) {
                CheckAccess();
                if(returnValueSet) {
                    throw new CfxException("The return value has already been set");
                }
                returnValueSet = true;
                this.m_returnValue = returnValue;
            }

            public override string ToString() {
                return String.Format("Browser={{{0}}}, Rect={{{1}}}", Browser, Rect);
            }
        }

        public delegate void CfxGetScreenPointEventHandler(object sender, CfxGetScreenPointEventArgs e);

        /// <summary>
        /// Called to retrieve the translation from view coordinates to actual screen
        /// coordinates. Return true (1) if the screen coordinates were provided.
        /// </summary>
        public class CfxGetScreenPointEventArgs : CfxEventArgs {

            internal IntPtr m_browser;
            internal CfxBrowser m_browser_wrapped;
            internal int m_viewX;
            internal int m_viewY;
            internal int m_screenX;
            internal int m_screenY;

            internal bool m_returnValue;
            private bool returnValueSet;

            internal CfxGetScreenPointEventArgs(IntPtr browser, int viewX, int viewY) {
                m_browser = browser;
                m_viewX = viewX;
                m_viewY = viewY;
            }

            public CfxBrowser Browser {
                get {
                    CheckAccess();
                    if(m_browser_wrapped == null) m_browser_wrapped = CfxBrowser.Wrap(m_browser);
                    return m_browser_wrapped;
                }
            }
            public int ViewX {
                get {
                    CheckAccess();
                    return m_viewX;
                }
            }
            public int ViewY {
                get {
                    CheckAccess();
                    return m_viewY;
                }
            }
            public int ScreenX {
                set {
                    CheckAccess();
                    m_screenX = value;
                }
            }
            public int ScreenY {
                set {
                    CheckAccess();
                    m_screenY = value;
                }
            }
            public void SetReturnValue(bool returnValue) {
                CheckAccess();
                if(returnValueSet) {
                    throw new CfxException("The return value has already been set");
                }
                returnValueSet = true;
                this.m_returnValue = returnValue;
            }

            public override string ToString() {
                return String.Format("Browser={{{0}}}, ViewX={{{1}}}, ViewY={{{2}}}", Browser, ViewX, ViewY);
            }
        }

        public delegate void CfxGetScreenInfoEventHandler(object sender, CfxGetScreenInfoEventArgs e);

        /// <summary>
        /// Called to allow the client to fill in the CfxScreenInfo object with
        /// appropriate values. Return true (1) if the |ScreenInfo| structure has been
        /// modified.
        /// If the screen info rectangle is left NULL the rectangle from GetViewRect
        /// will be used. If the rectangle is still NULL or invalid popups may not be
        /// drawn correctly.
        /// </summary>
        public class CfxGetScreenInfoEventArgs : CfxEventArgs {

            internal IntPtr m_browser;
            internal CfxBrowser m_browser_wrapped;
            internal IntPtr m_screen_info;
            internal CfxScreenInfo m_screen_info_wrapped;

            internal bool m_returnValue;
            private bool returnValueSet;

            internal CfxGetScreenInfoEventArgs(IntPtr browser, IntPtr screen_info) {
                m_browser = browser;
                m_screen_info = screen_info;
            }

            public CfxBrowser Browser {
                get {
                    CheckAccess();
                    if(m_browser_wrapped == null) m_browser_wrapped = CfxBrowser.Wrap(m_browser);
                    return m_browser_wrapped;
                }
            }
            public CfxScreenInfo ScreenInfo {
                get {
                    CheckAccess();
                    if(m_screen_info_wrapped == null) m_screen_info_wrapped = CfxScreenInfo.Wrap(m_screen_info);
                    return m_screen_info_wrapped;
                }
            }
            public void SetReturnValue(bool returnValue) {
                CheckAccess();
                if(returnValueSet) {
                    throw new CfxException("The return value has already been set");
                }
                returnValueSet = true;
                this.m_returnValue = returnValue;
            }

            public override string ToString() {
                return String.Format("Browser={{{0}}}, ScreenInfo={{{1}}}", Browser, ScreenInfo);
            }
        }

        public delegate void CfxOnPopupShowEventHandler(object sender, CfxOnPopupShowEventArgs e);

        /// <summary>
        /// Called when the browser wants to show or hide the popup widget. The popup
        /// should be shown if |Show| is true (1) and hidden if |Show| is false (0).
        /// </summary>
        public class CfxOnPopupShowEventArgs : CfxEventArgs {

            internal IntPtr m_browser;
            internal CfxBrowser m_browser_wrapped;
            internal int m_show;

            internal CfxOnPopupShowEventArgs(IntPtr browser, int show) {
                m_browser = browser;
                m_show = show;
            }

            public CfxBrowser Browser {
                get {
                    CheckAccess();
                    if(m_browser_wrapped == null) m_browser_wrapped = CfxBrowser.Wrap(m_browser);
                    return m_browser_wrapped;
                }
            }
            public bool Show {
                get {
                    CheckAccess();
                    return 0 != m_show;
                }
            }

            public override string ToString() {
                return String.Format("Browser={{{0}}}, Show={{{1}}}", Browser, Show);
            }
        }

        public delegate void CfxOnPopupSizeEventHandler(object sender, CfxOnPopupSizeEventArgs e);

        /// <summary>
        /// Called when the browser wants to move or resize the popup widget. |Rect|
        /// contains the new location and size.
        /// </summary>
        public class CfxOnPopupSizeEventArgs : CfxEventArgs {

            internal IntPtr m_browser;
            internal CfxBrowser m_browser_wrapped;
            internal IntPtr m_rect;
            internal CfxRect m_rect_wrapped;

            internal CfxOnPopupSizeEventArgs(IntPtr browser, IntPtr rect) {
                m_browser = browser;
                m_rect = rect;
            }

            public CfxBrowser Browser {
                get {
                    CheckAccess();
                    if(m_browser_wrapped == null) m_browser_wrapped = CfxBrowser.Wrap(m_browser);
                    return m_browser_wrapped;
                }
            }
            public CfxRect Rect {
                get {
                    CheckAccess();
                    if(m_rect_wrapped == null) m_rect_wrapped = CfxRect.Wrap(m_rect);
                    return m_rect_wrapped;
                }
            }

            public override string ToString() {
                return String.Format("Browser={{{0}}}, Rect={{{1}}}", Browser, Rect);
            }
        }

        public delegate void CfxOnPaintEventHandler(object sender, CfxOnPaintEventArgs e);

        /// <summary>
        /// Called when an element should be painted. |Type| indicates whether the
        /// element is the view or the popup widget. |Buffer| contains the pixel data
        /// for the whole image. |DirtyRects| contains the set of rectangles that need
        /// to be repainted. |Buffer| will be |Width|*|Height|*4 bytes in size and
        /// represents a BGRA image with an upper-left origin.
        /// </summary>
        public class CfxOnPaintEventArgs : CfxEventArgs {

            internal IntPtr m_browser;
            internal CfxBrowser m_browser_wrapped;
            internal CfxPaintElementType m_type;
            internal IntPtr m_dirtyRects;
            internal int m_dirtyRectsCount;
            internal CfxRect[] m_dirtyRects_managed;
            internal IntPtr m_buffer;
            internal int m_width;
            internal int m_height;

            internal CfxOnPaintEventArgs(IntPtr browser, CfxPaintElementType type, IntPtr dirtyRects, int dirtyRectsCount, IntPtr buffer, int width, int height) {
                m_browser = browser;
                m_type = type;
                m_dirtyRects = dirtyRects;
                m_dirtyRectsCount = dirtyRectsCount;
                m_buffer = buffer;
                m_width = width;
                m_height = height;
            }

            public CfxBrowser Browser {
                get {
                    CheckAccess();
                    if(m_browser_wrapped == null) m_browser_wrapped = CfxBrowser.Wrap(m_browser);
                    return m_browser_wrapped;
                }
            }
            public CfxPaintElementType Type {
                get {
                    CheckAccess();
                    return m_type;
                }
            }
            public CfxRect[] DirtyRects {
                get {
                    CheckAccess();
                    if(m_dirtyRects_managed == null) {
                        if(m_dirtyRectsCount == 0) return new CfxRect[0];
                        var buffer = new int[4 * m_dirtyRectsCount];
                        System.Runtime.InteropServices.Marshal.Copy(m_dirtyRects, buffer, 0, buffer.Length);
                        m_dirtyRects_managed = new CfxRect[m_dirtyRectsCount];
                        for (var i = 0; i < m_dirtyRectsCount;) {
                            m_dirtyRects_managed[i] = new CfxRect() {
                                X = buffer[i++],
                                Y = buffer[i++],
                                Width = buffer[i++],
                                Height = buffer[i++]
                            };
                        }
                    }
                    return m_dirtyRects_managed;
                }
            }
            public IntPtr Buffer {
                get {
                    CheckAccess();
                    return m_buffer;
                }
            }
            public int Width {
                get {
                    CheckAccess();
                    return m_width;
                }
            }
            public int Height {
                get {
                    CheckAccess();
                    return m_height;
                }
            }

            public override string ToString() {
                return String.Format("Browser={{{0}}}, Type={{{1}}}, DirtyRects={{{2}}}, Buffer={{{3}}}, Width={{{4}}}, Height={{{5}}}", Browser, Type, DirtyRects, Buffer, Width, Height);
            }
        }

        public delegate void CfxOnCursorChangeEventHandler(object sender, CfxOnCursorChangeEventArgs e);

        /// <summary>
        /// Called when the browser's cursor has changed. If |Type| is CT_CUSTOM then
        /// |CustomCursorInfo| will be populated with the custom cursor information.
        /// </summary>
        public class CfxOnCursorChangeEventArgs : CfxEventArgs {

            internal IntPtr m_browser;
            internal CfxBrowser m_browser_wrapped;
            internal IntPtr m_cursor;
            internal CfxCursorType m_type;
            internal IntPtr m_custom_cursor_info;
            internal CfxCursorInfo m_custom_cursor_info_wrapped;

            internal CfxOnCursorChangeEventArgs(IntPtr browser, IntPtr cursor, CfxCursorType type, IntPtr custom_cursor_info) {
                m_browser = browser;
                m_cursor = cursor;
                m_type = type;
                m_custom_cursor_info = custom_cursor_info;
            }

            public CfxBrowser Browser {
                get {
                    CheckAccess();
                    if(m_browser_wrapped == null) m_browser_wrapped = CfxBrowser.Wrap(m_browser);
                    return m_browser_wrapped;
                }
            }
            public IntPtr Cursor {
                get {
                    CheckAccess();
                    return m_cursor;
                }
            }
            public CfxCursorType Type {
                get {
                    CheckAccess();
                    return m_type;
                }
            }
            public CfxCursorInfo CustomCursorInfo {
                get {
                    CheckAccess();
                    if(m_custom_cursor_info_wrapped == null) m_custom_cursor_info_wrapped = CfxCursorInfo.Wrap(m_custom_cursor_info);
                    return m_custom_cursor_info_wrapped;
                }
            }

            public override string ToString() {
                return String.Format("Browser={{{0}}}, Cursor={{{1}}}, Type={{{2}}}, CustomCursorInfo={{{3}}}", Browser, Cursor, Type, CustomCursorInfo);
            }
        }

        public delegate void CfxStartDraggingEventHandler(object sender, CfxStartDraggingEventArgs e);

        /// <summary>
        /// Called when the user starts dragging content in the web view. Contextual
        /// information about the dragged content is supplied by |DragData|. OS APIs
        /// that run a system message loop may be used within the StartDragging call.
        /// Return false (0) to abort the drag operation. Don't call any of
        /// CfxBrowserHost.DragSource*Ended* functions after returning false (0).
        /// Return true (1) to handle the drag operation. Call
        /// CfxBrowserHost.DragSourceEndedAt and DragSourceSystemDragEnded either
        /// synchronously or asynchronously to inform the web view that the drag
        /// operation has ended.
        /// </summary>
        public class CfxStartDraggingEventArgs : CfxEventArgs {

            internal IntPtr m_browser;
            internal CfxBrowser m_browser_wrapped;
            internal IntPtr m_drag_data;
            internal CfxDragData m_drag_data_wrapped;
            internal CfxDragOperationsMask m_allowed_ops;
            internal int m_x;
            internal int m_y;

            internal bool m_returnValue;
            private bool returnValueSet;

            internal CfxStartDraggingEventArgs(IntPtr browser, IntPtr drag_data, CfxDragOperationsMask allowed_ops, int x, int y) {
                m_browser = browser;
                m_drag_data = drag_data;
                m_allowed_ops = allowed_ops;
                m_x = x;
                m_y = y;
            }

            public CfxBrowser Browser {
                get {
                    CheckAccess();
                    if(m_browser_wrapped == null) m_browser_wrapped = CfxBrowser.Wrap(m_browser);
                    return m_browser_wrapped;
                }
            }
            public CfxDragData DragData {
                get {
                    CheckAccess();
                    if(m_drag_data_wrapped == null) m_drag_data_wrapped = CfxDragData.Wrap(m_drag_data);
                    return m_drag_data_wrapped;
                }
            }
            public CfxDragOperationsMask AllowedOps {
                get {
                    CheckAccess();
                    return m_allowed_ops;
                }
            }
            public int X {
                get {
                    CheckAccess();
                    return m_x;
                }
            }
            public int Y {
                get {
                    CheckAccess();
                    return m_y;
                }
            }
            public void SetReturnValue(bool returnValue) {
                CheckAccess();
                if(returnValueSet) {
                    throw new CfxException("The return value has already been set");
                }
                returnValueSet = true;
                this.m_returnValue = returnValue;
            }

            public override string ToString() {
                return String.Format("Browser={{{0}}}, DragData={{{1}}}, AllowedOps={{{2}}}, X={{{3}}}, Y={{{4}}}", Browser, DragData, AllowedOps, X, Y);
            }
        }

        public delegate void CfxUpdateDragCursorEventHandler(object sender, CfxUpdateDragCursorEventArgs e);

        /// <summary>
        /// Called when the web view wants to update the mouse cursor during a drag &amp;
        /// drop operation. |Operation| describes the allowed operation (none, move,
        /// copy, link).
        /// </summary>
        public class CfxUpdateDragCursorEventArgs : CfxEventArgs {

            internal IntPtr m_browser;
            internal CfxBrowser m_browser_wrapped;
            internal CfxDragOperationsMask m_operation;

            internal CfxUpdateDragCursorEventArgs(IntPtr browser, CfxDragOperationsMask operation) {
                m_browser = browser;
                m_operation = operation;
            }

            public CfxBrowser Browser {
                get {
                    CheckAccess();
                    if(m_browser_wrapped == null) m_browser_wrapped = CfxBrowser.Wrap(m_browser);
                    return m_browser_wrapped;
                }
            }
            public CfxDragOperationsMask Operation {
                get {
                    CheckAccess();
                    return m_operation;
                }
            }

            public override string ToString() {
                return String.Format("Browser={{{0}}}, Operation={{{1}}}", Browser, Operation);
            }
        }

        public delegate void CfxOnScrollOffsetChangedEventHandler(object sender, CfxOnScrollOffsetChangedEventArgs e);

        /// <summary>
        /// Called when the scroll offset has changed.
        /// </summary>
        public class CfxOnScrollOffsetChangedEventArgs : CfxEventArgs {

            internal IntPtr m_browser;
            internal CfxBrowser m_browser_wrapped;

            internal CfxOnScrollOffsetChangedEventArgs(IntPtr browser) {
                m_browser = browser;
            }

            public CfxBrowser Browser {
                get {
                    CheckAccess();
                    if(m_browser_wrapped == null) m_browser_wrapped = CfxBrowser.Wrap(m_browser);
                    return m_browser_wrapped;
                }
            }

            public override string ToString() {
                return String.Format("Browser={{{0}}}", Browser);
            }
        }

    }
}
