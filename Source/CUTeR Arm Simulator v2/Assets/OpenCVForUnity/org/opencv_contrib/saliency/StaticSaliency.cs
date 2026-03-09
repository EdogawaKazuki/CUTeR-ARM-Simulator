
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;

namespace OpenCVForUnity.SaliencyModule
{

    // C++: class StaticSaliency
    /// <remarks>
    ///   ********************************* Static Saliency Base Class ***********************************
    /// </remarks>
    public class StaticSaliency : Saliency
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
                        saliency_StaticSaliency_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal StaticSaliency(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new StaticSaliency __fromPtr__(IntPtr addr) { return new StaticSaliency(addr); }

        //
        // C++:  bool cv::saliency::StaticSaliency::computeBinaryMap(Mat _saliencyMap, Mat& _binaryMap)
        //

        /// <summary>
        ///  This function perform a binary map of given saliency map. This is obtained in this
        ///      way:
        /// </summary>
        /// <remarks>
        ///      In a first step, to improve the definition of interest areas and facilitate identification of
        ///      targets, a segmentation by clustering is performed, using *K-means algorithm*. Then, to gain a
        ///      binary representation of clustered saliency map, since values of the map can vary according to
        ///      the characteristics of frame under analysis, it is not convenient to use a fixed threshold. So,
        ///       Otsu's algorithm* is used, which assumes that the image to be thresholded contains two classes
        ///      of pixels or bi-modal histograms (e.g. foreground and back-ground pixels); later on, the
        ///      algorithm calculates the optimal threshold separating those two classes, so that their
        ///      intra-class variance is minimal.
        /// </remarks>
        /// <param name="_saliencyMap">
        /// the saliency map obtained through one of the specialized algorithms
        /// </param>
        /// <param name="_binaryMap">
        /// the binary map
        /// </param>
        public bool computeBinaryMap(Mat _saliencyMap, Mat _binaryMap)
        {
            ThrowIfDisposed();
            if (_saliencyMap != null) _saliencyMap.ThrowIfDisposed();
            if (_binaryMap != null) _binaryMap.ThrowIfDisposed();

            return saliency_StaticSaliency_computeBinaryMap_10(nativeObj, _saliencyMap.nativeObj, _binaryMap.nativeObj);


        }


#if (UNITY_IOS || UNITY_VISIONOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  bool cv::saliency::StaticSaliency::computeBinaryMap(Mat _saliencyMap, Mat& _binaryMap)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool saliency_StaticSaliency_computeBinaryMap_10(IntPtr nativeObj, IntPtr _saliencyMap_nativeObj, IntPtr _binaryMap_nativeObj);

        // native support for java finalize() or cleaner
        [DllImport(LIBNAME)]
        private static extern void saliency_StaticSaliency_delete(IntPtr nativeObj);

    }
}
