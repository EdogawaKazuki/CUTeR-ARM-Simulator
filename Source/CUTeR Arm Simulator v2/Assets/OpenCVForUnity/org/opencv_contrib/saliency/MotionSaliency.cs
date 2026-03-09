
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;

namespace OpenCVForUnity.SaliencyModule
{

    // C++: class MotionSaliency
    /// <remarks>
    ///   ********************************* Motion Saliency Base Class ***********************************
    /// </remarks>
    public class MotionSaliency : Saliency
    {

        protected override void Dispose(bool disposing)
        {

            try
            {
                if (disposing)
                {
                }
                if (IsEnabledDispose)
                {
                    if (nativeObj != IntPtr.Zero)
                        saliency_MotionSaliency_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal MotionSaliency(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new MotionSaliency __fromPtr__(IntPtr addr) { return new MotionSaliency(addr); }

#if (UNITY_IOS || UNITY_VISIONOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // native support for java finalize() or cleaner
        [DllImport(LIBNAME)]
        private static extern void saliency_MotionSaliency_delete(IntPtr nativeObj);

    }
}
