
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;

namespace OpenCVForUnity.SaliencyModule
{

    // C++: class Saliency
    /// <remarks>
    ///   ********************************* Saliency Base Class ***********************************
    /// </remarks>
    public class Saliency : Algorithm
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
                        saliency_Saliency_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal Saliency(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new Saliency __fromPtr__(IntPtr addr) { return new Saliency(addr); }

        //
        // C++:  bool cv::saliency::Saliency::computeSaliency(Mat image, Mat& saliencyMap)
        //

        /// <remarks>
        ///    \brief Compute the saliency
        ///       \param image        The image.
        ///       \param saliencyMap      The computed saliency map.
        ///       \return true if the saliency map is computed, false otherwise
        /// </remarks>
        public virtual bool computeSaliency(Mat image, Mat saliencyMap)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (saliencyMap != null) saliencyMap.ThrowIfDisposed();

            return saliency_Saliency_computeSaliency_10(nativeObj, image.nativeObj, saliencyMap.nativeObj);


        }


#if (UNITY_IOS || UNITY_VISIONOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  bool cv::saliency::Saliency::computeSaliency(Mat image, Mat& saliencyMap)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool saliency_Saliency_computeSaliency_10(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr saliencyMap_nativeObj);

        // native support for java finalize() or cleaner
        [DllImport(LIBNAME)]
        private static extern void saliency_Saliency_delete(IntPtr nativeObj);

    }
}
