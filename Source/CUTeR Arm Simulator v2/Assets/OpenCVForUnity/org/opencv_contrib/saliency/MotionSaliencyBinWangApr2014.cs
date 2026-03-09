
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;

namespace OpenCVForUnity.SaliencyModule
{

    // C++: class MotionSaliencyBinWangApr2014
    /// <summary>
    ///  the Fast Self-tuning Background Subtraction Algorithm from @cite BinWangApr2014
    /// </summary>
    public class MotionSaliencyBinWangApr2014 : MotionSaliency
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
                        saliency_MotionSaliencyBinWangApr2014_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal MotionSaliencyBinWangApr2014(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new MotionSaliencyBinWangApr2014 __fromPtr__(IntPtr addr) { return new MotionSaliencyBinWangApr2014(addr); }

        //
        // C++: static Ptr_MotionSaliencyBinWangApr2014 cv::saliency::MotionSaliencyBinWangApr2014::create()
        //

        public static MotionSaliencyBinWangApr2014 create()
        {


            return MotionSaliencyBinWangApr2014.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(saliency_MotionSaliencyBinWangApr2014_create_10()));


        }


        //
        // C++:  bool cv::saliency::MotionSaliencyBinWangApr2014::computeSaliency(Mat image, Mat& saliencyMap)
        //

        public override bool computeSaliency(Mat image, Mat saliencyMap)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (saliencyMap != null) saliencyMap.ThrowIfDisposed();

            return saliency_MotionSaliencyBinWangApr2014_computeSaliency_10(nativeObj, image.nativeObj, saliencyMap.nativeObj);


        }


        //
        // C++:  void cv::saliency::MotionSaliencyBinWangApr2014::setImagesize(int W, int H)
        //

        /// <summary>
        ///  This is a utility function that allows to set the correct size (taken from the input image) in the
        ///      corresponding variables that will be used to size the data structures of the algorithm.
        /// </summary>
        /// <param name="W">
        /// width of input image
        /// </param>
        /// <param name="H">
        /// height of input image
        /// </param>
        public void setImagesize(int W, int H)
        {
            ThrowIfDisposed();

            saliency_MotionSaliencyBinWangApr2014_setImagesize_10(nativeObj, W, H);


        }


        //
        // C++:  bool cv::saliency::MotionSaliencyBinWangApr2014::init()
        //

        /// <summary>
        ///  This function allows the correct initialization of all data structures that will be used by the
        ///      algorithm.
        /// </summary>
        public bool init()
        {
            ThrowIfDisposed();

            return saliency_MotionSaliencyBinWangApr2014_init_10(nativeObj);


        }


        //
        // C++:  int cv::saliency::MotionSaliencyBinWangApr2014::getImageWidth()
        //

        public int getImageWidth()
        {
            ThrowIfDisposed();

            return saliency_MotionSaliencyBinWangApr2014_getImageWidth_10(nativeObj);


        }


        //
        // C++:  void cv::saliency::MotionSaliencyBinWangApr2014::setImageWidth(int val)
        //

        public void setImageWidth(int val)
        {
            ThrowIfDisposed();

            saliency_MotionSaliencyBinWangApr2014_setImageWidth_10(nativeObj, val);


        }


        //
        // C++:  int cv::saliency::MotionSaliencyBinWangApr2014::getImageHeight()
        //

        public int getImageHeight()
        {
            ThrowIfDisposed();

            return saliency_MotionSaliencyBinWangApr2014_getImageHeight_10(nativeObj);


        }


        //
        // C++:  void cv::saliency::MotionSaliencyBinWangApr2014::setImageHeight(int val)
        //

        public void setImageHeight(int val)
        {
            ThrowIfDisposed();

            saliency_MotionSaliencyBinWangApr2014_setImageHeight_10(nativeObj, val);


        }


#if (UNITY_IOS || UNITY_VISIONOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++: static Ptr_MotionSaliencyBinWangApr2014 cv::saliency::MotionSaliencyBinWangApr2014::create()
        [DllImport(LIBNAME)]
        private static extern IntPtr saliency_MotionSaliencyBinWangApr2014_create_10();

        // C++:  bool cv::saliency::MotionSaliencyBinWangApr2014::computeSaliency(Mat image, Mat& saliencyMap)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool saliency_MotionSaliencyBinWangApr2014_computeSaliency_10(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr saliencyMap_nativeObj);

        // C++:  void cv::saliency::MotionSaliencyBinWangApr2014::setImagesize(int W, int H)
        [DllImport(LIBNAME)]
        private static extern void saliency_MotionSaliencyBinWangApr2014_setImagesize_10(IntPtr nativeObj, int W, int H);

        // C++:  bool cv::saliency::MotionSaliencyBinWangApr2014::init()
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool saliency_MotionSaliencyBinWangApr2014_init_10(IntPtr nativeObj);

        // C++:  int cv::saliency::MotionSaliencyBinWangApr2014::getImageWidth()
        [DllImport(LIBNAME)]
        private static extern int saliency_MotionSaliencyBinWangApr2014_getImageWidth_10(IntPtr nativeObj);

        // C++:  void cv::saliency::MotionSaliencyBinWangApr2014::setImageWidth(int val)
        [DllImport(LIBNAME)]
        private static extern void saliency_MotionSaliencyBinWangApr2014_setImageWidth_10(IntPtr nativeObj, int val);

        // C++:  int cv::saliency::MotionSaliencyBinWangApr2014::getImageHeight()
        [DllImport(LIBNAME)]
        private static extern int saliency_MotionSaliencyBinWangApr2014_getImageHeight_10(IntPtr nativeObj);

        // C++:  void cv::saliency::MotionSaliencyBinWangApr2014::setImageHeight(int val)
        [DllImport(LIBNAME)]
        private static extern void saliency_MotionSaliencyBinWangApr2014_setImageHeight_10(IntPtr nativeObj, int val);

        // native support for java finalize() or cleaner
        [DllImport(LIBNAME)]
        private static extern void saliency_MotionSaliencyBinWangApr2014_delete(IntPtr nativeObj);

    }
}
