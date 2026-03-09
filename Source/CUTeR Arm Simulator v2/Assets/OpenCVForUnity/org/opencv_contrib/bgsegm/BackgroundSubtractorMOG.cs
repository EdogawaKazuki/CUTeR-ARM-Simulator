
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using OpenCVForUnity.VideoModule;

namespace OpenCVForUnity.BgsegmModule
{

    // C++: class BackgroundSubtractorMOG
    /// <summary>
    ///  Gaussian Mixture-based Background/Foreground Segmentation Algorithm.
    /// </summary>
    /// <remarks>
    ///  The class implements the algorithm described in @cite KB2001 .
    /// </remarks>
    public class BackgroundSubtractorMOG : BackgroundSubtractor
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
                        bgsegm_BackgroundSubtractorMOG_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal BackgroundSubtractorMOG(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new BackgroundSubtractorMOG __fromPtr__(IntPtr addr) { return new BackgroundSubtractorMOG(addr); }

        //
        // C++:  void cv::bgsegm::BackgroundSubtractorMOG::apply(Mat image, Mat& fgmask, double learningRate = -1)
        //

        /// <summary>
        ///  Computes a foreground mask.
        /// </summary>
        /// <param name="image">
        /// Next video frame of type CV_8UC(n),CV_8SC(n),CV_16UC(n),CV_16SC(n),CV_32SC(n),CV_32FC(n),CV_64FC(n), where n is 1,2,3,4.
        /// </param>
        /// <param name="fgmask">
        /// The output foreground mask as an 8-bit binary image.
        /// </param>
        /// <param name="learningRate">
        /// The value between 0 and 1 that indicates how fast the background model is
        ///      learnt. Negative parameter value makes the algorithm to use some automatically chosen learning
        ///      rate. 0 means that the background model is not updated at all, 1 means that the background model
        ///      is completely reinitialized from the last frame.
        /// </param>
        public override void apply(Mat image, Mat fgmask, double learningRate)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (fgmask != null) fgmask.ThrowIfDisposed();

            bgsegm_BackgroundSubtractorMOG_apply_10(nativeObj, image.nativeObj, fgmask.nativeObj, learningRate);


        }

        /// <summary>
        ///  Computes a foreground mask.
        /// </summary>
        /// <param name="image">
        /// Next video frame of type CV_8UC(n),CV_8SC(n),CV_16UC(n),CV_16SC(n),CV_32SC(n),CV_32FC(n),CV_64FC(n), where n is 1,2,3,4.
        /// </param>
        /// <param name="fgmask">
        /// The output foreground mask as an 8-bit binary image.
        /// </param>
        /// <param name="learningRate">
        /// The value between 0 and 1 that indicates how fast the background model is
        ///      learnt. Negative parameter value makes the algorithm to use some automatically chosen learning
        ///      rate. 0 means that the background model is not updated at all, 1 means that the background model
        ///      is completely reinitialized from the last frame.
        /// </param>
        public override void apply(Mat image, Mat fgmask)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (fgmask != null) fgmask.ThrowIfDisposed();

            bgsegm_BackgroundSubtractorMOG_apply_11(nativeObj, image.nativeObj, fgmask.nativeObj);


        }


        //
        // C++:  void cv::bgsegm::BackgroundSubtractorMOG::apply(Mat image, Mat knownForegroundMask, Mat& fgmask, double learningRate = -1)
        //

        /// <summary>
        ///  Computes a foreground mask and skips known foreground in evaluation.
        /// </summary>
        /// <param name="image">
        /// Next video frame of type CV_8UC(n),CV_8SC(n),CV_16UC(n),CV_16SC(n),CV_32SC(n),CV_32FC(n),CV_64FC(n), where n is 1,2,3,4.
        /// </param>
        /// <param name="fgmask">
        /// The output foreground mask as an 8-bit binary image.
        /// </param>
        /// <param name="knownForegroundMask">
        /// The mask for inputting already known foreground, allows model to ignore learning known pixels.
        /// </param>
        /// <param name="learningRate">
        /// The value between 0 and 1 that indicates how fast the background model is
        ///      learnt. Negative parameter value makes the algorithm to use some automatically chosen learning
        ///      rate. 0 means that the background model is not updated at all, 1 means that the background model
        ///      is completely reinitialized from the last frame.
        /// </param>
        public override void apply(Mat image, Mat knownForegroundMask, Mat fgmask, double learningRate)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (knownForegroundMask != null) knownForegroundMask.ThrowIfDisposed();
            if (fgmask != null) fgmask.ThrowIfDisposed();

            bgsegm_BackgroundSubtractorMOG_apply_12(nativeObj, image.nativeObj, knownForegroundMask.nativeObj, fgmask.nativeObj, learningRate);


        }

        /// <summary>
        ///  Computes a foreground mask and skips known foreground in evaluation.
        /// </summary>
        /// <param name="image">
        /// Next video frame of type CV_8UC(n),CV_8SC(n),CV_16UC(n),CV_16SC(n),CV_32SC(n),CV_32FC(n),CV_64FC(n), where n is 1,2,3,4.
        /// </param>
        /// <param name="fgmask">
        /// The output foreground mask as an 8-bit binary image.
        /// </param>
        /// <param name="knownForegroundMask">
        /// The mask for inputting already known foreground, allows model to ignore learning known pixels.
        /// </param>
        /// <param name="learningRate">
        /// The value between 0 and 1 that indicates how fast the background model is
        ///      learnt. Negative parameter value makes the algorithm to use some automatically chosen learning
        ///      rate. 0 means that the background model is not updated at all, 1 means that the background model
        ///      is completely reinitialized from the last frame.
        /// </param>
        public override void apply(Mat image, Mat knownForegroundMask, Mat fgmask)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (knownForegroundMask != null) knownForegroundMask.ThrowIfDisposed();
            if (fgmask != null) fgmask.ThrowIfDisposed();

            bgsegm_BackgroundSubtractorMOG_apply_13(nativeObj, image.nativeObj, knownForegroundMask.nativeObj, fgmask.nativeObj);


        }


        //
        // C++:  int cv::bgsegm::BackgroundSubtractorMOG::getHistory()
        //

        public int getHistory()
        {
            ThrowIfDisposed();

            return bgsegm_BackgroundSubtractorMOG_getHistory_10(nativeObj);


        }


        //
        // C++:  void cv::bgsegm::BackgroundSubtractorMOG::setHistory(int nframes)
        //

        public void setHistory(int nframes)
        {
            ThrowIfDisposed();

            bgsegm_BackgroundSubtractorMOG_setHistory_10(nativeObj, nframes);


        }


        //
        // C++:  int cv::bgsegm::BackgroundSubtractorMOG::getNMixtures()
        //

        public int getNMixtures()
        {
            ThrowIfDisposed();

            return bgsegm_BackgroundSubtractorMOG_getNMixtures_10(nativeObj);


        }


        //
        // C++:  void cv::bgsegm::BackgroundSubtractorMOG::setNMixtures(int nmix)
        //

        public void setNMixtures(int nmix)
        {
            ThrowIfDisposed();

            bgsegm_BackgroundSubtractorMOG_setNMixtures_10(nativeObj, nmix);


        }


        //
        // C++:  double cv::bgsegm::BackgroundSubtractorMOG::getBackgroundRatio()
        //

        public double getBackgroundRatio()
        {
            ThrowIfDisposed();

            return bgsegm_BackgroundSubtractorMOG_getBackgroundRatio_10(nativeObj);


        }


        //
        // C++:  void cv::bgsegm::BackgroundSubtractorMOG::setBackgroundRatio(double backgroundRatio)
        //

        public void setBackgroundRatio(double backgroundRatio)
        {
            ThrowIfDisposed();

            bgsegm_BackgroundSubtractorMOG_setBackgroundRatio_10(nativeObj, backgroundRatio);


        }


        //
        // C++:  double cv::bgsegm::BackgroundSubtractorMOG::getNoiseSigma()
        //

        public double getNoiseSigma()
        {
            ThrowIfDisposed();

            return bgsegm_BackgroundSubtractorMOG_getNoiseSigma_10(nativeObj);


        }


        //
        // C++:  void cv::bgsegm::BackgroundSubtractorMOG::setNoiseSigma(double noiseSigma)
        //

        public void setNoiseSigma(double noiseSigma)
        {
            ThrowIfDisposed();

            bgsegm_BackgroundSubtractorMOG_setNoiseSigma_10(nativeObj, noiseSigma);


        }


#if (UNITY_IOS || UNITY_VISIONOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  void cv::bgsegm::BackgroundSubtractorMOG::apply(Mat image, Mat& fgmask, double learningRate = -1)
        [DllImport(LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorMOG_apply_10(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr fgmask_nativeObj, double learningRate);
        [DllImport(LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorMOG_apply_11(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr fgmask_nativeObj);

        // C++:  void cv::bgsegm::BackgroundSubtractorMOG::apply(Mat image, Mat knownForegroundMask, Mat& fgmask, double learningRate = -1)
        [DllImport(LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorMOG_apply_12(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr knownForegroundMask_nativeObj, IntPtr fgmask_nativeObj, double learningRate);
        [DllImport(LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorMOG_apply_13(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr knownForegroundMask_nativeObj, IntPtr fgmask_nativeObj);

        // C++:  int cv::bgsegm::BackgroundSubtractorMOG::getHistory()
        [DllImport(LIBNAME)]
        private static extern int bgsegm_BackgroundSubtractorMOG_getHistory_10(IntPtr nativeObj);

        // C++:  void cv::bgsegm::BackgroundSubtractorMOG::setHistory(int nframes)
        [DllImport(LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorMOG_setHistory_10(IntPtr nativeObj, int nframes);

        // C++:  int cv::bgsegm::BackgroundSubtractorMOG::getNMixtures()
        [DllImport(LIBNAME)]
        private static extern int bgsegm_BackgroundSubtractorMOG_getNMixtures_10(IntPtr nativeObj);

        // C++:  void cv::bgsegm::BackgroundSubtractorMOG::setNMixtures(int nmix)
        [DllImport(LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorMOG_setNMixtures_10(IntPtr nativeObj, int nmix);

        // C++:  double cv::bgsegm::BackgroundSubtractorMOG::getBackgroundRatio()
        [DllImport(LIBNAME)]
        private static extern double bgsegm_BackgroundSubtractorMOG_getBackgroundRatio_10(IntPtr nativeObj);

        // C++:  void cv::bgsegm::BackgroundSubtractorMOG::setBackgroundRatio(double backgroundRatio)
        [DllImport(LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorMOG_setBackgroundRatio_10(IntPtr nativeObj, double backgroundRatio);

        // C++:  double cv::bgsegm::BackgroundSubtractorMOG::getNoiseSigma()
        [DllImport(LIBNAME)]
        private static extern double bgsegm_BackgroundSubtractorMOG_getNoiseSigma_10(IntPtr nativeObj);

        // C++:  void cv::bgsegm::BackgroundSubtractorMOG::setNoiseSigma(double noiseSigma)
        [DllImport(LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorMOG_setNoiseSigma_10(IntPtr nativeObj, double noiseSigma);

        // native support for java finalize() or cleaner
        [DllImport(LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorMOG_delete(IntPtr nativeObj);

    }
}
