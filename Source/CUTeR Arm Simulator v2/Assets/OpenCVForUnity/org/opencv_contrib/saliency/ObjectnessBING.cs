
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;

namespace OpenCVForUnity.SaliencyModule
{

    // C++: class ObjectnessBING
    /// <summary>
    ///  the Binarized normed gradients algorithm from @cite BING
    /// </summary>
    public class ObjectnessBING : Objectness
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
                        saliency_ObjectnessBING_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal ObjectnessBING(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new ObjectnessBING __fromPtr__(IntPtr addr) { return new ObjectnessBING(addr); }

        //
        // C++: static Ptr_ObjectnessBING cv::saliency::ObjectnessBING::create()
        //

        public static ObjectnessBING create()
        {


            return ObjectnessBING.__fromPtr__(DisposableObject.ThrowIfNullIntPtr(saliency_ObjectnessBING_create_10()));


        }


        //
        // C++:  bool cv::saliency::ObjectnessBING::computeSaliency(Mat image, Mat& saliencyMap)
        //

        public override bool computeSaliency(Mat image, Mat saliencyMap)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (saliencyMap != null) saliencyMap.ThrowIfDisposed();

            return saliency_ObjectnessBING_computeSaliency_10(nativeObj, image.nativeObj, saliencyMap.nativeObj);


        }


        //
        // C++:  vector_float cv::saliency::ObjectnessBING::getobjectnessValues()
        //

        /// <summary>
        ///  Return the list of the rectangles' objectness value,
        /// </summary>
        /// <remarks>
        ///      in the same order as the *vector&lt;Vec4i&gt; objectnessBoundingBox* returned by the algorithm (in
        ///      computeSaliencyImpl function). The bigger value these scores are, it is more likely to be an
        ///      object window.
        /// </remarks>
        public MatOfFloat getobjectnessValues()
        {
            ThrowIfDisposed();

            return MatOfFloat.fromNativeAddr(DisposableObject.ThrowIfNullIntPtr(saliency_ObjectnessBING_getobjectnessValues_10(nativeObj)));


        }


        //
        // C++:  void cv::saliency::ObjectnessBING::setTrainingPath(String trainingPath)
        //

        /// <summary>
        ///  This is a utility function that allows to set the correct path from which the algorithm will load
        ///      the trained model.
        /// </summary>
        /// <param name="trainingPath">
        /// trained model path
        /// </param>
        public void setTrainingPath(string trainingPath)
        {
            ThrowIfDisposed();

            saliency_ObjectnessBING_setTrainingPath_10(nativeObj, trainingPath);


        }


        //
        // C++:  void cv::saliency::ObjectnessBING::setBBResDir(String resultsDir)
        //

        /// <summary>
        ///  This is a utility function that allows to set an arbitrary path in which the algorithm will save the
        ///      optional results
        /// </summary>
        /// <remarks>
        ///      (ie writing on file the total number and the list of rectangles returned by objectess, one for
        ///      each row).
        /// </remarks>
        /// <param name="resultsDir">
        /// results' folder path
        /// </param>
        public void setBBResDir(string resultsDir)
        {
            ThrowIfDisposed();

            saliency_ObjectnessBING_setBBResDir_10(nativeObj, resultsDir);


        }


        //
        // C++:  double cv::saliency::ObjectnessBING::getBase()
        //

        public double getBase()
        {
            ThrowIfDisposed();

            return saliency_ObjectnessBING_getBase_10(nativeObj);


        }


        //
        // C++:  void cv::saliency::ObjectnessBING::setBase(double val)
        //

        public void setBase(double val)
        {
            ThrowIfDisposed();

            saliency_ObjectnessBING_setBase_10(nativeObj, val);


        }


        //
        // C++:  int cv::saliency::ObjectnessBING::getNSS()
        //

        public int getNSS()
        {
            ThrowIfDisposed();

            return saliency_ObjectnessBING_getNSS_10(nativeObj);


        }


        //
        // C++:  void cv::saliency::ObjectnessBING::setNSS(int val)
        //

        public void setNSS(int val)
        {
            ThrowIfDisposed();

            saliency_ObjectnessBING_setNSS_10(nativeObj, val);


        }


        //
        // C++:  int cv::saliency::ObjectnessBING::getW()
        //

        public int getW()
        {
            ThrowIfDisposed();

            return saliency_ObjectnessBING_getW_10(nativeObj);


        }


        //
        // C++:  void cv::saliency::ObjectnessBING::setW(int val)
        //

        public void setW(int val)
        {
            ThrowIfDisposed();

            saliency_ObjectnessBING_setW_10(nativeObj, val);


        }


#if (UNITY_IOS || UNITY_VISIONOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++: static Ptr_ObjectnessBING cv::saliency::ObjectnessBING::create()
        [DllImport(LIBNAME)]
        private static extern IntPtr saliency_ObjectnessBING_create_10();

        // C++:  bool cv::saliency::ObjectnessBING::computeSaliency(Mat image, Mat& saliencyMap)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool saliency_ObjectnessBING_computeSaliency_10(IntPtr nativeObj, IntPtr image_nativeObj, IntPtr saliencyMap_nativeObj);

        // C++:  vector_float cv::saliency::ObjectnessBING::getobjectnessValues()
        [DllImport(LIBNAME)]
        private static extern IntPtr saliency_ObjectnessBING_getobjectnessValues_10(IntPtr nativeObj);

        // C++:  void cv::saliency::ObjectnessBING::setTrainingPath(String trainingPath)
        [DllImport(LIBNAME)]
        private static extern void saliency_ObjectnessBING_setTrainingPath_10(IntPtr nativeObj, string trainingPath);

        // C++:  void cv::saliency::ObjectnessBING::setBBResDir(String resultsDir)
        [DllImport(LIBNAME)]
        private static extern void saliency_ObjectnessBING_setBBResDir_10(IntPtr nativeObj, string resultsDir);

        // C++:  double cv::saliency::ObjectnessBING::getBase()
        [DllImport(LIBNAME)]
        private static extern double saliency_ObjectnessBING_getBase_10(IntPtr nativeObj);

        // C++:  void cv::saliency::ObjectnessBING::setBase(double val)
        [DllImport(LIBNAME)]
        private static extern void saliency_ObjectnessBING_setBase_10(IntPtr nativeObj, double val);

        // C++:  int cv::saliency::ObjectnessBING::getNSS()
        [DllImport(LIBNAME)]
        private static extern int saliency_ObjectnessBING_getNSS_10(IntPtr nativeObj);

        // C++:  void cv::saliency::ObjectnessBING::setNSS(int val)
        [DllImport(LIBNAME)]
        private static extern void saliency_ObjectnessBING_setNSS_10(IntPtr nativeObj, int val);

        // C++:  int cv::saliency::ObjectnessBING::getW()
        [DllImport(LIBNAME)]
        private static extern int saliency_ObjectnessBING_getW_10(IntPtr nativeObj);

        // C++:  void cv::saliency::ObjectnessBING::setW(int val)
        [DllImport(LIBNAME)]
        private static extern void saliency_ObjectnessBING_setW_10(IntPtr nativeObj, int val);

        // native support for java finalize() or cleaner
        [DllImport(LIBNAME)]
        private static extern void saliency_ObjectnessBING_delete(IntPtr nativeObj);

    }
}
