
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;

namespace OpenCVForUnity.SaliencyModule
{

    // C++: class Objectness
    /// <remarks>
    ///   ********************************* Objectness Base Class ***********************************
    /// </remarks>
    public class Objectness : Saliency
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
                        saliency_Objectness_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal Objectness(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new Objectness __fromPtr__(IntPtr addr) { return new Objectness(addr); }

#if (UNITY_IOS || UNITY_VISIONOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // native support for java finalize() or cleaner
        [DllImport(LIBNAME)]
        private static extern void saliency_Objectness_delete(IntPtr nativeObj);

    }
}
