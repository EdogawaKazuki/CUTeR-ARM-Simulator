
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;

namespace OpenCVForUnity.SaliencyModule
{

    // C++: class StaticSaliencyFineGrained
    /// <summary>
    ///  the Fine Grained Saliency approach from @cite FGS
    /// </summary>
    /// <remarks>
    ///  This method calculates saliency based on center-surround differences.
    ///  High resolution saliency maps are generated in real time by using integral images.
    /// </remarks>
    public class StaticSaliencyFineGrained : StaticSaliency
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
                        saliency_StaticSaliencyFineGrained_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal StaticSaliencyFineGrained(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new StaticSaliencyFineGrained __fromPtr__(IntPtr addr) { return new StaticSaliencyFineGrained(addr); }

        //
        // C++: static Ptr_StaticSaliencyFineGrained cv::saliency::StaticSaliencyFineGrained::create()
        //

        public static StaticSaliencyFineGrained create()
        {


            return StaticSaliencyFineGrained.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(saliency_StaticSaliencyFineGrained_create_10()));


        }


        //
        // C++:  bool cv::saliency::StaticSaliencyFineGrained::computeSaliency(Mat image, Mat& saliencyMap)
        //

        public override bool computeSaliency(Mat image, Mat saliencyMap)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (saliencyMap != null) saliencyMap.ThrowIfDisposed();

            return saliency_StaticSaliencyFineGrained_computeSaliency_10(nativeObj, image.nativeObj, saliencyMap.nativeObj);


        }


#if (UNITY_IOS || UNITY_VISIONOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++: static Ptr_StaticSaliencyFineGrained cv::saliency::StaticSaliencyFineGrained::create()
        [DllImport(LIBNAME)]
        private static extern IntPtr saliency_StaticSaliencyFineGrained_create_10();

        // C++:  bool cv::saliency::StaticSaliencyFineGrained::computeSaliency(Mat image, Mat& saliencyMap)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool saliency_StaticSaliencyFineGrained_computeSaliency_10(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr saliencyMap_nativeObj);

        // native support for java finalize() or cleaner
        [DllImport(LIBNAME)]
        private static extern void saliency_StaticSaliencyFineGrained_delete(IntPtr nativeObj);

    }
}
