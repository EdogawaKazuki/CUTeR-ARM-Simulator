
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;

namespace OpenCVForUnity.SaliencyModule
{

    // C++: class StaticSaliencySpectralResidual
    /// <summary>
    ///  the Spectral Residual approach from  @cite SR
    /// </summary>
    /// <remarks>
    ///  Starting from the principle of natural image statistics, this method simulate the behavior of
    ///  pre-attentive visual search. The algorithm analyze the log spectrum of each image and obtain the
    ///  spectral residual. Then transform the spectral residual to spatial domain to obtain the saliency
    ///  map, which suggests the positions of proto-objects.
    /// </remarks>
    public class StaticSaliencySpectralResidual : StaticSaliency
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
                        saliency_StaticSaliencySpectralResidual_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal StaticSaliencySpectralResidual(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new StaticSaliencySpectralResidual __fromPtr__(IntPtr addr) { return new StaticSaliencySpectralResidual(addr); }

        //
        // C++: static Ptr_StaticSaliencySpectralResidual cv::saliency::StaticSaliencySpectralResidual::create()
        //

        public static StaticSaliencySpectralResidual create()
        {


            return StaticSaliencySpectralResidual.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(saliency_StaticSaliencySpectralResidual_create_10()));


        }


        //
        // C++:  bool cv::saliency::StaticSaliencySpectralResidual::computeSaliency(Mat image, Mat& saliencyMap)
        //

        public override bool computeSaliency(Mat image, Mat saliencyMap)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (saliencyMap != null) saliencyMap.ThrowIfDisposed();

            return saliency_StaticSaliencySpectralResidual_computeSaliency_10(nativeObj, image.nativeObj, saliencyMap.nativeObj);


        }


        //
        // C++:  void cv::saliency::StaticSaliencySpectralResidual::read(FileNode fn)
        //

        // Unknown type 'FileNode' (I), skipping the function


        //
        // C++:  void cv::saliency::StaticSaliencySpectralResidual::write(FileStorage fs)
        //

        // Unknown type 'FileStorage' (I), skipping the function


        //
        // C++:  int cv::saliency::StaticSaliencySpectralResidual::getImageWidth()
        //

        public int getImageWidth()
        {
            ThrowIfDisposed();

            return saliency_StaticSaliencySpectralResidual_getImageWidth_10(nativeObj);


        }


        //
        // C++:  void cv::saliency::StaticSaliencySpectralResidual::setImageWidth(int val)
        //

        public void setImageWidth(int val)
        {
            ThrowIfDisposed();

            saliency_StaticSaliencySpectralResidual_setImageWidth_10(nativeObj, val);


        }


        //
        // C++:  int cv::saliency::StaticSaliencySpectralResidual::getImageHeight()
        //

        public int getImageHeight()
        {
            ThrowIfDisposed();

            return saliency_StaticSaliencySpectralResidual_getImageHeight_10(nativeObj);


        }


        //
        // C++:  void cv::saliency::StaticSaliencySpectralResidual::setImageHeight(int val)
        //

        public void setImageHeight(int val)
        {
            ThrowIfDisposed();

            saliency_StaticSaliencySpectralResidual_setImageHeight_10(nativeObj, val);


        }


#if (UNITY_IOS || UNITY_VISIONOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++: static Ptr_StaticSaliencySpectralResidual cv::saliency::StaticSaliencySpectralResidual::create()
        [DllImport(LIBNAME)]
        private static extern IntPtr saliency_StaticSaliencySpectralResidual_create_10();

        // C++:  bool cv::saliency::StaticSaliencySpectralResidual::computeSaliency(Mat image, Mat& saliencyMap)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool saliency_StaticSaliencySpectralResidual_computeSaliency_10(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr saliencyMap_nativeObj);

        // C++:  int cv::saliency::StaticSaliencySpectralResidual::getImageWidth()
        [DllImport(LIBNAME)]
        private static extern int saliency_StaticSaliencySpectralResidual_getImageWidth_10(IntPtr nativeObj);

        // C++:  void cv::saliency::StaticSaliencySpectralResidual::setImageWidth(int val)
        [DllImport(LIBNAME)]
        private static extern void saliency_StaticSaliencySpectralResidual_setImageWidth_10(IntPtr nativeObj, int val);

        // C++:  int cv::saliency::StaticSaliencySpectralResidual::getImageHeight()
        [DllImport(LIBNAME)]
        private static extern int saliency_StaticSaliencySpectralResidual_getImageHeight_10(IntPtr nativeObj);

        // C++:  void cv::saliency::StaticSaliencySpectralResidual::setImageHeight(int val)
        [DllImport(LIBNAME)]
        private static extern void saliency_StaticSaliencySpectralResidual_setImageHeight_10(IntPtr nativeObj, int val);

        // native support for java finalize() or cleaner
        [DllImport(LIBNAME)]
        private static extern void saliency_StaticSaliencySpectralResidual_delete(IntPtr nativeObj);

    }
}
