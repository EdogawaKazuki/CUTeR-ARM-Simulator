using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using UnityEngine;

namespace OpenCVForUnity.CoreModule
{

    public class CleanableMat : DisposableOpenCVObject
    {

        /// <summary>
        /// Deallocates the matrix data and releases resources.
        /// </summary>
        /// <remarks>
        /// This method decrements the reference counter associated with the matrix data. If the reference
        /// counter reaches zero, the matrix data is deallocated, and the data and reference counter pointers
        /// are set to null. It is generally not necessary to call this method manually, as it is automatically
        /// invoked in the destructor or by any other method that changes the data pointer. The reference
        /// counter decrement and check for zero is an atomic operation on supported platforms, ensuring
        /// thread safety when operating on the same matrices asynchronously.
        /// </remarks>
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
                        core_CleanableMat_n_1delete(nativeObj);
                    nativeObj = IntPtr.Zero;
                }

            }
            finally
            {
                base.Dispose(disposing);
            }

        }

        protected CleanableMat(IntPtr obj)
        {

            nativeObj = obj;

        }

#if (UNITY_IOS || UNITY_VISIONOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif

        // native support for java finalize()
        [DllImport(LIBNAME)]
        private static extern void core_CleanableMat_n_1delete(IntPtr nativeObj);

    }
}
