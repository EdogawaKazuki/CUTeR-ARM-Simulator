#include "pch-cpp.hpp"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include <limits>



// UnityEngine.RenderTexture
struct RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27;
// System.String
struct String_t;
// System.Void
struct Void_t4861ACF8F4594C3437BB48B6E56783494B843915;



IL2CPP_EXTERN_C_BEGIN
IL2CPP_EXTERN_C_END

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// <Module>
struct U3CModuleU3E_tE8CCFA91781BB9C429F0997CDE2C44CCD8FBF84E 
{
};

// UnityEngine.ScreenCapture
struct ScreenCapture_t513DA8E74951FF61C8421D7046F6FC69A4153092  : public RuntimeObject
{
};

// System.String
struct String_t  : public RuntimeObject
{
	// System.Int32 System.String::_stringLength
	int32_t ____stringLength_4;
	// System.Char System.String::_firstChar
	Il2CppChar ____firstChar_5;
};

// System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F  : public RuntimeObject
{
};
// Native definition for P/Invoke marshalling of System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F_marshaled_com
{
};

// System.Int32
struct Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C 
{
	// System.Int32 System.Int32::m_value
	int32_t ___m_value_0;
};

// System.IntPtr
struct IntPtr_t 
{
	// System.Void* System.IntPtr::m_value
	void* ___m_value_0;
};

// System.Void
struct Void_t4861ACF8F4594C3437BB48B6E56783494B843915 
{
	union
	{
		struct
		{
		};
		uint8_t Void_t4861ACF8F4594C3437BB48B6E56783494B843915__padding[1];
	};
};

// UnityEngine.Object
struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C  : public RuntimeObject
{
	// System.IntPtr UnityEngine.Object::m_CachedPtr
	intptr_t ___m_CachedPtr_0;
};
// Native definition for P/Invoke marshalling of UnityEngine.Object
struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_marshaled_pinvoke
{
	intptr_t ___m_CachedPtr_0;
};
// Native definition for COM marshalling of UnityEngine.Object
struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_marshaled_com
{
	intptr_t ___m_CachedPtr_0;
};

// UnityEngine.Texture
struct Texture_t791CBB51219779964E0E8A2ED7C1AA5F92A4A700  : public Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C
{
};

// UnityEngine.RenderTexture
struct RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27  : public Texture_t791CBB51219779964E0E8A2ED7C1AA5F92A4A700
{
};

// <Module>

// <Module>

// UnityEngine.ScreenCapture

// UnityEngine.ScreenCapture

// System.String
struct String_t_StaticFields
{
	// System.String System.String::Empty
	String_t* ___Empty_6;
};

// System.String

// System.Int32

// System.Int32

// System.Void

// System.Void

// UnityEngine.RenderTexture

// UnityEngine.RenderTexture
#ifdef __clang__
#pragma clang diagnostic pop
#endif



// System.Void UnityEngine.ScreenCapture::CaptureScreenshot(System.String,System.Int32,UnityEngine.ScreenCapture/StereoScreenCaptureMode)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ScreenCapture_CaptureScreenshot_m35F14D593665968FE8F449104B66CE35EB22344D (String_t* ___0_filename, int32_t ___1_superSize, int32_t ___2_CaptureMode, const RuntimeMethod* method) ;
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.ScreenCapture::CaptureScreenshot(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ScreenCapture_CaptureScreenshot_m897B0264A202824D377CCD9A5221B164DE2CF9DE (String_t* ___0_filename, const RuntimeMethod* method) 
{
	{
		String_t* L_0 = ___0_filename;
		ScreenCapture_CaptureScreenshot_m35F14D593665968FE8F449104B66CE35EB22344D(L_0, 1, 1, NULL);
		return;
	}
}
// System.Void UnityEngine.ScreenCapture::CaptureScreenshotIntoRenderTexture(UnityEngine.RenderTexture)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ScreenCapture_CaptureScreenshotIntoRenderTexture_mFE70248151B56BF17669F15445392422AF3709FE (RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27* ___0_renderTexture, const RuntimeMethod* method) 
{
	typedef void (*ScreenCapture_CaptureScreenshotIntoRenderTexture_mFE70248151B56BF17669F15445392422AF3709FE_ftn) (RenderTexture_tBA90C4C3AD9EECCFDDCC632D97C29FAB80D60D27*);
	static ScreenCapture_CaptureScreenshotIntoRenderTexture_mFE70248151B56BF17669F15445392422AF3709FE_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (ScreenCapture_CaptureScreenshotIntoRenderTexture_mFE70248151B56BF17669F15445392422AF3709FE_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.ScreenCapture::CaptureScreenshotIntoRenderTexture(UnityEngine.RenderTexture)");
	_il2cpp_icall_func(___0_renderTexture);
}
// System.Void UnityEngine.ScreenCapture::CaptureScreenshot(System.String,System.Int32,UnityEngine.ScreenCapture/StereoScreenCaptureMode)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ScreenCapture_CaptureScreenshot_m35F14D593665968FE8F449104B66CE35EB22344D (String_t* ___0_filename, int32_t ___1_superSize, int32_t ___2_CaptureMode, const RuntimeMethod* method) 
{
	typedef void (*ScreenCapture_CaptureScreenshot_m35F14D593665968FE8F449104B66CE35EB22344D_ftn) (String_t*, int32_t, int32_t);
	static ScreenCapture_CaptureScreenshot_m35F14D593665968FE8F449104B66CE35EB22344D_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (ScreenCapture_CaptureScreenshot_m35F14D593665968FE8F449104B66CE35EB22344D_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.ScreenCapture::CaptureScreenshot(System.String,System.Int32,UnityEngine.ScreenCapture/StereoScreenCaptureMode)");
	_il2cpp_icall_func(___0_filename, ___1_superSize, ___2_CaptureMode);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
