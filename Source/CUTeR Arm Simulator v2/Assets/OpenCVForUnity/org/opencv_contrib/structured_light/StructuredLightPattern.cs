#if !UNITY_WEBGL


using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;

namespace OpenCVForUnity.Structured_lightModule
{

    // C++: class StructuredLightPattern
    /// <summary>
    ///  Abstract base class for generating and decoding structured light patterns.
    /// </summary>
    public class StructuredLightPattern : Algorithm
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
                        structured_1light_StructuredLightPattern_delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected internal StructuredLightPattern(IntPtr addr) : base(addr) { }

        // internal usage only
        public static new StructuredLightPattern __fromPtr__(IntPtr addr) { return new StructuredLightPattern(addr); }

        //
        // C++:  bool cv::structured_light::StructuredLightPattern::generate(vector_Mat& patternImages)
        //

        /// <summary>
        ///  Generates the structured light pattern to project.
        /// </summary>
        /// <param name="patternImages">
        /// The generated pattern: a vector<Mat>, in which each image is a CV_8U Mat at projector's resolution.
        /// </param>
        public bool generate(List<Mat> patternImages)
        {
            ThrowIfDisposed();
            using Mat patternImages_mat = new Mat();
            bool retVal = structured_1light_StructuredLightPattern_generate_10(nativeObj, patternImages_mat.nativeObj);
            Converters.Mat_to_vector_Mat(patternImages_mat, patternImages);
            return retVal;
        }


        //
        // C++:  bool cv::structured_light::StructuredLightPattern::decode(vector_vector_Mat patternImages, Mat& disparityMap, vector_Mat blackImages = vector_Mat(), vector_Mat whiteImages = vector_Mat(), int flags = DECODE_3D_UNDERWORLD)
        //

        /// <summary>
        ///  Decodes the structured light pattern, generating a disparity map
        /// </summary>
        /// <param name="patternImages">
        /// The acquired pattern images to decode (vector&lt;vector<Mat>&gt;), loaded as grayscale and previously rectified.
        /// </param>
        /// <param name="disparityMap">
        /// The decoding result: a CV_64F Mat at image resolution, storing the computed disparity map.
        /// </param>
        /// <param name="blackImages">
        /// The all-black images needed for shadowMasks computation.
        /// </param>
        /// <param name="whiteImages">
        /// The all-white images needed for shadowMasks computation.
        /// </param>
        /// <param name="flags">
        /// Flags setting decoding algorithms. Default: DECODE_3D_UNDERWORLD.
        ///     @note All the images must be at the same resolution.
        /// </param>
        public bool decode(List<List<Mat>> patternImages, Mat disparityMap, List<Mat> blackImages, List<Mat> whiteImages, int flags)
        {
            ThrowIfDisposed();
            if (disparityMap != null) disparityMap.ThrowIfDisposed();
            using Mat patternImages_mat = Converters.vector_vector_Mat_to_Mat(patternImages);
            using Mat blackImages_mat = Converters.vector_Mat_to_Mat(blackImages);
            using Mat whiteImages_mat = Converters.vector_Mat_to_Mat(whiteImages);
            return structured_1light_StructuredLightPattern_decode_10(nativeObj, patternImages_mat.nativeObj, disparityMap.nativeObj, blackImages_mat.nativeObj, whiteImages_mat.nativeObj, flags);


        }

        /// <summary>
        ///  Decodes the structured light pattern, generating a disparity map
        /// </summary>
        /// <param name="patternImages">
        /// The acquired pattern images to decode (vector&lt;vector<Mat>&gt;), loaded as grayscale and previously rectified.
        /// </param>
        /// <param name="disparityMap">
        /// The decoding result: a CV_64F Mat at image resolution, storing the computed disparity map.
        /// </param>
        /// <param name="blackImages">
        /// The all-black images needed for shadowMasks computation.
        /// </param>
        /// <param name="whiteImages">
        /// The all-white images needed for shadowMasks computation.
        /// </param>
        /// <param name="flags">
        /// Flags setting decoding algorithms. Default: DECODE_3D_UNDERWORLD.
        ///     @note All the images must be at the same resolution.
        /// </param>
        public bool decode(List<List<Mat>> patternImages, Mat disparityMap, List<Mat> blackImages, List<Mat> whiteImages)
        {
            ThrowIfDisposed();
            if (disparityMap != null) disparityMap.ThrowIfDisposed();
            using Mat patternImages_mat = Converters.vector_vector_Mat_to_Mat(patternImages);
            using Mat blackImages_mat = Converters.vector_Mat_to_Mat(blackImages);
            using Mat whiteImages_mat = Converters.vector_Mat_to_Mat(whiteImages);
            return structured_1light_StructuredLightPattern_decode_11(nativeObj, patternImages_mat.nativeObj, disparityMap.nativeObj, blackImages_mat.nativeObj, whiteImages_mat.nativeObj);


        }

        /// <summary>
        ///  Decodes the structured light pattern, generating a disparity map
        /// </summary>
        /// <param name="patternImages">
        /// The acquired pattern images to decode (vector&lt;vector<Mat>&gt;), loaded as grayscale and previously rectified.
        /// </param>
        /// <param name="disparityMap">
        /// The decoding result: a CV_64F Mat at image resolution, storing the computed disparity map.
        /// </param>
        /// <param name="blackImages">
        /// The all-black images needed for shadowMasks computation.
        /// </param>
        /// <param name="whiteImages">
        /// The all-white images needed for shadowMasks computation.
        /// </param>
        /// <param name="flags">
        /// Flags setting decoding algorithms. Default: DECODE_3D_UNDERWORLD.
        ///     @note All the images must be at the same resolution.
        /// </param>
        public bool decode(List<List<Mat>> patternImages, Mat disparityMap, List<Mat> blackImages)
        {
            ThrowIfDisposed();
            if (disparityMap != null) disparityMap.ThrowIfDisposed();
            using Mat patternImages_mat = Converters.vector_vector_Mat_to_Mat(patternImages);
            using Mat blackImages_mat = Converters.vector_Mat_to_Mat(blackImages);
            return structured_1light_StructuredLightPattern_decode_12(nativeObj, patternImages_mat.nativeObj, disparityMap.nativeObj, blackImages_mat.nativeObj);


        }

        /// <summary>
        ///  Decodes the structured light pattern, generating a disparity map
        /// </summary>
        /// <param name="patternImages">
        /// The acquired pattern images to decode (vector&lt;vector<Mat>&gt;), loaded as grayscale and previously rectified.
        /// </param>
        /// <param name="disparityMap">
        /// The decoding result: a CV_64F Mat at image resolution, storing the computed disparity map.
        /// </param>
        /// <param name="blackImages">
        /// The all-black images needed for shadowMasks computation.
        /// </param>
        /// <param name="whiteImages">
        /// The all-white images needed for shadowMasks computation.
        /// </param>
        /// <param name="flags">
        /// Flags setting decoding algorithms. Default: DECODE_3D_UNDERWORLD.
        ///     @note All the images must be at the same resolution.
        /// </param>
        public bool decode(List<List<Mat>> patternImages, Mat disparityMap)
        {
            ThrowIfDisposed();
            if (disparityMap != null) disparityMap.ThrowIfDisposed();
            using Mat patternImages_mat = Converters.vector_vector_Mat_to_Mat(patternImages);
            return structured_1light_StructuredLightPattern_decode_13(nativeObj, patternImages_mat.nativeObj, disparityMap.nativeObj);


        }


#if (UNITY_IOS || UNITY_VISIONOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  bool cv::structured_light::StructuredLightPattern::generate(vector_Mat& patternImages)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool structured_1light_StructuredLightPattern_generate_10(IntPtr nativeObj, IntPtr patternImages_mat_nativeObj);

        // C++:  bool cv::structured_light::StructuredLightPattern::decode(vector_vector_Mat patternImages, Mat& disparityMap, vector_Mat blackImages = vector_Mat(), vector_Mat whiteImages = vector_Mat(), int flags = DECODE_3D_UNDERWORLD)
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool structured_1light_StructuredLightPattern_decode_10(IntPtr nativeObj, IntPtr patternImages_mat_nativeObj, IntPtr disparityMap_nativeObj, IntPtr blackImages_mat_nativeObj, IntPtr whiteImages_mat_nativeObj, int flags);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool structured_1light_StructuredLightPattern_decode_11(IntPtr nativeObj, IntPtr patternImages_mat_nativeObj, IntPtr disparityMap_nativeObj, IntPtr blackImages_mat_nativeObj, IntPtr whiteImages_mat_nativeObj);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool structured_1light_StructuredLightPattern_decode_12(IntPtr nativeObj, IntPtr patternImages_mat_nativeObj, IntPtr disparityMap_nativeObj, IntPtr blackImages_mat_nativeObj);
        [DllImport(LIBNAME)]
        [return: MarshalAs(UnmanagedType.U1)]
        private static extern bool structured_1light_StructuredLightPattern_decode_13(IntPtr nativeObj, IntPtr patternImages_mat_nativeObj, IntPtr disparityMap_nativeObj);

        // native support for java finalize() or cleaner
        [DllImport(LIBNAME)]
        private static extern void structured_1light_StructuredLightPattern_delete(IntPtr nativeObj);

    }
}


#endif