
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using OpenCVForUnity.Calib3dModule;
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UnityIntegration;
using OpenCVForUnity.UtilsModule;

namespace OpenCVForUnity.XimgprocModule
{
    public partial class Ximgproc
    {


        //
        // C++:  double cv::ximgproc::computeMSE(Mat GT, Mat src, Rect ROI)
        //

        /// <summary>
        ///  Function for computing mean square error for disparity maps
        /// </summary>
        /// <param name="GT">
        /// ground truth disparity map
        /// </param>
        /// <param name="src">
        /// disparity map to evaluate
        /// </param>
        /// <param name="ROI">
        /// region of interest
        /// </param>
        /// <remarks>
        ///  @result returns mean square error between GT and src
        /// </remarks>
        public static double computeMSE(Mat GT, Mat src, in Vec4i ROI)
        {
            if (GT != null) GT.ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();

            return ximgproc_Ximgproc_computeMSE_10(GT.nativeObj, src.nativeObj, ROI.Item1, ROI.Item2, ROI.Item3, ROI.Item4);


        }


        //
        // C++:  double cv::ximgproc::computeBadPixelPercent(Mat GT, Mat src, Rect ROI, int thresh = 24)
        //

        /// <summary>
        ///  Function for computing the percent of "bad" pixels in the disparity map
        ///  (pixels where error is higher than a specified threshold)
        /// </summary>
        /// <param name="GT">
        /// ground truth disparity map
        /// </param>
        /// <param name="src">
        /// disparity map to evaluate
        /// </param>
        /// <param name="ROI">
        /// region of interest
        /// </param>
        /// <param name="thresh">
        /// threshold used to determine "bad" pixels
        /// </param>
        /// <remarks>
        ///  @result returns mean square error between GT and src
        /// </remarks>
        public static double computeBadPixelPercent(Mat GT, Mat src, in Vec4i ROI, int thresh)
        {
            if (GT != null) GT.ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();

            return ximgproc_Ximgproc_computeBadPixelPercent_10(GT.nativeObj, src.nativeObj, ROI.Item1, ROI.Item2, ROI.Item3, ROI.Item4, thresh);


        }

        /// <summary>
        ///  Function for computing the percent of "bad" pixels in the disparity map
        ///  (pixels where error is higher than a specified threshold)
        /// </summary>
        /// <param name="GT">
        /// ground truth disparity map
        /// </param>
        /// <param name="src">
        /// disparity map to evaluate
        /// </param>
        /// <param name="ROI">
        /// region of interest
        /// </param>
        /// <param name="thresh">
        /// threshold used to determine "bad" pixels
        /// </param>
        /// <remarks>
        ///  @result returns mean square error between GT and src
        /// </remarks>
        public static double computeBadPixelPercent(Mat GT, Mat src, in Vec4i ROI)
        {
            if (GT != null) GT.ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();

            return ximgproc_Ximgproc_computeBadPixelPercent_11(GT.nativeObj, src.nativeObj, ROI.Item1, ROI.Item2, ROI.Item3, ROI.Item4);


        }


        //
        // C++:  Vec4i cv::ximgproc::HoughPoint2Line(Point houghPoint, Mat srcImgInfo, int angleRange = ARO_315_135, int makeSkew = HDO_DESKEW, int rules = RO_IGNORE_BORDERS)
        //

        /// <summary>
        ///    Calculates coordinates of line segment corresponded by point in Hough space.
        /// </summary>
        /// <param name="houghPoint">
        /// Point in Hough space.
        /// </param>
        /// <param name="srcImgInfo">
        /// The source (input) image of Hough transform.
        /// </param>
        /// <param name="angleRange">
        /// The part of Hough space where point is situated, see cv::AngleRangeOption
        /// </param>
        /// <param name="makeSkew">
        /// Specifies to do or not to do image skewing, see cv::HoughDeskewOption
        /// </param>
        /// <param name="rules">
        /// Specifies strictness of line segment calculating, see cv::RulesOption
        /// </param>
        /// <remarks>
        ///  If rules parameter set to RO_STRICT
        ///             then returned line cut along the border of source image.
        /// </remarks>
        /// <remarks>
        ///  If rules parameter set to RO_WEAK then in case of point, which belongs
        ///             the incorrect part of Hough image, returned line will not intersect source image.
        ///   
        ///    The function calculates coordinates of line segment corresponded by point in Hough space.
        /// </remarks>
        public static int[] HoughPoint2Line(in Vec2d houghPoint, Mat srcImgInfo, int angleRange, int makeSkew, int rules)
        {
            if (srcImgInfo != null) srcImgInfo.ThrowIfDisposed();

            int[] retVal = new int[4];
            ximgproc_Ximgproc_HoughPoint2Line_10(houghPoint.Item1, houghPoint.Item2, srcImgInfo.nativeObj, angleRange, makeSkew, rules, retVal);

            return retVal;
        }

        /// <summary>
        ///    Calculates coordinates of line segment corresponded by point in Hough space.
        /// </summary>
        /// <param name="houghPoint">
        /// Point in Hough space.
        /// </param>
        /// <param name="srcImgInfo">
        /// The source (input) image of Hough transform.
        /// </param>
        /// <param name="angleRange">
        /// The part of Hough space where point is situated, see cv::AngleRangeOption
        /// </param>
        /// <param name="makeSkew">
        /// Specifies to do or not to do image skewing, see cv::HoughDeskewOption
        /// </param>
        /// <param name="rules">
        /// Specifies strictness of line segment calculating, see cv::RulesOption
        /// </param>
        /// <remarks>
        ///  If rules parameter set to RO_STRICT
        ///             then returned line cut along the border of source image.
        /// </remarks>
        /// <remarks>
        ///  If rules parameter set to RO_WEAK then in case of point, which belongs
        ///             the incorrect part of Hough image, returned line will not intersect source image.
        ///   
        ///    The function calculates coordinates of line segment corresponded by point in Hough space.
        /// </remarks>
        public static int[] HoughPoint2Line(in Vec2d houghPoint, Mat srcImgInfo, int angleRange, int makeSkew)
        {
            if (srcImgInfo != null) srcImgInfo.ThrowIfDisposed();

            int[] retVal = new int[4];
            ximgproc_Ximgproc_HoughPoint2Line_11(houghPoint.Item1, houghPoint.Item2, srcImgInfo.nativeObj, angleRange, makeSkew, retVal);

            return retVal;
        }

        /// <summary>
        ///    Calculates coordinates of line segment corresponded by point in Hough space.
        /// </summary>
        /// <param name="houghPoint">
        /// Point in Hough space.
        /// </param>
        /// <param name="srcImgInfo">
        /// The source (input) image of Hough transform.
        /// </param>
        /// <param name="angleRange">
        /// The part of Hough space where point is situated, see cv::AngleRangeOption
        /// </param>
        /// <param name="makeSkew">
        /// Specifies to do or not to do image skewing, see cv::HoughDeskewOption
        /// </param>
        /// <param name="rules">
        /// Specifies strictness of line segment calculating, see cv::RulesOption
        /// </param>
        /// <remarks>
        ///  If rules parameter set to RO_STRICT
        ///             then returned line cut along the border of source image.
        /// </remarks>
        /// <remarks>
        ///  If rules parameter set to RO_WEAK then in case of point, which belongs
        ///             the incorrect part of Hough image, returned line will not intersect source image.
        ///   
        ///    The function calculates coordinates of line segment corresponded by point in Hough space.
        /// </remarks>
        public static int[] HoughPoint2Line(in Vec2d houghPoint, Mat srcImgInfo, int angleRange)
        {
            if (srcImgInfo != null) srcImgInfo.ThrowIfDisposed();

            int[] retVal = new int[4];
            ximgproc_Ximgproc_HoughPoint2Line_12(houghPoint.Item1, houghPoint.Item2, srcImgInfo.nativeObj, angleRange, retVal);

            return retVal;
        }

        /// <summary>
        ///    Calculates coordinates of line segment corresponded by point in Hough space.
        /// </summary>
        /// <param name="houghPoint">
        /// Point in Hough space.
        /// </param>
        /// <param name="srcImgInfo">
        /// The source (input) image of Hough transform.
        /// </param>
        /// <param name="angleRange">
        /// The part of Hough space where point is situated, see cv::AngleRangeOption
        /// </param>
        /// <param name="makeSkew">
        /// Specifies to do or not to do image skewing, see cv::HoughDeskewOption
        /// </param>
        /// <param name="rules">
        /// Specifies strictness of line segment calculating, see cv::RulesOption
        /// </param>
        /// <remarks>
        ///  If rules parameter set to RO_STRICT
        ///             then returned line cut along the border of source image.
        /// </remarks>
        /// <remarks>
        ///  If rules parameter set to RO_WEAK then in case of point, which belongs
        ///             the incorrect part of Hough image, returned line will not intersect source image.
        ///   
        ///    The function calculates coordinates of line segment corresponded by point in Hough space.
        /// </remarks>
        public static int[] HoughPoint2Line(in Vec2d houghPoint, Mat srcImgInfo)
        {
            if (srcImgInfo != null) srcImgInfo.ThrowIfDisposed();

            int[] retVal = new int[4];
            ximgproc_Ximgproc_HoughPoint2Line_13(houghPoint.Item1, houghPoint.Item2, srcImgInfo.nativeObj, retVal);

            return retVal;
        }

    }
}
