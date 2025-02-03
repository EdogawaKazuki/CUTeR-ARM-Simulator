#include "pch-cpp.hpp"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include <limits>


template <typename T1, typename T2, typename T3>
struct VirtualActionInvoker3
{
	typedef void (*Action)(void*, T1, T2, T3, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1 p1, T2 p2, T3 p3)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		((Action)invokeData.methodPtr)(obj, p1, p2, p3, invokeData.method);
	}
};
template <typename R>
struct VirtualFuncInvoker0
{
	typedef R (*Func)(void*, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		return ((Func)invokeData.methodPtr)(obj, invokeData.method);
	}
};
template <typename R, typename T1>
struct VirtualFuncInvoker1
{
	typedef R (*Func)(void*, T1, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1 p1)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		return ((Func)invokeData.methodPtr)(obj, p1, invokeData.method);
	}
};
template <typename R, typename T1, typename T2>
struct VirtualFuncInvoker2
{
	typedef R (*Func)(void*, T1, T2, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1 p1, T2 p2)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		return ((Func)invokeData.methodPtr)(obj, p1, p2, invokeData.method);
	}
};

// MathNet.Numerics.LinearAlgebra.Factorization.Cholesky`1<System.Double>
struct Cholesky_1_t1FD2C6EAE804ACF062E3034A45A8D1004519525C;
// System.Func`2<System.Double[],System.Double[]>
struct Func_2_tA1A2AD8DF81B4522B8EE6DE5D7855397EAF54012;
// System.Func`2<System.Double[],System.Double>
struct Func_2_t89B8106282004E94AE869931CD4E1DF667EB235E;
// System.Func`2<System.Double,System.Double>
struct Func_2_t0221E9CE1FF8B8FE59AED052D562790B96F13B3D;
// System.Func`2<System.Object,System.Double>
struct Func_2_t5D850B409400F6FC6B650829D4B758F5899212B1;
// System.Func`2<System.Object,System.Object>
struct Func_2_tACBF5A1656250800CE861707354491F0611F6624;
// System.Func`3<System.Double,System.Int32,System.Double>
struct Func_3_t4A84D23D01C9E182A3CFA36E5B7F3F13F9B82367;
// System.Func`3<System.Int32,System.Int32,System.Double>
struct Func_3_t057050D6922BDFD2DA39811D38124A65D97E389C;
// System.Collections.Generic.IEnumerable`1<System.Double>
struct IEnumerable_1_tAB7E6AAC5334AFEE42DB96DB8C245338F041A2DB;
// System.Collections.Generic.IEnumerable`1<System.Int32>
struct IEnumerable_1_tCE758D940790D6D0D56B457E522C195F8C413AF2;
// System.Collections.Generic.IEnumerator`1<System.Int32>
struct IEnumerator_1_tD6A90A7446DA8E6CF865EDFBBF18C1200BB6D452;
// MathNet.Numerics.LinearAlgebra.MatrixBuilder`1<System.Double>
struct MatrixBuilder_1_tB265D6E40F33E9A311724A5F2EDB8C5F71621C2A;
// MathNet.Numerics.LinearAlgebra.Storage.MatrixStorage`1<System.Double>
struct MatrixStorage_1_t3274677608F0D866A33A7F6CB795B2C43D750C6D;
// MathNet.Numerics.LinearAlgebra.Matrix`1<System.Double>
struct Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9;
// System.Threading.ThreadLocal`1<MathNet.Numerics.Random.SystemRandomSource>
struct ThreadLocal_1_tCDC272FFAAF66E27F8F3AE02CB0896A09D050D12;
// System.Func`2<System.Double[],System.Double>[]
struct Func_2U5BU5D_tAFC1A2A6571948ADB9C2BC67B555510E993FC60A;
// System.Nullable`1<System.Double>[]
struct Nullable_1U5BU5D_t8608EFC3D4A79785F59C7AB124AD5FBE0F75BCF1;
// System.Double[,][]
struct DoubleU5BU2CU5DU5BU5D_tA2205504790CBE64D5959B2C6A51DAFD8916B6BF;
// System.Delegate[]
struct DelegateU5BU5D_tC5AB7E8F745616680F337909D3A8E6C722CDF771;
// System.Double[]
struct DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE;
// System.Int32[]
struct Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C;
// System.IntPtr[]
struct IntPtrU5BU5D_tFD177F8C806A6921AD7150264CCC62FA00CAD832;
// System.Diagnostics.StackTrace[]
struct StackTraceU5BU5D_t32FBCB20930EAF5BAE3F450FF75228E5450DA0DF;
// System.Double[,]
struct DoubleU5BU2CU5D_tA10EAF4C451E6EBC345A8881EBB9EF9441D01AAE;
// System.ArgumentException
struct ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263;
// System.ArgumentNullException
struct ArgumentNullException_t327031E412FAB2351B0022DD5DAD47E67E597129;
// System.ArgumentOutOfRangeException
struct ArgumentOutOfRangeException_tEA2822DAF62B10EEED00E0E3A341D4BAF78CF85F;
// System.AsyncCallback
struct AsyncCallback_t7FEF460CBDCFB9C5FA2EF776984778B9A4145F4C;
// System.DelegateData
struct DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E;
// MathNet.Numerics.LinearAlgebra.Double.DenseMatrix
struct DenseMatrix_tEB7C614EBDC0021BA303ED597DC448A8662D8A9F;
// System.Exception
struct Exception_t;
// MathNet.Numerics.Differentiation.FiniteDifferenceCoefficients
struct FiniteDifferenceCoefficients_t4C297B32541755227C3C396F2EE875CD3C6369DD;
// System.IAsyncResult
struct IAsyncResult_t7B9B5A0ECB35DCEC31B8A8122C37D687369253B5;
// System.Collections.IDictionary
struct IDictionary_t6D03155AF1FA9083817AA5B6AD7DEEACC26AB220;
// System.Collections.IEnumerator
struct IEnumerator_t7B609C2FFA6EB5167D9C62A0C32A21DE2F666DAA;
// System.Reflection.MethodInfo
struct MethodInfo_t;
// System.NotSupportedException
struct NotSupportedException_t1429765983D409BD2986508963C98D214E4EBF4A;
// MathNet.Numerics.Differentiation.NumericalDerivative
struct NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8;
// MathNet.Numerics.Differentiation.NumericalHessian
struct NumericalHessian_tC668F2E392EB9EDB3A980FAA9946531D5078E102;
// MathNet.Numerics.Differentiation.NumericalJacobian
struct NumericalJacobian_tC9F1ECB42F01952106C19C255A6694627F3A2D78;
// System.Random
struct Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8;
// System.Runtime.Serialization.SafeSerializationManager
struct SafeSerializationManager_tCBB85B95DFD1634237140CD892E82D06ECB3F5E6;
// System.String
struct String_t;
// MathNet.Numerics.Random.SystemRandomSource
struct SystemRandomSource_t23E2BA98CFAB3CA24F6FE6DE3B83B132A44178E4;
// System.Threading.Tasks.TaskScheduler
struct TaskScheduler_t3F0550EBEF7C41F74EC8C08FF4BED0D8CE66006E;
// System.Void
struct Void_t4861ACF8F4594C3437BB48B6E56783494B843915;
// MathNet.Numerics.Distributions.Wishart
struct Wishart_tDEFFEE7331AA0DC9A9F45284E8CCA00CB8012135;
// MathNet.Numerics.Distributions.Zipf
struct Zipf_t533A437DA6EFB62CFF2FB4B397A2636242D87023;
// MathNet.Numerics.Differentiation.NumericalDerivative/<>c__DisplayClass28_0
struct U3CU3Ec__DisplayClass28_0_t1E475037E430264975A0956BD27AA2971F0532BC;
// MathNet.Numerics.Differentiation.NumericalDerivative/<>c__DisplayClass30_0
struct U3CU3Ec__DisplayClass30_0_tBBEEC61B57C35572AA699E79175C25C8F2D7AEBC;
// MathNet.Numerics.Differentiation.NumericalDerivative/<>c__DisplayClass33_0
struct U3CU3Ec__DisplayClass33_0_tBD2756287084841A3E1F1D69335FE19E47552364;
// MathNet.Numerics.Differentiation.NumericalDerivative/<>c__DisplayClass34_0
struct U3CU3Ec__DisplayClass34_0_tF6657B44CE0DCD05291B022AFF982CF97DD5204B;
// MathNet.Numerics.Differentiation.NumericalDerivative/<>c__DisplayClass37_0
struct U3CU3Ec__DisplayClass37_0_tB67C49B4F7E09BCA7E1D145A632C77D2A55C3617;
// MathNet.Numerics.Differentiation.NumericalDerivative/<>c__DisplayClass38_0
struct U3CU3Ec__DisplayClass38_0_t09E32000AEB1ECF9C6180CB2696459BB31E78B3D;
// MathNet.Numerics.Distributions.Weibull/<>c__DisplayClass40_0
struct U3CU3Ec__DisplayClass40_0_t363DAF3C516DB2996DD535161BF37F085613F359;
// MathNet.Numerics.Distributions.Weibull/<>c__DisplayClass41_0
struct U3CU3Ec__DisplayClass41_0_t92D7BA4BAEA3144DFB1F8B589E788EABB6682F70;
// MathNet.Numerics.Distributions.Zipf/<SamplesUnchecked>d__40
struct U3CSamplesUncheckedU3Ed__40_t29307BD38C6FF3892A8B3F9FD768493D8F93EE8A;

IL2CPP_EXTERN_C RuntimeClass* ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* ArgumentNullException_t327031E412FAB2351B0022DD5DAD47E67E597129_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* ArgumentOutOfRangeException_tEA2822DAF62B10EEED00E0E3A341D4BAF78CF85F_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* BitConverter_t6E99605185963BC12B3D369E13F2B88997E64A27_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Control_t697AAECEE3ACCC3477BE1CF29E56F7D224BD26DA_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* DenseMatrix_tEB7C614EBDC0021BA303ED597DC448A8662D8A9F_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* DoubleU5BU2CU5DU5BU5D_tA2205504790CBE64D5959B2C6A51DAFD8916B6BF_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* DoubleU5BU2CU5D_tA10EAF4C451E6EBC345A8881EBB9EF9441D01AAE_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Double_tE150EF3D1D43DEE85D533810AB4C742307EEDE5F_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* FiniteDifferenceCoefficients_t4C297B32541755227C3C396F2EE875CD3C6369DD_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Func_2_t0221E9CE1FF8B8FE59AED052D562790B96F13B3D_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Func_2_t89B8106282004E94AE869931CD4E1DF667EB235E_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Func_2_tA1A2AD8DF81B4522B8EE6DE5D7855397EAF54012_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Func_3_t057050D6922BDFD2DA39811D38124A65D97E389C_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Func_3_t4A84D23D01C9E182A3CFA36E5B7F3F13F9B82367_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* NotSupportedException_t1429765983D409BD2986508963C98D214E4EBF4A_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Precision_t995E3F8DD8836E0C854058E41426915A50908C0C_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* SpecialFunctions_tC2E7545045D2156631D348A56D08F8F5D34545DA_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* SystemRandomSource_t23E2BA98CFAB3CA24F6FE6DE3B83B132A44178E4_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* U3CSamplesUncheckedU3Ed__40_t29307BD38C6FF3892A8B3F9FD768493D8F93EE8A_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* U3CU3Ec__DisplayClass28_0_t1E475037E430264975A0956BD27AA2971F0532BC_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* U3CU3Ec__DisplayClass30_0_tBBEEC61B57C35572AA699E79175C25C8F2D7AEBC_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* U3CU3Ec__DisplayClass33_0_tBD2756287084841A3E1F1D69335FE19E47552364_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* U3CU3Ec__DisplayClass34_0_tF6657B44CE0DCD05291B022AFF982CF97DD5204B_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* U3CU3Ec__DisplayClass37_0_tB67C49B4F7E09BCA7E1D145A632C77D2A55C3617_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* U3CU3Ec__DisplayClass38_0_t09E32000AEB1ECF9C6180CB2696459BB31E78B3D_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C String_t* _stringLiteral062DB096C728515E033CF8C48A1C1F0B9A79384B;
IL2CPP_EXTERN_C String_t* _stringLiteral17A7BA088490CA1D9307C4F7F07BDC92703EDF51;
IL2CPP_EXTERN_C String_t* _stringLiteral406C57A0B5DCC522724098AAB80DF0B1E55007A7;
IL2CPP_EXTERN_C String_t* _stringLiteral46F273EF641E07D271D91E0DC24A4392582671F8;
IL2CPP_EXTERN_C String_t* _stringLiteral49E8993E0689CABC731C33ACC59BD666AAE09144;
IL2CPP_EXTERN_C String_t* _stringLiteral69FC133B7461295F45AF4CCC31336B4BCF6DDA7B;
IL2CPP_EXTERN_C String_t* _stringLiteral78E88F68574BA7A377B127398AF38F7FF9F57490;
IL2CPP_EXTERN_C String_t* _stringLiteral7B4009EABB849A075B30CF0C472DBA2C303AF1C8;
IL2CPP_EXTERN_C String_t* _stringLiteralA907D465D395275002F6CB36C016B291C24C7E70;
IL2CPP_EXTERN_C String_t* _stringLiteralC0FD9400016D989556CDADD04CCB9ED9820BF290;
IL2CPP_EXTERN_C String_t* _stringLiteralEB5675C9AF0CC71BA66A836D19B5F2E3A937F632;
IL2CPP_EXTERN_C String_t* _stringLiteralEDB4B72A6850FC1446A2DF40F1A7B1CEB22C5283;
IL2CPP_EXTERN_C String_t* _stringLiteralEFD51132E6C4A6EFF276CD33D7CA92017B42FCDE;
IL2CPP_EXTERN_C String_t* _stringLiteralF26F502B14F503952C33ADFF928357DED0388E8D;
IL2CPP_EXTERN_C String_t* _stringLiteralFB0EE994B16C328F77EAD6F18E926187CFA36D96;
IL2CPP_EXTERN_C const RuntimeMethod* Cholesky_1_get_Factor_m0DAB4879B1C18A503BC02DB1055250A8611C5CA7_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Enumerable_Select_TisDouble_tE150EF3D1D43DEE85D533810AB4C742307EEDE5F_TisDouble_tE150EF3D1D43DEE85D533810AB4C742307EEDE5F_mB588D15462B1F933FD6F77574674E0999EC99B62_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* FiniteDifferenceCoefficients_GetCoefficientsForAllOrders_mF31F126BE46658AA28691BF8A23DE43FD05AAC43_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* FiniteDifferenceCoefficients_GetCoefficients_m0EF0A6A58D90EFBBCD57331D42A23800EC13664E_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* MatrixBuilder_1_Dense_mB6F63A6F6EF5CBA2F7670D858050EE99C7F2C258_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Matrix_1_At_m3510B6B24011AF518E2720B108836BF602246877_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Matrix_1_At_mBA3B6ADE91F6541597F6BA43AD04B13E36998233_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Matrix_1_DimensionsDontMatch_TisArgumentOutOfRangeException_tEA2822DAF62B10EEED00E0E3A341D4BAF78CF85F_m4F81149F91232A646B909C1F429796AE05751321_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Matrix_1_ToArray_m0F3DB5D9135BA3556C288F91992B1B0C390AAF72_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Matrix_1_Transpose_m7A760B1D7F8E54788932F964F865D0398171D74A_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Matrix_1_get_ColumnCount_mA9469577A4E8459338A621B987E653D241A6883B_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Matrix_1_get_Item_m9AC37D09D678515B98CFC7C5A3BBECAC3067D9DE_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Matrix_1_get_RowCount_m9B54DCE02A3829F5EBD4D5D7ACF2615FCBA2A7E2_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Matrix_1_op_Multiply_m39042F5DB6C9BCAC26059652232B314517464584_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Matrix_1_op_Multiply_mA80E4A79BDCADD1707F7C2BBFDDB8F3C9709B790_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Matrix_1_set_Item_mC97D847F561C86DD3856B0FA098D2D0529728B67_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Nullable_1__ctor_mDE3158DD99CA7E1775A8BA276E428AF808AB8FBF_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Nullable_1_get_HasValue_mC082C667C8EB3A6CA80E06BCAEA0BED00C6BC15A_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Nullable_1_get_Value_m260A5CB9269FD3E130F998A589EDAEC2E8F9EAE1_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* NumericalDerivative_EvaluateDerivative_mCDBA97154622BE221740EF0643F7D685D82F1004_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* NumericalDerivative_EvaluateMixedPartialDerivative_mB6986A98BC73CFEBD25C1203BE8DE3F1D22849CE_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* NumericalDerivative__ctor_m94BF5A04E867018682D56B120B89E5B00595739E_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* NumericalDerivative_set_Center_mFA5EE04E3C7CF245411FF33E80928D962383513E_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* U3CSamplesUncheckedU3Ed__40_System_Collections_IEnumerator_Reset_m4F6EB72FA2445139D55885EBFD799CA6BA648989_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* U3CU3Ec__DisplayClass28_0_U3CEvaluateDerivativeU3Eb__0_m1D184DE944EE44A477CF4873E26E76B1EF29B6C1_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* U3CU3Ec__DisplayClass30_0_U3CCreateDerivativeFunctionHandleU3Eb__0_mF7EE56846A2440ED151B2A5DE00E1D1AE75A45B5_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* U3CU3Ec__DisplayClass33_0_U3CCreatePartialDerivativeFunctionHandleU3Eb__0_mB6666A1868E95E3F8BD11E07663371EFDAEF0585_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* U3CU3Ec__DisplayClass34_0_U3CCreatePartialDerivativeFunctionHandleU3Eb__0_m0919F5E6A57BBCD99A41510256B11DEBCC534E29_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* U3CU3Ec__DisplayClass37_0_U3CCreateMixedPartialDerivativeFunctionHandleU3Eb__0_mB16331F68765F8AEBB943CF3237BB509C5C9EE6A_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* U3CU3Ec__DisplayClass38_0_U3CCreateMixedPartialDerivativeFunctionHandleU3Eb__0_mF11172BC451306DB25036D54218C850D1E7F9245_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Wishart_Density_mD3C1ABBCB81C1824843858DD6F7B0CBE93FE7A1B_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Wishart_Sample_mAA9D8443C95062146BDAE4F1821F2AB107EF7917_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Wishart_U3Cget_VarianceU3Eb__20_0_mA19341F95BD2B87A28AF4A3A03A135375EC954B8_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Wishart__ctor_m10B5EB9D2F05C5B74D04729F56E98D74D284A7F8_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Wishart__ctor_mC62CD6283B58C68962566B54C5F3CE7F28FC41E9_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Zipf_CDF_mE9BA11DBA927D111A6D0FDA2322F3CB793EE8D5C_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Zipf_PMFLn_mC73B265DFB49DCEA74F1B9D0F664626AD468C392_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Zipf_PMF_mCBB1E81BE3F41DA62E019DAE5BCEDB71D36B69E2_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Zipf_Sample_m327C5F54D20B06A4EB677774CB9A88BB2853654B_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Zipf_Sample_mDF6BAC2080A0F48978ECF1A1C298B3522ABFE9AC_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Zipf_Samples_m183EF9DB4B5F964C30A8478C1A044A6541CE9DCC_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Zipf_Samples_m87A504F4D561A6BB34FFE88BE860AB5E0E9DDC3A_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Zipf_Samples_mD61E49CCC0A06AF4C01652158AF18E373667718A_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Zipf_Samples_mF67AE443EAEDA235D248884A8720E7C82972971A_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Zipf__ctor_mCDD01AF4F0DD61A3EDE6B26F4AF6A631A39B6949_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Zipf__ctor_mDBCEE0A4D63457EBA98FD967FC0EA2DF649DAAD8_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Zipf_get_Median_mA9DE0CC27922CBFAC321FCCEB915D6221F6E655A_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Zipf_get_Skewness_m46265461B5592E4ECB31426785E81A76C415EABF_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Zipf_get_Variance_m9E7880B7901EEAD19AEDCDBB429ACAB2CB36BA7B_RuntimeMethod_var;
struct Delegate_t_marshaled_com;
struct Delegate_t_marshaled_pinvoke;
struct Exception_t_marshaled_com;
struct Exception_t_marshaled_pinvoke;

struct Func_2U5BU5D_tAFC1A2A6571948ADB9C2BC67B555510E993FC60A;
struct Nullable_1U5BU5D_t8608EFC3D4A79785F59C7AB124AD5FBE0F75BCF1;
struct DoubleU5BU2CU5DU5BU5D_tA2205504790CBE64D5959B2C6A51DAFD8916B6BF;
struct DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE;
struct Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C;
struct DoubleU5BU2CU5D_tA10EAF4C451E6EBC345A8881EBB9EF9441D01AAE;

IL2CPP_EXTERN_C_BEGIN
IL2CPP_EXTERN_C_END

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// MathNet.Numerics.LinearAlgebra.Factorization.Cholesky`1<System.Double>
struct Cholesky_1_t1FD2C6EAE804ACF062E3034A45A8D1004519525C  : public RuntimeObject
{
	// MathNet.Numerics.LinearAlgebra.Matrix`1<T> MathNet.Numerics.LinearAlgebra.Factorization.Cholesky`1::<Factor>k__BackingField
	Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* ___U3CFactorU3Ek__BackingField_0;
};

// MathNet.Numerics.LinearAlgebra.MatrixBuilder`1<System.Double>
struct MatrixBuilder_1_tB265D6E40F33E9A311724A5F2EDB8C5F71621C2A  : public RuntimeObject
{
};

// MathNet.Numerics.LinearAlgebra.Storage.MatrixStorage`1<System.Double>
struct MatrixStorage_1_t3274677608F0D866A33A7F6CB795B2C43D750C6D  : public RuntimeObject
{
	// System.Int32 MathNet.Numerics.LinearAlgebra.Storage.MatrixStorage`1::RowCount
	int32_t ___RowCount_1;
	// System.Int32 MathNet.Numerics.LinearAlgebra.Storage.MatrixStorage`1::ColumnCount
	int32_t ___ColumnCount_2;
};

// MathNet.Numerics.LinearAlgebra.Matrix`1<System.Double>
struct Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9  : public RuntimeObject
{
	// MathNet.Numerics.LinearAlgebra.Storage.MatrixStorage`1<T> MathNet.Numerics.LinearAlgebra.Matrix`1::<Storage>k__BackingField
	MatrixStorage_1_t3274677608F0D866A33A7F6CB795B2C43D750C6D* ___U3CStorageU3Ek__BackingField_3;
	// System.Int32 MathNet.Numerics.LinearAlgebra.Matrix`1::<ColumnCount>k__BackingField
	int32_t ___U3CColumnCountU3Ek__BackingField_4;
	// System.Int32 MathNet.Numerics.LinearAlgebra.Matrix`1::<RowCount>k__BackingField
	int32_t ___U3CRowCountU3Ek__BackingField_5;
};

// MathNet.Numerics.Control
struct Control_t697AAECEE3ACCC3477BE1CF29E56F7D224BD26DA  : public RuntimeObject
{
};

// MathNet.Numerics.Differentiation.FiniteDifferenceCoefficients
struct FiniteDifferenceCoefficients_t4C297B32541755227C3C396F2EE875CD3C6369DD  : public RuntimeObject
{
	// System.Double[,][] MathNet.Numerics.Differentiation.FiniteDifferenceCoefficients::_coefficients
	DoubleU5BU2CU5DU5BU5D_tA2205504790CBE64D5959B2C6A51DAFD8916B6BF* ____coefficients_0;
	// System.Int32 MathNet.Numerics.Differentiation.FiniteDifferenceCoefficients::_points
	int32_t ____points_1;
};

// MathNet.Numerics.Differentiation.NumericalDerivative
struct NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8  : public RuntimeObject
{
	// System.Int32 MathNet.Numerics.Differentiation.NumericalDerivative::_points
	int32_t ____points_0;
	// System.Int32 MathNet.Numerics.Differentiation.NumericalDerivative::_center
	int32_t ____center_1;
	// System.Double MathNet.Numerics.Differentiation.NumericalDerivative::_stepSize
	double ____stepSize_2;
	// System.Double MathNet.Numerics.Differentiation.NumericalDerivative::_epsilon
	double ____epsilon_3;
	// System.Double MathNet.Numerics.Differentiation.NumericalDerivative::_baseStepSize
	double ____baseStepSize_4;
	// MathNet.Numerics.Differentiation.FiniteDifferenceCoefficients MathNet.Numerics.Differentiation.NumericalDerivative::_coefficients
	FiniteDifferenceCoefficients_t4C297B32541755227C3C396F2EE875CD3C6369DD* ____coefficients_5;
	// System.Int32 MathNet.Numerics.Differentiation.NumericalDerivative::<Evaluations>k__BackingField
	int32_t ___U3CEvaluationsU3Ek__BackingField_6;
	// MathNet.Numerics.Differentiation.StepType MathNet.Numerics.Differentiation.NumericalDerivative::<StepType>k__BackingField
	int32_t ___U3CStepTypeU3Ek__BackingField_7;
};

// MathNet.Numerics.Differentiation.NumericalHessian
struct NumericalHessian_tC668F2E392EB9EDB3A980FAA9946531D5078E102  : public RuntimeObject
{
	// MathNet.Numerics.Differentiation.NumericalDerivative MathNet.Numerics.Differentiation.NumericalHessian::_df
	NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* ____df_0;
};

// MathNet.Numerics.Differentiation.NumericalJacobian
struct NumericalJacobian_tC9F1ECB42F01952106C19C255A6694627F3A2D78  : public RuntimeObject
{
	// MathNet.Numerics.Differentiation.NumericalDerivative MathNet.Numerics.Differentiation.NumericalJacobian::_df
	NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* ____df_0;
};

// MathNet.Numerics.Precision
struct Precision_t995E3F8DD8836E0C854058E41426915A50908C0C  : public RuntimeObject
{
};

// System.Random
struct Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8  : public RuntimeObject
{
	// System.Int32 System.Random::_inext
	int32_t ____inext_0;
	// System.Int32 System.Random::_inextp
	int32_t ____inextp_1;
	// System.Int32[] System.Random::_seedArray
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ____seedArray_2;
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

// MathNet.Numerics.Distributions.Wishart
struct Wishart_tDEFFEE7331AA0DC9A9F45284E8CCA00CB8012135  : public RuntimeObject
{
	// System.Random MathNet.Numerics.Distributions.Wishart::_random
	Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8* ____random_0;
	// System.Double MathNet.Numerics.Distributions.Wishart::_degreesOfFreedom
	double ____degreesOfFreedom_1;
	// MathNet.Numerics.LinearAlgebra.Matrix`1<System.Double> MathNet.Numerics.Distributions.Wishart::_scale
	Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* ____scale_2;
	// MathNet.Numerics.LinearAlgebra.Factorization.Cholesky`1<System.Double> MathNet.Numerics.Distributions.Wishart::_chol
	Cholesky_1_t1FD2C6EAE804ACF062E3034A45A8D1004519525C* ____chol_3;
};

// MathNet.Numerics.Distributions.Zipf
struct Zipf_t533A437DA6EFB62CFF2FB4B397A2636242D87023  : public RuntimeObject
{
	// System.Random MathNet.Numerics.Distributions.Zipf::_random
	Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8* ____random_0;
	// System.Double MathNet.Numerics.Distributions.Zipf::_s
	double ____s_1;
	// System.Int32 MathNet.Numerics.Distributions.Zipf::_n
	int32_t ____n_2;
};

// MathNet.Numerics.Differentiation.NumericalDerivative/<>c__DisplayClass28_0
struct U3CU3Ec__DisplayClass28_0_t1E475037E430264975A0956BD27AA2971F0532BC  : public RuntimeObject
{
	// System.Double[] MathNet.Numerics.Differentiation.NumericalDerivative/<>c__DisplayClass28_0::points
	DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* ___points_0;
};

// MathNet.Numerics.Differentiation.NumericalDerivative/<>c__DisplayClass30_0
struct U3CU3Ec__DisplayClass30_0_tBBEEC61B57C35572AA699E79175C25C8F2D7AEBC  : public RuntimeObject
{
	// MathNet.Numerics.Differentiation.NumericalDerivative MathNet.Numerics.Differentiation.NumericalDerivative/<>c__DisplayClass30_0::<>4__this
	NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* ___U3CU3E4__this_0;
	// System.Func`2<System.Double,System.Double> MathNet.Numerics.Differentiation.NumericalDerivative/<>c__DisplayClass30_0::f
	Func_2_t0221E9CE1FF8B8FE59AED052D562790B96F13B3D* ___f_1;
	// System.Int32 MathNet.Numerics.Differentiation.NumericalDerivative/<>c__DisplayClass30_0::order
	int32_t ___order_2;
};

// MathNet.Numerics.Differentiation.NumericalDerivative/<>c__DisplayClass33_0
struct U3CU3Ec__DisplayClass33_0_tBD2756287084841A3E1F1D69335FE19E47552364  : public RuntimeObject
{
	// MathNet.Numerics.Differentiation.NumericalDerivative MathNet.Numerics.Differentiation.NumericalDerivative/<>c__DisplayClass33_0::<>4__this
	NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* ___U3CU3E4__this_0;
	// System.Func`2<System.Double[],System.Double> MathNet.Numerics.Differentiation.NumericalDerivative/<>c__DisplayClass33_0::f
	Func_2_t89B8106282004E94AE869931CD4E1DF667EB235E* ___f_1;
	// System.Int32 MathNet.Numerics.Differentiation.NumericalDerivative/<>c__DisplayClass33_0::parameterIndex
	int32_t ___parameterIndex_2;
	// System.Int32 MathNet.Numerics.Differentiation.NumericalDerivative/<>c__DisplayClass33_0::order
	int32_t ___order_3;
};

// MathNet.Numerics.Differentiation.NumericalDerivative/<>c__DisplayClass34_0
struct U3CU3Ec__DisplayClass34_0_tF6657B44CE0DCD05291B022AFF982CF97DD5204B  : public RuntimeObject
{
	// MathNet.Numerics.Differentiation.NumericalDerivative MathNet.Numerics.Differentiation.NumericalDerivative/<>c__DisplayClass34_0::<>4__this
	NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* ___U3CU3E4__this_0;
	// System.Func`2<System.Double[],System.Double>[] MathNet.Numerics.Differentiation.NumericalDerivative/<>c__DisplayClass34_0::f
	Func_2U5BU5D_tAFC1A2A6571948ADB9C2BC67B555510E993FC60A* ___f_1;
	// System.Int32 MathNet.Numerics.Differentiation.NumericalDerivative/<>c__DisplayClass34_0::parameterIndex
	int32_t ___parameterIndex_2;
	// System.Int32 MathNet.Numerics.Differentiation.NumericalDerivative/<>c__DisplayClass34_0::order
	int32_t ___order_3;
};

// MathNet.Numerics.Differentiation.NumericalDerivative/<>c__DisplayClass37_0
struct U3CU3Ec__DisplayClass37_0_tB67C49B4F7E09BCA7E1D145A632C77D2A55C3617  : public RuntimeObject
{
	// MathNet.Numerics.Differentiation.NumericalDerivative MathNet.Numerics.Differentiation.NumericalDerivative/<>c__DisplayClass37_0::<>4__this
	NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* ___U3CU3E4__this_0;
	// System.Func`2<System.Double[],System.Double> MathNet.Numerics.Differentiation.NumericalDerivative/<>c__DisplayClass37_0::f
	Func_2_t89B8106282004E94AE869931CD4E1DF667EB235E* ___f_1;
	// System.Int32[] MathNet.Numerics.Differentiation.NumericalDerivative/<>c__DisplayClass37_0::parameterIndex
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ___parameterIndex_2;
	// System.Int32 MathNet.Numerics.Differentiation.NumericalDerivative/<>c__DisplayClass37_0::order
	int32_t ___order_3;
};

// MathNet.Numerics.Differentiation.NumericalDerivative/<>c__DisplayClass38_0
struct U3CU3Ec__DisplayClass38_0_t09E32000AEB1ECF9C6180CB2696459BB31E78B3D  : public RuntimeObject
{
	// MathNet.Numerics.Differentiation.NumericalDerivative MathNet.Numerics.Differentiation.NumericalDerivative/<>c__DisplayClass38_0::<>4__this
	NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* ___U3CU3E4__this_0;
	// System.Func`2<System.Double[],System.Double>[] MathNet.Numerics.Differentiation.NumericalDerivative/<>c__DisplayClass38_0::f
	Func_2U5BU5D_tAFC1A2A6571948ADB9C2BC67B555510E993FC60A* ___f_1;
	// System.Int32[] MathNet.Numerics.Differentiation.NumericalDerivative/<>c__DisplayClass38_0::parameterIndex
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ___parameterIndex_2;
	// System.Int32 MathNet.Numerics.Differentiation.NumericalDerivative/<>c__DisplayClass38_0::order
	int32_t ___order_3;
};

// MathNet.Numerics.Distributions.Weibull/<>c__DisplayClass40_0
struct U3CU3Ec__DisplayClass40_0_t363DAF3C516DB2996DD535161BF37F085613F359  : public RuntimeObject
{
	// System.Double MathNet.Numerics.Distributions.Weibull/<>c__DisplayClass40_0::scale
	double ___scale_0;
	// System.Double MathNet.Numerics.Distributions.Weibull/<>c__DisplayClass40_0::exponent
	double ___exponent_1;
};

// MathNet.Numerics.Distributions.Weibull/<>c__DisplayClass41_0
struct U3CU3Ec__DisplayClass41_0_t92D7BA4BAEA3144DFB1F8B589E788EABB6682F70  : public RuntimeObject
{
	// System.Double[] MathNet.Numerics.Distributions.Weibull/<>c__DisplayClass41_0::values
	DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* ___values_0;
	// System.Double MathNet.Numerics.Distributions.Weibull/<>c__DisplayClass41_0::scale
	double ___scale_1;
	// System.Double MathNet.Numerics.Distributions.Weibull/<>c__DisplayClass41_0::exponent
	double ___exponent_2;
};

// MathNet.Numerics.Distributions.Zipf/<SamplesUnchecked>d__40
struct U3CSamplesUncheckedU3Ed__40_t29307BD38C6FF3892A8B3F9FD768493D8F93EE8A  : public RuntimeObject
{
	// System.Int32 MathNet.Numerics.Distributions.Zipf/<SamplesUnchecked>d__40::<>1__state
	int32_t ___U3CU3E1__state_0;
	// System.Int32 MathNet.Numerics.Distributions.Zipf/<SamplesUnchecked>d__40::<>2__current
	int32_t ___U3CU3E2__current_1;
	// System.Int32 MathNet.Numerics.Distributions.Zipf/<SamplesUnchecked>d__40::<>l__initialThreadId
	int32_t ___U3CU3El__initialThreadId_2;
	// System.Random MathNet.Numerics.Distributions.Zipf/<SamplesUnchecked>d__40::rnd
	Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8* ___rnd_3;
	// System.Random MathNet.Numerics.Distributions.Zipf/<SamplesUnchecked>d__40::<>3__rnd
	Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8* ___U3CU3E3__rnd_4;
	// System.Double MathNet.Numerics.Distributions.Zipf/<SamplesUnchecked>d__40::s
	double ___s_5;
	// System.Double MathNet.Numerics.Distributions.Zipf/<SamplesUnchecked>d__40::<>3__s
	double ___U3CU3E3__s_6;
	// System.Int32 MathNet.Numerics.Distributions.Zipf/<SamplesUnchecked>d__40::n
	int32_t ___n_7;
	// System.Int32 MathNet.Numerics.Distributions.Zipf/<SamplesUnchecked>d__40::<>3__n
	int32_t ___U3CU3E3__n_8;
};

// System.Nullable`1<System.Double>
struct Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165 
{
	// System.Boolean System.Nullable`1::hasValue
	bool ___hasValue_0;
	// T System.Nullable`1::value
	double ___value_1;
};

// System.Boolean
struct Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22 
{
	// System.Boolean System.Boolean::m_value
	bool ___m_value_0;
};

// System.Double
struct Double_tE150EF3D1D43DEE85D533810AB4C742307EEDE5F 
{
	// System.Double System.Double::m_value
	double ___m_value_0;
};

// System.Int32
struct Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C 
{
	// System.Int32 System.Int32::m_value
	int32_t ___m_value_0;
};

// System.Int64
struct Int64_t092CFB123BE63C28ACDAF65C68F21A526050DBA3 
{
	// System.Int64 System.Int64::m_value
	int64_t ___m_value_0;
};

// System.IntPtr
struct IntPtr_t 
{
	// System.Void* System.IntPtr::m_value
	void* ___m_value_0;
};

// MathNet.Numerics.LinearAlgebra.Double.Matrix
struct Matrix_tE07DF40E62C9A5290551E4F6D22910A01E9C7C75  : public Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9
{
};

// MathNet.Numerics.Random.RandomSource
struct RandomSource_tAFDA2EA95D499ACEF522F573F562E4B4B9D02E1E  : public Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8
{
	// System.Boolean MathNet.Numerics.Random.RandomSource::_threadSafe
	bool ____threadSafe_5;
	// System.Object MathNet.Numerics.Random.RandomSource::_lock
	RuntimeObject* ____lock_6;
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

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=1024
struct __StaticArrayInitTypeSizeU3D1024_tB81472E99F63254F5E76D9CD03FF689F7C564A8F 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D1024_tB81472E99F63254F5E76D9CD03FF689F7C564A8F__padding[1024];
	};
};

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=104
struct __StaticArrayInitTypeSizeU3D104_t284A2E4986EFCB891CD6401E344B81163CC907DF 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D104_t284A2E4986EFCB891CD6401E344B81163CC907DF__padding[104];
	};
};

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=112
struct __StaticArrayInitTypeSizeU3D112_t8173B0EA6E3496C3DD8CF5AD2E73F31BD30A4C8C 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D112_t8173B0EA6E3496C3DD8CF5AD2E73F31BD30A4C8C__padding[112];
	};
};

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=120
struct __StaticArrayInitTypeSizeU3D120_tFB94AC1DD2A9025138D4D46D91715CCC3FF11600 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D120_tFB94AC1DD2A9025138D4D46D91715CCC3FF11600__padding[120];
	};
};

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=128
struct __StaticArrayInitTypeSizeU3D128_t640A21A2468D16DFD0B732485754BEFBBAC8A6E2 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D128_t640A21A2468D16DFD0B732485754BEFBBAC8A6E2__padding[128];
	};
};

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=1368
struct __StaticArrayInitTypeSizeU3D1368_t73FCF5E5D9B9CB73A431288C1993B6D583D3E426 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D1368_t73FCF5E5D9B9CB73A431288C1993B6D583D3E426__padding[1368];
	};
};

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=144
struct __StaticArrayInitTypeSizeU3D144_t86FE0B03ABC127132139E03631B2B07EEC44F73A 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D144_t86FE0B03ABC127132139E03631B2B07EEC44F73A__padding[144];
	};
};

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=1440
struct __StaticArrayInitTypeSizeU3D1440_t2C01A9E6DEC579312631CAF83AEB25F0B3139653 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D1440_t2C01A9E6DEC579312631CAF83AEB25F0B3139653__padding[1440];
	};
};

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=168
struct __StaticArrayInitTypeSizeU3D168_t0D4075FD484E508BC0C0DD20948BFF27529E947F 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D168_t0D4075FD484E508BC0C0DD20948BFF27529E947F__padding[168];
	};
};

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=1680
struct __StaticArrayInitTypeSizeU3D1680_tC7B06B9771B36B942CE6558A3056C675C35CFBED 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D1680_tC7B06B9771B36B942CE6558A3056C675C35CFBED__padding[1680];
	};
};

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=176
struct __StaticArrayInitTypeSizeU3D176_t23D8B71A728FE79A15EE202B7A7F0E4A06E7BF8A 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D176_t23D8B71A728FE79A15EE202B7A7F0E4A06E7BF8A__padding[176];
	};
};

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=192
struct __StaticArrayInitTypeSizeU3D192_t6B99BE29A58F1B0459B68D3722331DF5162C06EC 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D192_t6B99BE29A58F1B0459B68D3722331DF5162C06EC__padding[192];
	};
};

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=20
struct __StaticArrayInitTypeSizeU3D20_t41461105D35DDD4C72A7C9A99B74F8DC5E1ED437 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D20_t41461105D35DDD4C72A7C9A99B74F8DC5E1ED437__padding[20];
	};
};

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=200
struct __StaticArrayInitTypeSizeU3D200_tF60DE27DAE580A1B13058B131EC4E513FD321FC1 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D200_tF60DE27DAE580A1B13058B131EC4E513FD321FC1__padding[200];
	};
};

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=2048
struct __StaticArrayInitTypeSizeU3D2048_t0C35A0CA34A63F1FECC92DDD63D81FB736D5FA3C 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D2048_t0C35A0CA34A63F1FECC92DDD63D81FB736D5FA3C__padding[2048];
	};
};

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=208
struct __StaticArrayInitTypeSizeU3D208_tEBAE0937E3F8E1B7729875816D6F26927BA55D1E 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D208_tEBAE0937E3F8E1B7729875816D6F26927BA55D1E__padding[208];
	};
};

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=216
struct __StaticArrayInitTypeSizeU3D216_t3C69B6B65A0C6D9729CAC2C7A1E11FCA26E12755 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D216_t3C69B6B65A0C6D9729CAC2C7A1E11FCA26E12755__padding[216];
	};
};

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=232
struct __StaticArrayInitTypeSizeU3D232_t473109E5478E2A1CDB404DC9F3606C77F65F6E4A 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D232_t473109E5478E2A1CDB404DC9F3606C77F65F6E4A__padding[232];
	};
};

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=24
struct __StaticArrayInitTypeSizeU3D24_t74D1343660A6A5714F919C6B6CF35472ADF34FB4 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D24_t74D1343660A6A5714F919C6B6CF35472ADF34FB4__padding[24];
	};
};

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=240
struct __StaticArrayInitTypeSizeU3D240_t8360335AAF186135DBB6BB491097128F387A6DF0 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D240_t8360335AAF186135DBB6BB491097128F387A6DF0__padding[240];
	};
};

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=248
struct __StaticArrayInitTypeSizeU3D248_t5749AB59ED299BF9D2B242FE08E30F1747DE4BFE 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D248_t5749AB59ED299BF9D2B242FE08E30F1747DE4BFE__padding[248];
	};
};

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=256
struct __StaticArrayInitTypeSizeU3D256_tA106810FA425C1BE0A04C445803CF0DABF77D630 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D256_tA106810FA425C1BE0A04C445803CF0DABF77D630__padding[256];
	};
};

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=32
struct __StaticArrayInitTypeSizeU3D32_tF3BF3F419E08C2B4D21ADCEC29206686A7221E0A 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D32_tF3BF3F419E08C2B4D21ADCEC29206686A7221E0A__padding[32];
	};
};

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=384
struct __StaticArrayInitTypeSizeU3D384_tBC7DC966DDA8FD957F1020909106489F7C2E307D 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D384_tBC7DC966DDA8FD957F1020909106489F7C2E307D__padding[384];
	};
};

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=40
struct __StaticArrayInitTypeSizeU3D40_t9E6A84D485B0C75F1CA0BD2D219146FCDC7ED4BD 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D40_t9E6A84D485B0C75F1CA0BD2D219146FCDC7ED4BD__padding[40];
	};
};

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=400
struct __StaticArrayInitTypeSizeU3D400_tC029CD1424092BEC2D9AB8D9CBC8B22B49DFA552 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D400_tC029CD1424092BEC2D9AB8D9CBC8B22B49DFA552__padding[400];
	};
};

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=4096
struct __StaticArrayInitTypeSizeU3D4096_tBB0AB4FB3110EBB4D8094F6D03DB96D2F260C451 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D4096_tBB0AB4FB3110EBB4D8094F6D03DB96D2F260C451__padding[4096];
	};
};

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=48
struct __StaticArrayInitTypeSizeU3D48_tB425B9168DD04A4EAAF07BD2CC6DFD1CF35CC40D 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D48_tB425B9168DD04A4EAAF07BD2CC6DFD1CF35CC40D__padding[48];
	};
};

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=512
struct __StaticArrayInitTypeSizeU3D512_t32DB5465FA515FDD766C272C418E5B8166B0E816 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D512_t32DB5465FA515FDD766C272C418E5B8166B0E816__padding[512];
	};
};

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=56
struct __StaticArrayInitTypeSizeU3D56_tB88B81AE57B8A712204365F456C8AC69B77BA92F 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D56_tB88B81AE57B8A712204365F456C8AC69B77BA92F__padding[56];
	};
};

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=64
struct __StaticArrayInitTypeSizeU3D64_tD9AF088EC79B314805D0B368C31072882C1EBBB1 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D64_tD9AF088EC79B314805D0B368C31072882C1EBBB1__padding[64];
	};
};

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=72
struct __StaticArrayInitTypeSizeU3D72_t5B6BC9642D006F35493D9E4B930EDA3D9970D264 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D72_t5B6BC9642D006F35493D9E4B930EDA3D9970D264__padding[72];
	};
};

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=768
struct __StaticArrayInitTypeSizeU3D768_t75BAB53216CBA938AD1064C2B94F6591C965AAF9 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D768_t75BAB53216CBA938AD1064C2B94F6591C965AAF9__padding[768];
	};
};

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=80
struct __StaticArrayInitTypeSizeU3D80_tF0F3D4C3B26BCD7AA0C3B46EE73DE0D653DC719A 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D80_tF0F3D4C3B26BCD7AA0C3B46EE73DE0D653DC719A__padding[80];
	};
};

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=800
struct __StaticArrayInitTypeSizeU3D800_tA8959F0E69FA1A67AB3E8ECC41DE2F1B05D21B66 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D800_tA8959F0E69FA1A67AB3E8ECC41DE2F1B05D21B66__padding[800];
	};
};

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=8192
struct __StaticArrayInitTypeSizeU3D8192_t4C5E03EFB21191EC1CA56D46B2E7F8EF2E8B8BA8 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D8192_t4C5E03EFB21191EC1CA56D46B2E7F8EF2E8B8BA8__padding[8192];
	};
};

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=840
struct __StaticArrayInitTypeSizeU3D840_t6B295E185CF97F7FA1BF7A96A845A410A431DB24 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D840_t6B295E185CF97F7FA1BF7A96A845A410A431DB24__padding[840];
	};
};

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=88
struct __StaticArrayInitTypeSizeU3D88_tC9D35D8FE1174F38E7FE4E673C66E0CBE1CD77D7 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D88_tC9D35D8FE1174F38E7FE4E673C66E0CBE1CD77D7__padding[88];
	};
};

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=96
struct __StaticArrayInitTypeSizeU3D96_t7839E5E3863E908B97FAC76DD08A31B57876A4C0 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D96_t7839E5E3863E908B97FAC76DD08A31B57876A4C0__padding[96];
	};
};

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=960
struct __StaticArrayInitTypeSizeU3D960_tB6EA6C8CADBE75AC2FD93DB98C05A386DBF4DF40 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D960_tB6EA6C8CADBE75AC2FD93DB98C05A386DBF4DF40__padding[960];
	};
};

// <PrivateImplementationDetails>
struct U3CPrivateImplementationDetailsU3E_tC43F9FADAC79875838891874AE8E89DC3B99E330  : public RuntimeObject
{
};

// System.Delegate
struct Delegate_t  : public RuntimeObject
{
	// System.IntPtr System.Delegate::method_ptr
	Il2CppMethodPointer ___method_ptr_0;
	// System.IntPtr System.Delegate::invoke_impl
	intptr_t ___invoke_impl_1;
	// System.Object System.Delegate::m_target
	RuntimeObject* ___m_target_2;
	// System.IntPtr System.Delegate::method
	intptr_t ___method_3;
	// System.IntPtr System.Delegate::delegate_trampoline
	intptr_t ___delegate_trampoline_4;
	// System.IntPtr System.Delegate::extra_arg
	intptr_t ___extra_arg_5;
	// System.IntPtr System.Delegate::method_code
	intptr_t ___method_code_6;
	// System.IntPtr System.Delegate::interp_method
	intptr_t ___interp_method_7;
	// System.IntPtr System.Delegate::interp_invoke_impl
	intptr_t ___interp_invoke_impl_8;
	// System.Reflection.MethodInfo System.Delegate::method_info
	MethodInfo_t* ___method_info_9;
	// System.Reflection.MethodInfo System.Delegate::original_method_info
	MethodInfo_t* ___original_method_info_10;
	// System.DelegateData System.Delegate::data
	DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E* ___data_11;
	// System.Boolean System.Delegate::method_is_virtual
	bool ___method_is_virtual_12;
};
// Native definition for P/Invoke marshalling of System.Delegate
struct Delegate_t_marshaled_pinvoke
{
	intptr_t ___method_ptr_0;
	intptr_t ___invoke_impl_1;
	Il2CppIUnknown* ___m_target_2;
	intptr_t ___method_3;
	intptr_t ___delegate_trampoline_4;
	intptr_t ___extra_arg_5;
	intptr_t ___method_code_6;
	intptr_t ___interp_method_7;
	intptr_t ___interp_invoke_impl_8;
	MethodInfo_t* ___method_info_9;
	MethodInfo_t* ___original_method_info_10;
	DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E* ___data_11;
	int32_t ___method_is_virtual_12;
};
// Native definition for COM marshalling of System.Delegate
struct Delegate_t_marshaled_com
{
	intptr_t ___method_ptr_0;
	intptr_t ___invoke_impl_1;
	Il2CppIUnknown* ___m_target_2;
	intptr_t ___method_3;
	intptr_t ___delegate_trampoline_4;
	intptr_t ___extra_arg_5;
	intptr_t ___method_code_6;
	intptr_t ___interp_method_7;
	intptr_t ___interp_invoke_impl_8;
	MethodInfo_t* ___method_info_9;
	MethodInfo_t* ___original_method_info_10;
	DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E* ___data_11;
	int32_t ___method_is_virtual_12;
};

// MathNet.Numerics.LinearAlgebra.Double.DenseMatrix
struct DenseMatrix_tEB7C614EBDC0021BA303ED597DC448A8662D8A9F  : public Matrix_tE07DF40E62C9A5290551E4F6D22910A01E9C7C75
{
	// System.Int32 MathNet.Numerics.LinearAlgebra.Double.DenseMatrix::_rowCount
	int32_t ____rowCount_6;
	// System.Int32 MathNet.Numerics.LinearAlgebra.Double.DenseMatrix::_columnCount
	int32_t ____columnCount_7;
	// System.Double[] MathNet.Numerics.LinearAlgebra.Double.DenseMatrix::_values
	DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* ____values_8;
};

// System.Exception
struct Exception_t  : public RuntimeObject
{
	// System.String System.Exception::_className
	String_t* ____className_1;
	// System.String System.Exception::_message
	String_t* ____message_2;
	// System.Collections.IDictionary System.Exception::_data
	RuntimeObject* ____data_3;
	// System.Exception System.Exception::_innerException
	Exception_t* ____innerException_4;
	// System.String System.Exception::_helpURL
	String_t* ____helpURL_5;
	// System.Object System.Exception::_stackTrace
	RuntimeObject* ____stackTrace_6;
	// System.String System.Exception::_stackTraceString
	String_t* ____stackTraceString_7;
	// System.String System.Exception::_remoteStackTraceString
	String_t* ____remoteStackTraceString_8;
	// System.Int32 System.Exception::_remoteStackIndex
	int32_t ____remoteStackIndex_9;
	// System.Object System.Exception::_dynamicMethods
	RuntimeObject* ____dynamicMethods_10;
	// System.Int32 System.Exception::_HResult
	int32_t ____HResult_11;
	// System.String System.Exception::_source
	String_t* ____source_12;
	// System.Runtime.Serialization.SafeSerializationManager System.Exception::_safeSerializationManager
	SafeSerializationManager_tCBB85B95DFD1634237140CD892E82D06ECB3F5E6* ____safeSerializationManager_13;
	// System.Diagnostics.StackTrace[] System.Exception::captured_traces
	StackTraceU5BU5D_t32FBCB20930EAF5BAE3F450FF75228E5450DA0DF* ___captured_traces_14;
	// System.IntPtr[] System.Exception::native_trace_ips
	IntPtrU5BU5D_tFD177F8C806A6921AD7150264CCC62FA00CAD832* ___native_trace_ips_15;
	// System.Int32 System.Exception::caught_in_unmanaged
	int32_t ___caught_in_unmanaged_16;
};
// Native definition for P/Invoke marshalling of System.Exception
struct Exception_t_marshaled_pinvoke
{
	char* ____className_1;
	char* ____message_2;
	RuntimeObject* ____data_3;
	Exception_t_marshaled_pinvoke* ____innerException_4;
	char* ____helpURL_5;
	Il2CppIUnknown* ____stackTrace_6;
	char* ____stackTraceString_7;
	char* ____remoteStackTraceString_8;
	int32_t ____remoteStackIndex_9;
	Il2CppIUnknown* ____dynamicMethods_10;
	int32_t ____HResult_11;
	char* ____source_12;
	SafeSerializationManager_tCBB85B95DFD1634237140CD892E82D06ECB3F5E6* ____safeSerializationManager_13;
	StackTraceU5BU5D_t32FBCB20930EAF5BAE3F450FF75228E5450DA0DF* ___captured_traces_14;
	Il2CppSafeArray/*NONE*/* ___native_trace_ips_15;
	int32_t ___caught_in_unmanaged_16;
};
// Native definition for COM marshalling of System.Exception
struct Exception_t_marshaled_com
{
	Il2CppChar* ____className_1;
	Il2CppChar* ____message_2;
	RuntimeObject* ____data_3;
	Exception_t_marshaled_com* ____innerException_4;
	Il2CppChar* ____helpURL_5;
	Il2CppIUnknown* ____stackTrace_6;
	Il2CppChar* ____stackTraceString_7;
	Il2CppChar* ____remoteStackTraceString_8;
	int32_t ____remoteStackIndex_9;
	Il2CppIUnknown* ____dynamicMethods_10;
	int32_t ____HResult_11;
	Il2CppChar* ____source_12;
	SafeSerializationManager_tCBB85B95DFD1634237140CD892E82D06ECB3F5E6* ____safeSerializationManager_13;
	StackTraceU5BU5D_t32FBCB20930EAF5BAE3F450FF75228E5450DA0DF* ___captured_traces_14;
	Il2CppSafeArray/*NONE*/* ___native_trace_ips_15;
	int32_t ___caught_in_unmanaged_16;
};

// MathNet.Numerics.Random.SystemRandomSource
struct SystemRandomSource_t23E2BA98CFAB3CA24F6FE6DE3B83B132A44178E4  : public RandomSource_tAFDA2EA95D499ACEF522F573F562E4B4B9D02E1E
{
	// System.Random MathNet.Numerics.Random.SystemRandomSource::_random
	Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8* ____random_7;
};

// System.MulticastDelegate
struct MulticastDelegate_t  : public Delegate_t
{
	// System.Delegate[] System.MulticastDelegate::delegates
	DelegateU5BU5D_tC5AB7E8F745616680F337909D3A8E6C722CDF771* ___delegates_13;
};
// Native definition for P/Invoke marshalling of System.MulticastDelegate
struct MulticastDelegate_t_marshaled_pinvoke : public Delegate_t_marshaled_pinvoke
{
	Delegate_t_marshaled_pinvoke** ___delegates_13;
};
// Native definition for COM marshalling of System.MulticastDelegate
struct MulticastDelegate_t_marshaled_com : public Delegate_t_marshaled_com
{
	Delegate_t_marshaled_com** ___delegates_13;
};

// System.SystemException
struct SystemException_tCC48D868298F4C0705279823E34B00F4FBDB7295  : public Exception_t
{
};

// System.Func`2<System.Double[],System.Double[]>
struct Func_2_tA1A2AD8DF81B4522B8EE6DE5D7855397EAF54012  : public MulticastDelegate_t
{
};

// System.Func`2<System.Double[],System.Double>
struct Func_2_t89B8106282004E94AE869931CD4E1DF667EB235E  : public MulticastDelegate_t
{
};

// System.Func`2<System.Double,System.Double>
struct Func_2_t0221E9CE1FF8B8FE59AED052D562790B96F13B3D  : public MulticastDelegate_t
{
};

// System.Func`2<System.Object,System.Double>
struct Func_2_t5D850B409400F6FC6B650829D4B758F5899212B1  : public MulticastDelegate_t
{
};

// System.Func`3<System.Double,System.Int32,System.Double>
struct Func_3_t4A84D23D01C9E182A3CFA36E5B7F3F13F9B82367  : public MulticastDelegate_t
{
};

// System.Func`3<System.Int32,System.Int32,System.Double>
struct Func_3_t057050D6922BDFD2DA39811D38124A65D97E389C  : public MulticastDelegate_t
{
};

// System.ArgumentException
struct ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263  : public SystemException_tCC48D868298F4C0705279823E34B00F4FBDB7295
{
	// System.String System.ArgumentException::_paramName
	String_t* ____paramName_18;
};

// System.NotSupportedException
struct NotSupportedException_t1429765983D409BD2986508963C98D214E4EBF4A  : public SystemException_tCC48D868298F4C0705279823E34B00F4FBDB7295
{
};

// System.ArgumentNullException
struct ArgumentNullException_t327031E412FAB2351B0022DD5DAD47E67E597129  : public ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263
{
};

// System.ArgumentOutOfRangeException
struct ArgumentOutOfRangeException_tEA2822DAF62B10EEED00E0E3A341D4BAF78CF85F  : public ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263
{
	// System.Object System.ArgumentOutOfRangeException::_actualValue
	RuntimeObject* ____actualValue_19;
};

// MathNet.Numerics.LinearAlgebra.Factorization.Cholesky`1<System.Double>

// MathNet.Numerics.LinearAlgebra.Factorization.Cholesky`1<System.Double>

// MathNet.Numerics.LinearAlgebra.MatrixBuilder`1<System.Double>

// MathNet.Numerics.LinearAlgebra.MatrixBuilder`1<System.Double>

// MathNet.Numerics.LinearAlgebra.Storage.MatrixStorage`1<System.Double>
struct MatrixStorage_1_t3274677608F0D866A33A7F6CB795B2C43D750C6D_StaticFields
{
	// T MathNet.Numerics.LinearAlgebra.Storage.MatrixStorage`1::Zero
	double ___Zero_0;
};

// MathNet.Numerics.LinearAlgebra.Storage.MatrixStorage`1<System.Double>

// MathNet.Numerics.LinearAlgebra.Matrix`1<System.Double>
struct Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9_StaticFields
{
	// T MathNet.Numerics.LinearAlgebra.Matrix`1::One
	double ___One_0;
	// T MathNet.Numerics.LinearAlgebra.Matrix`1::Zero
	double ___Zero_1;
	// MathNet.Numerics.LinearAlgebra.MatrixBuilder`1<T> MathNet.Numerics.LinearAlgebra.Matrix`1::Build
	MatrixBuilder_1_tB265D6E40F33E9A311724A5F2EDB8C5F71621C2A* ___Build_2;
};

// MathNet.Numerics.LinearAlgebra.Matrix`1<System.Double>

// MathNet.Numerics.Control
struct Control_t697AAECEE3ACCC3477BE1CF29E56F7D224BD26DA_StaticFields
{
	// System.Int32 MathNet.Numerics.Control::_maxDegreeOfParallelism
	int32_t ____maxDegreeOfParallelism_0;
	// System.Int32 MathNet.Numerics.Control::_parallelizeOrder
	int32_t ____parallelizeOrder_1;
	// System.Int32 MathNet.Numerics.Control::_parallelizeElements
	int32_t ____parallelizeElements_2;
	// System.String MathNet.Numerics.Control::_nativeProviderHintPath
	String_t* ____nativeProviderHintPath_3;
	// System.Boolean MathNet.Numerics.Control::<CheckDistributionParameters>k__BackingField
	bool ___U3CCheckDistributionParametersU3Ek__BackingField_4;
	// System.Boolean MathNet.Numerics.Control::<ThreadSafeRandomNumberGenerators>k__BackingField
	bool ___U3CThreadSafeRandomNumberGeneratorsU3Ek__BackingField_5;
	// System.Threading.Tasks.TaskScheduler MathNet.Numerics.Control::<TaskScheduler>k__BackingField
	TaskScheduler_t3F0550EBEF7C41F74EC8C08FF4BED0D8CE66006E* ___U3CTaskSchedulerU3Ek__BackingField_6;
};

// MathNet.Numerics.Control

// MathNet.Numerics.Differentiation.FiniteDifferenceCoefficients

// MathNet.Numerics.Differentiation.FiniteDifferenceCoefficients

// MathNet.Numerics.Differentiation.NumericalDerivative

// MathNet.Numerics.Differentiation.NumericalDerivative

// MathNet.Numerics.Differentiation.NumericalHessian

// MathNet.Numerics.Differentiation.NumericalHessian

// MathNet.Numerics.Differentiation.NumericalJacobian

// MathNet.Numerics.Differentiation.NumericalJacobian

// MathNet.Numerics.Precision
struct Precision_t995E3F8DD8836E0C854058E41426915A50908C0C_StaticFields
{
	// System.Double MathNet.Numerics.Precision::DoublePrecision
	double ___DoublePrecision_2;
	// System.Double MathNet.Numerics.Precision::PositiveDoublePrecision
	double ___PositiveDoublePrecision_3;
	// System.Double MathNet.Numerics.Precision::SinglePrecision
	double ___SinglePrecision_4;
	// System.Double MathNet.Numerics.Precision::PositiveSinglePrecision
	double ___PositiveSinglePrecision_5;
	// System.Double MathNet.Numerics.Precision::MachineEpsilon
	double ___MachineEpsilon_6;
	// System.Double MathNet.Numerics.Precision::PositiveMachineEpsilon
	double ___PositiveMachineEpsilon_7;
	// System.Int32 MathNet.Numerics.Precision::DoubleDecimalPlaces
	int32_t ___DoubleDecimalPlaces_8;
	// System.Int32 MathNet.Numerics.Precision::SingleDecimalPlaces
	int32_t ___SingleDecimalPlaces_9;
	// System.Double MathNet.Numerics.Precision::DefaultDoubleAccuracy
	double ___DefaultDoubleAccuracy_10;
	// System.Single MathNet.Numerics.Precision::DefaultSingleAccuracy
	float ___DefaultSingleAccuracy_11;
	// System.Double[] MathNet.Numerics.Precision::NegativePowersOf10
	DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* ___NegativePowersOf10_12;
};

// MathNet.Numerics.Precision

// System.Random
struct Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8_StaticFields
{
	// System.Random System.Random::s_globalRandom
	Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8* ___s_globalRandom_4;
};

// System.Random
struct Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8_ThreadStaticFields
{
	// System.Random System.Random::t_threadRandom
	Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8* ___t_threadRandom_3;
};

// System.String
struct String_t_StaticFields
{
	// System.String System.String::Empty
	String_t* ___Empty_6;
};

// System.String

// MathNet.Numerics.Distributions.Wishart

// MathNet.Numerics.Distributions.Wishart

// MathNet.Numerics.Distributions.Zipf

// MathNet.Numerics.Distributions.Zipf

// MathNet.Numerics.Differentiation.NumericalDerivative/<>c__DisplayClass28_0

// MathNet.Numerics.Differentiation.NumericalDerivative/<>c__DisplayClass28_0

// MathNet.Numerics.Differentiation.NumericalDerivative/<>c__DisplayClass30_0

// MathNet.Numerics.Differentiation.NumericalDerivative/<>c__DisplayClass30_0

// MathNet.Numerics.Differentiation.NumericalDerivative/<>c__DisplayClass33_0

// MathNet.Numerics.Differentiation.NumericalDerivative/<>c__DisplayClass33_0

// MathNet.Numerics.Differentiation.NumericalDerivative/<>c__DisplayClass34_0

// MathNet.Numerics.Differentiation.NumericalDerivative/<>c__DisplayClass34_0

// MathNet.Numerics.Differentiation.NumericalDerivative/<>c__DisplayClass37_0

// MathNet.Numerics.Differentiation.NumericalDerivative/<>c__DisplayClass37_0

// MathNet.Numerics.Differentiation.NumericalDerivative/<>c__DisplayClass38_0

// MathNet.Numerics.Differentiation.NumericalDerivative/<>c__DisplayClass38_0

// MathNet.Numerics.Distributions.Weibull/<>c__DisplayClass40_0

// MathNet.Numerics.Distributions.Weibull/<>c__DisplayClass40_0

// MathNet.Numerics.Distributions.Weibull/<>c__DisplayClass41_0

// MathNet.Numerics.Distributions.Weibull/<>c__DisplayClass41_0

// MathNet.Numerics.Distributions.Zipf/<SamplesUnchecked>d__40

// MathNet.Numerics.Distributions.Zipf/<SamplesUnchecked>d__40

// System.Nullable`1<System.Double>

// System.Nullable`1<System.Double>

// System.Boolean
struct Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22_StaticFields
{
	// System.String System.Boolean::TrueString
	String_t* ___TrueString_5;
	// System.String System.Boolean::FalseString
	String_t* ___FalseString_6;
};

// System.Boolean

// System.Double

// System.Double

// System.Int32

// System.Int32

// System.Int64

// System.Int64

// System.IntPtr
struct IntPtr_t_StaticFields
{
	// System.IntPtr System.IntPtr::Zero
	intptr_t ___Zero_1;
};

// System.IntPtr

// System.Void

// System.Void

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=1024

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=1024

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=104

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=104

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=112

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=112

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=120

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=120

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=128

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=128

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=1368

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=1368

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=144

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=144

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=1440

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=1440

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=168

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=168

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=1680

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=1680

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=176

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=176

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=192

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=192

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=20

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=20

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=200

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=200

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=2048

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=2048

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=208

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=208

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=216

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=216

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=232

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=232

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=24

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=24

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=240

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=240

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=248

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=248

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=256

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=256

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=32

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=32

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=384

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=384

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=40

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=40

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=400

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=400

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=4096

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=4096

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=48

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=48

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=512

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=512

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=56

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=56

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=64

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=64

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=72

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=72

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=768

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=768

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=80

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=80

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=800

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=800

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=8192

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=8192

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=840

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=840

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=88

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=88

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=96

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=96

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=960

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=960

// <PrivateImplementationDetails>
struct U3CPrivateImplementationDetailsU3E_tC43F9FADAC79875838891874AE8E89DC3B99E330_StaticFields
{
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=1368 <PrivateImplementationDetails>::009964B2D52C0B5FBEE27A0F3EBC28E2DF48547C0BE4E1D513630EFC3B24638B
	__StaticArrayInitTypeSizeU3D1368_t73FCF5E5D9B9CB73A431288C1993B6D583D3E426 ___009964B2D52C0B5FBEE27A0F3EBC28E2DF48547C0BE4E1D513630EFC3B24638B_0;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=72 <PrivateImplementationDetails>::0188FA44D55618E18747FE9F06AF9B4C460C5066087A26EAE5A01B6618154062
	__StaticArrayInitTypeSizeU3D72_t5B6BC9642D006F35493D9E4B930EDA3D9970D264 ___0188FA44D55618E18747FE9F06AF9B4C460C5066087A26EAE5A01B6618154062_1;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=80 <PrivateImplementationDetails>::01D1983DDCB327B2F09B53D5C407191778B85788FA02FD8C6C44F0694E82BD93
	__StaticArrayInitTypeSizeU3D80_tF0F3D4C3B26BCD7AA0C3B46EE73DE0D653DC719A ___01D1983DDCB327B2F09B53D5C407191778B85788FA02FD8C6C44F0694E82BD93_2;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=104 <PrivateImplementationDetails>::0259AC517FC268EEED713BDB0ECBFF320A7B993652A87E6FB891A99EBC7C3223
	__StaticArrayInitTypeSizeU3D104_t284A2E4986EFCB891CD6401E344B81163CC907DF ___0259AC517FC268EEED713BDB0ECBFF320A7B993652A87E6FB891A99EBC7C3223_3;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=112 <PrivateImplementationDetails>::03AB4085A0532F852C77FFD9A2AD37E0B3E4CDDDE6B2BDFBC83D1824BF0E0043
	__StaticArrayInitTypeSizeU3D112_t8173B0EA6E3496C3DD8CF5AD2E73F31BD30A4C8C ___03AB4085A0532F852C77FFD9A2AD37E0B3E4CDDDE6B2BDFBC83D1824BF0E0043_4;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=248 <PrivateImplementationDetails>::04B745F519143C4706C8DCE9C9808907834CAAEC26AC6E4CA46B432ED6175E4A
	__StaticArrayInitTypeSizeU3D248_t5749AB59ED299BF9D2B242FE08E30F1747DE4BFE ___04B745F519143C4706C8DCE9C9808907834CAAEC26AC6E4CA46B432ED6175E4A_5;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=800 <PrivateImplementationDetails>::0558292D44FE0D4812D51FD7BC517EC58E1424E856BD1E16852671EB229407E1
	__StaticArrayInitTypeSizeU3D800_tA8959F0E69FA1A67AB3E8ECC41DE2F1B05D21B66 ___0558292D44FE0D4812D51FD7BC517EC58E1424E856BD1E16852671EB229407E1_6;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=384 <PrivateImplementationDetails>::07F9A217BEBBE77808A1FAC9028A887A2682358949CE4550C38FFFF6C90F4019
	__StaticArrayInitTypeSizeU3D384_tBC7DC966DDA8FD957F1020909106489F7C2E307D ___07F9A217BEBBE77808A1FAC9028A887A2682358949CE4550C38FFFF6C90F4019_7;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=128 <PrivateImplementationDetails>::087D62403E78DC49C9277940610005765798849EA9532010ED60C2D57E018E8A
	__StaticArrayInitTypeSizeU3D128_t640A21A2468D16DFD0B732485754BEFBBAC8A6E2 ___087D62403E78DC49C9277940610005765798849EA9532010ED60C2D57E018E8A_8;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=400 <PrivateImplementationDetails>::0A145FDD181D66008E68C7CDF09785F202D930AB51DA597C2DA9CA999E44B6ED
	__StaticArrayInitTypeSizeU3D400_tC029CD1424092BEC2D9AB8D9CBC8B22B49DFA552 ___0A145FDD181D66008E68C7CDF09785F202D930AB51DA597C2DA9CA999E44B6ED_9;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=48 <PrivateImplementationDetails>::0AEB38AB550EB5B292900CECFDA25C22BEE4CC058E1CBF833D22D9713A276F96
	__StaticArrayInitTypeSizeU3D48_tB425B9168DD04A4EAAF07BD2CC6DFD1CF35CC40D ___0AEB38AB550EB5B292900CECFDA25C22BEE4CC058E1CBF833D22D9713A276F96_10;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=72 <PrivateImplementationDetails>::0B123FD7BE4B585B84FA9DB156D8EC6370E10B072FC81E1AF9676B8475D39249
	__StaticArrayInitTypeSizeU3D72_t5B6BC9642D006F35493D9E4B930EDA3D9970D264 ___0B123FD7BE4B585B84FA9DB156D8EC6370E10B072FC81E1AF9676B8475D39249_11;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=64 <PrivateImplementationDetails>::0D26CBA7E2CD4AD480192447AFBDD954BE93B862D2EB4161FC56EEEEB855032C
	__StaticArrayInitTypeSizeU3D64_tD9AF088EC79B314805D0B368C31072882C1EBBB1 ___0D26CBA7E2CD4AD480192447AFBDD954BE93B862D2EB4161FC56EEEEB855032C_12;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=512 <PrivateImplementationDetails>::0D96C33AB99F0230C70F12A18B444B82965D55E9FBF9D635AB5BC6B84C9F71BC
	__StaticArrayInitTypeSizeU3D512_t32DB5465FA515FDD766C272C418E5B8166B0E816 ___0D96C33AB99F0230C70F12A18B444B82965D55E9FBF9D635AB5BC6B84C9F71BC_13;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=64 <PrivateImplementationDetails>::11CFFFE8B1E6EE15C900CEFFD7407617C0CAE5E1D124FD1851434D6F01E88719
	__StaticArrayInitTypeSizeU3D64_tD9AF088EC79B314805D0B368C31072882C1EBBB1 ___11CFFFE8B1E6EE15C900CEFFD7407617C0CAE5E1D124FD1851434D6F01E88719_14;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=48 <PrivateImplementationDetails>::12C31527BBC33BFAB9507F941A1E31172E8A433068C7DEACE59067A4FCE14F40
	__StaticArrayInitTypeSizeU3D48_tB425B9168DD04A4EAAF07BD2CC6DFD1CF35CC40D ___12C31527BBC33BFAB9507F941A1E31172E8A433068C7DEACE59067A4FCE14F40_15;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=64 <PrivateImplementationDetails>::140F3C1B319CF21F177ED7D2D743E82889A5E341617DE57FBAE73E40CE6A789C
	__StaticArrayInitTypeSizeU3D64_tD9AF088EC79B314805D0B368C31072882C1EBBB1 ___140F3C1B319CF21F177ED7D2D743E82889A5E341617DE57FBAE73E40CE6A789C_16;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=48 <PrivateImplementationDetails>::1415A001CBEB350CCEBF7DEE4381D483C15284F1B527CCCFC66D13F582408A22
	__StaticArrayInitTypeSizeU3D48_tB425B9168DD04A4EAAF07BD2CC6DFD1CF35CC40D ___1415A001CBEB350CCEBF7DEE4381D483C15284F1B527CCCFC66D13F582408A22_17;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=64 <PrivateImplementationDetails>::14DE2A62274FC7971E0F4BBF620D66B1A7218E0A4E6E3C6C560FEC252CF52577
	__StaticArrayInitTypeSizeU3D64_tD9AF088EC79B314805D0B368C31072882C1EBBB1 ___14DE2A62274FC7971E0F4BBF620D66B1A7218E0A4E6E3C6C560FEC252CF52577_18;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=56 <PrivateImplementationDetails>::1565B83CBAC79A4352A66E8A6651922F3F6E3FFF7BC21E9AB973DF5DBAAF2D4B
	__StaticArrayInitTypeSizeU3D56_tB88B81AE57B8A712204365F456C8AC69B77BA92F ___1565B83CBAC79A4352A66E8A6651922F3F6E3FFF7BC21E9AB973DF5DBAAF2D4B_19;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=64 <PrivateImplementationDetails>::17BB0066E9E275C05C33976A7476A9A67DDBF573EA1A164223D4811806B742CE
	__StaticArrayInitTypeSizeU3D64_tD9AF088EC79B314805D0B368C31072882C1EBBB1 ___17BB0066E9E275C05C33976A7476A9A67DDBF573EA1A164223D4811806B742CE_20;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=32 <PrivateImplementationDetails>::17BC1CD3D4A84AEFE48B53EC4348C6586B4AAD6BAA2CE78DFF53CB3020B76AFA
	__StaticArrayInitTypeSizeU3D32_tF3BF3F419E08C2B4D21ADCEC29206686A7221E0A ___17BC1CD3D4A84AEFE48B53EC4348C6586B4AAD6BAA2CE78DFF53CB3020B76AFA_21;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=40 <PrivateImplementationDetails>::196AC37A9FB682FCBCCF59DADB763333355889F7A92BCF0C7FD72300988BD132
	__StaticArrayInitTypeSizeU3D40_t9E6A84D485B0C75F1CA0BD2D219146FCDC7ED4BD ___196AC37A9FB682FCBCCF59DADB763333355889F7A92BCF0C7FD72300988BD132_22;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=192 <PrivateImplementationDetails>::1D26859D321979A4F20F3BCAA6F0ABABE8737692CFE86C9F332150E5456E9715
	__StaticArrayInitTypeSizeU3D192_t6B99BE29A58F1B0459B68D3722331DF5162C06EC ___1D26859D321979A4F20F3BCAA6F0ABABE8737692CFE86C9F332150E5456E9715_23;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=88 <PrivateImplementationDetails>::203293C9C8BEA9E03224578A7EE5A207AADB96ACA226044EE4BD2C2981E9E3F4
	__StaticArrayInitTypeSizeU3D88_tC9D35D8FE1174F38E7FE4E673C66E0CBE1CD77D7 ___203293C9C8BEA9E03224578A7EE5A207AADB96ACA226044EE4BD2C2981E9E3F4_24;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=960 <PrivateImplementationDetails>::22B3D0C52A61B2C2A0381485B5BB47FEA05D4AE6F43C58CA5B8922EAB5ADAC55
	__StaticArrayInitTypeSizeU3D960_tB6EA6C8CADBE75AC2FD93DB98C05A386DBF4DF40 ___22B3D0C52A61B2C2A0381485B5BB47FEA05D4AE6F43C58CA5B8922EAB5ADAC55_25;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=88 <PrivateImplementationDetails>::23B2DF70249A4DFC7109E73EAC0221980649A07D18E187CBD17A1279F7547EBB
	__StaticArrayInitTypeSizeU3D88_tC9D35D8FE1174F38E7FE4E673C66E0CBE1CD77D7 ___23B2DF70249A4DFC7109E73EAC0221980649A07D18E187CBD17A1279F7547EBB_26;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=112 <PrivateImplementationDetails>::24D7E4F1355A742B95B89EE1D66C3E2EDC5FBFFEFEFB4EC1FD0E5A3F62E57EBA
	__StaticArrayInitTypeSizeU3D112_t8173B0EA6E3496C3DD8CF5AD2E73F31BD30A4C8C ___24D7E4F1355A742B95B89EE1D66C3E2EDC5FBFFEFEFB4EC1FD0E5A3F62E57EBA_27;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=256 <PrivateImplementationDetails>::253381D9AF9FB228D842F5F15BE56F9A6489CE66D13646175227CDB2307C1A9F
	__StaticArrayInitTypeSizeU3D256_tA106810FA425C1BE0A04C445803CF0DABF77D630 ___253381D9AF9FB228D842F5F15BE56F9A6489CE66D13646175227CDB2307C1A9F_28;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=40 <PrivateImplementationDetails>::261889F8B9566EAE7AF07F60E3BBCED0E425407351EF126B85CD8E0F0E8C6C35
	__StaticArrayInitTypeSizeU3D40_t9E6A84D485B0C75F1CA0BD2D219146FCDC7ED4BD ___261889F8B9566EAE7AF07F60E3BBCED0E425407351EF126B85CD8E0F0E8C6C35_29;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=128 <PrivateImplementationDetails>::26731535FAB5443FE2CDCF29348038826E0EF2AFED1DA54547F7456A5A2A196A
	__StaticArrayInitTypeSizeU3D128_t640A21A2468D16DFD0B732485754BEFBBAC8A6E2 ___26731535FAB5443FE2CDCF29348038826E0EF2AFED1DA54547F7456A5A2A196A_30;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=48 <PrivateImplementationDetails>::270817C82B0745AA79C26468AE4A5AB06DA75782BDBC27F4DAB03006528DB0D6
	__StaticArrayInitTypeSizeU3D48_tB425B9168DD04A4EAAF07BD2CC6DFD1CF35CC40D ___270817C82B0745AA79C26468AE4A5AB06DA75782BDBC27F4DAB03006528DB0D6_31;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=72 <PrivateImplementationDetails>::2852B30A6F6B7DEAFA8A8C509C6BE28F8B167EED570C7095CAA69D9983F5ACDA
	__StaticArrayInitTypeSizeU3D72_t5B6BC9642D006F35493D9E4B930EDA3D9970D264 ___2852B30A6F6B7DEAFA8A8C509C6BE28F8B167EED570C7095CAA69D9983F5ACDA_32;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=48 <PrivateImplementationDetails>::2B16401F8702C2A99684FFB51B1D77D7A982AA92873B5B2B988E44347BC99D79
	__StaticArrayInitTypeSizeU3D48_tB425B9168DD04A4EAAF07BD2CC6DFD1CF35CC40D ___2B16401F8702C2A99684FFB51B1D77D7A982AA92873B5B2B988E44347BC99D79_33;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=128 <PrivateImplementationDetails>::2B498830646A099A537E99F23E75C76CC4F28901B32F5CFD87FF484BEDF67A9F
	__StaticArrayInitTypeSizeU3D128_t640A21A2468D16DFD0B732485754BEFBBAC8A6E2 ___2B498830646A099A537E99F23E75C76CC4F28901B32F5CFD87FF484BEDF67A9F_34;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=64 <PrivateImplementationDetails>::2D6487F5878194D62B422080B8913E44CCA04B015D43D1DF8A1264A8FBCC423B
	__StaticArrayInitTypeSizeU3D64_tD9AF088EC79B314805D0B368C31072882C1EBBB1 ___2D6487F5878194D62B422080B8913E44CCA04B015D43D1DF8A1264A8FBCC423B_35;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=56 <PrivateImplementationDetails>::2DA0A8D7217534E4624D82362FF71A3B32504DC6BBC3DCBFCC3FB09611EA2B6E
	__StaticArrayInitTypeSizeU3D56_tB88B81AE57B8A712204365F456C8AC69B77BA92F ___2DA0A8D7217534E4624D82362FF71A3B32504DC6BBC3DCBFCC3FB09611EA2B6E_36;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=208 <PrivateImplementationDetails>::2F83A5A159437845B2A23CBCFE6814B7917FEC4F956CE4749975DCBAD1C82362
	__StaticArrayInitTypeSizeU3D208_tEBAE0937E3F8E1B7729875816D6F26927BA55D1E ___2F83A5A159437845B2A23CBCFE6814B7917FEC4F956CE4749975DCBAD1C82362_37;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=20 <PrivateImplementationDetails>::30190DBD9F4F360C8381AAEEFE3C343B92C783002041CF09DD0B0BAC6C821E91
	__StaticArrayInitTypeSizeU3D20_t41461105D35DDD4C72A7C9A99B74F8DC5E1ED437 ___30190DBD9F4F360C8381AAEEFE3C343B92C783002041CF09DD0B0BAC6C821E91_38;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=72 <PrivateImplementationDetails>::32149B38B789150E7A21FE886B1F0E0B9692113D29952714E492B5C33B666586
	__StaticArrayInitTypeSizeU3D72_t5B6BC9642D006F35493D9E4B930EDA3D9970D264 ___32149B38B789150E7A21FE886B1F0E0B9692113D29952714E492B5C33B666586_39;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=56 <PrivateImplementationDetails>::32388257ACBD35F2376CCF667EFD1C10BC922E37632944BC2D45F32A4899D08D
	__StaticArrayInitTypeSizeU3D56_tB88B81AE57B8A712204365F456C8AC69B77BA92F ___32388257ACBD35F2376CCF667EFD1C10BC922E37632944BC2D45F32A4899D08D_40;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=56 <PrivateImplementationDetails>::3357FD12A4C6A431BB6C7987324CFE319B85B16C33042A7267C4EF4549D91D90
	__StaticArrayInitTypeSizeU3D56_tB88B81AE57B8A712204365F456C8AC69B77BA92F ___3357FD12A4C6A431BB6C7987324CFE319B85B16C33042A7267C4EF4549D91D90_41;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=56 <PrivateImplementationDetails>::33A70684A1DC35C92ED247AF02C0022C4DE567961B18ACEA2FB8A34EE3DC1811
	__StaticArrayInitTypeSizeU3D56_tB88B81AE57B8A712204365F456C8AC69B77BA92F ___33A70684A1DC35C92ED247AF02C0022C4DE567961B18ACEA2FB8A34EE3DC1811_42;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=64 <PrivateImplementationDetails>::3784412861751747F02F3447841124BD3F7EF1BA5AAD910E74B57AC8BAFB798B
	__StaticArrayInitTypeSizeU3D64_tD9AF088EC79B314805D0B368C31072882C1EBBB1 ___3784412861751747F02F3447841124BD3F7EF1BA5AAD910E74B57AC8BAFB798B_43;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=384 <PrivateImplementationDetails>::379D56BBECE48698F73651EA72C5BA4F2D139399CD2584FDEEC0AD23905F4461
	__StaticArrayInitTypeSizeU3D384_tBC7DC966DDA8FD957F1020909106489F7C2E307D ___379D56BBECE48698F73651EA72C5BA4F2D139399CD2584FDEEC0AD23905F4461_44;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=208 <PrivateImplementationDetails>::38A0E7AEDC087D3C37B1BA429500897B8ADAAD11CE3526B694975FADC72633EB
	__StaticArrayInitTypeSizeU3D208_tEBAE0937E3F8E1B7729875816D6F26927BA55D1E ___38A0E7AEDC087D3C37B1BA429500897B8ADAAD11CE3526B694975FADC72633EB_45;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=1024 <PrivateImplementationDetails>::395FDB22658C06B716A672B3AA9F08BD12D4E17E977CDB0892C45CA55AF20A3A
	__StaticArrayInitTypeSizeU3D1024_tB81472E99F63254F5E76D9CD03FF689F7C564A8F ___395FDB22658C06B716A672B3AA9F08BD12D4E17E977CDB0892C45CA55AF20A3A_46;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=1440 <PrivateImplementationDetails>::3A3867A3A3824E9A483CC809C4FD9D00053D320CE8F8000662D32D4703E6800B
	__StaticArrayInitTypeSizeU3D1440_t2C01A9E6DEC579312631CAF83AEB25F0B3139653 ___3A3867A3A3824E9A483CC809C4FD9D00053D320CE8F8000662D32D4703E6800B_47;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=24 <PrivateImplementationDetails>::3A3FEE132DCA399483C5BC3FC6B91850D35BBB20E960224B2AB55C1306519B4D
	__StaticArrayInitTypeSizeU3D24_t74D1343660A6A5714F919C6B6CF35472ADF34FB4 ___3A3FEE132DCA399483C5BC3FC6B91850D35BBB20E960224B2AB55C1306519B4D_48;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=200 <PrivateImplementationDetails>::3C49E9103A362B559074B43B95BE04ABCD2F1EA98A0A2F13C50192671A8F18DE
	__StaticArrayInitTypeSizeU3D200_tF60DE27DAE580A1B13058B131EC4E513FD321FC1 ___3C49E9103A362B559074B43B95BE04ABCD2F1EA98A0A2F13C50192671A8F18DE_49;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=40 <PrivateImplementationDetails>::3C8EEBA6C23751C54EE58E9992C91585F91028862F0C352DD549C0CDC80328C5
	__StaticArrayInitTypeSizeU3D40_t9E6A84D485B0C75F1CA0BD2D219146FCDC7ED4BD ___3C8EEBA6C23751C54EE58E9992C91585F91028862F0C352DD549C0CDC80328C5_50;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=56 <PrivateImplementationDetails>::3E54DDCA64B6026CEB3062E0D5602582863B849A37DECF2C3FD4F6384570D31E
	__StaticArrayInitTypeSizeU3D56_tB88B81AE57B8A712204365F456C8AC69B77BA92F ___3E54DDCA64B6026CEB3062E0D5602582863B849A37DECF2C3FD4F6384570D31E_51;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=32 <PrivateImplementationDetails>::3EBDDA62458EAC3CC930B42F54B47AA9321EECFDA4731F0603BE42104EE561A3
	__StaticArrayInitTypeSizeU3D32_tF3BF3F419E08C2B4D21ADCEC29206686A7221E0A ___3EBDDA62458EAC3CC930B42F54B47AA9321EECFDA4731F0603BE42104EE561A3_52;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=40 <PrivateImplementationDetails>::4062BEA0005ACA6CAEE73BE1FBA31DD2D7D700A21EBC014696EAE351786842B2
	__StaticArrayInitTypeSizeU3D40_t9E6A84D485B0C75F1CA0BD2D219146FCDC7ED4BD ___4062BEA0005ACA6CAEE73BE1FBA31DD2D7D700A21EBC014696EAE351786842B2_53;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=384 <PrivateImplementationDetails>::4225C6B7905528BD85B15D8753AA3EE6DAA6CBE1FCBA62F26AA1AB5A220FA324
	__StaticArrayInitTypeSizeU3D384_tBC7DC966DDA8FD957F1020909106489F7C2E307D ___4225C6B7905528BD85B15D8753AA3EE6DAA6CBE1FCBA62F26AA1AB5A220FA324_54;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=512 <PrivateImplementationDetails>::42C7E12D053365A763568110CD36DFDE8B0E9524C56EC0C2CE60F03EF305EC41
	__StaticArrayInitTypeSizeU3D512_t32DB5465FA515FDD766C272C418E5B8166B0E816 ___42C7E12D053365A763568110CD36DFDE8B0E9524C56EC0C2CE60F03EF305EC41_55;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=24 <PrivateImplementationDetails>::44115319EC8D00120EF4EDD85DC81B6C22493ACFB82B48325632D27E69948B81
	__StaticArrayInitTypeSizeU3D24_t74D1343660A6A5714F919C6B6CF35472ADF34FB4 ___44115319EC8D00120EF4EDD85DC81B6C22493ACFB82B48325632D27E69948B81_56;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=88 <PrivateImplementationDetails>::4499785A168428308B99B7F2F6BCE6D69CD3E14583455FB41BC84A0CE532AEAD
	__StaticArrayInitTypeSizeU3D88_tC9D35D8FE1174F38E7FE4E673C66E0CBE1CD77D7 ___4499785A168428308B99B7F2F6BCE6D69CD3E14583455FB41BC84A0CE532AEAD_57;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=64 <PrivateImplementationDetails>::462D54BC7B6B70468DB035C5C065713F9FB2E84859B1E0C84ECF5B9F5A2F4C72
	__StaticArrayInitTypeSizeU3D64_tD9AF088EC79B314805D0B368C31072882C1EBBB1 ___462D54BC7B6B70468DB035C5C065713F9FB2E84859B1E0C84ECF5B9F5A2F4C72_58;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=200 <PrivateImplementationDetails>::46D2BDED5559167DC5A784901C598235FABD75066DAEA2056789BE72424ECDB6
	__StaticArrayInitTypeSizeU3D200_tF60DE27DAE580A1B13058B131EC4E513FD321FC1 ___46D2BDED5559167DC5A784901C598235FABD75066DAEA2056789BE72424ECDB6_59;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=88 <PrivateImplementationDetails>::48CE02DDAE62F413D19EA29045FEC496E4BA35199A2FAED0F1B8CDB6F06BBD0B
	__StaticArrayInitTypeSizeU3D88_tC9D35D8FE1174F38E7FE4E673C66E0CBE1CD77D7 ___48CE02DDAE62F413D19EA29045FEC496E4BA35199A2FAED0F1B8CDB6F06BBD0B_60;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=64 <PrivateImplementationDetails>::4AF8268E464EB73720B94B49F585D2C19161EF47115DD10EB7A8A7D1FF23BBC2
	__StaticArrayInitTypeSizeU3D64_tD9AF088EC79B314805D0B368C31072882C1EBBB1 ___4AF8268E464EB73720B94B49F585D2C19161EF47115DD10EB7A8A7D1FF23BBC2_61;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=48 <PrivateImplementationDetails>::4B51A226D2C028BA41611EF945475314566C9E6FE2D086019D2AC8B8F574652A
	__StaticArrayInitTypeSizeU3D48_tB425B9168DD04A4EAAF07BD2CC6DFD1CF35CC40D ___4B51A226D2C028BA41611EF945475314566C9E6FE2D086019D2AC8B8F574652A_62;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=48 <PrivateImplementationDetails>::507E2D733312627A71DA81FE2D7882E8E45502A7722994B45BEC1E14DA18B6BB
	__StaticArrayInitTypeSizeU3D48_tB425B9168DD04A4EAAF07BD2CC6DFD1CF35CC40D ___507E2D733312627A71DA81FE2D7882E8E45502A7722994B45BEC1E14DA18B6BB_63;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=72 <PrivateImplementationDetails>::5207093A87B93D7FCC5BF4F2AFDB8A58CA59751F676DE1C6761FDBD38BA1F672
	__StaticArrayInitTypeSizeU3D72_t5B6BC9642D006F35493D9E4B930EDA3D9970D264 ___5207093A87B93D7FCC5BF4F2AFDB8A58CA59751F676DE1C6761FDBD38BA1F672_64;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=64 <PrivateImplementationDetails>::5839B44F4C6A104424C4FA34697B228CDBC8541CAB269947C89A2D5C531CC94C
	__StaticArrayInitTypeSizeU3D64_tD9AF088EC79B314805D0B368C31072882C1EBBB1 ___5839B44F4C6A104424C4FA34697B228CDBC8541CAB269947C89A2D5C531CC94C_65;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=24 <PrivateImplementationDetails>::591895F55699D487F364F23D84209171F8816EE4E16C5C7390C9D79AC4B7E3BF
	__StaticArrayInitTypeSizeU3D24_t74D1343660A6A5714F919C6B6CF35472ADF34FB4 ___591895F55699D487F364F23D84209171F8816EE4E16C5C7390C9D79AC4B7E3BF_66;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=216 <PrivateImplementationDetails>::5AFD431AAC4BA84C8F23DA40E87DCDAF45A22A12648E4FFCA1B42504300BACB7
	__StaticArrayInitTypeSizeU3D216_t3C69B6B65A0C6D9729CAC2C7A1E11FCA26E12755 ___5AFD431AAC4BA84C8F23DA40E87DCDAF45A22A12648E4FFCA1B42504300BACB7_67;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=48 <PrivateImplementationDetails>::5B1E7CF9B3AAE08100EDD7DB3DD6D0FD00E2592D7CFBB68CF2223C96B5D0DAAC
	__StaticArrayInitTypeSizeU3D48_tB425B9168DD04A4EAAF07BD2CC6DFD1CF35CC40D ___5B1E7CF9B3AAE08100EDD7DB3DD6D0FD00E2592D7CFBB68CF2223C96B5D0DAAC_68;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=24 <PrivateImplementationDetails>::5FA2B11B24BE3824CFE12BCDF4ADB2A57152521C3F0770D299E0FD8D0CFCB204
	__StaticArrayInitTypeSizeU3D24_t74D1343660A6A5714F919C6B6CF35472ADF34FB4 ___5FA2B11B24BE3824CFE12BCDF4ADB2A57152521C3F0770D299E0FD8D0CFCB204_69;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=40 <PrivateImplementationDetails>::61B1020DCFA9F3378913A7D9444458F932AB899B5E95A535C9CAF48E22C30450
	__StaticArrayInitTypeSizeU3D40_t9E6A84D485B0C75F1CA0BD2D219146FCDC7ED4BD ___61B1020DCFA9F3378913A7D9444458F932AB899B5E95A535C9CAF48E22C30450_70;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=32 <PrivateImplementationDetails>::671ED4563FF653595569D7F5E16C191859B3E983E06371931BAC54DB0E68FE99
	__StaticArrayInitTypeSizeU3D32_tF3BF3F419E08C2B4D21ADCEC29206686A7221E0A ___671ED4563FF653595569D7F5E16C191859B3E983E06371931BAC54DB0E68FE99_71;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=56 <PrivateImplementationDetails>::68E106791A0E72E5DD13B9186B480B3D000B9B0D7B37D38E91B65E6A2DE72F4F
	__StaticArrayInitTypeSizeU3D56_tB88B81AE57B8A712204365F456C8AC69B77BA92F ___68E106791A0E72E5DD13B9186B480B3D000B9B0D7B37D38E91B65E6A2DE72F4F_72;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=32 <PrivateImplementationDetails>::695E2B0FACBAEECE713C6BFCDF660BD4DFF48872897E66088F8076B02D31D145
	__StaticArrayInitTypeSizeU3D32_tF3BF3F419E08C2B4D21ADCEC29206686A7221E0A ___695E2B0FACBAEECE713C6BFCDF660BD4DFF48872897E66088F8076B02D31D145_73;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=48 <PrivateImplementationDetails>::6DD804957BBD89A87D861D21FE20E7559D7449C60A34797C8F396E28ED2FB07C
	__StaticArrayInitTypeSizeU3D48_tB425B9168DD04A4EAAF07BD2CC6DFD1CF35CC40D ___6DD804957BBD89A87D861D21FE20E7559D7449C60A34797C8F396E28ED2FB07C_74;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=32 <PrivateImplementationDetails>::6E262259EF0B44EB16D3F2F85C55FF4E57A25AAA1BD77D41B0E83A3E83CF21FB
	__StaticArrayInitTypeSizeU3D32_tF3BF3F419E08C2B4D21ADCEC29206686A7221E0A ___6E262259EF0B44EB16D3F2F85C55FF4E57A25AAA1BD77D41B0E83A3E83CF21FB_75;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=24 <PrivateImplementationDetails>::75CDEDC3871ABA0620DBA825B28B77DA4B42749CE691557B2048CE30153A77A1
	__StaticArrayInitTypeSizeU3D24_t74D1343660A6A5714F919C6B6CF35472ADF34FB4 ___75CDEDC3871ABA0620DBA825B28B77DA4B42749CE691557B2048CE30153A77A1_76;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=32 <PrivateImplementationDetails>::76BD4363957A52B2F92901CB43C6FA8279739CE109E1F62E88EE34B02536F7B5
	__StaticArrayInitTypeSizeU3D32_tF3BF3F419E08C2B4D21ADCEC29206686A7221E0A ___76BD4363957A52B2F92901CB43C6FA8279739CE109E1F62E88EE34B02536F7B5_77;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=144 <PrivateImplementationDetails>::7C4F1B5F3BB2B702BD2880B19C1F61701EC062B61354D10AB3F6F5469946AB1F
	__StaticArrayInitTypeSizeU3D144_t86FE0B03ABC127132139E03631B2B07EEC44F73A ___7C4F1B5F3BB2B702BD2880B19C1F61701EC062B61354D10AB3F6F5469946AB1F_78;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=80 <PrivateImplementationDetails>::7F115120BE8D4256410DFBF5BFC077A0CCA2BAD179B14A3C39B8DE27ADF66A31
	__StaticArrayInitTypeSizeU3D80_tF0F3D4C3B26BCD7AA0C3B46EE73DE0D653DC719A ___7F115120BE8D4256410DFBF5BFC077A0CCA2BAD179B14A3C39B8DE27ADF66A31_79;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=72 <PrivateImplementationDetails>::8099EED7766F7DDD56764652DD2196F44FE2E80E478DAFA95913312B252B5EED
	__StaticArrayInitTypeSizeU3D72_t5B6BC9642D006F35493D9E4B930EDA3D9970D264 ___8099EED7766F7DDD56764652DD2196F44FE2E80E478DAFA95913312B252B5EED_80;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=384 <PrivateImplementationDetails>::80D606FB84A7139A3AAD035E3676F3B447BEED283C1860C9400BBC0F37725F89
	__StaticArrayInitTypeSizeU3D384_tBC7DC966DDA8FD957F1020909106489F7C2E307D ___80D606FB84A7139A3AAD035E3676F3B447BEED283C1860C9400BBC0F37725F89_81;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=40 <PrivateImplementationDetails>::82C3937EF59A24F871984838C846E4201CE52112D88812F2D9042444B000687A
	__StaticArrayInitTypeSizeU3D40_t9E6A84D485B0C75F1CA0BD2D219146FCDC7ED4BD ___82C3937EF59A24F871984838C846E4201CE52112D88812F2D9042444B000687A_82;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=56 <PrivateImplementationDetails>::83A56AE801FB1DCDBF6D8A56529B1088A0E2A68091873CE9BFA5C7E3CE4688C5
	__StaticArrayInitTypeSizeU3D56_tB88B81AE57B8A712204365F456C8AC69B77BA92F ___83A56AE801FB1DCDBF6D8A56529B1088A0E2A68091873CE9BFA5C7E3CE4688C5_83;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=56 <PrivateImplementationDetails>::8468F2AC7837A04299FE43CFD91AE539B94839B49DE0D75C4E23B1D833663B66
	__StaticArrayInitTypeSizeU3D56_tB88B81AE57B8A712204365F456C8AC69B77BA92F ___8468F2AC7837A04299FE43CFD91AE539B94839B49DE0D75C4E23B1D833663B66_84;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=56 <PrivateImplementationDetails>::850AB51F4669FFD6C5F84E0E81ABB091E927CEE08CA29023FD2A0E7F815E97E8
	__StaticArrayInitTypeSizeU3D56_tB88B81AE57B8A712204365F456C8AC69B77BA92F ___850AB51F4669FFD6C5F84E0E81ABB091E927CEE08CA29023FD2A0E7F815E97E8_85;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=32 <PrivateImplementationDetails>::8757685792563AD8EC5685287824E72CE3C15EA3F0E64FB7B4E596D7AF3F425E
	__StaticArrayInitTypeSizeU3D32_tF3BF3F419E08C2B4D21ADCEC29206686A7221E0A ___8757685792563AD8EC5685287824E72CE3C15EA3F0E64FB7B4E596D7AF3F425E_86;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=168 <PrivateImplementationDetails>::87850C294278E8D8D1B3E611230D222EE38011C33036BB74823911AEC17F7018
	__StaticArrayInitTypeSizeU3D168_t0D4075FD484E508BC0C0DD20948BFF27529E947F ___87850C294278E8D8D1B3E611230D222EE38011C33036BB74823911AEC17F7018_87;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=56 <PrivateImplementationDetails>::89E3D8360605B8A59C9DE331989A53F5D0E2F997F1A3EF005DE0B7713D3B9DC1
	__StaticArrayInitTypeSizeU3D56_tB88B81AE57B8A712204365F456C8AC69B77BA92F ___89E3D8360605B8A59C9DE331989A53F5D0E2F997F1A3EF005DE0B7713D3B9DC1_88;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=200 <PrivateImplementationDetails>::8CFB8AE105FB5A3A325D8C2628E148819C56BFBD22E0D55BBB5859158081A51D
	__StaticArrayInitTypeSizeU3D200_tF60DE27DAE580A1B13058B131EC4E513FD321FC1 ___8CFB8AE105FB5A3A325D8C2628E148819C56BFBD22E0D55BBB5859158081A51D_89;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=200 <PrivateImplementationDetails>::8DF3F1F3C84A5C2CB98FD15C75610AA362344142A590195EED9FF2895CF5CFEB
	__StaticArrayInitTypeSizeU3D200_tF60DE27DAE580A1B13058B131EC4E513FD321FC1 ___8DF3F1F3C84A5C2CB98FD15C75610AA362344142A590195EED9FF2895CF5CFEB_90;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=64 <PrivateImplementationDetails>::8E51DC7B86DAB548E8EC9221A34FE46FBFB9E11D317257EFE687E2B26CAF593E
	__StaticArrayInitTypeSizeU3D64_tD9AF088EC79B314805D0B368C31072882C1EBBB1 ___8E51DC7B86DAB548E8EC9221A34FE46FBFB9E11D317257EFE687E2B26CAF593E_91;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=48 <PrivateImplementationDetails>::8E76DE049BD99E7DDC4A4DDC0D0FA120A153E106226D2A64FC9FB54AF7540840
	__StaticArrayInitTypeSizeU3D48_tB425B9168DD04A4EAAF07BD2CC6DFD1CF35CC40D ___8E76DE049BD99E7DDC4A4DDC0D0FA120A153E106226D2A64FC9FB54AF7540840_92;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=40 <PrivateImplementationDetails>::8ED2615639A1966E67770B712BF758EE082937BBBB1A8E7FC866C72E10F3FCE0
	__StaticArrayInitTypeSizeU3D40_t9E6A84D485B0C75F1CA0BD2D219146FCDC7ED4BD ___8ED2615639A1966E67770B712BF758EE082937BBBB1A8E7FC866C72E10F3FCE0_93;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=40 <PrivateImplementationDetails>::9228DD0E51D4AEC691F89AF9C2ED642F784B39EE538F3F8D79D8BCFBD38DC27E
	__StaticArrayInitTypeSizeU3D40_t9E6A84D485B0C75F1CA0BD2D219146FCDC7ED4BD ___9228DD0E51D4AEC691F89AF9C2ED642F784B39EE538F3F8D79D8BCFBD38DC27E_94;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=40 <PrivateImplementationDetails>::92AFB7FBE1CFC8348B7494AF206756A8DD72D44B1805A5033FE993602870CADF
	__StaticArrayInitTypeSizeU3D40_t9E6A84D485B0C75F1CA0BD2D219146FCDC7ED4BD ___92AFB7FBE1CFC8348B7494AF206756A8DD72D44B1805A5033FE993602870CADF_95;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=64 <PrivateImplementationDetails>::9315F266E8FE02D0F54362D61A0CF3B214AE391C8C277439A895C9B673F5396A
	__StaticArrayInitTypeSizeU3D64_tD9AF088EC79B314805D0B368C31072882C1EBBB1 ___9315F266E8FE02D0F54362D61A0CF3B214AE391C8C277439A895C9B673F5396A_96;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=80 <PrivateImplementationDetails>::9366456D54E8C4E1294E779497B86F248661FC810B86E0270A1DE3D3AE190742
	__StaticArrayInitTypeSizeU3D80_tF0F3D4C3B26BCD7AA0C3B46EE73DE0D653DC719A ___9366456D54E8C4E1294E779497B86F248661FC810B86E0270A1DE3D3AE190742_97;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=56 <PrivateImplementationDetails>::9501A4E7E303ABC27D8868795360C2502922C65E0925C6788873F9CF2ED4DF4F
	__StaticArrayInitTypeSizeU3D56_tB88B81AE57B8A712204365F456C8AC69B77BA92F ___9501A4E7E303ABC27D8868795360C2502922C65E0925C6788873F9CF2ED4DF4F_98;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=32 <PrivateImplementationDetails>::957613C9D039DA77CA46681BD66FEB35570AE2CD84F5CAD7A9117CF310FE5AD1
	__StaticArrayInitTypeSizeU3D32_tF3BF3F419E08C2B4D21ADCEC29206686A7221E0A ___957613C9D039DA77CA46681BD66FEB35570AE2CD84F5CAD7A9117CF310FE5AD1_99;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=176 <PrivateImplementationDetails>::987FDB7A7BE3BBF4A3C6259F4D42388BAD19F160FE619C51D6E314173115D0E2
	__StaticArrayInitTypeSizeU3D176_t23D8B71A728FE79A15EE202B7A7F0E4A06E7BF8A ___987FDB7A7BE3BBF4A3C6259F4D42388BAD19F160FE619C51D6E314173115D0E2_100;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=32 <PrivateImplementationDetails>::9A07D53D9BD67A774F2BAD53952842D688B49B379A024A3E810CD761C187A486
	__StaticArrayInitTypeSizeU3D32_tF3BF3F419E08C2B4D21ADCEC29206686A7221E0A ___9A07D53D9BD67A774F2BAD53952842D688B49B379A024A3E810CD761C187A486_101;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=2048 <PrivateImplementationDetails>::9C134BFC6DCD4E872E869387CCCCCDA7C7DD94C2BD5A684905E5D6FF15846A2F
	__StaticArrayInitTypeSizeU3D2048_t0C35A0CA34A63F1FECC92DDD63D81FB736D5FA3C ___9C134BFC6DCD4E872E869387CCCCCDA7C7DD94C2BD5A684905E5D6FF15846A2F_102;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=40 <PrivateImplementationDetails>::9D08CFB96C79C2CF5520C1520C62ADE7F253E058A50E306EB21F94D04269B1AF
	__StaticArrayInitTypeSizeU3D40_t9E6A84D485B0C75F1CA0BD2D219146FCDC7ED4BD ___9D08CFB96C79C2CF5520C1520C62ADE7F253E058A50E306EB21F94D04269B1AF_103;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=4096 <PrivateImplementationDetails>::A706A93F9E025C99149A396C401F2E6EF4B6F0FE5CCE18055946B8748101646A
	__StaticArrayInitTypeSizeU3D4096_tBB0AB4FB3110EBB4D8094F6D03DB96D2F260C451 ___A706A93F9E025C99149A396C401F2E6EF4B6F0FE5CCE18055946B8748101646A_104;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=768 <PrivateImplementationDetails>::A793ACB303B48C2938ADFB5CE2A89258308325CC928E66898B30A553AE88E453
	__StaticArrayInitTypeSizeU3D768_t75BAB53216CBA938AD1064C2B94F6591C965AAF9 ___A793ACB303B48C2938ADFB5CE2A89258308325CC928E66898B30A553AE88E453_105;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=72 <PrivateImplementationDetails>::AAB291A2D438C9B98C13E49B20ED77278910FB11CC9E75F6907161A1F9DB69AF
	__StaticArrayInitTypeSizeU3D72_t5B6BC9642D006F35493D9E4B930EDA3D9970D264 ___AAB291A2D438C9B98C13E49B20ED77278910FB11CC9E75F6907161A1F9DB69AF_106;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=72 <PrivateImplementationDetails>::AEEB8BC7D997698CE14359373F3B21D0E9046D8F3EF32298BA3F7005EC85D4B3
	__StaticArrayInitTypeSizeU3D72_t5B6BC9642D006F35493D9E4B930EDA3D9970D264 ___AEEB8BC7D997698CE14359373F3B21D0E9046D8F3EF32298BA3F7005EC85D4B3_107;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=56 <PrivateImplementationDetails>::AF4581BBC826CEE29683BB692227B630537B63C2DCD9CC1D4DB460CAFC30F338
	__StaticArrayInitTypeSizeU3D56_tB88B81AE57B8A712204365F456C8AC69B77BA92F ___AF4581BBC826CEE29683BB692227B630537B63C2DCD9CC1D4DB460CAFC30F338_108;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=208 <PrivateImplementationDetails>::B3BDC60B67455F6F48B3D8CB8689236DAB53AD89C194E1AA30304AEE03EA5691
	__StaticArrayInitTypeSizeU3D208_tEBAE0937E3F8E1B7729875816D6F26927BA55D1E ___B3BDC60B67455F6F48B3D8CB8689236DAB53AD89C194E1AA30304AEE03EA5691_109;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=400 <PrivateImplementationDetails>::B756DCEB1F8E53A9A479390FCF844C6B63AAC62C5A2200559B487B1EE11AFFB0
	__StaticArrayInitTypeSizeU3D400_tC029CD1424092BEC2D9AB8D9CBC8B22B49DFA552 ___B756DCEB1F8E53A9A479390FCF844C6B63AAC62C5A2200559B487B1EE11AFFB0_110;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=128 <PrivateImplementationDetails>::B8F2307738DFC696CFAE6733BA3039D28318178988DA7C5750FAFB99E84F2F91
	__StaticArrayInitTypeSizeU3D128_t640A21A2468D16DFD0B732485754BEFBBAC8A6E2 ___B8F2307738DFC696CFAE6733BA3039D28318178988DA7C5750FAFB99E84F2F91_111;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=48 <PrivateImplementationDetails>::BD86C03576B3C2312CBD965EE79654E9BE0D3766FC11B235E02A93E5634AFECF
	__StaticArrayInitTypeSizeU3D48_tB425B9168DD04A4EAAF07BD2CC6DFD1CF35CC40D ___BD86C03576B3C2312CBD965EE79654E9BE0D3766FC11B235E02A93E5634AFECF_112;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=240 <PrivateImplementationDetails>::BF6CB3140946655EB1B147BB7909C7F5C4B8058413F47649E1C6828A930A7A02
	__StaticArrayInitTypeSizeU3D240_t8360335AAF186135DBB6BB491097128F387A6DF0 ___BF6CB3140946655EB1B147BB7909C7F5C4B8058413F47649E1C6828A930A7A02_113;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=2048 <PrivateImplementationDetails>::C3945B22EFF62F924F4DA57060DE2529934009FAD34AC3FDE9A86C49F1584D8A
	__StaticArrayInitTypeSizeU3D2048_t0C35A0CA34A63F1FECC92DDD63D81FB736D5FA3C ___C3945B22EFF62F924F4DA57060DE2529934009FAD34AC3FDE9A86C49F1584D8A_114;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=56 <PrivateImplementationDetails>::C4CC1DB5707E493A4E14E625A0C51840DEF701C6AFD4E9415559567C4970009A
	__StaticArrayInitTypeSizeU3D56_tB88B81AE57B8A712204365F456C8AC69B77BA92F ___C4CC1DB5707E493A4E14E625A0C51840DEF701C6AFD4E9415559567C4970009A_115;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=72 <PrivateImplementationDetails>::C6A717BB8BC695DCC35083C7A232C5F2B2BE83631E09722BCA681A73C22DB735
	__StaticArrayInitTypeSizeU3D72_t5B6BC9642D006F35493D9E4B930EDA3D9970D264 ___C6A717BB8BC695DCC35083C7A232C5F2B2BE83631E09722BCA681A73C22DB735_116;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=96 <PrivateImplementationDetails>::C6C0EC28545D63E67E09C9D12D7349AA58D5BD0551E8A91A462E87D77DF28F9D
	__StaticArrayInitTypeSizeU3D96_t7839E5E3863E908B97FAC76DD08A31B57876A4C0 ___C6C0EC28545D63E67E09C9D12D7349AA58D5BD0551E8A91A462E87D77DF28F9D_117;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=80 <PrivateImplementationDetails>::C6E48919167BA983CA9BE955CE7E6BF81B6DB0634F01EF1583BCF082B0B05C86
	__StaticArrayInitTypeSizeU3D80_tF0F3D4C3B26BCD7AA0C3B46EE73DE0D653DC719A ___C6E48919167BA983CA9BE955CE7E6BF81B6DB0634F01EF1583BCF082B0B05C86_118;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=840 <PrivateImplementationDetails>::C7693B6973330A4C435043B2924D7B2C0CDFEDEB430F7D2904D64F3C8B5C8D4B
	__StaticArrayInitTypeSizeU3D840_t6B295E185CF97F7FA1BF7A96A845A410A431DB24 ___C7693B6973330A4C435043B2924D7B2C0CDFEDEB430F7D2904D64F3C8B5C8D4B_119;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=48 <PrivateImplementationDetails>::C8205CA8281543277EDB8FBD8BCEA62A7D48A7476B7F00C6D0A0FC0796ECCE4A
	__StaticArrayInitTypeSizeU3D48_tB425B9168DD04A4EAAF07BD2CC6DFD1CF35CC40D ___C8205CA8281543277EDB8FBD8BCEA62A7D48A7476B7F00C6D0A0FC0796ECCE4A_120;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=40 <PrivateImplementationDetails>::C87B75B20CB250117394BD421ED9EC0B0153C04AB7372C10CE3D3DBC52397276
	__StaticArrayInitTypeSizeU3D40_t9E6A84D485B0C75F1CA0BD2D219146FCDC7ED4BD ___C87B75B20CB250117394BD421ED9EC0B0153C04AB7372C10CE3D3DBC52397276_121;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=64 <PrivateImplementationDetails>::C9035959B3C396D4EEA23F492250C9896D3DE490F60C89D72F0F0C4F916D9F54
	__StaticArrayInitTypeSizeU3D64_tD9AF088EC79B314805D0B368C31072882C1EBBB1 ___C9035959B3C396D4EEA23F492250C9896D3DE490F60C89D72F0F0C4F916D9F54_122;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=40 <PrivateImplementationDetails>::C9698DD6C498706E835F28F69EBACF56E380788F1E9169EF7E01472365AB4772
	__StaticArrayInitTypeSizeU3D40_t9E6A84D485B0C75F1CA0BD2D219146FCDC7ED4BD ___C9698DD6C498706E835F28F69EBACF56E380788F1E9169EF7E01472365AB4772_123;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=96 <PrivateImplementationDetails>::CB2EB01825EE70B16527EEB81F43D428489E36D0CDACC1659E8A99092999A3E8
	__StaticArrayInitTypeSizeU3D96_t7839E5E3863E908B97FAC76DD08A31B57876A4C0 ___CB2EB01825EE70B16527EEB81F43D428489E36D0CDACC1659E8A99092999A3E8_124;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=192 <PrivateImplementationDetails>::CCB71B1949E6B3BE51DB30F81787231303506C9420421999DF89943BE687C6E5
	__StaticArrayInitTypeSizeU3D192_t6B99BE29A58F1B0459B68D3722331DF5162C06EC ___CCB71B1949E6B3BE51DB30F81787231303506C9420421999DF89943BE687C6E5_125;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=40 <PrivateImplementationDetails>::CCCC1246C931533D81C91CF8840942C6EA7B78E3C520110B749C7AFEDEFEFB8A
	__StaticArrayInitTypeSizeU3D40_t9E6A84D485B0C75F1CA0BD2D219146FCDC7ED4BD ___CCCC1246C931533D81C91CF8840942C6EA7B78E3C520110B749C7AFEDEFEFB8A_126;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=232 <PrivateImplementationDetails>::CCD1234D142DB060F120B110733EC705C0C1ED9BAAFC49645703648F5798C5E3
	__StaticArrayInitTypeSizeU3D232_t473109E5478E2A1CDB404DC9F3606C77F65F6E4A ___CCD1234D142DB060F120B110733EC705C0C1ED9BAAFC49645703648F5798C5E3_127;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=144 <PrivateImplementationDetails>::CD6BDA77FBD02BA99B91440A0E1C22EA6337FD22A31DFF065A4767C2D24F4F1D
	__StaticArrayInitTypeSizeU3D144_t86FE0B03ABC127132139E03631B2B07EEC44F73A ___CD6BDA77FBD02BA99B91440A0E1C22EA6337FD22A31DFF065A4767C2D24F4F1D_128;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=1680 <PrivateImplementationDetails>::D37548BDB339D68A274CA9F76F4B0D353F5CF0062AEC588BD7BB3BBEA9797F90
	__StaticArrayInitTypeSizeU3D1680_tC7B06B9771B36B942CE6558A3056C675C35CFBED ___D37548BDB339D68A274CA9F76F4B0D353F5CF0062AEC588BD7BB3BBEA9797F90_129;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=4096 <PrivateImplementationDetails>::D3B1B2294AA4B7DAA2F9B8CAB27A6437441350E110E277FC47109E6219875BCC
	__StaticArrayInitTypeSizeU3D4096_tBB0AB4FB3110EBB4D8094F6D03DB96D2F260C451 ___D3B1B2294AA4B7DAA2F9B8CAB27A6437441350E110E277FC47109E6219875BCC_130;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=240 <PrivateImplementationDetails>::D41E09946F9D11A8A598501FD289F7B01AD3FA8DFF500BCE89FAC35906E5B8AF
	__StaticArrayInitTypeSizeU3D240_t8360335AAF186135DBB6BB491097128F387A6DF0 ___D41E09946F9D11A8A598501FD289F7B01AD3FA8DFF500BCE89FAC35906E5B8AF_131;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=768 <PrivateImplementationDetails>::D462675AFDA6D8EEA15A9214B1A6BB8955965C7CC23580BD49A76A5F8CC94FD9
	__StaticArrayInitTypeSizeU3D768_t75BAB53216CBA938AD1064C2B94F6591C965AAF9 ___D462675AFDA6D8EEA15A9214B1A6BB8955965C7CC23580BD49A76A5F8CC94FD9_132;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=56 <PrivateImplementationDetails>::D81239225B37D0CAEF8D12260D8D3DF42EBD6C0AF1DA243E0DD75B1389CDDA57
	__StaticArrayInitTypeSizeU3D56_tB88B81AE57B8A712204365F456C8AC69B77BA92F ___D81239225B37D0CAEF8D12260D8D3DF42EBD6C0AF1DA243E0DD75B1389CDDA57_133;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=72 <PrivateImplementationDetails>::D9CB763269419E73BAC44CB1AEA12E957AA337DC61177120D012BE4E03428D73
	__StaticArrayInitTypeSizeU3D72_t5B6BC9642D006F35493D9E4B930EDA3D9970D264 ___D9CB763269419E73BAC44CB1AEA12E957AA337DC61177120D012BE4E03428D73_134;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=80 <PrivateImplementationDetails>::D9FE5DE26FE10E27C602BEBF7A289CF9C52645D28775782795A14F78E38B4112
	__StaticArrayInitTypeSizeU3D80_tF0F3D4C3B26BCD7AA0C3B46EE73DE0D653DC719A ___D9FE5DE26FE10E27C602BEBF7A289CF9C52645D28775782795A14F78E38B4112_135;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=56 <PrivateImplementationDetails>::DAA9E4A285E4B613799960CCD6CA7294A84CD5683A87F2072E88AD73759602B6
	__StaticArrayInitTypeSizeU3D56_tB88B81AE57B8A712204365F456C8AC69B77BA92F ___DAA9E4A285E4B613799960CCD6CA7294A84CD5683A87F2072E88AD73759602B6_136;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=48 <PrivateImplementationDetails>::DB02066BD9C53FDD788457F018FE27A9A5ADC8F3CFED79CCC0FB3ABB30257F03
	__StaticArrayInitTypeSizeU3D48_tB425B9168DD04A4EAAF07BD2CC6DFD1CF35CC40D ___DB02066BD9C53FDD788457F018FE27A9A5ADC8F3CFED79CCC0FB3ABB30257F03_137;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=40 <PrivateImplementationDetails>::DBAFA7162F03CEC52C75EE83BE3C5E536D3A525C9B32661DD8EC11473E4EB491
	__StaticArrayInitTypeSizeU3D40_t9E6A84D485B0C75F1CA0BD2D219146FCDC7ED4BD ___DBAFA7162F03CEC52C75EE83BE3C5E536D3A525C9B32661DD8EC11473E4EB491_138;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=72 <PrivateImplementationDetails>::E1043B6B4D1AC8BC8AFDBA7BA02436D5899B62B1A6FAA6BA81A63A4F7673F9DB
	__StaticArrayInitTypeSizeU3D72_t5B6BC9642D006F35493D9E4B930EDA3D9970D264 ___E1043B6B4D1AC8BC8AFDBA7BA02436D5899B62B1A6FAA6BA81A63A4F7673F9DB_139;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=256 <PrivateImplementationDetails>::E24B4F6B39B06D2AA3F7FFC6A0562AC79958E856546DAF4F891B0E6A3F14DCA7
	__StaticArrayInitTypeSizeU3D256_tA106810FA425C1BE0A04C445803CF0DABF77D630 ___E24B4F6B39B06D2AA3F7FFC6A0562AC79958E856546DAF4F891B0E6A3F14DCA7_140;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=128 <PrivateImplementationDetails>::E277A8C50BAA1AB8D24C5E600E1851764EB122CB868CDE52B55D70ACA3A2F817
	__StaticArrayInitTypeSizeU3D128_t640A21A2468D16DFD0B732485754BEFBBAC8A6E2 ___E277A8C50BAA1AB8D24C5E600E1851764EB122CB868CDE52B55D70ACA3A2F817_141;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=64 <PrivateImplementationDetails>::E3D078D933D15A43FEC7A7B876AA6ABD724C04AB763FAE0209C2BEC4857C1863
	__StaticArrayInitTypeSizeU3D64_tD9AF088EC79B314805D0B368C31072882C1EBBB1 ___E3D078D933D15A43FEC7A7B876AA6ABD724C04AB763FAE0209C2BEC4857C1863_142;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=64 <PrivateImplementationDetails>::E4CF58EA387BC1B8D65DC0EE20295A5EF95AD716EBBBB6432B316FFC43F8AE94
	__StaticArrayInitTypeSizeU3D64_tD9AF088EC79B314805D0B368C31072882C1EBBB1 ___E4CF58EA387BC1B8D65DC0EE20295A5EF95AD716EBBBB6432B316FFC43F8AE94_143;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=88 <PrivateImplementationDetails>::E50B1BE91D17B2C69C54791AFEDAC31ACA6C6AD67CB9FBFC7F1DC88949925A4C
	__StaticArrayInitTypeSizeU3D88_tC9D35D8FE1174F38E7FE4E673C66E0CBE1CD77D7 ___E50B1BE91D17B2C69C54791AFEDAC31ACA6C6AD67CB9FBFC7F1DC88949925A4C_144;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=80 <PrivateImplementationDetails>::E7B8900B7428ABA38FB9AFFB525E124DB6521B092E3B3B7A502B6434E9069175
	__StaticArrayInitTypeSizeU3D80_tF0F3D4C3B26BCD7AA0C3B46EE73DE0D653DC719A ___E7B8900B7428ABA38FB9AFFB525E124DB6521B092E3B3B7A502B6434E9069175_145;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=168 <PrivateImplementationDetails>::E7D1813DDE47DC7B2CD6CF7F2C54F17E39593EE825F34725838862E79D0CE6AB
	__StaticArrayInitTypeSizeU3D168_t0D4075FD484E508BC0C0DD20948BFF27529E947F ___E7D1813DDE47DC7B2CD6CF7F2C54F17E39593EE825F34725838862E79D0CE6AB_146;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=32 <PrivateImplementationDetails>::EB12EDA9225071A41236EC1F144D2B039A1BA976B4E6FC5497863266F2DA1E72
	__StaticArrayInitTypeSizeU3D32_tF3BF3F419E08C2B4D21ADCEC29206686A7221E0A ___EB12EDA9225071A41236EC1F144D2B039A1BA976B4E6FC5497863266F2DA1E72_147;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=120 <PrivateImplementationDetails>::EE14A322349EDBCF1852436782701532B54A18FA0FBF1CCC719737F25C8B6E01
	__StaticArrayInitTypeSizeU3D120_tFB94AC1DD2A9025138D4D46D91715CCC3FF11600 ___EE14A322349EDBCF1852436782701532B54A18FA0FBF1CCC719737F25C8B6E01_148;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=1024 <PrivateImplementationDetails>::EF176177FC5179507DBBA8B91AEE7AB612E2D7DB3DA3D8F8FE46011A8FCFE20B
	__StaticArrayInitTypeSizeU3D1024_tB81472E99F63254F5E76D9CD03FF689F7C564A8F ___EF176177FC5179507DBBA8B91AEE7AB612E2D7DB3DA3D8F8FE46011A8FCFE20B_149;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=40 <PrivateImplementationDetails>::EFE55C2CBEA35A271C9ACF07760E56357D5E1D4BEA1EE784F60F3AEC9A82A483
	__StaticArrayInitTypeSizeU3D40_t9E6A84D485B0C75F1CA0BD2D219146FCDC7ED4BD ___EFE55C2CBEA35A271C9ACF07760E56357D5E1D4BEA1EE784F60F3AEC9A82A483_150;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=64 <PrivateImplementationDetails>::F01589B67FF9A75B2CC9925B744B0FE9E3B36C175B52F18485A5135834086D70
	__StaticArrayInitTypeSizeU3D64_tD9AF088EC79B314805D0B368C31072882C1EBBB1 ___F01589B67FF9A75B2CC9925B744B0FE9E3B36C175B52F18485A5135834086D70_151;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=40 <PrivateImplementationDetails>::F556C8D5A69CEF3387CCF9AA15D9676B6923C4999D4EE530458DFC4B77F49A2F
	__StaticArrayInitTypeSizeU3D40_t9E6A84D485B0C75F1CA0BD2D219146FCDC7ED4BD ___F556C8D5A69CEF3387CCF9AA15D9676B6923C4999D4EE530458DFC4B77F49A2F_152;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=168 <PrivateImplementationDetails>::F986301E70D79C1DFFCB4812B8A9B2B0282185C64DC2755301EFBB156203628B
	__StaticArrayInitTypeSizeU3D168_t0D4075FD484E508BC0C0DD20948BFF27529E947F ___F986301E70D79C1DFFCB4812B8A9B2B0282185C64DC2755301EFBB156203628B_153;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=72 <PrivateImplementationDetails>::F9884B17C24ED60BAF991466C64DF0F50C020A4FD52AB859E8021DF316D6E789
	__StaticArrayInitTypeSizeU3D72_t5B6BC9642D006F35493D9E4B930EDA3D9970D264 ___F9884B17C24ED60BAF991466C64DF0F50C020A4FD52AB859E8021DF316D6E789_154;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=48 <PrivateImplementationDetails>::FAC7BD0AED74BBF61012E4AD0E06848132A754D403B118273F8B33B957D321C5
	__StaticArrayInitTypeSizeU3D48_tB425B9168DD04A4EAAF07BD2CC6DFD1CF35CC40D ___FAC7BD0AED74BBF61012E4AD0E06848132A754D403B118273F8B33B957D321C5_155;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=40 <PrivateImplementationDetails>::FB1570C24E08B295451521F9ADF71B1778D767131F0618A321D63AC539C89BD5
	__StaticArrayInitTypeSizeU3D40_t9E6A84D485B0C75F1CA0BD2D219146FCDC7ED4BD ___FB1570C24E08B295451521F9ADF71B1778D767131F0618A321D63AC539C89BD5_156;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=8192 <PrivateImplementationDetails>::FB1D2E3D7108CBD93E6A1FA4E0E8FF3A795B93B7F8FDCEF010D67E3520A734C5
	__StaticArrayInitTypeSizeU3D8192_t4C5E03EFB21191EC1CA56D46B2E7F8EF2E8B8BA8 ___FB1D2E3D7108CBD93E6A1FA4E0E8FF3A795B93B7F8FDCEF010D67E3520A734C5_157;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=248 <PrivateImplementationDetails>::FBBD13D92847B31A9D43FC33BA716CDABBDA8A392A1A9303CA843023C96D03FB
	__StaticArrayInitTypeSizeU3D248_t5749AB59ED299BF9D2B242FE08E30F1747DE4BFE ___FBBD13D92847B31A9D43FC33BA716CDABBDA8A392A1A9303CA843023C96D03FB_158;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=40 <PrivateImplementationDetails>::FCBA3969EB924386378F48C1E3C5E44E50E54BCE3314921F80D2DA6F9F5969A6
	__StaticArrayInitTypeSizeU3D40_t9E6A84D485B0C75F1CA0BD2D219146FCDC7ED4BD ___FCBA3969EB924386378F48C1E3C5E44E50E54BCE3314921F80D2DA6F9F5969A6_159;
};

// <PrivateImplementationDetails>

// MathNet.Numerics.LinearAlgebra.Double.DenseMatrix

// MathNet.Numerics.LinearAlgebra.Double.DenseMatrix

// System.Exception
struct Exception_t_StaticFields
{
	// System.Object System.Exception::s_EDILock
	RuntimeObject* ___s_EDILock_0;
};

// System.Exception

// MathNet.Numerics.Random.SystemRandomSource
struct SystemRandomSource_t23E2BA98CFAB3CA24F6FE6DE3B83B132A44178E4_StaticFields
{
	// System.Threading.ThreadLocal`1<MathNet.Numerics.Random.SystemRandomSource> MathNet.Numerics.Random.SystemRandomSource::DefaultInstance
	ThreadLocal_1_tCDC272FFAAF66E27F8F3AE02CB0896A09D050D12* ___DefaultInstance_8;
};

// MathNet.Numerics.Random.SystemRandomSource

// System.Func`2<System.Double[],System.Double[]>

// System.Func`2<System.Double[],System.Double[]>

// System.Func`2<System.Double[],System.Double>

// System.Func`2<System.Double[],System.Double>

// System.Func`2<System.Double,System.Double>

// System.Func`2<System.Double,System.Double>

// System.Func`2<System.Object,System.Double>

// System.Func`2<System.Object,System.Double>

// System.Func`3<System.Double,System.Int32,System.Double>

// System.Func`3<System.Double,System.Int32,System.Double>

// System.Func`3<System.Int32,System.Int32,System.Double>

// System.Func`3<System.Int32,System.Int32,System.Double>

// System.ArgumentException

// System.ArgumentException

// System.NotSupportedException

// System.NotSupportedException

// System.ArgumentNullException

// System.ArgumentNullException

// System.ArgumentOutOfRangeException

// System.ArgumentOutOfRangeException
#ifdef __clang__
#pragma clang diagnostic pop
#endif
// System.Double[]
struct DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE  : public RuntimeArray
{
	ALIGN_FIELD (8) double m_Items[1];

	inline double GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline double* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, double value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline double GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline double* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, double value)
	{
		m_Items[index] = value;
	}
};
// System.Int32[]
struct Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C  : public RuntimeArray
{
	ALIGN_FIELD (8) int32_t m_Items[1];

	inline int32_t GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline int32_t* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, int32_t value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline int32_t GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline int32_t* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, int32_t value)
	{
		m_Items[index] = value;
	}
};
// System.Double[,]
struct DoubleU5BU2CU5D_tA10EAF4C451E6EBC345A8881EBB9EF9441D01AAE  : public RuntimeArray
{
	ALIGN_FIELD (8) double m_Items[1];

	inline double GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline double* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, double value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline double GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline double* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, double value)
	{
		m_Items[index] = value;
	}
	inline double GetAt(il2cpp_array_size_t i, il2cpp_array_size_t j) const
	{
		il2cpp_array_size_t iBound = bounds[0].length;
		IL2CPP_ARRAY_BOUNDS_CHECK(i, iBound);
		il2cpp_array_size_t jBound = bounds[1].length;
		IL2CPP_ARRAY_BOUNDS_CHECK(j, jBound);

		il2cpp_array_size_t index = i * jBound + j;
		return m_Items[index];
	}
	inline double* GetAddressAt(il2cpp_array_size_t i, il2cpp_array_size_t j)
	{
		il2cpp_array_size_t iBound = bounds[0].length;
		IL2CPP_ARRAY_BOUNDS_CHECK(i, iBound);
		il2cpp_array_size_t jBound = bounds[1].length;
		IL2CPP_ARRAY_BOUNDS_CHECK(j, jBound);

		il2cpp_array_size_t index = i * jBound + j;
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t i, il2cpp_array_size_t j, double value)
	{
		il2cpp_array_size_t iBound = bounds[0].length;
		IL2CPP_ARRAY_BOUNDS_CHECK(i, iBound);
		il2cpp_array_size_t jBound = bounds[1].length;
		IL2CPP_ARRAY_BOUNDS_CHECK(j, jBound);

		il2cpp_array_size_t index = i * jBound + j;
		m_Items[index] = value;
	}
	inline double GetAtUnchecked(il2cpp_array_size_t i, il2cpp_array_size_t j) const
	{
		il2cpp_array_size_t jBound = bounds[1].length;

		il2cpp_array_size_t index = i * jBound + j;
		return m_Items[index];
	}
	inline double* GetAddressAtUnchecked(il2cpp_array_size_t i, il2cpp_array_size_t j)
	{
		il2cpp_array_size_t jBound = bounds[1].length;

		il2cpp_array_size_t index = i * jBound + j;
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t i, il2cpp_array_size_t j, double value)
	{
		il2cpp_array_size_t jBound = bounds[1].length;

		il2cpp_array_size_t index = i * jBound + j;
		m_Items[index] = value;
	}
};
// System.Double[,][]
struct DoubleU5BU2CU5DU5BU5D_tA2205504790CBE64D5959B2C6A51DAFD8916B6BF  : public RuntimeArray
{
	ALIGN_FIELD (8) DoubleU5BU2CU5D_tA10EAF4C451E6EBC345A8881EBB9EF9441D01AAE* m_Items[1];

	inline DoubleU5BU2CU5D_tA10EAF4C451E6EBC345A8881EBB9EF9441D01AAE* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline DoubleU5BU2CU5D_tA10EAF4C451E6EBC345A8881EBB9EF9441D01AAE** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, DoubleU5BU2CU5D_tA10EAF4C451E6EBC345A8881EBB9EF9441D01AAE* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline DoubleU5BU2CU5D_tA10EAF4C451E6EBC345A8881EBB9EF9441D01AAE* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline DoubleU5BU2CU5D_tA10EAF4C451E6EBC345A8881EBB9EF9441D01AAE** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, DoubleU5BU2CU5D_tA10EAF4C451E6EBC345A8881EBB9EF9441D01AAE* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};
// System.Func`2<System.Double[],System.Double>[]
struct Func_2U5BU5D_tAFC1A2A6571948ADB9C2BC67B555510E993FC60A  : public RuntimeArray
{
	ALIGN_FIELD (8) Func_2_t89B8106282004E94AE869931CD4E1DF667EB235E* m_Items[1];

	inline Func_2_t89B8106282004E94AE869931CD4E1DF667EB235E* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Func_2_t89B8106282004E94AE869931CD4E1DF667EB235E** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Func_2_t89B8106282004E94AE869931CD4E1DF667EB235E* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline Func_2_t89B8106282004E94AE869931CD4E1DF667EB235E* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Func_2_t89B8106282004E94AE869931CD4E1DF667EB235E** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Func_2_t89B8106282004E94AE869931CD4E1DF667EB235E* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};
// System.Nullable`1<System.Double>[]
struct Nullable_1U5BU5D_t8608EFC3D4A79785F59C7AB124AD5FBE0F75BCF1  : public RuntimeArray
{
	ALIGN_FIELD (8) Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165 m_Items[1];

	inline Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165 GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165 value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165 GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165 value)
	{
		m_Items[index] = value;
	}
};


// System.Int32 MathNet.Numerics.LinearAlgebra.Matrix`1<System.Double>::get_RowCount()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t Matrix_1_get_RowCount_m9B54DCE02A3829F5EBD4D5D7ACF2615FCBA2A7E2_gshared_inline (Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* __this, const RuntimeMethod* method) ;
// System.Int32 MathNet.Numerics.LinearAlgebra.Matrix`1<System.Double>::get_ColumnCount()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t Matrix_1_get_ColumnCount_mA9469577A4E8459338A621B987E653D241A6883B_gshared_inline (Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* __this, const RuntimeMethod* method) ;
// T MathNet.Numerics.LinearAlgebra.Matrix`1<System.Double>::At(System.Int32,System.Int32)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR double Matrix_1_At_mBA3B6ADE91F6541597F6BA43AD04B13E36998233_gshared_inline (Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* __this, int32_t ___0_row, int32_t ___1_column, const RuntimeMethod* method) ;
// MathNet.Numerics.LinearAlgebra.Matrix`1<T> MathNet.Numerics.LinearAlgebra.Matrix`1<System.Double>::op_Multiply(T,MathNet.Numerics.LinearAlgebra.Matrix`1<T>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* Matrix_1_op_Multiply_m39042F5DB6C9BCAC26059652232B314517464584_gshared (double ___0_leftSide, Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* ___1_rightSide, const RuntimeMethod* method) ;
// System.Void System.Func`3<System.Int32,System.Int32,System.Double>::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Func_3__ctor_m7937C139834AD053DE8E365BDD625EF16A628D7D_gshared (Func_3_t057050D6922BDFD2DA39811D38124A65D97E389C* __this, RuntimeObject* ___0_object, intptr_t ___1_method, const RuntimeMethod* method) ;
// MathNet.Numerics.LinearAlgebra.Matrix`1<T> MathNet.Numerics.LinearAlgebra.MatrixBuilder`1<System.Double>::Dense(System.Int32,System.Int32,System.Func`3<System.Int32,System.Int32,T>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* MatrixBuilder_1_Dense_mB6F63A6F6EF5CBA2F7670D858050EE99C7F2C258_gshared (MatrixBuilder_1_tB265D6E40F33E9A311724A5F2EDB8C5F71621C2A* __this, int32_t ___0_rows, int32_t ___1_columns, Func_3_t057050D6922BDFD2DA39811D38124A65D97E389C* ___2_init, const RuntimeMethod* method) ;
// System.Exception MathNet.Numerics.LinearAlgebra.Matrix`1<System.Double>::DimensionsDontMatch<System.Object>(MathNet.Numerics.LinearAlgebra.Matrix`1<T>,MathNet.Numerics.LinearAlgebra.Matrix`1<T>,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Exception_t* Matrix_1_DimensionsDontMatch_TisRuntimeObject_mC2B06FFFC2F23C52117FC06EB802726BBBBB845B_gshared (Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* ___0_left, Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* ___1_right, String_t* ___2_paramName, const RuntimeMethod* method) ;
// System.Void MathNet.Numerics.LinearAlgebra.Matrix`1<System.Double>::At(System.Int32,System.Int32,T)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Matrix_1_At_m3510B6B24011AF518E2720B108836BF602246877_gshared_inline (Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* __this, int32_t ___0_row, int32_t ___1_column, double ___2_value, const RuntimeMethod* method) ;
// MathNet.Numerics.LinearAlgebra.Matrix`1<T> MathNet.Numerics.LinearAlgebra.Factorization.Cholesky`1<System.Double>::get_Factor()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* Cholesky_1_get_Factor_m0DAB4879B1C18A503BC02DB1055250A8611C5CA7_gshared_inline (Cholesky_1_t1FD2C6EAE804ACF062E3034A45A8D1004519525C* __this, const RuntimeMethod* method) ;
// MathNet.Numerics.LinearAlgebra.Matrix`1<T> MathNet.Numerics.LinearAlgebra.Matrix`1<System.Double>::op_Multiply(MathNet.Numerics.LinearAlgebra.Matrix`1<T>,MathNet.Numerics.LinearAlgebra.Matrix`1<T>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* Matrix_1_op_Multiply_mA80E4A79BDCADD1707F7C2BBFDDB8F3C9709B790_gshared (Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* ___0_leftSide, Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* ___1_rightSide, const RuntimeMethod* method) ;
// MathNet.Numerics.LinearAlgebra.Matrix`1<T> MathNet.Numerics.LinearAlgebra.Matrix`1<System.Double>::Transpose()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* Matrix_1_Transpose_m7A760B1D7F8E54788932F964F865D0398171D74A_gshared (Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* __this, const RuntimeMethod* method) ;
// System.Void MathNet.Numerics.LinearAlgebra.Matrix`1<System.Double>::set_Item(System.Int32,System.Int32,T)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Matrix_1_set_Item_mC97D847F561C86DD3856B0FA098D2D0529728B67_gshared_inline (Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* __this, int32_t ___0_row, int32_t ___1_column, double ___2_value, const RuntimeMethod* method) ;
// T MathNet.Numerics.LinearAlgebra.Matrix`1<System.Double>::get_Item(System.Int32,System.Int32)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR double Matrix_1_get_Item_m9AC37D09D678515B98CFC7C5A3BBECAC3067D9DE_gshared_inline (Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* __this, int32_t ___0_row, int32_t ___1_column, const RuntimeMethod* method) ;
// T[,] MathNet.Numerics.LinearAlgebra.Matrix`1<System.Double>::ToArray()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR DoubleU5BU2CU5D_tA10EAF4C451E6EBC345A8881EBB9EF9441D01AAE* Matrix_1_ToArray_m0F3DB5D9135BA3556C288F91992B1B0C390AAF72_gshared (Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* __this, const RuntimeMethod* method) ;
// System.Void System.Func`3<System.Double,System.Int32,System.Double>::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Func_3__ctor_m3CD5133CBCB6F0EA58618ADE3B4635342495E6B9_gshared (Func_3_t4A84D23D01C9E182A3CFA36E5B7F3F13F9B82367* __this, RuntimeObject* ___0_object, intptr_t ___1_method, const RuntimeMethod* method) ;
// System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable::Select<System.Double,System.Double>(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`3<TSource,System.Int32,TResult>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* Enumerable_Select_TisDouble_tE150EF3D1D43DEE85D533810AB4C742307EEDE5F_TisDouble_tE150EF3D1D43DEE85D533810AB4C742307EEDE5F_mB588D15462B1F933FD6F77574674E0999EC99B62_gshared (RuntimeObject* ___0_source, Func_3_t4A84D23D01C9E182A3CFA36E5B7F3F13F9B82367* ___1_selector, const RuntimeMethod* method) ;
// System.Boolean System.Nullable`1<System.Double>::get_HasValue()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool Nullable_1_get_HasValue_mC082C667C8EB3A6CA80E06BCAEA0BED00C6BC15A_gshared_inline (Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165* __this, const RuntimeMethod* method) ;
// T System.Nullable`1<System.Double>::get_Value()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double Nullable_1_get_Value_m260A5CB9269FD3E130F998A589EDAEC2E8F9EAE1_gshared (Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165* __this, const RuntimeMethod* method) ;
// TResult System.Func`2<System.Double,System.Double>::Invoke(T)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR double Func_2_Invoke_m762147834B46FC6B99180328AD303FC3F47CCD62_gshared_inline (Func_2_t0221E9CE1FF8B8FE59AED052D562790B96F13B3D* __this, double ___0_arg, const RuntimeMethod* method) ;
// System.Void System.Func`2<System.Double,System.Double>::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Func_2__ctor_m653F26D531BA0409921E01E3994462FC75138745_gshared (Func_2_t0221E9CE1FF8B8FE59AED052D562790B96F13B3D* __this, RuntimeObject* ___0_object, intptr_t ___1_method, const RuntimeMethod* method) ;
// TResult System.Func`2<System.Object,System.Double>::Invoke(T)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR double Func_2_Invoke_mD53F0155434EDFA18B5BDAD0B0F61AC5F82EB95B_gshared_inline (Func_2_t5D850B409400F6FC6B650829D4B758F5899212B1* __this, RuntimeObject* ___0_arg, const RuntimeMethod* method) ;
// System.Void System.Nullable`1<System.Double>::.ctor(T)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Nullable_1__ctor_mDE3158DD99CA7E1775A8BA276E428AF808AB8FBF_gshared (Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165* __this, double ___0_value, const RuntimeMethod* method) ;
// System.Void System.Func`2<System.Object,System.Double>::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Func_2__ctor_mC2F9460DBFF9A8659492AC19F4B9FCA63BFA48A8_gshared (Func_2_t5D850B409400F6FC6B650829D4B758F5899212B1* __this, RuntimeObject* ___0_object, intptr_t ___1_method, const RuntimeMethod* method) ;
// System.Void System.Func`2<System.Object,System.Object>::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Func_2__ctor_m7F8A01C0B02BC1D4063F4EB1E817F7A48562A398_gshared (Func_2_tACBF5A1656250800CE861707354491F0611F6624* __this, RuntimeObject* ___0_object, intptr_t ___1_method, const RuntimeMethod* method) ;

// System.Void System.Object::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2 (RuntimeObject* __this, const RuntimeMethod* method) ;
// System.Double System.Math::Pow(System.Double,System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double Math_Pow_mEAE651F0858203FBE12B72B6A53951BBD0FB5265 (double ___0_x, double ___1_y, const RuntimeMethod* method) ;
// System.Boolean MathNet.Numerics.Control::get_CheckDistributionParameters()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool Control_get_CheckDistributionParameters_mCCA3C1C492BF697B4A7181481C894D2E2D8CD093_inline (const RuntimeMethod* method) ;
// System.Boolean MathNet.Numerics.Distributions.Wishart::IsValidParameterSet(System.Double,MathNet.Numerics.LinearAlgebra.Matrix`1<System.Double>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Wishart_IsValidParameterSet_mAD4D0A28CE229250C2087691CA24EEDBF747F84A (double ___0_degreesOfFreedom, Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* ___1_scale, const RuntimeMethod* method) ;
// System.Void System.ArgumentException::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ArgumentException__ctor_m026938A67AF9D36BB7ED27F80425D7194B514465 (ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263* __this, String_t* ___0_message, const RuntimeMethod* method) ;
// MathNet.Numerics.Random.SystemRandomSource MathNet.Numerics.Random.SystemRandomSource::get_Default()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR SystemRandomSource_t23E2BA98CFAB3CA24F6FE6DE3B83B132A44178E4* SystemRandomSource_get_Default_mBEE95CF0D1F624A75C45F88C10523473691F4D8D (const RuntimeMethod* method) ;
// System.Int32 MathNet.Numerics.LinearAlgebra.Matrix`1<System.Double>::get_RowCount()
inline int32_t Matrix_1_get_RowCount_m9B54DCE02A3829F5EBD4D5D7ACF2615FCBA2A7E2_inline (Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* __this, const RuntimeMethod* method)
{
	return ((  int32_t (*) (Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9*, const RuntimeMethod*))Matrix_1_get_RowCount_m9B54DCE02A3829F5EBD4D5D7ACF2615FCBA2A7E2_gshared_inline)(__this, method);
}
// System.Int32 MathNet.Numerics.LinearAlgebra.Matrix`1<System.Double>::get_ColumnCount()
inline int32_t Matrix_1_get_ColumnCount_mA9469577A4E8459338A621B987E653D241A6883B_inline (Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* __this, const RuntimeMethod* method)
{
	return ((  int32_t (*) (Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9*, const RuntimeMethod*))Matrix_1_get_ColumnCount_mA9469577A4E8459338A621B987E653D241A6883B_gshared_inline)(__this, method);
}
// T MathNet.Numerics.LinearAlgebra.Matrix`1<System.Double>::At(System.Int32,System.Int32)
inline double Matrix_1_At_mBA3B6ADE91F6541597F6BA43AD04B13E36998233_inline (Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* __this, int32_t ___0_row, int32_t ___1_column, const RuntimeMethod* method)
{
	return ((  double (*) (Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9*, int32_t, int32_t, const RuntimeMethod*))Matrix_1_At_mBA3B6ADE91F6541597F6BA43AD04B13E36998233_gshared_inline)(__this, ___0_row, ___1_column, method);
}
// System.Boolean System.Double::IsNaN(System.Double)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool Double_IsNaN_mF2BC6D1FD4813179B2CAE58D29770E42830D0883_inline (double ___0_d, const RuntimeMethod* method) ;
// System.String System.String::Format(System.String,System.Object,System.Object,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Format_mA0534D6E2AE4D67A6BD8D45B3321323930EB930C (String_t* ___0_format, RuntimeObject* ___1_arg0, RuntimeObject* ___2_arg1, RuntimeObject* ___3_arg2, const RuntimeMethod* method) ;
// MathNet.Numerics.LinearAlgebra.Matrix`1<T> MathNet.Numerics.LinearAlgebra.Matrix`1<System.Double>::op_Multiply(T,MathNet.Numerics.LinearAlgebra.Matrix`1<T>)
inline Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* Matrix_1_op_Multiply_m39042F5DB6C9BCAC26059652232B314517464584 (double ___0_leftSide, Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* ___1_rightSide, const RuntimeMethod* method)
{
	return ((  Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* (*) (double, Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9*, const RuntimeMethod*))Matrix_1_op_Multiply_m39042F5DB6C9BCAC26059652232B314517464584_gshared)(___0_leftSide, ___1_rightSide, method);
}
// System.Void System.Func`3<System.Int32,System.Int32,System.Double>::.ctor(System.Object,System.IntPtr)
inline void Func_3__ctor_m7937C139834AD053DE8E365BDD625EF16A628D7D (Func_3_t057050D6922BDFD2DA39811D38124A65D97E389C* __this, RuntimeObject* ___0_object, intptr_t ___1_method, const RuntimeMethod* method)
{
	((  void (*) (Func_3_t057050D6922BDFD2DA39811D38124A65D97E389C*, RuntimeObject*, intptr_t, const RuntimeMethod*))Func_3__ctor_m7937C139834AD053DE8E365BDD625EF16A628D7D_gshared)(__this, ___0_object, ___1_method, method);
}
// MathNet.Numerics.LinearAlgebra.Matrix`1<T> MathNet.Numerics.LinearAlgebra.MatrixBuilder`1<System.Double>::Dense(System.Int32,System.Int32,System.Func`3<System.Int32,System.Int32,T>)
inline Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* MatrixBuilder_1_Dense_mB6F63A6F6EF5CBA2F7670D858050EE99C7F2C258 (MatrixBuilder_1_tB265D6E40F33E9A311724A5F2EDB8C5F71621C2A* __this, int32_t ___0_rows, int32_t ___1_columns, Func_3_t057050D6922BDFD2DA39811D38124A65D97E389C* ___2_init, const RuntimeMethod* method)
{
	return ((  Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* (*) (MatrixBuilder_1_tB265D6E40F33E9A311724A5F2EDB8C5F71621C2A*, int32_t, int32_t, Func_3_t057050D6922BDFD2DA39811D38124A65D97E389C*, const RuntimeMethod*))MatrixBuilder_1_Dense_mB6F63A6F6EF5CBA2F7670D858050EE99C7F2C258_gshared)(__this, ___0_rows, ___1_columns, ___2_init, method);
}
// System.Exception MathNet.Numerics.LinearAlgebra.Matrix`1<System.Double>::DimensionsDontMatch<System.ArgumentOutOfRangeException>(MathNet.Numerics.LinearAlgebra.Matrix`1<T>,MathNet.Numerics.LinearAlgebra.Matrix`1<T>,System.String)
inline Exception_t* Matrix_1_DimensionsDontMatch_TisArgumentOutOfRangeException_tEA2822DAF62B10EEED00E0E3A341D4BAF78CF85F_m4F81149F91232A646B909C1F429796AE05751321 (Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* ___0_left, Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* ___1_right, String_t* ___2_paramName, const RuntimeMethod* method)
{
	return ((  Exception_t* (*) (Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9*, Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9*, String_t*, const RuntimeMethod*))Matrix_1_DimensionsDontMatch_TisRuntimeObject_mC2B06FFFC2F23C52117FC06EB802726BBBBB845B_gshared)(___0_left, ___1_right, ___2_paramName, method);
}
// System.Double MathNet.Numerics.SpecialFunctions::Gamma(System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double SpecialFunctions_Gamma_mC906224A9C8758F3C91964E0C7A1C780410A41D4 (double ___0_z, const RuntimeMethod* method) ;
// System.Random MathNet.Numerics.Distributions.Wishart::get_RandomSource()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8* Wishart_get_RandomSource_m2FD439F2EA4CD9FE9D99EDE884771950DCA00797_inline (Wishart_tDEFFEE7331AA0DC9A9F45284E8CCA00CB8012135* __this, const RuntimeMethod* method) ;
// MathNet.Numerics.LinearAlgebra.Matrix`1<System.Double> MathNet.Numerics.Distributions.Wishart::DoSample(System.Random,System.Double,MathNet.Numerics.LinearAlgebra.Matrix`1<System.Double>,MathNet.Numerics.LinearAlgebra.Factorization.Cholesky`1<System.Double>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* Wishart_DoSample_m1E9ECF30C383E6AAC800B6A5B02A82015652DE89 (Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8* ___0_rnd, double ___1_degreesOfFreedom, Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* ___2_scale, Cholesky_1_t1FD2C6EAE804ACF062E3034A45A8D1004519525C* ___3_chol, const RuntimeMethod* method) ;
// System.Void MathNet.Numerics.LinearAlgebra.Double.DenseMatrix::.ctor(System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void DenseMatrix__ctor_mE46D680928BE6324897DC27821012A7B854595E9 (DenseMatrix_tEB7C614EBDC0021BA303ED597DC448A8662D8A9F* __this, int32_t ___0_rows, int32_t ___1_columns, const RuntimeMethod* method) ;
// System.Double MathNet.Numerics.Distributions.Gamma::Sample(System.Random,System.Double,System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double Gamma_Sample_m539642CA16B45E050594513BB19DAFC637C01633 (Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8* ___0_rnd, double ___1_shape, double ___2_rate, const RuntimeMethod* method) ;
// System.Void MathNet.Numerics.LinearAlgebra.Matrix`1<System.Double>::At(System.Int32,System.Int32,T)
inline void Matrix_1_At_m3510B6B24011AF518E2720B108836BF602246877_inline (Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* __this, int32_t ___0_row, int32_t ___1_column, double ___2_value, const RuntimeMethod* method)
{
	((  void (*) (Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9*, int32_t, int32_t, double, const RuntimeMethod*))Matrix_1_At_m3510B6B24011AF518E2720B108836BF602246877_gshared_inline)(__this, ___0_row, ___1_column, ___2_value, method);
}
// System.Double MathNet.Numerics.Distributions.Normal::Sample(System.Random,System.Double,System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double Normal_Sample_m2811DDE0BBC677EFE70737954FE50B21CBCBC4E2 (Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8* ___0_rnd, double ___1_mean, double ___2_stddev, const RuntimeMethod* method) ;
// MathNet.Numerics.LinearAlgebra.Matrix`1<T> MathNet.Numerics.LinearAlgebra.Factorization.Cholesky`1<System.Double>::get_Factor()
inline Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* Cholesky_1_get_Factor_m0DAB4879B1C18A503BC02DB1055250A8611C5CA7_inline (Cholesky_1_t1FD2C6EAE804ACF062E3034A45A8D1004519525C* __this, const RuntimeMethod* method)
{
	return ((  Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* (*) (Cholesky_1_t1FD2C6EAE804ACF062E3034A45A8D1004519525C*, const RuntimeMethod*))Cholesky_1_get_Factor_m0DAB4879B1C18A503BC02DB1055250A8611C5CA7_gshared_inline)(__this, method);
}
// MathNet.Numerics.LinearAlgebra.Matrix`1<T> MathNet.Numerics.LinearAlgebra.Matrix`1<System.Double>::op_Multiply(MathNet.Numerics.LinearAlgebra.Matrix`1<T>,MathNet.Numerics.LinearAlgebra.Matrix`1<T>)
inline Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* Matrix_1_op_Multiply_mA80E4A79BDCADD1707F7C2BBFDDB8F3C9709B790 (Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* ___0_leftSide, Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* ___1_rightSide, const RuntimeMethod* method)
{
	return ((  Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* (*) (Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9*, Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9*, const RuntimeMethod*))Matrix_1_op_Multiply_mA80E4A79BDCADD1707F7C2BBFDDB8F3C9709B790_gshared)(___0_leftSide, ___1_rightSide, method);
}
// MathNet.Numerics.LinearAlgebra.Matrix`1<T> MathNet.Numerics.LinearAlgebra.Matrix`1<System.Double>::Transpose()
inline Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* Matrix_1_Transpose_m7A760B1D7F8E54788932F964F865D0398171D74A (Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* __this, const RuntimeMethod* method)
{
	return ((  Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* (*) (Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9*, const RuntimeMethod*))Matrix_1_Transpose_m7A760B1D7F8E54788932F964F865D0398171D74A_gshared)(__this, method);
}
// System.Boolean MathNet.Numerics.Distributions.Zipf::IsValidParameterSet(System.Double,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Zipf_IsValidParameterSet_mCBA918E502E3B0CD3CE08036B50C83015074D8B3 (double ___0_s, int32_t ___1_n, const RuntimeMethod* method) ;
// System.String System.String::Format(System.String,System.Object,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Format_mFB7DA489BD99F4670881FF50EC017BFB0A5C0987 (String_t* ___0_format, RuntimeObject* ___1_arg0, RuntimeObject* ___2_arg1, const RuntimeMethod* method) ;
// System.Double MathNet.Numerics.SpecialFunctions::GeneralHarmonic(System.Int32,System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double SpecialFunctions_GeneralHarmonic_mAB62B3F25407FA097A065F20516C08FED35B3508 (int32_t ___0_n, double ___1_m, const RuntimeMethod* method) ;
// System.Void System.NotSupportedException::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NotSupportedException__ctor_m1398D0CDE19B36AA3DE9392879738C1EA2439CDF (NotSupportedException_t1429765983D409BD2986508963C98D214E4EBF4A* __this, const RuntimeMethod* method) ;
// System.Double MathNet.Numerics.Distributions.Zipf::get_Variance()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double Zipf_get_Variance_m9E7880B7901EEAD19AEDCDBB429ACAB2CB36BA7B (Zipf_t533A437DA6EFB62CFF2FB4B397A2636242D87023* __this, const RuntimeMethod* method) ;
// System.Double MathNet.Numerics.Distributions.Zipf::Probability(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double Zipf_Probability_m1D6D84D3EBFDEE9C0E4A0665A1B430C2F41FD877 (Zipf_t533A437DA6EFB62CFF2FB4B397A2636242D87023* __this, int32_t ___0_k, const RuntimeMethod* method) ;
// System.Double MathNet.Numerics.Distributions.Zipf::PMF(System.Double,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double Zipf_PMF_mCBB1E81BE3F41DA62E019DAE5BCEDB71D36B69E2 (double ___0_s, int32_t ___1_n, int32_t ___2_k, const RuntimeMethod* method) ;
// System.Int32 MathNet.Numerics.Distributions.Zipf::SampleUnchecked(System.Random,System.Double,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Zipf_SampleUnchecked_m11CA278BCB474AE673FB4D6DB3B749FC43966E91 (Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8* ___0_rnd, double ___1_s, int32_t ___2_n, const RuntimeMethod* method) ;
// System.Void MathNet.Numerics.Distributions.Zipf/<SamplesUnchecked>d__40::.ctor(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CSamplesUncheckedU3Ed__40__ctor_m57A71D90D5247F4EDD0BF417F99C34F1F14A5F83 (U3CSamplesUncheckedU3Ed__40_t29307BD38C6FF3892A8B3F9FD768493D8F93EE8A* __this, int32_t ___0_U3CU3E1__state, const RuntimeMethod* method) ;
// System.Void MathNet.Numerics.Distributions.Zipf::SamplesUnchecked(System.Random,System.Int32[],System.Double,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Zipf_SamplesUnchecked_m7299A1FC9F6D4BDA78226B7B69621A5127EFD726 (Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8* ___0_rnd, Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ___1_values, double ___2_s, int32_t ___3_n, const RuntimeMethod* method) ;
// System.Collections.Generic.IEnumerable`1<System.Int32> MathNet.Numerics.Distributions.Zipf::SamplesUnchecked(System.Random,System.Double,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* Zipf_SamplesUnchecked_mCC16E880B53B2E7BB566C2ED1A343CB3831D7C03 (Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8* ___0_rnd, double ___1_s, int32_t ___2_n, const RuntimeMethod* method) ;
// System.Int32 System.Environment::get_CurrentManagedThreadId()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Environment_get_CurrentManagedThreadId_m66483AADCCC13272EBDCD94D31D2E52603C24BDF (const RuntimeMethod* method) ;
// System.Collections.Generic.IEnumerator`1<System.Int32> MathNet.Numerics.Distributions.Zipf/<SamplesUnchecked>d__40::System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* U3CSamplesUncheckedU3Ed__40_System_Collections_Generic_IEnumerableU3CSystem_Int32U3E_GetEnumerator_m9695B8349A4904784985C41FE8102AA7FB3A007C (U3CSamplesUncheckedU3Ed__40_t29307BD38C6FF3892A8B3F9FD768493D8F93EE8A* __this, const RuntimeMethod* method) ;
// System.Void MathNet.Numerics.Differentiation.FiniteDifferenceCoefficients::CalculateCoefficients(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void FiniteDifferenceCoefficients_CalculateCoefficients_m9049629B7D2D98DB6888ADAADD45D3988A9EE1C6 (FiniteDifferenceCoefficients_t4C297B32541755227C3C396F2EE875CD3C6369DD* __this, int32_t ___0_points, const RuntimeMethod* method) ;
// System.Void MathNet.Numerics.Differentiation.FiniteDifferenceCoefficients::set_Points(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void FiniteDifferenceCoefficients_set_Points_m53E5CB6A789DDBF44AEF29B4BE0BFFB2B8E8E0E7 (FiniteDifferenceCoefficients_t4C297B32541755227C3C396F2EE875CD3C6369DD* __this, int32_t ___0_value, const RuntimeMethod* method) ;
// System.Int32 MathNet.Numerics.Differentiation.FiniteDifferenceCoefficients::get_Points()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t FiniteDifferenceCoefficients_get_Points_mAA4ACE7A8E867B1361D8A67F5E61662943736E00_inline (FiniteDifferenceCoefficients_t4C297B32541755227C3C396F2EE875CD3C6369DD* __this, const RuntimeMethod* method) ;
// System.Void System.ArgumentOutOfRangeException::.ctor(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ArgumentOutOfRangeException__ctor_mE5B2755F0BEA043CACF915D5CE140859EE58FA66 (ArgumentOutOfRangeException_tEA2822DAF62B10EEED00E0E3A341D4BAF78CF85F* __this, String_t* ___0_paramName, String_t* ___1_message, const RuntimeMethod* method) ;
// System.Int32 System.Array::GetLength(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Array_GetLength_mFE7A9FE891DE1E07795230BE09854441CDD0E935 (RuntimeArray* __this, int32_t ___0_dimension, const RuntimeMethod* method) ;
// System.Void MathNet.Numerics.LinearAlgebra.Double.DenseMatrix::.ctor(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void DenseMatrix__ctor_m9A77ED10BA74106ADAC117999AA6C9CB9D8CDD30 (DenseMatrix_tEB7C614EBDC0021BA303ED597DC448A8662D8A9F* __this, int32_t ___0_order, const RuntimeMethod* method) ;
// System.Void MathNet.Numerics.LinearAlgebra.Matrix`1<System.Double>::set_Item(System.Int32,System.Int32,T)
inline void Matrix_1_set_Item_mC97D847F561C86DD3856B0FA098D2D0529728B67_inline (Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* __this, int32_t ___0_row, int32_t ___1_column, double ___2_value, const RuntimeMethod* method)
{
	((  void (*) (Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9*, int32_t, int32_t, double, const RuntimeMethod*))Matrix_1_set_Item_mC97D847F561C86DD3856B0FA098D2D0529728B67_gshared_inline)(__this, ___0_row, ___1_column, ___2_value, method);
}
// T MathNet.Numerics.LinearAlgebra.Matrix`1<System.Double>::get_Item(System.Int32,System.Int32)
inline double Matrix_1_get_Item_m9AC37D09D678515B98CFC7C5A3BBECAC3067D9DE_inline (Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* __this, int32_t ___0_row, int32_t ___1_column, const RuntimeMethod* method)
{
	return ((  double (*) (Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9*, int32_t, int32_t, const RuntimeMethod*))Matrix_1_get_Item_m9AC37D09D678515B98CFC7C5A3BBECAC3067D9DE_gshared_inline)(__this, ___0_row, ___1_column, method);
}
// T[,] MathNet.Numerics.LinearAlgebra.Matrix`1<System.Double>::ToArray()
inline DoubleU5BU2CU5D_tA10EAF4C451E6EBC345A8881EBB9EF9441D01AAE* Matrix_1_ToArray_m0F3DB5D9135BA3556C288F91992B1B0C390AAF72 (Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* __this, const RuntimeMethod* method)
{
	return ((  DoubleU5BU2CU5D_tA10EAF4C451E6EBC345A8881EBB9EF9441D01AAE* (*) (Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9*, const RuntimeMethod*))Matrix_1_ToArray_m0F3DB5D9135BA3556C288F91992B1B0C390AAF72_gshared)(__this, method);
}
// System.Double MathNet.Numerics.SpecialFunctions::Factorial(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double SpecialFunctions_Factorial_mA03982EFC69960F81FB44F06B8443026836FA39C (int32_t ___0_x, const RuntimeMethod* method) ;
// System.Double System.Math::Round(System.Double,System.MidpointRounding)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR double Math_Round_mAD8888A4B6E25BBA84A6C87535E68689BC4F46C8_inline (double ___0_value, int32_t ___1_mode, const RuntimeMethod* method) ;
// System.Void MathNet.Numerics.Differentiation.NumericalDerivative::.ctor(System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NumericalDerivative__ctor_m94BF5A04E867018682D56B120B89E5B00595739E (NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* __this, int32_t ___0_points, int32_t ___1_center, const RuntimeMethod* method) ;
// System.Void MathNet.Numerics.Differentiation.NumericalDerivative::set_Center(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NumericalDerivative_set_Center_mFA5EE04E3C7CF245411FF33E80928D962383513E (NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* __this, int32_t ___0_value, const RuntimeMethod* method) ;
// System.Void MathNet.Numerics.Differentiation.FiniteDifferenceCoefficients::.ctor(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void FiniteDifferenceCoefficients__ctor_mE61D6740E2C00AB440CC04A3A0A3238DCBF7E901 (FiniteDifferenceCoefficients_t4C297B32541755227C3C396F2EE875CD3C6369DD* __this, int32_t ___0_points, const RuntimeMethod* method) ;
// System.Void MathNet.Numerics.Differentiation.NumericalDerivative/<>c__DisplayClass28_0::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass28_0__ctor_mAEF3FED953F7D9BC82E503B819024AD3D38C87BA (U3CU3Ec__DisplayClass28_0_t1E475037E430264975A0956BD27AA2971F0532BC* __this, const RuntimeMethod* method) ;
// System.Void System.ArgumentNullException::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ArgumentNullException__ctor_m444AE141157E333844FC1A9500224C2F9FD24F4B (ArgumentNullException_t327031E412FAB2351B0022DD5DAD47E67E597129* __this, String_t* ___0_paramName, const RuntimeMethod* method) ;
// System.Int32 MathNet.Numerics.Differentiation.NumericalDerivative::get_Center()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t NumericalDerivative_get_Center_m2A342DC5FBB8EAA82940F5D32883217021ACECD6_inline (NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* __this, const RuntimeMethod* method) ;
// System.Double[] MathNet.Numerics.Differentiation.FiniteDifferenceCoefficients::GetCoefficients(System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* FiniteDifferenceCoefficients_GetCoefficients_m0EF0A6A58D90EFBBCD57331D42A23800EC13664E (FiniteDifferenceCoefficients_t4C297B32541755227C3C396F2EE875CD3C6369DD* __this, int32_t ___0_center, int32_t ___1_order, const RuntimeMethod* method) ;
// System.Void System.Func`3<System.Double,System.Int32,System.Double>::.ctor(System.Object,System.IntPtr)
inline void Func_3__ctor_m3CD5133CBCB6F0EA58618ADE3B4635342495E6B9 (Func_3_t4A84D23D01C9E182A3CFA36E5B7F3F13F9B82367* __this, RuntimeObject* ___0_object, intptr_t ___1_method, const RuntimeMethod* method)
{
	((  void (*) (Func_3_t4A84D23D01C9E182A3CFA36E5B7F3F13F9B82367*, RuntimeObject*, intptr_t, const RuntimeMethod*))Func_3__ctor_m3CD5133CBCB6F0EA58618ADE3B4635342495E6B9_gshared)(__this, ___0_object, ___1_method, method);
}
// System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable::Select<System.Double,System.Double>(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`3<TSource,System.Int32,TResult>)
inline RuntimeObject* Enumerable_Select_TisDouble_tE150EF3D1D43DEE85D533810AB4C742307EEDE5F_TisDouble_tE150EF3D1D43DEE85D533810AB4C742307EEDE5F_mB588D15462B1F933FD6F77574674E0999EC99B62 (RuntimeObject* ___0_source, Func_3_t4A84D23D01C9E182A3CFA36E5B7F3F13F9B82367* ___1_selector, const RuntimeMethod* method)
{
	return ((  RuntimeObject* (*) (RuntimeObject*, Func_3_t4A84D23D01C9E182A3CFA36E5B7F3F13F9B82367*, const RuntimeMethod*))Enumerable_Select_TisDouble_tE150EF3D1D43DEE85D533810AB4C742307EEDE5F_TisDouble_tE150EF3D1D43DEE85D533810AB4C742307EEDE5F_mB588D15462B1F933FD6F77574674E0999EC99B62_gshared)(___0_source, ___1_selector, method);
}
// System.Double System.Linq.Enumerable::Sum(System.Collections.Generic.IEnumerable`1<System.Double>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double Enumerable_Sum_mB4B29B0D6E567EB810D0B439945F9BC6ACC01284 (RuntimeObject* ___0_source, const RuntimeMethod* method) ;
// System.Double MathNet.Numerics.Differentiation.NumericalDerivative::CalculateStepSize(System.Int32,System.Double,System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double NumericalDerivative_CalculateStepSize_m6DD2C80785010974B05485A22594397FA6A166FB (NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* __this, int32_t ___0_points, double ___1_x, double ___2_order, const RuntimeMethod* method) ;
// System.Boolean System.Nullable`1<System.Double>::get_HasValue()
inline bool Nullable_1_get_HasValue_mC082C667C8EB3A6CA80E06BCAEA0BED00C6BC15A_inline (Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165* __this, const RuntimeMethod* method)
{
	return ((  bool (*) (Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165*, const RuntimeMethod*))Nullable_1_get_HasValue_mC082C667C8EB3A6CA80E06BCAEA0BED00C6BC15A_gshared_inline)(__this, method);
}
// T System.Nullable`1<System.Double>::get_Value()
inline double Nullable_1_get_Value_m260A5CB9269FD3E130F998A589EDAEC2E8F9EAE1 (Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165* __this, const RuntimeMethod* method)
{
	return ((  double (*) (Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165*, const RuntimeMethod*))Nullable_1_get_Value_m260A5CB9269FD3E130F998A589EDAEC2E8F9EAE1_gshared)(__this, method);
}
// TResult System.Func`2<System.Double,System.Double>::Invoke(T)
inline double Func_2_Invoke_m762147834B46FC6B99180328AD303FC3F47CCD62_inline (Func_2_t0221E9CE1FF8B8FE59AED052D562790B96F13B3D* __this, double ___0_arg, const RuntimeMethod* method)
{
	return ((  double (*) (Func_2_t0221E9CE1FF8B8FE59AED052D562790B96F13B3D*, double, const RuntimeMethod*))Func_2_Invoke_m762147834B46FC6B99180328AD303FC3F47CCD62_gshared_inline)(__this, ___0_arg, method);
}
// System.Int32 MathNet.Numerics.Differentiation.NumericalDerivative::get_Evaluations()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t NumericalDerivative_get_Evaluations_mCA8A041C5842CB4239707CB207A053D3037151FE_inline (NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* __this, const RuntimeMethod* method) ;
// System.Void MathNet.Numerics.Differentiation.NumericalDerivative::set_Evaluations(System.Int32)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void NumericalDerivative_set_Evaluations_mCCE3A9BE2B152CFFC6B9C02EEC6641E392048042_inline (NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* __this, int32_t ___0_value, const RuntimeMethod* method) ;
// System.Double MathNet.Numerics.Differentiation.NumericalDerivative::EvaluateDerivative(System.Double[],System.Int32,System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double NumericalDerivative_EvaluateDerivative_mCDBA97154622BE221740EF0643F7D685D82F1004 (NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* __this, DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* ___0_points, int32_t ___1_order, double ___2_stepSize, const RuntimeMethod* method) ;
// System.Void MathNet.Numerics.Differentiation.NumericalDerivative/<>c__DisplayClass30_0::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass30_0__ctor_mDA8A74FD9E157F81603A64A51886C3E0C7E30DDA (U3CU3Ec__DisplayClass30_0_tBBEEC61B57C35572AA699E79175C25C8F2D7AEBC* __this, const RuntimeMethod* method) ;
// System.Void System.Func`2<System.Double,System.Double>::.ctor(System.Object,System.IntPtr)
inline void Func_2__ctor_m653F26D531BA0409921E01E3994462FC75138745 (Func_2_t0221E9CE1FF8B8FE59AED052D562790B96F13B3D* __this, RuntimeObject* ___0_object, intptr_t ___1_method, const RuntimeMethod* method)
{
	((  void (*) (Func_2_t0221E9CE1FF8B8FE59AED052D562790B96F13B3D*, RuntimeObject*, intptr_t, const RuntimeMethod*))Func_2__ctor_m653F26D531BA0409921E01E3994462FC75138745_gshared)(__this, ___0_object, ___1_method, method);
}
// TResult System.Func`2<System.Double[],System.Double>::Invoke(T)
inline double Func_2_Invoke_m7442A25D41142B8F2A021318023893E3DD4DF5B8_inline (Func_2_t89B8106282004E94AE869931CD4E1DF667EB235E* __this, DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* ___0_arg, const RuntimeMethod* method)
{
	return ((  double (*) (Func_2_t89B8106282004E94AE869931CD4E1DF667EB235E*, DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE*, const RuntimeMethod*))Func_2_Invoke_mD53F0155434EDFA18B5BDAD0B0F61AC5F82EB95B_gshared_inline)(__this, ___0_arg, method);
}
// System.Void System.Nullable`1<System.Double>::.ctor(T)
inline void Nullable_1__ctor_mDE3158DD99CA7E1775A8BA276E428AF808AB8FBF (Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165* __this, double ___0_value, const RuntimeMethod* method)
{
	((  void (*) (Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165*, double, const RuntimeMethod*))Nullable_1__ctor_mDE3158DD99CA7E1775A8BA276E428AF808AB8FBF_gshared)(__this, ___0_value, method);
}
// System.Double MathNet.Numerics.Differentiation.NumericalDerivative::EvaluatePartialDerivative(System.Func`2<System.Double[],System.Double>,System.Double[],System.Int32,System.Int32,System.Nullable`1<System.Double>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double NumericalDerivative_EvaluatePartialDerivative_mDE906B586F0CCE53070CC5DCB0670419D1F22D87 (NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* __this, Func_2_t89B8106282004E94AE869931CD4E1DF667EB235E* ___0_f, DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* ___1_x, int32_t ___2_parameterIndex, int32_t ___3_order, Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165 ___4_currentValue, const RuntimeMethod* method) ;
// System.Void MathNet.Numerics.Differentiation.NumericalDerivative/<>c__DisplayClass33_0::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass33_0__ctor_mFDA3E2D1D75579B687460B56F722EEC239356AEC (U3CU3Ec__DisplayClass33_0_tBD2756287084841A3E1F1D69335FE19E47552364* __this, const RuntimeMethod* method) ;
// System.Void System.Func`2<System.Double[],System.Double>::.ctor(System.Object,System.IntPtr)
inline void Func_2__ctor_m4D03D33F7B4AF2D1131E528ACAB3A21A84741714 (Func_2_t89B8106282004E94AE869931CD4E1DF667EB235E* __this, RuntimeObject* ___0_object, intptr_t ___1_method, const RuntimeMethod* method)
{
	((  void (*) (Func_2_t89B8106282004E94AE869931CD4E1DF667EB235E*, RuntimeObject*, intptr_t, const RuntimeMethod*))Func_2__ctor_mC2F9460DBFF9A8659492AC19F4B9FCA63BFA48A8_gshared)(__this, ___0_object, ___1_method, method);
}
// System.Void MathNet.Numerics.Differentiation.NumericalDerivative/<>c__DisplayClass34_0::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass34_0__ctor_m0CA5B471C8A0BECC2E9D14DAD9229D6657599770 (U3CU3Ec__DisplayClass34_0_tF6657B44CE0DCD05291B022AFF982CF97DD5204B* __this, const RuntimeMethod* method) ;
// System.Void System.Func`2<System.Double[],System.Double[]>::.ctor(System.Object,System.IntPtr)
inline void Func_2__ctor_m2ED05A74879DCC63F0AE05AE5157CBC0E7F27F19 (Func_2_tA1A2AD8DF81B4522B8EE6DE5D7855397EAF54012* __this, RuntimeObject* ___0_object, intptr_t ___1_method, const RuntimeMethod* method)
{
	((  void (*) (Func_2_tA1A2AD8DF81B4522B8EE6DE5D7855397EAF54012*, RuntimeObject*, intptr_t, const RuntimeMethod*))Func_2__ctor_m7F8A01C0B02BC1D4063F4EB1E817F7A48562A398_gshared)(__this, ___0_object, ___1_method, method);
}
// System.Void System.Array::Copy(System.Array,System.Int32,System.Array,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Array_Copy_mB4904E17BD92E320613A3251C0205E0786B3BF41 (RuntimeArray* ___0_sourceArray, int32_t ___1_sourceIndex, RuntimeArray* ___2_destinationArray, int32_t ___3_destinationIndex, int32_t ___4_length, const RuntimeMethod* method) ;
// System.Double MathNet.Numerics.Differentiation.NumericalDerivative::EvaluateMixedPartialDerivative(System.Func`2<System.Double[],System.Double>,System.Double[],System.Int32[],System.Int32,System.Nullable`1<System.Double>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double NumericalDerivative_EvaluateMixedPartialDerivative_mB6986A98BC73CFEBD25C1203BE8DE3F1D22849CE (NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* __this, Func_2_t89B8106282004E94AE869931CD4E1DF667EB235E* ___0_f, DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* ___1_x, Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ___2_parameterIndex, int32_t ___3_order, Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165 ___4_currentValue, const RuntimeMethod* method) ;
// System.Void MathNet.Numerics.Differentiation.NumericalDerivative/<>c__DisplayClass37_0::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass37_0__ctor_mD34308515D296A888A4F1D808FCCBBBADDDB54B8 (U3CU3Ec__DisplayClass37_0_tB67C49B4F7E09BCA7E1D145A632C77D2A55C3617* __this, const RuntimeMethod* method) ;
// System.Void MathNet.Numerics.Differentiation.NumericalDerivative/<>c__DisplayClass38_0::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass38_0__ctor_m1A33209F6B18D3C7E7A353633731F2B855A86117 (U3CU3Ec__DisplayClass38_0_t09E32000AEB1ECF9C6180CB2696459BB31E78B3D* __this, const RuntimeMethod* method) ;
// MathNet.Numerics.Differentiation.StepType MathNet.Numerics.Differentiation.NumericalDerivative::get_StepType()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t NumericalDerivative_get_StepType_m9067F9BAD716966954DD4090822BF911594D592F_inline (NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* __this, const RuntimeMethod* method) ;
// System.Double MathNet.Numerics.Differentiation.NumericalDerivative::get_BaseStepSize()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR double NumericalDerivative_get_BaseStepSize_mFAE6FF2D0717BF1E60A83EB6706241C50E154F17_inline (NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* __this, const RuntimeMethod* method) ;
// System.Void MathNet.Numerics.Differentiation.NumericalDerivative::set_StepSize(System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NumericalDerivative_set_StepSize_m1D5FF4430F889F96CAFECF3F8B57FD3C109334BF (NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* __this, double ___0_value, const RuntimeMethod* method) ;
// System.Double MathNet.Numerics.Differentiation.NumericalDerivative::get_Epsilon()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR double NumericalDerivative_get_Epsilon_mAA8717E023550582F3C2D9E6A89EF3E4723479AF_inline (NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* __this, const RuntimeMethod* method) ;
// System.Void MathNet.Numerics.Differentiation.NumericalDerivative::set_BaseStepSize(System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NumericalDerivative_set_BaseStepSize_mAB871F65B8912C4DE512F44D18E83A4F2644F1F3 (NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* __this, double ___0_value, const RuntimeMethod* method) ;
// System.Double MathNet.Numerics.Differentiation.NumericalDerivative::get_StepSize()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR double NumericalDerivative_get_StepSize_m13C020A5C6ADCE52FF19373914AF86C84F3B58B5_inline (NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* __this, const RuntimeMethod* method) ;
// System.Double MathNet.Numerics.Differentiation.NumericalDerivative::EvaluateDerivative(System.Func`2<System.Double,System.Double>,System.Double,System.Int32,System.Nullable`1<System.Double>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double NumericalDerivative_EvaluateDerivative_m4D6F74A0B7826E6CD850B8D34DC3D91EA2AC0B21 (NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* __this, Func_2_t0221E9CE1FF8B8FE59AED052D562790B96F13B3D* ___0_f, double ___1_x, int32_t ___2_order, Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165 ___3_currentValue, const RuntimeMethod* method) ;
// System.Double[] MathNet.Numerics.Differentiation.NumericalDerivative::EvaluatePartialDerivative(System.Func`2<System.Double[],System.Double>[],System.Double[],System.Int32,System.Int32,System.Nullable`1<System.Double>[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* NumericalDerivative_EvaluatePartialDerivative_m365C3DB2EC65FF94BC7B14ED2787FECE64705C5C (NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* __this, Func_2U5BU5D_tAFC1A2A6571948ADB9C2BC67B555510E993FC60A* ___0_f, DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* ___1_x, int32_t ___2_parameterIndex, int32_t ___3_order, Nullable_1U5BU5D_t8608EFC3D4A79785F59C7AB124AD5FBE0F75BCF1* ___4_currentValue, const RuntimeMethod* method) ;
// System.Double[] MathNet.Numerics.Differentiation.NumericalDerivative::EvaluateMixedPartialDerivative(System.Func`2<System.Double[],System.Double>[],System.Double[],System.Int32[],System.Int32,System.Nullable`1<System.Double>[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* NumericalDerivative_EvaluateMixedPartialDerivative_mACD450152ADEA0BF5A5B5BD75A33836B66661E8E (NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* __this, Func_2U5BU5D_tAFC1A2A6571948ADB9C2BC67B555510E993FC60A* ___0_f, DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* ___1_x, Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ___2_parameterIndex, int32_t ___3_order, Nullable_1U5BU5D_t8608EFC3D4A79785F59C7AB124AD5FBE0F75BCF1* ___4_currentValue, const RuntimeMethod* method) ;
// System.Void MathNet.Numerics.Differentiation.NumericalHessian::.ctor(System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NumericalHessian__ctor_mFC1EEA412511BBEC606939B9C542F77B52AE283A (NumericalHessian_tC668F2E392EB9EDB3A980FAA9946531D5078E102* __this, int32_t ___0_points, int32_t ___1_center, const RuntimeMethod* method) ;
// System.Void MathNet.Numerics.Differentiation.NumericalDerivative::ResetEvaluations()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NumericalDerivative_ResetEvaluations_m6F6F8564E3BB74CBB55B0A4A1F16460966147057 (NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* __this, const RuntimeMethod* method) ;
// System.Void MathNet.Numerics.Differentiation.NumericalJacobian::.ctor(System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NumericalJacobian__ctor_m77ED8BEF165A927D9AF1A0195CF7D7E159C93E16 (NumericalJacobian_tC9F1ECB42F01952106C19C255A6694627F3A2D78* __this, int32_t ___0_points, int32_t ___1_center, const RuntimeMethod* method) ;
// System.Double[] MathNet.Numerics.Differentiation.NumericalJacobian::Evaluate(System.Func`2<System.Double[],System.Double>,System.Double[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* NumericalJacobian_Evaluate_mAB1B25F8143BD558F79CDC1D72C8B65BAEE6B732 (NumericalJacobian_tC9F1ECB42F01952106C19C255A6694627F3A2D78* __this, Func_2_t89B8106282004E94AE869931CD4E1DF667EB235E* ___0_f, DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* ___1_x, const RuntimeMethod* method) ;
// System.Double[] MathNet.Numerics.Differentiation.NumericalJacobian::Evaluate(System.Func`2<System.Double[],System.Double>,System.Double[],System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* NumericalJacobian_Evaluate_mE48D1D33054AB0B4AD2168BD2BD32E48DF784549 (NumericalJacobian_tC9F1ECB42F01952106C19C255A6694627F3A2D78* __this, Func_2_t89B8106282004E94AE869931CD4E1DF667EB235E* ___0_f, DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* ___1_x, double ___2_currentValue, const RuntimeMethod* method) ;
// System.Int64 System.BitConverter::DoubleToInt64Bits(System.Double)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int64_t BitConverter_DoubleToInt64Bits_m4F42741818550F9956B5FBAF88C051F4DE5B0AE6_inline (double ___0_value, const RuntimeMethod* method) ;
// System.Double System.Math::Round(System.Double,System.Int32,System.MidpointRounding)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double Math_Round_m8DB2F61CB73B9E71E54149290ABD5DC8A68890D1 (double ___0_value, int32_t ___1_digits, int32_t ___2_mode, const RuntimeMethod* method) ;
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void MathNet.Numerics.Distributions.Weibull/<>c__DisplayClass40_0::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass40_0__ctor_m9ABC3BFD18AFB3B24DC7B51C7BEA911B7BD28391 (U3CU3Ec__DisplayClass40_0_t363DAF3C516DB2996DD535161BF37F085613F359* __this, const RuntimeMethod* method) 
{
	{
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		return;
	}
}
// System.Double MathNet.Numerics.Distributions.Weibull/<>c__DisplayClass40_0::<SamplesUnchecked>b__0(System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double U3CU3Ec__DisplayClass40_0_U3CSamplesUncheckedU3Eb__0_m252105CC1E010C05B718E8225EB7292A94FAFB1A (U3CU3Ec__DisplayClass40_0_t363DAF3C516DB2996DD535161BF37F085613F359* __this, double ___0_x, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		double L_0 = __this->___scale_0;
		double L_1 = ___0_x;
		il2cpp_codegen_runtime_class_init_inline(Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		double L_2;
		L_2 = log(L_1);
		double L_3 = __this->___exponent_1;
		double L_4;
		L_4 = Math_Pow_mEAE651F0858203FBE12B72B6A53951BBD0FB5265(((-L_2)), L_3, NULL);
		return ((double)il2cpp_codegen_multiply(L_0, L_4));
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void MathNet.Numerics.Distributions.Weibull/<>c__DisplayClass41_0::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass41_0__ctor_m4052AD4019447EB6F09DFE4D119ED05246285C52 (U3CU3Ec__DisplayClass41_0_t92D7BA4BAEA3144DFB1F8B589E788EABB6682F70* __this, const RuntimeMethod* method) 
{
	{
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		return;
	}
}
// System.Void MathNet.Numerics.Distributions.Weibull/<>c__DisplayClass41_0::<SamplesUnchecked>b__0(System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass41_0_U3CSamplesUncheckedU3Eb__0_m79FCC18DFCC5FB37487B23337D90E1FBB68A0501 (U3CU3Ec__DisplayClass41_0_t92D7BA4BAEA3144DFB1F8B589E788EABB6682F70* __this, int32_t ___0_a, int32_t ___1_b, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	{
		int32_t L_0 = ___0_a;
		V_0 = L_0;
		goto IL_0030;
	}

IL_0004:
	{
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_1 = __this->___values_0;
		int32_t L_2 = V_0;
		double L_3 = __this->___scale_1;
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_4 = __this->___values_0;
		int32_t L_5 = V_0;
		NullCheck(L_4);
		int32_t L_6 = L_5;
		double L_7 = (L_4)->GetAt(static_cast<il2cpp_array_size_t>(L_6));
		il2cpp_codegen_runtime_class_init_inline(Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		double L_8;
		L_8 = log(L_7);
		double L_9 = __this->___exponent_2;
		double L_10;
		L_10 = Math_Pow_mEAE651F0858203FBE12B72B6A53951BBD0FB5265(((-L_8)), L_9, NULL);
		NullCheck(L_1);
		(L_1)->SetAt(static_cast<il2cpp_array_size_t>(L_2), (double)((double)il2cpp_codegen_multiply(L_3, L_10)));
		int32_t L_11 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_add(L_11, 1));
	}

IL_0030:
	{
		int32_t L_12 = V_0;
		int32_t L_13 = ___1_b;
		if ((((int32_t)L_12) < ((int32_t)L_13)))
		{
			goto IL_0004;
		}
	}
	{
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void MathNet.Numerics.Distributions.Wishart::.ctor(System.Double,MathNet.Numerics.LinearAlgebra.Matrix`1<System.Double>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Wishart__ctor_mC62CD6283B58C68962566B54C5F3CE7F28FC41E9 (Wishart_tDEFFEE7331AA0DC9A9F45284E8CCA00CB8012135* __this, double ___0_degreesOfFreedom, Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* ___1_scale, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Control_t697AAECEE3ACCC3477BE1CF29E56F7D224BD26DA_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SystemRandomSource_t23E2BA98CFAB3CA24F6FE6DE3B83B132A44178E4_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		il2cpp_codegen_runtime_class_init_inline(Control_t697AAECEE3ACCC3477BE1CF29E56F7D224BD26DA_il2cpp_TypeInfo_var);
		bool L_0;
		L_0 = Control_get_CheckDistributionParameters_mCCA3C1C492BF697B4A7181481C894D2E2D8CD093_inline(NULL);
		if (!L_0)
		{
			goto IL_0021;
		}
	}
	{
		double L_1 = ___0_degreesOfFreedom;
		Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* L_2 = ___1_scale;
		bool L_3;
		L_3 = Wishart_IsValidParameterSet_mAD4D0A28CE229250C2087691CA24EEDBF747F84A(L_1, L_2, NULL);
		if (L_3)
		{
			goto IL_0021;
		}
	}
	{
		ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263* L_4 = (ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263_il2cpp_TypeInfo_var)));
		NullCheck(L_4);
		ArgumentException__ctor_m026938A67AF9D36BB7ED27F80425D7194B514465(L_4, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral7B4009EABB849A075B30CF0C472DBA2C303AF1C8)), NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_4, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Wishart__ctor_mC62CD6283B58C68962566B54C5F3CE7F28FC41E9_RuntimeMethod_var)));
	}

IL_0021:
	{
		il2cpp_codegen_runtime_class_init_inline(SystemRandomSource_t23E2BA98CFAB3CA24F6FE6DE3B83B132A44178E4_il2cpp_TypeInfo_var);
		SystemRandomSource_t23E2BA98CFAB3CA24F6FE6DE3B83B132A44178E4* L_5;
		L_5 = SystemRandomSource_get_Default_mBEE95CF0D1F624A75C45F88C10523473691F4D8D(NULL);
		__this->____random_0 = L_5;
		Il2CppCodeGenWriteBarrier((void**)(&__this->____random_0), (void*)L_5);
		double L_6 = ___0_degreesOfFreedom;
		__this->____degreesOfFreedom_1 = L_6;
		Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* L_7 = ___1_scale;
		__this->____scale_2 = L_7;
		Il2CppCodeGenWriteBarrier((void**)(&__this->____scale_2), (void*)L_7);
		Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* L_8 = __this->____scale_2;
		NullCheck(L_8);
		Cholesky_1_t1FD2C6EAE804ACF062E3034A45A8D1004519525C* L_9;
		L_9 = VirtualFuncInvoker0< Cholesky_1_t1FD2C6EAE804ACF062E3034A45A8D1004519525C* >::Invoke(102 /* MathNet.Numerics.LinearAlgebra.Factorization.Cholesky`1<T> MathNet.Numerics.LinearAlgebra.Matrix`1<System.Double>::Cholesky() */, L_8);
		__this->____chol_3 = L_9;
		Il2CppCodeGenWriteBarrier((void**)(&__this->____chol_3), (void*)L_9);
		return;
	}
}
// System.Void MathNet.Numerics.Distributions.Wishart::.ctor(System.Double,MathNet.Numerics.LinearAlgebra.Matrix`1<System.Double>,System.Random)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Wishart__ctor_m10B5EB9D2F05C5B74D04729F56E98D74D284A7F8 (Wishart_tDEFFEE7331AA0DC9A9F45284E8CCA00CB8012135* __this, double ___0_degreesOfFreedom, Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* ___1_scale, Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8* ___2_randomSource, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Control_t697AAECEE3ACCC3477BE1CF29E56F7D224BD26DA_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SystemRandomSource_t23E2BA98CFAB3CA24F6FE6DE3B83B132A44178E4_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8* G_B5_0 = NULL;
	Wishart_tDEFFEE7331AA0DC9A9F45284E8CCA00CB8012135* G_B5_1 = NULL;
	Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8* G_B4_0 = NULL;
	Wishart_tDEFFEE7331AA0DC9A9F45284E8CCA00CB8012135* G_B4_1 = NULL;
	{
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		il2cpp_codegen_runtime_class_init_inline(Control_t697AAECEE3ACCC3477BE1CF29E56F7D224BD26DA_il2cpp_TypeInfo_var);
		bool L_0;
		L_0 = Control_get_CheckDistributionParameters_mCCA3C1C492BF697B4A7181481C894D2E2D8CD093_inline(NULL);
		if (!L_0)
		{
			goto IL_0021;
		}
	}
	{
		double L_1 = ___0_degreesOfFreedom;
		Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* L_2 = ___1_scale;
		bool L_3;
		L_3 = Wishart_IsValidParameterSet_mAD4D0A28CE229250C2087691CA24EEDBF747F84A(L_1, L_2, NULL);
		if (L_3)
		{
			goto IL_0021;
		}
	}
	{
		ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263* L_4 = (ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263_il2cpp_TypeInfo_var)));
		NullCheck(L_4);
		ArgumentException__ctor_m026938A67AF9D36BB7ED27F80425D7194B514465(L_4, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral7B4009EABB849A075B30CF0C472DBA2C303AF1C8)), NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_4, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Wishart__ctor_m10B5EB9D2F05C5B74D04729F56E98D74D284A7F8_RuntimeMethod_var)));
	}

IL_0021:
	{
		Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8* L_5 = ___2_randomSource;
		Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8* L_6 = L_5;
		G_B4_0 = L_6;
		G_B4_1 = __this;
		if (L_6)
		{
			G_B5_0 = L_6;
			G_B5_1 = __this;
			goto IL_002c;
		}
	}
	{
		il2cpp_codegen_runtime_class_init_inline(SystemRandomSource_t23E2BA98CFAB3CA24F6FE6DE3B83B132A44178E4_il2cpp_TypeInfo_var);
		SystemRandomSource_t23E2BA98CFAB3CA24F6FE6DE3B83B132A44178E4* L_7;
		L_7 = SystemRandomSource_get_Default_mBEE95CF0D1F624A75C45F88C10523473691F4D8D(NULL);
		G_B5_0 = ((Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8*)(L_7));
		G_B5_1 = G_B4_1;
	}

IL_002c:
	{
		NullCheck(G_B5_1);
		G_B5_1->____random_0 = G_B5_0;
		Il2CppCodeGenWriteBarrier((void**)(&G_B5_1->____random_0), (void*)G_B5_0);
		double L_8 = ___0_degreesOfFreedom;
		__this->____degreesOfFreedom_1 = L_8;
		Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* L_9 = ___1_scale;
		__this->____scale_2 = L_9;
		Il2CppCodeGenWriteBarrier((void**)(&__this->____scale_2), (void*)L_9);
		Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* L_10 = __this->____scale_2;
		NullCheck(L_10);
		Cholesky_1_t1FD2C6EAE804ACF062E3034A45A8D1004519525C* L_11;
		L_11 = VirtualFuncInvoker0< Cholesky_1_t1FD2C6EAE804ACF062E3034A45A8D1004519525C* >::Invoke(102 /* MathNet.Numerics.LinearAlgebra.Factorization.Cholesky`1<T> MathNet.Numerics.LinearAlgebra.Matrix`1<System.Double>::Cholesky() */, L_10);
		__this->____chol_3 = L_11;
		Il2CppCodeGenWriteBarrier((void**)(&__this->____chol_3), (void*)L_11);
		return;
	}
}
// System.Boolean MathNet.Numerics.Distributions.Wishart::IsValidParameterSet(System.Double,MathNet.Numerics.LinearAlgebra.Matrix`1<System.Double>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Wishart_IsValidParameterSet_mAD4D0A28CE229250C2087691CA24EEDBF747F84A (double ___0_degreesOfFreedom, Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* ___1_scale, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Matrix_1_At_mBA3B6ADE91F6541597F6BA43AD04B13E36998233_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Matrix_1_get_ColumnCount_mA9469577A4E8459338A621B987E653D241A6883B_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Matrix_1_get_RowCount_m9B54DCE02A3829F5EBD4D5D7ACF2615FCBA2A7E2_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	{
		Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* L_0 = ___1_scale;
		NullCheck(L_0);
		int32_t L_1;
		L_1 = Matrix_1_get_RowCount_m9B54DCE02A3829F5EBD4D5D7ACF2615FCBA2A7E2_inline(L_0, Matrix_1_get_RowCount_m9B54DCE02A3829F5EBD4D5D7ACF2615FCBA2A7E2_RuntimeMethod_var);
		Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* L_2 = ___1_scale;
		NullCheck(L_2);
		int32_t L_3;
		L_3 = Matrix_1_get_ColumnCount_mA9469577A4E8459338A621B987E653D241A6883B_inline(L_2, Matrix_1_get_ColumnCount_mA9469577A4E8459338A621B987E653D241A6883B_RuntimeMethod_var);
		if ((((int32_t)L_1) == ((int32_t)L_3)))
		{
			goto IL_0010;
		}
	}
	{
		return (bool)0;
	}

IL_0010:
	{
		V_0 = 0;
		goto IL_002d;
	}

IL_0014:
	{
		Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* L_4 = ___1_scale;
		int32_t L_5 = V_0;
		int32_t L_6 = V_0;
		NullCheck(L_4);
		double L_7;
		L_7 = Matrix_1_At_mBA3B6ADE91F6541597F6BA43AD04B13E36998233_inline(L_4, L_5, L_6, Matrix_1_At_mBA3B6ADE91F6541597F6BA43AD04B13E36998233_RuntimeMethod_var);
		if ((!(((double)L_7) <= ((double)(0.0)))))
		{
			goto IL_0029;
		}
	}
	{
		return (bool)0;
	}

IL_0029:
	{
		int32_t L_8 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_add(L_8, 1));
	}

IL_002d:
	{
		int32_t L_9 = V_0;
		Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* L_10 = ___1_scale;
		NullCheck(L_10);
		int32_t L_11;
		L_11 = Matrix_1_get_RowCount_m9B54DCE02A3829F5EBD4D5D7ACF2615FCBA2A7E2_inline(L_10, Matrix_1_get_RowCount_m9B54DCE02A3829F5EBD4D5D7ACF2615FCBA2A7E2_RuntimeMethod_var);
		if ((((int32_t)L_9) < ((int32_t)L_11)))
		{
			goto IL_0014;
		}
	}
	{
		double L_12 = ___0_degreesOfFreedom;
		if ((((double)L_12) <= ((double)(0.0))))
		{
			goto IL_004a;
		}
	}
	{
		double L_13 = ___0_degreesOfFreedom;
		bool L_14;
		L_14 = Double_IsNaN_mF2BC6D1FD4813179B2CAE58D29770E42830D0883_inline(L_13, NULL);
		if (!L_14)
		{
			goto IL_004c;
		}
	}

IL_004a:
	{
		return (bool)0;
	}

IL_004c:
	{
		return (bool)1;
	}
}
// System.Double MathNet.Numerics.Distributions.Wishart::get_DegreesOfFreedom()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double Wishart_get_DegreesOfFreedom_m21DD0D6F89B3DF8771195C202A0C000C67DFAAA1 (Wishart_tDEFFEE7331AA0DC9A9F45284E8CCA00CB8012135* __this, const RuntimeMethod* method) 
{
	{
		double L_0 = __this->____degreesOfFreedom_1;
		return L_0;
	}
}
// MathNet.Numerics.LinearAlgebra.Matrix`1<System.Double> MathNet.Numerics.Distributions.Wishart::get_Scale()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* Wishart_get_Scale_m9C8D82D011DB52C81079E1C885704A876D7F8082 (Wishart_tDEFFEE7331AA0DC9A9F45284E8CCA00CB8012135* __this, const RuntimeMethod* method) 
{
	{
		Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* L_0 = __this->____scale_2;
		return L_0;
	}
}
// System.String MathNet.Numerics.Distributions.Wishart::ToString()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Wishart_ToString_m2831E0DA359695038EC03C1C98F80C80511FCB23 (Wishart_tDEFFEE7331AA0DC9A9F45284E8CCA00CB8012135* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Double_tE150EF3D1D43DEE85D533810AB4C742307EEDE5F_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Matrix_1_get_ColumnCount_mA9469577A4E8459338A621B987E653D241A6883B_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Matrix_1_get_RowCount_m9B54DCE02A3829F5EBD4D5D7ACF2615FCBA2A7E2_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralC0FD9400016D989556CDADD04CCB9ED9820BF290);
		s_Il2CppMethodInitialized = true;
	}
	{
		double L_0 = __this->____degreesOfFreedom_1;
		double L_1 = L_0;
		RuntimeObject* L_2 = Box(Double_tE150EF3D1D43DEE85D533810AB4C742307EEDE5F_il2cpp_TypeInfo_var, &L_1);
		Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* L_3 = __this->____scale_2;
		NullCheck(L_3);
		int32_t L_4;
		L_4 = Matrix_1_get_RowCount_m9B54DCE02A3829F5EBD4D5D7ACF2615FCBA2A7E2_inline(L_3, Matrix_1_get_RowCount_m9B54DCE02A3829F5EBD4D5D7ACF2615FCBA2A7E2_RuntimeMethod_var);
		int32_t L_5 = L_4;
		RuntimeObject* L_6 = Box(Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C_il2cpp_TypeInfo_var, &L_5);
		Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* L_7 = __this->____scale_2;
		NullCheck(L_7);
		int32_t L_8;
		L_8 = Matrix_1_get_ColumnCount_mA9469577A4E8459338A621B987E653D241A6883B_inline(L_7, Matrix_1_get_ColumnCount_mA9469577A4E8459338A621B987E653D241A6883B_RuntimeMethod_var);
		int32_t L_9 = L_8;
		RuntimeObject* L_10 = Box(Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C_il2cpp_TypeInfo_var, &L_9);
		String_t* L_11;
		L_11 = String_Format_mA0534D6E2AE4D67A6BD8D45B3321323930EB930C(_stringLiteralC0FD9400016D989556CDADD04CCB9ED9820BF290, L_2, L_6, L_10, NULL);
		return L_11;
	}
}
// System.Random MathNet.Numerics.Distributions.Wishart::get_RandomSource()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8* Wishart_get_RandomSource_m2FD439F2EA4CD9FE9D99EDE884771950DCA00797 (Wishart_tDEFFEE7331AA0DC9A9F45284E8CCA00CB8012135* __this, const RuntimeMethod* method) 
{
	{
		Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8* L_0 = __this->____random_0;
		return L_0;
	}
}
// System.Void MathNet.Numerics.Distributions.Wishart::set_RandomSource(System.Random)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Wishart_set_RandomSource_m0A047CB290E32B76B4663B3CCE85E774E1E54C5F (Wishart_tDEFFEE7331AA0DC9A9F45284E8CCA00CB8012135* __this, Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8* ___0_value, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SystemRandomSource_t23E2BA98CFAB3CA24F6FE6DE3B83B132A44178E4_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8* G_B2_0 = NULL;
	Wishart_tDEFFEE7331AA0DC9A9F45284E8CCA00CB8012135* G_B2_1 = NULL;
	Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8* G_B1_0 = NULL;
	Wishart_tDEFFEE7331AA0DC9A9F45284E8CCA00CB8012135* G_B1_1 = NULL;
	{
		Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8* L_0 = ___0_value;
		Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8* L_1 = L_0;
		G_B1_0 = L_1;
		G_B1_1 = __this;
		if (L_1)
		{
			G_B2_0 = L_1;
			G_B2_1 = __this;
			goto IL_000b;
		}
	}
	{
		il2cpp_codegen_runtime_class_init_inline(SystemRandomSource_t23E2BA98CFAB3CA24F6FE6DE3B83B132A44178E4_il2cpp_TypeInfo_var);
		SystemRandomSource_t23E2BA98CFAB3CA24F6FE6DE3B83B132A44178E4* L_2;
		L_2 = SystemRandomSource_get_Default_mBEE95CF0D1F624A75C45F88C10523473691F4D8D(NULL);
		G_B2_0 = ((Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8*)(L_2));
		G_B2_1 = G_B1_1;
	}

IL_000b:
	{
		NullCheck(G_B2_1);
		G_B2_1->____random_0 = G_B2_0;
		Il2CppCodeGenWriteBarrier((void**)(&G_B2_1->____random_0), (void*)G_B2_0);
		return;
	}
}
// MathNet.Numerics.LinearAlgebra.Matrix`1<System.Double> MathNet.Numerics.Distributions.Wishart::get_Mean()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* Wishart_get_Mean_m5D24983AFDD34D55FF64D59999496796F0542BC1 (Wishart_tDEFFEE7331AA0DC9A9F45284E8CCA00CB8012135* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Matrix_1_op_Multiply_m39042F5DB6C9BCAC26059652232B314517464584_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		double L_0 = __this->____degreesOfFreedom_1;
		Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* L_1 = __this->____scale_2;
		il2cpp_codegen_runtime_class_init_inline(Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9_il2cpp_TypeInfo_var);
		Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* L_2;
		L_2 = Matrix_1_op_Multiply_m39042F5DB6C9BCAC26059652232B314517464584(L_0, L_1, Matrix_1_op_Multiply_m39042F5DB6C9BCAC26059652232B314517464584_RuntimeMethod_var);
		return L_2;
	}
}
// MathNet.Numerics.LinearAlgebra.Matrix`1<System.Double> MathNet.Numerics.Distributions.Wishart::get_Mode()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* Wishart_get_Mode_m537282F2F298EDAF1FB9EF28A321A71A613910F8 (Wishart_tDEFFEE7331AA0DC9A9F45284E8CCA00CB8012135* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Matrix_1_get_RowCount_m9B54DCE02A3829F5EBD4D5D7ACF2615FCBA2A7E2_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Matrix_1_op_Multiply_m39042F5DB6C9BCAC26059652232B314517464584_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		double L_0 = __this->____degreesOfFreedom_1;
		Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* L_1 = __this->____scale_2;
		NullCheck(L_1);
		int32_t L_2;
		L_2 = Matrix_1_get_RowCount_m9B54DCE02A3829F5EBD4D5D7ACF2615FCBA2A7E2_inline(L_1, Matrix_1_get_RowCount_m9B54DCE02A3829F5EBD4D5D7ACF2615FCBA2A7E2_RuntimeMethod_var);
		Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* L_3 = __this->____scale_2;
		il2cpp_codegen_runtime_class_init_inline(Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9_il2cpp_TypeInfo_var);
		Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* L_4;
		L_4 = Matrix_1_op_Multiply_m39042F5DB6C9BCAC26059652232B314517464584(((double)il2cpp_codegen_subtract(((double)il2cpp_codegen_subtract(L_0, ((double)L_2))), (1.0))), L_3, Matrix_1_op_Multiply_m39042F5DB6C9BCAC26059652232B314517464584_RuntimeMethod_var);
		return L_4;
	}
}
// MathNet.Numerics.LinearAlgebra.Matrix`1<System.Double> MathNet.Numerics.Distributions.Wishart::get_Variance()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* Wishart_get_Variance_mEBAEBBA5D480840B40249F7B58C3907D98CAA626 (Wishart_tDEFFEE7331AA0DC9A9F45284E8CCA00CB8012135* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Func_3_t057050D6922BDFD2DA39811D38124A65D97E389C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&MatrixBuilder_1_Dense_mB6F63A6F6EF5CBA2F7670D858050EE99C7F2C258_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Matrix_1_get_ColumnCount_mA9469577A4E8459338A621B987E653D241A6883B_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Matrix_1_get_RowCount_m9B54DCE02A3829F5EBD4D5D7ACF2615FCBA2A7E2_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Wishart_U3Cget_VarianceU3Eb__20_0_mA19341F95BD2B87A28AF4A3A03A135375EC954B8_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		il2cpp_codegen_runtime_class_init_inline(Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9_il2cpp_TypeInfo_var);
		MatrixBuilder_1_tB265D6E40F33E9A311724A5F2EDB8C5F71621C2A* L_0 = ((Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9_StaticFields*)il2cpp_codegen_static_fields_for(Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9_il2cpp_TypeInfo_var))->___Build_2;
		Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* L_1 = __this->____scale_2;
		NullCheck(L_1);
		int32_t L_2;
		L_2 = Matrix_1_get_RowCount_m9B54DCE02A3829F5EBD4D5D7ACF2615FCBA2A7E2_inline(L_1, Matrix_1_get_RowCount_m9B54DCE02A3829F5EBD4D5D7ACF2615FCBA2A7E2_RuntimeMethod_var);
		Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* L_3 = __this->____scale_2;
		NullCheck(L_3);
		int32_t L_4;
		L_4 = Matrix_1_get_ColumnCount_mA9469577A4E8459338A621B987E653D241A6883B_inline(L_3, Matrix_1_get_ColumnCount_mA9469577A4E8459338A621B987E653D241A6883B_RuntimeMethod_var);
		Func_3_t057050D6922BDFD2DA39811D38124A65D97E389C* L_5 = (Func_3_t057050D6922BDFD2DA39811D38124A65D97E389C*)il2cpp_codegen_object_new(Func_3_t057050D6922BDFD2DA39811D38124A65D97E389C_il2cpp_TypeInfo_var);
		NullCheck(L_5);
		Func_3__ctor_m7937C139834AD053DE8E365BDD625EF16A628D7D(L_5, __this, (intptr_t)((void*)Wishart_U3Cget_VarianceU3Eb__20_0_mA19341F95BD2B87A28AF4A3A03A135375EC954B8_RuntimeMethod_var), NULL);
		NullCheck(L_0);
		Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* L_6;
		L_6 = MatrixBuilder_1_Dense_mB6F63A6F6EF5CBA2F7670D858050EE99C7F2C258(L_0, L_2, L_4, L_5, MatrixBuilder_1_Dense_mB6F63A6F6EF5CBA2F7670D858050EE99C7F2C258_RuntimeMethod_var);
		return L_6;
	}
}
// System.Double MathNet.Numerics.Distributions.Wishart::Density(MathNet.Numerics.LinearAlgebra.Matrix`1<System.Double>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double Wishart_Density_mD3C1ABBCB81C1824843858DD6F7B0CBE93FE7A1B (Wishart_tDEFFEE7331AA0DC9A9F45284E8CCA00CB8012135* __this, Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* ___0_x, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Matrix_1_get_ColumnCount_mA9469577A4E8459338A621B987E653D241A6883B_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Matrix_1_get_RowCount_m9B54DCE02A3829F5EBD4D5D7ACF2615FCBA2A7E2_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SpecialFunctions_tC2E7545045D2156631D348A56D08F8F5D34545DA_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	double V_1 = 0.0;
	Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* V_2 = NULL;
	double V_3 = 0.0;
	int32_t V_4 = 0;
	{
		Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* L_0 = __this->____scale_2;
		NullCheck(L_0);
		int32_t L_1;
		L_1 = Matrix_1_get_RowCount_m9B54DCE02A3829F5EBD4D5D7ACF2615FCBA2A7E2_inline(L_0, Matrix_1_get_RowCount_m9B54DCE02A3829F5EBD4D5D7ACF2615FCBA2A7E2_RuntimeMethod_var);
		V_0 = L_1;
		Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* L_2 = ___0_x;
		NullCheck(L_2);
		int32_t L_3;
		L_3 = Matrix_1_get_RowCount_m9B54DCE02A3829F5EBD4D5D7ACF2615FCBA2A7E2_inline(L_2, Matrix_1_get_RowCount_m9B54DCE02A3829F5EBD4D5D7ACF2615FCBA2A7E2_RuntimeMethod_var);
		int32_t L_4 = V_0;
		if ((!(((uint32_t)L_3) == ((uint32_t)L_4))))
		{
			goto IL_001e;
		}
	}
	{
		Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* L_5 = ___0_x;
		NullCheck(L_5);
		int32_t L_6;
		L_6 = Matrix_1_get_ColumnCount_mA9469577A4E8459338A621B987E653D241A6883B_inline(L_5, Matrix_1_get_ColumnCount_mA9469577A4E8459338A621B987E653D241A6883B_RuntimeMethod_var);
		int32_t L_7 = V_0;
		if ((((int32_t)L_6) == ((int32_t)L_7)))
		{
			goto IL_0030;
		}
	}

IL_001e:
	{
		Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* L_8 = ___0_x;
		Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* L_9 = __this->____scale_2;
		il2cpp_codegen_runtime_class_init_inline(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9_il2cpp_TypeInfo_var)));
		Exception_t* L_10;
		L_10 = Matrix_1_DimensionsDontMatch_TisArgumentOutOfRangeException_tEA2822DAF62B10EEED00E0E3A341D4BAF78CF85F_m4F81149F91232A646B909C1F429796AE05751321(L_8, L_9, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral062DB096C728515E033CF8C48A1C1F0B9A79384B)), ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Matrix_1_DimensionsDontMatch_TisArgumentOutOfRangeException_tEA2822DAF62B10EEED00E0E3A341D4BAF78CF85F_m4F81149F91232A646B909C1F429796AE05751321_RuntimeMethod_var)));
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_10, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Wishart_Density_mD3C1ABBCB81C1824843858DD6F7B0CBE93FE7A1B_RuntimeMethod_var)));
	}

IL_0030:
	{
		Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* L_11 = ___0_x;
		NullCheck(L_11);
		double L_12;
		L_12 = VirtualFuncInvoker0< double >::Invoke(64 /* T MathNet.Numerics.LinearAlgebra.Matrix`1<System.Double>::Determinant() */, L_11);
		V_1 = L_12;
		Cholesky_1_t1FD2C6EAE804ACF062E3034A45A8D1004519525C* L_13 = __this->____chol_3;
		Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* L_14 = ___0_x;
		NullCheck(L_13);
		Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* L_15;
		L_15 = VirtualFuncInvoker1< Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9*, Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* >::Invoke(11 /* MathNet.Numerics.LinearAlgebra.Matrix`1<T> MathNet.Numerics.LinearAlgebra.Factorization.Cholesky`1<System.Double>::Solve(MathNet.Numerics.LinearAlgebra.Matrix`1<T>) */, L_13, L_14);
		V_2 = L_15;
		int32_t L_16 = V_0;
		int32_t L_17 = V_0;
		il2cpp_codegen_runtime_class_init_inline(Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		double L_18;
		L_18 = Math_Pow_mEAE651F0858203FBE12B72B6A53951BBD0FB5265((3.1415926535897931), ((double)(((double)il2cpp_codegen_multiply(((double)L_16), ((double)il2cpp_codegen_subtract(((double)L_17), (1.0)))))/(4.0))), NULL);
		V_3 = L_18;
		V_4 = 1;
		goto IL_009d;
	}

IL_0071:
	{
		double L_19 = V_3;
		double L_20 = __this->____degreesOfFreedom_1;
		int32_t L_21 = V_4;
		il2cpp_codegen_runtime_class_init_inline(SpecialFunctions_tC2E7545045D2156631D348A56D08F8F5D34545DA_il2cpp_TypeInfo_var);
		double L_22;
		L_22 = SpecialFunctions_Gamma_mC906224A9C8758F3C91964E0C7A1C780410A41D4(((double)(((double)il2cpp_codegen_subtract(((double)il2cpp_codegen_add(L_20, (1.0))), ((double)L_21)))/(2.0))), NULL);
		V_3 = ((double)il2cpp_codegen_multiply(L_19, L_22));
		int32_t L_23 = V_4;
		V_4 = ((int32_t)il2cpp_codegen_add(L_23, 1));
	}

IL_009d:
	{
		int32_t L_24 = V_4;
		int32_t L_25 = V_0;
		if ((((int32_t)L_24) <= ((int32_t)L_25)))
		{
			goto IL_0071;
		}
	}
	{
		double L_26 = V_1;
		double L_27 = __this->____degreesOfFreedom_1;
		int32_t L_28 = V_0;
		il2cpp_codegen_runtime_class_init_inline(Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		double L_29;
		L_29 = Math_Pow_mEAE651F0858203FBE12B72B6A53951BBD0FB5265(L_26, ((double)(((double)il2cpp_codegen_subtract(((double)il2cpp_codegen_subtract(L_27, ((double)L_28))), (1.0)))/(2.0))), NULL);
		Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* L_30 = V_2;
		NullCheck(L_30);
		double L_31;
		L_31 = VirtualFuncInvoker0< double >::Invoke(61 /* T MathNet.Numerics.LinearAlgebra.Matrix`1<System.Double>::Trace() */, L_30);
		double L_32;
		L_32 = exp(((double)il2cpp_codegen_multiply((-0.5), L_31)));
		double L_33 = __this->____degreesOfFreedom_1;
		int32_t L_34 = V_0;
		double L_35;
		L_35 = Math_Pow_mEAE651F0858203FBE12B72B6A53951BBD0FB5265((2.0), ((double)(((double)il2cpp_codegen_multiply(L_33, ((double)L_34)))/(2.0))), NULL);
		Cholesky_1_t1FD2C6EAE804ACF062E3034A45A8D1004519525C* L_36 = __this->____chol_3;
		NullCheck(L_36);
		double L_37;
		L_37 = VirtualFuncInvoker0< double >::Invoke(8 /* T MathNet.Numerics.LinearAlgebra.Factorization.Cholesky`1<System.Double>::get_Determinant() */, L_36);
		double L_38 = __this->____degreesOfFreedom_1;
		double L_39;
		L_39 = Math_Pow_mEAE651F0858203FBE12B72B6A53951BBD0FB5265(L_37, ((double)(L_38/(2.0))), NULL);
		double L_40 = V_3;
		return ((double)(((double)(((double)(((double)il2cpp_codegen_multiply(L_29, L_32))/L_35))/L_39))/L_40));
	}
}
// MathNet.Numerics.LinearAlgebra.Matrix`1<System.Double> MathNet.Numerics.Distributions.Wishart::Sample()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* Wishart_Sample_mBDAAECE5DD556B39577D7E581953828500345ADC (Wishart_tDEFFEE7331AA0DC9A9F45284E8CCA00CB8012135* __this, const RuntimeMethod* method) 
{
	{
		Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8* L_0;
		L_0 = Wishart_get_RandomSource_m2FD439F2EA4CD9FE9D99EDE884771950DCA00797_inline(__this, NULL);
		double L_1 = __this->____degreesOfFreedom_1;
		Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* L_2 = __this->____scale_2;
		Cholesky_1_t1FD2C6EAE804ACF062E3034A45A8D1004519525C* L_3 = __this->____chol_3;
		Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* L_4;
		L_4 = Wishart_DoSample_m1E9ECF30C383E6AAC800B6A5B02A82015652DE89(L_0, L_1, L_2, L_3, NULL);
		return L_4;
	}
}
// MathNet.Numerics.LinearAlgebra.Matrix`1<System.Double> MathNet.Numerics.Distributions.Wishart::Sample(System.Random,System.Double,MathNet.Numerics.LinearAlgebra.Matrix`1<System.Double>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* Wishart_Sample_mAA9D8443C95062146BDAE4F1821F2AB107EF7917 (Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8* ___0_rnd, double ___1_degreesOfFreedom, Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* ___2_scale, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Control_t697AAECEE3ACCC3477BE1CF29E56F7D224BD26DA_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		il2cpp_codegen_runtime_class_init_inline(Control_t697AAECEE3ACCC3477BE1CF29E56F7D224BD26DA_il2cpp_TypeInfo_var);
		bool L_0;
		L_0 = Control_get_CheckDistributionParameters_mCCA3C1C492BF697B4A7181481C894D2E2D8CD093_inline(NULL);
		if (!L_0)
		{
			goto IL_001b;
		}
	}
	{
		double L_1 = ___1_degreesOfFreedom;
		Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* L_2 = ___2_scale;
		bool L_3;
		L_3 = Wishart_IsValidParameterSet_mAD4D0A28CE229250C2087691CA24EEDBF747F84A(L_1, L_2, NULL);
		if (L_3)
		{
			goto IL_001b;
		}
	}
	{
		ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263* L_4 = (ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263_il2cpp_TypeInfo_var)));
		NullCheck(L_4);
		ArgumentException__ctor_m026938A67AF9D36BB7ED27F80425D7194B514465(L_4, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral7B4009EABB849A075B30CF0C472DBA2C303AF1C8)), NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_4, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Wishart_Sample_mAA9D8443C95062146BDAE4F1821F2AB107EF7917_RuntimeMethod_var)));
	}

IL_001b:
	{
		Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8* L_5 = ___0_rnd;
		double L_6 = ___1_degreesOfFreedom;
		Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* L_7 = ___2_scale;
		Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* L_8 = ___2_scale;
		NullCheck(L_8);
		Cholesky_1_t1FD2C6EAE804ACF062E3034A45A8D1004519525C* L_9;
		L_9 = VirtualFuncInvoker0< Cholesky_1_t1FD2C6EAE804ACF062E3034A45A8D1004519525C* >::Invoke(102 /* MathNet.Numerics.LinearAlgebra.Factorization.Cholesky`1<T> MathNet.Numerics.LinearAlgebra.Matrix`1<System.Double>::Cholesky() */, L_8);
		Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* L_10;
		L_10 = Wishart_DoSample_m1E9ECF30C383E6AAC800B6A5B02A82015652DE89(L_5, L_6, L_7, L_9, NULL);
		return L_10;
	}
}
// MathNet.Numerics.LinearAlgebra.Matrix`1<System.Double> MathNet.Numerics.Distributions.Wishart::DoSample(System.Random,System.Double,MathNet.Numerics.LinearAlgebra.Matrix`1<System.Double>,MathNet.Numerics.LinearAlgebra.Factorization.Cholesky`1<System.Double>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* Wishart_DoSample_m1E9ECF30C383E6AAC800B6A5B02A82015652DE89 (Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8* ___0_rnd, double ___1_degreesOfFreedom, Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* ___2_scale, Cholesky_1_t1FD2C6EAE804ACF062E3034A45A8D1004519525C* ___3_chol, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Cholesky_1_get_Factor_m0DAB4879B1C18A503BC02DB1055250A8611C5CA7_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&DenseMatrix_tEB7C614EBDC0021BA303ED597DC448A8662D8A9F_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Matrix_1_At_m3510B6B24011AF518E2720B108836BF602246877_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Matrix_1_Transpose_m7A760B1D7F8E54788932F964F865D0398171D74A_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Matrix_1_get_RowCount_m9B54DCE02A3829F5EBD4D5D7ACF2615FCBA2A7E2_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Matrix_1_op_Multiply_mA80E4A79BDCADD1707F7C2BBFDDB8F3C9709B790_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	DenseMatrix_tEB7C614EBDC0021BA303ED597DC448A8662D8A9F* V_1 = NULL;
	Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* V_2 = NULL;
	int32_t V_3 = 0;
	int32_t V_4 = 0;
	int32_t V_5 = 0;
	{
		Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* L_0 = ___2_scale;
		NullCheck(L_0);
		int32_t L_1;
		L_1 = Matrix_1_get_RowCount_m9B54DCE02A3829F5EBD4D5D7ACF2615FCBA2A7E2_inline(L_0, Matrix_1_get_RowCount_m9B54DCE02A3829F5EBD4D5D7ACF2615FCBA2A7E2_RuntimeMethod_var);
		V_0 = L_1;
		int32_t L_2 = V_0;
		int32_t L_3 = V_0;
		DenseMatrix_tEB7C614EBDC0021BA303ED597DC448A8662D8A9F* L_4 = (DenseMatrix_tEB7C614EBDC0021BA303ED597DC448A8662D8A9F*)il2cpp_codegen_object_new(DenseMatrix_tEB7C614EBDC0021BA303ED597DC448A8662D8A9F_il2cpp_TypeInfo_var);
		NullCheck(L_4);
		DenseMatrix__ctor_mE46D680928BE6324897DC27821012A7B854595E9(L_4, L_2, L_3, NULL);
		V_1 = L_4;
		V_3 = 0;
		goto IL_0041;
	}

IL_0013:
	{
		DenseMatrix_tEB7C614EBDC0021BA303ED597DC448A8662D8A9F* L_5 = V_1;
		int32_t L_6 = V_3;
		int32_t L_7 = V_3;
		Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8* L_8 = ___0_rnd;
		double L_9 = ___1_degreesOfFreedom;
		int32_t L_10 = V_3;
		double L_11;
		L_11 = Gamma_Sample_m539642CA16B45E050594513BB19DAFC637C01633(L_8, ((double)(((double)il2cpp_codegen_subtract(L_9, ((double)L_10)))/(2.0))), (0.5), NULL);
		il2cpp_codegen_runtime_class_init_inline(Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		double L_12;
		L_12 = sqrt(L_11);
		NullCheck(L_5);
		Matrix_1_At_m3510B6B24011AF518E2720B108836BF602246877_inline(L_5, L_6, L_7, L_12, Matrix_1_At_m3510B6B24011AF518E2720B108836BF602246877_RuntimeMethod_var);
		int32_t L_13 = V_3;
		V_3 = ((int32_t)il2cpp_codegen_add(L_13, 1));
	}

IL_0041:
	{
		int32_t L_14 = V_3;
		int32_t L_15 = V_0;
		if ((((int32_t)L_14) < ((int32_t)L_15)))
		{
			goto IL_0013;
		}
	}
	{
		V_4 = 1;
		goto IL_0083;
	}

IL_004a:
	{
		V_5 = 0;
		goto IL_0077;
	}

IL_004f:
	{
		DenseMatrix_tEB7C614EBDC0021BA303ED597DC448A8662D8A9F* L_16 = V_1;
		int32_t L_17 = V_4;
		int32_t L_18 = V_5;
		Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8* L_19 = ___0_rnd;
		double L_20;
		L_20 = Normal_Sample_m2811DDE0BBC677EFE70737954FE50B21CBCBC4E2(L_19, (0.0), (1.0), NULL);
		NullCheck(L_16);
		Matrix_1_At_m3510B6B24011AF518E2720B108836BF602246877_inline(L_16, L_17, L_18, L_20, Matrix_1_At_m3510B6B24011AF518E2720B108836BF602246877_RuntimeMethod_var);
		int32_t L_21 = V_5;
		V_5 = ((int32_t)il2cpp_codegen_add(L_21, 1));
	}

IL_0077:
	{
		int32_t L_22 = V_5;
		int32_t L_23 = V_4;
		if ((((int32_t)L_22) < ((int32_t)L_23)))
		{
			goto IL_004f;
		}
	}
	{
		int32_t L_24 = V_4;
		V_4 = ((int32_t)il2cpp_codegen_add(L_24, 1));
	}

IL_0083:
	{
		int32_t L_25 = V_4;
		int32_t L_26 = V_0;
		if ((((int32_t)L_25) < ((int32_t)L_26)))
		{
			goto IL_004a;
		}
	}
	{
		Cholesky_1_t1FD2C6EAE804ACF062E3034A45A8D1004519525C* L_27 = ___3_chol;
		NullCheck(L_27);
		Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* L_28;
		L_28 = Cholesky_1_get_Factor_m0DAB4879B1C18A503BC02DB1055250A8611C5CA7_inline(L_27, Cholesky_1_get_Factor_m0DAB4879B1C18A503BC02DB1055250A8611C5CA7_RuntimeMethod_var);
		V_2 = L_28;
		Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* L_29 = V_2;
		DenseMatrix_tEB7C614EBDC0021BA303ED597DC448A8662D8A9F* L_30 = V_1;
		il2cpp_codegen_runtime_class_init_inline(Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9_il2cpp_TypeInfo_var);
		Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* L_31;
		L_31 = Matrix_1_op_Multiply_mA80E4A79BDCADD1707F7C2BBFDDB8F3C9709B790(L_29, L_30, Matrix_1_op_Multiply_mA80E4A79BDCADD1707F7C2BBFDDB8F3C9709B790_RuntimeMethod_var);
		DenseMatrix_tEB7C614EBDC0021BA303ED597DC448A8662D8A9F* L_32 = V_1;
		NullCheck(L_32);
		Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* L_33;
		L_33 = Matrix_1_Transpose_m7A760B1D7F8E54788932F964F865D0398171D74A(L_32, Matrix_1_Transpose_m7A760B1D7F8E54788932F964F865D0398171D74A_RuntimeMethod_var);
		Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* L_34;
		L_34 = Matrix_1_op_Multiply_mA80E4A79BDCADD1707F7C2BBFDDB8F3C9709B790(L_31, L_33, Matrix_1_op_Multiply_mA80E4A79BDCADD1707F7C2BBFDDB8F3C9709B790_RuntimeMethod_var);
		Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* L_35 = V_2;
		NullCheck(L_35);
		Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* L_36;
		L_36 = Matrix_1_Transpose_m7A760B1D7F8E54788932F964F865D0398171D74A(L_35, Matrix_1_Transpose_m7A760B1D7F8E54788932F964F865D0398171D74A_RuntimeMethod_var);
		Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* L_37;
		L_37 = Matrix_1_op_Multiply_mA80E4A79BDCADD1707F7C2BBFDDB8F3C9709B790(L_34, L_36, Matrix_1_op_Multiply_mA80E4A79BDCADD1707F7C2BBFDDB8F3C9709B790_RuntimeMethod_var);
		return L_37;
	}
}
// System.Double MathNet.Numerics.Distributions.Wishart::<get_Variance>b__20_0(System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double Wishart_U3Cget_VarianceU3Eb__20_0_mA19341F95BD2B87A28AF4A3A03A135375EC954B8 (Wishart_tDEFFEE7331AA0DC9A9F45284E8CCA00CB8012135* __this, int32_t ___0_i, int32_t ___1_j, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Matrix_1_At_mBA3B6ADE91F6541597F6BA43AD04B13E36998233_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		double L_0 = __this->____degreesOfFreedom_1;
		Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* L_1 = __this->____scale_2;
		int32_t L_2 = ___0_i;
		int32_t L_3 = ___1_j;
		NullCheck(L_1);
		double L_4;
		L_4 = Matrix_1_At_mBA3B6ADE91F6541597F6BA43AD04B13E36998233_inline(L_1, L_2, L_3, Matrix_1_At_mBA3B6ADE91F6541597F6BA43AD04B13E36998233_RuntimeMethod_var);
		Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* L_5 = __this->____scale_2;
		int32_t L_6 = ___0_i;
		int32_t L_7 = ___1_j;
		NullCheck(L_5);
		double L_8;
		L_8 = Matrix_1_At_mBA3B6ADE91F6541597F6BA43AD04B13E36998233_inline(L_5, L_6, L_7, Matrix_1_At_mBA3B6ADE91F6541597F6BA43AD04B13E36998233_RuntimeMethod_var);
		Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* L_9 = __this->____scale_2;
		int32_t L_10 = ___0_i;
		int32_t L_11 = ___0_i;
		NullCheck(L_9);
		double L_12;
		L_12 = Matrix_1_At_mBA3B6ADE91F6541597F6BA43AD04B13E36998233_inline(L_9, L_10, L_11, Matrix_1_At_mBA3B6ADE91F6541597F6BA43AD04B13E36998233_RuntimeMethod_var);
		Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* L_13 = __this->____scale_2;
		int32_t L_14 = ___1_j;
		int32_t L_15 = ___1_j;
		NullCheck(L_13);
		double L_16;
		L_16 = Matrix_1_At_mBA3B6ADE91F6541597F6BA43AD04B13E36998233_inline(L_13, L_14, L_15, Matrix_1_At_mBA3B6ADE91F6541597F6BA43AD04B13E36998233_RuntimeMethod_var);
		return ((double)il2cpp_codegen_multiply(L_0, ((double)il2cpp_codegen_add(((double)il2cpp_codegen_multiply(L_4, L_8)), ((double)il2cpp_codegen_multiply(L_12, L_16))))));
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void MathNet.Numerics.Distributions.Zipf::.ctor(System.Double,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Zipf__ctor_mCDD01AF4F0DD61A3EDE6B26F4AF6A631A39B6949 (Zipf_t533A437DA6EFB62CFF2FB4B397A2636242D87023* __this, double ___0_s, int32_t ___1_n, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SystemRandomSource_t23E2BA98CFAB3CA24F6FE6DE3B83B132A44178E4_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		double L_0 = ___0_s;
		int32_t L_1 = ___1_n;
		bool L_2;
		L_2 = Zipf_IsValidParameterSet_mCBA918E502E3B0CD3CE08036B50C83015074D8B3(L_0, L_1, NULL);
		if (L_2)
		{
			goto IL_001a;
		}
	}
	{
		ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263* L_3 = (ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263_il2cpp_TypeInfo_var)));
		NullCheck(L_3);
		ArgumentException__ctor_m026938A67AF9D36BB7ED27F80425D7194B514465(L_3, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral7B4009EABB849A075B30CF0C472DBA2C303AF1C8)), NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_3, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Zipf__ctor_mCDD01AF4F0DD61A3EDE6B26F4AF6A631A39B6949_RuntimeMethod_var)));
	}

IL_001a:
	{
		il2cpp_codegen_runtime_class_init_inline(SystemRandomSource_t23E2BA98CFAB3CA24F6FE6DE3B83B132A44178E4_il2cpp_TypeInfo_var);
		SystemRandomSource_t23E2BA98CFAB3CA24F6FE6DE3B83B132A44178E4* L_4;
		L_4 = SystemRandomSource_get_Default_mBEE95CF0D1F624A75C45F88C10523473691F4D8D(NULL);
		__this->____random_0 = L_4;
		Il2CppCodeGenWriteBarrier((void**)(&__this->____random_0), (void*)L_4);
		double L_5 = ___0_s;
		__this->____s_1 = L_5;
		int32_t L_6 = ___1_n;
		__this->____n_2 = L_6;
		return;
	}
}
// System.Void MathNet.Numerics.Distributions.Zipf::.ctor(System.Double,System.Int32,System.Random)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Zipf__ctor_mDBCEE0A4D63457EBA98FD967FC0EA2DF649DAAD8 (Zipf_t533A437DA6EFB62CFF2FB4B397A2636242D87023* __this, double ___0_s, int32_t ___1_n, Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8* ___2_randomSource, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SystemRandomSource_t23E2BA98CFAB3CA24F6FE6DE3B83B132A44178E4_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8* G_B4_0 = NULL;
	Zipf_t533A437DA6EFB62CFF2FB4B397A2636242D87023* G_B4_1 = NULL;
	Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8* G_B3_0 = NULL;
	Zipf_t533A437DA6EFB62CFF2FB4B397A2636242D87023* G_B3_1 = NULL;
	{
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		double L_0 = ___0_s;
		int32_t L_1 = ___1_n;
		bool L_2;
		L_2 = Zipf_IsValidParameterSet_mCBA918E502E3B0CD3CE08036B50C83015074D8B3(L_0, L_1, NULL);
		if (L_2)
		{
			goto IL_001a;
		}
	}
	{
		ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263* L_3 = (ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263_il2cpp_TypeInfo_var)));
		NullCheck(L_3);
		ArgumentException__ctor_m026938A67AF9D36BB7ED27F80425D7194B514465(L_3, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral7B4009EABB849A075B30CF0C472DBA2C303AF1C8)), NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_3, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Zipf__ctor_mDBCEE0A4D63457EBA98FD967FC0EA2DF649DAAD8_RuntimeMethod_var)));
	}

IL_001a:
	{
		Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8* L_4 = ___2_randomSource;
		Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8* L_5 = L_4;
		G_B3_0 = L_5;
		G_B3_1 = __this;
		if (L_5)
		{
			G_B4_0 = L_5;
			G_B4_1 = __this;
			goto IL_0025;
		}
	}
	{
		il2cpp_codegen_runtime_class_init_inline(SystemRandomSource_t23E2BA98CFAB3CA24F6FE6DE3B83B132A44178E4_il2cpp_TypeInfo_var);
		SystemRandomSource_t23E2BA98CFAB3CA24F6FE6DE3B83B132A44178E4* L_6;
		L_6 = SystemRandomSource_get_Default_mBEE95CF0D1F624A75C45F88C10523473691F4D8D(NULL);
		G_B4_0 = ((Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8*)(L_6));
		G_B4_1 = G_B3_1;
	}

IL_0025:
	{
		NullCheck(G_B4_1);
		G_B4_1->____random_0 = G_B4_0;
		Il2CppCodeGenWriteBarrier((void**)(&G_B4_1->____random_0), (void*)G_B4_0);
		double L_7 = ___0_s;
		__this->____s_1 = L_7;
		int32_t L_8 = ___1_n;
		__this->____n_2 = L_8;
		return;
	}
}
// System.String MathNet.Numerics.Distributions.Zipf::ToString()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Zipf_ToString_m4C9A6C8C3710D72C009AFF2629FEEF0E5CC5FC3C (Zipf_t533A437DA6EFB62CFF2FB4B397A2636242D87023* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Double_tE150EF3D1D43DEE85D533810AB4C742307EEDE5F_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral406C57A0B5DCC522724098AAB80DF0B1E55007A7);
		s_Il2CppMethodInitialized = true;
	}
	{
		double L_0 = __this->____s_1;
		double L_1 = L_0;
		RuntimeObject* L_2 = Box(Double_tE150EF3D1D43DEE85D533810AB4C742307EEDE5F_il2cpp_TypeInfo_var, &L_1);
		int32_t L_3 = __this->____n_2;
		int32_t L_4 = L_3;
		RuntimeObject* L_5 = Box(Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C_il2cpp_TypeInfo_var, &L_4);
		String_t* L_6;
		L_6 = String_Format_mFB7DA489BD99F4670881FF50EC017BFB0A5C0987(_stringLiteral406C57A0B5DCC522724098AAB80DF0B1E55007A7, L_2, L_5, NULL);
		return L_6;
	}
}
// System.Boolean MathNet.Numerics.Distributions.Zipf::IsValidParameterSet(System.Double,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Zipf_IsValidParameterSet_mCBA918E502E3B0CD3CE08036B50C83015074D8B3 (double ___0_s, int32_t ___1_n, const RuntimeMethod* method) 
{
	{
		int32_t L_0 = ___1_n;
		if ((((int32_t)L_0) <= ((int32_t)0)))
		{
			goto IL_0011;
		}
	}
	{
		double L_1 = ___0_s;
		return (bool)((((double)L_1) > ((double)(0.0)))? 1 : 0);
	}

IL_0011:
	{
		return (bool)0;
	}
}
// System.Double MathNet.Numerics.Distributions.Zipf::get_S()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double Zipf_get_S_m04617CEA70C96C3DE0DB4192CE4625BB49E7E00E (Zipf_t533A437DA6EFB62CFF2FB4B397A2636242D87023* __this, const RuntimeMethod* method) 
{
	{
		double L_0 = __this->____s_1;
		return L_0;
	}
}
// System.Int32 MathNet.Numerics.Distributions.Zipf::get_N()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Zipf_get_N_m454FF3E7FC205913C0712F6C75D06F1E5AC64830 (Zipf_t533A437DA6EFB62CFF2FB4B397A2636242D87023* __this, const RuntimeMethod* method) 
{
	{
		int32_t L_0 = __this->____n_2;
		return L_0;
	}
}
// System.Random MathNet.Numerics.Distributions.Zipf::get_RandomSource()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8* Zipf_get_RandomSource_mEF2FDA503F3B78077A28435CFD2B544B62E56664 (Zipf_t533A437DA6EFB62CFF2FB4B397A2636242D87023* __this, const RuntimeMethod* method) 
{
	{
		Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8* L_0 = __this->____random_0;
		return L_0;
	}
}
// System.Void MathNet.Numerics.Distributions.Zipf::set_RandomSource(System.Random)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Zipf_set_RandomSource_mC51A0282302338E211D8EC11DA646F2B72513784 (Zipf_t533A437DA6EFB62CFF2FB4B397A2636242D87023* __this, Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8* ___0_value, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SystemRandomSource_t23E2BA98CFAB3CA24F6FE6DE3B83B132A44178E4_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8* G_B2_0 = NULL;
	Zipf_t533A437DA6EFB62CFF2FB4B397A2636242D87023* G_B2_1 = NULL;
	Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8* G_B1_0 = NULL;
	Zipf_t533A437DA6EFB62CFF2FB4B397A2636242D87023* G_B1_1 = NULL;
	{
		Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8* L_0 = ___0_value;
		Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8* L_1 = L_0;
		G_B1_0 = L_1;
		G_B1_1 = __this;
		if (L_1)
		{
			G_B2_0 = L_1;
			G_B2_1 = __this;
			goto IL_000b;
		}
	}
	{
		il2cpp_codegen_runtime_class_init_inline(SystemRandomSource_t23E2BA98CFAB3CA24F6FE6DE3B83B132A44178E4_il2cpp_TypeInfo_var);
		SystemRandomSource_t23E2BA98CFAB3CA24F6FE6DE3B83B132A44178E4* L_2;
		L_2 = SystemRandomSource_get_Default_mBEE95CF0D1F624A75C45F88C10523473691F4D8D(NULL);
		G_B2_0 = ((Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8*)(L_2));
		G_B2_1 = G_B1_1;
	}

IL_000b:
	{
		NullCheck(G_B2_1);
		G_B2_1->____random_0 = G_B2_0;
		Il2CppCodeGenWriteBarrier((void**)(&G_B2_1->____random_0), (void*)G_B2_0);
		return;
	}
}
// System.Double MathNet.Numerics.Distributions.Zipf::get_Mean()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double Zipf_get_Mean_m2AE4ADA9679FAAA1238F40A7C6407E2BDFC7BD7A (Zipf_t533A437DA6EFB62CFF2FB4B397A2636242D87023* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SpecialFunctions_tC2E7545045D2156631D348A56D08F8F5D34545DA_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		int32_t L_0 = __this->____n_2;
		double L_1 = __this->____s_1;
		il2cpp_codegen_runtime_class_init_inline(SpecialFunctions_tC2E7545045D2156631D348A56D08F8F5D34545DA_il2cpp_TypeInfo_var);
		double L_2;
		L_2 = SpecialFunctions_GeneralHarmonic_mAB62B3F25407FA097A065F20516C08FED35B3508(L_0, ((double)il2cpp_codegen_subtract(L_1, (1.0))), NULL);
		int32_t L_3 = __this->____n_2;
		double L_4 = __this->____s_1;
		double L_5;
		L_5 = SpecialFunctions_GeneralHarmonic_mAB62B3F25407FA097A065F20516C08FED35B3508(L_3, L_4, NULL);
		return ((double)(L_2/L_5));
	}
}
// System.Double MathNet.Numerics.Distributions.Zipf::get_Variance()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double Zipf_get_Variance_m9E7880B7901EEAD19AEDCDBB429ACAB2CB36BA7B (Zipf_t533A437DA6EFB62CFF2FB4B397A2636242D87023* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SpecialFunctions_tC2E7545045D2156631D348A56D08F8F5D34545DA_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	double V_0 = 0.0;
	{
		double L_0 = __this->____s_1;
		if ((!(((double)L_0) <= ((double)(3.0)))))
		{
			goto IL_0017;
		}
	}
	{
		NotSupportedException_t1429765983D409BD2986508963C98D214E4EBF4A* L_1 = (NotSupportedException_t1429765983D409BD2986508963C98D214E4EBF4A*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&NotSupportedException_t1429765983D409BD2986508963C98D214E4EBF4A_il2cpp_TypeInfo_var)));
		NullCheck(L_1);
		NotSupportedException__ctor_m1398D0CDE19B36AA3DE9392879738C1EA2439CDF(L_1, NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_1, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Zipf_get_Variance_m9E7880B7901EEAD19AEDCDBB429ACAB2CB36BA7B_RuntimeMethod_var)));
	}

IL_0017:
	{
		int32_t L_2 = __this->____n_2;
		double L_3 = __this->____s_1;
		il2cpp_codegen_runtime_class_init_inline(SpecialFunctions_tC2E7545045D2156631D348A56D08F8F5D34545DA_il2cpp_TypeInfo_var);
		double L_4;
		L_4 = SpecialFunctions_GeneralHarmonic_mAB62B3F25407FA097A065F20516C08FED35B3508(L_2, L_3, NULL);
		V_0 = L_4;
		int32_t L_5 = __this->____n_2;
		double L_6 = __this->____s_1;
		double L_7;
		L_7 = SpecialFunctions_GeneralHarmonic_mAB62B3F25407FA097A065F20516C08FED35B3508(L_5, ((double)il2cpp_codegen_subtract(L_6, (2.0))), NULL);
		int32_t L_8 = __this->____n_2;
		double L_9 = __this->____s_1;
		double L_10;
		L_10 = SpecialFunctions_GeneralHarmonic_mAB62B3F25407FA097A065F20516C08FED35B3508(L_8, L_9, NULL);
		int32_t L_11 = __this->____n_2;
		double L_12 = __this->____s_1;
		double L_13;
		L_13 = SpecialFunctions_GeneralHarmonic_mAB62B3F25407FA097A065F20516C08FED35B3508(L_11, ((double)il2cpp_codegen_subtract(L_12, (1.0))), NULL);
		il2cpp_codegen_runtime_class_init_inline(Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		double L_14;
		L_14 = Math_Pow_mEAE651F0858203FBE12B72B6A53951BBD0FB5265(L_13, (2.0), NULL);
		double L_15 = V_0;
		double L_16 = V_0;
		return ((double)il2cpp_codegen_subtract(((double)il2cpp_codegen_multiply(L_7, L_10)), ((double)(L_14/((double)il2cpp_codegen_multiply(L_15, L_16))))));
	}
}
// System.Double MathNet.Numerics.Distributions.Zipf::get_StdDev()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double Zipf_get_StdDev_mD4758BF9E9C46E34989DAB5093279227F24DC665 (Zipf_t533A437DA6EFB62CFF2FB4B397A2636242D87023* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		double L_0;
		L_0 = Zipf_get_Variance_m9E7880B7901EEAD19AEDCDBB429ACAB2CB36BA7B(__this, NULL);
		il2cpp_codegen_runtime_class_init_inline(Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		double L_1;
		L_1 = sqrt(L_0);
		return L_1;
	}
}
// System.Double MathNet.Numerics.Distributions.Zipf::get_Entropy()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double Zipf_get_Entropy_mDFC07DB63E9BDB895B52DBFB79480611B5351A1F (Zipf_t533A437DA6EFB62CFF2FB4B397A2636242D87023* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SpecialFunctions_tC2E7545045D2156631D348A56D08F8F5D34545DA_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	double V_0 = 0.0;
	int32_t V_1 = 0;
	{
		V_0 = (0.0);
		V_1 = 0;
		goto IL_002e;
	}

IL_000e:
	{
		double L_0 = V_0;
		int32_t L_1 = V_1;
		il2cpp_codegen_runtime_class_init_inline(Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		double L_2;
		L_2 = log(((double)((int32_t)il2cpp_codegen_add(L_1, 1))));
		int32_t L_3 = V_1;
		double L_4 = __this->____s_1;
		double L_5;
		L_5 = Math_Pow_mEAE651F0858203FBE12B72B6A53951BBD0FB5265(((double)((int32_t)il2cpp_codegen_add(L_3, 1))), L_4, NULL);
		V_0 = ((double)il2cpp_codegen_add(L_0, ((double)(L_2/L_5))));
		int32_t L_6 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add(L_6, 1));
	}

IL_002e:
	{
		int32_t L_7 = V_1;
		int32_t L_8 = __this->____n_2;
		if ((((int32_t)L_7) < ((int32_t)L_8)))
		{
			goto IL_000e;
		}
	}
	{
		double L_9 = __this->____s_1;
		int32_t L_10 = __this->____n_2;
		double L_11 = __this->____s_1;
		il2cpp_codegen_runtime_class_init_inline(SpecialFunctions_tC2E7545045D2156631D348A56D08F8F5D34545DA_il2cpp_TypeInfo_var);
		double L_12;
		L_12 = SpecialFunctions_GeneralHarmonic_mAB62B3F25407FA097A065F20516C08FED35B3508(L_10, L_11, NULL);
		double L_13 = V_0;
		int32_t L_14 = __this->____n_2;
		double L_15 = __this->____s_1;
		double L_16;
		L_16 = SpecialFunctions_GeneralHarmonic_mAB62B3F25407FA097A065F20516C08FED35B3508(L_14, L_15, NULL);
		il2cpp_codegen_runtime_class_init_inline(Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		double L_17;
		L_17 = log(L_16);
		return ((double)il2cpp_codegen_add(((double)il2cpp_codegen_multiply(((double)(L_9/L_12)), L_13)), L_17));
	}
}
// System.Double MathNet.Numerics.Distributions.Zipf::get_Skewness()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double Zipf_get_Skewness_m46265461B5592E4ECB31426785E81A76C415EABF (Zipf_t533A437DA6EFB62CFF2FB4B397A2636242D87023* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SpecialFunctions_tC2E7545045D2156631D348A56D08F8F5D34545DA_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		double L_0 = __this->____s_1;
		if ((!(((double)L_0) <= ((double)(4.0)))))
		{
			goto IL_0017;
		}
	}
	{
		NotSupportedException_t1429765983D409BD2986508963C98D214E4EBF4A* L_1 = (NotSupportedException_t1429765983D409BD2986508963C98D214E4EBF4A*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&NotSupportedException_t1429765983D409BD2986508963C98D214E4EBF4A_il2cpp_TypeInfo_var)));
		NullCheck(L_1);
		NotSupportedException__ctor_m1398D0CDE19B36AA3DE9392879738C1EA2439CDF(L_1, NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_1, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Zipf_get_Skewness_m46265461B5592E4ECB31426785E81A76C415EABF_RuntimeMethod_var)));
	}

IL_0017:
	{
		int32_t L_2 = __this->____n_2;
		double L_3 = __this->____s_1;
		il2cpp_codegen_runtime_class_init_inline(SpecialFunctions_tC2E7545045D2156631D348A56D08F8F5D34545DA_il2cpp_TypeInfo_var);
		double L_4;
		L_4 = SpecialFunctions_GeneralHarmonic_mAB62B3F25407FA097A065F20516C08FED35B3508(L_2, ((double)il2cpp_codegen_subtract(L_3, (3.0))), NULL);
		int32_t L_5 = __this->____n_2;
		double L_6 = __this->____s_1;
		double L_7;
		L_7 = SpecialFunctions_GeneralHarmonic_mAB62B3F25407FA097A065F20516C08FED35B3508(L_5, L_6, NULL);
		il2cpp_codegen_runtime_class_init_inline(Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		double L_8;
		L_8 = Math_Pow_mEAE651F0858203FBE12B72B6A53951BBD0FB5265(L_7, (2.0), NULL);
		int32_t L_9 = __this->____n_2;
		double L_10 = __this->____s_1;
		double L_11;
		L_11 = SpecialFunctions_GeneralHarmonic_mAB62B3F25407FA097A065F20516C08FED35B3508(L_9, ((double)il2cpp_codegen_subtract(L_10, (1.0))), NULL);
		int32_t L_12 = __this->____n_2;
		double L_13 = __this->____s_1;
		double L_14;
		L_14 = SpecialFunctions_GeneralHarmonic_mAB62B3F25407FA097A065F20516C08FED35B3508(L_12, ((double)il2cpp_codegen_subtract(L_13, (2.0))), NULL);
		int32_t L_15 = __this->____n_2;
		double L_16 = __this->____s_1;
		double L_17;
		L_17 = SpecialFunctions_GeneralHarmonic_mAB62B3F25407FA097A065F20516C08FED35B3508(L_15, L_16, NULL);
		int32_t L_18 = __this->____n_2;
		double L_19 = __this->____s_1;
		double L_20;
		L_20 = SpecialFunctions_GeneralHarmonic_mAB62B3F25407FA097A065F20516C08FED35B3508(L_18, ((double)il2cpp_codegen_subtract(L_19, (1.0))), NULL);
		double L_21;
		L_21 = Math_Pow_mEAE651F0858203FBE12B72B6A53951BBD0FB5265(L_20, (2.0), NULL);
		int32_t L_22 = __this->____n_2;
		double L_23 = __this->____s_1;
		double L_24;
		L_24 = SpecialFunctions_GeneralHarmonic_mAB62B3F25407FA097A065F20516C08FED35B3508(L_22, ((double)il2cpp_codegen_subtract(L_23, (2.0))), NULL);
		int32_t L_25 = __this->____n_2;
		double L_26 = __this->____s_1;
		double L_27;
		L_27 = SpecialFunctions_GeneralHarmonic_mAB62B3F25407FA097A065F20516C08FED35B3508(L_25, L_26, NULL);
		int32_t L_28 = __this->____n_2;
		double L_29 = __this->____s_1;
		double L_30;
		L_30 = SpecialFunctions_GeneralHarmonic_mAB62B3F25407FA097A065F20516C08FED35B3508(L_28, ((double)il2cpp_codegen_subtract(L_29, (1.0))), NULL);
		double L_31;
		L_31 = Math_Pow_mEAE651F0858203FBE12B72B6A53951BBD0FB5265(L_30, (2.0), NULL);
		double L_32;
		L_32 = Math_Pow_mEAE651F0858203FBE12B72B6A53951BBD0FB5265(((double)il2cpp_codegen_subtract(((double)il2cpp_codegen_multiply(L_24, L_27)), L_31)), (1.5), NULL);
		return ((double)(((double)il2cpp_codegen_subtract(((double)il2cpp_codegen_multiply(L_4, L_8)), ((double)il2cpp_codegen_multiply(L_11, ((double)il2cpp_codegen_subtract(((double)il2cpp_codegen_multiply(((double)il2cpp_codegen_multiply((3.0), L_14)), L_17)), L_21))))))/L_32));
	}
}
// System.Int32 MathNet.Numerics.Distributions.Zipf::get_Mode()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Zipf_get_Mode_m9A2815EAAB896992E523F529864AA4CD8A9BE80F (Zipf_t533A437DA6EFB62CFF2FB4B397A2636242D87023* __this, const RuntimeMethod* method) 
{
	{
		return 1;
	}
}
// System.Double MathNet.Numerics.Distributions.Zipf::get_Median()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double Zipf_get_Median_mA9DE0CC27922CBFAC321FCCEB915D6221F6E655A (Zipf_t533A437DA6EFB62CFF2FB4B397A2636242D87023* __this, const RuntimeMethod* method) 
{
	{
		NotSupportedException_t1429765983D409BD2986508963C98D214E4EBF4A* L_0 = (NotSupportedException_t1429765983D409BD2986508963C98D214E4EBF4A*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&NotSupportedException_t1429765983D409BD2986508963C98D214E4EBF4A_il2cpp_TypeInfo_var)));
		NullCheck(L_0);
		NotSupportedException__ctor_m1398D0CDE19B36AA3DE9392879738C1EA2439CDF(L_0, NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_0, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Zipf_get_Median_mA9DE0CC27922CBFAC321FCCEB915D6221F6E655A_RuntimeMethod_var)));
	}
}
// System.Int32 MathNet.Numerics.Distributions.Zipf::get_Minimum()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Zipf_get_Minimum_mC44FF832169CCA7362EBB6D50F958E371268F8F1 (Zipf_t533A437DA6EFB62CFF2FB4B397A2636242D87023* __this, const RuntimeMethod* method) 
{
	{
		return 1;
	}
}
// System.Int32 MathNet.Numerics.Distributions.Zipf::get_Maximum()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Zipf_get_Maximum_mCB0F19201099210205EC7520B7AB42FA628FC826 (Zipf_t533A437DA6EFB62CFF2FB4B397A2636242D87023* __this, const RuntimeMethod* method) 
{
	{
		int32_t L_0 = __this->____n_2;
		return L_0;
	}
}
// System.Double MathNet.Numerics.Distributions.Zipf::Probability(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double Zipf_Probability_m1D6D84D3EBFDEE9C0E4A0665A1B430C2F41FD877 (Zipf_t533A437DA6EFB62CFF2FB4B397A2636242D87023* __this, int32_t ___0_k, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SpecialFunctions_tC2E7545045D2156631D348A56D08F8F5D34545DA_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		int32_t L_0 = ___0_k;
		double L_1 = __this->____s_1;
		il2cpp_codegen_runtime_class_init_inline(Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		double L_2;
		L_2 = Math_Pow_mEAE651F0858203FBE12B72B6A53951BBD0FB5265(((double)L_0), L_1, NULL);
		int32_t L_3 = __this->____n_2;
		double L_4 = __this->____s_1;
		il2cpp_codegen_runtime_class_init_inline(SpecialFunctions_tC2E7545045D2156631D348A56D08F8F5D34545DA_il2cpp_TypeInfo_var);
		double L_5;
		L_5 = SpecialFunctions_GeneralHarmonic_mAB62B3F25407FA097A065F20516C08FED35B3508(L_3, L_4, NULL);
		return ((double)(((double)((1.0)/L_2))/L_5));
	}
}
// System.Double MathNet.Numerics.Distributions.Zipf::ProbabilityLn(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double Zipf_ProbabilityLn_m21F8B34C6AAE59A135EA577D7EDEEF3C6A8498E3 (Zipf_t533A437DA6EFB62CFF2FB4B397A2636242D87023* __this, int32_t ___0_k, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		int32_t L_0 = ___0_k;
		double L_1;
		L_1 = Zipf_Probability_m1D6D84D3EBFDEE9C0E4A0665A1B430C2F41FD877(__this, L_0, NULL);
		il2cpp_codegen_runtime_class_init_inline(Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		double L_2;
		L_2 = log(L_1);
		return L_2;
	}
}
// System.Double MathNet.Numerics.Distributions.Zipf::CumulativeDistribution(System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double Zipf_CumulativeDistribution_m8BB3CB97F3999C82E2166068E1D5BE674993E216 (Zipf_t533A437DA6EFB62CFF2FB4B397A2636242D87023* __this, double ___0_x, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SpecialFunctions_tC2E7545045D2156631D348A56D08F8F5D34545DA_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		double L_0 = ___0_x;
		if ((!(((double)L_0) < ((double)(1.0)))))
		{
			goto IL_0016;
		}
	}
	{
		return (0.0);
	}

IL_0016:
	{
		double L_1 = ___0_x;
		double L_2 = __this->____s_1;
		il2cpp_codegen_runtime_class_init_inline(SpecialFunctions_tC2E7545045D2156631D348A56D08F8F5D34545DA_il2cpp_TypeInfo_var);
		double L_3;
		L_3 = SpecialFunctions_GeneralHarmonic_mAB62B3F25407FA097A065F20516C08FED35B3508(il2cpp_codegen_cast_double_to_int<int32_t>(L_1), L_2, NULL);
		int32_t L_4 = __this->____n_2;
		double L_5 = __this->____s_1;
		double L_6;
		L_6 = SpecialFunctions_GeneralHarmonic_mAB62B3F25407FA097A065F20516C08FED35B3508(L_4, L_5, NULL);
		return ((double)(L_3/L_6));
	}
}
// System.Double MathNet.Numerics.Distributions.Zipf::PMF(System.Double,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double Zipf_PMF_mCBB1E81BE3F41DA62E019DAE5BCEDB71D36B69E2 (double ___0_s, int32_t ___1_n, int32_t ___2_k, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SpecialFunctions_tC2E7545045D2156631D348A56D08F8F5D34545DA_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		int32_t L_0 = ___1_n;
		if ((((int32_t)L_0) <= ((int32_t)0)))
		{
			goto IL_0010;
		}
	}
	{
		double L_1 = ___0_s;
		if ((((double)L_1) > ((double)(0.0))))
		{
			goto IL_001b;
		}
	}

IL_0010:
	{
		ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263* L_2 = (ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263_il2cpp_TypeInfo_var)));
		NullCheck(L_2);
		ArgumentException__ctor_m026938A67AF9D36BB7ED27F80425D7194B514465(L_2, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral7B4009EABB849A075B30CF0C472DBA2C303AF1C8)), NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_2, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Zipf_PMF_mCBB1E81BE3F41DA62E019DAE5BCEDB71D36B69E2_RuntimeMethod_var)));
	}

IL_001b:
	{
		int32_t L_3 = ___2_k;
		double L_4 = ___0_s;
		il2cpp_codegen_runtime_class_init_inline(Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		double L_5;
		L_5 = Math_Pow_mEAE651F0858203FBE12B72B6A53951BBD0FB5265(((double)L_3), L_4, NULL);
		int32_t L_6 = ___1_n;
		double L_7 = ___0_s;
		il2cpp_codegen_runtime_class_init_inline(SpecialFunctions_tC2E7545045D2156631D348A56D08F8F5D34545DA_il2cpp_TypeInfo_var);
		double L_8;
		L_8 = SpecialFunctions_GeneralHarmonic_mAB62B3F25407FA097A065F20516C08FED35B3508(L_6, L_7, NULL);
		return ((double)(((double)((1.0)/L_5))/L_8));
	}
}
// System.Double MathNet.Numerics.Distributions.Zipf::PMFLn(System.Double,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double Zipf_PMFLn_mC73B265DFB49DCEA74F1B9D0F664626AD468C392 (double ___0_s, int32_t ___1_n, int32_t ___2_k, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		int32_t L_0 = ___1_n;
		if ((((int32_t)L_0) <= ((int32_t)0)))
		{
			goto IL_0010;
		}
	}
	{
		double L_1 = ___0_s;
		if ((((double)L_1) > ((double)(0.0))))
		{
			goto IL_001b;
		}
	}

IL_0010:
	{
		ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263* L_2 = (ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263_il2cpp_TypeInfo_var)));
		NullCheck(L_2);
		ArgumentException__ctor_m026938A67AF9D36BB7ED27F80425D7194B514465(L_2, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral7B4009EABB849A075B30CF0C472DBA2C303AF1C8)), NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_2, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Zipf_PMFLn_mC73B265DFB49DCEA74F1B9D0F664626AD468C392_RuntimeMethod_var)));
	}

IL_001b:
	{
		double L_3 = ___0_s;
		int32_t L_4 = ___1_n;
		int32_t L_5 = ___2_k;
		double L_6;
		L_6 = Zipf_PMF_mCBB1E81BE3F41DA62E019DAE5BCEDB71D36B69E2(L_3, L_4, L_5, NULL);
		il2cpp_codegen_runtime_class_init_inline(Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		double L_7;
		L_7 = log(L_6);
		return L_7;
	}
}
// System.Double MathNet.Numerics.Distributions.Zipf::CDF(System.Double,System.Int32,System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double Zipf_CDF_mE9BA11DBA927D111A6D0FDA2322F3CB793EE8D5C (double ___0_s, int32_t ___1_n, double ___2_x, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SpecialFunctions_tC2E7545045D2156631D348A56D08F8F5D34545DA_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		int32_t L_0 = ___1_n;
		if ((((int32_t)L_0) <= ((int32_t)0)))
		{
			goto IL_0010;
		}
	}
	{
		double L_1 = ___0_s;
		if ((((double)L_1) > ((double)(0.0))))
		{
			goto IL_001b;
		}
	}

IL_0010:
	{
		ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263* L_2 = (ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263_il2cpp_TypeInfo_var)));
		NullCheck(L_2);
		ArgumentException__ctor_m026938A67AF9D36BB7ED27F80425D7194B514465(L_2, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral7B4009EABB849A075B30CF0C472DBA2C303AF1C8)), NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_2, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Zipf_CDF_mE9BA11DBA927D111A6D0FDA2322F3CB793EE8D5C_RuntimeMethod_var)));
	}

IL_001b:
	{
		double L_3 = ___2_x;
		if ((!(((double)L_3) < ((double)(1.0)))))
		{
			goto IL_0031;
		}
	}
	{
		return (0.0);
	}

IL_0031:
	{
		double L_4 = ___2_x;
		double L_5 = ___0_s;
		il2cpp_codegen_runtime_class_init_inline(SpecialFunctions_tC2E7545045D2156631D348A56D08F8F5D34545DA_il2cpp_TypeInfo_var);
		double L_6;
		L_6 = SpecialFunctions_GeneralHarmonic_mAB62B3F25407FA097A065F20516C08FED35B3508(il2cpp_codegen_cast_double_to_int<int32_t>(L_4), L_5, NULL);
		int32_t L_7 = ___1_n;
		double L_8 = ___0_s;
		double L_9;
		L_9 = SpecialFunctions_GeneralHarmonic_mAB62B3F25407FA097A065F20516C08FED35B3508(L_7, L_8, NULL);
		return ((double)(L_6/L_9));
	}
}
// System.Int32 MathNet.Numerics.Distributions.Zipf::SampleUnchecked(System.Random,System.Double,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Zipf_SampleUnchecked_m11CA278BCB474AE673FB4D6DB3B749FC43966E91 (Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8* ___0_rnd, double ___1_s, int32_t ___2_n, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SpecialFunctions_tC2E7545045D2156631D348A56D08F8F5D34545DA_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	double V_0 = 0.0;
	double V_1 = 0.0;
	int32_t V_2 = 0;
	double V_3 = 0.0;
	{
		V_0 = (0.0);
		goto IL_0013;
	}

IL_000c:
	{
		Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8* L_0 = ___0_rnd;
		NullCheck(L_0);
		double L_1;
		L_1 = VirtualFuncInvoker0< double >::Invoke(8 /* System.Double System.Random::NextDouble() */, L_0);
		V_0 = L_1;
	}

IL_0013:
	{
		double L_2 = V_0;
		if ((((double)L_2) == ((double)(0.0))))
		{
			goto IL_000c;
		}
	}
	{
		int32_t L_3 = ___2_n;
		double L_4 = ___1_s;
		il2cpp_codegen_runtime_class_init_inline(SpecialFunctions_tC2E7545045D2156631D348A56D08F8F5D34545DA_il2cpp_TypeInfo_var);
		double L_5;
		L_5 = SpecialFunctions_GeneralHarmonic_mAB62B3F25407FA097A065F20516C08FED35B3508(L_3, L_4, NULL);
		V_1 = ((double)((1.0)/L_5));
		V_3 = (0.0);
		V_2 = 1;
		goto IL_0054;
	}

IL_003f:
	{
		double L_6 = V_3;
		double L_7 = V_1;
		int32_t L_8 = V_2;
		double L_9 = ___1_s;
		il2cpp_codegen_runtime_class_init_inline(Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		double L_10;
		L_10 = Math_Pow_mEAE651F0858203FBE12B72B6A53951BBD0FB5265(((double)L_8), L_9, NULL);
		V_3 = ((double)il2cpp_codegen_add(L_6, ((double)(L_7/L_10))));
		double L_11 = V_3;
		double L_12 = V_0;
		if ((((double)L_11) >= ((double)L_12)))
		{
			goto IL_0058;
		}
	}
	{
		int32_t L_13 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add(L_13, 1));
	}

IL_0054:
	{
		int32_t L_14 = V_2;
		int32_t L_15 = ___2_n;
		if ((((int32_t)L_14) <= ((int32_t)L_15)))
		{
			goto IL_003f;
		}
	}

IL_0058:
	{
		int32_t L_16 = V_2;
		return L_16;
	}
}
// System.Void MathNet.Numerics.Distributions.Zipf::SamplesUnchecked(System.Random,System.Int32[],System.Double,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Zipf_SamplesUnchecked_m7299A1FC9F6D4BDA78226B7B69621A5127EFD726 (Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8* ___0_rnd, Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ___1_values, double ___2_s, int32_t ___3_n, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	{
		V_0 = 0;
		goto IL_0013;
	}

IL_0004:
	{
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_0 = ___1_values;
		int32_t L_1 = V_0;
		Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8* L_2 = ___0_rnd;
		double L_3 = ___2_s;
		int32_t L_4 = ___3_n;
		int32_t L_5;
		L_5 = Zipf_SampleUnchecked_m11CA278BCB474AE673FB4D6DB3B749FC43966E91(L_2, L_3, L_4, NULL);
		NullCheck(L_0);
		(L_0)->SetAt(static_cast<il2cpp_array_size_t>(L_1), (int32_t)L_5);
		int32_t L_6 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_add(L_6, 1));
	}

IL_0013:
	{
		int32_t L_7 = V_0;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_8 = ___1_values;
		NullCheck(L_8);
		if ((((int32_t)L_7) < ((int32_t)((int32_t)(((RuntimeArray*)L_8)->max_length)))))
		{
			goto IL_0004;
		}
	}
	{
		return;
	}
}
// System.Collections.Generic.IEnumerable`1<System.Int32> MathNet.Numerics.Distributions.Zipf::SamplesUnchecked(System.Random,System.Double,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* Zipf_SamplesUnchecked_mCC16E880B53B2E7BB566C2ED1A343CB3831D7C03 (Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8* ___0_rnd, double ___1_s, int32_t ___2_n, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CSamplesUncheckedU3Ed__40_t29307BD38C6FF3892A8B3F9FD768493D8F93EE8A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		U3CSamplesUncheckedU3Ed__40_t29307BD38C6FF3892A8B3F9FD768493D8F93EE8A* L_0 = (U3CSamplesUncheckedU3Ed__40_t29307BD38C6FF3892A8B3F9FD768493D8F93EE8A*)il2cpp_codegen_object_new(U3CSamplesUncheckedU3Ed__40_t29307BD38C6FF3892A8B3F9FD768493D8F93EE8A_il2cpp_TypeInfo_var);
		NullCheck(L_0);
		U3CSamplesUncheckedU3Ed__40__ctor_m57A71D90D5247F4EDD0BF417F99C34F1F14A5F83(L_0, ((int32_t)-2), NULL);
		U3CSamplesUncheckedU3Ed__40_t29307BD38C6FF3892A8B3F9FD768493D8F93EE8A* L_1 = L_0;
		Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8* L_2 = ___0_rnd;
		NullCheck(L_1);
		L_1->___U3CU3E3__rnd_4 = L_2;
		Il2CppCodeGenWriteBarrier((void**)(&L_1->___U3CU3E3__rnd_4), (void*)L_2);
		U3CSamplesUncheckedU3Ed__40_t29307BD38C6FF3892A8B3F9FD768493D8F93EE8A* L_3 = L_1;
		double L_4 = ___1_s;
		NullCheck(L_3);
		L_3->___U3CU3E3__s_6 = L_4;
		U3CSamplesUncheckedU3Ed__40_t29307BD38C6FF3892A8B3F9FD768493D8F93EE8A* L_5 = L_3;
		int32_t L_6 = ___2_n;
		NullCheck(L_5);
		L_5->___U3CU3E3__n_8 = L_6;
		return L_5;
	}
}
// System.Int32 MathNet.Numerics.Distributions.Zipf::Sample()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Zipf_Sample_mDD27921437C5BC89E21859F52C23609084C0D385 (Zipf_t533A437DA6EFB62CFF2FB4B397A2636242D87023* __this, const RuntimeMethod* method) 
{
	{
		Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8* L_0 = __this->____random_0;
		double L_1 = __this->____s_1;
		int32_t L_2 = __this->____n_2;
		int32_t L_3;
		L_3 = Zipf_SampleUnchecked_m11CA278BCB474AE673FB4D6DB3B749FC43966E91(L_0, L_1, L_2, NULL);
		return L_3;
	}
}
// System.Void MathNet.Numerics.Distributions.Zipf::Samples(System.Int32[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Zipf_Samples_m3886FFE26D9CE4A24287E8309C751BD22E392CC7 (Zipf_t533A437DA6EFB62CFF2FB4B397A2636242D87023* __this, Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ___0_values, const RuntimeMethod* method) 
{
	{
		Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8* L_0 = __this->____random_0;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_1 = ___0_values;
		double L_2 = __this->____s_1;
		int32_t L_3 = __this->____n_2;
		Zipf_SamplesUnchecked_m7299A1FC9F6D4BDA78226B7B69621A5127EFD726(L_0, L_1, L_2, L_3, NULL);
		return;
	}
}
// System.Collections.Generic.IEnumerable`1<System.Int32> MathNet.Numerics.Distributions.Zipf::Samples()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* Zipf_Samples_m5DC6752F26F75D6CEEE69B0B059212243F3ED6CF (Zipf_t533A437DA6EFB62CFF2FB4B397A2636242D87023* __this, const RuntimeMethod* method) 
{
	{
		Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8* L_0 = __this->____random_0;
		double L_1 = __this->____s_1;
		int32_t L_2 = __this->____n_2;
		RuntimeObject* L_3;
		L_3 = Zipf_SamplesUnchecked_mCC16E880B53B2E7BB566C2ED1A343CB3831D7C03(L_0, L_1, L_2, NULL);
		return L_3;
	}
}
// System.Int32 MathNet.Numerics.Distributions.Zipf::Sample(System.Random,System.Double,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Zipf_Sample_m327C5F54D20B06A4EB677774CB9A88BB2853654B (Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8* ___0_rnd, double ___1_s, int32_t ___2_n, const RuntimeMethod* method) 
{
	{
		int32_t L_0 = ___2_n;
		if ((((int32_t)L_0) <= ((int32_t)0)))
		{
			goto IL_0010;
		}
	}
	{
		double L_1 = ___1_s;
		if ((((double)L_1) > ((double)(0.0))))
		{
			goto IL_001b;
		}
	}

IL_0010:
	{
		ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263* L_2 = (ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263_il2cpp_TypeInfo_var)));
		NullCheck(L_2);
		ArgumentException__ctor_m026938A67AF9D36BB7ED27F80425D7194B514465(L_2, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral7B4009EABB849A075B30CF0C472DBA2C303AF1C8)), NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_2, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Zipf_Sample_m327C5F54D20B06A4EB677774CB9A88BB2853654B_RuntimeMethod_var)));
	}

IL_001b:
	{
		Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8* L_3 = ___0_rnd;
		double L_4 = ___1_s;
		int32_t L_5 = ___2_n;
		int32_t L_6;
		L_6 = Zipf_SampleUnchecked_m11CA278BCB474AE673FB4D6DB3B749FC43966E91(L_3, L_4, L_5, NULL);
		return L_6;
	}
}
// System.Collections.Generic.IEnumerable`1<System.Int32> MathNet.Numerics.Distributions.Zipf::Samples(System.Random,System.Double,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* Zipf_Samples_mF67AE443EAEDA235D248884A8720E7C82972971A (Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8* ___0_rnd, double ___1_s, int32_t ___2_n, const RuntimeMethod* method) 
{
	{
		int32_t L_0 = ___2_n;
		if ((((int32_t)L_0) <= ((int32_t)0)))
		{
			goto IL_0010;
		}
	}
	{
		double L_1 = ___1_s;
		if ((((double)L_1) > ((double)(0.0))))
		{
			goto IL_001b;
		}
	}

IL_0010:
	{
		ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263* L_2 = (ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263_il2cpp_TypeInfo_var)));
		NullCheck(L_2);
		ArgumentException__ctor_m026938A67AF9D36BB7ED27F80425D7194B514465(L_2, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral7B4009EABB849A075B30CF0C472DBA2C303AF1C8)), NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_2, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Zipf_Samples_mF67AE443EAEDA235D248884A8720E7C82972971A_RuntimeMethod_var)));
	}

IL_001b:
	{
		Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8* L_3 = ___0_rnd;
		double L_4 = ___1_s;
		int32_t L_5 = ___2_n;
		RuntimeObject* L_6;
		L_6 = Zipf_SamplesUnchecked_mCC16E880B53B2E7BB566C2ED1A343CB3831D7C03(L_3, L_4, L_5, NULL);
		return L_6;
	}
}
// System.Void MathNet.Numerics.Distributions.Zipf::Samples(System.Random,System.Int32[],System.Double,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Zipf_Samples_m87A504F4D561A6BB34FFE88BE860AB5E0E9DDC3A (Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8* ___0_rnd, Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ___1_values, double ___2_s, int32_t ___3_n, const RuntimeMethod* method) 
{
	{
		int32_t L_0 = ___3_n;
		if ((((int32_t)L_0) <= ((int32_t)0)))
		{
			goto IL_0010;
		}
	}
	{
		double L_1 = ___2_s;
		if ((((double)L_1) > ((double)(0.0))))
		{
			goto IL_001b;
		}
	}

IL_0010:
	{
		ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263* L_2 = (ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263_il2cpp_TypeInfo_var)));
		NullCheck(L_2);
		ArgumentException__ctor_m026938A67AF9D36BB7ED27F80425D7194B514465(L_2, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral7B4009EABB849A075B30CF0C472DBA2C303AF1C8)), NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_2, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Zipf_Samples_m87A504F4D561A6BB34FFE88BE860AB5E0E9DDC3A_RuntimeMethod_var)));
	}

IL_001b:
	{
		Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8* L_3 = ___0_rnd;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_4 = ___1_values;
		double L_5 = ___2_s;
		int32_t L_6 = ___3_n;
		Zipf_SamplesUnchecked_m7299A1FC9F6D4BDA78226B7B69621A5127EFD726(L_3, L_4, L_5, L_6, NULL);
		return;
	}
}
// System.Int32 MathNet.Numerics.Distributions.Zipf::Sample(System.Double,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Zipf_Sample_mDF6BAC2080A0F48978ECF1A1C298B3522ABFE9AC (double ___0_s, int32_t ___1_n, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SystemRandomSource_t23E2BA98CFAB3CA24F6FE6DE3B83B132A44178E4_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		int32_t L_0 = ___1_n;
		if ((((int32_t)L_0) <= ((int32_t)0)))
		{
			goto IL_0010;
		}
	}
	{
		double L_1 = ___0_s;
		if ((((double)L_1) > ((double)(0.0))))
		{
			goto IL_001b;
		}
	}

IL_0010:
	{
		ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263* L_2 = (ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263_il2cpp_TypeInfo_var)));
		NullCheck(L_2);
		ArgumentException__ctor_m026938A67AF9D36BB7ED27F80425D7194B514465(L_2, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral7B4009EABB849A075B30CF0C472DBA2C303AF1C8)), NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_2, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Zipf_Sample_mDF6BAC2080A0F48978ECF1A1C298B3522ABFE9AC_RuntimeMethod_var)));
	}

IL_001b:
	{
		il2cpp_codegen_runtime_class_init_inline(SystemRandomSource_t23E2BA98CFAB3CA24F6FE6DE3B83B132A44178E4_il2cpp_TypeInfo_var);
		SystemRandomSource_t23E2BA98CFAB3CA24F6FE6DE3B83B132A44178E4* L_3;
		L_3 = SystemRandomSource_get_Default_mBEE95CF0D1F624A75C45F88C10523473691F4D8D(NULL);
		double L_4 = ___0_s;
		int32_t L_5 = ___1_n;
		int32_t L_6;
		L_6 = Zipf_SampleUnchecked_m11CA278BCB474AE673FB4D6DB3B749FC43966E91(L_3, L_4, L_5, NULL);
		return L_6;
	}
}
// System.Collections.Generic.IEnumerable`1<System.Int32> MathNet.Numerics.Distributions.Zipf::Samples(System.Double,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* Zipf_Samples_mD61E49CCC0A06AF4C01652158AF18E373667718A (double ___0_s, int32_t ___1_n, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SystemRandomSource_t23E2BA98CFAB3CA24F6FE6DE3B83B132A44178E4_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		int32_t L_0 = ___1_n;
		if ((((int32_t)L_0) <= ((int32_t)0)))
		{
			goto IL_0010;
		}
	}
	{
		double L_1 = ___0_s;
		if ((((double)L_1) > ((double)(0.0))))
		{
			goto IL_001b;
		}
	}

IL_0010:
	{
		ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263* L_2 = (ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263_il2cpp_TypeInfo_var)));
		NullCheck(L_2);
		ArgumentException__ctor_m026938A67AF9D36BB7ED27F80425D7194B514465(L_2, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral7B4009EABB849A075B30CF0C472DBA2C303AF1C8)), NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_2, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Zipf_Samples_mD61E49CCC0A06AF4C01652158AF18E373667718A_RuntimeMethod_var)));
	}

IL_001b:
	{
		il2cpp_codegen_runtime_class_init_inline(SystemRandomSource_t23E2BA98CFAB3CA24F6FE6DE3B83B132A44178E4_il2cpp_TypeInfo_var);
		SystemRandomSource_t23E2BA98CFAB3CA24F6FE6DE3B83B132A44178E4* L_3;
		L_3 = SystemRandomSource_get_Default_mBEE95CF0D1F624A75C45F88C10523473691F4D8D(NULL);
		double L_4 = ___0_s;
		int32_t L_5 = ___1_n;
		RuntimeObject* L_6;
		L_6 = Zipf_SamplesUnchecked_mCC16E880B53B2E7BB566C2ED1A343CB3831D7C03(L_3, L_4, L_5, NULL);
		return L_6;
	}
}
// System.Void MathNet.Numerics.Distributions.Zipf::Samples(System.Int32[],System.Double,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Zipf_Samples_m183EF9DB4B5F964C30A8478C1A044A6541CE9DCC (Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ___0_values, double ___1_s, int32_t ___2_n, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SystemRandomSource_t23E2BA98CFAB3CA24F6FE6DE3B83B132A44178E4_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		int32_t L_0 = ___2_n;
		if ((((int32_t)L_0) <= ((int32_t)0)))
		{
			goto IL_0010;
		}
	}
	{
		double L_1 = ___1_s;
		if ((((double)L_1) > ((double)(0.0))))
		{
			goto IL_001b;
		}
	}

IL_0010:
	{
		ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263* L_2 = (ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ArgumentException_tAD90411542A20A9C72D5CDA3A84181D8B947A263_il2cpp_TypeInfo_var)));
		NullCheck(L_2);
		ArgumentException__ctor_m026938A67AF9D36BB7ED27F80425D7194B514465(L_2, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral7B4009EABB849A075B30CF0C472DBA2C303AF1C8)), NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_2, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Zipf_Samples_m183EF9DB4B5F964C30A8478C1A044A6541CE9DCC_RuntimeMethod_var)));
	}

IL_001b:
	{
		il2cpp_codegen_runtime_class_init_inline(SystemRandomSource_t23E2BA98CFAB3CA24F6FE6DE3B83B132A44178E4_il2cpp_TypeInfo_var);
		SystemRandomSource_t23E2BA98CFAB3CA24F6FE6DE3B83B132A44178E4* L_3;
		L_3 = SystemRandomSource_get_Default_mBEE95CF0D1F624A75C45F88C10523473691F4D8D(NULL);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_4 = ___0_values;
		double L_5 = ___1_s;
		int32_t L_6 = ___2_n;
		Zipf_SamplesUnchecked_m7299A1FC9F6D4BDA78226B7B69621A5127EFD726(L_3, L_4, L_5, L_6, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void MathNet.Numerics.Distributions.Zipf/<SamplesUnchecked>d__40::.ctor(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CSamplesUncheckedU3Ed__40__ctor_m57A71D90D5247F4EDD0BF417F99C34F1F14A5F83 (U3CSamplesUncheckedU3Ed__40_t29307BD38C6FF3892A8B3F9FD768493D8F93EE8A* __this, int32_t ___0_U3CU3E1__state, const RuntimeMethod* method) 
{
	{
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		int32_t L_0 = ___0_U3CU3E1__state;
		__this->___U3CU3E1__state_0 = L_0;
		int32_t L_1;
		L_1 = Environment_get_CurrentManagedThreadId_m66483AADCCC13272EBDCD94D31D2E52603C24BDF(NULL);
		__this->___U3CU3El__initialThreadId_2 = L_1;
		return;
	}
}
// System.Void MathNet.Numerics.Distributions.Zipf/<SamplesUnchecked>d__40::System.IDisposable.Dispose()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CSamplesUncheckedU3Ed__40_System_IDisposable_Dispose_m722F7D886F401CD3C27A62DBD63D7F95934CE7D7 (U3CSamplesUncheckedU3Ed__40_t29307BD38C6FF3892A8B3F9FD768493D8F93EE8A* __this, const RuntimeMethod* method) 
{
	{
		return;
	}
}
// System.Boolean MathNet.Numerics.Distributions.Zipf/<SamplesUnchecked>d__40::MoveNext()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool U3CSamplesUncheckedU3Ed__40_MoveNext_mCA5AA16B1F030F625DD8C0E2BBF40FDB8DD65FD4 (U3CSamplesUncheckedU3Ed__40_t29307BD38C6FF3892A8B3F9FD768493D8F93EE8A* __this, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	{
		int32_t L_0 = __this->___U3CU3E1__state_0;
		V_0 = L_0;
		int32_t L_1 = V_0;
		if (!L_1)
		{
			goto IL_0010;
		}
	}
	{
		int32_t L_2 = V_0;
		if ((((int32_t)L_2) == ((int32_t)1)))
		{
			goto IL_003d;
		}
	}
	{
		return (bool)0;
	}

IL_0010:
	{
		__this->___U3CU3E1__state_0 = (-1);
	}

IL_0017:
	{
		Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8* L_3 = __this->___rnd_3;
		double L_4 = __this->___s_5;
		int32_t L_5 = __this->___n_7;
		int32_t L_6;
		L_6 = Zipf_SampleUnchecked_m11CA278BCB474AE673FB4D6DB3B749FC43966E91(L_3, L_4, L_5, NULL);
		__this->___U3CU3E2__current_1 = L_6;
		__this->___U3CU3E1__state_0 = 1;
		return (bool)1;
	}

IL_003d:
	{
		__this->___U3CU3E1__state_0 = (-1);
		goto IL_0017;
	}
}
// System.Int32 MathNet.Numerics.Distributions.Zipf/<SamplesUnchecked>d__40::System.Collections.Generic.IEnumerator<System.Int32>.get_Current()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t U3CSamplesUncheckedU3Ed__40_System_Collections_Generic_IEnumeratorU3CSystem_Int32U3E_get_Current_mEF78B2B20D4E2456A93506CE3A85E3C3E0B5327C (U3CSamplesUncheckedU3Ed__40_t29307BD38C6FF3892A8B3F9FD768493D8F93EE8A* __this, const RuntimeMethod* method) 
{
	{
		int32_t L_0 = __this->___U3CU3E2__current_1;
		return L_0;
	}
}
// System.Void MathNet.Numerics.Distributions.Zipf/<SamplesUnchecked>d__40::System.Collections.IEnumerator.Reset()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CSamplesUncheckedU3Ed__40_System_Collections_IEnumerator_Reset_m4F6EB72FA2445139D55885EBFD799CA6BA648989 (U3CSamplesUncheckedU3Ed__40_t29307BD38C6FF3892A8B3F9FD768493D8F93EE8A* __this, const RuntimeMethod* method) 
{
	{
		NotSupportedException_t1429765983D409BD2986508963C98D214E4EBF4A* L_0 = (NotSupportedException_t1429765983D409BD2986508963C98D214E4EBF4A*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&NotSupportedException_t1429765983D409BD2986508963C98D214E4EBF4A_il2cpp_TypeInfo_var)));
		NullCheck(L_0);
		NotSupportedException__ctor_m1398D0CDE19B36AA3DE9392879738C1EA2439CDF(L_0, NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_0, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&U3CSamplesUncheckedU3Ed__40_System_Collections_IEnumerator_Reset_m4F6EB72FA2445139D55885EBFD799CA6BA648989_RuntimeMethod_var)));
	}
}
// System.Object MathNet.Numerics.Distributions.Zipf/<SamplesUnchecked>d__40::System.Collections.IEnumerator.get_Current()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* U3CSamplesUncheckedU3Ed__40_System_Collections_IEnumerator_get_Current_m19522C7F9E00E9C8180C3D00B55B03A080E63AB9 (U3CSamplesUncheckedU3Ed__40_t29307BD38C6FF3892A8B3F9FD768493D8F93EE8A* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		int32_t L_0 = __this->___U3CU3E2__current_1;
		int32_t L_1 = L_0;
		RuntimeObject* L_2 = Box(Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C_il2cpp_TypeInfo_var, &L_1);
		return L_2;
	}
}
// System.Collections.Generic.IEnumerator`1<System.Int32> MathNet.Numerics.Distributions.Zipf/<SamplesUnchecked>d__40::System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* U3CSamplesUncheckedU3Ed__40_System_Collections_Generic_IEnumerableU3CSystem_Int32U3E_GetEnumerator_m9695B8349A4904784985C41FE8102AA7FB3A007C (U3CSamplesUncheckedU3Ed__40_t29307BD38C6FF3892A8B3F9FD768493D8F93EE8A* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CSamplesUncheckedU3Ed__40_t29307BD38C6FF3892A8B3F9FD768493D8F93EE8A_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	U3CSamplesUncheckedU3Ed__40_t29307BD38C6FF3892A8B3F9FD768493D8F93EE8A* V_0 = NULL;
	{
		int32_t L_0 = __this->___U3CU3E1__state_0;
		if ((!(((uint32_t)L_0) == ((uint32_t)((int32_t)-2)))))
		{
			goto IL_0022;
		}
	}
	{
		int32_t L_1 = __this->___U3CU3El__initialThreadId_2;
		int32_t L_2;
		L_2 = Environment_get_CurrentManagedThreadId_m66483AADCCC13272EBDCD94D31D2E52603C24BDF(NULL);
		if ((!(((uint32_t)L_1) == ((uint32_t)L_2))))
		{
			goto IL_0022;
		}
	}
	{
		__this->___U3CU3E1__state_0 = 0;
		V_0 = __this;
		goto IL_0029;
	}

IL_0022:
	{
		U3CSamplesUncheckedU3Ed__40_t29307BD38C6FF3892A8B3F9FD768493D8F93EE8A* L_3 = (U3CSamplesUncheckedU3Ed__40_t29307BD38C6FF3892A8B3F9FD768493D8F93EE8A*)il2cpp_codegen_object_new(U3CSamplesUncheckedU3Ed__40_t29307BD38C6FF3892A8B3F9FD768493D8F93EE8A_il2cpp_TypeInfo_var);
		NullCheck(L_3);
		U3CSamplesUncheckedU3Ed__40__ctor_m57A71D90D5247F4EDD0BF417F99C34F1F14A5F83(L_3, 0, NULL);
		V_0 = L_3;
	}

IL_0029:
	{
		U3CSamplesUncheckedU3Ed__40_t29307BD38C6FF3892A8B3F9FD768493D8F93EE8A* L_4 = V_0;
		Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8* L_5 = __this->___U3CU3E3__rnd_4;
		NullCheck(L_4);
		L_4->___rnd_3 = L_5;
		Il2CppCodeGenWriteBarrier((void**)(&L_4->___rnd_3), (void*)L_5);
		U3CSamplesUncheckedU3Ed__40_t29307BD38C6FF3892A8B3F9FD768493D8F93EE8A* L_6 = V_0;
		double L_7 = __this->___U3CU3E3__s_6;
		NullCheck(L_6);
		L_6->___s_5 = L_7;
		U3CSamplesUncheckedU3Ed__40_t29307BD38C6FF3892A8B3F9FD768493D8F93EE8A* L_8 = V_0;
		int32_t L_9 = __this->___U3CU3E3__n_8;
		NullCheck(L_8);
		L_8->___n_7 = L_9;
		U3CSamplesUncheckedU3Ed__40_t29307BD38C6FF3892A8B3F9FD768493D8F93EE8A* L_10 = V_0;
		return L_10;
	}
}
// System.Collections.IEnumerator MathNet.Numerics.Distributions.Zipf/<SamplesUnchecked>d__40::System.Collections.IEnumerable.GetEnumerator()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* U3CSamplesUncheckedU3Ed__40_System_Collections_IEnumerable_GetEnumerator_m809A17016163013397DCDAAFDC10D4BA292435D2 (U3CSamplesUncheckedU3Ed__40_t29307BD38C6FF3892A8B3F9FD768493D8F93EE8A* __this, const RuntimeMethod* method) 
{
	{
		RuntimeObject* L_0;
		L_0 = U3CSamplesUncheckedU3Ed__40_System_Collections_Generic_IEnumerableU3CSystem_Int32U3E_GetEnumerator_m9695B8349A4904784985C41FE8102AA7FB3A007C(__this, NULL);
		return L_0;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Int32 MathNet.Numerics.Differentiation.FiniteDifferenceCoefficients::get_Points()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t FiniteDifferenceCoefficients_get_Points_mAA4ACE7A8E867B1361D8A67F5E61662943736E00 (FiniteDifferenceCoefficients_t4C297B32541755227C3C396F2EE875CD3C6369DD* __this, const RuntimeMethod* method) 
{
	{
		int32_t L_0 = __this->____points_1;
		return L_0;
	}
}
// System.Void MathNet.Numerics.Differentiation.FiniteDifferenceCoefficients::set_Points(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void FiniteDifferenceCoefficients_set_Points_m53E5CB6A789DDBF44AEF29B4BE0BFFB2B8E8E0E7 (FiniteDifferenceCoefficients_t4C297B32541755227C3C396F2EE875CD3C6369DD* __this, int32_t ___0_value, const RuntimeMethod* method) 
{
	{
		int32_t L_0 = ___0_value;
		FiniteDifferenceCoefficients_CalculateCoefficients_m9049629B7D2D98DB6888ADAADD45D3988A9EE1C6(__this, L_0, NULL);
		int32_t L_1 = ___0_value;
		__this->____points_1 = L_1;
		return;
	}
}
// System.Void MathNet.Numerics.Differentiation.FiniteDifferenceCoefficients::.ctor(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void FiniteDifferenceCoefficients__ctor_mE61D6740E2C00AB440CC04A3A0A3238DCBF7E901 (FiniteDifferenceCoefficients_t4C297B32541755227C3C396F2EE875CD3C6369DD* __this, int32_t ___0_points, const RuntimeMethod* method) 
{
	{
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		int32_t L_0 = ___0_points;
		FiniteDifferenceCoefficients_set_Points_m53E5CB6A789DDBF44AEF29B4BE0BFFB2B8E8E0E7(__this, L_0, NULL);
		int32_t L_1;
		L_1 = FiniteDifferenceCoefficients_get_Points_mAA4ACE7A8E867B1361D8A67F5E61662943736E00_inline(__this, NULL);
		FiniteDifferenceCoefficients_CalculateCoefficients_m9049629B7D2D98DB6888ADAADD45D3988A9EE1C6(__this, L_1, NULL);
		return;
	}
}
// System.Double[] MathNet.Numerics.Differentiation.FiniteDifferenceCoefficients::GetCoefficients(System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* FiniteDifferenceCoefficients_GetCoefficients_m0EF0A6A58D90EFBBCD57331D42A23800EC13664E (FiniteDifferenceCoefficients_t4C297B32541755227C3C396F2EE875CD3C6369DD* __this, int32_t ___0_center, int32_t ___1_order, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* V_1 = NULL;
	int32_t V_2 = 0;
	{
		int32_t L_0 = ___0_center;
		DoubleU5BU2CU5DU5BU5D_tA2205504790CBE64D5959B2C6A51DAFD8916B6BF* L_1 = __this->____coefficients_0;
		NullCheck(L_1);
		if ((((int32_t)L_0) < ((int32_t)((int32_t)(((RuntimeArray*)L_1)->max_length)))))
		{
			goto IL_001b;
		}
	}
	{
		ArgumentOutOfRangeException_tEA2822DAF62B10EEED00E0E3A341D4BAF78CF85F* L_2 = (ArgumentOutOfRangeException_tEA2822DAF62B10EEED00E0E3A341D4BAF78CF85F*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ArgumentOutOfRangeException_tEA2822DAF62B10EEED00E0E3A341D4BAF78CF85F_il2cpp_TypeInfo_var)));
		NullCheck(L_2);
		ArgumentOutOfRangeException__ctor_mE5B2755F0BEA043CACF915D5CE140859EE58FA66(L_2, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteralF26F502B14F503952C33ADFF928357DED0388E8D)), ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral49E8993E0689CABC731C33ACC59BD666AAE09144)), NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_2, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&FiniteDifferenceCoefficients_GetCoefficients_m0EF0A6A58D90EFBBCD57331D42A23800EC13664E_RuntimeMethod_var)));
	}

IL_001b:
	{
		int32_t L_3 = ___1_order;
		DoubleU5BU2CU5DU5BU5D_tA2205504790CBE64D5959B2C6A51DAFD8916B6BF* L_4 = __this->____coefficients_0;
		NullCheck(L_4);
		if ((((int32_t)L_3) < ((int32_t)((int32_t)(((RuntimeArray*)L_4)->max_length)))))
		{
			goto IL_0036;
		}
	}
	{
		ArgumentOutOfRangeException_tEA2822DAF62B10EEED00E0E3A341D4BAF78CF85F* L_5 = (ArgumentOutOfRangeException_tEA2822DAF62B10EEED00E0E3A341D4BAF78CF85F*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ArgumentOutOfRangeException_tEA2822DAF62B10EEED00E0E3A341D4BAF78CF85F_il2cpp_TypeInfo_var)));
		NullCheck(L_5);
		ArgumentOutOfRangeException__ctor_mE5B2755F0BEA043CACF915D5CE140859EE58FA66(L_5, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteralA907D465D395275002F6CB36C016B291C24C7E70)), ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteralFB0EE994B16C328F77EAD6F18E926187CFA36D96)), NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_5, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&FiniteDifferenceCoefficients_GetCoefficients_m0EF0A6A58D90EFBBCD57331D42A23800EC13664E_RuntimeMethod_var)));
	}

IL_0036:
	{
		DoubleU5BU2CU5DU5BU5D_tA2205504790CBE64D5959B2C6A51DAFD8916B6BF* L_6 = __this->____coefficients_0;
		int32_t L_7 = ___0_center;
		NullCheck(L_6);
		int32_t L_8 = L_7;
		DoubleU5BU2CU5D_tA10EAF4C451E6EBC345A8881EBB9EF9441D01AAE* L_9 = (L_6)->GetAt(static_cast<il2cpp_array_size_t>(L_8));
		NullCheck((RuntimeArray*)L_9);
		int32_t L_10;
		L_10 = Array_GetLength_mFE7A9FE891DE1E07795230BE09854441CDD0E935((RuntimeArray*)L_9, 1, NULL);
		V_0 = L_10;
		int32_t L_11 = V_0;
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_12 = (DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE*)(DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE*)SZArrayNew(DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE_il2cpp_TypeInfo_var, (uint32_t)L_11);
		V_1 = L_12;
		V_2 = 0;
		goto IL_0066;
	}

IL_0050:
	{
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_13 = V_1;
		int32_t L_14 = V_2;
		DoubleU5BU2CU5DU5BU5D_tA2205504790CBE64D5959B2C6A51DAFD8916B6BF* L_15 = __this->____coefficients_0;
		int32_t L_16 = ___0_center;
		NullCheck(L_15);
		int32_t L_17 = L_16;
		DoubleU5BU2CU5D_tA10EAF4C451E6EBC345A8881EBB9EF9441D01AAE* L_18 = (L_15)->GetAt(static_cast<il2cpp_array_size_t>(L_17));
		int32_t L_19 = ___1_order;
		int32_t L_20 = V_2;
		NullCheck(L_18);
		double L_21;
		L_21 = (L_18)->GetAt(L_19, L_20);
		NullCheck(L_13);
		(L_13)->SetAt(static_cast<il2cpp_array_size_t>(L_14), (double)L_21);
		int32_t L_22 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add(L_22, 1));
	}

IL_0066:
	{
		int32_t L_23 = V_2;
		int32_t L_24 = V_0;
		if ((((int32_t)L_23) < ((int32_t)L_24)))
		{
			goto IL_0050;
		}
	}
	{
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_25 = V_1;
		return L_25;
	}
}
// System.Double[,] MathNet.Numerics.Differentiation.FiniteDifferenceCoefficients::GetCoefficientsForAllOrders(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR DoubleU5BU2CU5D_tA10EAF4C451E6EBC345A8881EBB9EF9441D01AAE* FiniteDifferenceCoefficients_GetCoefficientsForAllOrders_mF31F126BE46658AA28691BF8A23DE43FD05AAC43 (FiniteDifferenceCoefficients_t4C297B32541755227C3C396F2EE875CD3C6369DD* __this, int32_t ___0_center, const RuntimeMethod* method) 
{
	{
		int32_t L_0 = ___0_center;
		DoubleU5BU2CU5DU5BU5D_tA2205504790CBE64D5959B2C6A51DAFD8916B6BF* L_1 = __this->____coefficients_0;
		NullCheck(L_1);
		if ((((int32_t)L_0) < ((int32_t)((int32_t)(((RuntimeArray*)L_1)->max_length)))))
		{
			goto IL_001b;
		}
	}
	{
		ArgumentOutOfRangeException_tEA2822DAF62B10EEED00E0E3A341D4BAF78CF85F* L_2 = (ArgumentOutOfRangeException_tEA2822DAF62B10EEED00E0E3A341D4BAF78CF85F*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ArgumentOutOfRangeException_tEA2822DAF62B10EEED00E0E3A341D4BAF78CF85F_il2cpp_TypeInfo_var)));
		NullCheck(L_2);
		ArgumentOutOfRangeException__ctor_mE5B2755F0BEA043CACF915D5CE140859EE58FA66(L_2, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteralF26F502B14F503952C33ADFF928357DED0388E8D)), ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral49E8993E0689CABC731C33ACC59BD666AAE09144)), NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_2, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&FiniteDifferenceCoefficients_GetCoefficientsForAllOrders_mF31F126BE46658AA28691BF8A23DE43FD05AAC43_RuntimeMethod_var)));
	}

IL_001b:
	{
		DoubleU5BU2CU5DU5BU5D_tA2205504790CBE64D5959B2C6A51DAFD8916B6BF* L_3 = __this->____coefficients_0;
		int32_t L_4 = ___0_center;
		NullCheck(L_3);
		int32_t L_5 = L_4;
		DoubleU5BU2CU5D_tA10EAF4C451E6EBC345A8881EBB9EF9441D01AAE* L_6 = (L_3)->GetAt(static_cast<il2cpp_array_size_t>(L_5));
		return L_6;
	}
}
// System.Void MathNet.Numerics.Differentiation.FiniteDifferenceCoefficients::CalculateCoefficients(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void FiniteDifferenceCoefficients_CalculateCoefficients_m9049629B7D2D98DB6888ADAADD45D3988A9EE1C6 (FiniteDifferenceCoefficients_t4C297B32541755227C3C396F2EE875CD3C6369DD* __this, int32_t ___0_points, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&DenseMatrix_tEB7C614EBDC0021BA303ED597DC448A8662D8A9F_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&DoubleU5BU2CU5DU5BU5D_tA2205504790CBE64D5959B2C6A51DAFD8916B6BF_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Matrix_1_ToArray_m0F3DB5D9135BA3556C288F91992B1B0C390AAF72_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Matrix_1_get_Item_m9AC37D09D678515B98CFC7C5A3BBECAC3067D9DE_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Matrix_1_set_Item_mC97D847F561C86DD3856B0FA098D2D0529728B67_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SpecialFunctions_tC2E7545045D2156631D348A56D08F8F5D34545DA_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	DoubleU5BU2CU5DU5BU5D_tA2205504790CBE64D5959B2C6A51DAFD8916B6BF* V_0 = NULL;
	int32_t V_1 = 0;
	DenseMatrix_tEB7C614EBDC0021BA303ED597DC448A8662D8A9F* V_2 = NULL;
	int32_t V_3 = 0;
	double V_4 = 0.0;
	int32_t V_5 = 0;
	int32_t V_6 = 0;
	int32_t V_7 = 0;
	int32_t V_8 = 0;
	{
		int32_t L_0 = ___0_points;
		DoubleU5BU2CU5DU5BU5D_tA2205504790CBE64D5959B2C6A51DAFD8916B6BF* L_1 = (DoubleU5BU2CU5DU5BU5D_tA2205504790CBE64D5959B2C6A51DAFD8916B6BF*)(DoubleU5BU2CU5DU5BU5D_tA2205504790CBE64D5959B2C6A51DAFD8916B6BF*)SZArrayNew(DoubleU5BU2CU5DU5BU5D_tA2205504790CBE64D5959B2C6A51DAFD8916B6BF_il2cpp_TypeInfo_var, (uint32_t)L_0);
		V_0 = L_1;
		V_1 = 0;
		goto IL_00ce;
	}

IL_000e:
	{
		int32_t L_2 = ___0_points;
		DenseMatrix_tEB7C614EBDC0021BA303ED597DC448A8662D8A9F* L_3 = (DenseMatrix_tEB7C614EBDC0021BA303ED597DC448A8662D8A9F*)il2cpp_codegen_object_new(DenseMatrix_tEB7C614EBDC0021BA303ED597DC448A8662D8A9F_il2cpp_TypeInfo_var);
		NullCheck(L_3);
		DenseMatrix__ctor_m9A77ED10BA74106ADAC117999AA6C9CB9D8CDD30(L_3, L_2, NULL);
		V_2 = L_3;
		int32_t L_4 = ___0_points;
		int32_t L_5 = V_1;
		V_3 = ((int32_t)il2cpp_codegen_subtract(((int32_t)il2cpp_codegen_subtract(L_4, L_5)), 1));
		int32_t L_6 = ___0_points;
		V_5 = ((int32_t)il2cpp_codegen_subtract(L_6, 1));
		goto IL_006b;
	}

IL_0022:
	{
		DenseMatrix_tEB7C614EBDC0021BA303ED597DC448A8662D8A9F* L_7 = V_2;
		int32_t L_8 = V_5;
		NullCheck(L_7);
		Matrix_1_set_Item_mC97D847F561C86DD3856B0FA098D2D0529728B67_inline(L_7, L_8, 0, (1.0), Matrix_1_set_Item_mC97D847F561C86DD3856B0FA098D2D0529728B67_RuntimeMethod_var);
		V_6 = 1;
		goto IL_005c;
	}

IL_0039:
	{
		DenseMatrix_tEB7C614EBDC0021BA303ED597DC448A8662D8A9F* L_9 = V_2;
		int32_t L_10 = V_5;
		int32_t L_11 = V_6;
		DenseMatrix_tEB7C614EBDC0021BA303ED597DC448A8662D8A9F* L_12 = V_2;
		int32_t L_13 = V_5;
		int32_t L_14 = V_6;
		NullCheck(L_12);
		double L_15;
		L_15 = Matrix_1_get_Item_m9AC37D09D678515B98CFC7C5A3BBECAC3067D9DE_inline(L_12, L_13, ((int32_t)il2cpp_codegen_subtract(L_14, 1)), Matrix_1_get_Item_m9AC37D09D678515B98CFC7C5A3BBECAC3067D9DE_RuntimeMethod_var);
		int32_t L_16 = V_3;
		int32_t L_17 = V_6;
		NullCheck(L_9);
		Matrix_1_set_Item_mC97D847F561C86DD3856B0FA098D2D0529728B67_inline(L_9, L_10, L_11, ((double)(((double)il2cpp_codegen_multiply(L_15, ((double)L_16)))/((double)L_17))), Matrix_1_set_Item_mC97D847F561C86DD3856B0FA098D2D0529728B67_RuntimeMethod_var);
		int32_t L_18 = V_6;
		V_6 = ((int32_t)il2cpp_codegen_add(L_18, 1));
	}

IL_005c:
	{
		int32_t L_19 = V_6;
		int32_t L_20 = ___0_points;
		if ((((int32_t)L_19) < ((int32_t)L_20)))
		{
			goto IL_0039;
		}
	}
	{
		int32_t L_21 = V_3;
		V_3 = ((int32_t)il2cpp_codegen_subtract(L_21, 1));
		int32_t L_22 = V_5;
		V_5 = ((int32_t)il2cpp_codegen_subtract(L_22, 1));
	}

IL_006b:
	{
		int32_t L_23 = V_5;
		if ((((int32_t)L_23) >= ((int32_t)0)))
		{
			goto IL_0022;
		}
	}
	{
		DoubleU5BU2CU5DU5BU5D_tA2205504790CBE64D5959B2C6A51DAFD8916B6BF* L_24 = V_0;
		int32_t L_25 = V_1;
		DenseMatrix_tEB7C614EBDC0021BA303ED597DC448A8662D8A9F* L_26 = V_2;
		NullCheck(L_26);
		Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* L_27;
		L_27 = VirtualFuncInvoker0< Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* >::Invoke(67 /* MathNet.Numerics.LinearAlgebra.Matrix`1<T> MathNet.Numerics.LinearAlgebra.Matrix`1<System.Double>::Inverse() */, L_26);
		NullCheck(L_27);
		DoubleU5BU2CU5D_tA10EAF4C451E6EBC345A8881EBB9EF9441D01AAE* L_28;
		L_28 = Matrix_1_ToArray_m0F3DB5D9135BA3556C288F91992B1B0C390AAF72(L_27, Matrix_1_ToArray_m0F3DB5D9135BA3556C288F91992B1B0C390AAF72_RuntimeMethod_var);
		NullCheck(L_24);
		ArrayElementTypeCheck (L_24, L_28);
		(L_24)->SetAt(static_cast<il2cpp_array_size_t>(L_25), (DoubleU5BU2CU5D_tA10EAF4C451E6EBC345A8881EBB9EF9441D01AAE*)L_28);
		int32_t L_29 = ___0_points;
		il2cpp_codegen_runtime_class_init_inline(SpecialFunctions_tC2E7545045D2156631D348A56D08F8F5D34545DA_il2cpp_TypeInfo_var);
		double L_30;
		L_30 = SpecialFunctions_Factorial_mA03982EFC69960F81FB44F06B8443026836FA39C(L_29, NULL);
		V_4 = L_30;
		V_7 = 0;
		goto IL_00c5;
	}

IL_008b:
	{
		V_8 = 0;
		goto IL_00ba;
	}

IL_0090:
	{
		DoubleU5BU2CU5DU5BU5D_tA2205504790CBE64D5959B2C6A51DAFD8916B6BF* L_31 = V_0;
		int32_t L_32 = V_1;
		NullCheck(L_31);
		int32_t L_33 = L_32;
		DoubleU5BU2CU5D_tA10EAF4C451E6EBC345A8881EBB9EF9441D01AAE* L_34 = (L_31)->GetAt(static_cast<il2cpp_array_size_t>(L_33));
		int32_t L_35 = V_7;
		int32_t L_36 = V_8;
		DoubleU5BU2CU5DU5BU5D_tA2205504790CBE64D5959B2C6A51DAFD8916B6BF* L_37 = V_0;
		int32_t L_38 = V_1;
		NullCheck(L_37);
		int32_t L_39 = L_38;
		DoubleU5BU2CU5D_tA10EAF4C451E6EBC345A8881EBB9EF9441D01AAE* L_40 = (L_37)->GetAt(static_cast<il2cpp_array_size_t>(L_39));
		int32_t L_41 = V_7;
		int32_t L_42 = V_8;
		NullCheck(L_40);
		double L_43;
		L_43 = (L_40)->GetAt(L_41, L_42);
		double L_44 = V_4;
		il2cpp_codegen_runtime_class_init_inline(Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		double L_45;
		L_45 = Math_Round_mAD8888A4B6E25BBA84A6C87535E68689BC4F46C8_inline(((double)il2cpp_codegen_multiply(L_43, L_44)), 1, NULL);
		double L_46 = V_4;
		NullCheck(L_34);
		(L_34)->SetAt(L_35, L_36, ((double)(L_45/L_46)));
		int32_t L_47 = V_8;
		V_8 = ((int32_t)il2cpp_codegen_add(L_47, 1));
	}

IL_00ba:
	{
		int32_t L_48 = V_8;
		int32_t L_49 = ___0_points;
		if ((((int32_t)L_48) < ((int32_t)L_49)))
		{
			goto IL_0090;
		}
	}
	{
		int32_t L_50 = V_7;
		V_7 = ((int32_t)il2cpp_codegen_add(L_50, 1));
	}

IL_00c5:
	{
		int32_t L_51 = V_7;
		int32_t L_52 = ___0_points;
		if ((((int32_t)L_51) < ((int32_t)L_52)))
		{
			goto IL_008b;
		}
	}
	{
		int32_t L_53 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add(L_53, 1));
	}

IL_00ce:
	{
		int32_t L_54 = V_1;
		int32_t L_55 = ___0_points;
		if ((((int32_t)L_54) < ((int32_t)L_55)))
		{
			goto IL_000e;
		}
	}
	{
		DoubleU5BU2CU5DU5BU5D_tA2205504790CBE64D5959B2C6A51DAFD8916B6BF* L_56 = V_0;
		__this->____coefficients_0 = L_56;
		Il2CppCodeGenWriteBarrier((void**)(&__this->____coefficients_0), (void*)L_56);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void MathNet.Numerics.Differentiation.NumericalDerivative::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NumericalDerivative__ctor_m976745090E656C667193B46CE7A3CC1FA3E3DFFC (NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* __this, const RuntimeMethod* method) 
{
	{
		NumericalDerivative__ctor_m94BF5A04E867018682D56B120B89E5B00595739E(__this, 3, 1, NULL);
		return;
	}
}
// System.Void MathNet.Numerics.Differentiation.NumericalDerivative::.ctor(System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NumericalDerivative__ctor_m94BF5A04E867018682D56B120B89E5B00595739E (NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* __this, int32_t ___0_points, int32_t ___1_center, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&FiniteDifferenceCoefficients_t4C297B32541755227C3C396F2EE875CD3C6369DD_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Precision_t995E3F8DD8836E0C854058E41426915A50908C0C_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		il2cpp_codegen_runtime_class_init_inline(Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		double L_0;
		L_0 = Math_Pow_mEAE651F0858203FBE12B72B6A53951BBD0FB5265((2.0), (-10.0), NULL);
		__this->____stepSize_2 = L_0;
		il2cpp_codegen_runtime_class_init_inline(Precision_t995E3F8DD8836E0C854058E41426915A50908C0C_il2cpp_TypeInfo_var);
		double L_1 = ((Precision_t995E3F8DD8836E0C854058E41426915A50908C0C_StaticFields*)il2cpp_codegen_static_fields_for(Precision_t995E3F8DD8836E0C854058E41426915A50908C0C_il2cpp_TypeInfo_var))->___PositiveMachineEpsilon_7;
		__this->____epsilon_3 = L_1;
		double L_2;
		L_2 = Math_Pow_mEAE651F0858203FBE12B72B6A53951BBD0FB5265((2.0), (-26.0), NULL);
		__this->____baseStepSize_4 = L_2;
		__this->___U3CStepTypeU3Ek__BackingField_7 = 2;
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		int32_t L_3 = ___0_points;
		if ((((int32_t)L_3) >= ((int32_t)2)))
		{
			goto IL_0066;
		}
	}
	{
		ArgumentOutOfRangeException_tEA2822DAF62B10EEED00E0E3A341D4BAF78CF85F* L_4 = (ArgumentOutOfRangeException_tEA2822DAF62B10EEED00E0E3A341D4BAF78CF85F*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ArgumentOutOfRangeException_tEA2822DAF62B10EEED00E0E3A341D4BAF78CF85F_il2cpp_TypeInfo_var)));
		NullCheck(L_4);
		ArgumentOutOfRangeException__ctor_mE5B2755F0BEA043CACF915D5CE140859EE58FA66(L_4, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral17A7BA088490CA1D9307C4F7F07BDC92703EDF51)), ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteralEB5675C9AF0CC71BA66A836D19B5F2E3A937F632)), NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_4, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&NumericalDerivative__ctor_m94BF5A04E867018682D56B120B89E5B00595739E_RuntimeMethod_var)));
	}

IL_0066:
	{
		int32_t L_5 = ___1_center;
		__this->____center_1 = L_5;
		int32_t L_6 = ___0_points;
		__this->____points_0 = L_6;
		int32_t L_7 = ___1_center;
		NumericalDerivative_set_Center_mFA5EE04E3C7CF245411FF33E80928D962383513E(__this, L_7, NULL);
		int32_t L_8 = ___0_points;
		FiniteDifferenceCoefficients_t4C297B32541755227C3C396F2EE875CD3C6369DD* L_9 = (FiniteDifferenceCoefficients_t4C297B32541755227C3C396F2EE875CD3C6369DD*)il2cpp_codegen_object_new(FiniteDifferenceCoefficients_t4C297B32541755227C3C396F2EE875CD3C6369DD_il2cpp_TypeInfo_var);
		NullCheck(L_9);
		FiniteDifferenceCoefficients__ctor_mE61D6740E2C00AB440CC04A3A0A3238DCBF7E901(L_9, L_8, NULL);
		__this->____coefficients_5 = L_9;
		Il2CppCodeGenWriteBarrier((void**)(&__this->____coefficients_5), (void*)L_9);
		return;
	}
}
// System.Double MathNet.Numerics.Differentiation.NumericalDerivative::get_StepSize()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double NumericalDerivative_get_StepSize_m13C020A5C6ADCE52FF19373914AF86C84F3B58B5 (NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* __this, const RuntimeMethod* method) 
{
	{
		double L_0 = __this->____stepSize_2;
		return L_0;
	}
}
// System.Void MathNet.Numerics.Differentiation.NumericalDerivative::set_StepSize(System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NumericalDerivative_set_StepSize_m1D5FF4430F889F96CAFECF3F8B57FD3C109334BF (NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* __this, double ___0_value, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	double V_0 = 0.0;
	{
		double L_0 = ___0_value;
		il2cpp_codegen_runtime_class_init_inline(Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		double L_1;
		L_1 = fabs(L_0);
		double L_2;
		L_2 = log(L_1);
		double L_3;
		L_3 = log((2.0));
		V_0 = ((double)(L_2/L_3));
		double L_4 = V_0;
		double L_5;
		L_5 = bankers_round(L_4);
		double L_6;
		L_6 = Math_Pow_mEAE651F0858203FBE12B72B6A53951BBD0FB5265((2.0), L_5, NULL);
		__this->____stepSize_2 = L_6;
		return;
	}
}
// System.Double MathNet.Numerics.Differentiation.NumericalDerivative::get_BaseStepSize()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double NumericalDerivative_get_BaseStepSize_mFAE6FF2D0717BF1E60A83EB6706241C50E154F17 (NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* __this, const RuntimeMethod* method) 
{
	{
		double L_0 = __this->____baseStepSize_4;
		return L_0;
	}
}
// System.Void MathNet.Numerics.Differentiation.NumericalDerivative::set_BaseStepSize(System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NumericalDerivative_set_BaseStepSize_mAB871F65B8912C4DE512F44D18E83A4F2644F1F3 (NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* __this, double ___0_value, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	double V_0 = 0.0;
	{
		double L_0 = ___0_value;
		il2cpp_codegen_runtime_class_init_inline(Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		double L_1;
		L_1 = fabs(L_0);
		double L_2;
		L_2 = log(L_1);
		double L_3;
		L_3 = log((2.0));
		V_0 = ((double)(L_2/L_3));
		double L_4 = V_0;
		double L_5;
		L_5 = bankers_round(L_4);
		double L_6;
		L_6 = Math_Pow_mEAE651F0858203FBE12B72B6A53951BBD0FB5265((2.0), L_5, NULL);
		__this->____baseStepSize_4 = L_6;
		return;
	}
}
// System.Double MathNet.Numerics.Differentiation.NumericalDerivative::get_Epsilon()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double NumericalDerivative_get_Epsilon_mAA8717E023550582F3C2D9E6A89EF3E4723479AF (NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* __this, const RuntimeMethod* method) 
{
	{
		double L_0 = __this->____epsilon_3;
		return L_0;
	}
}
// System.Void MathNet.Numerics.Differentiation.NumericalDerivative::set_Epsilon(System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NumericalDerivative_set_Epsilon_m8172DE875E1D1FAD125BE122F6FA03FA4D36DF3E (NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* __this, double ___0_value, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	double V_0 = 0.0;
	{
		double L_0 = ___0_value;
		il2cpp_codegen_runtime_class_init_inline(Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		double L_1;
		L_1 = fabs(L_0);
		double L_2;
		L_2 = log(L_1);
		double L_3;
		L_3 = log((2.0));
		V_0 = ((double)(L_2/L_3));
		double L_4 = V_0;
		double L_5;
		L_5 = bankers_round(L_4);
		double L_6;
		L_6 = Math_Pow_mEAE651F0858203FBE12B72B6A53951BBD0FB5265((2.0), L_5, NULL);
		__this->____epsilon_3 = L_6;
		return;
	}
}
// System.Int32 MathNet.Numerics.Differentiation.NumericalDerivative::get_Center()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t NumericalDerivative_get_Center_m2A342DC5FBB8EAA82940F5D32883217021ACECD6 (NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* __this, const RuntimeMethod* method) 
{
	{
		int32_t L_0 = __this->____center_1;
		return L_0;
	}
}
// System.Void MathNet.Numerics.Differentiation.NumericalDerivative::set_Center(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NumericalDerivative_set_Center_mFA5EE04E3C7CF245411FF33E80928D962383513E (NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* __this, int32_t ___0_value, const RuntimeMethod* method) 
{
	{
		int32_t L_0 = ___0_value;
		int32_t L_1 = __this->____points_0;
		if ((((int32_t)L_0) >= ((int32_t)L_1)))
		{
			goto IL_000d;
		}
	}
	{
		int32_t L_2 = ___0_value;
		if ((((int32_t)L_2) >= ((int32_t)0)))
		{
			goto IL_001d;
		}
	}

IL_000d:
	{
		ArgumentOutOfRangeException_tEA2822DAF62B10EEED00E0E3A341D4BAF78CF85F* L_3 = (ArgumentOutOfRangeException_tEA2822DAF62B10EEED00E0E3A341D4BAF78CF85F*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ArgumentOutOfRangeException_tEA2822DAF62B10EEED00E0E3A341D4BAF78CF85F_il2cpp_TypeInfo_var)));
		NullCheck(L_3);
		ArgumentOutOfRangeException__ctor_mE5B2755F0BEA043CACF915D5CE140859EE58FA66(L_3, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral46F273EF641E07D271D91E0DC24A4392582671F8)), ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteralEDB4B72A6850FC1446A2DF40F1A7B1CEB22C5283)), NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_3, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&NumericalDerivative_set_Center_mFA5EE04E3C7CF245411FF33E80928D962383513E_RuntimeMethod_var)));
	}

IL_001d:
	{
		int32_t L_4 = ___0_value;
		__this->____center_1 = L_4;
		return;
	}
}
// System.Int32 MathNet.Numerics.Differentiation.NumericalDerivative::get_Evaluations()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t NumericalDerivative_get_Evaluations_mCA8A041C5842CB4239707CB207A053D3037151FE (NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* __this, const RuntimeMethod* method) 
{
	{
		int32_t L_0 = __this->___U3CEvaluationsU3Ek__BackingField_6;
		return L_0;
	}
}
// System.Void MathNet.Numerics.Differentiation.NumericalDerivative::set_Evaluations(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NumericalDerivative_set_Evaluations_mCCE3A9BE2B152CFFC6B9C02EEC6641E392048042 (NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* __this, int32_t ___0_value, const RuntimeMethod* method) 
{
	{
		int32_t L_0 = ___0_value;
		__this->___U3CEvaluationsU3Ek__BackingField_6 = L_0;
		return;
	}
}
// MathNet.Numerics.Differentiation.StepType MathNet.Numerics.Differentiation.NumericalDerivative::get_StepType()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t NumericalDerivative_get_StepType_m9067F9BAD716966954DD4090822BF911594D592F (NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* __this, const RuntimeMethod* method) 
{
	{
		int32_t L_0 = __this->___U3CStepTypeU3Ek__BackingField_7;
		return L_0;
	}
}
// System.Void MathNet.Numerics.Differentiation.NumericalDerivative::set_StepType(MathNet.Numerics.Differentiation.StepType)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NumericalDerivative_set_StepType_m95CB8374FFCC2B94F61CA2982B1301C4DCE21035 (NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* __this, int32_t ___0_value, const RuntimeMethod* method) 
{
	{
		int32_t L_0 = ___0_value;
		__this->___U3CStepTypeU3Ek__BackingField_7 = L_0;
		return;
	}
}
// System.Double MathNet.Numerics.Differentiation.NumericalDerivative::EvaluateDerivative(System.Double[],System.Int32,System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double NumericalDerivative_EvaluateDerivative_mCDBA97154622BE221740EF0643F7D685D82F1004 (NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* __this, DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* ___0_points, int32_t ___1_order, double ___2_stepSize, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Enumerable_Select_TisDouble_tE150EF3D1D43DEE85D533810AB4C742307EEDE5F_TisDouble_tE150EF3D1D43DEE85D533810AB4C742307EEDE5F_mB588D15462B1F933FD6F77574674E0999EC99B62_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Func_3_t4A84D23D01C9E182A3CFA36E5B7F3F13F9B82367_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CU3Ec__DisplayClass28_0_U3CEvaluateDerivativeU3Eb__0_m1D184DE944EE44A477CF4873E26E76B1EF29B6C1_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CU3Ec__DisplayClass28_0_t1E475037E430264975A0956BD27AA2971F0532BC_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	U3CU3Ec__DisplayClass28_0_t1E475037E430264975A0956BD27AA2971F0532BC* V_0 = NULL;
	{
		U3CU3Ec__DisplayClass28_0_t1E475037E430264975A0956BD27AA2971F0532BC* L_0 = (U3CU3Ec__DisplayClass28_0_t1E475037E430264975A0956BD27AA2971F0532BC*)il2cpp_codegen_object_new(U3CU3Ec__DisplayClass28_0_t1E475037E430264975A0956BD27AA2971F0532BC_il2cpp_TypeInfo_var);
		NullCheck(L_0);
		U3CU3Ec__DisplayClass28_0__ctor_mAEF3FED953F7D9BC82E503B819024AD3D38C87BA(L_0, NULL);
		V_0 = L_0;
		U3CU3Ec__DisplayClass28_0_t1E475037E430264975A0956BD27AA2971F0532BC* L_1 = V_0;
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_2 = ___0_points;
		NullCheck(L_1);
		L_1->___points_0 = L_2;
		Il2CppCodeGenWriteBarrier((void**)(&L_1->___points_0), (void*)L_2);
		U3CU3Ec__DisplayClass28_0_t1E475037E430264975A0956BD27AA2971F0532BC* L_3 = V_0;
		NullCheck(L_3);
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_4 = L_3->___points_0;
		if (L_4)
		{
			goto IL_0020;
		}
	}
	{
		ArgumentNullException_t327031E412FAB2351B0022DD5DAD47E67E597129* L_5 = (ArgumentNullException_t327031E412FAB2351B0022DD5DAD47E67E597129*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ArgumentNullException_t327031E412FAB2351B0022DD5DAD47E67E597129_il2cpp_TypeInfo_var)));
		NullCheck(L_5);
		ArgumentNullException__ctor_m444AE141157E333844FC1A9500224C2F9FD24F4B(L_5, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral17A7BA088490CA1D9307C4F7F07BDC92703EDF51)), NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_5, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&NumericalDerivative_EvaluateDerivative_mCDBA97154622BE221740EF0643F7D685D82F1004_RuntimeMethod_var)));
	}

IL_0020:
	{
		int32_t L_6 = ___1_order;
		int32_t L_7 = __this->____points_0;
		if ((((int32_t)L_6) >= ((int32_t)L_7)))
		{
			goto IL_002d;
		}
	}
	{
		int32_t L_8 = ___1_order;
		if ((((int32_t)L_8) >= ((int32_t)0)))
		{
			goto IL_003d;
		}
	}

IL_002d:
	{
		ArgumentOutOfRangeException_tEA2822DAF62B10EEED00E0E3A341D4BAF78CF85F* L_9 = (ArgumentOutOfRangeException_tEA2822DAF62B10EEED00E0E3A341D4BAF78CF85F*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ArgumentOutOfRangeException_tEA2822DAF62B10EEED00E0E3A341D4BAF78CF85F_il2cpp_TypeInfo_var)));
		NullCheck(L_9);
		ArgumentOutOfRangeException__ctor_mE5B2755F0BEA043CACF915D5CE140859EE58FA66(L_9, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteralA907D465D395275002F6CB36C016B291C24C7E70)), ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral69FC133B7461295F45AF4CCC31336B4BCF6DDA7B)), NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_9, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&NumericalDerivative_EvaluateDerivative_mCDBA97154622BE221740EF0643F7D685D82F1004_RuntimeMethod_var)));
	}

IL_003d:
	{
		FiniteDifferenceCoefficients_t4C297B32541755227C3C396F2EE875CD3C6369DD* L_10 = __this->____coefficients_5;
		int32_t L_11;
		L_11 = NumericalDerivative_get_Center_m2A342DC5FBB8EAA82940F5D32883217021ACECD6_inline(__this, NULL);
		int32_t L_12 = ___1_order;
		NullCheck(L_10);
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_13;
		L_13 = FiniteDifferenceCoefficients_GetCoefficients_m0EF0A6A58D90EFBBCD57331D42A23800EC13664E(L_10, L_11, L_12, NULL);
		U3CU3Ec__DisplayClass28_0_t1E475037E430264975A0956BD27AA2971F0532BC* L_14 = V_0;
		Func_3_t4A84D23D01C9E182A3CFA36E5B7F3F13F9B82367* L_15 = (Func_3_t4A84D23D01C9E182A3CFA36E5B7F3F13F9B82367*)il2cpp_codegen_object_new(Func_3_t4A84D23D01C9E182A3CFA36E5B7F3F13F9B82367_il2cpp_TypeInfo_var);
		NullCheck(L_15);
		Func_3__ctor_m3CD5133CBCB6F0EA58618ADE3B4635342495E6B9(L_15, L_14, (intptr_t)((void*)U3CU3Ec__DisplayClass28_0_U3CEvaluateDerivativeU3Eb__0_m1D184DE944EE44A477CF4873E26E76B1EF29B6C1_RuntimeMethod_var), NULL);
		RuntimeObject* L_16;
		L_16 = Enumerable_Select_TisDouble_tE150EF3D1D43DEE85D533810AB4C742307EEDE5F_TisDouble_tE150EF3D1D43DEE85D533810AB4C742307EEDE5F_mB588D15462B1F933FD6F77574674E0999EC99B62((RuntimeObject*)L_13, L_15, Enumerable_Select_TisDouble_tE150EF3D1D43DEE85D533810AB4C742307EEDE5F_TisDouble_tE150EF3D1D43DEE85D533810AB4C742307EEDE5F_mB588D15462B1F933FD6F77574674E0999EC99B62_RuntimeMethod_var);
		double L_17;
		L_17 = Enumerable_Sum_mB4B29B0D6E567EB810D0B439945F9BC6ACC01284(L_16, NULL);
		double L_18 = ___2_stepSize;
		int32_t L_19 = ___1_order;
		il2cpp_codegen_runtime_class_init_inline(Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		double L_20;
		L_20 = Math_Pow_mEAE651F0858203FBE12B72B6A53951BBD0FB5265(L_18, ((double)L_19), NULL);
		return ((double)(L_17/L_20));
	}
}
// System.Double MathNet.Numerics.Differentiation.NumericalDerivative::EvaluateDerivative(System.Func`2<System.Double,System.Double>,System.Double,System.Int32,System.Nullable`1<System.Double>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double NumericalDerivative_EvaluateDerivative_m4D6F74A0B7826E6CD850B8D34DC3D91EA2AC0B21 (NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* __this, Func_2_t0221E9CE1FF8B8FE59AED052D562790B96F13B3D* ___0_f, double ___1_x, int32_t ___2_order, Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165 ___3_currentValue, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Nullable_1_get_HasValue_mC082C667C8EB3A6CA80E06BCAEA0BED00C6BC15A_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Nullable_1_get_Value_m260A5CB9269FD3E130F998A589EDAEC2E8F9EAE1_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* V_0 = NULL;
	double V_1 = 0.0;
	DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* V_2 = NULL;
	int32_t V_3 = 0;
	int32_t V_4 = 0;
	{
		FiniteDifferenceCoefficients_t4C297B32541755227C3C396F2EE875CD3C6369DD* L_0 = __this->____coefficients_5;
		int32_t L_1;
		L_1 = NumericalDerivative_get_Center_m2A342DC5FBB8EAA82940F5D32883217021ACECD6_inline(__this, NULL);
		int32_t L_2 = ___2_order;
		NullCheck(L_0);
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_3;
		L_3 = FiniteDifferenceCoefficients_GetCoefficients_m0EF0A6A58D90EFBBCD57331D42A23800EC13664E(L_0, L_1, L_2, NULL);
		V_0 = L_3;
		int32_t L_4 = __this->____points_0;
		double L_5 = ___1_x;
		int32_t L_6 = ___2_order;
		double L_7;
		L_7 = NumericalDerivative_CalculateStepSize_m6DD2C80785010974B05485A22594397FA6A166FB(__this, L_4, L_5, ((double)L_6), NULL);
		V_1 = L_7;
		int32_t L_8 = __this->____points_0;
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_9 = (DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE*)(DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE*)SZArrayNew(DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE_il2cpp_TypeInfo_var, (uint32_t)L_8);
		V_2 = L_9;
		V_3 = 0;
		goto IL_008b;
	}

IL_0033:
	{
		int32_t L_10 = V_3;
		int32_t L_11;
		L_11 = NumericalDerivative_get_Center_m2A342DC5FBB8EAA82940F5D32883217021ACECD6_inline(__this, NULL);
		if ((!(((uint32_t)L_10) == ((uint32_t)L_11))))
		{
			goto IL_0051;
		}
	}
	{
		bool L_12;
		L_12 = Nullable_1_get_HasValue_mC082C667C8EB3A6CA80E06BCAEA0BED00C6BC15A_inline((&___3_currentValue), Nullable_1_get_HasValue_mC082C667C8EB3A6CA80E06BCAEA0BED00C6BC15A_RuntimeMethod_var);
		if (!L_12)
		{
			goto IL_0051;
		}
	}
	{
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_13 = V_2;
		int32_t L_14 = V_3;
		double L_15;
		L_15 = Nullable_1_get_Value_m260A5CB9269FD3E130F998A589EDAEC2E8F9EAE1((&___3_currentValue), Nullable_1_get_Value_m260A5CB9269FD3E130F998A589EDAEC2E8F9EAE1_RuntimeMethod_var);
		NullCheck(L_13);
		(L_13)->SetAt(static_cast<il2cpp_array_size_t>(L_14), (double)L_15);
		goto IL_0087;
	}

IL_0051:
	{
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_16 = V_0;
		int32_t L_17 = V_3;
		NullCheck(L_16);
		int32_t L_18 = L_17;
		double L_19 = (L_16)->GetAt(static_cast<il2cpp_array_size_t>(L_18));
		if ((((double)L_19) == ((double)(0.0))))
		{
			goto IL_0087;
		}
	}
	{
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_20 = V_2;
		int32_t L_21 = V_3;
		Func_2_t0221E9CE1FF8B8FE59AED052D562790B96F13B3D* L_22 = ___0_f;
		double L_23 = ___1_x;
		int32_t L_24 = V_3;
		int32_t L_25;
		L_25 = NumericalDerivative_get_Center_m2A342DC5FBB8EAA82940F5D32883217021ACECD6_inline(__this, NULL);
		double L_26 = V_1;
		NullCheck(L_22);
		double L_27;
		L_27 = Func_2_Invoke_m762147834B46FC6B99180328AD303FC3F47CCD62_inline(L_22, ((double)il2cpp_codegen_add(L_23, ((double)il2cpp_codegen_multiply(((double)((int32_t)il2cpp_codegen_subtract(L_24, L_25))), L_26)))), NULL);
		NullCheck(L_20);
		(L_20)->SetAt(static_cast<il2cpp_array_size_t>(L_21), (double)L_27);
		int32_t L_28;
		L_28 = NumericalDerivative_get_Evaluations_mCA8A041C5842CB4239707CB207A053D3037151FE_inline(__this, NULL);
		V_4 = L_28;
		int32_t L_29 = V_4;
		NumericalDerivative_set_Evaluations_mCCE3A9BE2B152CFFC6B9C02EEC6641E392048042_inline(__this, ((int32_t)il2cpp_codegen_add(L_29, 1)), NULL);
	}

IL_0087:
	{
		int32_t L_30 = V_3;
		V_3 = ((int32_t)il2cpp_codegen_add(L_30, 1));
	}

IL_008b:
	{
		int32_t L_31 = V_3;
		int32_t L_32 = __this->____points_0;
		if ((((int32_t)L_31) < ((int32_t)L_32)))
		{
			goto IL_0033;
		}
	}
	{
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_33 = V_2;
		int32_t L_34 = ___2_order;
		double L_35 = V_1;
		double L_36;
		L_36 = NumericalDerivative_EvaluateDerivative_mCDBA97154622BE221740EF0643F7D685D82F1004(__this, L_33, L_34, L_35, NULL);
		return L_36;
	}
}
// System.Func`2<System.Double,System.Double> MathNet.Numerics.Differentiation.NumericalDerivative::CreateDerivativeFunctionHandle(System.Func`2<System.Double,System.Double>,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Func_2_t0221E9CE1FF8B8FE59AED052D562790B96F13B3D* NumericalDerivative_CreateDerivativeFunctionHandle_m9B66115DD17505B8736D44EE0266112C6B465E70 (NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* __this, Func_2_t0221E9CE1FF8B8FE59AED052D562790B96F13B3D* ___0_f, int32_t ___1_order, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Func_2_t0221E9CE1FF8B8FE59AED052D562790B96F13B3D_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CU3Ec__DisplayClass30_0_U3CCreateDerivativeFunctionHandleU3Eb__0_mF7EE56846A2440ED151B2A5DE00E1D1AE75A45B5_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CU3Ec__DisplayClass30_0_tBBEEC61B57C35572AA699E79175C25C8F2D7AEBC_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		U3CU3Ec__DisplayClass30_0_tBBEEC61B57C35572AA699E79175C25C8F2D7AEBC* L_0 = (U3CU3Ec__DisplayClass30_0_tBBEEC61B57C35572AA699E79175C25C8F2D7AEBC*)il2cpp_codegen_object_new(U3CU3Ec__DisplayClass30_0_tBBEEC61B57C35572AA699E79175C25C8F2D7AEBC_il2cpp_TypeInfo_var);
		NullCheck(L_0);
		U3CU3Ec__DisplayClass30_0__ctor_mDA8A74FD9E157F81603A64A51886C3E0C7E30DDA(L_0, NULL);
		U3CU3Ec__DisplayClass30_0_tBBEEC61B57C35572AA699E79175C25C8F2D7AEBC* L_1 = L_0;
		NullCheck(L_1);
		L_1->___U3CU3E4__this_0 = __this;
		Il2CppCodeGenWriteBarrier((void**)(&L_1->___U3CU3E4__this_0), (void*)__this);
		U3CU3Ec__DisplayClass30_0_tBBEEC61B57C35572AA699E79175C25C8F2D7AEBC* L_2 = L_1;
		Func_2_t0221E9CE1FF8B8FE59AED052D562790B96F13B3D* L_3 = ___0_f;
		NullCheck(L_2);
		L_2->___f_1 = L_3;
		Il2CppCodeGenWriteBarrier((void**)(&L_2->___f_1), (void*)L_3);
		U3CU3Ec__DisplayClass30_0_tBBEEC61B57C35572AA699E79175C25C8F2D7AEBC* L_4 = L_2;
		int32_t L_5 = ___1_order;
		NullCheck(L_4);
		L_4->___order_2 = L_5;
		Func_2_t0221E9CE1FF8B8FE59AED052D562790B96F13B3D* L_6 = (Func_2_t0221E9CE1FF8B8FE59AED052D562790B96F13B3D*)il2cpp_codegen_object_new(Func_2_t0221E9CE1FF8B8FE59AED052D562790B96F13B3D_il2cpp_TypeInfo_var);
		NullCheck(L_6);
		Func_2__ctor_m653F26D531BA0409921E01E3994462FC75138745(L_6, L_4, (intptr_t)((void*)U3CU3Ec__DisplayClass30_0_U3CCreateDerivativeFunctionHandleU3Eb__0_mF7EE56846A2440ED151B2A5DE00E1D1AE75A45B5_RuntimeMethod_var), NULL);
		return L_6;
	}
}
// System.Double MathNet.Numerics.Differentiation.NumericalDerivative::EvaluatePartialDerivative(System.Func`2<System.Double[],System.Double>,System.Double[],System.Int32,System.Int32,System.Nullable`1<System.Double>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double NumericalDerivative_EvaluatePartialDerivative_mDE906B586F0CCE53070CC5DCB0670419D1F22D87 (NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* __this, Func_2_t89B8106282004E94AE869931CD4E1DF667EB235E* ___0_f, DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* ___1_x, int32_t ___2_parameterIndex, int32_t ___3_order, Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165 ___4_currentValue, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Nullable_1_get_HasValue_mC082C667C8EB3A6CA80E06BCAEA0BED00C6BC15A_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Nullable_1_get_Value_m260A5CB9269FD3E130F998A589EDAEC2E8F9EAE1_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	double V_0 = 0.0;
	DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* V_1 = NULL;
	double V_2 = 0.0;
	DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* V_3 = NULL;
	int32_t V_4 = 0;
	int32_t V_5 = 0;
	{
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_0 = ___1_x;
		int32_t L_1 = ___2_parameterIndex;
		NullCheck(L_0);
		int32_t L_2 = L_1;
		double L_3 = (L_0)->GetAt(static_cast<il2cpp_array_size_t>(L_2));
		V_0 = L_3;
		FiniteDifferenceCoefficients_t4C297B32541755227C3C396F2EE875CD3C6369DD* L_4 = __this->____coefficients_5;
		int32_t L_5;
		L_5 = NumericalDerivative_get_Center_m2A342DC5FBB8EAA82940F5D32883217021ACECD6_inline(__this, NULL);
		int32_t L_6 = ___3_order;
		NullCheck(L_4);
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_7;
		L_7 = FiniteDifferenceCoefficients_GetCoefficients_m0EF0A6A58D90EFBBCD57331D42A23800EC13664E(L_4, L_5, L_6, NULL);
		V_1 = L_7;
		int32_t L_8 = __this->____points_0;
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_9 = ___1_x;
		int32_t L_10 = ___2_parameterIndex;
		NullCheck(L_9);
		int32_t L_11 = L_10;
		double L_12 = (L_9)->GetAt(static_cast<il2cpp_array_size_t>(L_11));
		int32_t L_13 = ___3_order;
		double L_14;
		L_14 = NumericalDerivative_CalculateStepSize_m6DD2C80785010974B05485A22594397FA6A166FB(__this, L_8, L_12, ((double)L_13), NULL);
		V_2 = L_14;
		int32_t L_15 = __this->____points_0;
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_16 = (DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE*)(DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE*)SZArrayNew(DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE_il2cpp_TypeInfo_var, (uint32_t)L_15);
		V_3 = L_16;
		V_4 = 0;
		goto IL_009f;
	}

IL_003c:
	{
		int32_t L_17 = V_4;
		int32_t L_18;
		L_18 = NumericalDerivative_get_Center_m2A342DC5FBB8EAA82940F5D32883217021ACECD6_inline(__this, NULL);
		if ((!(((uint32_t)L_17) == ((uint32_t)L_18))))
		{
			goto IL_005c;
		}
	}
	{
		bool L_19;
		L_19 = Nullable_1_get_HasValue_mC082C667C8EB3A6CA80E06BCAEA0BED00C6BC15A_inline((&___4_currentValue), Nullable_1_get_HasValue_mC082C667C8EB3A6CA80E06BCAEA0BED00C6BC15A_RuntimeMethod_var);
		if (!L_19)
		{
			goto IL_005c;
		}
	}
	{
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_20 = V_3;
		int32_t L_21 = V_4;
		double L_22;
		L_22 = Nullable_1_get_Value_m260A5CB9269FD3E130F998A589EDAEC2E8F9EAE1((&___4_currentValue), Nullable_1_get_Value_m260A5CB9269FD3E130F998A589EDAEC2E8F9EAE1_RuntimeMethod_var);
		NullCheck(L_20);
		(L_20)->SetAt(static_cast<il2cpp_array_size_t>(L_21), (double)L_22);
		goto IL_0099;
	}

IL_005c:
	{
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_23 = V_1;
		int32_t L_24 = V_4;
		NullCheck(L_23);
		int32_t L_25 = L_24;
		double L_26 = (L_23)->GetAt(static_cast<il2cpp_array_size_t>(L_25));
		if ((((double)L_26) == ((double)(0.0))))
		{
			goto IL_0099;
		}
	}
	{
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_27 = ___1_x;
		int32_t L_28 = ___2_parameterIndex;
		double L_29 = V_0;
		int32_t L_30 = V_4;
		int32_t L_31;
		L_31 = NumericalDerivative_get_Center_m2A342DC5FBB8EAA82940F5D32883217021ACECD6_inline(__this, NULL);
		double L_32 = V_2;
		NullCheck(L_27);
		(L_27)->SetAt(static_cast<il2cpp_array_size_t>(L_28), (double)((double)il2cpp_codegen_add(L_29, ((double)il2cpp_codegen_multiply(((double)((int32_t)il2cpp_codegen_subtract(L_30, L_31))), L_32)))));
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_33 = V_3;
		int32_t L_34 = V_4;
		Func_2_t89B8106282004E94AE869931CD4E1DF667EB235E* L_35 = ___0_f;
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_36 = ___1_x;
		NullCheck(L_35);
		double L_37;
		L_37 = Func_2_Invoke_m7442A25D41142B8F2A021318023893E3DD4DF5B8_inline(L_35, L_36, NULL);
		NullCheck(L_33);
		(L_33)->SetAt(static_cast<il2cpp_array_size_t>(L_34), (double)L_37);
		int32_t L_38;
		L_38 = NumericalDerivative_get_Evaluations_mCA8A041C5842CB4239707CB207A053D3037151FE_inline(__this, NULL);
		V_5 = L_38;
		int32_t L_39 = V_5;
		NumericalDerivative_set_Evaluations_mCCE3A9BE2B152CFFC6B9C02EEC6641E392048042_inline(__this, ((int32_t)il2cpp_codegen_add(L_39, 1)), NULL);
	}

IL_0099:
	{
		int32_t L_40 = V_4;
		V_4 = ((int32_t)il2cpp_codegen_add(L_40, 1));
	}

IL_009f:
	{
		int32_t L_41 = V_4;
		int32_t L_42 = __this->____points_0;
		if ((((int32_t)L_41) < ((int32_t)L_42)))
		{
			goto IL_003c;
		}
	}
	{
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_43 = ___1_x;
		int32_t L_44 = ___2_parameterIndex;
		double L_45 = V_0;
		NullCheck(L_43);
		(L_43)->SetAt(static_cast<il2cpp_array_size_t>(L_44), (double)L_45);
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_46 = V_3;
		int32_t L_47 = ___3_order;
		double L_48 = V_2;
		double L_49;
		L_49 = NumericalDerivative_EvaluateDerivative_mCDBA97154622BE221740EF0643F7D685D82F1004(__this, L_46, L_47, L_48, NULL);
		return L_49;
	}
}
// System.Double[] MathNet.Numerics.Differentiation.NumericalDerivative::EvaluatePartialDerivative(System.Func`2<System.Double[],System.Double>[],System.Double[],System.Int32,System.Int32,System.Nullable`1<System.Double>[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* NumericalDerivative_EvaluatePartialDerivative_m365C3DB2EC65FF94BC7B14ED2787FECE64705C5C (NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* __this, Func_2U5BU5D_tAFC1A2A6571948ADB9C2BC67B555510E993FC60A* ___0_f, DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* ___1_x, int32_t ___2_parameterIndex, int32_t ___3_order, Nullable_1U5BU5D_t8608EFC3D4A79785F59C7AB124AD5FBE0F75BCF1* ___4_currentValue, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Nullable_1__ctor_mDE3158DD99CA7E1775A8BA276E428AF808AB8FBF_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Nullable_1_get_HasValue_mC082C667C8EB3A6CA80E06BCAEA0BED00C6BC15A_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Nullable_1_get_Value_m260A5CB9269FD3E130F998A589EDAEC2E8F9EAE1_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* V_0 = NULL;
	int32_t V_1 = 0;
	Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165 V_2;
	memset((&V_2), 0, sizeof(V_2));
	{
		Func_2U5BU5D_tAFC1A2A6571948ADB9C2BC67B555510E993FC60A* L_0 = ___0_f;
		NullCheck(L_0);
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_1 = (DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE*)(DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE*)SZArrayNew(DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE_il2cpp_TypeInfo_var, (uint32_t)((int32_t)(((RuntimeArray*)L_0)->max_length)));
		V_0 = L_1;
		V_1 = 0;
		goto IL_0061;
	}

IL_000d:
	{
		Nullable_1U5BU5D_t8608EFC3D4A79785F59C7AB124AD5FBE0F75BCF1* L_2 = ___4_currentValue;
		if (!L_2)
		{
			goto IL_0044;
		}
	}
	{
		Nullable_1U5BU5D_t8608EFC3D4A79785F59C7AB124AD5FBE0F75BCF1* L_3 = ___4_currentValue;
		int32_t L_4 = V_1;
		NullCheck(L_3);
		bool L_5;
		L_5 = Nullable_1_get_HasValue_mC082C667C8EB3A6CA80E06BCAEA0BED00C6BC15A_inline(((L_3)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_4))), Nullable_1_get_HasValue_mC082C667C8EB3A6CA80E06BCAEA0BED00C6BC15A_RuntimeMethod_var);
		if (!L_5)
		{
			goto IL_0044;
		}
	}
	{
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_6 = V_0;
		int32_t L_7 = V_1;
		Func_2U5BU5D_tAFC1A2A6571948ADB9C2BC67B555510E993FC60A* L_8 = ___0_f;
		int32_t L_9 = V_1;
		NullCheck(L_8);
		int32_t L_10 = L_9;
		Func_2_t89B8106282004E94AE869931CD4E1DF667EB235E* L_11 = (L_8)->GetAt(static_cast<il2cpp_array_size_t>(L_10));
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_12 = ___1_x;
		int32_t L_13 = ___2_parameterIndex;
		int32_t L_14 = ___3_order;
		Nullable_1U5BU5D_t8608EFC3D4A79785F59C7AB124AD5FBE0F75BCF1* L_15 = ___4_currentValue;
		int32_t L_16 = V_1;
		NullCheck(L_15);
		double L_17;
		L_17 = Nullable_1_get_Value_m260A5CB9269FD3E130F998A589EDAEC2E8F9EAE1(((L_15)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_16))), Nullable_1_get_Value_m260A5CB9269FD3E130F998A589EDAEC2E8F9EAE1_RuntimeMethod_var);
		Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165 L_18;
		memset((&L_18), 0, sizeof(L_18));
		Nullable_1__ctor_mDE3158DD99CA7E1775A8BA276E428AF808AB8FBF((&L_18), L_17, /*hidden argument*/Nullable_1__ctor_mDE3158DD99CA7E1775A8BA276E428AF808AB8FBF_RuntimeMethod_var);
		double L_19;
		L_19 = NumericalDerivative_EvaluatePartialDerivative_mDE906B586F0CCE53070CC5DCB0670419D1F22D87(__this, L_11, L_12, L_13, L_14, L_18, NULL);
		NullCheck(L_6);
		(L_6)->SetAt(static_cast<il2cpp_array_size_t>(L_7), (double)L_19);
		goto IL_005d;
	}

IL_0044:
	{
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_20 = V_0;
		int32_t L_21 = V_1;
		Func_2U5BU5D_tAFC1A2A6571948ADB9C2BC67B555510E993FC60A* L_22 = ___0_f;
		int32_t L_23 = V_1;
		NullCheck(L_22);
		int32_t L_24 = L_23;
		Func_2_t89B8106282004E94AE869931CD4E1DF667EB235E* L_25 = (L_22)->GetAt(static_cast<il2cpp_array_size_t>(L_24));
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_26 = ___1_x;
		int32_t L_27 = ___2_parameterIndex;
		int32_t L_28 = ___3_order;
		il2cpp_codegen_initobj((&V_2), sizeof(Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165));
		Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165 L_29 = V_2;
		double L_30;
		L_30 = NumericalDerivative_EvaluatePartialDerivative_mDE906B586F0CCE53070CC5DCB0670419D1F22D87(__this, L_25, L_26, L_27, L_28, L_29, NULL);
		NullCheck(L_20);
		(L_20)->SetAt(static_cast<il2cpp_array_size_t>(L_21), (double)L_30);
	}

IL_005d:
	{
		int32_t L_31 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add(L_31, 1));
	}

IL_0061:
	{
		int32_t L_32 = V_1;
		Func_2U5BU5D_tAFC1A2A6571948ADB9C2BC67B555510E993FC60A* L_33 = ___0_f;
		NullCheck(L_33);
		if ((((int32_t)L_32) < ((int32_t)((int32_t)(((RuntimeArray*)L_33)->max_length)))))
		{
			goto IL_000d;
		}
	}
	{
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_34 = V_0;
		return L_34;
	}
}
// System.Func`2<System.Double[],System.Double> MathNet.Numerics.Differentiation.NumericalDerivative::CreatePartialDerivativeFunctionHandle(System.Func`2<System.Double[],System.Double>,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Func_2_t89B8106282004E94AE869931CD4E1DF667EB235E* NumericalDerivative_CreatePartialDerivativeFunctionHandle_m59A6B6AADE61B7C707FB7E04D59046C8AD164D70 (NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* __this, Func_2_t89B8106282004E94AE869931CD4E1DF667EB235E* ___0_f, int32_t ___1_parameterIndex, int32_t ___2_order, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Func_2_t89B8106282004E94AE869931CD4E1DF667EB235E_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CU3Ec__DisplayClass33_0_U3CCreatePartialDerivativeFunctionHandleU3Eb__0_mB6666A1868E95E3F8BD11E07663371EFDAEF0585_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CU3Ec__DisplayClass33_0_tBD2756287084841A3E1F1D69335FE19E47552364_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		U3CU3Ec__DisplayClass33_0_tBD2756287084841A3E1F1D69335FE19E47552364* L_0 = (U3CU3Ec__DisplayClass33_0_tBD2756287084841A3E1F1D69335FE19E47552364*)il2cpp_codegen_object_new(U3CU3Ec__DisplayClass33_0_tBD2756287084841A3E1F1D69335FE19E47552364_il2cpp_TypeInfo_var);
		NullCheck(L_0);
		U3CU3Ec__DisplayClass33_0__ctor_mFDA3E2D1D75579B687460B56F722EEC239356AEC(L_0, NULL);
		U3CU3Ec__DisplayClass33_0_tBD2756287084841A3E1F1D69335FE19E47552364* L_1 = L_0;
		NullCheck(L_1);
		L_1->___U3CU3E4__this_0 = __this;
		Il2CppCodeGenWriteBarrier((void**)(&L_1->___U3CU3E4__this_0), (void*)__this);
		U3CU3Ec__DisplayClass33_0_tBD2756287084841A3E1F1D69335FE19E47552364* L_2 = L_1;
		Func_2_t89B8106282004E94AE869931CD4E1DF667EB235E* L_3 = ___0_f;
		NullCheck(L_2);
		L_2->___f_1 = L_3;
		Il2CppCodeGenWriteBarrier((void**)(&L_2->___f_1), (void*)L_3);
		U3CU3Ec__DisplayClass33_0_tBD2756287084841A3E1F1D69335FE19E47552364* L_4 = L_2;
		int32_t L_5 = ___1_parameterIndex;
		NullCheck(L_4);
		L_4->___parameterIndex_2 = L_5;
		U3CU3Ec__DisplayClass33_0_tBD2756287084841A3E1F1D69335FE19E47552364* L_6 = L_4;
		int32_t L_7 = ___2_order;
		NullCheck(L_6);
		L_6->___order_3 = L_7;
		Func_2_t89B8106282004E94AE869931CD4E1DF667EB235E* L_8 = (Func_2_t89B8106282004E94AE869931CD4E1DF667EB235E*)il2cpp_codegen_object_new(Func_2_t89B8106282004E94AE869931CD4E1DF667EB235E_il2cpp_TypeInfo_var);
		NullCheck(L_8);
		Func_2__ctor_m4D03D33F7B4AF2D1131E528ACAB3A21A84741714(L_8, L_6, (intptr_t)((void*)U3CU3Ec__DisplayClass33_0_U3CCreatePartialDerivativeFunctionHandleU3Eb__0_mB6666A1868E95E3F8BD11E07663371EFDAEF0585_RuntimeMethod_var), NULL);
		return L_8;
	}
}
// System.Func`2<System.Double[],System.Double[]> MathNet.Numerics.Differentiation.NumericalDerivative::CreatePartialDerivativeFunctionHandle(System.Func`2<System.Double[],System.Double>[],System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Func_2_tA1A2AD8DF81B4522B8EE6DE5D7855397EAF54012* NumericalDerivative_CreatePartialDerivativeFunctionHandle_mA87E3F39EC85BB4D5B1F1B18DE2F479F9E65F9F6 (NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* __this, Func_2U5BU5D_tAFC1A2A6571948ADB9C2BC67B555510E993FC60A* ___0_f, int32_t ___1_parameterIndex, int32_t ___2_order, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Func_2_tA1A2AD8DF81B4522B8EE6DE5D7855397EAF54012_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CU3Ec__DisplayClass34_0_U3CCreatePartialDerivativeFunctionHandleU3Eb__0_m0919F5E6A57BBCD99A41510256B11DEBCC534E29_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CU3Ec__DisplayClass34_0_tF6657B44CE0DCD05291B022AFF982CF97DD5204B_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		U3CU3Ec__DisplayClass34_0_tF6657B44CE0DCD05291B022AFF982CF97DD5204B* L_0 = (U3CU3Ec__DisplayClass34_0_tF6657B44CE0DCD05291B022AFF982CF97DD5204B*)il2cpp_codegen_object_new(U3CU3Ec__DisplayClass34_0_tF6657B44CE0DCD05291B022AFF982CF97DD5204B_il2cpp_TypeInfo_var);
		NullCheck(L_0);
		U3CU3Ec__DisplayClass34_0__ctor_m0CA5B471C8A0BECC2E9D14DAD9229D6657599770(L_0, NULL);
		U3CU3Ec__DisplayClass34_0_tF6657B44CE0DCD05291B022AFF982CF97DD5204B* L_1 = L_0;
		NullCheck(L_1);
		L_1->___U3CU3E4__this_0 = __this;
		Il2CppCodeGenWriteBarrier((void**)(&L_1->___U3CU3E4__this_0), (void*)__this);
		U3CU3Ec__DisplayClass34_0_tF6657B44CE0DCD05291B022AFF982CF97DD5204B* L_2 = L_1;
		Func_2U5BU5D_tAFC1A2A6571948ADB9C2BC67B555510E993FC60A* L_3 = ___0_f;
		NullCheck(L_2);
		L_2->___f_1 = L_3;
		Il2CppCodeGenWriteBarrier((void**)(&L_2->___f_1), (void*)L_3);
		U3CU3Ec__DisplayClass34_0_tF6657B44CE0DCD05291B022AFF982CF97DD5204B* L_4 = L_2;
		int32_t L_5 = ___1_parameterIndex;
		NullCheck(L_4);
		L_4->___parameterIndex_2 = L_5;
		U3CU3Ec__DisplayClass34_0_tF6657B44CE0DCD05291B022AFF982CF97DD5204B* L_6 = L_4;
		int32_t L_7 = ___2_order;
		NullCheck(L_6);
		L_6->___order_3 = L_7;
		Func_2_tA1A2AD8DF81B4522B8EE6DE5D7855397EAF54012* L_8 = (Func_2_tA1A2AD8DF81B4522B8EE6DE5D7855397EAF54012*)il2cpp_codegen_object_new(Func_2_tA1A2AD8DF81B4522B8EE6DE5D7855397EAF54012_il2cpp_TypeInfo_var);
		NullCheck(L_8);
		Func_2__ctor_m2ED05A74879DCC63F0AE05AE5157CBC0E7F27F19(L_8, L_6, (intptr_t)((void*)U3CU3Ec__DisplayClass34_0_U3CCreatePartialDerivativeFunctionHandleU3Eb__0_m0919F5E6A57BBCD99A41510256B11DEBCC534E29_RuntimeMethod_var), NULL);
		return L_8;
	}
}
// System.Double MathNet.Numerics.Differentiation.NumericalDerivative::EvaluateMixedPartialDerivative(System.Func`2<System.Double[],System.Double>,System.Double[],System.Int32[],System.Int32,System.Nullable`1<System.Double>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double NumericalDerivative_EvaluateMixedPartialDerivative_mB6986A98BC73CFEBD25C1203BE8DE3F1D22849CE (NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* __this, Func_2_t89B8106282004E94AE869931CD4E1DF667EB235E* ___0_f, DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* ___1_x, Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ___2_parameterIndex, int32_t ___3_order, Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165 ___4_currentValue, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* V_1 = NULL;
	DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* V_2 = NULL;
	int32_t V_3 = 0;
	double V_4 = 0.0;
	double V_5 = 0.0;
	int32_t V_6 = 0;
	Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165 V_7;
	memset((&V_7), 0, sizeof(V_7));
	{
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_0 = ___2_parameterIndex;
		NullCheck(L_0);
		int32_t L_1 = ___3_order;
		if ((((int32_t)((int32_t)(((RuntimeArray*)L_0)->max_length))) == ((int32_t)L_1)))
		{
			goto IL_0017;
		}
	}
	{
		ArgumentOutOfRangeException_tEA2822DAF62B10EEED00E0E3A341D4BAF78CF85F* L_2 = (ArgumentOutOfRangeException_tEA2822DAF62B10EEED00E0E3A341D4BAF78CF85F*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&ArgumentOutOfRangeException_tEA2822DAF62B10EEED00E0E3A341D4BAF78CF85F_il2cpp_TypeInfo_var)));
		NullCheck(L_2);
		ArgumentOutOfRangeException__ctor_mE5B2755F0BEA043CACF915D5CE140859EE58FA66(L_2, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral78E88F68574BA7A377B127398AF38F7FF9F57490)), ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteralEFD51132E6C4A6EFF276CD33D7CA92017B42FCDE)), NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_2, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&NumericalDerivative_EvaluateMixedPartialDerivative_mB6986A98BC73CFEBD25C1203BE8DE3F1D22849CE_RuntimeMethod_var)));
	}

IL_0017:
	{
		int32_t L_3 = ___3_order;
		if ((!(((uint32_t)L_3) == ((uint32_t)1))))
		{
			goto IL_002c;
		}
	}
	{
		Func_2_t89B8106282004E94AE869931CD4E1DF667EB235E* L_4 = ___0_f;
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_5 = ___1_x;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_6 = ___2_parameterIndex;
		NullCheck(L_6);
		int32_t L_7 = 0;
		int32_t L_8 = (L_6)->GetAt(static_cast<il2cpp_array_size_t>(L_7));
		int32_t L_9 = ___3_order;
		Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165 L_10 = ___4_currentValue;
		double L_11;
		L_11 = NumericalDerivative_EvaluatePartialDerivative_mDE906B586F0CCE53070CC5DCB0670419D1F22D87(__this, L_4, L_5, L_8, L_9, L_10, NULL);
		return L_11;
	}

IL_002c:
	{
		int32_t L_12 = ___3_order;
		V_0 = ((int32_t)il2cpp_codegen_subtract(L_12, 1));
		int32_t L_13 = V_0;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_14 = (Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C*)(Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C*)SZArrayNew(Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C_il2cpp_TypeInfo_var, (uint32_t)L_13);
		V_1 = L_14;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_15 = ___2_parameterIndex;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_16 = V_1;
		int32_t L_17 = V_0;
		Array_Copy_mB4904E17BD92E320613A3251C0205E0786B3BF41((RuntimeArray*)L_15, 0, (RuntimeArray*)L_16, 0, L_17, NULL);
		int32_t L_18 = __this->____points_0;
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_19 = (DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE*)(DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE*)SZArrayNew(DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE_il2cpp_TypeInfo_var, (uint32_t)L_18);
		V_2 = L_19;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_20 = ___2_parameterIndex;
		int32_t L_21 = ___3_order;
		NullCheck(L_20);
		int32_t L_22 = ((int32_t)il2cpp_codegen_subtract(L_21, 1));
		int32_t L_23 = (L_20)->GetAt(static_cast<il2cpp_array_size_t>(L_22));
		V_3 = L_23;
		int32_t L_24 = __this->____points_0;
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_25 = ___1_x;
		int32_t L_26 = V_3;
		NullCheck(L_25);
		int32_t L_27 = L_26;
		double L_28 = (L_25)->GetAt(static_cast<il2cpp_array_size_t>(L_27));
		int32_t L_29 = ___3_order;
		double L_30;
		L_30 = NumericalDerivative_CalculateStepSize_m6DD2C80785010974B05485A22594397FA6A166FB(__this, L_24, L_28, ((double)L_29), NULL);
		V_4 = L_30;
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_31 = ___1_x;
		int32_t L_32 = V_3;
		NullCheck(L_31);
		int32_t L_33 = L_32;
		double L_34 = (L_31)->GetAt(static_cast<il2cpp_array_size_t>(L_33));
		V_5 = L_34;
		V_6 = 0;
		goto IL_00a4;
	}

IL_0073:
	{
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_35 = ___1_x;
		int32_t L_36 = V_3;
		double L_37 = V_5;
		int32_t L_38 = V_6;
		int32_t L_39;
		L_39 = NumericalDerivative_get_Center_m2A342DC5FBB8EAA82940F5D32883217021ACECD6_inline(__this, NULL);
		double L_40 = V_4;
		NullCheck(L_35);
		(L_35)->SetAt(static_cast<il2cpp_array_size_t>(L_36), (double)((double)il2cpp_codegen_add(L_37, ((double)il2cpp_codegen_multiply(((double)((int32_t)il2cpp_codegen_subtract(L_38, L_39))), L_40)))));
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_41 = V_2;
		int32_t L_42 = V_6;
		Func_2_t89B8106282004E94AE869931CD4E1DF667EB235E* L_43 = ___0_f;
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_44 = ___1_x;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_45 = V_1;
		int32_t L_46 = V_0;
		il2cpp_codegen_initobj((&V_7), sizeof(Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165));
		Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165 L_47 = V_7;
		double L_48;
		L_48 = NumericalDerivative_EvaluateMixedPartialDerivative_mB6986A98BC73CFEBD25C1203BE8DE3F1D22849CE(__this, L_43, L_44, L_45, L_46, L_47, NULL);
		NullCheck(L_41);
		(L_41)->SetAt(static_cast<il2cpp_array_size_t>(L_42), (double)L_48);
		int32_t L_49 = V_6;
		V_6 = ((int32_t)il2cpp_codegen_add(L_49, 1));
	}

IL_00a4:
	{
		int32_t L_50 = V_6;
		int32_t L_51 = __this->____points_0;
		if ((((int32_t)L_50) < ((int32_t)L_51)))
		{
			goto IL_0073;
		}
	}
	{
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_52 = ___1_x;
		int32_t L_53 = V_3;
		double L_54 = V_5;
		NullCheck(L_52);
		(L_52)->SetAt(static_cast<il2cpp_array_size_t>(L_53), (double)L_54);
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_55 = V_2;
		double L_56 = V_4;
		double L_57;
		L_57 = NumericalDerivative_EvaluateDerivative_mCDBA97154622BE221740EF0643F7D685D82F1004(__this, L_55, 1, L_56, NULL);
		return L_57;
	}
}
// System.Double[] MathNet.Numerics.Differentiation.NumericalDerivative::EvaluateMixedPartialDerivative(System.Func`2<System.Double[],System.Double>[],System.Double[],System.Int32[],System.Int32,System.Nullable`1<System.Double>[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* NumericalDerivative_EvaluateMixedPartialDerivative_mACD450152ADEA0BF5A5B5BD75A33836B66661E8E (NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* __this, Func_2U5BU5D_tAFC1A2A6571948ADB9C2BC67B555510E993FC60A* ___0_f, DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* ___1_x, Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ___2_parameterIndex, int32_t ___3_order, Nullable_1U5BU5D_t8608EFC3D4A79785F59C7AB124AD5FBE0F75BCF1* ___4_currentValue, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Nullable_1__ctor_mDE3158DD99CA7E1775A8BA276E428AF808AB8FBF_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Nullable_1_get_HasValue_mC082C667C8EB3A6CA80E06BCAEA0BED00C6BC15A_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Nullable_1_get_Value_m260A5CB9269FD3E130F998A589EDAEC2E8F9EAE1_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* V_0 = NULL;
	int32_t V_1 = 0;
	Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165 V_2;
	memset((&V_2), 0, sizeof(V_2));
	{
		Func_2U5BU5D_tAFC1A2A6571948ADB9C2BC67B555510E993FC60A* L_0 = ___0_f;
		NullCheck(L_0);
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_1 = (DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE*)(DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE*)SZArrayNew(DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE_il2cpp_TypeInfo_var, (uint32_t)((int32_t)(((RuntimeArray*)L_0)->max_length)));
		V_0 = L_1;
		V_1 = 0;
		goto IL_0061;
	}

IL_000d:
	{
		Nullable_1U5BU5D_t8608EFC3D4A79785F59C7AB124AD5FBE0F75BCF1* L_2 = ___4_currentValue;
		if (!L_2)
		{
			goto IL_0044;
		}
	}
	{
		Nullable_1U5BU5D_t8608EFC3D4A79785F59C7AB124AD5FBE0F75BCF1* L_3 = ___4_currentValue;
		int32_t L_4 = V_1;
		NullCheck(L_3);
		bool L_5;
		L_5 = Nullable_1_get_HasValue_mC082C667C8EB3A6CA80E06BCAEA0BED00C6BC15A_inline(((L_3)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_4))), Nullable_1_get_HasValue_mC082C667C8EB3A6CA80E06BCAEA0BED00C6BC15A_RuntimeMethod_var);
		if (!L_5)
		{
			goto IL_0044;
		}
	}
	{
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_6 = V_0;
		int32_t L_7 = V_1;
		Func_2U5BU5D_tAFC1A2A6571948ADB9C2BC67B555510E993FC60A* L_8 = ___0_f;
		int32_t L_9 = V_1;
		NullCheck(L_8);
		int32_t L_10 = L_9;
		Func_2_t89B8106282004E94AE869931CD4E1DF667EB235E* L_11 = (L_8)->GetAt(static_cast<il2cpp_array_size_t>(L_10));
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_12 = ___1_x;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_13 = ___2_parameterIndex;
		int32_t L_14 = ___3_order;
		Nullable_1U5BU5D_t8608EFC3D4A79785F59C7AB124AD5FBE0F75BCF1* L_15 = ___4_currentValue;
		int32_t L_16 = V_1;
		NullCheck(L_15);
		double L_17;
		L_17 = Nullable_1_get_Value_m260A5CB9269FD3E130F998A589EDAEC2E8F9EAE1(((L_15)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_16))), Nullable_1_get_Value_m260A5CB9269FD3E130F998A589EDAEC2E8F9EAE1_RuntimeMethod_var);
		Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165 L_18;
		memset((&L_18), 0, sizeof(L_18));
		Nullable_1__ctor_mDE3158DD99CA7E1775A8BA276E428AF808AB8FBF((&L_18), L_17, /*hidden argument*/Nullable_1__ctor_mDE3158DD99CA7E1775A8BA276E428AF808AB8FBF_RuntimeMethod_var);
		double L_19;
		L_19 = NumericalDerivative_EvaluateMixedPartialDerivative_mB6986A98BC73CFEBD25C1203BE8DE3F1D22849CE(__this, L_11, L_12, L_13, L_14, L_18, NULL);
		NullCheck(L_6);
		(L_6)->SetAt(static_cast<il2cpp_array_size_t>(L_7), (double)L_19);
		goto IL_005d;
	}

IL_0044:
	{
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_20 = V_0;
		int32_t L_21 = V_1;
		Func_2U5BU5D_tAFC1A2A6571948ADB9C2BC67B555510E993FC60A* L_22 = ___0_f;
		int32_t L_23 = V_1;
		NullCheck(L_22);
		int32_t L_24 = L_23;
		Func_2_t89B8106282004E94AE869931CD4E1DF667EB235E* L_25 = (L_22)->GetAt(static_cast<il2cpp_array_size_t>(L_24));
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_26 = ___1_x;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_27 = ___2_parameterIndex;
		int32_t L_28 = ___3_order;
		il2cpp_codegen_initobj((&V_2), sizeof(Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165));
		Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165 L_29 = V_2;
		double L_30;
		L_30 = NumericalDerivative_EvaluateMixedPartialDerivative_mB6986A98BC73CFEBD25C1203BE8DE3F1D22849CE(__this, L_25, L_26, L_27, L_28, L_29, NULL);
		NullCheck(L_20);
		(L_20)->SetAt(static_cast<il2cpp_array_size_t>(L_21), (double)L_30);
	}

IL_005d:
	{
		int32_t L_31 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add(L_31, 1));
	}

IL_0061:
	{
		int32_t L_32 = V_1;
		Func_2U5BU5D_tAFC1A2A6571948ADB9C2BC67B555510E993FC60A* L_33 = ___0_f;
		NullCheck(L_33);
		if ((((int32_t)L_32) < ((int32_t)((int32_t)(((RuntimeArray*)L_33)->max_length)))))
		{
			goto IL_000d;
		}
	}
	{
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_34 = V_0;
		return L_34;
	}
}
// System.Func`2<System.Double[],System.Double> MathNet.Numerics.Differentiation.NumericalDerivative::CreateMixedPartialDerivativeFunctionHandle(System.Func`2<System.Double[],System.Double>,System.Int32[],System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Func_2_t89B8106282004E94AE869931CD4E1DF667EB235E* NumericalDerivative_CreateMixedPartialDerivativeFunctionHandle_mA5E54932CC9E3AB2865D22330B4600A7486F8EE0 (NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* __this, Func_2_t89B8106282004E94AE869931CD4E1DF667EB235E* ___0_f, Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ___1_parameterIndex, int32_t ___2_order, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Func_2_t89B8106282004E94AE869931CD4E1DF667EB235E_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CU3Ec__DisplayClass37_0_U3CCreateMixedPartialDerivativeFunctionHandleU3Eb__0_mB16331F68765F8AEBB943CF3237BB509C5C9EE6A_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CU3Ec__DisplayClass37_0_tB67C49B4F7E09BCA7E1D145A632C77D2A55C3617_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		U3CU3Ec__DisplayClass37_0_tB67C49B4F7E09BCA7E1D145A632C77D2A55C3617* L_0 = (U3CU3Ec__DisplayClass37_0_tB67C49B4F7E09BCA7E1D145A632C77D2A55C3617*)il2cpp_codegen_object_new(U3CU3Ec__DisplayClass37_0_tB67C49B4F7E09BCA7E1D145A632C77D2A55C3617_il2cpp_TypeInfo_var);
		NullCheck(L_0);
		U3CU3Ec__DisplayClass37_0__ctor_mD34308515D296A888A4F1D808FCCBBBADDDB54B8(L_0, NULL);
		U3CU3Ec__DisplayClass37_0_tB67C49B4F7E09BCA7E1D145A632C77D2A55C3617* L_1 = L_0;
		NullCheck(L_1);
		L_1->___U3CU3E4__this_0 = __this;
		Il2CppCodeGenWriteBarrier((void**)(&L_1->___U3CU3E4__this_0), (void*)__this);
		U3CU3Ec__DisplayClass37_0_tB67C49B4F7E09BCA7E1D145A632C77D2A55C3617* L_2 = L_1;
		Func_2_t89B8106282004E94AE869931CD4E1DF667EB235E* L_3 = ___0_f;
		NullCheck(L_2);
		L_2->___f_1 = L_3;
		Il2CppCodeGenWriteBarrier((void**)(&L_2->___f_1), (void*)L_3);
		U3CU3Ec__DisplayClass37_0_tB67C49B4F7E09BCA7E1D145A632C77D2A55C3617* L_4 = L_2;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_5 = ___1_parameterIndex;
		NullCheck(L_4);
		L_4->___parameterIndex_2 = L_5;
		Il2CppCodeGenWriteBarrier((void**)(&L_4->___parameterIndex_2), (void*)L_5);
		U3CU3Ec__DisplayClass37_0_tB67C49B4F7E09BCA7E1D145A632C77D2A55C3617* L_6 = L_4;
		int32_t L_7 = ___2_order;
		NullCheck(L_6);
		L_6->___order_3 = L_7;
		Func_2_t89B8106282004E94AE869931CD4E1DF667EB235E* L_8 = (Func_2_t89B8106282004E94AE869931CD4E1DF667EB235E*)il2cpp_codegen_object_new(Func_2_t89B8106282004E94AE869931CD4E1DF667EB235E_il2cpp_TypeInfo_var);
		NullCheck(L_8);
		Func_2__ctor_m4D03D33F7B4AF2D1131E528ACAB3A21A84741714(L_8, L_6, (intptr_t)((void*)U3CU3Ec__DisplayClass37_0_U3CCreateMixedPartialDerivativeFunctionHandleU3Eb__0_mB16331F68765F8AEBB943CF3237BB509C5C9EE6A_RuntimeMethod_var), NULL);
		return L_8;
	}
}
// System.Func`2<System.Double[],System.Double[]> MathNet.Numerics.Differentiation.NumericalDerivative::CreateMixedPartialDerivativeFunctionHandle(System.Func`2<System.Double[],System.Double>[],System.Int32[],System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Func_2_tA1A2AD8DF81B4522B8EE6DE5D7855397EAF54012* NumericalDerivative_CreateMixedPartialDerivativeFunctionHandle_m2D55735E63F431C827A1CBF28CFE89227F336110 (NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* __this, Func_2U5BU5D_tAFC1A2A6571948ADB9C2BC67B555510E993FC60A* ___0_f, Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ___1_parameterIndex, int32_t ___2_order, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Func_2_tA1A2AD8DF81B4522B8EE6DE5D7855397EAF54012_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CU3Ec__DisplayClass38_0_U3CCreateMixedPartialDerivativeFunctionHandleU3Eb__0_mF11172BC451306DB25036D54218C850D1E7F9245_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&U3CU3Ec__DisplayClass38_0_t09E32000AEB1ECF9C6180CB2696459BB31E78B3D_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		U3CU3Ec__DisplayClass38_0_t09E32000AEB1ECF9C6180CB2696459BB31E78B3D* L_0 = (U3CU3Ec__DisplayClass38_0_t09E32000AEB1ECF9C6180CB2696459BB31E78B3D*)il2cpp_codegen_object_new(U3CU3Ec__DisplayClass38_0_t09E32000AEB1ECF9C6180CB2696459BB31E78B3D_il2cpp_TypeInfo_var);
		NullCheck(L_0);
		U3CU3Ec__DisplayClass38_0__ctor_m1A33209F6B18D3C7E7A353633731F2B855A86117(L_0, NULL);
		U3CU3Ec__DisplayClass38_0_t09E32000AEB1ECF9C6180CB2696459BB31E78B3D* L_1 = L_0;
		NullCheck(L_1);
		L_1->___U3CU3E4__this_0 = __this;
		Il2CppCodeGenWriteBarrier((void**)(&L_1->___U3CU3E4__this_0), (void*)__this);
		U3CU3Ec__DisplayClass38_0_t09E32000AEB1ECF9C6180CB2696459BB31E78B3D* L_2 = L_1;
		Func_2U5BU5D_tAFC1A2A6571948ADB9C2BC67B555510E993FC60A* L_3 = ___0_f;
		NullCheck(L_2);
		L_2->___f_1 = L_3;
		Il2CppCodeGenWriteBarrier((void**)(&L_2->___f_1), (void*)L_3);
		U3CU3Ec__DisplayClass38_0_t09E32000AEB1ECF9C6180CB2696459BB31E78B3D* L_4 = L_2;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_5 = ___1_parameterIndex;
		NullCheck(L_4);
		L_4->___parameterIndex_2 = L_5;
		Il2CppCodeGenWriteBarrier((void**)(&L_4->___parameterIndex_2), (void*)L_5);
		U3CU3Ec__DisplayClass38_0_t09E32000AEB1ECF9C6180CB2696459BB31E78B3D* L_6 = L_4;
		int32_t L_7 = ___2_order;
		NullCheck(L_6);
		L_6->___order_3 = L_7;
		Func_2_tA1A2AD8DF81B4522B8EE6DE5D7855397EAF54012* L_8 = (Func_2_tA1A2AD8DF81B4522B8EE6DE5D7855397EAF54012*)il2cpp_codegen_object_new(Func_2_tA1A2AD8DF81B4522B8EE6DE5D7855397EAF54012_il2cpp_TypeInfo_var);
		NullCheck(L_8);
		Func_2__ctor_m2ED05A74879DCC63F0AE05AE5157CBC0E7F27F19(L_8, L_6, (intptr_t)((void*)U3CU3Ec__DisplayClass38_0_U3CCreateMixedPartialDerivativeFunctionHandleU3Eb__0_mF11172BC451306DB25036D54218C850D1E7F9245_RuntimeMethod_var), NULL);
		return L_8;
	}
}
// System.Void MathNet.Numerics.Differentiation.NumericalDerivative::ResetEvaluations()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NumericalDerivative_ResetEvaluations_m6F6F8564E3BB74CBB55B0A4A1F16460966147057 (NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* __this, const RuntimeMethod* method) 
{
	{
		NumericalDerivative_set_Evaluations_mCCE3A9BE2B152CFFC6B9C02EEC6641E392048042_inline(__this, 0, NULL);
		return;
	}
}
// System.Double MathNet.Numerics.Differentiation.NumericalDerivative::CalculateStepSize(System.Int32,System.Double,System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double NumericalDerivative_CalculateStepSize_m6DD2C80785010974B05485A22594397FA6A166FB (NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* __this, int32_t ___0_points, double ___1_x, double ___2_order, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	double V_0 = 0.0;
	{
		int32_t L_0;
		L_0 = NumericalDerivative_get_StepType_m9067F9BAD716966954DD4090822BF911594D592F_inline(__this, NULL);
		if ((!(((uint32_t)L_0) == ((uint32_t)1))))
		{
			goto IL_0028;
		}
	}
	{
		double L_1;
		L_1 = NumericalDerivative_get_BaseStepSize_mFAE6FF2D0717BF1E60A83EB6706241C50E154F17_inline(__this, NULL);
		double L_2 = ___1_x;
		il2cpp_codegen_runtime_class_init_inline(Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		double L_3;
		L_3 = fabs(L_2);
		NumericalDerivative_set_StepSize_m1D5FF4430F889F96CAFECF3F8B57FD3C109334BF(__this, ((double)il2cpp_codegen_multiply(L_1, ((double)il2cpp_codegen_add((1.0), L_3)))), NULL);
		goto IL_0071;
	}

IL_0028:
	{
		int32_t L_4;
		L_4 = NumericalDerivative_get_StepType_m9067F9BAD716966954DD4090822BF911594D592F_inline(__this, NULL);
		if ((!(((uint32_t)L_4) == ((uint32_t)2))))
		{
			goto IL_0071;
		}
	}
	{
		int32_t L_5 = ___0_points;
		double L_6 = ___2_order;
		V_0 = ((double)il2cpp_codegen_subtract(((double)L_5), L_6));
		double L_7;
		L_7 = NumericalDerivative_get_Epsilon_mAA8717E023550582F3C2D9E6A89EF3E4723479AF_inline(__this, NULL);
		double L_8 = V_0;
		double L_9 = ___2_order;
		il2cpp_codegen_runtime_class_init_inline(Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		double L_10;
		L_10 = Math_Pow_mEAE651F0858203FBE12B72B6A53951BBD0FB5265(L_7, ((double)((1.0)/((double)il2cpp_codegen_add(L_8, L_9)))), NULL);
		NumericalDerivative_set_BaseStepSize_mAB871F65B8912C4DE512F44D18E83A4F2644F1F3(__this, L_10, NULL);
		double L_11;
		L_11 = NumericalDerivative_get_BaseStepSize_mFAE6FF2D0717BF1E60A83EB6706241C50E154F17_inline(__this, NULL);
		double L_12 = ___1_x;
		double L_13;
		L_13 = fabs(L_12);
		NumericalDerivative_set_StepSize_m1D5FF4430F889F96CAFECF3F8B57FD3C109334BF(__this, ((double)il2cpp_codegen_multiply(L_11, ((double)il2cpp_codegen_add((1.0), L_13)))), NULL);
	}

IL_0071:
	{
		double L_14;
		L_14 = NumericalDerivative_get_StepSize_m13C020A5C6ADCE52FF19373914AF86C84F3B58B5_inline(__this, NULL);
		return L_14;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void MathNet.Numerics.Differentiation.NumericalDerivative/<>c__DisplayClass28_0::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass28_0__ctor_mAEF3FED953F7D9BC82E503B819024AD3D38C87BA (U3CU3Ec__DisplayClass28_0_t1E475037E430264975A0956BD27AA2971F0532BC* __this, const RuntimeMethod* method) 
{
	{
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		return;
	}
}
// System.Double MathNet.Numerics.Differentiation.NumericalDerivative/<>c__DisplayClass28_0::<EvaluateDerivative>b__0(System.Double,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double U3CU3Ec__DisplayClass28_0_U3CEvaluateDerivativeU3Eb__0_m1D184DE944EE44A477CF4873E26E76B1EF29B6C1 (U3CU3Ec__DisplayClass28_0_t1E475037E430264975A0956BD27AA2971F0532BC* __this, double ___0_t, int32_t ___1_i, const RuntimeMethod* method) 
{
	{
		double L_0 = ___0_t;
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_1 = __this->___points_0;
		int32_t L_2 = ___1_i;
		NullCheck(L_1);
		int32_t L_3 = L_2;
		double L_4 = (L_1)->GetAt(static_cast<il2cpp_array_size_t>(L_3));
		return ((double)il2cpp_codegen_multiply(L_0, L_4));
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void MathNet.Numerics.Differentiation.NumericalDerivative/<>c__DisplayClass30_0::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass30_0__ctor_mDA8A74FD9E157F81603A64A51886C3E0C7E30DDA (U3CU3Ec__DisplayClass30_0_tBBEEC61B57C35572AA699E79175C25C8F2D7AEBC* __this, const RuntimeMethod* method) 
{
	{
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		return;
	}
}
// System.Double MathNet.Numerics.Differentiation.NumericalDerivative/<>c__DisplayClass30_0::<CreateDerivativeFunctionHandle>b__0(System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double U3CU3Ec__DisplayClass30_0_U3CCreateDerivativeFunctionHandleU3Eb__0_mF7EE56846A2440ED151B2A5DE00E1D1AE75A45B5 (U3CU3Ec__DisplayClass30_0_tBBEEC61B57C35572AA699E79175C25C8F2D7AEBC* __this, double ___0_x, const RuntimeMethod* method) 
{
	Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* L_0 = __this->___U3CU3E4__this_0;
		Func_2_t0221E9CE1FF8B8FE59AED052D562790B96F13B3D* L_1 = __this->___f_1;
		double L_2 = ___0_x;
		int32_t L_3 = __this->___order_2;
		il2cpp_codegen_initobj((&V_0), sizeof(Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165));
		Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165 L_4 = V_0;
		NullCheck(L_0);
		double L_5;
		L_5 = NumericalDerivative_EvaluateDerivative_m4D6F74A0B7826E6CD850B8D34DC3D91EA2AC0B21(L_0, L_1, L_2, L_3, L_4, NULL);
		return L_5;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void MathNet.Numerics.Differentiation.NumericalDerivative/<>c__DisplayClass33_0::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass33_0__ctor_mFDA3E2D1D75579B687460B56F722EEC239356AEC (U3CU3Ec__DisplayClass33_0_tBD2756287084841A3E1F1D69335FE19E47552364* __this, const RuntimeMethod* method) 
{
	{
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		return;
	}
}
// System.Double MathNet.Numerics.Differentiation.NumericalDerivative/<>c__DisplayClass33_0::<CreatePartialDerivativeFunctionHandle>b__0(System.Double[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double U3CU3Ec__DisplayClass33_0_U3CCreatePartialDerivativeFunctionHandleU3Eb__0_mB6666A1868E95E3F8BD11E07663371EFDAEF0585 (U3CU3Ec__DisplayClass33_0_tBD2756287084841A3E1F1D69335FE19E47552364* __this, DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* ___0_x, const RuntimeMethod* method) 
{
	Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* L_0 = __this->___U3CU3E4__this_0;
		Func_2_t89B8106282004E94AE869931CD4E1DF667EB235E* L_1 = __this->___f_1;
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_2 = ___0_x;
		int32_t L_3 = __this->___parameterIndex_2;
		int32_t L_4 = __this->___order_3;
		il2cpp_codegen_initobj((&V_0), sizeof(Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165));
		Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165 L_5 = V_0;
		NullCheck(L_0);
		double L_6;
		L_6 = NumericalDerivative_EvaluatePartialDerivative_mDE906B586F0CCE53070CC5DCB0670419D1F22D87(L_0, L_1, L_2, L_3, L_4, L_5, NULL);
		return L_6;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void MathNet.Numerics.Differentiation.NumericalDerivative/<>c__DisplayClass34_0::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass34_0__ctor_m0CA5B471C8A0BECC2E9D14DAD9229D6657599770 (U3CU3Ec__DisplayClass34_0_tF6657B44CE0DCD05291B022AFF982CF97DD5204B* __this, const RuntimeMethod* method) 
{
	{
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		return;
	}
}
// System.Double[] MathNet.Numerics.Differentiation.NumericalDerivative/<>c__DisplayClass34_0::<CreatePartialDerivativeFunctionHandle>b__0(System.Double[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* U3CU3Ec__DisplayClass34_0_U3CCreatePartialDerivativeFunctionHandleU3Eb__0_m0919F5E6A57BBCD99A41510256B11DEBCC534E29 (U3CU3Ec__DisplayClass34_0_tF6657B44CE0DCD05291B022AFF982CF97DD5204B* __this, DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* ___0_x, const RuntimeMethod* method) 
{
	{
		NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* L_0 = __this->___U3CU3E4__this_0;
		Func_2U5BU5D_tAFC1A2A6571948ADB9C2BC67B555510E993FC60A* L_1 = __this->___f_1;
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_2 = ___0_x;
		int32_t L_3 = __this->___parameterIndex_2;
		int32_t L_4 = __this->___order_3;
		NullCheck(L_0);
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_5;
		L_5 = NumericalDerivative_EvaluatePartialDerivative_m365C3DB2EC65FF94BC7B14ED2787FECE64705C5C(L_0, L_1, L_2, L_3, L_4, (Nullable_1U5BU5D_t8608EFC3D4A79785F59C7AB124AD5FBE0F75BCF1*)NULL, NULL);
		return L_5;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void MathNet.Numerics.Differentiation.NumericalDerivative/<>c__DisplayClass37_0::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass37_0__ctor_mD34308515D296A888A4F1D808FCCBBBADDDB54B8 (U3CU3Ec__DisplayClass37_0_tB67C49B4F7E09BCA7E1D145A632C77D2A55C3617* __this, const RuntimeMethod* method) 
{
	{
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		return;
	}
}
// System.Double MathNet.Numerics.Differentiation.NumericalDerivative/<>c__DisplayClass37_0::<CreateMixedPartialDerivativeFunctionHandle>b__0(System.Double[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR double U3CU3Ec__DisplayClass37_0_U3CCreateMixedPartialDerivativeFunctionHandleU3Eb__0_mB16331F68765F8AEBB943CF3237BB509C5C9EE6A (U3CU3Ec__DisplayClass37_0_tB67C49B4F7E09BCA7E1D145A632C77D2A55C3617* __this, DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* ___0_x, const RuntimeMethod* method) 
{
	Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* L_0 = __this->___U3CU3E4__this_0;
		Func_2_t89B8106282004E94AE869931CD4E1DF667EB235E* L_1 = __this->___f_1;
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_2 = ___0_x;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_3 = __this->___parameterIndex_2;
		int32_t L_4 = __this->___order_3;
		il2cpp_codegen_initobj((&V_0), sizeof(Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165));
		Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165 L_5 = V_0;
		NullCheck(L_0);
		double L_6;
		L_6 = NumericalDerivative_EvaluateMixedPartialDerivative_mB6986A98BC73CFEBD25C1203BE8DE3F1D22849CE(L_0, L_1, L_2, L_3, L_4, L_5, NULL);
		return L_6;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void MathNet.Numerics.Differentiation.NumericalDerivative/<>c__DisplayClass38_0::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass38_0__ctor_m1A33209F6B18D3C7E7A353633731F2B855A86117 (U3CU3Ec__DisplayClass38_0_t09E32000AEB1ECF9C6180CB2696459BB31E78B3D* __this, const RuntimeMethod* method) 
{
	{
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		return;
	}
}
// System.Double[] MathNet.Numerics.Differentiation.NumericalDerivative/<>c__DisplayClass38_0::<CreateMixedPartialDerivativeFunctionHandle>b__0(System.Double[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* U3CU3Ec__DisplayClass38_0_U3CCreateMixedPartialDerivativeFunctionHandleU3Eb__0_mF11172BC451306DB25036D54218C850D1E7F9245 (U3CU3Ec__DisplayClass38_0_t09E32000AEB1ECF9C6180CB2696459BB31E78B3D* __this, DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* ___0_x, const RuntimeMethod* method) 
{
	{
		NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* L_0 = __this->___U3CU3E4__this_0;
		Func_2U5BU5D_tAFC1A2A6571948ADB9C2BC67B555510E993FC60A* L_1 = __this->___f_1;
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_2 = ___0_x;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_3 = __this->___parameterIndex_2;
		int32_t L_4 = __this->___order_3;
		NullCheck(L_0);
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_5;
		L_5 = NumericalDerivative_EvaluateMixedPartialDerivative_mACD450152ADEA0BF5A5B5BD75A33836B66661E8E(L_0, L_1, L_2, L_3, L_4, (Nullable_1U5BU5D_t8608EFC3D4A79785F59C7AB124AD5FBE0F75BCF1*)NULL, NULL);
		return L_5;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Int32 MathNet.Numerics.Differentiation.NumericalHessian::get_FunctionEvaluations()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t NumericalHessian_get_FunctionEvaluations_m25E2E3D4A1DCC1B1C024B1FD1EB71171F3C8F94E (NumericalHessian_tC668F2E392EB9EDB3A980FAA9946531D5078E102* __this, const RuntimeMethod* method) 
{
	{
		NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* L_0 = __this->____df_0;
		NullCheck(L_0);
		int32_t L_1;
		L_1 = NumericalDerivative_get_Evaluations_mCA8A041C5842CB4239707CB207A053D3037151FE_inline(L_0, NULL);
		return L_1;
	}
}
// System.Void MathNet.Numerics.Differentiation.NumericalHessian::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NumericalHessian__ctor_m3F3F487D07B43C7662AC255521337E547FFED477 (NumericalHessian_tC668F2E392EB9EDB3A980FAA9946531D5078E102* __this, const RuntimeMethod* method) 
{
	{
		NumericalHessian__ctor_mFC1EEA412511BBEC606939B9C542F77B52AE283A(__this, 3, 1, NULL);
		return;
	}
}
// System.Void MathNet.Numerics.Differentiation.NumericalHessian::.ctor(System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NumericalHessian__ctor_mFC1EEA412511BBEC606939B9C542F77B52AE283A (NumericalHessian_tC668F2E392EB9EDB3A980FAA9946531D5078E102* __this, int32_t ___0_points, int32_t ___1_center, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		int32_t L_0 = ___0_points;
		int32_t L_1 = ___1_center;
		NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* L_2 = (NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8*)il2cpp_codegen_object_new(NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8_il2cpp_TypeInfo_var);
		NullCheck(L_2);
		NumericalDerivative__ctor_m94BF5A04E867018682D56B120B89E5B00595739E(L_2, L_0, L_1, NULL);
		__this->____df_0 = L_2;
		Il2CppCodeGenWriteBarrier((void**)(&__this->____df_0), (void*)L_2);
		return;
	}
}
// System.Double[] MathNet.Numerics.Differentiation.NumericalHessian::Evaluate(System.Func`2<System.Double,System.Double>,System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* NumericalHessian_Evaluate_mA4CEDA5DA1CEE7800404FC1E54D7553BB82EAF00 (NumericalHessian_tC668F2E392EB9EDB3A980FAA9946531D5078E102* __this, Func_2_t0221E9CE1FF8B8FE59AED052D562790B96F13B3D* ___0_f, double ___1_x, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_0 = (DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE*)(DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE*)SZArrayNew(DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE_il2cpp_TypeInfo_var, (uint32_t)1);
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_1 = L_0;
		NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* L_2 = __this->____df_0;
		Func_2_t0221E9CE1FF8B8FE59AED052D562790B96F13B3D* L_3 = ___0_f;
		double L_4 = ___1_x;
		il2cpp_codegen_initobj((&V_0), sizeof(Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165));
		Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165 L_5 = V_0;
		NullCheck(L_2);
		double L_6;
		L_6 = NumericalDerivative_EvaluateDerivative_m4D6F74A0B7826E6CD850B8D34DC3D91EA2AC0B21(L_2, L_3, L_4, 2, L_5, NULL);
		NullCheck(L_1);
		(L_1)->SetAt(static_cast<il2cpp_array_size_t>(0), (double)L_6);
		return L_1;
	}
}
// System.Double[,] MathNet.Numerics.Differentiation.NumericalHessian::Evaluate(System.Func`2<System.Double[],System.Double>,System.Double[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR DoubleU5BU2CU5D_tA10EAF4C451E6EBC345A8881EBB9EF9441D01AAE* NumericalHessian_Evaluate_m899346B7F16BEAA195F9DFF34896B6450A9A1C95 (NumericalHessian_tC668F2E392EB9EDB3A980FAA9946531D5078E102* __this, Func_2_t89B8106282004E94AE869931CD4E1DF667EB235E* ___0_f, DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* ___1_x, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&DoubleU5BU2CU5D_tA10EAF4C451E6EBC345A8881EBB9EF9441D01AAE_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	DoubleU5BU2CU5D_tA10EAF4C451E6EBC345A8881EBB9EF9441D01AAE* V_0 = NULL;
	int32_t V_1 = 0;
	Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165 V_2;
	memset((&V_2), 0, sizeof(V_2));
	int32_t V_3 = 0;
	int32_t V_4 = 0;
	double V_5 = 0.0;
	{
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_0 = ___1_x;
		NullCheck(L_0);
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_1 = ___1_x;
		NullCheck(L_1);
		il2cpp_array_size_t L_3[] = { (il2cpp_array_size_t)((int32_t)(((RuntimeArray*)L_0)->max_length)), (il2cpp_array_size_t)((int32_t)(((RuntimeArray*)L_1)->max_length)) };
		DoubleU5BU2CU5D_tA10EAF4C451E6EBC345A8881EBB9EF9441D01AAE* L_2 = (DoubleU5BU2CU5D_tA10EAF4C451E6EBC345A8881EBB9EF9441D01AAE*)GenArrayNew(DoubleU5BU2CU5D_tA10EAF4C451E6EBC345A8881EBB9EF9441D01AAE_il2cpp_TypeInfo_var, L_3);
		V_0 = L_2;
		V_1 = 0;
		goto IL_0034;
	}

IL_0010:
	{
		DoubleU5BU2CU5D_tA10EAF4C451E6EBC345A8881EBB9EF9441D01AAE* L_4 = V_0;
		int32_t L_5 = V_1;
		int32_t L_6 = V_1;
		NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* L_7 = __this->____df_0;
		Func_2_t89B8106282004E94AE869931CD4E1DF667EB235E* L_8 = ___0_f;
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_9 = ___1_x;
		int32_t L_10 = V_1;
		il2cpp_codegen_initobj((&V_2), sizeof(Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165));
		Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165 L_11 = V_2;
		NullCheck(L_7);
		double L_12;
		L_12 = NumericalDerivative_EvaluatePartialDerivative_mDE906B586F0CCE53070CC5DCB0670419D1F22D87(L_7, L_8, L_9, L_10, 2, L_11, NULL);
		NullCheck(L_4);
		(L_4)->SetAt(L_5, L_6, L_12);
		int32_t L_13 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add(L_13, 1));
	}

IL_0034:
	{
		int32_t L_14 = V_1;
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_15 = ___1_x;
		NullCheck(L_15);
		if ((((int32_t)L_14) < ((int32_t)((int32_t)(((RuntimeArray*)L_15)->max_length)))))
		{
			goto IL_0010;
		}
	}
	{
		V_3 = 0;
		goto IL_0090;
	}

IL_003e:
	{
		V_4 = 0;
		goto IL_0087;
	}

IL_0043:
	{
		NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* L_16 = __this->____df_0;
		Func_2_t89B8106282004E94AE869931CD4E1DF667EB235E* L_17 = ___0_f;
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_18 = ___1_x;
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_19 = (Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C*)(Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C*)SZArrayNew(Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C_il2cpp_TypeInfo_var, (uint32_t)2);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_20 = L_19;
		int32_t L_21 = V_3;
		NullCheck(L_20);
		(L_20)->SetAt(static_cast<il2cpp_array_size_t>(0), (int32_t)L_21);
		Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* L_22 = L_20;
		int32_t L_23 = V_4;
		NullCheck(L_22);
		(L_22)->SetAt(static_cast<il2cpp_array_size_t>(1), (int32_t)L_23);
		il2cpp_codegen_initobj((&V_2), sizeof(Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165));
		Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165 L_24 = V_2;
		NullCheck(L_16);
		double L_25;
		L_25 = NumericalDerivative_EvaluateMixedPartialDerivative_mB6986A98BC73CFEBD25C1203BE8DE3F1D22849CE(L_16, L_17, L_18, L_22, 2, L_24, NULL);
		V_5 = L_25;
		DoubleU5BU2CU5D_tA10EAF4C451E6EBC345A8881EBB9EF9441D01AAE* L_26 = V_0;
		int32_t L_27 = V_3;
		int32_t L_28 = V_4;
		double L_29 = V_5;
		NullCheck(L_26);
		(L_26)->SetAt(L_27, L_28, L_29);
		DoubleU5BU2CU5D_tA10EAF4C451E6EBC345A8881EBB9EF9441D01AAE* L_30 = V_0;
		int32_t L_31 = V_4;
		int32_t L_32 = V_3;
		double L_33 = V_5;
		NullCheck(L_30);
		(L_30)->SetAt(L_31, L_32, L_33);
		int32_t L_34 = V_4;
		V_4 = ((int32_t)il2cpp_codegen_add(L_34, 1));
	}

IL_0087:
	{
		int32_t L_35 = V_4;
		int32_t L_36 = V_3;
		if ((((int32_t)L_35) < ((int32_t)L_36)))
		{
			goto IL_0043;
		}
	}
	{
		int32_t L_37 = V_3;
		V_3 = ((int32_t)il2cpp_codegen_add(L_37, 1));
	}

IL_0090:
	{
		int32_t L_38 = V_3;
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_39 = ___1_x;
		NullCheck(L_39);
		if ((((int32_t)L_38) < ((int32_t)((int32_t)(((RuntimeArray*)L_39)->max_length)))))
		{
			goto IL_003e;
		}
	}
	{
		DoubleU5BU2CU5D_tA10EAF4C451E6EBC345A8881EBB9EF9441D01AAE* L_40 = V_0;
		return L_40;
	}
}
// System.Void MathNet.Numerics.Differentiation.NumericalHessian::ResetFunctionEvaluations()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NumericalHessian_ResetFunctionEvaluations_m6B37791EE89224E68D5BD32632E5F7896DC96E80 (NumericalHessian_tC668F2E392EB9EDB3A980FAA9946531D5078E102* __this, const RuntimeMethod* method) 
{
	{
		NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* L_0 = __this->____df_0;
		NullCheck(L_0);
		NumericalDerivative_ResetEvaluations_m6F6F8564E3BB74CBB55B0A4A1F16460966147057(L_0, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Int32 MathNet.Numerics.Differentiation.NumericalJacobian::get_FunctionEvaluations()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t NumericalJacobian_get_FunctionEvaluations_m6E520568DB4B4662E7620EF5DAB399F2A911C31B (NumericalJacobian_tC9F1ECB42F01952106C19C255A6694627F3A2D78* __this, const RuntimeMethod* method) 
{
	{
		NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* L_0 = __this->____df_0;
		NullCheck(L_0);
		int32_t L_1;
		L_1 = NumericalDerivative_get_Evaluations_mCA8A041C5842CB4239707CB207A053D3037151FE_inline(L_0, NULL);
		return L_1;
	}
}
// System.Void MathNet.Numerics.Differentiation.NumericalJacobian::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NumericalJacobian__ctor_mB4D9DBA3E160740A914899724053294DB3AC1562 (NumericalJacobian_tC9F1ECB42F01952106C19C255A6694627F3A2D78* __this, const RuntimeMethod* method) 
{
	{
		NumericalJacobian__ctor_m77ED8BEF165A927D9AF1A0195CF7D7E159C93E16(__this, 3, 1, NULL);
		return;
	}
}
// System.Void MathNet.Numerics.Differentiation.NumericalJacobian::.ctor(System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NumericalJacobian__ctor_m77ED8BEF165A927D9AF1A0195CF7D7E159C93E16 (NumericalJacobian_tC9F1ECB42F01952106C19C255A6694627F3A2D78* __this, int32_t ___0_points, int32_t ___1_center, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		int32_t L_0 = ___0_points;
		int32_t L_1 = ___1_center;
		NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* L_2 = (NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8*)il2cpp_codegen_object_new(NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8_il2cpp_TypeInfo_var);
		NullCheck(L_2);
		NumericalDerivative__ctor_m94BF5A04E867018682D56B120B89E5B00595739E(L_2, L_0, L_1, NULL);
		__this->____df_0 = L_2;
		Il2CppCodeGenWriteBarrier((void**)(&__this->____df_0), (void*)L_2);
		return;
	}
}
// System.Double[] MathNet.Numerics.Differentiation.NumericalJacobian::Evaluate(System.Func`2<System.Double,System.Double>,System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* NumericalJacobian_Evaluate_m6EF2E410B0E1662A2F29ECE5EA858F8F7975F5E4 (NumericalJacobian_tC9F1ECB42F01952106C19C255A6694627F3A2D78* __this, Func_2_t0221E9CE1FF8B8FE59AED052D562790B96F13B3D* ___0_f, double ___1_x, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_0 = (DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE*)(DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE*)SZArrayNew(DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE_il2cpp_TypeInfo_var, (uint32_t)1);
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_1 = L_0;
		NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* L_2 = __this->____df_0;
		Func_2_t0221E9CE1FF8B8FE59AED052D562790B96F13B3D* L_3 = ___0_f;
		double L_4 = ___1_x;
		il2cpp_codegen_initobj((&V_0), sizeof(Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165));
		Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165 L_5 = V_0;
		NullCheck(L_2);
		double L_6;
		L_6 = NumericalDerivative_EvaluateDerivative_m4D6F74A0B7826E6CD850B8D34DC3D91EA2AC0B21(L_2, L_3, L_4, 1, L_5, NULL);
		NullCheck(L_1);
		(L_1)->SetAt(static_cast<il2cpp_array_size_t>(0), (double)L_6);
		return L_1;
	}
}
// System.Double[] MathNet.Numerics.Differentiation.NumericalJacobian::Evaluate(System.Func`2<System.Double[],System.Double>,System.Double[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* NumericalJacobian_Evaluate_mAB1B25F8143BD558F79CDC1D72C8B65BAEE6B732 (NumericalJacobian_tC9F1ECB42F01952106C19C255A6694627F3A2D78* __this, Func_2_t89B8106282004E94AE869931CD4E1DF667EB235E* ___0_f, DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* ___1_x, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* V_0 = NULL;
	int32_t V_1 = 0;
	Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165 V_2;
	memset((&V_2), 0, sizeof(V_2));
	{
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_0 = ___1_x;
		NullCheck(L_0);
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_1 = (DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE*)(DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE*)SZArrayNew(DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE_il2cpp_TypeInfo_var, (uint32_t)((int32_t)(((RuntimeArray*)L_0)->max_length)));
		V_0 = L_1;
		V_1 = 0;
		goto IL_002c;
	}

IL_000d:
	{
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_2 = V_0;
		int32_t L_3 = V_1;
		NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* L_4 = __this->____df_0;
		Func_2_t89B8106282004E94AE869931CD4E1DF667EB235E* L_5 = ___0_f;
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_6 = ___1_x;
		int32_t L_7 = V_1;
		il2cpp_codegen_initobj((&V_2), sizeof(Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165));
		Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165 L_8 = V_2;
		NullCheck(L_4);
		double L_9;
		L_9 = NumericalDerivative_EvaluatePartialDerivative_mDE906B586F0CCE53070CC5DCB0670419D1F22D87(L_4, L_5, L_6, L_7, 1, L_8, NULL);
		NullCheck(L_2);
		(L_2)->SetAt(static_cast<il2cpp_array_size_t>(L_3), (double)L_9);
		int32_t L_10 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add(L_10, 1));
	}

IL_002c:
	{
		int32_t L_11 = V_1;
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_12 = V_0;
		NullCheck(L_12);
		if ((((int32_t)L_11) < ((int32_t)((int32_t)(((RuntimeArray*)L_12)->max_length)))))
		{
			goto IL_000d;
		}
	}
	{
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_13 = V_0;
		return L_13;
	}
}
// System.Double[] MathNet.Numerics.Differentiation.NumericalJacobian::Evaluate(System.Func`2<System.Double[],System.Double>,System.Double[],System.Double)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* NumericalJacobian_Evaluate_mE48D1D33054AB0B4AD2168BD2BD32E48DF784549 (NumericalJacobian_tC9F1ECB42F01952106C19C255A6694627F3A2D78* __this, Func_2_t89B8106282004E94AE869931CD4E1DF667EB235E* ___0_f, DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* ___1_x, double ___2_currentValue, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Nullable_1__ctor_mDE3158DD99CA7E1775A8BA276E428AF808AB8FBF_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* V_0 = NULL;
	int32_t V_1 = 0;
	{
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_0 = ___1_x;
		NullCheck(L_0);
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_1 = (DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE*)(DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE*)SZArrayNew(DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE_il2cpp_TypeInfo_var, (uint32_t)((int32_t)(((RuntimeArray*)L_0)->max_length)));
		V_0 = L_1;
		V_1 = 0;
		goto IL_0029;
	}

IL_000d:
	{
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_2 = V_0;
		int32_t L_3 = V_1;
		NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* L_4 = __this->____df_0;
		Func_2_t89B8106282004E94AE869931CD4E1DF667EB235E* L_5 = ___0_f;
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_6 = ___1_x;
		int32_t L_7 = V_1;
		double L_8 = ___2_currentValue;
		Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165 L_9;
		memset((&L_9), 0, sizeof(L_9));
		Nullable_1__ctor_mDE3158DD99CA7E1775A8BA276E428AF808AB8FBF((&L_9), L_8, /*hidden argument*/Nullable_1__ctor_mDE3158DD99CA7E1775A8BA276E428AF808AB8FBF_RuntimeMethod_var);
		NullCheck(L_4);
		double L_10;
		L_10 = NumericalDerivative_EvaluatePartialDerivative_mDE906B586F0CCE53070CC5DCB0670419D1F22D87(L_4, L_5, L_6, L_7, 1, L_9, NULL);
		NullCheck(L_2);
		(L_2)->SetAt(static_cast<il2cpp_array_size_t>(L_3), (double)L_10);
		int32_t L_11 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add(L_11, 1));
	}

IL_0029:
	{
		int32_t L_12 = V_1;
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_13 = V_0;
		NullCheck(L_13);
		if ((((int32_t)L_12) < ((int32_t)((int32_t)(((RuntimeArray*)L_13)->max_length)))))
		{
			goto IL_000d;
		}
	}
	{
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_14 = V_0;
		return L_14;
	}
}
// System.Double[,] MathNet.Numerics.Differentiation.NumericalJacobian::Evaluate(System.Func`2<System.Double[],System.Double>[],System.Double[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR DoubleU5BU2CU5D_tA10EAF4C451E6EBC345A8881EBB9EF9441D01AAE* NumericalJacobian_Evaluate_mCD6284403CF1291C5FB53B404FCFFD191349D5E2 (NumericalJacobian_tC9F1ECB42F01952106C19C255A6694627F3A2D78* __this, Func_2U5BU5D_tAFC1A2A6571948ADB9C2BC67B555510E993FC60A* ___0_f, DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* ___1_x, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&DoubleU5BU2CU5D_tA10EAF4C451E6EBC345A8881EBB9EF9441D01AAE_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	DoubleU5BU2CU5D_tA10EAF4C451E6EBC345A8881EBB9EF9441D01AAE* V_0 = NULL;
	int32_t V_1 = 0;
	DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* V_2 = NULL;
	int32_t V_3 = 0;
	{
		Func_2U5BU5D_tAFC1A2A6571948ADB9C2BC67B555510E993FC60A* L_0 = ___0_f;
		NullCheck(L_0);
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_1 = ___1_x;
		NullCheck(L_1);
		il2cpp_array_size_t L_3[] = { (il2cpp_array_size_t)((int32_t)(((RuntimeArray*)L_0)->max_length)), (il2cpp_array_size_t)((int32_t)(((RuntimeArray*)L_1)->max_length)) };
		DoubleU5BU2CU5D_tA10EAF4C451E6EBC345A8881EBB9EF9441D01AAE* L_2 = (DoubleU5BU2CU5D_tA10EAF4C451E6EBC345A8881EBB9EF9441D01AAE*)GenArrayNew(DoubleU5BU2CU5D_tA10EAF4C451E6EBC345A8881EBB9EF9441D01AAE_il2cpp_TypeInfo_var, L_3);
		V_0 = L_2;
		V_1 = 0;
		goto IL_0038;
	}

IL_0010:
	{
		Func_2U5BU5D_tAFC1A2A6571948ADB9C2BC67B555510E993FC60A* L_4 = ___0_f;
		int32_t L_5 = V_1;
		NullCheck(L_4);
		int32_t L_6 = L_5;
		Func_2_t89B8106282004E94AE869931CD4E1DF667EB235E* L_7 = (L_4)->GetAt(static_cast<il2cpp_array_size_t>(L_6));
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_8 = ___1_x;
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_9;
		L_9 = NumericalJacobian_Evaluate_mAB1B25F8143BD558F79CDC1D72C8B65BAEE6B732(__this, L_7, L_8, NULL);
		V_2 = L_9;
		V_3 = 0;
		goto IL_002e;
	}

IL_001f:
	{
		DoubleU5BU2CU5D_tA10EAF4C451E6EBC345A8881EBB9EF9441D01AAE* L_10 = V_0;
		int32_t L_11 = V_1;
		int32_t L_12 = V_3;
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_13 = V_2;
		int32_t L_14 = V_3;
		NullCheck(L_13);
		int32_t L_15 = L_14;
		double L_16 = (L_13)->GetAt(static_cast<il2cpp_array_size_t>(L_15));
		NullCheck(L_10);
		(L_10)->SetAt(L_11, L_12, L_16);
		int32_t L_17 = V_3;
		V_3 = ((int32_t)il2cpp_codegen_add(L_17, 1));
	}

IL_002e:
	{
		int32_t L_18 = V_3;
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_19 = V_2;
		NullCheck(L_19);
		if ((((int32_t)L_18) < ((int32_t)((int32_t)(((RuntimeArray*)L_19)->max_length)))))
		{
			goto IL_001f;
		}
	}
	{
		int32_t L_20 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add(L_20, 1));
	}

IL_0038:
	{
		int32_t L_21 = V_1;
		Func_2U5BU5D_tAFC1A2A6571948ADB9C2BC67B555510E993FC60A* L_22 = ___0_f;
		NullCheck(L_22);
		if ((((int32_t)L_21) < ((int32_t)((int32_t)(((RuntimeArray*)L_22)->max_length)))))
		{
			goto IL_0010;
		}
	}
	{
		DoubleU5BU2CU5D_tA10EAF4C451E6EBC345A8881EBB9EF9441D01AAE* L_23 = V_0;
		return L_23;
	}
}
// System.Double[,] MathNet.Numerics.Differentiation.NumericalJacobian::Evaluate(System.Func`2<System.Double[],System.Double>[],System.Double[],System.Double[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR DoubleU5BU2CU5D_tA10EAF4C451E6EBC345A8881EBB9EF9441D01AAE* NumericalJacobian_Evaluate_m26A823EEA4A2B714189C88D325316030BF7EC336 (NumericalJacobian_tC9F1ECB42F01952106C19C255A6694627F3A2D78* __this, Func_2U5BU5D_tAFC1A2A6571948ADB9C2BC67B555510E993FC60A* ___0_f, DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* ___1_x, DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* ___2_currentValues, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&DoubleU5BU2CU5D_tA10EAF4C451E6EBC345A8881EBB9EF9441D01AAE_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	DoubleU5BU2CU5D_tA10EAF4C451E6EBC345A8881EBB9EF9441D01AAE* V_0 = NULL;
	int32_t V_1 = 0;
	DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* V_2 = NULL;
	int32_t V_3 = 0;
	{
		Func_2U5BU5D_tAFC1A2A6571948ADB9C2BC67B555510E993FC60A* L_0 = ___0_f;
		NullCheck(L_0);
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_1 = ___1_x;
		NullCheck(L_1);
		il2cpp_array_size_t L_3[] = { (il2cpp_array_size_t)((int32_t)(((RuntimeArray*)L_0)->max_length)), (il2cpp_array_size_t)((int32_t)(((RuntimeArray*)L_1)->max_length)) };
		DoubleU5BU2CU5D_tA10EAF4C451E6EBC345A8881EBB9EF9441D01AAE* L_2 = (DoubleU5BU2CU5D_tA10EAF4C451E6EBC345A8881EBB9EF9441D01AAE*)GenArrayNew(DoubleU5BU2CU5D_tA10EAF4C451E6EBC345A8881EBB9EF9441D01AAE_il2cpp_TypeInfo_var, L_3);
		V_0 = L_2;
		V_1 = 0;
		goto IL_003b;
	}

IL_0010:
	{
		Func_2U5BU5D_tAFC1A2A6571948ADB9C2BC67B555510E993FC60A* L_4 = ___0_f;
		int32_t L_5 = V_1;
		NullCheck(L_4);
		int32_t L_6 = L_5;
		Func_2_t89B8106282004E94AE869931CD4E1DF667EB235E* L_7 = (L_4)->GetAt(static_cast<il2cpp_array_size_t>(L_6));
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_8 = ___1_x;
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_9 = ___2_currentValues;
		int32_t L_10 = V_1;
		NullCheck(L_9);
		int32_t L_11 = L_10;
		double L_12 = (L_9)->GetAt(static_cast<il2cpp_array_size_t>(L_11));
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_13;
		L_13 = NumericalJacobian_Evaluate_mE48D1D33054AB0B4AD2168BD2BD32E48DF784549(__this, L_7, L_8, L_12, NULL);
		V_2 = L_13;
		V_3 = 0;
		goto IL_0031;
	}

IL_0022:
	{
		DoubleU5BU2CU5D_tA10EAF4C451E6EBC345A8881EBB9EF9441D01AAE* L_14 = V_0;
		int32_t L_15 = V_1;
		int32_t L_16 = V_3;
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_17 = V_2;
		int32_t L_18 = V_3;
		NullCheck(L_17);
		int32_t L_19 = L_18;
		double L_20 = (L_17)->GetAt(static_cast<il2cpp_array_size_t>(L_19));
		NullCheck(L_14);
		(L_14)->SetAt(L_15, L_16, L_20);
		int32_t L_21 = V_3;
		V_3 = ((int32_t)il2cpp_codegen_add(L_21, 1));
	}

IL_0031:
	{
		int32_t L_22 = V_3;
		DoubleU5BU5D_tCC308475BD3B8229DB2582938669EF2F9ECC1FEE* L_23 = V_2;
		NullCheck(L_23);
		if ((((int32_t)L_22) < ((int32_t)((int32_t)(((RuntimeArray*)L_23)->max_length)))))
		{
			goto IL_0022;
		}
	}
	{
		int32_t L_24 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add(L_24, 1));
	}

IL_003b:
	{
		int32_t L_25 = V_1;
		Func_2U5BU5D_tAFC1A2A6571948ADB9C2BC67B555510E993FC60A* L_26 = ___0_f;
		NullCheck(L_26);
		if ((((int32_t)L_25) < ((int32_t)((int32_t)(((RuntimeArray*)L_26)->max_length)))))
		{
			goto IL_0010;
		}
	}
	{
		DoubleU5BU2CU5D_tA10EAF4C451E6EBC345A8881EBB9EF9441D01AAE* L_27 = V_0;
		return L_27;
	}
}
// System.Void MathNet.Numerics.Differentiation.NumericalJacobian::ResetFunctionEvaluations()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void NumericalJacobian_ResetFunctionEvaluations_mD6802A1FBB5C6790FE79451CCA1E6CC5E4DD9366 (NumericalJacobian_tC9F1ECB42F01952106C19C255A6694627F3A2D78* __this, const RuntimeMethod* method) 
{
	{
		NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* L_0 = __this->____df_0;
		NullCheck(L_0);
		NumericalDerivative_ResetEvaluations_m6F6F8564E3BB74CBB55B0A4A1F16460966147057(L_0, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
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
#ifdef __clang__
#pragma clang diagnostic pop
#endif
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
#ifdef __clang__
#pragma clang diagnostic pop
#endif
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
#ifdef __clang__
#pragma clang diagnostic pop
#endif
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
#ifdef __clang__
#pragma clang diagnostic pop
#endif
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
#ifdef __clang__
#pragma clang diagnostic pop
#endif
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
#ifdef __clang__
#pragma clang diagnostic pop
#endif
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
#ifdef __clang__
#pragma clang diagnostic pop
#endif
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
#ifdef __clang__
#pragma clang diagnostic pop
#endif
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
#ifdef __clang__
#pragma clang diagnostic pop
#endif
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
#ifdef __clang__
#pragma clang diagnostic pop
#endif
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
#ifdef __clang__
#pragma clang diagnostic pop
#endif
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
#ifdef __clang__
#pragma clang diagnostic pop
#endif
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
#ifdef __clang__
#pragma clang diagnostic pop
#endif
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
#ifdef __clang__
#pragma clang diagnostic pop
#endif
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
#ifdef __clang__
#pragma clang diagnostic pop
#endif
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
#ifdef __clang__
#pragma clang diagnostic pop
#endif
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
#ifdef __clang__
#pragma clang diagnostic pop
#endif
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
#ifdef __clang__
#pragma clang diagnostic pop
#endif
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
#ifdef __clang__
#pragma clang diagnostic pop
#endif
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
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool Control_get_CheckDistributionParameters_mCCA3C1C492BF697B4A7181481C894D2E2D8CD093_inline (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Control_t697AAECEE3ACCC3477BE1CF29E56F7D224BD26DA_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		il2cpp_codegen_runtime_class_init_inline(Control_t697AAECEE3ACCC3477BE1CF29E56F7D224BD26DA_il2cpp_TypeInfo_var);
		bool L_0 = ((Control_t697AAECEE3ACCC3477BE1CF29E56F7D224BD26DA_StaticFields*)il2cpp_codegen_static_fields_for(Control_t697AAECEE3ACCC3477BE1CF29E56F7D224BD26DA_il2cpp_TypeInfo_var))->___U3CCheckDistributionParametersU3Ek__BackingField_4;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool Double_IsNaN_mF2BC6D1FD4813179B2CAE58D29770E42830D0883_inline (double ___0_d, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&BitConverter_t6E99605185963BC12B3D369E13F2B88997E64A27_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		double L_0 = ___0_d;
		il2cpp_codegen_runtime_class_init_inline(BitConverter_t6E99605185963BC12B3D369E13F2B88997E64A27_il2cpp_TypeInfo_var);
		int64_t L_1;
		L_1 = BitConverter_DoubleToInt64Bits_m4F42741818550F9956B5FBAF88C051F4DE5B0AE6_inline(L_0, NULL);
		return (bool)((((int64_t)((int64_t)(L_1&((int64_t)(std::numeric_limits<int64_t>::max)())))) > ((int64_t)((int64_t)9218868437227405312LL)))? 1 : 0);
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8* Wishart_get_RandomSource_m2FD439F2EA4CD9FE9D99EDE884771950DCA00797_inline (Wishart_tDEFFEE7331AA0DC9A9F45284E8CCA00CB8012135* __this, const RuntimeMethod* method) 
{
	{
		Random_t79716069EDE67D1D7734F60AE402D0CA3FB6B4C8* L_0 = __this->____random_0;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t FiniteDifferenceCoefficients_get_Points_mAA4ACE7A8E867B1361D8A67F5E61662943736E00_inline (FiniteDifferenceCoefficients_t4C297B32541755227C3C396F2EE875CD3C6369DD* __this, const RuntimeMethod* method) 
{
	{
		int32_t L_0 = __this->____points_1;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR double Math_Round_mAD8888A4B6E25BBA84A6C87535E68689BC4F46C8_inline (double ___0_value, int32_t ___1_mode, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		double L_0 = ___0_value;
		int32_t L_1 = ___1_mode;
		il2cpp_codegen_runtime_class_init_inline(Math_tEB65DE7CA8B083C412C969C92981C030865486CE_il2cpp_TypeInfo_var);
		double L_2;
		L_2 = Math_Round_m8DB2F61CB73B9E71E54149290ABD5DC8A68890D1(L_0, 0, L_1, NULL);
		return L_2;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t NumericalDerivative_get_Center_m2A342DC5FBB8EAA82940F5D32883217021ACECD6_inline (NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* __this, const RuntimeMethod* method) 
{
	{
		int32_t L_0 = __this->____center_1;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t NumericalDerivative_get_Evaluations_mCA8A041C5842CB4239707CB207A053D3037151FE_inline (NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* __this, const RuntimeMethod* method) 
{
	{
		int32_t L_0 = __this->___U3CEvaluationsU3Ek__BackingField_6;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void NumericalDerivative_set_Evaluations_mCCE3A9BE2B152CFFC6B9C02EEC6641E392048042_inline (NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* __this, int32_t ___0_value, const RuntimeMethod* method) 
{
	{
		int32_t L_0 = ___0_value;
		__this->___U3CEvaluationsU3Ek__BackingField_6 = L_0;
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t NumericalDerivative_get_StepType_m9067F9BAD716966954DD4090822BF911594D592F_inline (NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* __this, const RuntimeMethod* method) 
{
	{
		int32_t L_0 = __this->___U3CStepTypeU3Ek__BackingField_7;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR double NumericalDerivative_get_BaseStepSize_mFAE6FF2D0717BF1E60A83EB6706241C50E154F17_inline (NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* __this, const RuntimeMethod* method) 
{
	{
		double L_0 = __this->____baseStepSize_4;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR double NumericalDerivative_get_Epsilon_mAA8717E023550582F3C2D9E6A89EF3E4723479AF_inline (NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* __this, const RuntimeMethod* method) 
{
	{
		double L_0 = __this->____epsilon_3;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR double NumericalDerivative_get_StepSize_m13C020A5C6ADCE52FF19373914AF86C84F3B58B5_inline (NumericalDerivative_t519F3B3B314E00BE377699A86DDD2BD8C33840A8* __this, const RuntimeMethod* method) 
{
	{
		double L_0 = __this->____stepSize_2;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t Matrix_1_get_RowCount_m9B54DCE02A3829F5EBD4D5D7ACF2615FCBA2A7E2_gshared_inline (Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* __this, const RuntimeMethod* method) 
{
	{
		int32_t L_0 = (int32_t)__this->___U3CRowCountU3Ek__BackingField_5;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t Matrix_1_get_ColumnCount_mA9469577A4E8459338A621B987E653D241A6883B_gshared_inline (Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* __this, const RuntimeMethod* method) 
{
	{
		int32_t L_0 = (int32_t)__this->___U3CColumnCountU3Ek__BackingField_4;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR double Matrix_1_At_mBA3B6ADE91F6541597F6BA43AD04B13E36998233_gshared_inline (Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* __this, int32_t ___0_row, int32_t ___1_column, const RuntimeMethod* method) 
{
	{
		MatrixStorage_1_t3274677608F0D866A33A7F6CB795B2C43D750C6D* L_0;
		L_0 = ((  MatrixStorage_1_t3274677608F0D866A33A7F6CB795B2C43D750C6D* (*) (Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 116)))(__this, il2cpp_rgctx_method(method->klass->rgctx_data, 116));
		int32_t L_1 = ___0_row;
		int32_t L_2 = ___1_column;
		NullCheck(L_0);
		double L_3;
		L_3 = VirtualFuncInvoker2< double, int32_t, int32_t >::Invoke(8 /* T MathNet.Numerics.LinearAlgebra.Storage.MatrixStorage`1<System.Double>::At(System.Int32,System.Int32) */, L_0, L_1, L_2);
		return L_3;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Matrix_1_At_m3510B6B24011AF518E2720B108836BF602246877_gshared_inline (Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* __this, int32_t ___0_row, int32_t ___1_column, double ___2_value, const RuntimeMethod* method) 
{
	{
		MatrixStorage_1_t3274677608F0D866A33A7F6CB795B2C43D750C6D* L_0;
		L_0 = ((  MatrixStorage_1_t3274677608F0D866A33A7F6CB795B2C43D750C6D* (*) (Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 116)))(__this, il2cpp_rgctx_method(method->klass->rgctx_data, 116));
		int32_t L_1 = ___0_row;
		int32_t L_2 = ___1_column;
		double L_3 = ___2_value;
		NullCheck(L_0);
		VirtualActionInvoker3< int32_t, int32_t, double >::Invoke(9 /* System.Void MathNet.Numerics.LinearAlgebra.Storage.MatrixStorage`1<System.Double>::At(System.Int32,System.Int32,T) */, L_0, L_1, L_2, L_3);
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* Cholesky_1_get_Factor_m0DAB4879B1C18A503BC02DB1055250A8611C5CA7_gshared_inline (Cholesky_1_t1FD2C6EAE804ACF062E3034A45A8D1004519525C* __this, const RuntimeMethod* method) 
{
	{
		Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* L_0 = (Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9*)__this->___U3CFactorU3Ek__BackingField_0;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Matrix_1_set_Item_mC97D847F561C86DD3856B0FA098D2D0529728B67_gshared_inline (Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* __this, int32_t ___0_row, int32_t ___1_column, double ___2_value, const RuntimeMethod* method) 
{
	{
		MatrixStorage_1_t3274677608F0D866A33A7F6CB795B2C43D750C6D* L_0;
		L_0 = ((  MatrixStorage_1_t3274677608F0D866A33A7F6CB795B2C43D750C6D* (*) (Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 116)))(__this, il2cpp_rgctx_method(method->klass->rgctx_data, 116));
		int32_t L_1 = ___0_row;
		int32_t L_2 = ___1_column;
		double L_3 = ___2_value;
		NullCheck(L_0);
		((  void (*) (MatrixStorage_1_t3274677608F0D866A33A7F6CB795B2C43D750C6D*, int32_t, int32_t, double, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 148)))(L_0, L_1, L_2, L_3, il2cpp_rgctx_method(method->klass->rgctx_data, 148));
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR double Matrix_1_get_Item_m9AC37D09D678515B98CFC7C5A3BBECAC3067D9DE_gshared_inline (Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9* __this, int32_t ___0_row, int32_t ___1_column, const RuntimeMethod* method) 
{
	{
		MatrixStorage_1_t3274677608F0D866A33A7F6CB795B2C43D750C6D* L_0;
		L_0 = ((  MatrixStorage_1_t3274677608F0D866A33A7F6CB795B2C43D750C6D* (*) (Matrix_1_t0FF8F8B6CEFB2DEA1D3A91F538DB2510E2AC37D9*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 116)))(__this, il2cpp_rgctx_method(method->klass->rgctx_data, 116));
		int32_t L_1 = ___0_row;
		int32_t L_2 = ___1_column;
		NullCheck(L_0);
		double L_3;
		L_3 = ((  double (*) (MatrixStorage_1_t3274677608F0D866A33A7F6CB795B2C43D750C6D*, int32_t, int32_t, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 147)))(L_0, L_1, L_2, il2cpp_rgctx_method(method->klass->rgctx_data, 147));
		return L_3;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool Nullable_1_get_HasValue_mC082C667C8EB3A6CA80E06BCAEA0BED00C6BC15A_gshared_inline (Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165* __this, const RuntimeMethod* method) 
{
	{
		bool L_0 = (bool)__this->___hasValue_0;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR double Func_2_Invoke_m762147834B46FC6B99180328AD303FC3F47CCD62_gshared_inline (Func_2_t0221E9CE1FF8B8FE59AED052D562790B96F13B3D* __this, double ___0_arg, const RuntimeMethod* method) 
{
	typedef double (*FunctionPointerType) (RuntimeObject*, double, const RuntimeMethod*);
	return ((FunctionPointerType)__this->___invoke_impl_1)((Il2CppObject*)__this->___method_code_6, ___0_arg, reinterpret_cast<RuntimeMethod*>(__this->___method_3));
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR double Func_2_Invoke_mD53F0155434EDFA18B5BDAD0B0F61AC5F82EB95B_gshared_inline (Func_2_t5D850B409400F6FC6B650829D4B758F5899212B1* __this, RuntimeObject* ___0_arg, const RuntimeMethod* method) 
{
	typedef double (*FunctionPointerType) (RuntimeObject*, RuntimeObject*, const RuntimeMethod*);
	return ((FunctionPointerType)__this->___invoke_impl_1)((Il2CppObject*)__this->___method_code_6, ___0_arg, reinterpret_cast<RuntimeMethod*>(__this->___method_3));
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int64_t BitConverter_DoubleToInt64Bits_m4F42741818550F9956B5FBAF88C051F4DE5B0AE6_inline (double ___0_value, const RuntimeMethod* method) 
{
	{
		int64_t L_0 = *((int64_t*)((uintptr_t)(&___0_value)));
		return L_0;
	}
}
