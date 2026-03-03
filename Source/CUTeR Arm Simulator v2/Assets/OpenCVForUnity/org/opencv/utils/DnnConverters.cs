#if !UNITY_WSA_10_0

using System;
using System.Collections.Generic;
using OpenCVForUnity.CoreModule;

namespace OpenCVForUnity.UtilsModule
{
    public partial class Converters
    {

        public static Mat vector_MatShape_to_Mat(List<MatOfInt> matshapes)
        {

            Mat res;
            int count = (matshapes != null) ? matshapes.Count : 0;
            if (count > 0)
            {
                res = new Mat(count, 1, CvType.CV_32SC2);
                Converters.List_Mat_to_Mat<MatOfInt>(matshapes, res, count);
            }
            else
            {
                res = new Mat();
            }
            return res;
        }


        //// vector_MatShape
        //public static Mat vector_MatShape_to_Mat(List<MatOfInt> matOfInts)
        //{
        //    Mat res;
        //    int count = (matOfInts != null) ? matOfInts.size() : 0;
        //    if (count > 0)
        //    {
        //        res = new Mat(count, 1, CvType.CV_32SC2);
        //        int[] buff = new int[count * 2];
        //        for (int i = 0; i < count; i++)
        //        {
        //            long addr = matOfInts.get(i).nativeObj;
        //            buff[i * 2] = (int)(addr >> 32);
        //            buff[i * 2 + 1] = (int)(addr & 0xffffffff);
        //        }
        //        res.put(0, 0, buff);
        //    }
        //    else
        //    {
        //        res = new Mat();
        //    }
        //    return res;
        //}

        public static void Mat_to_vector_MatShape(Mat m, List<MatOfInt> matOfInts)
        {
            if (matOfInts == null)
                throw new CvException("matOfInts == null");
            int count = m.rows();
            if (CvType.CV_32SC2 != m.type() || m.cols() != 1)
                throw new CvException(
                        "CvType.CV_32SC2 != m.type() ||  m.cols()!=1\n" + m);

            matOfInts.Clear();
            int[] buff = new int[count * 2];
            m.get(0, 0, buff);
            for (int i = 0; i < count; i++)
            {
                long addr = (((long)buff[i * 2]) << 32) | (((long)buff[i * 2 + 1]) & 0xffffffffL);
                matOfInts.Add(MatOfInt.fromNativeAddr(new IntPtr(addr)));
            }
        }

        // vector_vector_MatShape
        public static Mat vector_vector_MatShape_to_Mat(List<List<MatOfInt>> vecMatOfInts, List<Mat> mats)
        {
            Mat res;
            int lCount = (vecMatOfInts != null) ? vecMatOfInts.Count : 0;
            if (lCount > 0)
            {
                foreach (List<MatOfInt> matList in vecMatOfInts)
                {
                    Mat mat = vector_MatShape_to_Mat(matList);
                    mats.Add(mat);
                }
                res = vector_Mat_to_Mat(mats);
            }
            else
            {
                res = new Mat();
            }
            return res;
        }

        public static void Mat_to_vector_vector_MatShape(Mat m, List<List<MatOfInt>> vecMatOfInts)
        {
            if (vecMatOfInts == null)
                throw new CvException("Output List can't be null");

            if (m == null)
                throw new CvException("Input Mat can't be null");

            vecMatOfInts.Clear();
            List<Mat> mats = new List<Mat>(m.rows());
            Mat_to_vector_Mat(m, mats);
            foreach (Mat mi in mats)
            {
                List<MatOfInt> rowList = new List<MatOfInt>(mi.rows());
                Mat_to_vector_MatShape(mi, rowList);
                vecMatOfInts.Add(rowList);
                mi.release();
            }
            mats.Clear();
        }

        public static void Mat_to_vector_Target(Mat m, List<int> targets)
        {
            if (m != null)
                m.ThrowIfDisposed();

            if (targets == null)
                throw new CvException("targets == null");
            int count = m.rows();
            if (CvType.CV_32SC1 != m.type() || m.cols() != 1)
                throw new CvException(
                    "CvType.CV_32SC1 != m.type() ||  m.cols()!=1\n" + m);

            targets.Clear();
            for (int i = 0; i < count; i++)
            {
                targets.Add(0);
            }
            Converters.Mat_to_List_int(m, targets, count, CvType.CV_32SC1);
        }
    }
}
#endif
