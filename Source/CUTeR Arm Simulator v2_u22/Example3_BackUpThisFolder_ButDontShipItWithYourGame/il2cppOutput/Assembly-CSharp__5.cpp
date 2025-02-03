#include "pch-cpp.hpp"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include <limits>


template <typename T1>
struct VirtualActionInvoker1
{
	typedef void (*Action)(void*, T1, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1 p1)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		((Action)invokeData.methodPtr)(obj, p1, invokeData.method);
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
template <typename R, typename T1, typename T2, typename T3>
struct VirtualFuncInvoker3
{
	typedef R (*Func)(void*, T1, T2, T3, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1 p1, T2 p2, T3 p3)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		return ((Func)invokeData.methodPtr)(obj, p1, p2, p3, invokeData.method);
	}
};
struct InterfaceActionInvoker0
{
	typedef void (*Action)(void*, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		((Action)invokeData.methodPtr)(obj, invokeData.method);
	}
};
template <typename T1, typename T2, typename T3, typename T4>
struct InterfaceActionInvoker4
{
	typedef void (*Action)(void*, T1, T2, T3, T4, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj, T1 p1, T2 p2, T3 p3, T4 p4)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		((Action)invokeData.methodPtr)(obj, p1, p2, p3, p4, invokeData.method);
	}
};
template <typename T1, typename T2, typename T3, typename T4, typename T5>
struct InterfaceActionInvoker5
{
	typedef void (*Action)(void*, T1, T2, T3, T4, T5, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		((Action)invokeData.methodPtr)(obj, p1, p2, p3, p4, p5, invokeData.method);
	}
};
template <typename R, typename T1, typename T2, typename T3>
struct InterfaceFuncInvoker3
{
	typedef R (*Func)(void*, T1, T2, T3, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj, T1 p1, T2 p2, T3 p3)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		return ((Func)invokeData.methodPtr)(obj, p1, p2, p3, invokeData.method);
	}
};
template <typename R, typename T1, typename T2, typename T3, typename T4>
struct InterfaceFuncInvoker4
{
	typedef R (*Func)(void*, T1, T2, T3, T4, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj, T1 p1, T2 p2, T3 p3, T4 p4)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		return ((Func)invokeData.methodPtr)(obj, p1, p2, p3, p4, invokeData.method);
	}
};

// System.Action`1<System.String[]>
struct Action_1_t5439CAB6DF93B6A7A29E473D9B2A9943E580CAF8;
// System.Action`1<System.String>
struct Action_1_t3CB5D1A819C3ED3F99E9E39F890F18633253949A;
// System.Action`1<TMPro.TMP_TextInfo>
struct Action_1_tB93AB717F9D419A1BEC832FF76E74EAA32184CC1;
// System.Comparison`1<UnityEngine.EventSystems.RaycastResult>
struct Comparison_1_t9FCAC8C8CE160A96C5AAD2DE1D353DCE8A2FEEFC;
// System.Collections.Generic.Dictionary`2<System.Int32,System.Int32>
struct Dictionary_2_tABE19B9C5C52F1DE14F0D3287B2696E7D7419180;
// System.Func`3<System.Int32,System.String,TMPro.TMP_FontAsset>
struct Func_3_tC721DF8CDD07ED66A4833A19A2ED2302608C906C;
// System.Func`3<System.Int32,System.String,TMPro.TMP_SpriteAsset>
struct Func_3_t6F6D9932638EA1A5A45303C6626C818C25D164E5;
// System.Collections.Generic.List`1<UnityEngine.EventSystems.BaseInputModule>
struct List_1_tA5BDE435C735A082941CD33D212F97F4AE9FA55F;
// System.Collections.Generic.List`1<UnityEngine.CanvasGroup>
struct List_1_t2CDCA768E7F493F5EDEBC75AEB200FD621354E35;
// System.Collections.Generic.List`1<UnityEngine.Color32>
struct List_1_t3517D52AE25CA3B19051E691E9C06ED03A3AB9B8;
// System.Collections.Generic.List`1<UnityEngine.EventSystems.EventSystem>
struct List_1_tF2FE88545EFEC788CAAE6C74EC2F78E937FCCAC3;
// System.Collections.Generic.List`1<UnityEngine.UI.Image>
struct List_1_tE6BB71ABF15905EFA2BE92C38A2716547AEADB19;
// System.Threading.Tasks.Task`1<System.Int32>
struct Task_1_t4C228DE57804012969575431CFF12D57C875552D;
// UnityEngine.UI.CoroutineTween.TweenRunner`1<UnityEngine.UI.CoroutineTween.ColorTween>
struct TweenRunner_1_t5BB0582F926E75E2FE795492679A6CF55A4B4BC4;
// UnityEngine.Events.UnityAction`1<System.Boolean>
struct UnityAction_1_t8EC357AF4FBD2A0C4A575C4BBD0B3A81029E43A9;
// UnityEngine.Events.UnityAction`1<System.Object>
struct UnityAction_1_t9C30BCD020745BF400CBACF22C6F34ADBA2DDA6A;
// UnityEngine.Events.UnityAction`1<System.String>
struct UnityAction_1_t690494F0E492A2098660E28B8EB7D71B2C69BE1B;
// UnityEngine.Events.UnityAction`4<UnityEngine.Color,UnityEngine.Color,UnityEngine.Color,UnityEngine.Color>
struct UnityAction_4_t05D51CE8BEA0460D330923E761D421EF194ED9B1;
// TMPro.TMP_TextProcessingStack`1<System.Int32>[]
struct TMP_TextProcessingStack_1U5BU5D_t08293E0BB072311BB96170F351D1083BCA97B9B2;
// System.Byte[]
struct ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031;
// System.Char[]
struct CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB;
// UnityEngine.Color[]
struct ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389;
// UnityEngine.Color32[]
struct Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259;
// System.Decimal[]
struct DecimalU5BU5D_t93BA0C88FA80728F73B792EE1A5199D0C060B615;
// System.Delegate[]
struct DelegateU5BU5D_tC5AB7E8F745616680F337909D3A8E6C722CDF771;
// SFB.ExtensionFilter[]
struct ExtensionFilterU5BU5D_t724AA1EDDC78E2F3CC3EB4C808F408EDF52EDCFD;
// TMPro.FontWeight[]
struct FontWeightU5BU5D_t2A406B5BAB0DD0F06E7F1773DB062E4AF98067BA;
// TMPro.HighlightState[]
struct HighlightStateU5BU5D_tA878A0AF1F4F52882ACD29515AADC277EE135622;
// TMPro.HorizontalAlignmentOptions[]
struct HorizontalAlignmentOptionsU5BU5D_t4D185662282BFB910D8B9A8199E91578E9422658;
// System.Int32[]
struct Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C;
// System.IntPtr[]
struct IntPtrU5BU5D_tFD177F8C806A6921AD7150264CCC62FA00CAD832;
// UnityEngine.Material[]
struct MaterialU5BU5D_t2B1D11C42DB07A4400C0535F92DBB87A2E346D3D;
// TMPro.MaterialReference[]
struct MaterialReferenceU5BU5D_t7491D335AB3E3E13CE9C0F5E931F396F6A02E1F2;
// System.Object[]
struct ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918;
// TMPro.RichTextTagAttribute[]
struct RichTextTagAttributeU5BU5D_t5816316EFD8F59DBC30B9F88E15828C564E47B6D;
// UnityEngine.UI.Selectable[]
struct SelectableU5BU5D_t4160E135F02A40F75A63F787D36F31FEC6FE91A9;
// System.Single[]
struct SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C;
// System.Diagnostics.StackTrace[]
struct StackTraceU5BU5D_t32FBCB20930EAF5BAE3F450FF75228E5450DA0DF;
// System.String[]
struct StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248;
// TMPro.TMP_CharacterInfo[]
struct TMP_CharacterInfoU5BU5D_t297D56FCF66DAA99D8FEA7C30F9F3926902C5B99;
// TMPro.TMP_ColorGradient[]
struct TMP_ColorGradientU5BU5D_t2F65E8C42F268DFF33BB1392D94BCF5B5087308A;
// TMPro.TMP_SubMeshUI[]
struct TMP_SubMeshUIU5BU5D_tC77B263183A59A75345C26152457207EAC3BBF29;
// UnityEngine.UIVertex[]
struct UIVertexU5BU5D_tBC532486B45D071A520751A90E819C77BA4E3D2F;
// System.UInt32[]
struct UInt32U5BU5D_t02FBD658AD156A17574ECE6106CF1FBFCC9807FA;
// UnityEngine.Vector2[]
struct Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA;
// UnityEngine.Vector3[]
struct Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C;
// TMPro.WordWrapState[]
struct WordWrapStateU5BU5D_t473D59C9DBCC949CE72EF1EB471CBA152A6CEAC9;
// TMPro.TMP_Text/UnicodeChar[]
struct UnicodeCharU5BU5D_t67F27D09F8EB28D2C42DFF16FE60054F157012F5;
// UnityEngine.UI.AnimationTriggers
struct AnimationTriggers_tA0DC06F89C5280C6DD972F6F4C8A56D7F4F79074;
// System.AsyncCallback
struct AsyncCallback_t7FEF460CBDCFB9C5FA2EF776984778B9A4145F4C;
// B83.Image.BMP.BMPImage
struct BMPImage_tA6E059574F192A9BB574E7B260012D990055F05C;
// B83.Image.BMP.BMPLoader
struct BMPLoader_t8C88A751EA549C5D60C3E41F58F456A97D8B5C83;
// UnityEngine.EventSystems.BaseEventData
struct BaseEventData_tE03A848325C0AE8E76C6CA15FD86395EBF83364F;
// UnityEngine.EventSystems.BaseInputModule
struct BaseInputModule_tF3B7C22AF1419B2AC9ECE6589357DC1B88ED96B1;
// System.IO.BinaryReader
struct BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158;
// UnityEngine.UI.Button
struct Button_t6786514A57F7AFDEE5431112FEA0CAB24F5AE098;
// UnityEngine.Canvas
struct Canvas_t2DB4CEFDFF732884866C83F11ABF75F5AE8FFB26;
// UnityEngine.CanvasRenderer
struct CanvasRenderer_tAB9A55A976C4E3B2B37D0CE5616E5685A8B43860;
// UnityEngine.Component
struct Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3;
// UnityEngine.Coroutine
struct Coroutine_t85EA685566A254C23F3FD77AB5BDFFFF8799596B;
// System.Text.Decoder
struct Decoder_tE16E789E38B25DD304004FC630EA8B21000ECBBC;
// System.Delegate
struct Delegate_t;
// System.DelegateData
struct DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E;
// UnityEngine.Event
struct Event_tEBC6F24B56CE22B9C9AD1AC6C24A6B83BC3860CB;
// UnityEngine.EventSystems.EventSystem
struct EventSystem_t61C51380B105BE9D2C39C4F15B7E655659957707;
// System.Exception
struct Exception_t;
// System.IO.FileStream
struct FileStream_t07C7222EE10B75F352B89B76E60820160FF10AD8;
// UnityEngine.GameObject
struct GameObject_t76FEDD663AB33C991A9C9A23129337651094216F;
// UnityEngine.UI.Graphic
struct Graphic_tCBFCA4585A19E2B75465AECFEAC43F4016BF7931;
// System.IAsyncResult
struct IAsyncResult_t7B9B5A0ECB35DCEC31B8A8122C37D687369253B5;
// System.Collections.IDictionary
struct IDictionary_t6D03155AF1FA9083817AA5B6AD7DEEACC26AB220;
// UnityEngine.EventSystems.IScrollHandler
struct IScrollHandler_t762CB73017D561E11CF6759ED9FD8C9F24B3D13F;
// SFB.IStandaloneFileBrowser
struct IStandaloneFileBrowser_t702D6FF622C15DC43255001FD380A5D424F308B2;
// TMPro.ITextPreprocessor
struct ITextPreprocessor_tDBB49C8B68D7B80E8D233B9D9666C43981EFAAB9;
// UnityEngine.UI.Image
struct Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E;
// Dummiesman.ImageLoader
struct ImageLoader_t8A370851A05DC8FBFA9EF3A8348BC2D76445BD82;
// Dummiesman.ImageLoaderHelper
struct ImageLoaderHelper_t8603BF10D0193AFD974D45CB504409448995359B;
// UnityEngine.Events.InvokableCallList
struct InvokableCallList_t309E1C8C7CE885A0D2F98C84CEA77A8935688382;
// Keyboard.Key
struct Key_tB9DA6A9816AEA58ACE1AE6EA33755EAEEBAC8970;
// Keyboard.KeyChannel
struct KeyChannel_t928FC4C0F40F35E44A1B18D92A9B172B2B760A8A;
// Keyboard.KeyboardManager
struct KeyboardManager_t41DD8382AE61564F08C9856BE00640CCB87720FB;
// UnityEngine.UI.LayoutElement
struct LayoutElement_tB1F24CC11AF4AA87015C8D8EE06D22349C5BF40A;
// UnityEngine.UI.LayoutGroup
struct LayoutGroup_t32417833C700E77EDFA7C20034DAFD26604E05CE;
// Keyboard.LetterKey
struct LetterKey_tE8293A64AC9C3DB2D3C25A5F73BA0F931E763D49;
// UnityEngine.Material
struct Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3;
// System.IO.MemoryStream
struct MemoryStream_tAAED1B42172E3390584E4194308AB878E786AAC2;
// UnityEngine.Mesh
struct Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4;
// System.Reflection.MethodInfo
struct MethodInfo_t;
// UnityEngine.MonoBehaviour
struct MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71;
// UnityEngine.Object
struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C;
// UnityEngine.Events.PersistentCallGroup
struct PersistentCallGroup_tB826EDF15DC80F71BCBCD8E410FD959A04C33F25;
// UnityEngine.UI.RectMask2D
struct RectMask2D_tACF92BE999C791A665BD1ADEABF5BCEB82846670;
// UnityEngine.RectTransform
struct RectTransform_t6C5DA5E41A89E0F488B001E45E58963480E543A5;
// Microsoft.Win32.SafeHandles.SafeFileHandle
struct SafeFileHandle_t033FA6AAAC65F4BB25F4CBA9A242A58C95CD406E;
// System.Runtime.Serialization.SafeSerializationManager
struct SafeSerializationManager_tCBB85B95DFD1634237140CD892E82D06ECB3F5E6;
// UnityEngine.ScriptableObject
struct ScriptableObject_tB3BFDB921A1B1795B38A5417D3B97A89A140436A;
// UnityEngine.UI.Scrollbar
struct Scrollbar_t7CDC9B956698D9385A11E4C12964CD51477072C3;
// UnityEngine.UI.Selectable
struct Selectable_t3251808068A17B8E92FB33590A4C2FA66D456712;
// System.Threading.SemaphoreSlim
struct SemaphoreSlim_t0D5CB5685D9BFA5BF95CEC6E7395490F933E8DB2;
// UnityEngine.Sprite
struct Sprite_tAFF74BC83CD68037494CB0B4F28CBDF8971CAB99;
// SFB.StandaloneFileBrowser
struct StandaloneFileBrowser_t787EC519E2F250D5F984F7C4E41441B46C779AF6;
// System.IO.Stream
struct Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE;
// System.String
struct String_t;
// Dummiesman.TGALoader
struct TGALoader_tBF4AA5DFA40A991239260EF4CD506E8F5F59B1E2;
// TMPro.TMP_Character
struct TMP_Character_t7D37A55EF1A9FF6D0BFE6D50E86A00F80E7FAF35;
// TMPro.TMP_ColorGradient
struct TMP_ColorGradient_t17B51752B4E9499A1FF7D875DCEC1D15A0F4AEBB;
// TMPro.TMP_FontAsset
struct TMP_FontAsset_t923BF2F78D7C5AC36376E168A1193B7CB4855160;
// TMPro.TMP_InputField
struct TMP_InputField_t3488E0EE8C3DF56C6A328EC95D1BEEA2DF4A7D5F;
// TMPro.TMP_InputValidator
struct TMP_InputValidator_t3429AF61284AE19180C3FB81C0C7D2F90165EA98;
// TMPro.TMP_ScrollbarEventHandler
struct TMP_ScrollbarEventHandler_t84C389ED6800977DAEA8C025E18C9F3321888F4D;
// TMPro.TMP_SpriteAnimator
struct TMP_SpriteAnimator_t2E0F016A61CA343E3222FF51E7CF0E53F9F256E4;
// TMPro.TMP_SpriteAsset
struct TMP_SpriteAsset_t81F779E6F705CE190DC0D1F93A954CB8B1774B39;
// TMPro.TMP_Style
struct TMP_Style_tA9E5B1B35EBFE24EF980CEA03251B638282E120C;
// TMPro.TMP_StyleSheet
struct TMP_StyleSheet_t70C71699F5CB2D855C361DBB78A44C901236C859;
// TMPro.TMP_Text
struct TMP_Text_tE8D677872D43AD4B2AAF0D6101692A17D0B251A9;
// TMPro.TMP_TextElement
struct TMP_TextElement_t262A55214F712D4274485ABE5676E5254B84D0A5;
// TMPro.TMP_TextInfo
struct TMP_TextInfo_t09A8E906329422C3F0C059876801DD695B8D524D;
// TMPro.TextMeshProUGUI
struct TextMeshProUGUI_t101091AF4B578BB534C92E9D1EEAF0611636D957;
// UnityEngine.Texture
struct Texture_t791CBB51219779964E0E8A2ED7C1AA5F92A4A700;
// UnityEngine.Texture2D
struct Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4;
// UnityEngine.TouchScreenKeyboard
struct TouchScreenKeyboard_tE87B78A3DAED69816B44C99270A734682E093E7A;
// UnityEngine.Transform
struct Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1;
// UnityEngine.Events.UnityAction
struct UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7;
// UnityEngine.Events.UnityEvent
struct UnityEvent_tDC2C3548799DBC91D1E3F3DE60083A66F4751977;
// UnityEngine.UI.VertexHelper
struct VertexHelper_tB905FCB02AE67CBEE5F265FE37A5938FC5D136FE;
// System.Void
struct Void_t4861ACF8F4594C3437BB48B6E56783494B843915;
// UnityEngine.WaitForSecondsRealtime
struct WaitForSecondsRealtime_tA8CE0AAB4B0C872B843E7973637037D17682BA01;
// UnityEngine.UI.Button/ButtonClickedEvent
struct ButtonClickedEvent_t8EA72E90B3BD1392FB3B3EF167D5121C23569E4C;
// UnityEngine.UI.MaskableGraphic/CullStateChangedEvent
struct CullStateChangedEvent_t6073CD0D951EC1256BF74B8F9107D68FC89B99B8;
// System.IO.Stream/ReadWriteTask
struct ReadWriteTask_t0821BF49EE38596C7734E86E1A6A39D769BE2C05;
// TMPro.TMP_InputField/OnChangeEvent
struct OnChangeEvent_tDBB13012ABF81899E4DFDD82258EB7E9BB7A9F1D;
// TMPro.TMP_InputField/OnValidateInput
struct OnValidateInput_t88ECDC5C12A807AF2A5761369563B0FAA6A25530;
// TMPro.TMP_InputField/SelectionEvent
struct SelectionEvent_t8FC75B869F70C9F0BF13390AD0237AD310511119;
// TMPro.TMP_InputField/SubmitEvent
struct SubmitEvent_tF7E2843B6A79D94B8EEEA259707F77BD1773B500;
// TMPro.TMP_InputField/TextSelectionEvent
struct TextSelectionEvent_t6C496DAA6DAF01754C27C58A94A5FBA562BA9401;
// TMPro.TMP_InputField/TouchScreenKeyboardEvent
struct TouchScreenKeyboardEvent_tB9BEBEF5D6F2B52547EF3861FF437AC25BC06AF1;

IL2CPP_EXTERN_C RuntimeClass* BMPLoader_t8C88A751EA549C5D60C3E41F58F456A97D8B5C83_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* BitConverter_t6E99605185963BC12B3D369E13F2B88997E64A27_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Byte_t94D9231AC217BE4D2E004C4CD32DF6D099EA41A3_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Exception_t_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* ExtensionFilterU5BU5D_t724AA1EDDC78E2F3CC3EB4C808F408EDF52EDCFD_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IStandaloneFileBrowser_t702D6FF622C15DC43255001FD380A5D424F308B2_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* MemoryStream_tAAED1B42172E3390584E4194308AB878E786AAC2_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Path_t8A38A801D0219E8209C1B1D90D82D4D755D998BC_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* StandaloneFileBrowser_t787EC519E2F250D5F984F7C4E41441B46C779AF6_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* UnityAction_1_t690494F0E492A2098660E28B8EB7D71B2C69BE1B_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* UnityAction_1_t8EC357AF4FBD2A0C4A575C4BBD0B3A81029E43A9_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* UnityAction_4_t05D51CE8BEA0460D330923E761D421EF194ED9B1_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C String_t* _stringLiteral0FFABE86E9532C726C3E9C7D10AFE388437A380D;
IL2CPP_EXTERN_C String_t* _stringLiteral1A3E4D14FCCE4BCFFF56E01EE25543AD3912FB19;
IL2CPP_EXTERN_C String_t* _stringLiteral2386E77CF610F786B06A91AF2C1B3FD2282D2745;
IL2CPP_EXTERN_C String_t* _stringLiteral23DF9991B71463C240582D176E347E7E47AEFF5A;
IL2CPP_EXTERN_C String_t* _stringLiteral267226911D4A958D79875B1057280198F25BE5F6;
IL2CPP_EXTERN_C String_t* _stringLiteral3201B86FACEA09A6EC2396E7556112CD64565211;
IL2CPP_EXTERN_C String_t* _stringLiteral4B9B40AAD718882F5C0B95FE844E4AA92BD49C42;
IL2CPP_EXTERN_C String_t* _stringLiteral906902D085F4FCFFBE1AC027823E498FE4DA23F1;
IL2CPP_EXTERN_C String_t* _stringLiteral911FC00FE8A864A9D1B8F87A75E4EE5041ACF43B;
IL2CPP_EXTERN_C String_t* _stringLiteral985B72B30ECE05DD4EF5FE142CEE0FB8BF53A98C;
IL2CPP_EXTERN_C String_t* _stringLiteral9FB5B88DDC4C14C62E4014842DEC88E8353401A0;
IL2CPP_EXTERN_C String_t* _stringLiteralA15C898F015A9B0BC3268E8883CD03008A56DE26;
IL2CPP_EXTERN_C String_t* _stringLiteralA3C7F6BB1B46455CBE10794712ECEC4C0181B2F3;
IL2CPP_EXTERN_C String_t* _stringLiteralB93D5DFE334D74396F45A6431764B0B46F089032;
IL2CPP_EXTERN_C String_t* _stringLiteralBEFAFB5DB9B504BEEF8A79E3E990D713103F15A0;
IL2CPP_EXTERN_C String_t* _stringLiteralC00413A65EA4BBDF5F981E7DC7F68313AA28D95F;
IL2CPP_EXTERN_C String_t* _stringLiteralC04D29956674D158EF253F0C3DB19BB0C4033629;
IL2CPP_EXTERN_C String_t* _stringLiteralCCC77F6BEC01F19B25AEAE1DA587DC5A6486B284;
IL2CPP_EXTERN_C String_t* _stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709;
IL2CPP_EXTERN_C const RuntimeMethod* Component_GetComponentInChildren_TisTextMeshProUGUI_t101091AF4B578BB534C92E9D1EEAF0611636D957_m60A1B193FDBBFB3719065622DB5E0BB21CA4ABDC_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Component_GetComponent_TisButton_t6786514A57F7AFDEE5431112FEA0CAB24F5AE098_mFF8BA4CA5D7158D1D6249559A3289E7A6DF0A2BB_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* GameObject_GetComponent_TisTMP_InputField_t3488E0EE8C3DF56C6A328EC95D1BEEA2DF4A7D5F_m6CA031C91E5D203C24D3315721B6E3910B9C8729_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* ImageLoader_LoadTexture_m05091EED446921B94BDFBA4EEDC14656D11B2D10_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Key_ChangeKeyColors_mF848C4E6D96720A9311F65E6847AEC4E06F92038_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Key_ChangeKeyState_mD1A5BC6C4AAF356404BEA30434ED235412CF1A66_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* KeyboardManager_KeyPress_m4D6965693DBCED4B36CE839C7A9C702EA37BDBF0_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* KeyboardManager_OnDeletePress_mF2C78138A5C6B941C45092D2705C28944C42AE94_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* KeyboardManager_OnShiftPress_mF04B1244E8EB01E629B736A32297C46C2457A9E9_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* KeyboardManager_OnSpacePress_m38F1CC2F29F04AD3B6DEC34AB6377E8B26086124_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* KeyboardManager_OnSwitchPress_m593AE16BABC05F9A43E1A26CDB30CD1062817479_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* KeyboardManager_SwitchBetweenNumbersAndSpecialCharacters_m3004A040F523A15EBAB631216BBD0E4D6BFA0AF7_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* TGALoader_Load_mFFD983DFCBF01C4B0C51AEC8829191B59E63AD20_RuntimeMethod_var;
struct Delegate_t_marshaled_com;
struct Delegate_t_marshaled_pinvoke;
struct Exception_t_marshaled_com;
struct Exception_t_marshaled_pinvoke;

struct ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031;
struct ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389;
struct Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259;
struct ExtensionFilterU5BU5D_t724AA1EDDC78E2F3CC3EB4C808F408EDF52EDCFD;
struct StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248;

IL2CPP_EXTERN_C_BEGIN
IL2CPP_EXTERN_C_END

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// B83.Image.BMP.BMPLoader
struct BMPLoader_t8C88A751EA549C5D60C3E41F58F456A97D8B5C83  : public RuntimeObject
{
	// System.Boolean B83.Image.BMP.BMPLoader::ReadPaletteAlpha
	bool ___ReadPaletteAlpha_1;
	// System.Boolean B83.Image.BMP.BMPLoader::ForceAlphaReadWhenPossible
	bool ___ForceAlphaReadWhenPossible_2;
};

// System.IO.BinaryReader
struct BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158  : public RuntimeObject
{
	// System.IO.Stream System.IO.BinaryReader::m_stream
	Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* ___m_stream_0;
	// System.Byte[] System.IO.BinaryReader::m_buffer
	ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___m_buffer_1;
	// System.Text.Decoder System.IO.BinaryReader::m_decoder
	Decoder_tE16E789E38B25DD304004FC630EA8B21000ECBBC* ___m_decoder_2;
	// System.Byte[] System.IO.BinaryReader::m_charBytes
	ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___m_charBytes_3;
	// System.Char[] System.IO.BinaryReader::m_singleChar
	CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB* ___m_singleChar_4;
	// System.Char[] System.IO.BinaryReader::m_charBuffer
	CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB* ___m_charBuffer_5;
	// System.Int32 System.IO.BinaryReader::m_maxCharsSize
	int32_t ___m_maxCharsSize_6;
	// System.Boolean System.IO.BinaryReader::m_2BytesPerChar
	bool ___m_2BytesPerChar_7;
	// System.Boolean System.IO.BinaryReader::m_isMemoryStream
	bool ___m_isMemoryStream_8;
	// System.Boolean System.IO.BinaryReader::m_leaveOpen
	bool ___m_leaveOpen_9;
};

// Dummiesman.Extensions.ColorExtensions
struct ColorExtensions_t11CBE6A7B40152B1727BFC9693F700A13BC26A57  : public RuntimeObject
{
};

// Dummiesman.ImageLoader
struct ImageLoader_t8A370851A05DC8FBFA9EF3A8348BC2D76445BD82  : public RuntimeObject
{
};

// Dummiesman.ImageLoaderHelper
struct ImageLoaderHelper_t8603BF10D0193AFD974D45CB504409448995359B  : public RuntimeObject
{
};

// Dummiesman.ImageUtils
struct ImageUtils_t181A75EDA6EC524F53330496B4E116B38CE65744  : public RuntimeObject
{
};

// System.MarshalByRefObject
struct MarshalByRefObject_t8C2F4C5854177FD60439EB1FCCFC1B3CFAFE8DCE  : public RuntimeObject
{
	// System.Object System.MarshalByRefObject::_identity
	RuntimeObject* ____identity_0;
};
// Native definition for P/Invoke marshalling of System.MarshalByRefObject
struct MarshalByRefObject_t8C2F4C5854177FD60439EB1FCCFC1B3CFAFE8DCE_marshaled_pinvoke
{
	Il2CppIUnknown* ____identity_0;
};
// Native definition for COM marshalling of System.MarshalByRefObject
struct MarshalByRefObject_t8C2F4C5854177FD60439EB1FCCFC1B3CFAFE8DCE_marshaled_com
{
	Il2CppIUnknown* ____identity_0;
};

// SFB.StandaloneFileBrowser
struct StandaloneFileBrowser_t787EC519E2F250D5F984F7C4E41441B46C779AF6  : public RuntimeObject
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

// Dummiesman.TGALoader
struct TGALoader_tBF4AA5DFA40A991239260EF4CD506E8F5F59B1E2  : public RuntimeObject
{
};

// UnityEngine.Events.UnityEventBase
struct UnityEventBase_t4968A4C72559F35C0923E4BD9C042C3A842E1DB8  : public RuntimeObject
{
	// UnityEngine.Events.InvokableCallList UnityEngine.Events.UnityEventBase::m_Calls
	InvokableCallList_t309E1C8C7CE885A0D2F98C84CEA77A8935688382* ___m_Calls_0;
	// UnityEngine.Events.PersistentCallGroup UnityEngine.Events.UnityEventBase::m_PersistentCalls
	PersistentCallGroup_tB826EDF15DC80F71BCBCD8E410FD959A04C33F25* ___m_PersistentCalls_1;
	// System.Boolean UnityEngine.Events.UnityEventBase::m_CallsDirty
	bool ___m_CallsDirty_2;
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

// TMPro.TMP_TextProcessingStack`1<TMPro.FontWeight>
struct TMP_TextProcessingStack_1_tA5C8CED87DD9E73F6359E23B334FFB5B6F813FD4 
{
	// T[] TMPro.TMP_TextProcessingStack`1::itemStack
	FontWeightU5BU5D_t2A406B5BAB0DD0F06E7F1773DB062E4AF98067BA* ___itemStack_0;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::index
	int32_t ___index_1;
	// T TMPro.TMP_TextProcessingStack`1::m_DefaultItem
	int32_t ___m_DefaultItem_2;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::m_Capacity
	int32_t ___m_Capacity_3;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::m_RolloverSize
	int32_t ___m_RolloverSize_4;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::m_Count
	int32_t ___m_Count_5;
};

// TMPro.TMP_TextProcessingStack`1<TMPro.HorizontalAlignmentOptions>
struct TMP_TextProcessingStack_1_t243EA1B5D7FD2295D6533B953F0BBE8F52EFB8A0 
{
	// T[] TMPro.TMP_TextProcessingStack`1::itemStack
	HorizontalAlignmentOptionsU5BU5D_t4D185662282BFB910D8B9A8199E91578E9422658* ___itemStack_0;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::index
	int32_t ___index_1;
	// T TMPro.TMP_TextProcessingStack`1::m_DefaultItem
	int32_t ___m_DefaultItem_2;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::m_Capacity
	int32_t ___m_Capacity_3;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::m_RolloverSize
	int32_t ___m_RolloverSize_4;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::m_Count
	int32_t ___m_Count_5;
};

// TMPro.TMP_TextProcessingStack`1<System.Int32>
struct TMP_TextProcessingStack_1_tFBA719426D68CE1F2B5849D97AF5E5D65846290C 
{
	// T[] TMPro.TMP_TextProcessingStack`1::itemStack
	Int32U5BU5D_t19C97395396A72ECAF310612F0760F165060314C* ___itemStack_0;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::index
	int32_t ___index_1;
	// T TMPro.TMP_TextProcessingStack`1::m_DefaultItem
	int32_t ___m_DefaultItem_2;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::m_Capacity
	int32_t ___m_Capacity_3;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::m_RolloverSize
	int32_t ___m_RolloverSize_4;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::m_Count
	int32_t ___m_Count_5;
};

// TMPro.TMP_TextProcessingStack`1<System.Single>
struct TMP_TextProcessingStack_1_t138EC06BE7F101AA0A3C8D2DC951E55AACE085E9 
{
	// T[] TMPro.TMP_TextProcessingStack`1::itemStack
	SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C* ___itemStack_0;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::index
	int32_t ___index_1;
	// T TMPro.TMP_TextProcessingStack`1::m_DefaultItem
	float ___m_DefaultItem_2;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::m_Capacity
	int32_t ___m_Capacity_3;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::m_RolloverSize
	int32_t ___m_RolloverSize_4;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::m_Count
	int32_t ___m_Count_5;
};

// TMPro.TMP_TextProcessingStack`1<TMPro.TMP_ColorGradient>
struct TMP_TextProcessingStack_1_tC8FAEB17246D3B171EFD11165A5761AE39B40D0C 
{
	// T[] TMPro.TMP_TextProcessingStack`1::itemStack
	TMP_ColorGradientU5BU5D_t2F65E8C42F268DFF33BB1392D94BCF5B5087308A* ___itemStack_0;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::index
	int32_t ___index_1;
	// T TMPro.TMP_TextProcessingStack`1::m_DefaultItem
	TMP_ColorGradient_t17B51752B4E9499A1FF7D875DCEC1D15A0F4AEBB* ___m_DefaultItem_2;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::m_Capacity
	int32_t ___m_Capacity_3;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::m_RolloverSize
	int32_t ___m_RolloverSize_4;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::m_Count
	int32_t ___m_Count_5;
};

// B83.Image.BMP.BMPFileHeader
struct BMPFileHeader_t8BB1B4DE759798D79066DF23BBBDE48E1051D50C 
{
	// System.UInt16 B83.Image.BMP.BMPFileHeader::magic
	uint16_t ___magic_0;
	// System.UInt32 B83.Image.BMP.BMPFileHeader::filesize
	uint32_t ___filesize_1;
	// System.UInt32 B83.Image.BMP.BMPFileHeader::reserved
	uint32_t ___reserved_2;
	// System.UInt32 B83.Image.BMP.BMPFileHeader::offset
	uint32_t ___offset_3;
};

// B83.Image.BMP.BitmapInfoHeader
struct BitmapInfoHeader_tFB63C5954E9795BECDA9F843F451C426D1982C4E 
{
	// System.UInt32 B83.Image.BMP.BitmapInfoHeader::size
	uint32_t ___size_0;
	// System.Int32 B83.Image.BMP.BitmapInfoHeader::width
	int32_t ___width_1;
	// System.Int32 B83.Image.BMP.BitmapInfoHeader::height
	int32_t ___height_2;
	// System.UInt16 B83.Image.BMP.BitmapInfoHeader::nColorPlanes
	uint16_t ___nColorPlanes_3;
	// System.UInt16 B83.Image.BMP.BitmapInfoHeader::nBitsPerPixel
	uint16_t ___nBitsPerPixel_4;
	// B83.Image.BMP.BMPComressionMode B83.Image.BMP.BitmapInfoHeader::compressionMethod
	int32_t ___compressionMethod_5;
	// System.UInt32 B83.Image.BMP.BitmapInfoHeader::rawImageSize
	uint32_t ___rawImageSize_6;
	// System.Int32 B83.Image.BMP.BitmapInfoHeader::xPPM
	int32_t ___xPPM_7;
	// System.Int32 B83.Image.BMP.BitmapInfoHeader::yPPM
	int32_t ___yPPM_8;
	// System.UInt32 B83.Image.BMP.BitmapInfoHeader::nPaletteColors
	uint32_t ___nPaletteColors_9;
	// System.UInt32 B83.Image.BMP.BitmapInfoHeader::nImportantColors
	uint32_t ___nImportantColors_10;
};

// System.Boolean
struct Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22 
{
	// System.Boolean System.Boolean::m_value
	bool ___m_value_0;
};

// System.Byte
struct Byte_t94D9231AC217BE4D2E004C4CD32DF6D099EA41A3 
{
	// System.Byte System.Byte::m_value
	uint8_t ___m_value_0;
};

// System.Char
struct Char_t521A6F19B456D956AF452D926C32709DC03D6B17 
{
	// System.Char System.Char::m_value
	Il2CppChar ___m_value_0;
};

// UnityEngine.Color
struct Color_tD001788D726C3A7F1379BEED0260B9591F440C1F 
{
	// System.Single UnityEngine.Color::r
	float ___r_0;
	// System.Single UnityEngine.Color::g
	float ___g_1;
	// System.Single UnityEngine.Color::b
	float ___b_2;
	// System.Single UnityEngine.Color::a
	float ___a_3;
};

// UnityEngine.Color32
struct Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B 
{
	union
	{
		#pragma pack(push, tp, 1)
		struct
		{
			// System.Int32 UnityEngine.Color32::rgba
			int32_t ___rgba_0;
		};
		#pragma pack(pop, tp)
		struct
		{
			int32_t ___rgba_0_forAlignmentOnly;
		};
		#pragma pack(push, tp, 1)
		struct
		{
			// System.Byte UnityEngine.Color32::r
			uint8_t ___r_1;
		};
		#pragma pack(pop, tp)
		struct
		{
			uint8_t ___r_1_forAlignmentOnly;
		};
		#pragma pack(push, tp, 1)
		struct
		{
			char ___g_2_OffsetPadding[1];
			// System.Byte UnityEngine.Color32::g
			uint8_t ___g_2;
		};
		#pragma pack(pop, tp)
		struct
		{
			char ___g_2_OffsetPadding_forAlignmentOnly[1];
			uint8_t ___g_2_forAlignmentOnly;
		};
		#pragma pack(push, tp, 1)
		struct
		{
			char ___b_3_OffsetPadding[2];
			// System.Byte UnityEngine.Color32::b
			uint8_t ___b_3;
		};
		#pragma pack(pop, tp)
		struct
		{
			char ___b_3_OffsetPadding_forAlignmentOnly[2];
			uint8_t ___b_3_forAlignmentOnly;
		};
		#pragma pack(push, tp, 1)
		struct
		{
			char ___a_4_OffsetPadding[3];
			// System.Byte UnityEngine.Color32::a
			uint8_t ___a_4;
		};
		#pragma pack(pop, tp)
		struct
		{
			char ___a_4_OffsetPadding_forAlignmentOnly[3];
			uint8_t ___a_4_forAlignmentOnly;
		};
	};
};

// SFB.ExtensionFilter
struct ExtensionFilter_t8E3B1120DA244D6F742247E3EF9A152C3FAE3A57 
{
	// System.String SFB.ExtensionFilter::Name
	String_t* ___Name_0;
	// System.String[] SFB.ExtensionFilter::Extensions
	StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* ___Extensions_1;
};
// Native definition for P/Invoke marshalling of SFB.ExtensionFilter
struct ExtensionFilter_t8E3B1120DA244D6F742247E3EF9A152C3FAE3A57_marshaled_pinvoke
{
	char* ___Name_0;
	char** ___Extensions_1;
};
// Native definition for COM marshalling of SFB.ExtensionFilter
struct ExtensionFilter_t8E3B1120DA244D6F742247E3EF9A152C3FAE3A57_marshaled_com
{
	Il2CppChar* ___Name_0;
	Il2CppChar** ___Extensions_1;
};

// System.Int16
struct Int16_tB8EF286A9C33492FA6E6D6E67320BE93E794A175 
{
	// System.Int16 System.Int16::m_value
	int16_t ___m_value_0;
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

// TMPro.MaterialReference
struct MaterialReference_tFD98FFFBBDF168028E637446C6676507186F4D0B 
{
	// System.Int32 TMPro.MaterialReference::index
	int32_t ___index_0;
	// TMPro.TMP_FontAsset TMPro.MaterialReference::fontAsset
	TMP_FontAsset_t923BF2F78D7C5AC36376E168A1193B7CB4855160* ___fontAsset_1;
	// TMPro.TMP_SpriteAsset TMPro.MaterialReference::spriteAsset
	TMP_SpriteAsset_t81F779E6F705CE190DC0D1F93A954CB8B1774B39* ___spriteAsset_2;
	// UnityEngine.Material TMPro.MaterialReference::material
	Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* ___material_3;
	// System.Boolean TMPro.MaterialReference::isDefaultMaterial
	bool ___isDefaultMaterial_4;
	// System.Boolean TMPro.MaterialReference::isFallbackMaterial
	bool ___isFallbackMaterial_5;
	// UnityEngine.Material TMPro.MaterialReference::fallbackMaterial
	Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* ___fallbackMaterial_6;
	// System.Single TMPro.MaterialReference::padding
	float ___padding_7;
	// System.Int32 TMPro.MaterialReference::referenceCount
	int32_t ___referenceCount_8;
};
// Native definition for P/Invoke marshalling of TMPro.MaterialReference
struct MaterialReference_tFD98FFFBBDF168028E637446C6676507186F4D0B_marshaled_pinvoke
{
	int32_t ___index_0;
	TMP_FontAsset_t923BF2F78D7C5AC36376E168A1193B7CB4855160* ___fontAsset_1;
	TMP_SpriteAsset_t81F779E6F705CE190DC0D1F93A954CB8B1774B39* ___spriteAsset_2;
	Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* ___material_3;
	int32_t ___isDefaultMaterial_4;
	int32_t ___isFallbackMaterial_5;
	Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* ___fallbackMaterial_6;
	float ___padding_7;
	int32_t ___referenceCount_8;
};
// Native definition for COM marshalling of TMPro.MaterialReference
struct MaterialReference_tFD98FFFBBDF168028E637446C6676507186F4D0B_marshaled_com
{
	int32_t ___index_0;
	TMP_FontAsset_t923BF2F78D7C5AC36376E168A1193B7CB4855160* ___fontAsset_1;
	TMP_SpriteAsset_t81F779E6F705CE190DC0D1F93A954CB8B1774B39* ___spriteAsset_2;
	Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* ___material_3;
	int32_t ___isDefaultMaterial_4;
	int32_t ___isFallbackMaterial_5;
	Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* ___fallbackMaterial_6;
	float ___padding_7;
	int32_t ___referenceCount_8;
};

// UnityEngine.Matrix4x4
struct Matrix4x4_tDB70CF134A14BA38190C59AA700BCE10E2AED3E6 
{
	// System.Single UnityEngine.Matrix4x4::m00
	float ___m00_0;
	// System.Single UnityEngine.Matrix4x4::m10
	float ___m10_1;
	// System.Single UnityEngine.Matrix4x4::m20
	float ___m20_2;
	// System.Single UnityEngine.Matrix4x4::m30
	float ___m30_3;
	// System.Single UnityEngine.Matrix4x4::m01
	float ___m01_4;
	// System.Single UnityEngine.Matrix4x4::m11
	float ___m11_5;
	// System.Single UnityEngine.Matrix4x4::m21
	float ___m21_6;
	// System.Single UnityEngine.Matrix4x4::m31
	float ___m31_7;
	// System.Single UnityEngine.Matrix4x4::m02
	float ___m02_8;
	// System.Single UnityEngine.Matrix4x4::m12
	float ___m12_9;
	// System.Single UnityEngine.Matrix4x4::m22
	float ___m22_10;
	// System.Single UnityEngine.Matrix4x4::m32
	float ___m32_11;
	// System.Single UnityEngine.Matrix4x4::m03
	float ___m03_12;
	// System.Single UnityEngine.Matrix4x4::m13
	float ___m13_13;
	// System.Single UnityEngine.Matrix4x4::m23
	float ___m23_14;
	// System.Single UnityEngine.Matrix4x4::m33
	float ___m33_15;
};

// UnityEngine.UI.Navigation
struct Navigation_t4D2E201D65749CF4E104E8AC1232CF1D6F14795C 
{
	// UnityEngine.UI.Navigation/Mode UnityEngine.UI.Navigation::m_Mode
	int32_t ___m_Mode_0;
	// System.Boolean UnityEngine.UI.Navigation::m_WrapAround
	bool ___m_WrapAround_1;
	// UnityEngine.UI.Selectable UnityEngine.UI.Navigation::m_SelectOnUp
	Selectable_t3251808068A17B8E92FB33590A4C2FA66D456712* ___m_SelectOnUp_2;
	// UnityEngine.UI.Selectable UnityEngine.UI.Navigation::m_SelectOnDown
	Selectable_t3251808068A17B8E92FB33590A4C2FA66D456712* ___m_SelectOnDown_3;
	// UnityEngine.UI.Selectable UnityEngine.UI.Navigation::m_SelectOnLeft
	Selectable_t3251808068A17B8E92FB33590A4C2FA66D456712* ___m_SelectOnLeft_4;
	// UnityEngine.UI.Selectable UnityEngine.UI.Navigation::m_SelectOnRight
	Selectable_t3251808068A17B8E92FB33590A4C2FA66D456712* ___m_SelectOnRight_5;
};
// Native definition for P/Invoke marshalling of UnityEngine.UI.Navigation
struct Navigation_t4D2E201D65749CF4E104E8AC1232CF1D6F14795C_marshaled_pinvoke
{
	int32_t ___m_Mode_0;
	int32_t ___m_WrapAround_1;
	Selectable_t3251808068A17B8E92FB33590A4C2FA66D456712* ___m_SelectOnUp_2;
	Selectable_t3251808068A17B8E92FB33590A4C2FA66D456712* ___m_SelectOnDown_3;
	Selectable_t3251808068A17B8E92FB33590A4C2FA66D456712* ___m_SelectOnLeft_4;
	Selectable_t3251808068A17B8E92FB33590A4C2FA66D456712* ___m_SelectOnRight_5;
};
// Native definition for COM marshalling of UnityEngine.UI.Navigation
struct Navigation_t4D2E201D65749CF4E104E8AC1232CF1D6F14795C_marshaled_com
{
	int32_t ___m_Mode_0;
	int32_t ___m_WrapAround_1;
	Selectable_t3251808068A17B8E92FB33590A4C2FA66D456712* ___m_SelectOnUp_2;
	Selectable_t3251808068A17B8E92FB33590A4C2FA66D456712* ___m_SelectOnDown_3;
	Selectable_t3251808068A17B8E92FB33590A4C2FA66D456712* ___m_SelectOnLeft_4;
	Selectable_t3251808068A17B8E92FB33590A4C2FA66D456712* ___m_SelectOnRight_5;
};

// UnityEngine.Rect
struct Rect_tA04E0F8A1830E767F40FB27ECD8D309303571F0D 
{
	// System.Single UnityEngine.Rect::m_XMin
	float ___m_XMin_0;
	// System.Single UnityEngine.Rect::m_YMin
	float ___m_YMin_1;
	// System.Single UnityEngine.Rect::m_Width
	float ___m_Width_2;
	// System.Single UnityEngine.Rect::m_Height
	float ___m_Height_3;
};

// System.Single
struct Single_t4530F2FF86FCB0DC29F35385CA1BD21BE294761C 
{
	// System.Single System.Single::m_value
	float ___m_value_0;
};

// UnityEngine.UI.SpriteState
struct SpriteState_tC8199570BE6337FB5C49347C97892B4222E5AACD 
{
	// UnityEngine.Sprite UnityEngine.UI.SpriteState::m_HighlightedSprite
	Sprite_tAFF74BC83CD68037494CB0B4F28CBDF8971CAB99* ___m_HighlightedSprite_0;
	// UnityEngine.Sprite UnityEngine.UI.SpriteState::m_PressedSprite
	Sprite_tAFF74BC83CD68037494CB0B4F28CBDF8971CAB99* ___m_PressedSprite_1;
	// UnityEngine.Sprite UnityEngine.UI.SpriteState::m_SelectedSprite
	Sprite_tAFF74BC83CD68037494CB0B4F28CBDF8971CAB99* ___m_SelectedSprite_2;
	// UnityEngine.Sprite UnityEngine.UI.SpriteState::m_DisabledSprite
	Sprite_tAFF74BC83CD68037494CB0B4F28CBDF8971CAB99* ___m_DisabledSprite_3;
};
// Native definition for P/Invoke marshalling of UnityEngine.UI.SpriteState
struct SpriteState_tC8199570BE6337FB5C49347C97892B4222E5AACD_marshaled_pinvoke
{
	Sprite_tAFF74BC83CD68037494CB0B4F28CBDF8971CAB99* ___m_HighlightedSprite_0;
	Sprite_tAFF74BC83CD68037494CB0B4F28CBDF8971CAB99* ___m_PressedSprite_1;
	Sprite_tAFF74BC83CD68037494CB0B4F28CBDF8971CAB99* ___m_SelectedSprite_2;
	Sprite_tAFF74BC83CD68037494CB0B4F28CBDF8971CAB99* ___m_DisabledSprite_3;
};
// Native definition for COM marshalling of UnityEngine.UI.SpriteState
struct SpriteState_tC8199570BE6337FB5C49347C97892B4222E5AACD_marshaled_com
{
	Sprite_tAFF74BC83CD68037494CB0B4F28CBDF8971CAB99* ___m_HighlightedSprite_0;
	Sprite_tAFF74BC83CD68037494CB0B4F28CBDF8971CAB99* ___m_PressedSprite_1;
	Sprite_tAFF74BC83CD68037494CB0B4F28CBDF8971CAB99* ___m_SelectedSprite_2;
	Sprite_tAFF74BC83CD68037494CB0B4F28CBDF8971CAB99* ___m_DisabledSprite_3;
};

// System.IO.Stream
struct Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE  : public MarshalByRefObject_t8C2F4C5854177FD60439EB1FCCFC1B3CFAFE8DCE
{
	// System.IO.Stream/ReadWriteTask System.IO.Stream::_activeReadWriteTask
	ReadWriteTask_t0821BF49EE38596C7734E86E1A6A39D769BE2C05* ____activeReadWriteTask_2;
	// System.Threading.SemaphoreSlim System.IO.Stream::_asyncActiveSemaphore
	SemaphoreSlim_t0D5CB5685D9BFA5BF95CEC6E7395490F933E8DB2* ____asyncActiveSemaphore_3;
};

// TMPro.TMP_FontStyleStack
struct TMP_FontStyleStack_t52885F172FADBC21346C835B5302167BDA8020DC 
{
	// System.Byte TMPro.TMP_FontStyleStack::bold
	uint8_t ___bold_0;
	// System.Byte TMPro.TMP_FontStyleStack::italic
	uint8_t ___italic_1;
	// System.Byte TMPro.TMP_FontStyleStack::underline
	uint8_t ___underline_2;
	// System.Byte TMPro.TMP_FontStyleStack::strikethrough
	uint8_t ___strikethrough_3;
	// System.Byte TMPro.TMP_FontStyleStack::highlight
	uint8_t ___highlight_4;
	// System.Byte TMPro.TMP_FontStyleStack::superscript
	uint8_t ___superscript_5;
	// System.Byte TMPro.TMP_FontStyleStack::subscript
	uint8_t ___subscript_6;
	// System.Byte TMPro.TMP_FontStyleStack::uppercase
	uint8_t ___uppercase_7;
	// System.Byte TMPro.TMP_FontStyleStack::lowercase
	uint8_t ___lowercase_8;
	// System.Byte TMPro.TMP_FontStyleStack::smallcaps
	uint8_t ___smallcaps_9;
};

// TMPro.TMP_Offset
struct TMP_Offset_t2262BE4E87D9662487777FF8FFE1B17B0E4438C6 
{
	// System.Single TMPro.TMP_Offset::m_Left
	float ___m_Left_0;
	// System.Single TMPro.TMP_Offset::m_Right
	float ___m_Right_1;
	// System.Single TMPro.TMP_Offset::m_Top
	float ___m_Top_2;
	// System.Single TMPro.TMP_Offset::m_Bottom
	float ___m_Bottom_3;
};

// System.UInt16
struct UInt16_tF4C148C876015C212FD72652D0B6ED8CC247A455 
{
	// System.UInt16 System.UInt16::m_value
	uint16_t ___m_value_0;
};

// System.UInt32
struct UInt32_t1833D51FFA667B18A5AA4B8D34DE284F8495D29B 
{
	// System.UInt32 System.UInt32::m_value
	uint32_t ___m_value_0;
};

// UnityEngine.Events.UnityEvent
struct UnityEvent_tDC2C3548799DBC91D1E3F3DE60083A66F4751977  : public UnityEventBase_t4968A4C72559F35C0923E4BD9C042C3A842E1DB8
{
	// System.Object[] UnityEngine.Events.UnityEvent::m_InvokeArray
	ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* ___m_InvokeArray_3;
};

// UnityEngine.Vector2
struct Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 
{
	// System.Single UnityEngine.Vector2::x
	float ___x_0;
	// System.Single UnityEngine.Vector2::y
	float ___y_1;
};

// UnityEngine.Vector4
struct Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 
{
	// System.Single UnityEngine.Vector4::x
	float ___x_1;
	// System.Single UnityEngine.Vector4::y
	float ___y_2;
	// System.Single UnityEngine.Vector4::z
	float ___z_3;
	// System.Single UnityEngine.Vector4::w
	float ___w_4;
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

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=108
struct __StaticArrayInitTypeSizeU3D108_tDB5A737F5FBCFF628DE63E7700119A4EC9A3F2F9 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D108_tDB5A737F5FBCFF628DE63E7700119A4EC9A3F2F9__padding[108];
	};
};

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=12
struct __StaticArrayInitTypeSizeU3D12_t1BDD2193C3F925556BCD5FF35C0AC52DDB0CAB8F 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D12_t1BDD2193C3F925556BCD5FF35C0AC52DDB0CAB8F__padding[12];
	};
};

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=128
struct __StaticArrayInitTypeSizeU3D128_tF4DC60A802E7EAF26084A16B33B2CDCC817796AB 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D128_tF4DC60A802E7EAF26084A16B33B2CDCC817796AB__padding[128];
	};
};

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=36
struct __StaticArrayInitTypeSizeU3D36_tE3135E025C70F21BBD65107243EE57F8AA699792 
{
	union
	{
		struct
		{
			union
			{
			};
		};
		uint8_t __StaticArrayInitTypeSizeU3D36_tE3135E025C70F21BBD65107243EE57F8AA699792__padding[36];
	};
};

// UnityEngine.EventSystems.EventSystem/UIToolkitOverrideConfig
struct UIToolkitOverrideConfig_t4E6B4528E38BCA7DA72C45424634806200A50182 
{
	// UnityEngine.EventSystems.EventSystem UnityEngine.EventSystems.EventSystem/UIToolkitOverrideConfig::activeEventSystem
	EventSystem_t61C51380B105BE9D2C39C4F15B7E655659957707* ___activeEventSystem_0;
	// System.Boolean UnityEngine.EventSystems.EventSystem/UIToolkitOverrideConfig::sendEvents
	bool ___sendEvents_1;
	// System.Boolean UnityEngine.EventSystems.EventSystem/UIToolkitOverrideConfig::createPanelGameObjectsOnStart
	bool ___createPanelGameObjectsOnStart_2;
};
// Native definition for P/Invoke marshalling of UnityEngine.EventSystems.EventSystem/UIToolkitOverrideConfig
struct UIToolkitOverrideConfig_t4E6B4528E38BCA7DA72C45424634806200A50182_marshaled_pinvoke
{
	EventSystem_t61C51380B105BE9D2C39C4F15B7E655659957707* ___activeEventSystem_0;
	int32_t ___sendEvents_1;
	int32_t ___createPanelGameObjectsOnStart_2;
};
// Native definition for COM marshalling of UnityEngine.EventSystems.EventSystem/UIToolkitOverrideConfig
struct UIToolkitOverrideConfig_t4E6B4528E38BCA7DA72C45424634806200A50182_marshaled_com
{
	EventSystem_t61C51380B105BE9D2C39C4F15B7E655659957707* ___activeEventSystem_0;
	int32_t ___sendEvents_1;
	int32_t ___createPanelGameObjectsOnStart_2;
};

// TMPro.TMP_Text/SpecialCharacter
struct SpecialCharacter_t6C1DBE8C490706D1620899BAB7F0B8091AD26777 
{
	// TMPro.TMP_Character TMPro.TMP_Text/SpecialCharacter::character
	TMP_Character_t7D37A55EF1A9FF6D0BFE6D50E86A00F80E7FAF35* ___character_0;
	// TMPro.TMP_FontAsset TMPro.TMP_Text/SpecialCharacter::fontAsset
	TMP_FontAsset_t923BF2F78D7C5AC36376E168A1193B7CB4855160* ___fontAsset_1;
	// UnityEngine.Material TMPro.TMP_Text/SpecialCharacter::material
	Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* ___material_2;
	// System.Int32 TMPro.TMP_Text/SpecialCharacter::materialIndex
	int32_t ___materialIndex_3;
};
// Native definition for P/Invoke marshalling of TMPro.TMP_Text/SpecialCharacter
struct SpecialCharacter_t6C1DBE8C490706D1620899BAB7F0B8091AD26777_marshaled_pinvoke
{
	TMP_Character_t7D37A55EF1A9FF6D0BFE6D50E86A00F80E7FAF35* ___character_0;
	TMP_FontAsset_t923BF2F78D7C5AC36376E168A1193B7CB4855160* ___fontAsset_1;
	Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* ___material_2;
	int32_t ___materialIndex_3;
};
// Native definition for COM marshalling of TMPro.TMP_Text/SpecialCharacter
struct SpecialCharacter_t6C1DBE8C490706D1620899BAB7F0B8091AD26777_marshaled_com
{
	TMP_Character_t7D37A55EF1A9FF6D0BFE6D50E86A00F80E7FAF35* ___character_0;
	TMP_FontAsset_t923BF2F78D7C5AC36376E168A1193B7CB4855160* ___fontAsset_1;
	Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* ___material_2;
	int32_t ___materialIndex_3;
};

// TMPro.TMP_Text/TextBackingContainer
struct TextBackingContainer_t33D1CE628E7B26C45EDAC1D87BEF2DD22A5C6361 
{
	// System.UInt32[] TMPro.TMP_Text/TextBackingContainer::m_Array
	UInt32U5BU5D_t02FBD658AD156A17574ECE6106CF1FBFCC9807FA* ___m_Array_0;
	// System.Int32 TMPro.TMP_Text/TextBackingContainer::m_Count
	int32_t ___m_Count_1;
};
// Native definition for P/Invoke marshalling of TMPro.TMP_Text/TextBackingContainer
struct TextBackingContainer_t33D1CE628E7B26C45EDAC1D87BEF2DD22A5C6361_marshaled_pinvoke
{
	Il2CppSafeArray/*NONE*/* ___m_Array_0;
	int32_t ___m_Count_1;
};
// Native definition for COM marshalling of TMPro.TMP_Text/TextBackingContainer
struct TextBackingContainer_t33D1CE628E7B26C45EDAC1D87BEF2DD22A5C6361_marshaled_com
{
	Il2CppSafeArray/*NONE*/* ___m_Array_0;
	int32_t ___m_Count_1;
};

// TMPro.TMP_TextProcessingStack`1<UnityEngine.Color32>
struct TMP_TextProcessingStack_1_tF2CD5BE59E5EB22EA9E3EE3043A004EA918C4BB3 
{
	// T[] TMPro.TMP_TextProcessingStack`1::itemStack
	Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* ___itemStack_0;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::index
	int32_t ___index_1;
	// T TMPro.TMP_TextProcessingStack`1::m_DefaultItem
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ___m_DefaultItem_2;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::m_Capacity
	int32_t ___m_Capacity_3;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::m_RolloverSize
	int32_t ___m_RolloverSize_4;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::m_Count
	int32_t ___m_Count_5;
};

// TMPro.TMP_TextProcessingStack`1<TMPro.MaterialReference>
struct TMP_TextProcessingStack_1_tB03E08F69415B281A5A81138F09E49EE58402DF9 
{
	// T[] TMPro.TMP_TextProcessingStack`1::itemStack
	MaterialReferenceU5BU5D_t7491D335AB3E3E13CE9C0F5E931F396F6A02E1F2* ___itemStack_0;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::index
	int32_t ___index_1;
	// T TMPro.TMP_TextProcessingStack`1::m_DefaultItem
	MaterialReference_tFD98FFFBBDF168028E637446C6676507186F4D0B ___m_DefaultItem_2;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::m_Capacity
	int32_t ___m_Capacity_3;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::m_RolloverSize
	int32_t ___m_RolloverSize_4;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::m_Count
	int32_t ___m_Count_5;
};

// <PrivateImplementationDetails>
struct U3CPrivateImplementationDetailsU3E_t0F5473E849A5A5185A9F4C5246F0C32816C49FCA  : public RuntimeObject
{
};

// B83.Image.BMP.BMPImage
struct BMPImage_tA6E059574F192A9BB574E7B260012D990055F05C  : public RuntimeObject
{
	// B83.Image.BMP.BMPFileHeader B83.Image.BMP.BMPImage::header
	BMPFileHeader_t8BB1B4DE759798D79066DF23BBBDE48E1051D50C ___header_0;
	// B83.Image.BMP.BitmapInfoHeader B83.Image.BMP.BMPImage::info
	BitmapInfoHeader_tFB63C5954E9795BECDA9F843F451C426D1982C4E ___info_1;
	// System.UInt32 B83.Image.BMP.BMPImage::rMask
	uint32_t ___rMask_2;
	// System.UInt32 B83.Image.BMP.BMPImage::gMask
	uint32_t ___gMask_3;
	// System.UInt32 B83.Image.BMP.BMPImage::bMask
	uint32_t ___bMask_4;
	// System.UInt32 B83.Image.BMP.BMPImage::aMask
	uint32_t ___aMask_5;
	// System.Collections.Generic.List`1<UnityEngine.Color32> B83.Image.BMP.BMPImage::palette
	List_1_t3517D52AE25CA3B19051E691E9C06ED03A3AB9B8* ___palette_6;
	// UnityEngine.Color32[] B83.Image.BMP.BMPImage::imageData
	Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* ___imageData_7;
};

// UnityEngine.UI.ColorBlock
struct ColorBlock_tDD7C62E7AFE442652FC98F8D058CE8AE6BFD7C11 
{
	// UnityEngine.Color UnityEngine.UI.ColorBlock::m_NormalColor
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___m_NormalColor_0;
	// UnityEngine.Color UnityEngine.UI.ColorBlock::m_HighlightedColor
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___m_HighlightedColor_1;
	// UnityEngine.Color UnityEngine.UI.ColorBlock::m_PressedColor
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___m_PressedColor_2;
	// UnityEngine.Color UnityEngine.UI.ColorBlock::m_SelectedColor
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___m_SelectedColor_3;
	// UnityEngine.Color UnityEngine.UI.ColorBlock::m_DisabledColor
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___m_DisabledColor_4;
	// System.Single UnityEngine.UI.ColorBlock::m_ColorMultiplier
	float ___m_ColorMultiplier_5;
	// System.Single UnityEngine.UI.ColorBlock::m_FadeDuration
	float ___m_FadeDuration_6;
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

// TMPro.Extents
struct Extents_tA2D2F95811D0A18CB7AC3570D2D8F8CD3AF4C4A8 
{
	// UnityEngine.Vector2 TMPro.Extents::min
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___min_2;
	// UnityEngine.Vector2 TMPro.Extents::max
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___max_3;
};

// System.IO.FileStream
struct FileStream_t07C7222EE10B75F352B89B76E60820160FF10AD8  : public Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE
{
	// System.Byte[] System.IO.FileStream::buf
	ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___buf_6;
	// System.String System.IO.FileStream::name
	String_t* ___name_7;
	// Microsoft.Win32.SafeHandles.SafeFileHandle System.IO.FileStream::safeHandle
	SafeFileHandle_t033FA6AAAC65F4BB25F4CBA9A242A58C95CD406E* ___safeHandle_8;
	// System.Boolean System.IO.FileStream::isExposed
	bool ___isExposed_9;
	// System.Int64 System.IO.FileStream::append_startpos
	int64_t ___append_startpos_10;
	// System.IO.FileAccess System.IO.FileStream::access
	int32_t ___access_11;
	// System.Boolean System.IO.FileStream::owner
	bool ___owner_12;
	// System.Boolean System.IO.FileStream::async
	bool ___async_13;
	// System.Boolean System.IO.FileStream::canseek
	bool ___canseek_14;
	// System.Boolean System.IO.FileStream::anonymous
	bool ___anonymous_15;
	// System.Boolean System.IO.FileStream::buf_dirty
	bool ___buf_dirty_16;
	// System.Int32 System.IO.FileStream::buf_size
	int32_t ___buf_size_17;
	// System.Int32 System.IO.FileStream::buf_length
	int32_t ___buf_length_18;
	// System.Int32 System.IO.FileStream::buf_offset
	int32_t ___buf_offset_19;
	// System.Int64 System.IO.FileStream::buf_start
	int64_t ___buf_start_20;
};

// TMPro.HighlightState
struct HighlightState_tE4F50287E5E2E91D42AB77DEA281D88D3AD6A28B 
{
	// UnityEngine.Color32 TMPro.HighlightState::color
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ___color_0;
	// TMPro.TMP_Offset TMPro.HighlightState::padding
	TMP_Offset_t2262BE4E87D9662487777FF8FFE1B17B0E4438C6 ___padding_1;
};

// System.IO.MemoryStream
struct MemoryStream_tAAED1B42172E3390584E4194308AB878E786AAC2  : public Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE
{
	// System.Byte[] System.IO.MemoryStream::_buffer
	ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ____buffer_4;
	// System.Int32 System.IO.MemoryStream::_origin
	int32_t ____origin_5;
	// System.Int32 System.IO.MemoryStream::_position
	int32_t ____position_6;
	// System.Int32 System.IO.MemoryStream::_length
	int32_t ____length_7;
	// System.Int32 System.IO.MemoryStream::_capacity
	int32_t ____capacity_8;
	// System.Boolean System.IO.MemoryStream::_expandable
	bool ____expandable_9;
	// System.Boolean System.IO.MemoryStream::_writable
	bool ____writable_10;
	// System.Boolean System.IO.MemoryStream::_exposable
	bool ____exposable_11;
	// System.Boolean System.IO.MemoryStream::_isOpen
	bool ____isOpen_12;
	// System.Threading.Tasks.Task`1<System.Int32> System.IO.MemoryStream::_lastReadTask
	Task_1_t4C228DE57804012969575431CFF12D57C875552D* ____lastReadTask_13;
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

// Unity.Profiling.ProfilerMarker
struct ProfilerMarker_tA256E18DA86EDBC5528CE066FC91C96EE86501AD 
{
	// System.IntPtr Unity.Profiling.ProfilerMarker::m_Ptr
	intptr_t ___m_Ptr_0;
};

// TMPro.VertexGradient
struct VertexGradient_t2C057B53C0EA6E987C2B7BAB0305E686DA1C9A8F 
{
	// UnityEngine.Color TMPro.VertexGradient::topLeft
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___topLeft_0;
	// UnityEngine.Color TMPro.VertexGradient::topRight
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___topRight_1;
	// UnityEngine.Color TMPro.VertexGradient::bottomLeft
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___bottomLeft_2;
	// UnityEngine.Color TMPro.VertexGradient::bottomRight
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___bottomRight_3;
};

// UnityEngine.UI.Button/ButtonClickedEvent
struct ButtonClickedEvent_t8EA72E90B3BD1392FB3B3EF167D5121C23569E4C  : public UnityEvent_tDC2C3548799DBC91D1E3F3DE60083A66F4751977
{
};

// TMPro.TMP_TextProcessingStack`1<TMPro.HighlightState>
struct TMP_TextProcessingStack_1_t57AECDCC936A7FF1D6CF66CA11560B28A675648D 
{
	// T[] TMPro.TMP_TextProcessingStack`1::itemStack
	HighlightStateU5BU5D_tA878A0AF1F4F52882ACD29515AADC277EE135622* ___itemStack_0;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::index
	int32_t ___index_1;
	// T TMPro.TMP_TextProcessingStack`1::m_DefaultItem
	HighlightState_tE4F50287E5E2E91D42AB77DEA281D88D3AD6A28B ___m_DefaultItem_2;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::m_Capacity
	int32_t ___m_Capacity_3;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::m_RolloverSize
	int32_t ___m_RolloverSize_4;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::m_Count
	int32_t ___m_Count_5;
};

// UnityEngine.Component
struct Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3  : public Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C
{
};

// UnityEngine.GameObject
struct GameObject_t76FEDD663AB33C991A9C9A23129337651094216F  : public Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C
{
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

// UnityEngine.ScriptableObject
struct ScriptableObject_tB3BFDB921A1B1795B38A5417D3B97A89A140436A  : public Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C
{
};
// Native definition for P/Invoke marshalling of UnityEngine.ScriptableObject
struct ScriptableObject_tB3BFDB921A1B1795B38A5417D3B97A89A140436A_marshaled_pinvoke : public Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_marshaled_pinvoke
{
};
// Native definition for COM marshalling of UnityEngine.ScriptableObject
struct ScriptableObject_tB3BFDB921A1B1795B38A5417D3B97A89A140436A_marshaled_com : public Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_marshaled_com
{
};

// UnityEngine.Sprite
struct Sprite_tAFF74BC83CD68037494CB0B4F28CBDF8971CAB99  : public Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C
{
};

// TMPro.TMP_LineInfo
struct TMP_LineInfo_tB75C1965B58DB7B3A046C8CA55AD6AB92B6B17B3 
{
	// System.Int32 TMPro.TMP_LineInfo::controlCharacterCount
	int32_t ___controlCharacterCount_0;
	// System.Int32 TMPro.TMP_LineInfo::characterCount
	int32_t ___characterCount_1;
	// System.Int32 TMPro.TMP_LineInfo::visibleCharacterCount
	int32_t ___visibleCharacterCount_2;
	// System.Int32 TMPro.TMP_LineInfo::spaceCount
	int32_t ___spaceCount_3;
	// System.Int32 TMPro.TMP_LineInfo::wordCount
	int32_t ___wordCount_4;
	// System.Int32 TMPro.TMP_LineInfo::firstCharacterIndex
	int32_t ___firstCharacterIndex_5;
	// System.Int32 TMPro.TMP_LineInfo::firstVisibleCharacterIndex
	int32_t ___firstVisibleCharacterIndex_6;
	// System.Int32 TMPro.TMP_LineInfo::lastCharacterIndex
	int32_t ___lastCharacterIndex_7;
	// System.Int32 TMPro.TMP_LineInfo::lastVisibleCharacterIndex
	int32_t ___lastVisibleCharacterIndex_8;
	// System.Single TMPro.TMP_LineInfo::length
	float ___length_9;
	// System.Single TMPro.TMP_LineInfo::lineHeight
	float ___lineHeight_10;
	// System.Single TMPro.TMP_LineInfo::ascender
	float ___ascender_11;
	// System.Single TMPro.TMP_LineInfo::baseline
	float ___baseline_12;
	// System.Single TMPro.TMP_LineInfo::descender
	float ___descender_13;
	// System.Single TMPro.TMP_LineInfo::maxAdvance
	float ___maxAdvance_14;
	// System.Single TMPro.TMP_LineInfo::width
	float ___width_15;
	// System.Single TMPro.TMP_LineInfo::marginLeft
	float ___marginLeft_16;
	// System.Single TMPro.TMP_LineInfo::marginRight
	float ___marginRight_17;
	// TMPro.HorizontalAlignmentOptions TMPro.TMP_LineInfo::alignment
	int32_t ___alignment_18;
	// TMPro.Extents TMPro.TMP_LineInfo::lineExtents
	Extents_tA2D2F95811D0A18CB7AC3570D2D8F8CD3AF4C4A8 ___lineExtents_19;
};

// UnityEngine.Texture
struct Texture_t791CBB51219779964E0E8A2ED7C1AA5F92A4A700  : public Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C
{
};

// System.Action`1<System.String[]>
struct Action_1_t5439CAB6DF93B6A7A29E473D9B2A9943E580CAF8  : public MulticastDelegate_t
{
};

// System.Action`1<System.String>
struct Action_1_t3CB5D1A819C3ED3F99E9E39F890F18633253949A  : public MulticastDelegate_t
{
};

// UnityEngine.Events.UnityAction`1<System.Boolean>
struct UnityAction_1_t8EC357AF4FBD2A0C4A575C4BBD0B3A81029E43A9  : public MulticastDelegate_t
{
};

// UnityEngine.Events.UnityAction`1<System.Object>
struct UnityAction_1_t9C30BCD020745BF400CBACF22C6F34ADBA2DDA6A  : public MulticastDelegate_t
{
};

// UnityEngine.Events.UnityAction`1<System.String>
struct UnityAction_1_t690494F0E492A2098660E28B8EB7D71B2C69BE1B  : public MulticastDelegate_t
{
};

// UnityEngine.Events.UnityAction`4<UnityEngine.Color,UnityEngine.Color,UnityEngine.Color,UnityEngine.Color>
struct UnityAction_4_t05D51CE8BEA0460D330923E761D421EF194ED9B1  : public MulticastDelegate_t
{
};

// UnityEngine.Behaviour
struct Behaviour_t01970CFBBA658497AE30F311C447DB0440BAB7FA  : public Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3
{
};

// Keyboard.KeyChannel
struct KeyChannel_t928FC4C0F40F35E44A1B18D92A9B172B2B760A8A  : public ScriptableObject_tB3BFDB921A1B1795B38A5417D3B97A89A140436A
{
	// UnityEngine.Events.UnityAction`1<System.String> Keyboard.KeyChannel::OnKeyPressed
	UnityAction_1_t690494F0E492A2098660E28B8EB7D71B2C69BE1B* ___OnKeyPressed_4;
	// UnityEngine.Events.UnityAction`4<UnityEngine.Color,UnityEngine.Color,UnityEngine.Color,UnityEngine.Color> Keyboard.KeyChannel::OnKeyColorsChanged
	UnityAction_4_t05D51CE8BEA0460D330923E761D421EF194ED9B1* ___OnKeyColorsChanged_5;
	// UnityEngine.Events.UnityAction`1<System.Boolean> Keyboard.KeyChannel::OnKeysStateChange
	UnityAction_1_t8EC357AF4FBD2A0C4A575C4BBD0B3A81029E43A9* ___OnKeysStateChange_6;
	// UnityEngine.Events.UnityEvent Keyboard.KeyChannel::onFirstKeyPress
	UnityEvent_tDC2C3548799DBC91D1E3F3DE60083A66F4751977* ___onFirstKeyPress_7;
};

// UnityEngine.Texture2D
struct Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4  : public Texture_t791CBB51219779964E0E8A2ED7C1AA5F92A4A700
{
};

// UnityEngine.Events.UnityAction
struct UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7  : public MulticastDelegate_t
{
};

// TMPro.WordWrapState
struct WordWrapState_t80F67D8CAA9B1A0A3D5266521E23A9F3100EDD0A 
{
	// System.Int32 TMPro.WordWrapState::previous_WordBreak
	int32_t ___previous_WordBreak_0;
	// System.Int32 TMPro.WordWrapState::total_CharacterCount
	int32_t ___total_CharacterCount_1;
	// System.Int32 TMPro.WordWrapState::visible_CharacterCount
	int32_t ___visible_CharacterCount_2;
	// System.Int32 TMPro.WordWrapState::visible_SpriteCount
	int32_t ___visible_SpriteCount_3;
	// System.Int32 TMPro.WordWrapState::visible_LinkCount
	int32_t ___visible_LinkCount_4;
	// System.Int32 TMPro.WordWrapState::firstCharacterIndex
	int32_t ___firstCharacterIndex_5;
	// System.Int32 TMPro.WordWrapState::firstVisibleCharacterIndex
	int32_t ___firstVisibleCharacterIndex_6;
	// System.Int32 TMPro.WordWrapState::lastCharacterIndex
	int32_t ___lastCharacterIndex_7;
	// System.Int32 TMPro.WordWrapState::lastVisibleCharIndex
	int32_t ___lastVisibleCharIndex_8;
	// System.Int32 TMPro.WordWrapState::lineNumber
	int32_t ___lineNumber_9;
	// System.Single TMPro.WordWrapState::maxCapHeight
	float ___maxCapHeight_10;
	// System.Single TMPro.WordWrapState::maxAscender
	float ___maxAscender_11;
	// System.Single TMPro.WordWrapState::maxDescender
	float ___maxDescender_12;
	// System.Single TMPro.WordWrapState::startOfLineAscender
	float ___startOfLineAscender_13;
	// System.Single TMPro.WordWrapState::maxLineAscender
	float ___maxLineAscender_14;
	// System.Single TMPro.WordWrapState::maxLineDescender
	float ___maxLineDescender_15;
	// System.Single TMPro.WordWrapState::pageAscender
	float ___pageAscender_16;
	// TMPro.HorizontalAlignmentOptions TMPro.WordWrapState::horizontalAlignment
	int32_t ___horizontalAlignment_17;
	// System.Single TMPro.WordWrapState::marginLeft
	float ___marginLeft_18;
	// System.Single TMPro.WordWrapState::marginRight
	float ___marginRight_19;
	// System.Single TMPro.WordWrapState::xAdvance
	float ___xAdvance_20;
	// System.Single TMPro.WordWrapState::preferredWidth
	float ___preferredWidth_21;
	// System.Single TMPro.WordWrapState::preferredHeight
	float ___preferredHeight_22;
	// System.Single TMPro.WordWrapState::previousLineScale
	float ___previousLineScale_23;
	// System.Int32 TMPro.WordWrapState::wordCount
	int32_t ___wordCount_24;
	// TMPro.FontStyles TMPro.WordWrapState::fontStyle
	int32_t ___fontStyle_25;
	// System.Int32 TMPro.WordWrapState::italicAngle
	int32_t ___italicAngle_26;
	// System.Single TMPro.WordWrapState::fontScaleMultiplier
	float ___fontScaleMultiplier_27;
	// System.Single TMPro.WordWrapState::currentFontSize
	float ___currentFontSize_28;
	// System.Single TMPro.WordWrapState::baselineOffset
	float ___baselineOffset_29;
	// System.Single TMPro.WordWrapState::lineOffset
	float ___lineOffset_30;
	// System.Boolean TMPro.WordWrapState::isDrivenLineSpacing
	bool ___isDrivenLineSpacing_31;
	// System.Single TMPro.WordWrapState::glyphHorizontalAdvanceAdjustment
	float ___glyphHorizontalAdvanceAdjustment_32;
	// System.Single TMPro.WordWrapState::cSpace
	float ___cSpace_33;
	// System.Single TMPro.WordWrapState::mSpace
	float ___mSpace_34;
	// TMPro.TMP_TextInfo TMPro.WordWrapState::textInfo
	TMP_TextInfo_t09A8E906329422C3F0C059876801DD695B8D524D* ___textInfo_35;
	// TMPro.TMP_LineInfo TMPro.WordWrapState::lineInfo
	TMP_LineInfo_tB75C1965B58DB7B3A046C8CA55AD6AB92B6B17B3 ___lineInfo_36;
	// UnityEngine.Color32 TMPro.WordWrapState::vertexColor
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ___vertexColor_37;
	// UnityEngine.Color32 TMPro.WordWrapState::underlineColor
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ___underlineColor_38;
	// UnityEngine.Color32 TMPro.WordWrapState::strikethroughColor
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ___strikethroughColor_39;
	// UnityEngine.Color32 TMPro.WordWrapState::highlightColor
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ___highlightColor_40;
	// TMPro.TMP_FontStyleStack TMPro.WordWrapState::basicStyleStack
	TMP_FontStyleStack_t52885F172FADBC21346C835B5302167BDA8020DC ___basicStyleStack_41;
	// TMPro.TMP_TextProcessingStack`1<System.Int32> TMPro.WordWrapState::italicAngleStack
	TMP_TextProcessingStack_1_tFBA719426D68CE1F2B5849D97AF5E5D65846290C ___italicAngleStack_42;
	// TMPro.TMP_TextProcessingStack`1<UnityEngine.Color32> TMPro.WordWrapState::colorStack
	TMP_TextProcessingStack_1_tF2CD5BE59E5EB22EA9E3EE3043A004EA918C4BB3 ___colorStack_43;
	// TMPro.TMP_TextProcessingStack`1<UnityEngine.Color32> TMPro.WordWrapState::underlineColorStack
	TMP_TextProcessingStack_1_tF2CD5BE59E5EB22EA9E3EE3043A004EA918C4BB3 ___underlineColorStack_44;
	// TMPro.TMP_TextProcessingStack`1<UnityEngine.Color32> TMPro.WordWrapState::strikethroughColorStack
	TMP_TextProcessingStack_1_tF2CD5BE59E5EB22EA9E3EE3043A004EA918C4BB3 ___strikethroughColorStack_45;
	// TMPro.TMP_TextProcessingStack`1<UnityEngine.Color32> TMPro.WordWrapState::highlightColorStack
	TMP_TextProcessingStack_1_tF2CD5BE59E5EB22EA9E3EE3043A004EA918C4BB3 ___highlightColorStack_46;
	// TMPro.TMP_TextProcessingStack`1<TMPro.HighlightState> TMPro.WordWrapState::highlightStateStack
	TMP_TextProcessingStack_1_t57AECDCC936A7FF1D6CF66CA11560B28A675648D ___highlightStateStack_47;
	// TMPro.TMP_TextProcessingStack`1<TMPro.TMP_ColorGradient> TMPro.WordWrapState::colorGradientStack
	TMP_TextProcessingStack_1_tC8FAEB17246D3B171EFD11165A5761AE39B40D0C ___colorGradientStack_48;
	// TMPro.TMP_TextProcessingStack`1<System.Single> TMPro.WordWrapState::sizeStack
	TMP_TextProcessingStack_1_t138EC06BE7F101AA0A3C8D2DC951E55AACE085E9 ___sizeStack_49;
	// TMPro.TMP_TextProcessingStack`1<System.Single> TMPro.WordWrapState::indentStack
	TMP_TextProcessingStack_1_t138EC06BE7F101AA0A3C8D2DC951E55AACE085E9 ___indentStack_50;
	// TMPro.TMP_TextProcessingStack`1<TMPro.FontWeight> TMPro.WordWrapState::fontWeightStack
	TMP_TextProcessingStack_1_tA5C8CED87DD9E73F6359E23B334FFB5B6F813FD4 ___fontWeightStack_51;
	// TMPro.TMP_TextProcessingStack`1<System.Int32> TMPro.WordWrapState::styleStack
	TMP_TextProcessingStack_1_tFBA719426D68CE1F2B5849D97AF5E5D65846290C ___styleStack_52;
	// TMPro.TMP_TextProcessingStack`1<System.Single> TMPro.WordWrapState::baselineStack
	TMP_TextProcessingStack_1_t138EC06BE7F101AA0A3C8D2DC951E55AACE085E9 ___baselineStack_53;
	// TMPro.TMP_TextProcessingStack`1<System.Int32> TMPro.WordWrapState::actionStack
	TMP_TextProcessingStack_1_tFBA719426D68CE1F2B5849D97AF5E5D65846290C ___actionStack_54;
	// TMPro.TMP_TextProcessingStack`1<TMPro.MaterialReference> TMPro.WordWrapState::materialReferenceStack
	TMP_TextProcessingStack_1_tB03E08F69415B281A5A81138F09E49EE58402DF9 ___materialReferenceStack_55;
	// TMPro.TMP_TextProcessingStack`1<TMPro.HorizontalAlignmentOptions> TMPro.WordWrapState::lineJustificationStack
	TMP_TextProcessingStack_1_t243EA1B5D7FD2295D6533B953F0BBE8F52EFB8A0 ___lineJustificationStack_56;
	// System.Int32 TMPro.WordWrapState::spriteAnimationID
	int32_t ___spriteAnimationID_57;
	// TMPro.TMP_FontAsset TMPro.WordWrapState::currentFontAsset
	TMP_FontAsset_t923BF2F78D7C5AC36376E168A1193B7CB4855160* ___currentFontAsset_58;
	// TMPro.TMP_SpriteAsset TMPro.WordWrapState::currentSpriteAsset
	TMP_SpriteAsset_t81F779E6F705CE190DC0D1F93A954CB8B1774B39* ___currentSpriteAsset_59;
	// UnityEngine.Material TMPro.WordWrapState::currentMaterial
	Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* ___currentMaterial_60;
	// System.Int32 TMPro.WordWrapState::currentMaterialIndex
	int32_t ___currentMaterialIndex_61;
	// TMPro.Extents TMPro.WordWrapState::meshExtents
	Extents_tA2D2F95811D0A18CB7AC3570D2D8F8CD3AF4C4A8 ___meshExtents_62;
	// System.Boolean TMPro.WordWrapState::tagNoParsing
	bool ___tagNoParsing_63;
	// System.Boolean TMPro.WordWrapState::isNonBreakingSpace
	bool ___isNonBreakingSpace_64;
};
// Native definition for P/Invoke marshalling of TMPro.WordWrapState
struct WordWrapState_t80F67D8CAA9B1A0A3D5266521E23A9F3100EDD0A_marshaled_pinvoke
{
	int32_t ___previous_WordBreak_0;
	int32_t ___total_CharacterCount_1;
	int32_t ___visible_CharacterCount_2;
	int32_t ___visible_SpriteCount_3;
	int32_t ___visible_LinkCount_4;
	int32_t ___firstCharacterIndex_5;
	int32_t ___firstVisibleCharacterIndex_6;
	int32_t ___lastCharacterIndex_7;
	int32_t ___lastVisibleCharIndex_8;
	int32_t ___lineNumber_9;
	float ___maxCapHeight_10;
	float ___maxAscender_11;
	float ___maxDescender_12;
	float ___startOfLineAscender_13;
	float ___maxLineAscender_14;
	float ___maxLineDescender_15;
	float ___pageAscender_16;
	int32_t ___horizontalAlignment_17;
	float ___marginLeft_18;
	float ___marginRight_19;
	float ___xAdvance_20;
	float ___preferredWidth_21;
	float ___preferredHeight_22;
	float ___previousLineScale_23;
	int32_t ___wordCount_24;
	int32_t ___fontStyle_25;
	int32_t ___italicAngle_26;
	float ___fontScaleMultiplier_27;
	float ___currentFontSize_28;
	float ___baselineOffset_29;
	float ___lineOffset_30;
	int32_t ___isDrivenLineSpacing_31;
	float ___glyphHorizontalAdvanceAdjustment_32;
	float ___cSpace_33;
	float ___mSpace_34;
	TMP_TextInfo_t09A8E906329422C3F0C059876801DD695B8D524D* ___textInfo_35;
	TMP_LineInfo_tB75C1965B58DB7B3A046C8CA55AD6AB92B6B17B3 ___lineInfo_36;
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ___vertexColor_37;
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ___underlineColor_38;
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ___strikethroughColor_39;
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ___highlightColor_40;
	TMP_FontStyleStack_t52885F172FADBC21346C835B5302167BDA8020DC ___basicStyleStack_41;
	TMP_TextProcessingStack_1_tFBA719426D68CE1F2B5849D97AF5E5D65846290C ___italicAngleStack_42;
	TMP_TextProcessingStack_1_tF2CD5BE59E5EB22EA9E3EE3043A004EA918C4BB3 ___colorStack_43;
	TMP_TextProcessingStack_1_tF2CD5BE59E5EB22EA9E3EE3043A004EA918C4BB3 ___underlineColorStack_44;
	TMP_TextProcessingStack_1_tF2CD5BE59E5EB22EA9E3EE3043A004EA918C4BB3 ___strikethroughColorStack_45;
	TMP_TextProcessingStack_1_tF2CD5BE59E5EB22EA9E3EE3043A004EA918C4BB3 ___highlightColorStack_46;
	TMP_TextProcessingStack_1_t57AECDCC936A7FF1D6CF66CA11560B28A675648D ___highlightStateStack_47;
	TMP_TextProcessingStack_1_tC8FAEB17246D3B171EFD11165A5761AE39B40D0C ___colorGradientStack_48;
	TMP_TextProcessingStack_1_t138EC06BE7F101AA0A3C8D2DC951E55AACE085E9 ___sizeStack_49;
	TMP_TextProcessingStack_1_t138EC06BE7F101AA0A3C8D2DC951E55AACE085E9 ___indentStack_50;
	TMP_TextProcessingStack_1_tA5C8CED87DD9E73F6359E23B334FFB5B6F813FD4 ___fontWeightStack_51;
	TMP_TextProcessingStack_1_tFBA719426D68CE1F2B5849D97AF5E5D65846290C ___styleStack_52;
	TMP_TextProcessingStack_1_t138EC06BE7F101AA0A3C8D2DC951E55AACE085E9 ___baselineStack_53;
	TMP_TextProcessingStack_1_tFBA719426D68CE1F2B5849D97AF5E5D65846290C ___actionStack_54;
	TMP_TextProcessingStack_1_tB03E08F69415B281A5A81138F09E49EE58402DF9 ___materialReferenceStack_55;
	TMP_TextProcessingStack_1_t243EA1B5D7FD2295D6533B953F0BBE8F52EFB8A0 ___lineJustificationStack_56;
	int32_t ___spriteAnimationID_57;
	TMP_FontAsset_t923BF2F78D7C5AC36376E168A1193B7CB4855160* ___currentFontAsset_58;
	TMP_SpriteAsset_t81F779E6F705CE190DC0D1F93A954CB8B1774B39* ___currentSpriteAsset_59;
	Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* ___currentMaterial_60;
	int32_t ___currentMaterialIndex_61;
	Extents_tA2D2F95811D0A18CB7AC3570D2D8F8CD3AF4C4A8 ___meshExtents_62;
	int32_t ___tagNoParsing_63;
	int32_t ___isNonBreakingSpace_64;
};
// Native definition for COM marshalling of TMPro.WordWrapState
struct WordWrapState_t80F67D8CAA9B1A0A3D5266521E23A9F3100EDD0A_marshaled_com
{
	int32_t ___previous_WordBreak_0;
	int32_t ___total_CharacterCount_1;
	int32_t ___visible_CharacterCount_2;
	int32_t ___visible_SpriteCount_3;
	int32_t ___visible_LinkCount_4;
	int32_t ___firstCharacterIndex_5;
	int32_t ___firstVisibleCharacterIndex_6;
	int32_t ___lastCharacterIndex_7;
	int32_t ___lastVisibleCharIndex_8;
	int32_t ___lineNumber_9;
	float ___maxCapHeight_10;
	float ___maxAscender_11;
	float ___maxDescender_12;
	float ___startOfLineAscender_13;
	float ___maxLineAscender_14;
	float ___maxLineDescender_15;
	float ___pageAscender_16;
	int32_t ___horizontalAlignment_17;
	float ___marginLeft_18;
	float ___marginRight_19;
	float ___xAdvance_20;
	float ___preferredWidth_21;
	float ___preferredHeight_22;
	float ___previousLineScale_23;
	int32_t ___wordCount_24;
	int32_t ___fontStyle_25;
	int32_t ___italicAngle_26;
	float ___fontScaleMultiplier_27;
	float ___currentFontSize_28;
	float ___baselineOffset_29;
	float ___lineOffset_30;
	int32_t ___isDrivenLineSpacing_31;
	float ___glyphHorizontalAdvanceAdjustment_32;
	float ___cSpace_33;
	float ___mSpace_34;
	TMP_TextInfo_t09A8E906329422C3F0C059876801DD695B8D524D* ___textInfo_35;
	TMP_LineInfo_tB75C1965B58DB7B3A046C8CA55AD6AB92B6B17B3 ___lineInfo_36;
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ___vertexColor_37;
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ___underlineColor_38;
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ___strikethroughColor_39;
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ___highlightColor_40;
	TMP_FontStyleStack_t52885F172FADBC21346C835B5302167BDA8020DC ___basicStyleStack_41;
	TMP_TextProcessingStack_1_tFBA719426D68CE1F2B5849D97AF5E5D65846290C ___italicAngleStack_42;
	TMP_TextProcessingStack_1_tF2CD5BE59E5EB22EA9E3EE3043A004EA918C4BB3 ___colorStack_43;
	TMP_TextProcessingStack_1_tF2CD5BE59E5EB22EA9E3EE3043A004EA918C4BB3 ___underlineColorStack_44;
	TMP_TextProcessingStack_1_tF2CD5BE59E5EB22EA9E3EE3043A004EA918C4BB3 ___strikethroughColorStack_45;
	TMP_TextProcessingStack_1_tF2CD5BE59E5EB22EA9E3EE3043A004EA918C4BB3 ___highlightColorStack_46;
	TMP_TextProcessingStack_1_t57AECDCC936A7FF1D6CF66CA11560B28A675648D ___highlightStateStack_47;
	TMP_TextProcessingStack_1_tC8FAEB17246D3B171EFD11165A5761AE39B40D0C ___colorGradientStack_48;
	TMP_TextProcessingStack_1_t138EC06BE7F101AA0A3C8D2DC951E55AACE085E9 ___sizeStack_49;
	TMP_TextProcessingStack_1_t138EC06BE7F101AA0A3C8D2DC951E55AACE085E9 ___indentStack_50;
	TMP_TextProcessingStack_1_tA5C8CED87DD9E73F6359E23B334FFB5B6F813FD4 ___fontWeightStack_51;
	TMP_TextProcessingStack_1_tFBA719426D68CE1F2B5849D97AF5E5D65846290C ___styleStack_52;
	TMP_TextProcessingStack_1_t138EC06BE7F101AA0A3C8D2DC951E55AACE085E9 ___baselineStack_53;
	TMP_TextProcessingStack_1_tFBA719426D68CE1F2B5849D97AF5E5D65846290C ___actionStack_54;
	TMP_TextProcessingStack_1_tB03E08F69415B281A5A81138F09E49EE58402DF9 ___materialReferenceStack_55;
	TMP_TextProcessingStack_1_t243EA1B5D7FD2295D6533B953F0BBE8F52EFB8A0 ___lineJustificationStack_56;
	int32_t ___spriteAnimationID_57;
	TMP_FontAsset_t923BF2F78D7C5AC36376E168A1193B7CB4855160* ___currentFontAsset_58;
	TMP_SpriteAsset_t81F779E6F705CE190DC0D1F93A954CB8B1774B39* ___currentSpriteAsset_59;
	Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* ___currentMaterial_60;
	int32_t ___currentMaterialIndex_61;
	Extents_tA2D2F95811D0A18CB7AC3570D2D8F8CD3AF4C4A8 ___meshExtents_62;
	int32_t ___tagNoParsing_63;
	int32_t ___isNonBreakingSpace_64;
};

// TMPro.TMP_TextProcessingStack`1<TMPro.WordWrapState>
struct TMP_TextProcessingStack_1_t2DDA00FFC64AF6E3AFD475AB2086D16C34787E0F 
{
	// T[] TMPro.TMP_TextProcessingStack`1::itemStack
	WordWrapStateU5BU5D_t473D59C9DBCC949CE72EF1EB471CBA152A6CEAC9* ___itemStack_0;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::index
	int32_t ___index_1;
	// T TMPro.TMP_TextProcessingStack`1::m_DefaultItem
	WordWrapState_t80F67D8CAA9B1A0A3D5266521E23A9F3100EDD0A ___m_DefaultItem_2;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::m_Capacity
	int32_t ___m_Capacity_3;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::m_RolloverSize
	int32_t ___m_RolloverSize_4;
	// System.Int32 TMPro.TMP_TextProcessingStack`1::m_Count
	int32_t ___m_Count_5;
};

// UnityEngine.MonoBehaviour
struct MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71  : public Behaviour_t01970CFBBA658497AE30F311C447DB0440BAB7FA
{
};

// Keyboard.Key
struct Key_tB9DA6A9816AEA58ACE1AE6EA33755EAEEBAC8970  : public MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71
{
	// Keyboard.KeyChannel Keyboard.Key::keyChannel
	KeyChannel_t928FC4C0F40F35E44A1B18D92A9B172B2B760A8A* ___keyChannel_4;
	// Keyboard.KeyboardManager Keyboard.Key::keyboard
	KeyboardManager_t41DD8382AE61564F08C9856BE00640CCB87720FB* ___keyboard_5;
	// UnityEngine.UI.Button Keyboard.Key::button
	Button_t6786514A57F7AFDEE5431112FEA0CAB24F5AE098* ___button_6;
};

// Keyboard.KeyboardManager
struct KeyboardManager_t41DD8382AE61564F08C9856BE00640CCB87720FB  : public MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71
{
	// Keyboard.KeyChannel Keyboard.KeyboardManager::keyChannel
	KeyChannel_t928FC4C0F40F35E44A1B18D92A9B172B2B760A8A* ___keyChannel_4;
	// UnityEngine.UI.Button Keyboard.KeyboardManager::spacebarButton
	Button_t6786514A57F7AFDEE5431112FEA0CAB24F5AE098* ___spacebarButton_5;
	// UnityEngine.UI.Button Keyboard.KeyboardManager::speechButton
	Button_t6786514A57F7AFDEE5431112FEA0CAB24F5AE098* ___speechButton_6;
	// UnityEngine.UI.Button Keyboard.KeyboardManager::deleteButton
	Button_t6786514A57F7AFDEE5431112FEA0CAB24F5AE098* ___deleteButton_7;
	// UnityEngine.UI.Button Keyboard.KeyboardManager::switchButton
	Button_t6786514A57F7AFDEE5431112FEA0CAB24F5AE098* ___switchButton_8;
	// System.String Keyboard.KeyboardManager::switchToNumbers
	String_t* ___switchToNumbers_9;
	// System.String Keyboard.KeyboardManager::switchToLetter
	String_t* ___switchToLetter_10;
	// TMPro.TextMeshProUGUI Keyboard.KeyboardManager::switchButtonText
	TextMeshProUGUI_t101091AF4B578BB534C92E9D1EEAF0611636D957* ___switchButtonText_11;
	// UnityEngine.GameObject Keyboard.KeyboardManager::lettersKeyboard
	GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* ___lettersKeyboard_12;
	// UnityEngine.GameObject Keyboard.KeyboardManager::numbersKeyboard
	GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* ___numbersKeyboard_13;
	// UnityEngine.GameObject Keyboard.KeyboardManager::specialCharactersKeyboard
	GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* ___specialCharactersKeyboard_14;
	// System.Boolean Keyboard.KeyboardManager::autoCapsAtStart
	bool ___autoCapsAtStart_15;
	// UnityEngine.UI.Button Keyboard.KeyboardManager::shiftButton
	Button_t6786514A57F7AFDEE5431112FEA0CAB24F5AE098* ___shiftButton_16;
	// UnityEngine.UI.Image Keyboard.KeyboardManager::buttonImage
	Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* ___buttonImage_17;
	// UnityEngine.Sprite Keyboard.KeyboardManager::defaultSprite
	Sprite_tAFF74BC83CD68037494CB0B4F28CBDF8971CAB99* ___defaultSprite_18;
	// UnityEngine.Sprite Keyboard.KeyboardManager::activeSprite
	Sprite_tAFF74BC83CD68037494CB0B4F28CBDF8971CAB99* ___activeSprite_19;
	// UnityEngine.UI.Button Keyboard.KeyboardManager::switchNumberSpecialButton
	Button_t6786514A57F7AFDEE5431112FEA0CAB24F5AE098* ___switchNumberSpecialButton_20;
	// System.String Keyboard.KeyboardManager::numbersString
	String_t* ___numbersString_21;
	// System.String Keyboard.KeyboardManager::specialString
	String_t* ___specialString_22;
	// TMPro.TextMeshProUGUI Keyboard.KeyboardManager::switchNumSpecButtonText
	TextMeshProUGUI_t101091AF4B578BB534C92E9D1EEAF0611636D957* ___switchNumSpecButtonText_23;
	// UnityEngine.Color Keyboard.KeyboardManager::normalColor
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___normalColor_24;
	// UnityEngine.Color Keyboard.KeyboardManager::highlightedColor
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___highlightedColor_25;
	// UnityEngine.Color Keyboard.KeyboardManager::pressedColor
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___pressedColor_26;
	// UnityEngine.Color Keyboard.KeyboardManager::selectedColor
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___selectedColor_27;
	// TMPro.TMP_InputField Keyboard.KeyboardManager::outputField
	TMP_InputField_t3488E0EE8C3DF56C6A328EC95D1BEEA2DF4A7D5F* ___outputField_28;
	// UnityEngine.UI.Button Keyboard.KeyboardManager::enterButton
	Button_t6786514A57F7AFDEE5431112FEA0CAB24F5AE098* ___enterButton_29;
	// System.Int32 Keyboard.KeyboardManager::maxCharacters
	int32_t ___maxCharacters_30;
	// System.Int32 Keyboard.KeyboardManager::minCharacters
	int32_t ___minCharacters_31;
	// UnityEngine.UI.ColorBlock Keyboard.KeyboardManager::shiftButtonColors
	ColorBlock_tDD7C62E7AFE442652FC98F8D058CE8AE6BFD7C11 ___shiftButtonColors_32;
	// System.Boolean Keyboard.KeyboardManager::isFirstKeyPress
	bool ___isFirstKeyPress_33;
	// System.Boolean Keyboard.KeyboardManager::keyHasBeenPressed
	bool ___keyHasBeenPressed_34;
	// System.Boolean Keyboard.KeyboardManager::shiftActive
	bool ___shiftActive_35;
	// System.Boolean Keyboard.KeyboardManager::capsLockActive
	bool ___capsLockActive_36;
	// System.Boolean Keyboard.KeyboardManager::specialCharactersActive
	bool ___specialCharactersActive_37;
	// System.Single Keyboard.KeyboardManager::lastShiftClickTime
	float ___lastShiftClickTime_38;
	// System.Single Keyboard.KeyboardManager::shiftDoubleClickDelay
	float ___shiftDoubleClickDelay_39;
	// UnityEngine.Events.UnityEvent Keyboard.KeyboardManager::onKeyboardModeChanged
	UnityEvent_tDC2C3548799DBC91D1E3F3DE60083A66F4751977* ___onKeyboardModeChanged_40;
	// UnityEngine.EventSystems.EventSystem Keyboard.KeyboardManager::eventSystem
	EventSystem_t61C51380B105BE9D2C39C4F15B7E655659957707* ___eventSystem_41;
	// UnityEngine.GameObject Keyboard.KeyboardManager::selectedGameObject
	GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* ___selectedGameObject_42;
};

// UnityEngine.EventSystems.UIBehaviour
struct UIBehaviour_tB9D4295827BD2EEDEF0749200C6CA7090C742A9D  : public MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71
{
};

// UnityEngine.EventSystems.EventSystem
struct EventSystem_t61C51380B105BE9D2C39C4F15B7E655659957707  : public UIBehaviour_tB9D4295827BD2EEDEF0749200C6CA7090C742A9D
{
	// System.Collections.Generic.List`1<UnityEngine.EventSystems.BaseInputModule> UnityEngine.EventSystems.EventSystem::m_SystemInputModules
	List_1_tA5BDE435C735A082941CD33D212F97F4AE9FA55F* ___m_SystemInputModules_4;
	// UnityEngine.EventSystems.BaseInputModule UnityEngine.EventSystems.EventSystem::m_CurrentInputModule
	BaseInputModule_tF3B7C22AF1419B2AC9ECE6589357DC1B88ED96B1* ___m_CurrentInputModule_5;
	// UnityEngine.GameObject UnityEngine.EventSystems.EventSystem::m_FirstSelected
	GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* ___m_FirstSelected_7;
	// System.Boolean UnityEngine.EventSystems.EventSystem::m_sendNavigationEvents
	bool ___m_sendNavigationEvents_8;
	// System.Int32 UnityEngine.EventSystems.EventSystem::m_DragThreshold
	int32_t ___m_DragThreshold_9;
	// UnityEngine.GameObject UnityEngine.EventSystems.EventSystem::m_CurrentSelected
	GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* ___m_CurrentSelected_10;
	// System.Boolean UnityEngine.EventSystems.EventSystem::m_HasFocus
	bool ___m_HasFocus_11;
	// System.Boolean UnityEngine.EventSystems.EventSystem::m_SelectionGuard
	bool ___m_SelectionGuard_12;
	// UnityEngine.EventSystems.BaseEventData UnityEngine.EventSystems.EventSystem::m_DummyData
	BaseEventData_tE03A848325C0AE8E76C6CA15FD86395EBF83364F* ___m_DummyData_13;
};

// UnityEngine.UI.Graphic
struct Graphic_tCBFCA4585A19E2B75465AECFEAC43F4016BF7931  : public UIBehaviour_tB9D4295827BD2EEDEF0749200C6CA7090C742A9D
{
	// UnityEngine.Material UnityEngine.UI.Graphic::m_Material
	Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* ___m_Material_6;
	// UnityEngine.Color UnityEngine.UI.Graphic::m_Color
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___m_Color_7;
	// System.Boolean UnityEngine.UI.Graphic::m_SkipLayoutUpdate
	bool ___m_SkipLayoutUpdate_8;
	// System.Boolean UnityEngine.UI.Graphic::m_SkipMaterialUpdate
	bool ___m_SkipMaterialUpdate_9;
	// System.Boolean UnityEngine.UI.Graphic::m_RaycastTarget
	bool ___m_RaycastTarget_10;
	// System.Boolean UnityEngine.UI.Graphic::m_RaycastTargetCache
	bool ___m_RaycastTargetCache_11;
	// UnityEngine.Vector4 UnityEngine.UI.Graphic::m_RaycastPadding
	Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 ___m_RaycastPadding_12;
	// UnityEngine.RectTransform UnityEngine.UI.Graphic::m_RectTransform
	RectTransform_t6C5DA5E41A89E0F488B001E45E58963480E543A5* ___m_RectTransform_13;
	// UnityEngine.CanvasRenderer UnityEngine.UI.Graphic::m_CanvasRenderer
	CanvasRenderer_tAB9A55A976C4E3B2B37D0CE5616E5685A8B43860* ___m_CanvasRenderer_14;
	// UnityEngine.Canvas UnityEngine.UI.Graphic::m_Canvas
	Canvas_t2DB4CEFDFF732884866C83F11ABF75F5AE8FFB26* ___m_Canvas_15;
	// System.Boolean UnityEngine.UI.Graphic::m_VertsDirty
	bool ___m_VertsDirty_16;
	// System.Boolean UnityEngine.UI.Graphic::m_MaterialDirty
	bool ___m_MaterialDirty_17;
	// UnityEngine.Events.UnityAction UnityEngine.UI.Graphic::m_OnDirtyLayoutCallback
	UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7* ___m_OnDirtyLayoutCallback_18;
	// UnityEngine.Events.UnityAction UnityEngine.UI.Graphic::m_OnDirtyVertsCallback
	UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7* ___m_OnDirtyVertsCallback_19;
	// UnityEngine.Events.UnityAction UnityEngine.UI.Graphic::m_OnDirtyMaterialCallback
	UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7* ___m_OnDirtyMaterialCallback_20;
	// UnityEngine.Mesh UnityEngine.UI.Graphic::m_CachedMesh
	Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* ___m_CachedMesh_23;
	// UnityEngine.Vector2[] UnityEngine.UI.Graphic::m_CachedUvs
	Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* ___m_CachedUvs_24;
	// UnityEngine.UI.CoroutineTween.TweenRunner`1<UnityEngine.UI.CoroutineTween.ColorTween> UnityEngine.UI.Graphic::m_ColorTweenRunner
	TweenRunner_1_t5BB0582F926E75E2FE795492679A6CF55A4B4BC4* ___m_ColorTweenRunner_25;
	// System.Boolean UnityEngine.UI.Graphic::<useLegacyMeshGeneration>k__BackingField
	bool ___U3CuseLegacyMeshGenerationU3Ek__BackingField_26;
};

// Keyboard.LetterKey
struct LetterKey_tE8293A64AC9C3DB2D3C25A5F73BA0F931E763D49  : public Key_tB9DA6A9816AEA58ACE1AE6EA33755EAEEBAC8970
{
	// System.String Keyboard.LetterKey::character
	String_t* ___character_7;
	// TMPro.TextMeshProUGUI Keyboard.LetterKey::buttonText
	TextMeshProUGUI_t101091AF4B578BB534C92E9D1EEAF0611636D957* ___buttonText_8;
};

// UnityEngine.UI.Selectable
struct Selectable_t3251808068A17B8E92FB33590A4C2FA66D456712  : public UIBehaviour_tB9D4295827BD2EEDEF0749200C6CA7090C742A9D
{
	// System.Boolean UnityEngine.UI.Selectable::m_EnableCalled
	bool ___m_EnableCalled_6;
	// UnityEngine.UI.Navigation UnityEngine.UI.Selectable::m_Navigation
	Navigation_t4D2E201D65749CF4E104E8AC1232CF1D6F14795C ___m_Navigation_7;
	// UnityEngine.UI.Selectable/Transition UnityEngine.UI.Selectable::m_Transition
	int32_t ___m_Transition_8;
	// UnityEngine.UI.ColorBlock UnityEngine.UI.Selectable::m_Colors
	ColorBlock_tDD7C62E7AFE442652FC98F8D058CE8AE6BFD7C11 ___m_Colors_9;
	// UnityEngine.UI.SpriteState UnityEngine.UI.Selectable::m_SpriteState
	SpriteState_tC8199570BE6337FB5C49347C97892B4222E5AACD ___m_SpriteState_10;
	// UnityEngine.UI.AnimationTriggers UnityEngine.UI.Selectable::m_AnimationTriggers
	AnimationTriggers_tA0DC06F89C5280C6DD972F6F4C8A56D7F4F79074* ___m_AnimationTriggers_11;
	// System.Boolean UnityEngine.UI.Selectable::m_Interactable
	bool ___m_Interactable_12;
	// UnityEngine.UI.Graphic UnityEngine.UI.Selectable::m_TargetGraphic
	Graphic_tCBFCA4585A19E2B75465AECFEAC43F4016BF7931* ___m_TargetGraphic_13;
	// System.Boolean UnityEngine.UI.Selectable::m_GroupsAllowInteraction
	bool ___m_GroupsAllowInteraction_14;
	// System.Int32 UnityEngine.UI.Selectable::m_CurrentIndex
	int32_t ___m_CurrentIndex_15;
	// System.Boolean UnityEngine.UI.Selectable::<isPointerInside>k__BackingField
	bool ___U3CisPointerInsideU3Ek__BackingField_16;
	// System.Boolean UnityEngine.UI.Selectable::<isPointerDown>k__BackingField
	bool ___U3CisPointerDownU3Ek__BackingField_17;
	// System.Boolean UnityEngine.UI.Selectable::<hasSelection>k__BackingField
	bool ___U3ChasSelectionU3Ek__BackingField_18;
	// System.Collections.Generic.List`1<UnityEngine.CanvasGroup> UnityEngine.UI.Selectable::m_CanvasGroupCache
	List_1_t2CDCA768E7F493F5EDEBC75AEB200FD621354E35* ___m_CanvasGroupCache_19;
};

// UnityEngine.UI.Button
struct Button_t6786514A57F7AFDEE5431112FEA0CAB24F5AE098  : public Selectable_t3251808068A17B8E92FB33590A4C2FA66D456712
{
	// UnityEngine.UI.Button/ButtonClickedEvent UnityEngine.UI.Button::m_OnClick
	ButtonClickedEvent_t8EA72E90B3BD1392FB3B3EF167D5121C23569E4C* ___m_OnClick_20;
};

// UnityEngine.UI.MaskableGraphic
struct MaskableGraphic_tFC5B6BE351C90DE53744DF2A70940242774B361E  : public Graphic_tCBFCA4585A19E2B75465AECFEAC43F4016BF7931
{
	// System.Boolean UnityEngine.UI.MaskableGraphic::m_ShouldRecalculateStencil
	bool ___m_ShouldRecalculateStencil_27;
	// UnityEngine.Material UnityEngine.UI.MaskableGraphic::m_MaskMaterial
	Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* ___m_MaskMaterial_28;
	// UnityEngine.UI.RectMask2D UnityEngine.UI.MaskableGraphic::m_ParentMask
	RectMask2D_tACF92BE999C791A665BD1ADEABF5BCEB82846670* ___m_ParentMask_29;
	// System.Boolean UnityEngine.UI.MaskableGraphic::m_Maskable
	bool ___m_Maskable_30;
	// System.Boolean UnityEngine.UI.MaskableGraphic::m_IsMaskingGraphic
	bool ___m_IsMaskingGraphic_31;
	// System.Boolean UnityEngine.UI.MaskableGraphic::m_IncludeForMasking
	bool ___m_IncludeForMasking_32;
	// UnityEngine.UI.MaskableGraphic/CullStateChangedEvent UnityEngine.UI.MaskableGraphic::m_OnCullStateChanged
	CullStateChangedEvent_t6073CD0D951EC1256BF74B8F9107D68FC89B99B8* ___m_OnCullStateChanged_33;
	// System.Boolean UnityEngine.UI.MaskableGraphic::m_ShouldRecalculate
	bool ___m_ShouldRecalculate_34;
	// System.Int32 UnityEngine.UI.MaskableGraphic::m_StencilValue
	int32_t ___m_StencilValue_35;
	// UnityEngine.Vector3[] UnityEngine.UI.MaskableGraphic::m_Corners
	Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* ___m_Corners_36;
};

// TMPro.TMP_InputField
struct TMP_InputField_t3488E0EE8C3DF56C6A328EC95D1BEEA2DF4A7D5F  : public Selectable_t3251808068A17B8E92FB33590A4C2FA66D456712
{
	// UnityEngine.TouchScreenKeyboard TMPro.TMP_InputField::m_SoftKeyboard
	TouchScreenKeyboard_tE87B78A3DAED69816B44C99270A734682E093E7A* ___m_SoftKeyboard_20;
	// UnityEngine.RectTransform TMPro.TMP_InputField::m_RectTransform
	RectTransform_t6C5DA5E41A89E0F488B001E45E58963480E543A5* ___m_RectTransform_22;
	// UnityEngine.RectTransform TMPro.TMP_InputField::m_TextViewport
	RectTransform_t6C5DA5E41A89E0F488B001E45E58963480E543A5* ___m_TextViewport_23;
	// UnityEngine.UI.RectMask2D TMPro.TMP_InputField::m_TextComponentRectMask
	RectMask2D_tACF92BE999C791A665BD1ADEABF5BCEB82846670* ___m_TextComponentRectMask_24;
	// UnityEngine.UI.RectMask2D TMPro.TMP_InputField::m_TextViewportRectMask
	RectMask2D_tACF92BE999C791A665BD1ADEABF5BCEB82846670* ___m_TextViewportRectMask_25;
	// UnityEngine.Rect TMPro.TMP_InputField::m_CachedViewportRect
	Rect_tA04E0F8A1830E767F40FB27ECD8D309303571F0D ___m_CachedViewportRect_26;
	// TMPro.TMP_Text TMPro.TMP_InputField::m_TextComponent
	TMP_Text_tE8D677872D43AD4B2AAF0D6101692A17D0B251A9* ___m_TextComponent_27;
	// UnityEngine.RectTransform TMPro.TMP_InputField::m_TextComponentRectTransform
	RectTransform_t6C5DA5E41A89E0F488B001E45E58963480E543A5* ___m_TextComponentRectTransform_28;
	// UnityEngine.UI.Graphic TMPro.TMP_InputField::m_Placeholder
	Graphic_tCBFCA4585A19E2B75465AECFEAC43F4016BF7931* ___m_Placeholder_29;
	// UnityEngine.UI.Scrollbar TMPro.TMP_InputField::m_VerticalScrollbar
	Scrollbar_t7CDC9B956698D9385A11E4C12964CD51477072C3* ___m_VerticalScrollbar_30;
	// TMPro.TMP_ScrollbarEventHandler TMPro.TMP_InputField::m_VerticalScrollbarEventHandler
	TMP_ScrollbarEventHandler_t84C389ED6800977DAEA8C025E18C9F3321888F4D* ___m_VerticalScrollbarEventHandler_31;
	// System.Boolean TMPro.TMP_InputField::m_IsDrivenByLayoutComponents
	bool ___m_IsDrivenByLayoutComponents_32;
	// UnityEngine.UI.LayoutGroup TMPro.TMP_InputField::m_LayoutGroup
	LayoutGroup_t32417833C700E77EDFA7C20034DAFD26604E05CE* ___m_LayoutGroup_33;
	// UnityEngine.EventSystems.IScrollHandler TMPro.TMP_InputField::m_IScrollHandlerParent
	RuntimeObject* ___m_IScrollHandlerParent_34;
	// System.Single TMPro.TMP_InputField::m_ScrollPosition
	float ___m_ScrollPosition_35;
	// System.Single TMPro.TMP_InputField::m_ScrollSensitivity
	float ___m_ScrollSensitivity_36;
	// TMPro.TMP_InputField/ContentType TMPro.TMP_InputField::m_ContentType
	int32_t ___m_ContentType_37;
	// TMPro.TMP_InputField/InputType TMPro.TMP_InputField::m_InputType
	int32_t ___m_InputType_38;
	// System.Char TMPro.TMP_InputField::m_AsteriskChar
	Il2CppChar ___m_AsteriskChar_39;
	// UnityEngine.TouchScreenKeyboardType TMPro.TMP_InputField::m_KeyboardType
	int32_t ___m_KeyboardType_40;
	// TMPro.TMP_InputField/LineType TMPro.TMP_InputField::m_LineType
	int32_t ___m_LineType_41;
	// System.Boolean TMPro.TMP_InputField::m_HideMobileInput
	bool ___m_HideMobileInput_42;
	// System.Boolean TMPro.TMP_InputField::m_HideSoftKeyboard
	bool ___m_HideSoftKeyboard_43;
	// TMPro.TMP_InputField/CharacterValidation TMPro.TMP_InputField::m_CharacterValidation
	int32_t ___m_CharacterValidation_44;
	// System.String TMPro.TMP_InputField::m_RegexValue
	String_t* ___m_RegexValue_45;
	// System.Single TMPro.TMP_InputField::m_GlobalPointSize
	float ___m_GlobalPointSize_46;
	// System.Int32 TMPro.TMP_InputField::m_CharacterLimit
	int32_t ___m_CharacterLimit_47;
	// TMPro.TMP_InputField/SubmitEvent TMPro.TMP_InputField::m_OnEndEdit
	SubmitEvent_tF7E2843B6A79D94B8EEEA259707F77BD1773B500* ___m_OnEndEdit_48;
	// TMPro.TMP_InputField/SubmitEvent TMPro.TMP_InputField::m_OnSubmit
	SubmitEvent_tF7E2843B6A79D94B8EEEA259707F77BD1773B500* ___m_OnSubmit_49;
	// TMPro.TMP_InputField/SelectionEvent TMPro.TMP_InputField::m_OnSelect
	SelectionEvent_t8FC75B869F70C9F0BF13390AD0237AD310511119* ___m_OnSelect_50;
	// TMPro.TMP_InputField/SelectionEvent TMPro.TMP_InputField::m_OnDeselect
	SelectionEvent_t8FC75B869F70C9F0BF13390AD0237AD310511119* ___m_OnDeselect_51;
	// TMPro.TMP_InputField/TextSelectionEvent TMPro.TMP_InputField::m_OnTextSelection
	TextSelectionEvent_t6C496DAA6DAF01754C27C58A94A5FBA562BA9401* ___m_OnTextSelection_52;
	// TMPro.TMP_InputField/TextSelectionEvent TMPro.TMP_InputField::m_OnEndTextSelection
	TextSelectionEvent_t6C496DAA6DAF01754C27C58A94A5FBA562BA9401* ___m_OnEndTextSelection_53;
	// TMPro.TMP_InputField/OnChangeEvent TMPro.TMP_InputField::m_OnValueChanged
	OnChangeEvent_tDBB13012ABF81899E4DFDD82258EB7E9BB7A9F1D* ___m_OnValueChanged_54;
	// TMPro.TMP_InputField/TouchScreenKeyboardEvent TMPro.TMP_InputField::m_OnTouchScreenKeyboardStatusChanged
	TouchScreenKeyboardEvent_tB9BEBEF5D6F2B52547EF3861FF437AC25BC06AF1* ___m_OnTouchScreenKeyboardStatusChanged_55;
	// TMPro.TMP_InputField/OnValidateInput TMPro.TMP_InputField::m_OnValidateInput
	OnValidateInput_t88ECDC5C12A807AF2A5761369563B0FAA6A25530* ___m_OnValidateInput_56;
	// UnityEngine.Color TMPro.TMP_InputField::m_CaretColor
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___m_CaretColor_57;
	// System.Boolean TMPro.TMP_InputField::m_CustomCaretColor
	bool ___m_CustomCaretColor_58;
	// UnityEngine.Color TMPro.TMP_InputField::m_SelectionColor
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___m_SelectionColor_59;
	// System.String TMPro.TMP_InputField::m_Text
	String_t* ___m_Text_60;
	// System.Single TMPro.TMP_InputField::m_CaretBlinkRate
	float ___m_CaretBlinkRate_61;
	// System.Int32 TMPro.TMP_InputField::m_CaretWidth
	int32_t ___m_CaretWidth_62;
	// System.Boolean TMPro.TMP_InputField::m_ReadOnly
	bool ___m_ReadOnly_63;
	// System.Boolean TMPro.TMP_InputField::m_RichText
	bool ___m_RichText_64;
	// System.Int32 TMPro.TMP_InputField::m_StringPosition
	int32_t ___m_StringPosition_65;
	// System.Int32 TMPro.TMP_InputField::m_StringSelectPosition
	int32_t ___m_StringSelectPosition_66;
	// System.Int32 TMPro.TMP_InputField::m_CaretPosition
	int32_t ___m_CaretPosition_67;
	// System.Int32 TMPro.TMP_InputField::m_CaretSelectPosition
	int32_t ___m_CaretSelectPosition_68;
	// UnityEngine.RectTransform TMPro.TMP_InputField::caretRectTrans
	RectTransform_t6C5DA5E41A89E0F488B001E45E58963480E543A5* ___caretRectTrans_69;
	// UnityEngine.UIVertex[] TMPro.TMP_InputField::m_CursorVerts
	UIVertexU5BU5D_tBC532486B45D071A520751A90E819C77BA4E3D2F* ___m_CursorVerts_70;
	// UnityEngine.CanvasRenderer TMPro.TMP_InputField::m_CachedInputRenderer
	CanvasRenderer_tAB9A55A976C4E3B2B37D0CE5616E5685A8B43860* ___m_CachedInputRenderer_71;
	// UnityEngine.Vector2 TMPro.TMP_InputField::m_LastPosition
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___m_LastPosition_72;
	// UnityEngine.Mesh TMPro.TMP_InputField::m_Mesh
	Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* ___m_Mesh_73;
	// System.Boolean TMPro.TMP_InputField::m_AllowInput
	bool ___m_AllowInput_74;
	// System.Boolean TMPro.TMP_InputField::m_ShouldActivateNextUpdate
	bool ___m_ShouldActivateNextUpdate_75;
	// System.Boolean TMPro.TMP_InputField::m_UpdateDrag
	bool ___m_UpdateDrag_76;
	// System.Boolean TMPro.TMP_InputField::m_DragPositionOutOfBounds
	bool ___m_DragPositionOutOfBounds_77;
	// System.Boolean TMPro.TMP_InputField::m_CaretVisible
	bool ___m_CaretVisible_80;
	// UnityEngine.Coroutine TMPro.TMP_InputField::m_BlinkCoroutine
	Coroutine_t85EA685566A254C23F3FD77AB5BDFFFF8799596B* ___m_BlinkCoroutine_81;
	// System.Single TMPro.TMP_InputField::m_BlinkStartTime
	float ___m_BlinkStartTime_82;
	// UnityEngine.Coroutine TMPro.TMP_InputField::m_DragCoroutine
	Coroutine_t85EA685566A254C23F3FD77AB5BDFFFF8799596B* ___m_DragCoroutine_83;
	// System.String TMPro.TMP_InputField::m_OriginalText
	String_t* ___m_OriginalText_84;
	// System.Boolean TMPro.TMP_InputField::m_WasCanceled
	bool ___m_WasCanceled_85;
	// System.Boolean TMPro.TMP_InputField::m_HasDoneFocusTransition
	bool ___m_HasDoneFocusTransition_86;
	// UnityEngine.WaitForSecondsRealtime TMPro.TMP_InputField::m_WaitForSecondsRealtime
	WaitForSecondsRealtime_tA8CE0AAB4B0C872B843E7973637037D17682BA01* ___m_WaitForSecondsRealtime_87;
	// System.Boolean TMPro.TMP_InputField::m_PreventCallback
	bool ___m_PreventCallback_88;
	// System.Boolean TMPro.TMP_InputField::m_TouchKeyboardAllowsInPlaceEditing
	bool ___m_TouchKeyboardAllowsInPlaceEditing_89;
	// System.Boolean TMPro.TMP_InputField::m_IsTextComponentUpdateRequired
	bool ___m_IsTextComponentUpdateRequired_90;
	// System.Boolean TMPro.TMP_InputField::m_isLastKeyBackspace
	bool ___m_isLastKeyBackspace_91;
	// System.Single TMPro.TMP_InputField::m_PointerDownClickStartTime
	float ___m_PointerDownClickStartTime_92;
	// System.Single TMPro.TMP_InputField::m_KeyDownStartTime
	float ___m_KeyDownStartTime_93;
	// System.Single TMPro.TMP_InputField::m_DoubleClickDelay
	float ___m_DoubleClickDelay_94;
	// System.Boolean TMPro.TMP_InputField::m_IsCompositionActive
	bool ___m_IsCompositionActive_96;
	// System.Boolean TMPro.TMP_InputField::m_ShouldUpdateIMEWindowPosition
	bool ___m_ShouldUpdateIMEWindowPosition_97;
	// System.Int32 TMPro.TMP_InputField::m_PreviousIMEInsertionLine
	int32_t ___m_PreviousIMEInsertionLine_98;
	// TMPro.TMP_FontAsset TMPro.TMP_InputField::m_GlobalFontAsset
	TMP_FontAsset_t923BF2F78D7C5AC36376E168A1193B7CB4855160* ___m_GlobalFontAsset_99;
	// System.Boolean TMPro.TMP_InputField::m_OnFocusSelectAll
	bool ___m_OnFocusSelectAll_100;
	// System.Boolean TMPro.TMP_InputField::m_isSelectAll
	bool ___m_isSelectAll_101;
	// System.Boolean TMPro.TMP_InputField::m_ResetOnDeActivation
	bool ___m_ResetOnDeActivation_102;
	// System.Boolean TMPro.TMP_InputField::m_SelectionStillActive
	bool ___m_SelectionStillActive_103;
	// System.Boolean TMPro.TMP_InputField::m_ReleaseSelection
	bool ___m_ReleaseSelection_104;
	// UnityEngine.GameObject TMPro.TMP_InputField::m_PreviouslySelectedObject
	GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* ___m_PreviouslySelectedObject_105;
	// System.Boolean TMPro.TMP_InputField::m_RestoreOriginalTextOnEscape
	bool ___m_RestoreOriginalTextOnEscape_106;
	// System.Boolean TMPro.TMP_InputField::m_isRichTextEditingAllowed
	bool ___m_isRichTextEditingAllowed_107;
	// System.Int32 TMPro.TMP_InputField::m_LineLimit
	int32_t ___m_LineLimit_108;
	// TMPro.TMP_InputValidator TMPro.TMP_InputField::m_InputValidator
	TMP_InputValidator_t3429AF61284AE19180C3FB81C0C7D2F90165EA98* ___m_InputValidator_109;
	// System.Boolean TMPro.TMP_InputField::m_isSelected
	bool ___m_isSelected_110;
	// System.Boolean TMPro.TMP_InputField::m_IsStringPositionDirty
	bool ___m_IsStringPositionDirty_111;
	// System.Boolean TMPro.TMP_InputField::m_IsCaretPositionDirty
	bool ___m_IsCaretPositionDirty_112;
	// System.Boolean TMPro.TMP_InputField::m_forceRectTransformAdjustment
	bool ___m_forceRectTransformAdjustment_113;
	// UnityEngine.Event TMPro.TMP_InputField::m_ProcessingEvent
	Event_tEBC6F24B56CE22B9C9AD1AC6C24A6B83BC3860CB* ___m_ProcessingEvent_114;
};

// UnityEngine.UI.Image
struct Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E  : public MaskableGraphic_tFC5B6BE351C90DE53744DF2A70940242774B361E
{
	// UnityEngine.Sprite UnityEngine.UI.Image::m_Sprite
	Sprite_tAFF74BC83CD68037494CB0B4F28CBDF8971CAB99* ___m_Sprite_38;
	// UnityEngine.Sprite UnityEngine.UI.Image::m_OverrideSprite
	Sprite_tAFF74BC83CD68037494CB0B4F28CBDF8971CAB99* ___m_OverrideSprite_39;
	// UnityEngine.UI.Image/Type UnityEngine.UI.Image::m_Type
	int32_t ___m_Type_40;
	// System.Boolean UnityEngine.UI.Image::m_PreserveAspect
	bool ___m_PreserveAspect_41;
	// System.Boolean UnityEngine.UI.Image::m_FillCenter
	bool ___m_FillCenter_42;
	// UnityEngine.UI.Image/FillMethod UnityEngine.UI.Image::m_FillMethod
	int32_t ___m_FillMethod_43;
	// System.Single UnityEngine.UI.Image::m_FillAmount
	float ___m_FillAmount_44;
	// System.Boolean UnityEngine.UI.Image::m_FillClockwise
	bool ___m_FillClockwise_45;
	// System.Int32 UnityEngine.UI.Image::m_FillOrigin
	int32_t ___m_FillOrigin_46;
	// System.Single UnityEngine.UI.Image::m_AlphaHitTestMinimumThreshold
	float ___m_AlphaHitTestMinimumThreshold_47;
	// System.Boolean UnityEngine.UI.Image::m_Tracked
	bool ___m_Tracked_48;
	// System.Boolean UnityEngine.UI.Image::m_UseSpriteMesh
	bool ___m_UseSpriteMesh_49;
	// System.Single UnityEngine.UI.Image::m_PixelsPerUnitMultiplier
	float ___m_PixelsPerUnitMultiplier_50;
	// System.Single UnityEngine.UI.Image::m_CachedReferencePixelsPerUnit
	float ___m_CachedReferencePixelsPerUnit_51;
};

// TMPro.TMP_Text
struct TMP_Text_tE8D677872D43AD4B2AAF0D6101692A17D0B251A9  : public MaskableGraphic_tFC5B6BE351C90DE53744DF2A70940242774B361E
{
	// System.String TMPro.TMP_Text::m_text
	String_t* ___m_text_37;
	// System.Boolean TMPro.TMP_Text::m_IsTextBackingStringDirty
	bool ___m_IsTextBackingStringDirty_38;
	// TMPro.ITextPreprocessor TMPro.TMP_Text::m_TextPreprocessor
	RuntimeObject* ___m_TextPreprocessor_39;
	// System.Boolean TMPro.TMP_Text::m_isRightToLeft
	bool ___m_isRightToLeft_40;
	// TMPro.TMP_FontAsset TMPro.TMP_Text::m_fontAsset
	TMP_FontAsset_t923BF2F78D7C5AC36376E168A1193B7CB4855160* ___m_fontAsset_41;
	// TMPro.TMP_FontAsset TMPro.TMP_Text::m_currentFontAsset
	TMP_FontAsset_t923BF2F78D7C5AC36376E168A1193B7CB4855160* ___m_currentFontAsset_42;
	// System.Boolean TMPro.TMP_Text::m_isSDFShader
	bool ___m_isSDFShader_43;
	// UnityEngine.Material TMPro.TMP_Text::m_sharedMaterial
	Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* ___m_sharedMaterial_44;
	// UnityEngine.Material TMPro.TMP_Text::m_currentMaterial
	Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* ___m_currentMaterial_45;
	// System.Int32 TMPro.TMP_Text::m_currentMaterialIndex
	int32_t ___m_currentMaterialIndex_49;
	// UnityEngine.Material[] TMPro.TMP_Text::m_fontSharedMaterials
	MaterialU5BU5D_t2B1D11C42DB07A4400C0535F92DBB87A2E346D3D* ___m_fontSharedMaterials_50;
	// UnityEngine.Material TMPro.TMP_Text::m_fontMaterial
	Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* ___m_fontMaterial_51;
	// UnityEngine.Material[] TMPro.TMP_Text::m_fontMaterials
	MaterialU5BU5D_t2B1D11C42DB07A4400C0535F92DBB87A2E346D3D* ___m_fontMaterials_52;
	// System.Boolean TMPro.TMP_Text::m_isMaterialDirty
	bool ___m_isMaterialDirty_53;
	// UnityEngine.Color32 TMPro.TMP_Text::m_fontColor32
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ___m_fontColor32_54;
	// UnityEngine.Color TMPro.TMP_Text::m_fontColor
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___m_fontColor_55;
	// UnityEngine.Color32 TMPro.TMP_Text::m_underlineColor
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ___m_underlineColor_57;
	// UnityEngine.Color32 TMPro.TMP_Text::m_strikethroughColor
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ___m_strikethroughColor_58;
	// System.Boolean TMPro.TMP_Text::m_enableVertexGradient
	bool ___m_enableVertexGradient_59;
	// TMPro.ColorMode TMPro.TMP_Text::m_colorMode
	int32_t ___m_colorMode_60;
	// TMPro.VertexGradient TMPro.TMP_Text::m_fontColorGradient
	VertexGradient_t2C057B53C0EA6E987C2B7BAB0305E686DA1C9A8F ___m_fontColorGradient_61;
	// TMPro.TMP_ColorGradient TMPro.TMP_Text::m_fontColorGradientPreset
	TMP_ColorGradient_t17B51752B4E9499A1FF7D875DCEC1D15A0F4AEBB* ___m_fontColorGradientPreset_62;
	// TMPro.TMP_SpriteAsset TMPro.TMP_Text::m_spriteAsset
	TMP_SpriteAsset_t81F779E6F705CE190DC0D1F93A954CB8B1774B39* ___m_spriteAsset_63;
	// System.Boolean TMPro.TMP_Text::m_tintAllSprites
	bool ___m_tintAllSprites_64;
	// System.Boolean TMPro.TMP_Text::m_tintSprite
	bool ___m_tintSprite_65;
	// UnityEngine.Color32 TMPro.TMP_Text::m_spriteColor
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ___m_spriteColor_66;
	// TMPro.TMP_StyleSheet TMPro.TMP_Text::m_StyleSheet
	TMP_StyleSheet_t70C71699F5CB2D855C361DBB78A44C901236C859* ___m_StyleSheet_67;
	// TMPro.TMP_Style TMPro.TMP_Text::m_TextStyle
	TMP_Style_tA9E5B1B35EBFE24EF980CEA03251B638282E120C* ___m_TextStyle_68;
	// System.Int32 TMPro.TMP_Text::m_TextStyleHashCode
	int32_t ___m_TextStyleHashCode_69;
	// System.Boolean TMPro.TMP_Text::m_overrideHtmlColors
	bool ___m_overrideHtmlColors_70;
	// UnityEngine.Color32 TMPro.TMP_Text::m_faceColor
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ___m_faceColor_71;
	// UnityEngine.Color32 TMPro.TMP_Text::m_outlineColor
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ___m_outlineColor_72;
	// System.Single TMPro.TMP_Text::m_outlineWidth
	float ___m_outlineWidth_73;
	// System.Single TMPro.TMP_Text::m_fontSize
	float ___m_fontSize_74;
	// System.Single TMPro.TMP_Text::m_currentFontSize
	float ___m_currentFontSize_75;
	// System.Single TMPro.TMP_Text::m_fontSizeBase
	float ___m_fontSizeBase_76;
	// TMPro.TMP_TextProcessingStack`1<System.Single> TMPro.TMP_Text::m_sizeStack
	TMP_TextProcessingStack_1_t138EC06BE7F101AA0A3C8D2DC951E55AACE085E9 ___m_sizeStack_77;
	// TMPro.FontWeight TMPro.TMP_Text::m_fontWeight
	int32_t ___m_fontWeight_78;
	// TMPro.FontWeight TMPro.TMP_Text::m_FontWeightInternal
	int32_t ___m_FontWeightInternal_79;
	// TMPro.TMP_TextProcessingStack`1<TMPro.FontWeight> TMPro.TMP_Text::m_FontWeightStack
	TMP_TextProcessingStack_1_tA5C8CED87DD9E73F6359E23B334FFB5B6F813FD4 ___m_FontWeightStack_80;
	// System.Boolean TMPro.TMP_Text::m_enableAutoSizing
	bool ___m_enableAutoSizing_81;
	// System.Single TMPro.TMP_Text::m_maxFontSize
	float ___m_maxFontSize_82;
	// System.Single TMPro.TMP_Text::m_minFontSize
	float ___m_minFontSize_83;
	// System.Int32 TMPro.TMP_Text::m_AutoSizeIterationCount
	int32_t ___m_AutoSizeIterationCount_84;
	// System.Int32 TMPro.TMP_Text::m_AutoSizeMaxIterationCount
	int32_t ___m_AutoSizeMaxIterationCount_85;
	// System.Boolean TMPro.TMP_Text::m_IsAutoSizePointSizeSet
	bool ___m_IsAutoSizePointSizeSet_86;
	// System.Single TMPro.TMP_Text::m_fontSizeMin
	float ___m_fontSizeMin_87;
	// System.Single TMPro.TMP_Text::m_fontSizeMax
	float ___m_fontSizeMax_88;
	// TMPro.FontStyles TMPro.TMP_Text::m_fontStyle
	int32_t ___m_fontStyle_89;
	// TMPro.FontStyles TMPro.TMP_Text::m_FontStyleInternal
	int32_t ___m_FontStyleInternal_90;
	// TMPro.TMP_FontStyleStack TMPro.TMP_Text::m_fontStyleStack
	TMP_FontStyleStack_t52885F172FADBC21346C835B5302167BDA8020DC ___m_fontStyleStack_91;
	// System.Boolean TMPro.TMP_Text::m_isUsingBold
	bool ___m_isUsingBold_92;
	// TMPro.HorizontalAlignmentOptions TMPro.TMP_Text::m_HorizontalAlignment
	int32_t ___m_HorizontalAlignment_93;
	// TMPro.VerticalAlignmentOptions TMPro.TMP_Text::m_VerticalAlignment
	int32_t ___m_VerticalAlignment_94;
	// TMPro.TextAlignmentOptions TMPro.TMP_Text::m_textAlignment
	int32_t ___m_textAlignment_95;
	// TMPro.HorizontalAlignmentOptions TMPro.TMP_Text::m_lineJustification
	int32_t ___m_lineJustification_96;
	// TMPro.TMP_TextProcessingStack`1<TMPro.HorizontalAlignmentOptions> TMPro.TMP_Text::m_lineJustificationStack
	TMP_TextProcessingStack_1_t243EA1B5D7FD2295D6533B953F0BBE8F52EFB8A0 ___m_lineJustificationStack_97;
	// UnityEngine.Vector3[] TMPro.TMP_Text::m_textContainerLocalCorners
	Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* ___m_textContainerLocalCorners_98;
	// System.Single TMPro.TMP_Text::m_characterSpacing
	float ___m_characterSpacing_99;
	// System.Single TMPro.TMP_Text::m_cSpacing
	float ___m_cSpacing_100;
	// System.Single TMPro.TMP_Text::m_monoSpacing
	float ___m_monoSpacing_101;
	// System.Single TMPro.TMP_Text::m_wordSpacing
	float ___m_wordSpacing_102;
	// System.Single TMPro.TMP_Text::m_lineSpacing
	float ___m_lineSpacing_103;
	// System.Single TMPro.TMP_Text::m_lineSpacingDelta
	float ___m_lineSpacingDelta_104;
	// System.Single TMPro.TMP_Text::m_lineHeight
	float ___m_lineHeight_105;
	// System.Boolean TMPro.TMP_Text::m_IsDrivenLineSpacing
	bool ___m_IsDrivenLineSpacing_106;
	// System.Single TMPro.TMP_Text::m_lineSpacingMax
	float ___m_lineSpacingMax_107;
	// System.Single TMPro.TMP_Text::m_paragraphSpacing
	float ___m_paragraphSpacing_108;
	// System.Single TMPro.TMP_Text::m_charWidthMaxAdj
	float ___m_charWidthMaxAdj_109;
	// System.Single TMPro.TMP_Text::m_charWidthAdjDelta
	float ___m_charWidthAdjDelta_110;
	// System.Boolean TMPro.TMP_Text::m_enableWordWrapping
	bool ___m_enableWordWrapping_111;
	// System.Boolean TMPro.TMP_Text::m_isCharacterWrappingEnabled
	bool ___m_isCharacterWrappingEnabled_112;
	// System.Boolean TMPro.TMP_Text::m_isNonBreakingSpace
	bool ___m_isNonBreakingSpace_113;
	// System.Boolean TMPro.TMP_Text::m_isIgnoringAlignment
	bool ___m_isIgnoringAlignment_114;
	// System.Single TMPro.TMP_Text::m_wordWrappingRatios
	float ___m_wordWrappingRatios_115;
	// TMPro.TextOverflowModes TMPro.TMP_Text::m_overflowMode
	int32_t ___m_overflowMode_116;
	// System.Int32 TMPro.TMP_Text::m_firstOverflowCharacterIndex
	int32_t ___m_firstOverflowCharacterIndex_117;
	// TMPro.TMP_Text TMPro.TMP_Text::m_linkedTextComponent
	TMP_Text_tE8D677872D43AD4B2AAF0D6101692A17D0B251A9* ___m_linkedTextComponent_118;
	// TMPro.TMP_Text TMPro.TMP_Text::parentLinkedComponent
	TMP_Text_tE8D677872D43AD4B2AAF0D6101692A17D0B251A9* ___parentLinkedComponent_119;
	// System.Boolean TMPro.TMP_Text::m_isTextTruncated
	bool ___m_isTextTruncated_120;
	// System.Boolean TMPro.TMP_Text::m_enableKerning
	bool ___m_enableKerning_121;
	// System.Single TMPro.TMP_Text::m_GlyphHorizontalAdvanceAdjustment
	float ___m_GlyphHorizontalAdvanceAdjustment_122;
	// System.Boolean TMPro.TMP_Text::m_enableExtraPadding
	bool ___m_enableExtraPadding_123;
	// System.Boolean TMPro.TMP_Text::checkPaddingRequired
	bool ___checkPaddingRequired_124;
	// System.Boolean TMPro.TMP_Text::m_isRichText
	bool ___m_isRichText_125;
	// System.Boolean TMPro.TMP_Text::m_parseCtrlCharacters
	bool ___m_parseCtrlCharacters_126;
	// System.Boolean TMPro.TMP_Text::m_isOverlay
	bool ___m_isOverlay_127;
	// System.Boolean TMPro.TMP_Text::m_isOrthographic
	bool ___m_isOrthographic_128;
	// System.Boolean TMPro.TMP_Text::m_isCullingEnabled
	bool ___m_isCullingEnabled_129;
	// System.Boolean TMPro.TMP_Text::m_isMaskingEnabled
	bool ___m_isMaskingEnabled_130;
	// System.Boolean TMPro.TMP_Text::isMaskUpdateRequired
	bool ___isMaskUpdateRequired_131;
	// System.Boolean TMPro.TMP_Text::m_ignoreCulling
	bool ___m_ignoreCulling_132;
	// TMPro.TextureMappingOptions TMPro.TMP_Text::m_horizontalMapping
	int32_t ___m_horizontalMapping_133;
	// TMPro.TextureMappingOptions TMPro.TMP_Text::m_verticalMapping
	int32_t ___m_verticalMapping_134;
	// System.Single TMPro.TMP_Text::m_uvLineOffset
	float ___m_uvLineOffset_135;
	// TMPro.TextRenderFlags TMPro.TMP_Text::m_renderMode
	int32_t ___m_renderMode_136;
	// TMPro.VertexSortingOrder TMPro.TMP_Text::m_geometrySortingOrder
	int32_t ___m_geometrySortingOrder_137;
	// System.Boolean TMPro.TMP_Text::m_IsTextObjectScaleStatic
	bool ___m_IsTextObjectScaleStatic_138;
	// System.Boolean TMPro.TMP_Text::m_VertexBufferAutoSizeReduction
	bool ___m_VertexBufferAutoSizeReduction_139;
	// System.Int32 TMPro.TMP_Text::m_firstVisibleCharacter
	int32_t ___m_firstVisibleCharacter_140;
	// System.Int32 TMPro.TMP_Text::m_maxVisibleCharacters
	int32_t ___m_maxVisibleCharacters_141;
	// System.Int32 TMPro.TMP_Text::m_maxVisibleWords
	int32_t ___m_maxVisibleWords_142;
	// System.Int32 TMPro.TMP_Text::m_maxVisibleLines
	int32_t ___m_maxVisibleLines_143;
	// System.Boolean TMPro.TMP_Text::m_useMaxVisibleDescender
	bool ___m_useMaxVisibleDescender_144;
	// System.Int32 TMPro.TMP_Text::m_pageToDisplay
	int32_t ___m_pageToDisplay_145;
	// System.Boolean TMPro.TMP_Text::m_isNewPage
	bool ___m_isNewPage_146;
	// UnityEngine.Vector4 TMPro.TMP_Text::m_margin
	Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 ___m_margin_147;
	// System.Single TMPro.TMP_Text::m_marginLeft
	float ___m_marginLeft_148;
	// System.Single TMPro.TMP_Text::m_marginRight
	float ___m_marginRight_149;
	// System.Single TMPro.TMP_Text::m_marginWidth
	float ___m_marginWidth_150;
	// System.Single TMPro.TMP_Text::m_marginHeight
	float ___m_marginHeight_151;
	// System.Single TMPro.TMP_Text::m_width
	float ___m_width_152;
	// TMPro.TMP_TextInfo TMPro.TMP_Text::m_textInfo
	TMP_TextInfo_t09A8E906329422C3F0C059876801DD695B8D524D* ___m_textInfo_153;
	// System.Boolean TMPro.TMP_Text::m_havePropertiesChanged
	bool ___m_havePropertiesChanged_154;
	// System.Boolean TMPro.TMP_Text::m_isUsingLegacyAnimationComponent
	bool ___m_isUsingLegacyAnimationComponent_155;
	// UnityEngine.Transform TMPro.TMP_Text::m_transform
	Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___m_transform_156;
	// UnityEngine.RectTransform TMPro.TMP_Text::m_rectTransform
	RectTransform_t6C5DA5E41A89E0F488B001E45E58963480E543A5* ___m_rectTransform_157;
	// UnityEngine.Vector2 TMPro.TMP_Text::m_PreviousRectTransformSize
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___m_PreviousRectTransformSize_158;
	// UnityEngine.Vector2 TMPro.TMP_Text::m_PreviousPivotPosition
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___m_PreviousPivotPosition_159;
	// System.Boolean TMPro.TMP_Text::<autoSizeTextContainer>k__BackingField
	bool ___U3CautoSizeTextContainerU3Ek__BackingField_160;
	// System.Boolean TMPro.TMP_Text::m_autoSizeTextContainer
	bool ___m_autoSizeTextContainer_161;
	// UnityEngine.Mesh TMPro.TMP_Text::m_mesh
	Mesh_t6D9C539763A09BC2B12AEAEF36F6DFFC98AE63D4* ___m_mesh_162;
	// System.Boolean TMPro.TMP_Text::m_isVolumetricText
	bool ___m_isVolumetricText_163;
	// System.Action`1<TMPro.TMP_TextInfo> TMPro.TMP_Text::OnPreRenderText
	Action_1_tB93AB717F9D419A1BEC832FF76E74EAA32184CC1* ___OnPreRenderText_166;
	// TMPro.TMP_SpriteAnimator TMPro.TMP_Text::m_spriteAnimator
	TMP_SpriteAnimator_t2E0F016A61CA343E3222FF51E7CF0E53F9F256E4* ___m_spriteAnimator_167;
	// System.Single TMPro.TMP_Text::m_flexibleHeight
	float ___m_flexibleHeight_168;
	// System.Single TMPro.TMP_Text::m_flexibleWidth
	float ___m_flexibleWidth_169;
	// System.Single TMPro.TMP_Text::m_minWidth
	float ___m_minWidth_170;
	// System.Single TMPro.TMP_Text::m_minHeight
	float ___m_minHeight_171;
	// System.Single TMPro.TMP_Text::m_maxWidth
	float ___m_maxWidth_172;
	// System.Single TMPro.TMP_Text::m_maxHeight
	float ___m_maxHeight_173;
	// UnityEngine.UI.LayoutElement TMPro.TMP_Text::m_LayoutElement
	LayoutElement_tB1F24CC11AF4AA87015C8D8EE06D22349C5BF40A* ___m_LayoutElement_174;
	// System.Single TMPro.TMP_Text::m_preferredWidth
	float ___m_preferredWidth_175;
	// System.Single TMPro.TMP_Text::m_renderedWidth
	float ___m_renderedWidth_176;
	// System.Boolean TMPro.TMP_Text::m_isPreferredWidthDirty
	bool ___m_isPreferredWidthDirty_177;
	// System.Single TMPro.TMP_Text::m_preferredHeight
	float ___m_preferredHeight_178;
	// System.Single TMPro.TMP_Text::m_renderedHeight
	float ___m_renderedHeight_179;
	// System.Boolean TMPro.TMP_Text::m_isPreferredHeightDirty
	bool ___m_isPreferredHeightDirty_180;
	// System.Boolean TMPro.TMP_Text::m_isCalculatingPreferredValues
	bool ___m_isCalculatingPreferredValues_181;
	// System.Int32 TMPro.TMP_Text::m_layoutPriority
	int32_t ___m_layoutPriority_182;
	// System.Boolean TMPro.TMP_Text::m_isLayoutDirty
	bool ___m_isLayoutDirty_183;
	// System.Boolean TMPro.TMP_Text::m_isAwake
	bool ___m_isAwake_184;
	// System.Boolean TMPro.TMP_Text::m_isWaitingOnResourceLoad
	bool ___m_isWaitingOnResourceLoad_185;
	// TMPro.TMP_Text/TextInputSources TMPro.TMP_Text::m_inputSource
	int32_t ___m_inputSource_186;
	// System.Single TMPro.TMP_Text::m_fontScaleMultiplier
	float ___m_fontScaleMultiplier_187;
	// System.Single TMPro.TMP_Text::tag_LineIndent
	float ___tag_LineIndent_191;
	// System.Single TMPro.TMP_Text::tag_Indent
	float ___tag_Indent_192;
	// TMPro.TMP_TextProcessingStack`1<System.Single> TMPro.TMP_Text::m_indentStack
	TMP_TextProcessingStack_1_t138EC06BE7F101AA0A3C8D2DC951E55AACE085E9 ___m_indentStack_193;
	// System.Boolean TMPro.TMP_Text::tag_NoParsing
	bool ___tag_NoParsing_194;
	// System.Boolean TMPro.TMP_Text::m_isParsingText
	bool ___m_isParsingText_195;
	// UnityEngine.Matrix4x4 TMPro.TMP_Text::m_FXMatrix
	Matrix4x4_tDB70CF134A14BA38190C59AA700BCE10E2AED3E6 ___m_FXMatrix_196;
	// System.Boolean TMPro.TMP_Text::m_isFXMatrixSet
	bool ___m_isFXMatrixSet_197;
	// TMPro.TMP_Text/UnicodeChar[] TMPro.TMP_Text::m_TextProcessingArray
	UnicodeCharU5BU5D_t67F27D09F8EB28D2C42DFF16FE60054F157012F5* ___m_TextProcessingArray_198;
	// System.Int32 TMPro.TMP_Text::m_InternalTextProcessingArraySize
	int32_t ___m_InternalTextProcessingArraySize_199;
	// TMPro.TMP_CharacterInfo[] TMPro.TMP_Text::m_internalCharacterInfo
	TMP_CharacterInfoU5BU5D_t297D56FCF66DAA99D8FEA7C30F9F3926902C5B99* ___m_internalCharacterInfo_200;
	// System.Int32 TMPro.TMP_Text::m_totalCharacterCount
	int32_t ___m_totalCharacterCount_201;
	// System.Int32 TMPro.TMP_Text::m_characterCount
	int32_t ___m_characterCount_208;
	// System.Int32 TMPro.TMP_Text::m_firstCharacterOfLine
	int32_t ___m_firstCharacterOfLine_209;
	// System.Int32 TMPro.TMP_Text::m_firstVisibleCharacterOfLine
	int32_t ___m_firstVisibleCharacterOfLine_210;
	// System.Int32 TMPro.TMP_Text::m_lastCharacterOfLine
	int32_t ___m_lastCharacterOfLine_211;
	// System.Int32 TMPro.TMP_Text::m_lastVisibleCharacterOfLine
	int32_t ___m_lastVisibleCharacterOfLine_212;
	// System.Int32 TMPro.TMP_Text::m_lineNumber
	int32_t ___m_lineNumber_213;
	// System.Int32 TMPro.TMP_Text::m_lineVisibleCharacterCount
	int32_t ___m_lineVisibleCharacterCount_214;
	// System.Int32 TMPro.TMP_Text::m_pageNumber
	int32_t ___m_pageNumber_215;
	// System.Single TMPro.TMP_Text::m_PageAscender
	float ___m_PageAscender_216;
	// System.Single TMPro.TMP_Text::m_maxTextAscender
	float ___m_maxTextAscender_217;
	// System.Single TMPro.TMP_Text::m_maxCapHeight
	float ___m_maxCapHeight_218;
	// System.Single TMPro.TMP_Text::m_ElementAscender
	float ___m_ElementAscender_219;
	// System.Single TMPro.TMP_Text::m_ElementDescender
	float ___m_ElementDescender_220;
	// System.Single TMPro.TMP_Text::m_maxLineAscender
	float ___m_maxLineAscender_221;
	// System.Single TMPro.TMP_Text::m_maxLineDescender
	float ___m_maxLineDescender_222;
	// System.Single TMPro.TMP_Text::m_startOfLineAscender
	float ___m_startOfLineAscender_223;
	// System.Single TMPro.TMP_Text::m_startOfLineDescender
	float ___m_startOfLineDescender_224;
	// System.Single TMPro.TMP_Text::m_lineOffset
	float ___m_lineOffset_225;
	// TMPro.Extents TMPro.TMP_Text::m_meshExtents
	Extents_tA2D2F95811D0A18CB7AC3570D2D8F8CD3AF4C4A8 ___m_meshExtents_226;
	// UnityEngine.Color32 TMPro.TMP_Text::m_htmlColor
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ___m_htmlColor_227;
	// TMPro.TMP_TextProcessingStack`1<UnityEngine.Color32> TMPro.TMP_Text::m_colorStack
	TMP_TextProcessingStack_1_tF2CD5BE59E5EB22EA9E3EE3043A004EA918C4BB3 ___m_colorStack_228;
	// TMPro.TMP_TextProcessingStack`1<UnityEngine.Color32> TMPro.TMP_Text::m_underlineColorStack
	TMP_TextProcessingStack_1_tF2CD5BE59E5EB22EA9E3EE3043A004EA918C4BB3 ___m_underlineColorStack_229;
	// TMPro.TMP_TextProcessingStack`1<UnityEngine.Color32> TMPro.TMP_Text::m_strikethroughColorStack
	TMP_TextProcessingStack_1_tF2CD5BE59E5EB22EA9E3EE3043A004EA918C4BB3 ___m_strikethroughColorStack_230;
	// TMPro.TMP_TextProcessingStack`1<TMPro.HighlightState> TMPro.TMP_Text::m_HighlightStateStack
	TMP_TextProcessingStack_1_t57AECDCC936A7FF1D6CF66CA11560B28A675648D ___m_HighlightStateStack_231;
	// TMPro.TMP_ColorGradient TMPro.TMP_Text::m_colorGradientPreset
	TMP_ColorGradient_t17B51752B4E9499A1FF7D875DCEC1D15A0F4AEBB* ___m_colorGradientPreset_232;
	// TMPro.TMP_TextProcessingStack`1<TMPro.TMP_ColorGradient> TMPro.TMP_Text::m_colorGradientStack
	TMP_TextProcessingStack_1_tC8FAEB17246D3B171EFD11165A5761AE39B40D0C ___m_colorGradientStack_233;
	// System.Boolean TMPro.TMP_Text::m_colorGradientPresetIsTinted
	bool ___m_colorGradientPresetIsTinted_234;
	// System.Single TMPro.TMP_Text::m_tabSpacing
	float ___m_tabSpacing_235;
	// System.Single TMPro.TMP_Text::m_spacing
	float ___m_spacing_236;
	// TMPro.TMP_TextProcessingStack`1<System.Int32>[] TMPro.TMP_Text::m_TextStyleStacks
	TMP_TextProcessingStack_1U5BU5D_t08293E0BB072311BB96170F351D1083BCA97B9B2* ___m_TextStyleStacks_237;
	// System.Int32 TMPro.TMP_Text::m_TextStyleStackDepth
	int32_t ___m_TextStyleStackDepth_238;
	// TMPro.TMP_TextProcessingStack`1<System.Int32> TMPro.TMP_Text::m_ItalicAngleStack
	TMP_TextProcessingStack_1_tFBA719426D68CE1F2B5849D97AF5E5D65846290C ___m_ItalicAngleStack_239;
	// System.Int32 TMPro.TMP_Text::m_ItalicAngle
	int32_t ___m_ItalicAngle_240;
	// TMPro.TMP_TextProcessingStack`1<System.Int32> TMPro.TMP_Text::m_actionStack
	TMP_TextProcessingStack_1_tFBA719426D68CE1F2B5849D97AF5E5D65846290C ___m_actionStack_241;
	// System.Single TMPro.TMP_Text::m_padding
	float ___m_padding_242;
	// System.Single TMPro.TMP_Text::m_baselineOffset
	float ___m_baselineOffset_243;
	// TMPro.TMP_TextProcessingStack`1<System.Single> TMPro.TMP_Text::m_baselineOffsetStack
	TMP_TextProcessingStack_1_t138EC06BE7F101AA0A3C8D2DC951E55AACE085E9 ___m_baselineOffsetStack_244;
	// System.Single TMPro.TMP_Text::m_xAdvance
	float ___m_xAdvance_245;
	// TMPro.TMP_TextElementType TMPro.TMP_Text::m_textElementType
	int32_t ___m_textElementType_246;
	// TMPro.TMP_TextElement TMPro.TMP_Text::m_cached_TextElement
	TMP_TextElement_t262A55214F712D4274485ABE5676E5254B84D0A5* ___m_cached_TextElement_247;
	// TMPro.TMP_Text/SpecialCharacter TMPro.TMP_Text::m_Ellipsis
	SpecialCharacter_t6C1DBE8C490706D1620899BAB7F0B8091AD26777 ___m_Ellipsis_248;
	// TMPro.TMP_Text/SpecialCharacter TMPro.TMP_Text::m_Underline
	SpecialCharacter_t6C1DBE8C490706D1620899BAB7F0B8091AD26777 ___m_Underline_249;
	// TMPro.TMP_SpriteAsset TMPro.TMP_Text::m_defaultSpriteAsset
	TMP_SpriteAsset_t81F779E6F705CE190DC0D1F93A954CB8B1774B39* ___m_defaultSpriteAsset_250;
	// TMPro.TMP_SpriteAsset TMPro.TMP_Text::m_currentSpriteAsset
	TMP_SpriteAsset_t81F779E6F705CE190DC0D1F93A954CB8B1774B39* ___m_currentSpriteAsset_251;
	// System.Int32 TMPro.TMP_Text::m_spriteCount
	int32_t ___m_spriteCount_252;
	// System.Int32 TMPro.TMP_Text::m_spriteIndex
	int32_t ___m_spriteIndex_253;
	// System.Int32 TMPro.TMP_Text::m_spriteAnimationID
	int32_t ___m_spriteAnimationID_254;
	// System.Boolean TMPro.TMP_Text::m_ignoreActiveState
	bool ___m_ignoreActiveState_257;
	// TMPro.TMP_Text/TextBackingContainer TMPro.TMP_Text::m_TextBackingArray
	TextBackingContainer_t33D1CE628E7B26C45EDAC1D87BEF2DD22A5C6361 ___m_TextBackingArray_258;
	// System.Decimal[] TMPro.TMP_Text::k_Power
	DecimalU5BU5D_t93BA0C88FA80728F73B792EE1A5199D0C060B615* ___k_Power_259;
};

// TMPro.TextMeshProUGUI
struct TextMeshProUGUI_t101091AF4B578BB534C92E9D1EEAF0611636D957  : public TMP_Text_tE8D677872D43AD4B2AAF0D6101692A17D0B251A9
{
	// System.Boolean TMPro.TextMeshProUGUI::m_isRebuildingLayout
	bool ___m_isRebuildingLayout_266;
	// UnityEngine.Coroutine TMPro.TextMeshProUGUI::m_DelayedGraphicRebuild
	Coroutine_t85EA685566A254C23F3FD77AB5BDFFFF8799596B* ___m_DelayedGraphicRebuild_267;
	// UnityEngine.Coroutine TMPro.TextMeshProUGUI::m_DelayedMaterialRebuild
	Coroutine_t85EA685566A254C23F3FD77AB5BDFFFF8799596B* ___m_DelayedMaterialRebuild_268;
	// UnityEngine.Rect TMPro.TextMeshProUGUI::m_ClipRect
	Rect_tA04E0F8A1830E767F40FB27ECD8D309303571F0D ___m_ClipRect_269;
	// System.Boolean TMPro.TextMeshProUGUI::m_ValidRect
	bool ___m_ValidRect_270;
	// System.Action`1<TMPro.TMP_TextInfo> TMPro.TextMeshProUGUI::OnPreRenderText
	Action_1_tB93AB717F9D419A1BEC832FF76E74EAA32184CC1* ___OnPreRenderText_271;
	// System.Boolean TMPro.TextMeshProUGUI::m_hasFontAssetChanged
	bool ___m_hasFontAssetChanged_272;
	// TMPro.TMP_SubMeshUI[] TMPro.TextMeshProUGUI::m_subTextObjects
	TMP_SubMeshUIU5BU5D_tC77B263183A59A75345C26152457207EAC3BBF29* ___m_subTextObjects_273;
	// System.Single TMPro.TextMeshProUGUI::m_previousLossyScaleY
	float ___m_previousLossyScaleY_274;
	// UnityEngine.Vector3[] TMPro.TextMeshProUGUI::m_RectTransformCorners
	Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* ___m_RectTransformCorners_275;
	// UnityEngine.CanvasRenderer TMPro.TextMeshProUGUI::m_canvasRenderer
	CanvasRenderer_tAB9A55A976C4E3B2B37D0CE5616E5685A8B43860* ___m_canvasRenderer_276;
	// UnityEngine.Canvas TMPro.TextMeshProUGUI::m_canvas
	Canvas_t2DB4CEFDFF732884866C83F11ABF75F5AE8FFB26* ___m_canvas_277;
	// System.Single TMPro.TextMeshProUGUI::m_CanvasScaleFactor
	float ___m_CanvasScaleFactor_278;
	// System.Boolean TMPro.TextMeshProUGUI::m_isFirstAllocation
	bool ___m_isFirstAllocation_279;
	// System.Int32 TMPro.TextMeshProUGUI::m_max_characters
	int32_t ___m_max_characters_280;
	// UnityEngine.Material TMPro.TextMeshProUGUI::m_baseMaterial
	Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* ___m_baseMaterial_281;
	// System.Boolean TMPro.TextMeshProUGUI::m_isScrollRegionSet
	bool ___m_isScrollRegionSet_282;
	// UnityEngine.Vector4 TMPro.TextMeshProUGUI::m_maskOffset
	Vector4_t58B63D32F48C0DBF50DE2C60794C4676C80EDBE3 ___m_maskOffset_283;
	// UnityEngine.Matrix4x4 TMPro.TextMeshProUGUI::m_EnvMapMatrix
	Matrix4x4_tDB70CF134A14BA38190C59AA700BCE10E2AED3E6 ___m_EnvMapMatrix_284;
	// System.Boolean TMPro.TextMeshProUGUI::m_isRegisteredForEvents
	bool ___m_isRegisteredForEvents_285;
};

// B83.Image.BMP.BMPLoader

// B83.Image.BMP.BMPLoader

// System.IO.BinaryReader

// System.IO.BinaryReader

// Dummiesman.Extensions.ColorExtensions

// Dummiesman.Extensions.ColorExtensions

// Dummiesman.ImageLoader

// Dummiesman.ImageLoader

// Dummiesman.ImageLoaderHelper

// Dummiesman.ImageLoaderHelper

// Dummiesman.ImageUtils

// Dummiesman.ImageUtils

// SFB.StandaloneFileBrowser
struct StandaloneFileBrowser_t787EC519E2F250D5F984F7C4E41441B46C779AF6_StaticFields
{
	// SFB.IStandaloneFileBrowser SFB.StandaloneFileBrowser::_platformWrapper
	RuntimeObject* ____platformWrapper_0;
};

// SFB.StandaloneFileBrowser

// System.String
struct String_t_StaticFields
{
	// System.String System.String::Empty
	String_t* ___Empty_6;
};

// System.String

// Dummiesman.TGALoader

// Dummiesman.TGALoader

// System.Boolean
struct Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22_StaticFields
{
	// System.String System.Boolean::TrueString
	String_t* ___TrueString_5;
	// System.String System.Boolean::FalseString
	String_t* ___FalseString_6;
};

// System.Boolean

// System.Byte

// System.Byte

// System.Char
struct Char_t521A6F19B456D956AF452D926C32709DC03D6B17_StaticFields
{
	// System.Byte[] System.Char::s_categoryForLatin1
	ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___s_categoryForLatin1_3;
};

// System.Char

// UnityEngine.Color

// UnityEngine.Color

// UnityEngine.Color32

// UnityEngine.Color32

// SFB.ExtensionFilter

// SFB.ExtensionFilter

// System.Int16

// System.Int16

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

// System.Single

// System.Single

// System.IO.Stream
struct Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE_StaticFields
{
	// System.IO.Stream System.IO.Stream::Null
	Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* ___Null_1;
};

// System.IO.Stream

// System.UInt16

// System.UInt16

// System.UInt32

// System.UInt32

// UnityEngine.Events.UnityEvent

// UnityEngine.Events.UnityEvent

// System.Void

// System.Void

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=108

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=108

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=12

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=12

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=128

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=128

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=36

// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=36

// <PrivateImplementationDetails>
struct U3CPrivateImplementationDetailsU3E_t0F5473E849A5A5185A9F4C5246F0C32816C49FCA_StaticFields
{
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=36 <PrivateImplementationDetails>::27BC6E3FC0D5C256DBDD26B8A7C0D0E93E8739F13E773B651B094837DA3677DA
	__StaticArrayInitTypeSizeU3D36_tE3135E025C70F21BBD65107243EE57F8AA699792 ___27BC6E3FC0D5C256DBDD26B8A7C0D0E93E8739F13E773B651B094837DA3677DA_0;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=36 <PrivateImplementationDetails>::2A342D8825C7D2D3FD4A3BE9FA194090F6515500F7D3DE2E574490FCC04D294F
	__StaticArrayInitTypeSizeU3D36_tE3135E025C70F21BBD65107243EE57F8AA699792 ___2A342D8825C7D2D3FD4A3BE9FA194090F6515500F7D3DE2E574490FCC04D294F_1;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=108 <PrivateImplementationDetails>::406F20C0C087102DF0449D6C4E6DFBBE795237A8469E4A939B16BB110651648B
	__StaticArrayInitTypeSizeU3D108_tDB5A737F5FBCFF628DE63E7700119A4EC9A3F2F9 ___406F20C0C087102DF0449D6C4E6DFBBE795237A8469E4A939B16BB110651648B_2;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=108 <PrivateImplementationDetails>::4E4A18F8C67B90D6DAF97E41864361367BAD3560FBCF964E5CDF3DF2901FF346
	__StaticArrayInitTypeSizeU3D108_tDB5A737F5FBCFF628DE63E7700119A4EC9A3F2F9 ___4E4A18F8C67B90D6DAF97E41864361367BAD3560FBCF964E5CDF3DF2901FF346_3;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=108 <PrivateImplementationDetails>::9E8C9F8274AE5ED716FDB8DDABD8F64577819CACD9BBD7265E74977B8EEF3338
	__StaticArrayInitTypeSizeU3D108_tDB5A737F5FBCFF628DE63E7700119A4EC9A3F2F9 ___9E8C9F8274AE5ED716FDB8DDABD8F64577819CACD9BBD7265E74977B8EEF3338_4;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=108 <PrivateImplementationDetails>::C63E23066807F8303F9E9B6F6EB883A535A993C693478A358369D0CD7A9B9775
	__StaticArrayInitTypeSizeU3D108_tDB5A737F5FBCFF628DE63E7700119A4EC9A3F2F9 ___C63E23066807F8303F9E9B6F6EB883A535A993C693478A358369D0CD7A9B9775_5;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=128 <PrivateImplementationDetails>::D7E360BD116C94CDFBD37AC84F4858884EA5B86FEEE988C0B603ABAFB01FB1F0
	__StaticArrayInitTypeSizeU3D128_tF4DC60A802E7EAF26084A16B33B2CDCC817796AB ___D7E360BD116C94CDFBD37AC84F4858884EA5B86FEEE988C0B603ABAFB01FB1F0_6;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=36 <PrivateImplementationDetails>::DD4B4D5BBB78907E49DB7D20CF6591E0680FFF008944581461F66677BE268450
	__StaticArrayInitTypeSizeU3D36_tE3135E025C70F21BBD65107243EE57F8AA699792 ___DD4B4D5BBB78907E49DB7D20CF6591E0680FFF008944581461F66677BE268450_7;
	// <PrivateImplementationDetails>/__StaticArrayInitTypeSize=12 <PrivateImplementationDetails>::FD1B793E29978A5F4311BAD686BF2B7690169C2491089E61A15FC8982D982B5E
	__StaticArrayInitTypeSizeU3D12_t1BDD2193C3F925556BCD5FF35C0AC52DDB0CAB8F ___FD1B793E29978A5F4311BAD686BF2B7690169C2491089E61A15FC8982D982B5E_8;
};

// <PrivateImplementationDetails>

// B83.Image.BMP.BMPImage

// B83.Image.BMP.BMPImage

// UnityEngine.UI.ColorBlock
struct ColorBlock_tDD7C62E7AFE442652FC98F8D058CE8AE6BFD7C11_StaticFields
{
	// UnityEngine.UI.ColorBlock UnityEngine.UI.ColorBlock::defaultColorBlock
	ColorBlock_tDD7C62E7AFE442652FC98F8D058CE8AE6BFD7C11 ___defaultColorBlock_7;
};

// UnityEngine.UI.ColorBlock

// System.Delegate

// System.Delegate

// System.Exception
struct Exception_t_StaticFields
{
	// System.Object System.Exception::s_EDILock
	RuntimeObject* ___s_EDILock_0;
};

// System.Exception

// System.IO.FileStream
struct FileStream_t07C7222EE10B75F352B89B76E60820160FF10AD8_StaticFields
{
	// System.Byte[] System.IO.FileStream::buf_recycle
	ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___buf_recycle_4;
	// System.Object System.IO.FileStream::buf_recycle_lock
	RuntimeObject* ___buf_recycle_lock_5;
};

// System.IO.FileStream

// System.IO.MemoryStream

// System.IO.MemoryStream

// UnityEngine.Object
struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_StaticFields
{
	// System.Int32 UnityEngine.Object::OffsetOfInstanceIDInCPlusPlusObject
	int32_t ___OffsetOfInstanceIDInCPlusPlusObject_1;
};

// UnityEngine.Object

// UnityEngine.UI.Button/ButtonClickedEvent

// UnityEngine.UI.Button/ButtonClickedEvent

// UnityEngine.Component

// UnityEngine.Component

// UnityEngine.GameObject

// UnityEngine.GameObject

// UnityEngine.ScriptableObject

// UnityEngine.ScriptableObject

// UnityEngine.Sprite

// UnityEngine.Sprite

// UnityEngine.Texture
struct Texture_t791CBB51219779964E0E8A2ED7C1AA5F92A4A700_StaticFields
{
	// System.Int32 UnityEngine.Texture::GenerateAllMips
	int32_t ___GenerateAllMips_4;
};

// UnityEngine.Texture

// System.Action`1<System.String[]>

// System.Action`1<System.String[]>

// System.Action`1<System.String>

// System.Action`1<System.String>

// UnityEngine.Events.UnityAction`1<System.Boolean>

// UnityEngine.Events.UnityAction`1<System.Boolean>

// UnityEngine.Events.UnityAction`1<System.Object>

// UnityEngine.Events.UnityAction`1<System.Object>

// UnityEngine.Events.UnityAction`1<System.String>

// UnityEngine.Events.UnityAction`1<System.String>

// UnityEngine.Events.UnityAction`4<UnityEngine.Color,UnityEngine.Color,UnityEngine.Color,UnityEngine.Color>

// UnityEngine.Events.UnityAction`4<UnityEngine.Color,UnityEngine.Color,UnityEngine.Color,UnityEngine.Color>

// Keyboard.KeyChannel

// Keyboard.KeyChannel

// UnityEngine.Texture2D

// UnityEngine.Texture2D

// UnityEngine.Events.UnityAction

// UnityEngine.Events.UnityAction

// UnityEngine.MonoBehaviour

// UnityEngine.MonoBehaviour

// Keyboard.Key

// Keyboard.Key

// Keyboard.KeyboardManager

// Keyboard.KeyboardManager

// UnityEngine.EventSystems.EventSystem
struct EventSystem_t61C51380B105BE9D2C39C4F15B7E655659957707_StaticFields
{
	// System.Collections.Generic.List`1<UnityEngine.EventSystems.EventSystem> UnityEngine.EventSystems.EventSystem::m_EventSystems
	List_1_tF2FE88545EFEC788CAAE6C74EC2F78E937FCCAC3* ___m_EventSystems_6;
	// System.Comparison`1<UnityEngine.EventSystems.RaycastResult> UnityEngine.EventSystems.EventSystem::s_RaycastComparer
	Comparison_1_t9FCAC8C8CE160A96C5AAD2DE1D353DCE8A2FEEFC* ___s_RaycastComparer_14;
	// UnityEngine.EventSystems.EventSystem/UIToolkitOverrideConfig UnityEngine.EventSystems.EventSystem::s_UIToolkitOverride
	UIToolkitOverrideConfig_t4E6B4528E38BCA7DA72C45424634806200A50182 ___s_UIToolkitOverride_15;
};

// UnityEngine.EventSystems.EventSystem

// Keyboard.LetterKey

// Keyboard.LetterKey

// UnityEngine.UI.Selectable
struct Selectable_t3251808068A17B8E92FB33590A4C2FA66D456712_StaticFields
{
	// UnityEngine.UI.Selectable[] UnityEngine.UI.Selectable::s_Selectables
	SelectableU5BU5D_t4160E135F02A40F75A63F787D36F31FEC6FE91A9* ___s_Selectables_4;
	// System.Int32 UnityEngine.UI.Selectable::s_SelectableCount
	int32_t ___s_SelectableCount_5;
};

// UnityEngine.UI.Selectable

// UnityEngine.UI.Button

// UnityEngine.UI.Button

// TMPro.TMP_InputField
struct TMP_InputField_t3488E0EE8C3DF56C6A328EC95D1BEEA2DF4A7D5F_StaticFields
{
	// System.Char[] TMPro.TMP_InputField::kSeparators
	CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB* ___kSeparators_21;
};

// TMPro.TMP_InputField

// UnityEngine.UI.Image
struct Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E_StaticFields
{
	// UnityEngine.Material UnityEngine.UI.Image::s_ETC1DefaultUI
	Material_t18053F08F347D0DCA5E1140EC7EC4533DD8A14E3* ___s_ETC1DefaultUI_37;
	// UnityEngine.Vector2[] UnityEngine.UI.Image::s_VertScratch
	Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* ___s_VertScratch_52;
	// UnityEngine.Vector2[] UnityEngine.UI.Image::s_UVScratch
	Vector2U5BU5D_tFEBBC94BCC6C9C88277BA04047D2B3FDB6ED7FDA* ___s_UVScratch_53;
	// UnityEngine.Vector3[] UnityEngine.UI.Image::s_Xy
	Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* ___s_Xy_54;
	// UnityEngine.Vector3[] UnityEngine.UI.Image::s_Uv
	Vector3U5BU5D_tFF1859CCE176131B909E2044F76443064254679C* ___s_Uv_55;
	// System.Collections.Generic.List`1<UnityEngine.UI.Image> UnityEngine.UI.Image::m_TrackedTexturelessImages
	List_1_tE6BB71ABF15905EFA2BE92C38A2716547AEADB19* ___m_TrackedTexturelessImages_56;
	// System.Boolean UnityEngine.UI.Image::s_Initialized
	bool ___s_Initialized_57;
};

// UnityEngine.UI.Image

// TMPro.TMP_Text
struct TMP_Text_tE8D677872D43AD4B2AAF0D6101692A17D0B251A9_StaticFields
{
	// TMPro.MaterialReference[] TMPro.TMP_Text::m_materialReferences
	MaterialReferenceU5BU5D_t7491D335AB3E3E13CE9C0F5E931F396F6A02E1F2* ___m_materialReferences_46;
	// System.Collections.Generic.Dictionary`2<System.Int32,System.Int32> TMPro.TMP_Text::m_materialReferenceIndexLookup
	Dictionary_2_tABE19B9C5C52F1DE14F0D3287B2696E7D7419180* ___m_materialReferenceIndexLookup_47;
	// TMPro.TMP_TextProcessingStack`1<TMPro.MaterialReference> TMPro.TMP_Text::m_materialReferenceStack
	TMP_TextProcessingStack_1_tB03E08F69415B281A5A81138F09E49EE58402DF9 ___m_materialReferenceStack_48;
	// UnityEngine.Color32 TMPro.TMP_Text::s_colorWhite
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ___s_colorWhite_56;
	// System.Func`3<System.Int32,System.String,TMPro.TMP_FontAsset> TMPro.TMP_Text::OnFontAssetRequest
	Func_3_tC721DF8CDD07ED66A4833A19A2ED2302608C906C* ___OnFontAssetRequest_164;
	// System.Func`3<System.Int32,System.String,TMPro.TMP_SpriteAsset> TMPro.TMP_Text::OnSpriteAssetRequest
	Func_3_t6F6D9932638EA1A5A45303C6626C818C25D164E5* ___OnSpriteAssetRequest_165;
	// System.Char[] TMPro.TMP_Text::m_htmlTag
	CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB* ___m_htmlTag_188;
	// TMPro.RichTextTagAttribute[] TMPro.TMP_Text::m_xmlAttribute
	RichTextTagAttributeU5BU5D_t5816316EFD8F59DBC30B9F88E15828C564E47B6D* ___m_xmlAttribute_189;
	// System.Single[] TMPro.TMP_Text::m_attributeParameterValues
	SingleU5BU5D_t89DEFE97BCEDB5857010E79ECE0F52CF6E93B87C* ___m_attributeParameterValues_190;
	// TMPro.WordWrapState TMPro.TMP_Text::m_SavedWordWrapState
	WordWrapState_t80F67D8CAA9B1A0A3D5266521E23A9F3100EDD0A ___m_SavedWordWrapState_202;
	// TMPro.WordWrapState TMPro.TMP_Text::m_SavedLineState
	WordWrapState_t80F67D8CAA9B1A0A3D5266521E23A9F3100EDD0A ___m_SavedLineState_203;
	// TMPro.WordWrapState TMPro.TMP_Text::m_SavedEllipsisState
	WordWrapState_t80F67D8CAA9B1A0A3D5266521E23A9F3100EDD0A ___m_SavedEllipsisState_204;
	// TMPro.WordWrapState TMPro.TMP_Text::m_SavedLastValidState
	WordWrapState_t80F67D8CAA9B1A0A3D5266521E23A9F3100EDD0A ___m_SavedLastValidState_205;
	// TMPro.WordWrapState TMPro.TMP_Text::m_SavedSoftLineBreakState
	WordWrapState_t80F67D8CAA9B1A0A3D5266521E23A9F3100EDD0A ___m_SavedSoftLineBreakState_206;
	// TMPro.TMP_TextProcessingStack`1<TMPro.WordWrapState> TMPro.TMP_Text::m_EllipsisInsertionCandidateStack
	TMP_TextProcessingStack_1_t2DDA00FFC64AF6E3AFD475AB2086D16C34787E0F ___m_EllipsisInsertionCandidateStack_207;
	// Unity.Profiling.ProfilerMarker TMPro.TMP_Text::k_ParseTextMarker
	ProfilerMarker_tA256E18DA86EDBC5528CE066FC91C96EE86501AD ___k_ParseTextMarker_255;
	// Unity.Profiling.ProfilerMarker TMPro.TMP_Text::k_InsertNewLineMarker
	ProfilerMarker_tA256E18DA86EDBC5528CE066FC91C96EE86501AD ___k_InsertNewLineMarker_256;
	// UnityEngine.Vector2 TMPro.TMP_Text::k_LargePositiveVector2
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___k_LargePositiveVector2_260;
	// UnityEngine.Vector2 TMPro.TMP_Text::k_LargeNegativeVector2
	Vector2_t1FD6F485C871E832B347AB2DC8CBA08B739D8DF7 ___k_LargeNegativeVector2_261;
	// System.Single TMPro.TMP_Text::k_LargePositiveFloat
	float ___k_LargePositiveFloat_262;
	// System.Single TMPro.TMP_Text::k_LargeNegativeFloat
	float ___k_LargeNegativeFloat_263;
	// System.Int32 TMPro.TMP_Text::k_LargePositiveInt
	int32_t ___k_LargePositiveInt_264;
	// System.Int32 TMPro.TMP_Text::k_LargeNegativeInt
	int32_t ___k_LargeNegativeInt_265;
};

// TMPro.TMP_Text

// TMPro.TextMeshProUGUI
struct TextMeshProUGUI_t101091AF4B578BB534C92E9D1EEAF0611636D957_StaticFields
{
	// Unity.Profiling.ProfilerMarker TMPro.TextMeshProUGUI::k_GenerateTextMarker
	ProfilerMarker_tA256E18DA86EDBC5528CE066FC91C96EE86501AD ___k_GenerateTextMarker_286;
	// Unity.Profiling.ProfilerMarker TMPro.TextMeshProUGUI::k_SetArraySizesMarker
	ProfilerMarker_tA256E18DA86EDBC5528CE066FC91C96EE86501AD ___k_SetArraySizesMarker_287;
	// Unity.Profiling.ProfilerMarker TMPro.TextMeshProUGUI::k_GenerateTextPhaseIMarker
	ProfilerMarker_tA256E18DA86EDBC5528CE066FC91C96EE86501AD ___k_GenerateTextPhaseIMarker_288;
	// Unity.Profiling.ProfilerMarker TMPro.TextMeshProUGUI::k_ParseMarkupTextMarker
	ProfilerMarker_tA256E18DA86EDBC5528CE066FC91C96EE86501AD ___k_ParseMarkupTextMarker_289;
	// Unity.Profiling.ProfilerMarker TMPro.TextMeshProUGUI::k_CharacterLookupMarker
	ProfilerMarker_tA256E18DA86EDBC5528CE066FC91C96EE86501AD ___k_CharacterLookupMarker_290;
	// Unity.Profiling.ProfilerMarker TMPro.TextMeshProUGUI::k_HandleGPOSFeaturesMarker
	ProfilerMarker_tA256E18DA86EDBC5528CE066FC91C96EE86501AD ___k_HandleGPOSFeaturesMarker_291;
	// Unity.Profiling.ProfilerMarker TMPro.TextMeshProUGUI::k_CalculateVerticesPositionMarker
	ProfilerMarker_tA256E18DA86EDBC5528CE066FC91C96EE86501AD ___k_CalculateVerticesPositionMarker_292;
	// Unity.Profiling.ProfilerMarker TMPro.TextMeshProUGUI::k_ComputeTextMetricsMarker
	ProfilerMarker_tA256E18DA86EDBC5528CE066FC91C96EE86501AD ___k_ComputeTextMetricsMarker_293;
	// Unity.Profiling.ProfilerMarker TMPro.TextMeshProUGUI::k_HandleVisibleCharacterMarker
	ProfilerMarker_tA256E18DA86EDBC5528CE066FC91C96EE86501AD ___k_HandleVisibleCharacterMarker_294;
	// Unity.Profiling.ProfilerMarker TMPro.TextMeshProUGUI::k_HandleWhiteSpacesMarker
	ProfilerMarker_tA256E18DA86EDBC5528CE066FC91C96EE86501AD ___k_HandleWhiteSpacesMarker_295;
	// Unity.Profiling.ProfilerMarker TMPro.TextMeshProUGUI::k_HandleHorizontalLineBreakingMarker
	ProfilerMarker_tA256E18DA86EDBC5528CE066FC91C96EE86501AD ___k_HandleHorizontalLineBreakingMarker_296;
	// Unity.Profiling.ProfilerMarker TMPro.TextMeshProUGUI::k_HandleVerticalLineBreakingMarker
	ProfilerMarker_tA256E18DA86EDBC5528CE066FC91C96EE86501AD ___k_HandleVerticalLineBreakingMarker_297;
	// Unity.Profiling.ProfilerMarker TMPro.TextMeshProUGUI::k_SaveGlyphVertexDataMarker
	ProfilerMarker_tA256E18DA86EDBC5528CE066FC91C96EE86501AD ___k_SaveGlyphVertexDataMarker_298;
	// Unity.Profiling.ProfilerMarker TMPro.TextMeshProUGUI::k_ComputeCharacterAdvanceMarker
	ProfilerMarker_tA256E18DA86EDBC5528CE066FC91C96EE86501AD ___k_ComputeCharacterAdvanceMarker_299;
	// Unity.Profiling.ProfilerMarker TMPro.TextMeshProUGUI::k_HandleCarriageReturnMarker
	ProfilerMarker_tA256E18DA86EDBC5528CE066FC91C96EE86501AD ___k_HandleCarriageReturnMarker_300;
	// Unity.Profiling.ProfilerMarker TMPro.TextMeshProUGUI::k_HandleLineTerminationMarker
	ProfilerMarker_tA256E18DA86EDBC5528CE066FC91C96EE86501AD ___k_HandleLineTerminationMarker_301;
	// Unity.Profiling.ProfilerMarker TMPro.TextMeshProUGUI::k_SavePageInfoMarker
	ProfilerMarker_tA256E18DA86EDBC5528CE066FC91C96EE86501AD ___k_SavePageInfoMarker_302;
	// Unity.Profiling.ProfilerMarker TMPro.TextMeshProUGUI::k_SaveProcessingStatesMarker
	ProfilerMarker_tA256E18DA86EDBC5528CE066FC91C96EE86501AD ___k_SaveProcessingStatesMarker_303;
	// Unity.Profiling.ProfilerMarker TMPro.TextMeshProUGUI::k_GenerateTextPhaseIIMarker
	ProfilerMarker_tA256E18DA86EDBC5528CE066FC91C96EE86501AD ___k_GenerateTextPhaseIIMarker_304;
	// Unity.Profiling.ProfilerMarker TMPro.TextMeshProUGUI::k_GenerateTextPhaseIIIMarker
	ProfilerMarker_tA256E18DA86EDBC5528CE066FC91C96EE86501AD ___k_GenerateTextPhaseIIIMarker_305;
};

// TMPro.TextMeshProUGUI
#ifdef __clang__
#pragma clang diagnostic pop
#endif
// UnityEngine.Color[]
struct ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389  : public RuntimeArray
{
	ALIGN_FIELD (8) Color_tD001788D726C3A7F1379BEED0260B9591F440C1F m_Items[1];

	inline Color_tD001788D726C3A7F1379BEED0260B9591F440C1F GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Color_tD001788D726C3A7F1379BEED0260B9591F440C1F* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline Color_tD001788D726C3A7F1379BEED0260B9591F440C1F GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Color_tD001788D726C3A7F1379BEED0260B9591F440C1F* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F value)
	{
		m_Items[index] = value;
	}
};
// System.Byte[]
struct ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031  : public RuntimeArray
{
	ALIGN_FIELD (8) uint8_t m_Items[1];

	inline uint8_t GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline uint8_t* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, uint8_t value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline uint8_t GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline uint8_t* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, uint8_t value)
	{
		m_Items[index] = value;
	}
};
// System.String[]
struct StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248  : public RuntimeArray
{
	ALIGN_FIELD (8) String_t* m_Items[1];

	inline String_t* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline String_t** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, String_t* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline String_t* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline String_t** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, String_t* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};
// UnityEngine.Color32[]
struct Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259  : public RuntimeArray
{
	ALIGN_FIELD (8) Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B m_Items[1];

	inline Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B value)
	{
		m_Items[index] = value;
	}
};
// SFB.ExtensionFilter[]
struct ExtensionFilterU5BU5D_t724AA1EDDC78E2F3CC3EB4C808F408EDF52EDCFD  : public RuntimeArray
{
	ALIGN_FIELD (8) ExtensionFilter_t8E3B1120DA244D6F742247E3EF9A152C3FAE3A57 m_Items[1];

	inline ExtensionFilter_t8E3B1120DA244D6F742247E3EF9A152C3FAE3A57 GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline ExtensionFilter_t8E3B1120DA244D6F742247E3EF9A152C3FAE3A57* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, ExtensionFilter_t8E3B1120DA244D6F742247E3EF9A152C3FAE3A57 value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)&((m_Items + index)->___Name_0), (void*)NULL);
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&((m_Items + index)->___Extensions_1), (void*)NULL);
		#endif
	}
	inline ExtensionFilter_t8E3B1120DA244D6F742247E3EF9A152C3FAE3A57 GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline ExtensionFilter_t8E3B1120DA244D6F742247E3EF9A152C3FAE3A57* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, ExtensionFilter_t8E3B1120DA244D6F742247E3EF9A152C3FAE3A57 value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)&((m_Items + index)->___Name_0), (void*)NULL);
		#if IL2CPP_ENABLE_STRICT_WRITE_BARRIERS
		Il2CppCodeGenWriteBarrier((void**)&((m_Items + index)->___Extensions_1), (void*)NULL);
		#endif
	}
};


// T UnityEngine.Component::GetComponent<System.Object>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* Component_GetComponent_TisRuntimeObject_m7181F81CAEC2CF53F5D2BC79B7425C16E1F80D33_gshared (Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.Events.UnityAction`4<UnityEngine.Color,UnityEngine.Color,UnityEngine.Color,UnityEngine.Color>::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UnityAction_4__ctor_mE2C6FCF45CF8C72EE9A867DC5FEEF5B05372FFEF_gshared (UnityAction_4_t05D51CE8BEA0460D330923E761D421EF194ED9B1* __this, RuntimeObject* ___0_object, intptr_t ___1_method, const RuntimeMethod* method) ;
// System.Void UnityEngine.Events.UnityAction`1<System.Boolean>::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UnityAction_1__ctor_m11A393DB3C00474B4520978077E444DB6E4418DD_gshared (UnityAction_1_t8EC357AF4FBD2A0C4A575C4BBD0B3A81029E43A9* __this, RuntimeObject* ___0_object, intptr_t ___1_method, const RuntimeMethod* method) ;
// T UnityEngine.Component::GetComponentInChildren<System.Object>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* Component_GetComponentInChildren_TisRuntimeObject_mE483A27E876DE8E4E6901D6814837F81D7C42F65_gshared (Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.Events.UnityAction`1<System.Object>::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UnityAction_1__ctor_m0C2FC6B483B474AE9596A43EBA7FF6E85503A92A_gshared (UnityAction_1_t9C30BCD020745BF400CBACF22C6F34ADBA2DDA6A* __this, RuntimeObject* ___0_object, intptr_t ___1_method, const RuntimeMethod* method) ;
// T UnityEngine.GameObject::GetComponent<System.Object>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* GameObject_GetComponent_TisRuntimeObject_m6EAED4AA356F0F48288F67899E5958792395563B_gshared (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.Events.UnityAction`1<System.Object>::Invoke(T0)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void UnityAction_1_Invoke_m777839BF9CB9F96B081106B47202D06FB35326CA_gshared_inline (UnityAction_1_t9C30BCD020745BF400CBACF22C6F34ADBA2DDA6A* __this, RuntimeObject* ___0_arg0, const RuntimeMethod* method) ;
// System.Void UnityEngine.Events.UnityAction`4<UnityEngine.Color,UnityEngine.Color,UnityEngine.Color,UnityEngine.Color>::Invoke(T0,T1,T2,T3)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void UnityAction_4_Invoke_m9F4982DA5FB273A0BBC65D0448920E4310F21CB0_gshared_inline (UnityAction_4_t05D51CE8BEA0460D330923E761D421EF194ED9B1* __this, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___0_arg0, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___1_arg1, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___2_arg2, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___3_arg3, const RuntimeMethod* method) ;
// System.Void UnityEngine.Events.UnityAction`1<System.Boolean>::Invoke(T0)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void UnityAction_1_Invoke_mDDD7C50AEB02B2E86BCA82D46A0B32C9B8A6965B_gshared_inline (UnityAction_1_t8EC357AF4FBD2A0C4A575C4BBD0B3A81029E43A9* __this, bool ___0_arg0, const RuntimeMethod* method) ;

// UnityEngine.Color[] UnityEngine.Texture2D::GetPixels()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389* Texture2D_GetPixels_m77A00D71DF5CDC7DAA0EE66FF2C90A24C7604039 (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.Texture2D::SetPixels(UnityEngine.Color[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Texture2D_SetPixels_mAE0CDFA15FA96F840D7FFADC31405D8AF20D9073 (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* __this, ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389* ___0_colors, const RuntimeMethod* method) ;
// System.Void UnityEngine.Texture2D::Apply(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Texture2D_Apply_mCC369BCAB2D3AD3EE50EE01DA67AF227865FA2B3 (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* __this, bool ___0_updateMipmaps, const RuntimeMethod* method) ;
// System.Void B83.Image.BMP.BMPLoader::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void BMPLoader__ctor_mE1F6B7D4F696A40E6932B4B64EB677F8E5303CFA (BMPLoader_t8C88A751EA549C5D60C3E41F58F456A97D8B5C83* __this, const RuntimeMethod* method) ;
// B83.Image.BMP.BMPImage B83.Image.BMP.BMPLoader::LoadBMP(System.IO.Stream)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR BMPImage_tA6E059574F192A9BB574E7B260012D990055F05C* BMPLoader_LoadBMP_m0131F513F34E1A490D639C0F46E8E18B9DFB25B7 (BMPLoader_t8C88A751EA549C5D60C3E41F58F456A97D8B5C83* __this, Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* ___0_aData, const RuntimeMethod* method) ;
// UnityEngine.Texture2D B83.Image.BMP.BMPImage::ToTexture2D()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* BMPImage_ToTexture2D_m0E65B93ED38B9B8308E4314459DEFAB4D3277F32 (BMPImage_tA6E059574F192A9BB574E7B260012D990055F05C* __this, const RuntimeMethod* method) ;
// UnityEngine.Texture2D Dummiesman.DDSLoader::Load(System.IO.Stream)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* DDSLoader_Load_mE78B735A0481C6BC72A7A1C769B13912EA626E87 (Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* ___0_ddsStream, const RuntimeMethod* method) ;
// System.Void UnityEngine.Texture2D::.ctor(System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Texture2D__ctor_m3BA82E87442B7F69E118477069AE11101B9DF796 (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* __this, int32_t ___0_width, int32_t ___1_height, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.ImageConversion::LoadImage(UnityEngine.Texture2D,System.Byte[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool ImageConversion_LoadImage_m1797365F78319B68638DE8BB02836F8D60760041 (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* ___0_tex, ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___1_data, const RuntimeMethod* method) ;
// UnityEngine.Texture2D Dummiesman.TGALoader::Load(System.IO.Stream)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* TGALoader_Load_mFFD983DFCBF01C4B0C51AEC8829191B59E63AD20 (Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* ___0_TGAStream, const RuntimeMethod* method) ;
// System.Boolean System.IO.File::Exists(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool File_Exists_m95E329ABBE3EAD6750FE1989BBA6884457136D4A (String_t* ___0_path, const RuntimeMethod* method) ;
// System.Byte[] System.IO.File::ReadAllBytes(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* File_ReadAllBytes_m704CBBA3F130C94F5A3E0BE2A93D9E9D79DC3E24 (String_t* ___0_path, const RuntimeMethod* method) ;
// System.String System.IO.Path::GetExtension(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Path_GetExtension_m6FEAA9E14451BFD210B9D1AEC2430C813F570FE5 (String_t* ___0_path, const RuntimeMethod* method) ;
// System.String System.String::ToLower()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_ToLower_m6191ABA3DC514ED47C10BDA23FD0DDCEAE7ACFBD (String_t* __this, const RuntimeMethod* method) ;
// System.String System.IO.Path::GetFileName(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Path_GetFileName_mB1A8CE314EE250B06E3D33142315E2BD3A75D1D6 (String_t* ___0_path, const RuntimeMethod* method) ;
// System.UInt32 <PrivateImplementationDetails>::ComputeStringHash(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t U3CPrivateImplementationDetailsU3E_ComputeStringHash_m6EA1F233618497AEFF8902A5EDFA24C74E2F2876 (String_t* ___0_s, const RuntimeMethod* method) ;
// System.Boolean System.String::op_Equality(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool String_op_Equality_m030E1B219352228970A076136E455C4E568C02C1 (String_t* ___0_a, String_t* ___1_b, const RuntimeMethod* method) ;
// UnityEngine.Texture2D Dummiesman.DDSLoader::Load(System.Byte[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* DDSLoader_Load_mA93B6593C1BC710A3411B4CD9809284C43D9B1EC (ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___0_ddsBytes, const RuntimeMethod* method) ;
// UnityEngine.Texture2D Dummiesman.TGALoader::Load(System.Byte[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* TGALoader_Load_mA6CEA84E76054B05FE07E43AA47C20F76FCE20A4 (ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___0_bytes, const RuntimeMethod* method) ;
// B83.Image.BMP.BMPImage B83.Image.BMP.BMPLoader::LoadBMP(System.Byte[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR BMPImage_tA6E059574F192A9BB574E7B260012D990055F05C* BMPLoader_LoadBMP_m6A621DEC5410845DE112A71843CEA2381C3DD4BD (BMPLoader_t8C88A751EA549C5D60C3E41F58F456A97D8B5C83* __this, ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___0_aData, const RuntimeMethod* method) ;
// System.UInt16 System.BitConverter::ToUInt16(System.Byte[],System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint16_t BitConverter_ToUInt16_m1B08C19B8743A604FBC3807C22A831BD8DA5819D (ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___0_value, int32_t ___1_startIndex, const RuntimeMethod* method) ;
// System.String System.Byte::ToString()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Byte_ToString_mB80CE094B94215119578E4D796566E71D7277EE4 (uint8_t* __this, const RuntimeMethod* method) ;
// System.String System.String::Concat(System.String[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Concat_m647EBF831F54B6DF7D5AFA5FD012CF4EE7571B6A (StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* ___0_values, const RuntimeMethod* method) ;
// System.Void UnityEngine.Debug::LogError(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Debug_LogError_mB00B2B4468EF3CAF041B038D840820FB84C924B2 (RuntimeObject* ___0_message, const RuntimeMethod* method) ;
// System.Void UnityEngine.Texture2D::.ctor(System.Int32,System.Int32,UnityEngine.TextureFormat,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Texture2D__ctor_mECF60A9EC0638EC353C02C8E99B6B465D23BE917 (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* __this, int32_t ___0_width, int32_t ___1_height, int32_t ___2_textureFormat, bool ___3_mipChain, const RuntimeMethod* method) ;
// System.Void UnityEngine.Texture2D::LoadRawTextureData(System.Byte[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Texture2D_LoadRawTextureData_mB8D1DEB5FF8715A871D8043D48C9054FCFF4ED1B (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* __this, ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___0_data, const RuntimeMethod* method) ;
// System.String System.String::Concat(System.String,System.String,System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Concat_m093934F71A9B351911EE46311674ED463B180006 (String_t* ___0_str0, String_t* ___1_str1, String_t* ___2_str2, String_t* ___3_str3, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Object::op_Inequality(UnityEngine.Object,UnityEngine.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Object_op_Inequality_mD0BE578448EAA61948F25C32F8DD55AB1F778602 (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C* ___0_x, Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C* ___1_y, const RuntimeMethod* method) ;
// UnityEngine.Texture2D Dummiesman.ImageLoaderHelper::VerifyFormat(UnityEngine.Texture2D)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* ImageLoaderHelper_VerifyFormat_m4BE5205BCD52E707673B72893FFD743B07CB5383 (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* ___0_tex, const RuntimeMethod* method) ;
// System.String System.IO.Path::GetFileNameWithoutExtension(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Path_GetFileNameWithoutExtension_m2D14CCBAB9C60DC8D32C2443CCE3D34644822FAF (String_t* ___0_path, const RuntimeMethod* method) ;
// System.Void UnityEngine.Object::set_name(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object_set_name_mC79E6DC8FFD72479C90F0C4CC7F42A0FEAF5AE47 (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C* __this, String_t* ___0_value, const RuntimeMethod* method) ;
// System.Void System.Object::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2 (RuntimeObject* __this, const RuntimeMethod* method) ;
// UnityEngine.TextureFormat UnityEngine.Texture2D::get_format()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Texture2D_get_format_mE39DD922F83CA1097383309278BB6F20636A7D9D (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* __this, const RuntimeMethod* method) ;
// UnityEngine.Color32[] UnityEngine.Texture2D::GetPixels32()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* Texture2D_GetPixels32_m48230192E7543765C1A517F251D1D9BFCFB58C3D (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* __this, const RuntimeMethod* method) ;
// System.Int32 UnityEngine.Texture::get_mipmapCount()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Texture_get_mipmapCount_m9E68435BC8E30B9821525BFC8121C34A53774023 (Texture_t791CBB51219779964E0E8A2ED7C1AA5F92A4A700* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.Texture2D::SetPixels32(UnityEngine.Color32[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Texture2D_SetPixels32_m169F9873A21FB8DECA24DC1B8F06FB23D13BEE2A (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* __this, Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* ___0_colors, const RuntimeMethod* method) ;
// System.Void UnityEngine.Color32::.ctor(System.Byte,System.Byte,System.Byte,System.Byte)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Color32__ctor_mC9C6B443F0C7CA3F8B174158B2AF6F05E18EAC4E_inline (Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B* __this, uint8_t ___0_r, uint8_t ___1_g, uint8_t ___2_b, uint8_t ___3_a, const RuntimeMethod* method) ;
// System.Void Dummiesman.ImageLoaderHelper::FillPixelArray(UnityEngine.Color32[],System.Byte[],System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ImageLoaderHelper_FillPixelArray_m72B6D7E7DBBE2FFE61A038FA877217A68185A46C (Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* ___0_fillArray, ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___1_pixelData, int32_t ___2_bytesPerPixel, bool ___3_bgra, const RuntimeMethod* method) ;
// System.Int32 Dummiesman.TGALoader::GetBits(System.Byte,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t TGALoader_GetBits_m644EA9B2DA0F84A296F1779AB2E352B65383211E (uint8_t ___0_b, int32_t ___1_offset, int32_t ___2_count, const RuntimeMethod* method) ;
// UnityEngine.Color32 Dummiesman.BinaryExtensions::ReadColor32RGB(System.IO.BinaryReader)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B BinaryExtensions_ReadColor32RGB_m4E6A56048B5909CE85A0EC79B45F161FD1AAAD86 (BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158* ___0_r, const RuntimeMethod* method) ;
// UnityEngine.Color32 Dummiesman.Extensions.ColorExtensions::FlipRB(UnityEngine.Color32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ColorExtensions_FlipRB_mAE6EB26665B0643B471B17C6E9CE67D18ADC0FDD (Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ___0_color, const RuntimeMethod* method) ;
// UnityEngine.Color32 Dummiesman.BinaryExtensions::ReadColor32RGBA(System.IO.BinaryReader)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B BinaryExtensions_ReadColor32RGBA_m08B1549AF8CA5D27A28E9B2A80BFD74E94B2E92D (BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158* ___0_r, const RuntimeMethod* method) ;
// System.IO.FileStream System.IO.File::OpenRead(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR FileStream_t07C7222EE10B75F352B89B76E60820160FF10AD8* File_OpenRead_m6181B052EB0E98D2E18FAC79E7744D766BA4244C (String_t* ___0_path, const RuntimeMethod* method) ;
// System.Void System.IO.MemoryStream::.ctor(System.Byte[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MemoryStream__ctor_m662CA0D5A0004A2E3B475FE8DCD687B654870AA2 (MemoryStream_tAAED1B42172E3390584E4194308AB878E786AAC2* __this, ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___0_buffer, const RuntimeMethod* method) ;
// System.Void System.IO.BinaryReader::.ctor(System.IO.Stream)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void BinaryReader__ctor_m898732FE0DBEDD480B24F6DE45A9AC696E44CC0F (BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158* __this, Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* ___0_input, const RuntimeMethod* method) ;
// System.String System.String::Format(System.String,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Format_mA8DBB4C2516B9723C5A41E6CB1E2FAF4BBE96DD8 (String_t* ___0_format, RuntimeObject* ___1_arg0, const RuntimeMethod* method) ;
// System.Void System.Exception::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Exception__ctor_m9B2BD92CD68916245A75109105D9071C9D430E7F (Exception_t* __this, String_t* ___0_message, const RuntimeMethod* method) ;
// UnityEngine.Color32[] Dummiesman.TGALoader::LoadRawTGAData(System.IO.BinaryReader,System.Int32,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* TGALoader_LoadRawTGAData_mE8533A32EB9376821A049F17FC68B035F0CF6DA5 (BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158* ___0_r, int32_t ___1_bitDepth, int32_t ___2_width, int32_t ___3_height, const RuntimeMethod* method) ;
// UnityEngine.Color32[] Dummiesman.TGALoader::LoadRLETGAData(System.IO.BinaryReader,System.Int32,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* TGALoader_LoadRLETGAData_m697F5F83681111FDB4A4260CB501CBFB280DAEF7 (BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158* ___0_r, int32_t ___1_bitDepth, int32_t ___2_width, int32_t ___3_height, const RuntimeMethod* method) ;
// System.Void UnityEngine.Texture2D::Apply()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Texture2D_Apply_mA014182C9EE0BBF6EEE3B286854F29E50EB972DC (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.Color::.ctor(System.Single,System.Single,System.Single,System.Single)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Color__ctor_m3786F0D6E510D9CFA544523A955870BD2A514C8C_inline (Color_tD001788D726C3A7F1379BEED0260B9591F440C1F* __this, float ___0_r, float ___1_g, float ___2_b, float ___3_a, const RuntimeMethod* method) ;
// System.Void SFB.ExtensionFilter::.ctor(System.String,System.String[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ExtensionFilter__ctor_mC6B29D2340E2ABFDB631D14F82670A0B68B70373 (ExtensionFilter_t8E3B1120DA244D6F742247E3EF9A152C3FAE3A57* __this, String_t* ___0_filterName, StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* ___1_filterExtensions, const RuntimeMethod* method) ;
// System.Boolean System.String::IsNullOrEmpty(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool String_IsNullOrEmpty_mEA9E3FB005AC28FE02E69FCF95A7B8456192B478 (String_t* ___0_value, const RuntimeMethod* method) ;
// System.String[] SFB.StandaloneFileBrowser::OpenFilePanel(System.String,System.String,SFB.ExtensionFilter[],System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* StandaloneFileBrowser_OpenFilePanel_mA9A53F487A5FAB785DA5A42CB82560E113900F28 (String_t* ___0_title, String_t* ___1_directory, ExtensionFilterU5BU5D_t724AA1EDDC78E2F3CC3EB4C808F408EDF52EDCFD* ___2_extensions, bool ___3_multiselect, const RuntimeMethod* method) ;
// System.Void SFB.StandaloneFileBrowser::OpenFilePanelAsync(System.String,System.String,SFB.ExtensionFilter[],System.Boolean,System.Action`1<System.String[]>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void StandaloneFileBrowser_OpenFilePanelAsync_m4E9384D6A7E1459E8493C956E29DA2F4AD3AA4A8 (String_t* ___0_title, String_t* ___1_directory, ExtensionFilterU5BU5D_t724AA1EDDC78E2F3CC3EB4C808F408EDF52EDCFD* ___2_extensions, bool ___3_multiselect, Action_1_t5439CAB6DF93B6A7A29E473D9B2A9943E580CAF8* ___4_cb, const RuntimeMethod* method) ;
// System.String SFB.StandaloneFileBrowser::SaveFilePanel(System.String,System.String,System.String,SFB.ExtensionFilter[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* StandaloneFileBrowser_SaveFilePanel_m27DF41BF602A1712BE13DF3F7EB49A998A50B654 (String_t* ___0_title, String_t* ___1_directory, String_t* ___2_defaultName, ExtensionFilterU5BU5D_t724AA1EDDC78E2F3CC3EB4C808F408EDF52EDCFD* ___3_extensions, const RuntimeMethod* method) ;
// System.Void SFB.StandaloneFileBrowser::SaveFilePanelAsync(System.String,System.String,System.String,SFB.ExtensionFilter[],System.Action`1<System.String>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void StandaloneFileBrowser_SaveFilePanelAsync_m4DE0BB49F677327EAFE8D5F1645340FFB7EC6A08 (String_t* ___0_title, String_t* ___1_directory, String_t* ___2_defaultName, ExtensionFilterU5BU5D_t724AA1EDDC78E2F3CC3EB4C808F408EDF52EDCFD* ___3_extensions, Action_1_t3CB5D1A819C3ED3F99E9E39F890F18633253949A* ___4_cb, const RuntimeMethod* method) ;
// T UnityEngine.Component::GetComponent<UnityEngine.UI.Button>()
inline Button_t6786514A57F7AFDEE5431112FEA0CAB24F5AE098* Component_GetComponent_TisButton_t6786514A57F7AFDEE5431112FEA0CAB24F5AE098_mFF8BA4CA5D7158D1D6249559A3289E7A6DF0A2BB (Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3* __this, const RuntimeMethod* method)
{
	return ((  Button_t6786514A57F7AFDEE5431112FEA0CAB24F5AE098* (*) (Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3*, const RuntimeMethod*))Component_GetComponent_TisRuntimeObject_m7181F81CAEC2CF53F5D2BC79B7425C16E1F80D33_gshared)(__this, method);
}
// UnityEngine.UI.Button/ButtonClickedEvent UnityEngine.UI.Button::get_onClick()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR ButtonClickedEvent_t8EA72E90B3BD1392FB3B3EF167D5121C23569E4C* Button_get_onClick_m701712A7F7F000CC80D517C4510697E15722C35C_inline (Button_t6786514A57F7AFDEE5431112FEA0CAB24F5AE098* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.Events.UnityAction::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UnityAction__ctor_mC53E20D6B66E0D5688CD81B88DBB34F5A58B7131 (UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7* __this, RuntimeObject* ___0_object, intptr_t ___1_method, const RuntimeMethod* method) ;
// System.Void UnityEngine.Events.UnityEvent::AddListener(UnityEngine.Events.UnityAction)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UnityEvent_AddListener_m8AA4287C16628486B41DA41CA5E7A856A706D302 (UnityEvent_tDC2C3548799DBC91D1E3F3DE60083A66F4751977* __this, UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7* ___0_call, const RuntimeMethod* method) ;
// System.Void UnityEngine.Events.UnityAction`4<UnityEngine.Color,UnityEngine.Color,UnityEngine.Color,UnityEngine.Color>::.ctor(System.Object,System.IntPtr)
inline void UnityAction_4__ctor_mE2C6FCF45CF8C72EE9A867DC5FEEF5B05372FFEF (UnityAction_4_t05D51CE8BEA0460D330923E761D421EF194ED9B1* __this, RuntimeObject* ___0_object, intptr_t ___1_method, const RuntimeMethod* method)
{
	((  void (*) (UnityAction_4_t05D51CE8BEA0460D330923E761D421EF194ED9B1*, RuntimeObject*, intptr_t, const RuntimeMethod*))UnityAction_4__ctor_mE2C6FCF45CF8C72EE9A867DC5FEEF5B05372FFEF_gshared)(__this, ___0_object, ___1_method, method);
}
// System.Delegate System.Delegate::Combine(System.Delegate,System.Delegate)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Delegate_t* Delegate_Combine_m1F725AEF318BE6F0426863490691A6F4606E7D00 (Delegate_t* ___0_a, Delegate_t* ___1_b, const RuntimeMethod* method) ;
// System.Void UnityEngine.Events.UnityAction`1<System.Boolean>::.ctor(System.Object,System.IntPtr)
inline void UnityAction_1__ctor_m11A393DB3C00474B4520978077E444DB6E4418DD (UnityAction_1_t8EC357AF4FBD2A0C4A575C4BBD0B3A81029E43A9* __this, RuntimeObject* ___0_object, intptr_t ___1_method, const RuntimeMethod* method)
{
	((  void (*) (UnityAction_1_t8EC357AF4FBD2A0C4A575C4BBD0B3A81029E43A9*, RuntimeObject*, intptr_t, const RuntimeMethod*))UnityAction_1__ctor_m11A393DB3C00474B4520978077E444DB6E4418DD_gshared)(__this, ___0_object, ___1_method, method);
}
// System.Void UnityEngine.Events.UnityEvent::RemoveListener(UnityEngine.Events.UnityAction)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UnityEvent_RemoveListener_m0E138F5575CB4363019D3DA570E98FAD502B812C (UnityEvent_tDC2C3548799DBC91D1E3F3DE60083A66F4751977* __this, UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7* ___0_call, const RuntimeMethod* method) ;
// System.Delegate System.Delegate::Remove(System.Delegate,System.Delegate)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Delegate_t* Delegate_Remove_m8B7DD5661308FA972E23CA1CC3FC9CEB355504E3 (Delegate_t* ___0_source, Delegate_t* ___1_value, const RuntimeMethod* method) ;
// System.Void Keyboard.KeyboardManager::DeactivateShift()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void KeyboardManager_DeactivateShift_m5583AF2C623B7571D949EB0AC968DF509284F400 (KeyboardManager_t41DD8382AE61564F08C9856BE00640CCB87720FB* __this, const RuntimeMethod* method) ;
// UnityEngine.UI.ColorBlock UnityEngine.UI.Selectable::get_colors()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR ColorBlock_tDD7C62E7AFE442652FC98F8D058CE8AE6BFD7C11 Selectable_get_colors_mB53E365D02351D4B64084295C4B2A7AF2DEC4750_inline (Selectable_t3251808068A17B8E92FB33590A4C2FA66D456712* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.UI.ColorBlock::set_normalColor(UnityEngine.Color)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void ColorBlock_set_normalColor_m3EBF594F6FA2C6494ACA9FCB9B458807D85B96F8_inline (ColorBlock_tDD7C62E7AFE442652FC98F8D058CE8AE6BFD7C11* __this, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___0_value, const RuntimeMethod* method) ;
// System.Void UnityEngine.UI.ColorBlock::set_highlightedColor(UnityEngine.Color)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void ColorBlock_set_highlightedColor_m04E97DF2CCE7CAC47120D8F486E18BF62F16FF86_inline (ColorBlock_tDD7C62E7AFE442652FC98F8D058CE8AE6BFD7C11* __this, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___0_value, const RuntimeMethod* method) ;
// System.Void UnityEngine.UI.ColorBlock::set_pressedColor(UnityEngine.Color)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void ColorBlock_set_pressedColor_m644C938090857AB07C57B25FE53F6DC2BB0DD5A8_inline (ColorBlock_tDD7C62E7AFE442652FC98F8D058CE8AE6BFD7C11* __this, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___0_value, const RuntimeMethod* method) ;
// System.Void UnityEngine.UI.ColorBlock::set_selectedColor(UnityEngine.Color)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void ColorBlock_set_selectedColor_m76FEFB1148798B7A356C974CDEA3BA2E2E3C1D21_inline (ColorBlock_tDD7C62E7AFE442652FC98F8D058CE8AE6BFD7C11* __this, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___0_value, const RuntimeMethod* method) ;
// System.Void UnityEngine.UI.Selectable::set_colors(UnityEngine.UI.ColorBlock)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Selectable_set_colors_m0A49ED3ACD6647B7E5A2DA10B3D417E8FE1BE55A (Selectable_t3251808068A17B8E92FB33590A4C2FA66D456712* __this, ColorBlock_tDD7C62E7AFE442652FC98F8D058CE8AE6BFD7C11 ___0_value, const RuntimeMethod* method) ;
// System.Void UnityEngine.UI.Selectable::set_interactable(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Selectable_set_interactable_m8DD581C1AD99B2EFA8B3EE9AF69EDDF26688B492 (Selectable_t3251808068A17B8E92FB33590A4C2FA66D456712* __this, bool ___0_value, const RuntimeMethod* method) ;
// System.Void UnityEngine.MonoBehaviour::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MonoBehaviour__ctor_m592DB0105CA0BC97AA1C5F4AD27B12D68A3B7C1E (MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71* __this, const RuntimeMethod* method) ;
// System.Void Keyboard.KeyboardManager::CheckTextLength()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void KeyboardManager_CheckTextLength_m29214ABD71A9EF74FD355FDE3FC2575DF015D55B (KeyboardManager_t41DD8382AE61564F08C9856BE00640CCB87720FB* __this, const RuntimeMethod* method) ;
// T UnityEngine.Component::GetComponentInChildren<TMPro.TextMeshProUGUI>()
inline TextMeshProUGUI_t101091AF4B578BB534C92E9D1EEAF0611636D957* Component_GetComponentInChildren_TisTextMeshProUGUI_t101091AF4B578BB534C92E9D1EEAF0611636D957_m60A1B193FDBBFB3719065622DB5E0BB21CA4ABDC (Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3* __this, const RuntimeMethod* method)
{
	return ((  TextMeshProUGUI_t101091AF4B578BB534C92E9D1EEAF0611636D957* (*) (Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3*, const RuntimeMethod*))Component_GetComponentInChildren_TisRuntimeObject_mE483A27E876DE8E4E6901D6814837F81D7C42F65_gshared)(__this, method);
}
// System.Void Keyboard.KeyChannel::RaiseKeyColorsChangedEvent(UnityEngine.Color,UnityEngine.Color,UnityEngine.Color,UnityEngine.Color)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void KeyChannel_RaiseKeyColorsChangedEvent_mD1C7EE314F1390115D846C87B8E06805D5CBDC50 (KeyChannel_t928FC4C0F40F35E44A1B18D92A9B172B2B760A8A* __this, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___0_normalColor, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___1_highlightedColor, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___2_pressedColor, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___3_selectedColor, const RuntimeMethod* method) ;
// UnityEngine.GameObject UnityEngine.Component::get_gameObject()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* Component_get_gameObject_m57AEFBB14DB39EC476F740BA000E170355DE691B (Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.GameObject::SetActive(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GameObject_SetActive_m638E92E1E75E519E5B24CF150B08CA8E0CDFAB92 (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* __this, bool ___0_value, const RuntimeMethod* method) ;
// System.Void Keyboard.KeyboardManager::ActivateShift()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void KeyboardManager_ActivateShift_m4618EDB6F0C88292C071EB032A812B48ABF0AB1E (KeyboardManager_t41DD8382AE61564F08C9856BE00640CCB87720FB* __this, const RuntimeMethod* method) ;
// System.Void Keyboard.KeyboardManager::UpdateShiftButtonAppearance()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void KeyboardManager_UpdateShiftButtonAppearance_m14947FCA031715FE3843587C48002A45F7BEC128 (KeyboardManager_t41DD8382AE61564F08C9856BE00640CCB87720FB* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.Events.UnityAction`1<System.String>::.ctor(System.Object,System.IntPtr)
inline void UnityAction_1__ctor_mE6251CCFD943EB114960F556A546E2777B18AC71 (UnityAction_1_t690494F0E492A2098660E28B8EB7D71B2C69BE1B* __this, RuntimeObject* ___0_object, intptr_t ___1_method, const RuntimeMethod* method)
{
	((  void (*) (UnityAction_1_t690494F0E492A2098660E28B8EB7D71B2C69BE1B*, RuntimeObject*, intptr_t, const RuntimeMethod*))UnityAction_1__ctor_m0C2FC6B483B474AE9596A43EBA7FF6E85503A92A_gshared)(__this, ___0_object, ___1_method, method);
}
// UnityEngine.GameObject UnityEngine.EventSystems.EventSystem::get_currentSelectedGameObject()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* EventSystem_get_currentSelectedGameObject_mD606FFACF3E72755298A523CBB709535CF08C98A_inline (EventSystem_t61C51380B105BE9D2C39C4F15B7E655659957707* __this, const RuntimeMethod* method) ;
// T UnityEngine.GameObject::GetComponent<TMPro.TMP_InputField>()
inline TMP_InputField_t3488E0EE8C3DF56C6A328EC95D1BEEA2DF4A7D5F* GameObject_GetComponent_TisTMP_InputField_t3488E0EE8C3DF56C6A328EC95D1BEEA2DF4A7D5F_m6CA031C91E5D203C24D3315721B6E3910B9C8729 (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* __this, const RuntimeMethod* method)
{
	return ((  TMP_InputField_t3488E0EE8C3DF56C6A328EC95D1BEEA2DF4A7D5F* (*) (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F*, const RuntimeMethod*))GameObject_GetComponent_TisRuntimeObject_m6EAED4AA356F0F48288F67899E5958792395563B_gshared)(__this, method);
}
// System.String System.String::ToUpper()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_ToUpper_m5F499BC30C2A5F5C96248B4C3D1A3B4694748B49 (String_t* __this, const RuntimeMethod* method) ;
// System.Int32 TMPro.TMP_InputField::get_selectionAnchorPosition()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t TMP_InputField_get_selectionAnchorPosition_mAAD925C368B16EFE972C11F551A1D9DCB93B0B93 (TMP_InputField_t3488E0EE8C3DF56C6A328EC95D1BEEA2DF4A7D5F* __this, const RuntimeMethod* method) ;
// System.Int32 TMPro.TMP_InputField::get_selectionFocusPosition()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t TMP_InputField_get_selectionFocusPosition_m64C9DB19CDB18E29B7CB02DCC84B5F05ACDB473E (TMP_InputField_t3488E0EE8C3DF56C6A328EC95D1BEEA2DF4A7D5F* __this, const RuntimeMethod* method) ;
// System.Int32 UnityEngine.Mathf::Min(System.Int32,System.Int32)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t Mathf_Min_m888083F74FF5655778F0403BB5E9608BEFDEA8CB_inline (int32_t ___0_a, int32_t ___1_b, const RuntimeMethod* method) ;
// System.Int32 UnityEngine.Mathf::Max(System.Int32,System.Int32)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t Mathf_Max_m7FA442918DE37E3A00106D1F2E789D65829792B8_inline (int32_t ___0_a, int32_t ___1_b, const RuntimeMethod* method) ;
// System.String TMPro.TMP_InputField::get_text()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR String_t* TMP_InputField_get_text_mA4ACBF52435893D9DFD822A492454301740B3C6A_inline (TMP_InputField_t3488E0EE8C3DF56C6A328EC95D1BEEA2DF4A7D5F* __this, const RuntimeMethod* method) ;
// System.String System.String::Remove(System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Remove_m4D7A58E2124F8D0D8AE3EEDE74B6AD6A863ABA68 (String_t* __this, int32_t ___0_startIndex, int32_t ___1_count, const RuntimeMethod* method) ;
// System.Void TMPro.TMP_InputField::set_text(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TMP_InputField_set_text_m684E9CDA2D9E82D1C497B5E03DBE79C00584FF62 (TMP_InputField_t3488E0EE8C3DF56C6A328EC95D1BEEA2DF4A7D5F* __this, String_t* ___0_value, const RuntimeMethod* method) ;
// System.String System.String::Insert(System.Int32,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Insert_mA279E748F06514A6D0B9B680D651D6A6C6BB561A (String_t* __this, int32_t ___0_startIndex, String_t* ___1_value, const RuntimeMethod* method) ;
// System.Int32 System.String::get_Length()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t String_get_Length_m42625D67623FA5CC7A44D47425CE86FB946542D2_inline (String_t* __this, const RuntimeMethod* method) ;
// System.Void TMPro.TMP_InputField::set_selectionFocusPosition(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TMP_InputField_set_selectionFocusPosition_m862731C1A303D3778E292AB427BC1BEF4407050D (TMP_InputField_t3488E0EE8C3DF56C6A328EC95D1BEEA2DF4A7D5F* __this, int32_t ___0_value, const RuntimeMethod* method) ;
// System.Void TMPro.TMP_InputField::set_selectionAnchorPosition(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TMP_InputField_set_selectionAnchorPosition_mB6E72D94EFD7C55EAFA8F8AAC30D255935438B06 (TMP_InputField_t3488E0EE8C3DF56C6A328EC95D1BEEA2DF4A7D5F* __this, int32_t ___0_value, const RuntimeMethod* method) ;
// System.Void UnityEngine.Events.UnityEvent::Invoke()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void UnityEvent_Invoke_mFBF80D59B03C30C5FE6A06F897D954ACADE061D2 (UnityEvent_tDC2C3548799DBC91D1E3F3DE60083A66F4751977* __this, const RuntimeMethod* method) ;
// System.Void Keyboard.KeyChannel::RaiseKeysStateChangeEvent(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void KeyChannel_RaiseKeysStateChangeEvent_mE220A22E89C0F8E3D1582B7836CE764C1E69D92E (KeyChannel_t928FC4C0F40F35E44A1B18D92A9B172B2B760A8A* __this, bool ___0_enabled, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.GameObject::get_activeSelf()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool GameObject_get_activeSelf_m4F3E5240E138B66AAA080EA30759A3D0517DA368 (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* __this, const RuntimeMethod* method) ;
// System.Single UnityEngine.Time::get_time()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Time_get_time_m3A271BB1B20041144AC5B7863B71AB1F0150374B (const RuntimeMethod* method) ;
// System.Void UnityEngine.UI.Image::set_sprite(UnityEngine.Sprite)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Image_set_sprite_mC0C248340BA27AAEE56855A3FAFA0D8CA12956DE (Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* __this, Sprite_tAFF74BC83CD68037494CB0B4F28CBDF8971CAB99* ___0_value, const RuntimeMethod* method) ;
// UnityEngine.Color UnityEngine.Color::get_black()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Color_tD001788D726C3A7F1379BEED0260B9591F440C1F Color_get_black_mB50217951591A045844C61E7FF31EEE3FEF16737_inline (const RuntimeMethod* method) ;
// UnityEngine.Color UnityEngine.Color::get_yellow()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Color_tD001788D726C3A7F1379BEED0260B9591F440C1F Color_get_yellow_m66637FA14383E8D74F24AE256B577CE1D55D469F_inline (const RuntimeMethod* method) ;
// UnityEngine.Color UnityEngine.Color::get_red()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Color_tD001788D726C3A7F1379BEED0260B9591F440C1F Color_get_red_mA2E53E7173FDC97E68E335049AB0FAAEE43A844D_inline (const RuntimeMethod* method) ;
// UnityEngine.Color UnityEngine.Color::get_blue()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Color_tD001788D726C3A7F1379BEED0260B9591F440C1F Color_get_blue_mF04A26CE61D6DA3C0D8B1C4720901B1028C7AB87_inline (const RuntimeMethod* method) ;
// System.Void UnityEngine.Events.UnityAction`1<System.String>::Invoke(T0)
inline void UnityAction_1_Invoke_m98256205DDBB544C1E934EB7590AC6D6D2093BF4_inline (UnityAction_1_t690494F0E492A2098660E28B8EB7D71B2C69BE1B* __this, String_t* ___0_arg0, const RuntimeMethod* method)
{
	((  void (*) (UnityAction_1_t690494F0E492A2098660E28B8EB7D71B2C69BE1B*, String_t*, const RuntimeMethod*))UnityAction_1_Invoke_m777839BF9CB9F96B081106B47202D06FB35326CA_gshared_inline)(__this, ___0_arg0, method);
}
// System.Void UnityEngine.Events.UnityAction`4<UnityEngine.Color,UnityEngine.Color,UnityEngine.Color,UnityEngine.Color>::Invoke(T0,T1,T2,T3)
inline void UnityAction_4_Invoke_m9F4982DA5FB273A0BBC65D0448920E4310F21CB0_inline (UnityAction_4_t05D51CE8BEA0460D330923E761D421EF194ED9B1* __this, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___0_arg0, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___1_arg1, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___2_arg2, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___3_arg3, const RuntimeMethod* method)
{
	((  void (*) (UnityAction_4_t05D51CE8BEA0460D330923E761D421EF194ED9B1*, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F, const RuntimeMethod*))UnityAction_4_Invoke_m9F4982DA5FB273A0BBC65D0448920E4310F21CB0_gshared_inline)(__this, ___0_arg0, ___1_arg1, ___2_arg2, ___3_arg3, method);
}
// System.Void UnityEngine.Events.UnityAction`1<System.Boolean>::Invoke(T0)
inline void UnityAction_1_Invoke_mDDD7C50AEB02B2E86BCA82D46A0B32C9B8A6965B_inline (UnityAction_1_t8EC357AF4FBD2A0C4A575C4BBD0B3A81029E43A9* __this, bool ___0_arg0, const RuntimeMethod* method)
{
	((  void (*) (UnityAction_1_t8EC357AF4FBD2A0C4A575C4BBD0B3A81029E43A9*, bool, const RuntimeMethod*))UnityAction_1_Invoke_mDDD7C50AEB02B2E86BCA82D46A0B32C9B8A6965B_gshared_inline)(__this, ___0_arg0, method);
}
// System.Void UnityEngine.ScriptableObject::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ScriptableObject__ctor_mD037FDB0B487295EA47F79A4DB1BF1846C9087FF (ScriptableObject_tB3BFDB921A1B1795B38A5417D3B97A89A140436A* __this, const RuntimeMethod* method) ;
// System.Void Keyboard.Key::Awake()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Key_Awake_mE70A506A77B7A6BB87DB326A0B65B119767B8786 (Key_tB9DA6A9816AEA58ACE1AE6EA33755EAEEBAC8970* __this, const RuntimeMethod* method) ;
// System.Void Keyboard.LetterKey::InitializeKey()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LetterKey_InitializeKey_mF209A9417F5BC9B52B47617EB0A66DB25C878C20 (LetterKey_tE8293A64AC9C3DB2D3C25A5F73BA0F931E763D49* __this, const RuntimeMethod* method) ;
// System.Void Keyboard.Key::OnPress()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Key_OnPress_m71355FFA48E3DD2D8924B5C1B9E504B2D0EAE92C (Key_tB9DA6A9816AEA58ACE1AE6EA33755EAEEBAC8970* __this, const RuntimeMethod* method) ;
// System.Void Keyboard.KeyChannel::RaiseKeyPressedEvent(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void KeyChannel_RaiseKeyPressedEvent_m7DC25E723FD945824CF374B90363FD10A2C3FD72 (KeyChannel_t928FC4C0F40F35E44A1B18D92A9B172B2B760A8A* __this, String_t* ___0_key, const RuntimeMethod* method) ;
// System.Boolean Keyboard.KeyboardManager::IsShiftActive()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool KeyboardManager_IsShiftActive_m6751E01EFDE79B39663039847F711D4161E9C39F_inline (KeyboardManager_t41DD8382AE61564F08C9856BE00640CCB87720FB* __this, const RuntimeMethod* method) ;
// System.Boolean Keyboard.KeyboardManager::IsCapsLockActive()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool KeyboardManager_IsCapsLockActive_m84C0D99FD40D977DBC3788ABCE1EE41EA4BACDEB_inline (KeyboardManager_t41DD8382AE61564F08C9856BE00640CCB87720FB* __this, const RuntimeMethod* method) ;
// System.Void Keyboard.Key::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Key__ctor_m9C214508D172EE99713AC7F36C9B0309D9C77312 (Key_tB9DA6A9816AEA58ACE1AE6EA33755EAEEBAC8970* __this, const RuntimeMethod* method) ;
// System.Char System.String::get_Chars(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Il2CppChar String_get_Chars_mC49DF0CD2D3BE7BE97B3AD9C995BE3094F8E36D3 (String_t* __this, int32_t ___0_index, const RuntimeMethod* method) ;
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void Dummiesman.ImageLoader::SetNormalMap(UnityEngine.Texture2D&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ImageLoader_SetNormalMap_m4645AFA5DBC05E7D7F778803242F399CDF81FD39 (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4** ___0_tex, const RuntimeMethod* method) 
{
	ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389* V_0 = NULL;
	int32_t V_1 = 0;
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F V_2;
	memset((&V_2), 0, sizeof(V_2));
	{
		// Color[] pixels = tex.GetPixels();
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4** L_0 = ___0_tex;
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_1 = *((Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4**)L_0);
		NullCheck(L_1);
		ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389* L_2;
		L_2 = Texture2D_GetPixels_m77A00D71DF5CDC7DAA0EE66FF2C90A24C7604039(L_1, NULL);
		V_0 = L_2;
		// for (int i = 0; i < pixels.Length; i++)
		V_1 = 0;
		goto IL_0046;
	}

IL_000c:
	{
		// Color temp = pixels[i];
		ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389* L_3 = V_0;
		int32_t L_4 = V_1;
		NullCheck(L_3);
		int32_t L_5 = L_4;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_6 = (L_3)->GetAt(static_cast<il2cpp_array_size_t>(L_5));
		V_2 = L_6;
		// temp.r = pixels[i].g;
		ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389* L_7 = V_0;
		int32_t L_8 = V_1;
		NullCheck(L_7);
		float L_9 = ((L_7)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_8)))->___g_1;
		(&V_2)->___r_0 = L_9;
		// temp.a = pixels[i].r;
		ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389* L_10 = V_0;
		int32_t L_11 = V_1;
		NullCheck(L_10);
		float L_12 = ((L_10)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_11)))->___r_0;
		(&V_2)->___a_3 = L_12;
		// pixels[i] = temp;
		ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389* L_13 = V_0;
		int32_t L_14 = V_1;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_15 = V_2;
		NullCheck(L_13);
		(L_13)->SetAt(static_cast<il2cpp_array_size_t>(L_14), (Color_tD001788D726C3A7F1379BEED0260B9591F440C1F)L_15);
		// for (int i = 0; i < pixels.Length; i++)
		int32_t L_16 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add(L_16, 1));
	}

IL_0046:
	{
		// for (int i = 0; i < pixels.Length; i++)
		int32_t L_17 = V_1;
		ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389* L_18 = V_0;
		NullCheck(L_18);
		if ((((int32_t)L_17) < ((int32_t)((int32_t)(((RuntimeArray*)L_18)->max_length)))))
		{
			goto IL_000c;
		}
	}
	{
		// tex.SetPixels(pixels);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4** L_19 = ___0_tex;
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_20 = *((Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4**)L_19);
		ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389* L_21 = V_0;
		NullCheck(L_20);
		Texture2D_SetPixels_mAE0CDFA15FA96F840D7FFADC31405D8AF20D9073(L_20, L_21, NULL);
		// tex.Apply(true);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4** L_22 = ___0_tex;
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_23 = *((Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4**)L_22);
		NullCheck(L_23);
		Texture2D_Apply_mCC369BCAB2D3AD3EE50EE01DA67AF227865FA2B3(L_23, (bool)1, NULL);
		// }
		return;
	}
}
// UnityEngine.Texture2D Dummiesman.ImageLoader::LoadTexture(System.IO.Stream,Dummiesman.ImageLoader/TextureFormat)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* ImageLoader_LoadTexture_m05091EED446921B94BDFBA4EEDC14656D11B2D10 (Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* ___0_stream, int32_t ___1_format, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&BMPLoader_t8C88A751EA549C5D60C3E41F58F456A97D8B5C83_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ImageLoader_LoadTexture_m05091EED446921B94BDFBA4EEDC14656D11B2D10_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* V_0 = NULL;
	{
		// if (format == TextureFormat.BMP)
		int32_t L_0 = ___1_format;
		if ((!(((uint32_t)L_0) == ((uint32_t)2))))
		{
			goto IL_0015;
		}
	}
	{
		// return new BMPLoader().LoadBMP(stream).ToTexture2D();
		BMPLoader_t8C88A751EA549C5D60C3E41F58F456A97D8B5C83* L_1 = (BMPLoader_t8C88A751EA549C5D60C3E41F58F456A97D8B5C83*)il2cpp_codegen_object_new(BMPLoader_t8C88A751EA549C5D60C3E41F58F456A97D8B5C83_il2cpp_TypeInfo_var);
		NullCheck(L_1);
		BMPLoader__ctor_mE1F6B7D4F696A40E6932B4B64EB677F8E5303CFA(L_1, NULL);
		Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* L_2 = ___0_stream;
		NullCheck(L_1);
		BMPImage_tA6E059574F192A9BB574E7B260012D990055F05C* L_3;
		L_3 = BMPLoader_LoadBMP_m0131F513F34E1A490D639C0F46E8E18B9DFB25B7(L_1, L_2, NULL);
		NullCheck(L_3);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_4;
		L_4 = BMPImage_ToTexture2D_m0E65B93ED38B9B8308E4314459DEFAB4D3277F32(L_3, NULL);
		return L_4;
	}

IL_0015:
	{
		// else if (format == TextureFormat.DDS)
		int32_t L_5 = ___1_format;
		if (L_5)
		{
			goto IL_001f;
		}
	}
	{
		// return DDSLoader.Load(stream);
		Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* L_6 = ___0_stream;
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_7;
		L_7 = DDSLoader_Load_mE78B735A0481C6BC72A7A1C769B13912EA626E87(L_6, NULL);
		return L_7;
	}

IL_001f:
	{
		// else if (format == TextureFormat.JPG || format == TextureFormat.PNG)
		int32_t L_8 = ___1_format;
		if ((((int32_t)L_8) == ((int32_t)4)))
		{
			goto IL_0027;
		}
	}
	{
		int32_t L_9 = ___1_format;
		if ((!(((uint32_t)L_9) == ((uint32_t)3))))
		{
			goto IL_0054;
		}
	}

IL_0027:
	{
		// byte[] buffer = new byte[stream.Length];
		Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* L_10 = ___0_stream;
		NullCheck(L_10);
		int64_t L_11;
		L_11 = VirtualFuncInvoker0< int64_t >::Invoke(11 /* System.Int64 System.IO.Stream::get_Length() */, L_10);
		if ((int64_t)(L_11) > INTPTR_MAX) IL2CPP_RAISE_MANAGED_EXCEPTION(il2cpp_codegen_get_overflow_exception(), ImageLoader_LoadTexture_m05091EED446921B94BDFBA4EEDC14656D11B2D10_RuntimeMethod_var);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_12 = (ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031*)(ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031*)SZArrayNew(ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031_il2cpp_TypeInfo_var, (uint32_t)((intptr_t)L_11));
		V_0 = L_12;
		// stream.Read(buffer, 0, (int)stream.Length);
		Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* L_13 = ___0_stream;
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_14 = V_0;
		Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* L_15 = ___0_stream;
		NullCheck(L_15);
		int64_t L_16;
		L_16 = VirtualFuncInvoker0< int64_t >::Invoke(11 /* System.Int64 System.IO.Stream::get_Length() */, L_15);
		NullCheck(L_13);
		int32_t L_17;
		L_17 = VirtualFuncInvoker3< int32_t, ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031*, int32_t, int32_t >::Invoke(32 /* System.Int32 System.IO.Stream::Read(System.Byte[],System.Int32,System.Int32) */, L_13, L_14, 0, ((int32_t)L_16));
		// Texture2D texture = new Texture2D(1, 1);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_18 = (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4*)il2cpp_codegen_object_new(Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4_il2cpp_TypeInfo_var);
		NullCheck(L_18);
		Texture2D__ctor_m3BA82E87442B7F69E118477069AE11101B9DF796(L_18, 1, 1, NULL);
		// texture.LoadImage(buffer);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_19 = L_18;
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_20 = V_0;
		bool L_21;
		L_21 = ImageConversion_LoadImage_m1797365F78319B68638DE8BB02836F8D60760041(L_19, L_20, NULL);
		// return texture;
		return L_19;
	}

IL_0054:
	{
		// else if (format == TextureFormat.TGA)
		int32_t L_22 = ___1_format;
		if ((!(((uint32_t)L_22) == ((uint32_t)1))))
		{
			goto IL_005f;
		}
	}
	{
		// return TGALoader.Load(stream);
		Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* L_23 = ___0_stream;
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_24;
		L_24 = TGALoader_Load_mFFD983DFCBF01C4B0C51AEC8829191B59E63AD20(L_23, NULL);
		return L_24;
	}

IL_005f:
	{
		// return null;
		return (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4*)NULL;
	}
}
// UnityEngine.Texture2D Dummiesman.ImageLoader::LoadTexture(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* ImageLoader_LoadTexture_mC532488F1779882CA2E220DF8157B74B49F39DFC (String_t* ___0_fn, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&BMPLoader_t8C88A751EA549C5D60C3E41F58F456A97D8B5C83_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&BitConverter_t6E99605185963BC12B3D369E13F2B88997E64A27_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Path_t8A38A801D0219E8209C1B1D90D82D4D755D998BC_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral0FFABE86E9532C726C3E9C7D10AFE388437A380D);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral1A3E4D14FCCE4BCFFF56E01EE25543AD3912FB19);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral23DF9991B71463C240582D176E347E7E47AEFF5A);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral4B9B40AAD718882F5C0B95FE844E4AA92BD49C42);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral911FC00FE8A864A9D1B8F87A75E4EE5041ACF43B);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral985B72B30ECE05DD4EF5FE142CEE0FB8BF53A98C);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral9FB5B88DDC4C14C62E4014842DEC88E8353401A0);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralA15C898F015A9B0BC3268E8883CD03008A56DE26);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralB93D5DFE334D74396F45A6431764B0B46F089032);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralBEFAFB5DB9B504BEEF8A79E3E990D713103F15A0);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralC00413A65EA4BBDF5F981E7DC7F68313AA28D95F);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralCCC77F6BEC01F19B25AEAE1DA587DC5A6486B284);
		s_Il2CppMethodInitialized = true;
	}
	ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* V_0 = NULL;
	String_t* V_1 = NULL;
	String_t* V_2 = NULL;
	Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* V_3 = NULL;
	ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* V_4 = NULL;
	uint16_t V_5 = 0;
	uint16_t V_6 = 0;
	uint8_t V_7 = 0x0;
	int32_t V_8 = 0;
	uint32_t V_9 = 0;
	{
		// if (!File.Exists(fn))
		String_t* L_0 = ___0_fn;
		bool L_1;
		L_1 = File_Exists_m95E329ABBE3EAD6750FE1989BBA6884457136D4A(L_0, NULL);
		if (L_1)
		{
			goto IL_000a;
		}
	}
	{
		// return null;
		return (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4*)NULL;
	}

IL_000a:
	{
		// var textureBytes = File.ReadAllBytes(fn);
		String_t* L_2 = ___0_fn;
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_3;
		L_3 = File_ReadAllBytes_m704CBBA3F130C94F5A3E0BE2A93D9E9D79DC3E24(L_2, NULL);
		V_0 = L_3;
		// string ext = Path.GetExtension(fn).ToLower();
		String_t* L_4 = ___0_fn;
		il2cpp_codegen_runtime_class_init_inline(Path_t8A38A801D0219E8209C1B1D90D82D4D755D998BC_il2cpp_TypeInfo_var);
		String_t* L_5;
		L_5 = Path_GetExtension_m6FEAA9E14451BFD210B9D1AEC2430C813F570FE5(L_4, NULL);
		NullCheck(L_5);
		String_t* L_6;
		L_6 = String_ToLower_m6191ABA3DC514ED47C10BDA23FD0DDCEAE7ACFBD(L_5, NULL);
		V_1 = L_6;
		// string name = Path.GetFileName(fn);
		String_t* L_7 = ___0_fn;
		String_t* L_8;
		L_8 = Path_GetFileName_mB1A8CE314EE250B06E3D33142315E2BD3A75D1D6(L_7, NULL);
		V_2 = L_8;
		// Texture2D returnTex = null;
		V_3 = (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4*)NULL;
		String_t* L_9 = V_1;
		uint32_t L_10;
		L_10 = U3CPrivateImplementationDetailsU3E_ComputeStringHash_m6EA1F233618497AEFF8902A5EDFA24C74E2F2876(L_9, NULL);
		V_9 = L_10;
		uint32_t L_11 = V_9;
		if ((!(((uint32_t)L_11) <= ((uint32_t)((int32_t)1388056268)))))
		{
			goto IL_005a;
		}
	}
	{
		uint32_t L_12 = V_9;
		if ((((int32_t)L_12) == ((int32_t)((int32_t)175576948))))
		{
			goto IL_00ee;
		}
	}
	{
		uint32_t L_13 = V_9;
		if ((((int32_t)L_13) == ((int32_t)((int32_t)1128223456))))
		{
			goto IL_0094;
		}
	}
	{
		uint32_t L_14 = V_9;
		if ((((int32_t)L_14) == ((int32_t)((int32_t)1388056268))))
		{
			goto IL_00a6;
		}
	}
	{
		goto IL_0219;
	}

IL_005a:
	{
		uint32_t L_15 = V_9;
		if ((!(((uint32_t)L_15) <= ((uint32_t)((int32_t)-786288218)))))
		{
			goto IL_007d;
		}
	}
	{
		uint32_t L_16 = V_9;
		if ((((int32_t)L_16) == ((int32_t)((int32_t)-2079391002))))
		{
			goto IL_0100;
		}
	}
	{
		uint32_t L_17 = V_9;
		if ((((int32_t)L_17) == ((int32_t)((int32_t)-786288218))))
		{
			goto IL_00ca;
		}
	}
	{
		goto IL_0219;
	}

IL_007d:
	{
		uint32_t L_18 = V_9;
		if ((((int32_t)L_18) == ((int32_t)((int32_t)-116413041))))
		{
			goto IL_00b8;
		}
	}
	{
		uint32_t L_19 = V_9;
		if ((((int32_t)L_19) == ((int32_t)((int32_t)-9225237))))
		{
			goto IL_00dc;
		}
	}
	{
		goto IL_0219;
	}

IL_0094:
	{
		String_t* L_20 = V_1;
		bool L_21;
		L_21 = String_op_Equality_m030E1B219352228970A076136E455C4E568C02C1(L_20, _stringLiteralA15C898F015A9B0BC3268E8883CD03008A56DE26, NULL);
		if (L_21)
		{
			goto IL_0112;
		}
	}
	{
		goto IL_0219;
	}

IL_00a6:
	{
		String_t* L_22 = V_1;
		bool L_23;
		L_23 = String_op_Equality_m030E1B219352228970A076136E455C4E568C02C1(L_22, _stringLiteral23DF9991B71463C240582D176E347E7E47AEFF5A, NULL);
		if (L_23)
		{
			goto IL_0112;
		}
	}
	{
		goto IL_0219;
	}

IL_00b8:
	{
		String_t* L_24 = V_1;
		bool L_25;
		L_25 = String_op_Equality_m030E1B219352228970A076136E455C4E568C02C1(L_24, _stringLiteral4B9B40AAD718882F5C0B95FE844E4AA92BD49C42, NULL);
		if (L_25)
		{
			goto IL_0112;
		}
	}
	{
		goto IL_0219;
	}

IL_00ca:
	{
		String_t* L_26 = V_1;
		bool L_27;
		L_27 = String_op_Equality_m030E1B219352228970A076136E455C4E568C02C1(L_26, _stringLiteralB93D5DFE334D74396F45A6431764B0B46F089032, NULL);
		if (L_27)
		{
			goto IL_0127;
		}
	}
	{
		goto IL_0219;
	}

IL_00dc:
	{
		String_t* L_28 = V_1;
		bool L_29;
		L_29 = String_op_Equality_m030E1B219352228970A076136E455C4E568C02C1(L_28, _stringLiteral0FFABE86E9532C726C3E9C7D10AFE388437A380D, NULL);
		if (L_29)
		{
			goto IL_0133;
		}
	}
	{
		goto IL_0219;
	}

IL_00ee:
	{
		String_t* L_30 = V_1;
		bool L_31;
		L_31 = String_op_Equality_m030E1B219352228970A076136E455C4E568C02C1(L_30, _stringLiteral985B72B30ECE05DD4EF5FE142CEE0FB8BF53A98C, NULL);
		if (L_31)
		{
			goto IL_013f;
		}
	}
	{
		goto IL_0219;
	}

IL_0100:
	{
		String_t* L_32 = V_1;
		bool L_33;
		L_33 = String_op_Equality_m030E1B219352228970A076136E455C4E568C02C1(L_32, _stringLiteralBEFAFB5DB9B504BEEF8A79E3E990D713103F15A0, NULL);
		if (L_33)
		{
			goto IL_0155;
		}
	}
	{
		goto IL_0219;
	}

IL_0112:
	{
		// returnTex = new Texture2D(1, 1);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_34 = (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4*)il2cpp_codegen_object_new(Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4_il2cpp_TypeInfo_var);
		NullCheck(L_34);
		Texture2D__ctor_m3BA82E87442B7F69E118477069AE11101B9DF796(L_34, 1, 1, NULL);
		V_3 = L_34;
		// returnTex.LoadImage(textureBytes);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_35 = V_3;
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_36 = V_0;
		bool L_37;
		L_37 = ImageConversion_LoadImage_m1797365F78319B68638DE8BB02836F8D60760041(L_35, L_36, NULL);
		// break;
		goto IL_022f;
	}

IL_0127:
	{
		// returnTex = DDSLoader.Load(textureBytes);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_38 = V_0;
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_39;
		L_39 = DDSLoader_Load_mA93B6593C1BC710A3411B4CD9809284C43D9B1EC(L_38, NULL);
		V_3 = L_39;
		// break;
		goto IL_022f;
	}

IL_0133:
	{
		// returnTex = TGALoader.Load(textureBytes);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_40 = V_0;
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_41;
		L_41 = TGALoader_Load_mA6CEA84E76054B05FE07E43AA47C20F76FCE20A4(L_40, NULL);
		V_3 = L_41;
		// break;
		goto IL_022f;
	}

IL_013f:
	{
		// returnTex = new BMPLoader().LoadBMP(textureBytes).ToTexture2D();
		BMPLoader_t8C88A751EA549C5D60C3E41F58F456A97D8B5C83* L_42 = (BMPLoader_t8C88A751EA549C5D60C3E41F58F456A97D8B5C83*)il2cpp_codegen_object_new(BMPLoader_t8C88A751EA549C5D60C3E41F58F456A97D8B5C83_il2cpp_TypeInfo_var);
		NullCheck(L_42);
		BMPLoader__ctor_mE1F6B7D4F696A40E6932B4B64EB677F8E5303CFA(L_42, NULL);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_43 = V_0;
		NullCheck(L_42);
		BMPImage_tA6E059574F192A9BB574E7B260012D990055F05C* L_44;
		L_44 = BMPLoader_LoadBMP_m6A621DEC5410845DE112A71843CEA2381C3DD4BD(L_42, L_43, NULL);
		NullCheck(L_44);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_45;
		L_45 = BMPImage_ToTexture2D_m0E65B93ED38B9B8308E4314459DEFAB4D3277F32(L_44, NULL);
		V_3 = L_45;
		// break;
		goto IL_022f;
	}

IL_0155:
	{
		// byte[] crnBytes = textureBytes;
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_46 = V_0;
		V_4 = L_46;
		// ushort crnWidth = System.BitConverter.ToUInt16(new byte[2] { crnBytes[13], crnBytes[12] }, 0);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_47 = (ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031*)(ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031*)SZArrayNew(ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031_il2cpp_TypeInfo_var, (uint32_t)2);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_48 = L_47;
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_49 = V_4;
		NullCheck(L_49);
		int32_t L_50 = ((int32_t)13);
		uint8_t L_51 = (L_49)->GetAt(static_cast<il2cpp_array_size_t>(L_50));
		NullCheck(L_48);
		(L_48)->SetAt(static_cast<il2cpp_array_size_t>(0), (uint8_t)L_51);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_52 = L_48;
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_53 = V_4;
		NullCheck(L_53);
		int32_t L_54 = ((int32_t)12);
		uint8_t L_55 = (L_53)->GetAt(static_cast<il2cpp_array_size_t>(L_54));
		NullCheck(L_52);
		(L_52)->SetAt(static_cast<il2cpp_array_size_t>(1), (uint8_t)L_55);
		il2cpp_codegen_runtime_class_init_inline(BitConverter_t6E99605185963BC12B3D369E13F2B88997E64A27_il2cpp_TypeInfo_var);
		uint16_t L_56;
		L_56 = BitConverter_ToUInt16_m1B08C19B8743A604FBC3807C22A831BD8DA5819D(L_52, 0, NULL);
		V_5 = L_56;
		// ushort crnHeight = System.BitConverter.ToUInt16(new byte[2] { crnBytes[15], crnBytes[14] }, 0);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_57 = (ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031*)(ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031*)SZArrayNew(ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031_il2cpp_TypeInfo_var, (uint32_t)2);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_58 = L_57;
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_59 = V_4;
		NullCheck(L_59);
		int32_t L_60 = ((int32_t)15);
		uint8_t L_61 = (L_59)->GetAt(static_cast<il2cpp_array_size_t>(L_60));
		NullCheck(L_58);
		(L_58)->SetAt(static_cast<il2cpp_array_size_t>(0), (uint8_t)L_61);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_62 = L_58;
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_63 = V_4;
		NullCheck(L_63);
		int32_t L_64 = ((int32_t)14);
		uint8_t L_65 = (L_63)->GetAt(static_cast<il2cpp_array_size_t>(L_64));
		NullCheck(L_62);
		(L_62)->SetAt(static_cast<il2cpp_array_size_t>(1), (uint8_t)L_65);
		uint16_t L_66;
		L_66 = BitConverter_ToUInt16_m1B08C19B8743A604FBC3807C22A831BD8DA5819D(L_62, 0, NULL);
		V_6 = L_66;
		// byte crnFormatByte = crnBytes[18];
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_67 = V_4;
		NullCheck(L_67);
		int32_t L_68 = ((int32_t)18);
		uint8_t L_69 = (L_67)->GetAt(static_cast<il2cpp_array_size_t>(L_68));
		V_7 = L_69;
		// var crnTextureFormat = UnityEngine.TextureFormat.RGB24;
		V_8 = 3;
		// if (crnFormatByte == 0)
		uint8_t L_70 = V_7;
		if (L_70)
		{
			goto IL_01a8;
		}
	}
	{
		// crnTextureFormat = UnityEngine.TextureFormat.DXT1Crunched;
		V_8 = ((int32_t)28);
		goto IL_01fb;
	}

IL_01a8:
	{
		// }else if(crnFormatByte == 2)
		uint8_t L_71 = V_7;
		if ((!(((uint32_t)L_71) == ((uint32_t)2))))
		{
			goto IL_01b3;
		}
	}
	{
		// crnTextureFormat = UnityEngine.TextureFormat.DXT5Crunched;
		V_8 = ((int32_t)29);
		goto IL_01fb;
	}

IL_01b3:
	{
		// else if(crnFormatByte == 12)
		uint8_t L_72 = V_7;
		if ((!(((uint32_t)L_72) == ((uint32_t)((int32_t)12)))))
		{
			goto IL_01bf;
		}
	}
	{
		// crnTextureFormat = UnityEngine.TextureFormat.ETC2_RGBA8Crunched;
		V_8 = ((int32_t)65);
		goto IL_01fb;
	}

IL_01bf:
	{
		// Debug.LogError("Could not load crunched texture " + name + " because its format is not supported (" + crnFormatByte + "): " + fn);
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_73 = (StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248*)(StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248*)SZArrayNew(StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248_il2cpp_TypeInfo_var, (uint32_t)6);
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_74 = L_73;
		NullCheck(L_74);
		ArrayElementTypeCheck (L_74, _stringLiteralCCC77F6BEC01F19B25AEAE1DA587DC5A6486B284);
		(L_74)->SetAt(static_cast<il2cpp_array_size_t>(0), (String_t*)_stringLiteralCCC77F6BEC01F19B25AEAE1DA587DC5A6486B284);
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_75 = L_74;
		String_t* L_76 = V_2;
		NullCheck(L_75);
		ArrayElementTypeCheck (L_75, L_76);
		(L_75)->SetAt(static_cast<il2cpp_array_size_t>(1), (String_t*)L_76);
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_77 = L_75;
		NullCheck(L_77);
		ArrayElementTypeCheck (L_77, _stringLiteral1A3E4D14FCCE4BCFFF56E01EE25543AD3912FB19);
		(L_77)->SetAt(static_cast<il2cpp_array_size_t>(2), (String_t*)_stringLiteral1A3E4D14FCCE4BCFFF56E01EE25543AD3912FB19);
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_78 = L_77;
		String_t* L_79;
		L_79 = Byte_ToString_mB80CE094B94215119578E4D796566E71D7277EE4((&V_7), NULL);
		NullCheck(L_78);
		ArrayElementTypeCheck (L_78, L_79);
		(L_78)->SetAt(static_cast<il2cpp_array_size_t>(3), (String_t*)L_79);
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_80 = L_78;
		NullCheck(L_80);
		ArrayElementTypeCheck (L_80, _stringLiteral911FC00FE8A864A9D1B8F87A75E4EE5041ACF43B);
		(L_80)->SetAt(static_cast<il2cpp_array_size_t>(4), (String_t*)_stringLiteral911FC00FE8A864A9D1B8F87A75E4EE5041ACF43B);
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_81 = L_80;
		String_t* L_82 = ___0_fn;
		NullCheck(L_81);
		ArrayElementTypeCheck (L_81, L_82);
		(L_81)->SetAt(static_cast<il2cpp_array_size_t>(5), (String_t*)L_82);
		String_t* L_83;
		L_83 = String_Concat_m647EBF831F54B6DF7D5AFA5FD012CF4EE7571B6A(L_81, NULL);
		il2cpp_codegen_runtime_class_init_inline(Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		Debug_LogError_mB00B2B4468EF3CAF041B038D840820FB84C924B2(L_83, NULL);
		// break;
		goto IL_022f;
	}

IL_01fb:
	{
		// returnTex = new Texture2D(crnWidth, crnHeight, crnTextureFormat, true);
		uint16_t L_84 = V_5;
		uint16_t L_85 = V_6;
		int32_t L_86 = V_8;
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_87 = (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4*)il2cpp_codegen_object_new(Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4_il2cpp_TypeInfo_var);
		NullCheck(L_87);
		Texture2D__ctor_mECF60A9EC0638EC353C02C8E99B6B465D23BE917(L_87, L_84, L_85, L_86, (bool)1, NULL);
		V_3 = L_87;
		// returnTex.LoadRawTextureData(crnBytes);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_88 = V_3;
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_89 = V_4;
		NullCheck(L_88);
		Texture2D_LoadRawTextureData_mB8D1DEB5FF8715A871D8043D48C9054FCFF4ED1B(L_88, L_89, NULL);
		// returnTex.Apply(true);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_90 = V_3;
		NullCheck(L_90);
		Texture2D_Apply_mCC369BCAB2D3AD3EE50EE01DA67AF227865FA2B3(L_90, (bool)1, NULL);
		// break;
		goto IL_022f;
	}

IL_0219:
	{
		// Debug.LogError("Could not load texture " + name + " because its format is not supported : " + fn);
		String_t* L_91 = V_2;
		String_t* L_92 = ___0_fn;
		String_t* L_93;
		L_93 = String_Concat_m093934F71A9B351911EE46311674ED463B180006(_stringLiteral9FB5B88DDC4C14C62E4014842DEC88E8353401A0, L_91, _stringLiteralC00413A65EA4BBDF5F981E7DC7F68313AA28D95F, L_92, NULL);
		il2cpp_codegen_runtime_class_init_inline(Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		Debug_LogError_mB00B2B4468EF3CAF041B038D840820FB84C924B2(L_93, NULL);
	}

IL_022f:
	{
		// if (returnTex != null)
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_94 = V_3;
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		bool L_95;
		L_95 = Object_op_Inequality_mD0BE578448EAA61948F25C32F8DD55AB1F778602(L_94, (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C*)NULL, NULL);
		if (!L_95)
		{
			goto IL_024b;
		}
	}
	{
		// returnTex = ImageLoaderHelper.VerifyFormat(returnTex);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_96 = V_3;
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_97;
		L_97 = ImageLoaderHelper_VerifyFormat_m4BE5205BCD52E707673B72893FFD743B07CB5383(L_96, NULL);
		V_3 = L_97;
		// returnTex.name = Path.GetFileNameWithoutExtension(fn);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_98 = V_3;
		String_t* L_99 = ___0_fn;
		il2cpp_codegen_runtime_class_init_inline(Path_t8A38A801D0219E8209C1B1D90D82D4D755D998BC_il2cpp_TypeInfo_var);
		String_t* L_100;
		L_100 = Path_GetFileNameWithoutExtension_m2D14CCBAB9C60DC8D32C2443CCE3D34644822FAF(L_99, NULL);
		NullCheck(L_98);
		Object_set_name_mC79E6DC8FFD72479C90F0C4CC7F42A0FEAF5AE47(L_98, L_100, NULL);
	}

IL_024b:
	{
		// return returnTex;
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_101 = V_3;
		return L_101;
	}
}
// System.Void Dummiesman.ImageLoader::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ImageLoader__ctor_mD218225CB03566D60257CB1717366A3E372F0D85 (ImageLoader_t8A370851A05DC8FBFA9EF3A8348BC2D76445BD82* __this, const RuntimeMethod* method) 
{
	{
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
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
// UnityEngine.Texture2D Dummiesman.ImageLoaderHelper::VerifyFormat(UnityEngine.Texture2D)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* ImageLoaderHelper_VerifyFormat_m4BE5205BCD52E707673B72893FFD743B07CB5383 (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* ___0_tex, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* V_0 = NULL;
	bool V_1 = false;
	Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* V_2 = NULL;
	int32_t V_3 = 0;
	{
		// if (tex.format != UnityEngine.TextureFormat.ARGB32 && tex.format != UnityEngine.TextureFormat.RGBA32 && tex.format != UnityEngine.TextureFormat.DXT5)
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_0 = ___0_tex;
		NullCheck(L_0);
		int32_t L_1;
		L_1 = Texture2D_get_format_mE39DD922F83CA1097383309278BB6F20636A7D9D(L_0, NULL);
		if ((((int32_t)L_1) == ((int32_t)5)))
		{
			goto IL_001e;
		}
	}
	{
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_2 = ___0_tex;
		NullCheck(L_2);
		int32_t L_3;
		L_3 = Texture2D_get_format_mE39DD922F83CA1097383309278BB6F20636A7D9D(L_2, NULL);
		if ((((int32_t)L_3) == ((int32_t)4)))
		{
			goto IL_001e;
		}
	}
	{
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_4 = ___0_tex;
		NullCheck(L_4);
		int32_t L_5;
		L_5 = Texture2D_get_format_mE39DD922F83CA1097383309278BB6F20636A7D9D(L_4, NULL);
		if ((((int32_t)L_5) == ((int32_t)((int32_t)12))))
		{
			goto IL_001e;
		}
	}
	{
		// return tex;
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_6 = ___0_tex;
		return L_6;
	}

IL_001e:
	{
		// var pixels = tex.GetPixels32();
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_7 = ___0_tex;
		NullCheck(L_7);
		Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_8;
		L_8 = Texture2D_GetPixels32_m48230192E7543765C1A517F251D1D9BFCFB58C3D(L_7, NULL);
		V_0 = L_8;
		// bool validFormat = false;
		V_1 = (bool)0;
		// foreach(var px in pixels)
		Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_9 = V_0;
		V_2 = L_9;
		V_3 = 0;
		goto IL_0048;
	}

IL_002d:
	{
		// foreach(var px in pixels)
		Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_10 = V_2;
		int32_t L_11 = V_3;
		NullCheck(L_10);
		int32_t L_12 = L_11;
		Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B L_13 = (L_10)->GetAt(static_cast<il2cpp_array_size_t>(L_12));
		// if(px.a < 255)
		uint8_t L_14 = L_13.___a_4;
		if ((((int32_t)L_14) >= ((int32_t)((int32_t)255))))
		{
			goto IL_0044;
		}
	}
	{
		// validFormat = true;
		V_1 = (bool)1;
		// break;
		goto IL_004e;
	}

IL_0044:
	{
		int32_t L_15 = V_3;
		V_3 = ((int32_t)il2cpp_codegen_add(L_15, 1));
	}

IL_0048:
	{
		// foreach(var px in pixels)
		int32_t L_16 = V_3;
		Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_17 = V_2;
		NullCheck(L_17);
		if ((((int32_t)L_16) < ((int32_t)((int32_t)(((RuntimeArray*)L_17)->max_length)))))
		{
			goto IL_002d;
		}
	}

IL_004e:
	{
		// if (!validFormat)
		bool L_18 = V_1;
		if (L_18)
		{
			goto IL_007b;
		}
	}
	{
		// var tex24 = new Texture2D(tex.width, tex.height, UnityEngine.TextureFormat.RGB24, tex.mipmapCount > 0);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_19 = ___0_tex;
		NullCheck(L_19);
		int32_t L_20;
		L_20 = VirtualFuncInvoker0< int32_t >::Invoke(5 /* System.Int32 UnityEngine.Texture::get_width() */, L_19);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_21 = ___0_tex;
		NullCheck(L_21);
		int32_t L_22;
		L_22 = VirtualFuncInvoker0< int32_t >::Invoke(7 /* System.Int32 UnityEngine.Texture::get_height() */, L_21);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_23 = ___0_tex;
		NullCheck(L_23);
		int32_t L_24;
		L_24 = Texture_get_mipmapCount_m9E68435BC8E30B9821525BFC8121C34A53774023(L_23, NULL);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_25 = (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4*)il2cpp_codegen_object_new(Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4_il2cpp_TypeInfo_var);
		NullCheck(L_25);
		Texture2D__ctor_mECF60A9EC0638EC353C02C8E99B6B465D23BE917(L_25, L_20, L_22, 3, (bool)((((int32_t)L_24) > ((int32_t)0))? 1 : 0), NULL);
		// tex24.SetPixels32(pixels);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_26 = L_25;
		Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_27 = V_0;
		NullCheck(L_26);
		Texture2D_SetPixels32_m169F9873A21FB8DECA24DC1B8F06FB23D13BEE2A(L_26, L_27, NULL);
		// tex24.Apply(true);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_28 = L_26;
		NullCheck(L_28);
		Texture2D_Apply_mCC369BCAB2D3AD3EE50EE01DA67AF227865FA2B3(L_28, (bool)1, NULL);
		// return tex24;
		return L_28;
	}

IL_007b:
	{
		// return tex;
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_29 = ___0_tex;
		return L_29;
	}
}
// System.Void Dummiesman.ImageLoaderHelper::FillPixelArray(UnityEngine.Color32[],System.Byte[],System.Int32,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ImageLoaderHelper_FillPixelArray_m72B6D7E7DBBE2FFE61A038FA877217A68185A46C (Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* ___0_fillArray, ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___1_pixelData, int32_t ___2_bytesPerPixel, bool ___3_bgra, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	int32_t V_1 = 0;
	int32_t V_2 = 0;
	int32_t V_3 = 0;
	int32_t V_4 = 0;
	int32_t V_5 = 0;
	{
		// if (bgra)
		bool L_0 = ___3_bgra;
		if (!L_0)
		{
			goto IL_007e;
		}
	}
	{
		// if (bytesPerPixel == 4)
		int32_t L_1 = ___2_bytesPerPixel;
		if ((!(((uint32_t)L_1) == ((uint32_t)4))))
		{
			goto IL_0038;
		}
	}
	{
		// for (int i = 0; i < fillArray.Length; i++)
		V_0 = 0;
		goto IL_0031;
	}

IL_000b:
	{
		// int bi = i * bytesPerPixel;
		int32_t L_2 = V_0;
		int32_t L_3 = ___2_bytesPerPixel;
		V_1 = ((int32_t)il2cpp_codegen_multiply(L_2, L_3));
		// fillArray[i] = new Color32(pixelData[bi + 2], pixelData[bi + 1], pixelData[bi], pixelData[bi + 3]);
		Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_4 = ___0_fillArray;
		int32_t L_5 = V_0;
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_6 = ___1_pixelData;
		int32_t L_7 = V_1;
		NullCheck(L_6);
		int32_t L_8 = ((int32_t)il2cpp_codegen_add(L_7, 2));
		uint8_t L_9 = (L_6)->GetAt(static_cast<il2cpp_array_size_t>(L_8));
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_10 = ___1_pixelData;
		int32_t L_11 = V_1;
		NullCheck(L_10);
		int32_t L_12 = ((int32_t)il2cpp_codegen_add(L_11, 1));
		uint8_t L_13 = (L_10)->GetAt(static_cast<il2cpp_array_size_t>(L_12));
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_14 = ___1_pixelData;
		int32_t L_15 = V_1;
		NullCheck(L_14);
		int32_t L_16 = L_15;
		uint8_t L_17 = (L_14)->GetAt(static_cast<il2cpp_array_size_t>(L_16));
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_18 = ___1_pixelData;
		int32_t L_19 = V_1;
		NullCheck(L_18);
		int32_t L_20 = ((int32_t)il2cpp_codegen_add(L_19, 3));
		uint8_t L_21 = (L_18)->GetAt(static_cast<il2cpp_array_size_t>(L_20));
		Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B L_22;
		memset((&L_22), 0, sizeof(L_22));
		Color32__ctor_mC9C6B443F0C7CA3F8B174158B2AF6F05E18EAC4E_inline((&L_22), L_9, L_13, L_17, L_21, /*hidden argument*/NULL);
		NullCheck(L_4);
		(L_4)->SetAt(static_cast<il2cpp_array_size_t>(L_5), (Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B)L_22);
		// for (int i = 0; i < fillArray.Length; i++)
		int32_t L_23 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_add(L_23, 1));
	}

IL_0031:
	{
		// for (int i = 0; i < fillArray.Length; i++)
		int32_t L_24 = V_0;
		Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_25 = ___0_fillArray;
		NullCheck(L_25);
		if ((((int32_t)L_24) < ((int32_t)((int32_t)(((RuntimeArray*)L_25)->max_length)))))
		{
			goto IL_000b;
		}
	}
	{
		return;
	}

IL_0038:
	{
		// for (int i = 0; i < fillArray.Length; i++)
		V_2 = 0;
		goto IL_0077;
	}

IL_003c:
	{
		// fillArray[i].r = pixelData[(i * 3) + 2];
		Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_26 = ___0_fillArray;
		int32_t L_27 = V_2;
		NullCheck(L_26);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_28 = ___1_pixelData;
		int32_t L_29 = V_2;
		NullCheck(L_28);
		int32_t L_30 = ((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_multiply(L_29, 3)), 2));
		uint8_t L_31 = (L_28)->GetAt(static_cast<il2cpp_array_size_t>(L_30));
		((L_26)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_27)))->___r_1 = L_31;
		// fillArray[i].g = pixelData[(i * 3) + 1];
		Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_32 = ___0_fillArray;
		int32_t L_33 = V_2;
		NullCheck(L_32);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_34 = ___1_pixelData;
		int32_t L_35 = V_2;
		NullCheck(L_34);
		int32_t L_36 = ((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_multiply(L_35, 3)), 1));
		uint8_t L_37 = (L_34)->GetAt(static_cast<il2cpp_array_size_t>(L_36));
		((L_32)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_33)))->___g_2 = L_37;
		// fillArray[i].b = pixelData[(i * 3) + 0];
		Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_38 = ___0_fillArray;
		int32_t L_39 = V_2;
		NullCheck(L_38);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_40 = ___1_pixelData;
		int32_t L_41 = V_2;
		NullCheck(L_40);
		int32_t L_42 = ((int32_t)il2cpp_codegen_multiply(L_41, 3));
		uint8_t L_43 = (L_40)->GetAt(static_cast<il2cpp_array_size_t>(L_42));
		((L_38)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_39)))->___b_3 = L_43;
		// for (int i = 0; i < fillArray.Length; i++)
		int32_t L_44 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add(L_44, 1));
	}

IL_0077:
	{
		// for (int i = 0; i < fillArray.Length; i++)
		int32_t L_45 = V_2;
		Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_46 = ___0_fillArray;
		NullCheck(L_46);
		if ((((int32_t)L_45) < ((int32_t)((int32_t)(((RuntimeArray*)L_46)->max_length)))))
		{
			goto IL_003c;
		}
	}
	{
		return;
	}

IL_007e:
	{
		// if (bytesPerPixel == 4)
		int32_t L_47 = ___2_bytesPerPixel;
		if ((!(((uint32_t)L_47) == ((uint32_t)4))))
		{
			goto IL_00db;
		}
	}
	{
		// for (int i = 0; i < fillArray.Length; i++)
		V_3 = 0;
		goto IL_00d4;
	}

IL_0086:
	{
		// fillArray[i].r = pixelData[i * 4];
		Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_48 = ___0_fillArray;
		int32_t L_49 = V_3;
		NullCheck(L_48);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_50 = ___1_pixelData;
		int32_t L_51 = V_3;
		NullCheck(L_50);
		int32_t L_52 = ((int32_t)il2cpp_codegen_multiply(L_51, 4));
		uint8_t L_53 = (L_50)->GetAt(static_cast<il2cpp_array_size_t>(L_52));
		((L_48)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_49)))->___r_1 = L_53;
		// fillArray[i].g = pixelData[(i * 4) + 1];
		Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_54 = ___0_fillArray;
		int32_t L_55 = V_3;
		NullCheck(L_54);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_56 = ___1_pixelData;
		int32_t L_57 = V_3;
		NullCheck(L_56);
		int32_t L_58 = ((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_multiply(L_57, 4)), 1));
		uint8_t L_59 = (L_56)->GetAt(static_cast<il2cpp_array_size_t>(L_58));
		((L_54)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_55)))->___g_2 = L_59;
		// fillArray[i].b = pixelData[(i * 4) + 2];
		Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_60 = ___0_fillArray;
		int32_t L_61 = V_3;
		NullCheck(L_60);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_62 = ___1_pixelData;
		int32_t L_63 = V_3;
		NullCheck(L_62);
		int32_t L_64 = ((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_multiply(L_63, 4)), 2));
		uint8_t L_65 = (L_62)->GetAt(static_cast<il2cpp_array_size_t>(L_64));
		((L_60)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_61)))->___b_3 = L_65;
		// fillArray[i].a = pixelData[(i * 4) + 3];
		Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_66 = ___0_fillArray;
		int32_t L_67 = V_3;
		NullCheck(L_66);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_68 = ___1_pixelData;
		int32_t L_69 = V_3;
		NullCheck(L_68);
		int32_t L_70 = ((int32_t)il2cpp_codegen_add(((int32_t)il2cpp_codegen_multiply(L_69, 4)), 3));
		uint8_t L_71 = (L_68)->GetAt(static_cast<il2cpp_array_size_t>(L_70));
		((L_66)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_67)))->___a_4 = L_71;
		// for (int i = 0; i < fillArray.Length; i++)
		int32_t L_72 = V_3;
		V_3 = ((int32_t)il2cpp_codegen_add(L_72, 1));
	}

IL_00d4:
	{
		// for (int i = 0; i < fillArray.Length; i++)
		int32_t L_73 = V_3;
		Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_74 = ___0_fillArray;
		NullCheck(L_74);
		if ((((int32_t)L_73) < ((int32_t)((int32_t)(((RuntimeArray*)L_74)->max_length)))))
		{
			goto IL_0086;
		}
	}
	{
		return;
	}

IL_00db:
	{
		// int bi = 0;
		V_4 = 0;
		// for (int i = 0; i < fillArray.Length; i++)
		V_5 = 0;
		goto IL_013d;
	}

IL_00e3:
	{
		// fillArray[i].r = pixelData[bi++];
		Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_75 = ___0_fillArray;
		int32_t L_76 = V_5;
		NullCheck(L_75);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_77 = ___1_pixelData;
		int32_t L_78 = V_4;
		int32_t L_79 = L_78;
		V_4 = ((int32_t)il2cpp_codegen_add(L_79, 1));
		NullCheck(L_77);
		int32_t L_80 = L_79;
		uint8_t L_81 = (L_77)->GetAt(static_cast<il2cpp_array_size_t>(L_80));
		((L_75)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_76)))->___r_1 = L_81;
		// fillArray[i].g = pixelData[bi++];
		Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_82 = ___0_fillArray;
		int32_t L_83 = V_5;
		NullCheck(L_82);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_84 = ___1_pixelData;
		int32_t L_85 = V_4;
		int32_t L_86 = L_85;
		V_4 = ((int32_t)il2cpp_codegen_add(L_86, 1));
		NullCheck(L_84);
		int32_t L_87 = L_86;
		uint8_t L_88 = (L_84)->GetAt(static_cast<il2cpp_array_size_t>(L_87));
		((L_82)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_83)))->___g_2 = L_88;
		// fillArray[i].b = pixelData[bi++];
		Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_89 = ___0_fillArray;
		int32_t L_90 = V_5;
		NullCheck(L_89);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_91 = ___1_pixelData;
		int32_t L_92 = V_4;
		int32_t L_93 = L_92;
		V_4 = ((int32_t)il2cpp_codegen_add(L_93, 1));
		NullCheck(L_91);
		int32_t L_94 = L_93;
		uint8_t L_95 = (L_91)->GetAt(static_cast<il2cpp_array_size_t>(L_94));
		((L_89)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_90)))->___b_3 = L_95;
		// fillArray[i].a = 255;
		Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_96 = ___0_fillArray;
		int32_t L_97 = V_5;
		NullCheck(L_96);
		((L_96)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_97)))->___a_4 = (uint8_t)((int32_t)255);
		// for (int i = 0; i < fillArray.Length; i++)
		int32_t L_98 = V_5;
		V_5 = ((int32_t)il2cpp_codegen_add(L_98, 1));
	}

IL_013d:
	{
		// for (int i = 0; i < fillArray.Length; i++)
		int32_t L_99 = V_5;
		Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_100 = ___0_fillArray;
		NullCheck(L_100);
		if ((((int32_t)L_99) < ((int32_t)((int32_t)(((RuntimeArray*)L_100)->max_length)))))
		{
			goto IL_00e3;
		}
	}
	{
		// }
		return;
	}
}
// System.Void Dummiesman.ImageLoaderHelper::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ImageLoaderHelper__ctor_mADF1F5D3782898A04779AD45B573AA7580A8A3AF (ImageLoaderHelper_t8603BF10D0193AFD974D45CB504409448995359B* __this, const RuntimeMethod* method) 
{
	{
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
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
// UnityEngine.Texture2D Dummiesman.ImageUtils::ConvertToNormalMap(UnityEngine.Texture2D)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* ImageUtils_ConvertToNormalMap_mA5DE17921A34EAE184F8E6FD14213480FF7B5C88 (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* ___0_tex, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* V_0 = NULL;
	ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389* V_1 = NULL;
	int32_t V_2 = 0;
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F V_3;
	memset((&V_3), 0, sizeof(V_3));
	{
		// Texture2D returnTex = tex;
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_0 = ___0_tex;
		V_0 = L_0;
		// if(tex.format != TextureFormat.RGBA32 && tex.format != TextureFormat.ARGB32)
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_1 = ___0_tex;
		NullCheck(L_1);
		int32_t L_2;
		L_2 = Texture2D_get_format_mE39DD922F83CA1097383309278BB6F20636A7D9D(L_1, NULL);
		if ((((int32_t)L_2) == ((int32_t)4)))
		{
			goto IL_0028;
		}
	}
	{
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_3 = ___0_tex;
		NullCheck(L_3);
		int32_t L_4;
		L_4 = Texture2D_get_format_mE39DD922F83CA1097383309278BB6F20636A7D9D(L_3, NULL);
		if ((((int32_t)L_4) == ((int32_t)5)))
		{
			goto IL_0028;
		}
	}
	{
		// returnTex = new Texture2D(tex.width, tex.height, TextureFormat.RGBA32, true);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_5 = ___0_tex;
		NullCheck(L_5);
		int32_t L_6;
		L_6 = VirtualFuncInvoker0< int32_t >::Invoke(5 /* System.Int32 UnityEngine.Texture::get_width() */, L_5);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_7 = ___0_tex;
		NullCheck(L_7);
		int32_t L_8;
		L_8 = VirtualFuncInvoker0< int32_t >::Invoke(7 /* System.Int32 UnityEngine.Texture::get_height() */, L_7);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_9 = (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4*)il2cpp_codegen_object_new(Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4_il2cpp_TypeInfo_var);
		NullCheck(L_9);
		Texture2D__ctor_mECF60A9EC0638EC353C02C8E99B6B465D23BE917(L_9, L_6, L_8, 4, (bool)1, NULL);
		V_0 = L_9;
	}

IL_0028:
	{
		// Color[] pixels = tex.GetPixels();
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_10 = ___0_tex;
		NullCheck(L_10);
		ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389* L_11;
		L_11 = Texture2D_GetPixels_m77A00D71DF5CDC7DAA0EE66FF2C90A24C7604039(L_10, NULL);
		V_1 = L_11;
		// for (int i = 0; i < pixels.Length; i++)
		V_2 = 0;
		goto IL_0085;
	}

IL_0033:
	{
		// Color temp = pixels[i];
		ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389* L_12 = V_1;
		int32_t L_13 = V_2;
		NullCheck(L_12);
		int32_t L_14 = L_13;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_15 = (L_12)->GetAt(static_cast<il2cpp_array_size_t>(L_14));
		V_3 = L_15;
		// temp.a = pixels[i].r;
		ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389* L_16 = V_1;
		int32_t L_17 = V_2;
		NullCheck(L_16);
		float L_18 = ((L_16)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_17)))->___r_0;
		(&V_3)->___a_3 = L_18;
		// temp.r = 0f;
		(&V_3)->___r_0 = (0.0f);
		// temp.g = pixels[i].g;
		ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389* L_19 = V_1;
		int32_t L_20 = V_2;
		NullCheck(L_19);
		float L_21 = ((L_19)->GetAddressAt(static_cast<il2cpp_array_size_t>(L_20)))->___g_1;
		(&V_3)->___g_1 = L_21;
		// temp.b = 0f;
		(&V_3)->___b_2 = (0.0f);
		// pixels[i] = temp;
		ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389* L_22 = V_1;
		int32_t L_23 = V_2;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_24 = V_3;
		NullCheck(L_22);
		(L_22)->SetAt(static_cast<il2cpp_array_size_t>(L_23), (Color_tD001788D726C3A7F1379BEED0260B9591F440C1F)L_24);
		// for (int i = 0; i < pixels.Length; i++)
		int32_t L_25 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add(L_25, 1));
	}

IL_0085:
	{
		// for (int i = 0; i < pixels.Length; i++)
		int32_t L_26 = V_2;
		ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389* L_27 = V_1;
		NullCheck(L_27);
		if ((((int32_t)L_26) < ((int32_t)((int32_t)(((RuntimeArray*)L_27)->max_length)))))
		{
			goto IL_0033;
		}
	}
	{
		// returnTex.SetPixels(pixels);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_28 = V_0;
		ColorU5BU5D_t612261CF293F6FFC3D80AB52259FF0DC2B2CC389* L_29 = V_1;
		NullCheck(L_28);
		Texture2D_SetPixels_mAE0CDFA15FA96F840D7FFADC31405D8AF20D9073(L_28, L_29, NULL);
		// returnTex.Apply(true);
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_30 = V_0;
		NullCheck(L_30);
		Texture2D_Apply_mCC369BCAB2D3AD3EE50EE01DA67AF227865FA2B3(L_30, (bool)1, NULL);
		// return returnTex;
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_31 = V_0;
		return L_31;
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
// System.Int32 Dummiesman.TGALoader::GetBits(System.Byte,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t TGALoader_GetBits_m644EA9B2DA0F84A296F1779AB2E352B65383211E (uint8_t ___0_b, int32_t ___1_offset, int32_t ___2_count, const RuntimeMethod* method) 
{
	{
		// return (b >> offset) & ((1 << count) - 1);
		uint8_t L_0 = ___0_b;
		int32_t L_1 = ___1_offset;
		int32_t L_2 = ___2_count;
		return ((int32_t)(((int32_t)((int32_t)L_0>>((int32_t)(L_1&((int32_t)31)))))&((int32_t)il2cpp_codegen_subtract(((int32_t)(1<<((int32_t)(L_2&((int32_t)31))))), 1))));
	}
}
// UnityEngine.Color32[] Dummiesman.TGALoader::LoadRawTGAData(System.IO.BinaryReader,System.Int32,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* TGALoader_LoadRawTGAData_mE8533A32EB9376821A049F17FC68B035F0CF6DA5 (BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158* ___0_r, int32_t ___1_bitDepth, int32_t ___2_width, int32_t ___3_height, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* V_0 = NULL;
	{
		// Color32[] pulledColors = new Color32[width * height];
		int32_t L_0 = ___2_width;
		int32_t L_1 = ___3_height;
		Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_2 = (Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259*)(Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259*)SZArrayNew(Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259_il2cpp_TypeInfo_var, (uint32_t)((int32_t)il2cpp_codegen_multiply(L_0, L_1)));
		// byte[] colorData = r.ReadBytes(width * height * (bitDepth / 8));
		BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158* L_3 = ___0_r;
		int32_t L_4 = ___2_width;
		int32_t L_5 = ___3_height;
		int32_t L_6 = ___1_bitDepth;
		NullCheck(L_3);
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_7;
		L_7 = VirtualFuncInvoker1< ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031*, int32_t >::Invoke(25 /* System.Byte[] System.IO.BinaryReader::ReadBytes(System.Int32) */, L_3, ((int32_t)il2cpp_codegen_multiply(((int32_t)il2cpp_codegen_multiply(L_4, L_5)), ((int32_t)(L_6/8)))));
		V_0 = L_7;
		// ImageLoaderHelper.FillPixelArray(pulledColors, colorData, (bitDepth / 8), true);
		Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_8 = L_2;
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_9 = V_0;
		int32_t L_10 = ___1_bitDepth;
		ImageLoaderHelper_FillPixelArray_m72B6D7E7DBBE2FFE61A038FA877217A68185A46C(L_8, L_9, ((int32_t)(L_10/8)), (bool)1, NULL);
		// return pulledColors;
		return L_8;
	}
}
// UnityEngine.Color32[] Dummiesman.TGALoader::LoadRLETGAData(System.IO.BinaryReader,System.Int32,System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* TGALoader_LoadRLETGAData_m697F5F83681111FDB4A4260CB501CBFB280DAEF7 (BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158* ___0_r, int32_t ___1_bitDepth, int32_t ___2_width, int32_t ___3_height, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* V_0 = NULL;
	int32_t V_1 = 0;
	int32_t V_2 = 0;
	int32_t V_3 = 0;
	int32_t V_4 = 0;
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B V_5;
	memset((&V_5), 0, sizeof(V_5));
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B V_6;
	memset((&V_6), 0, sizeof(V_6));
	int32_t V_7 = 0;
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B G_B6_0;
	memset((&G_B6_0), 0, sizeof(G_B6_0));
	Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B G_B12_0;
	memset((&G_B12_0), 0, sizeof(G_B12_0));
	{
		// Color32[] pulledColors = new Color32[width * height];
		int32_t L_0 = ___2_width;
		int32_t L_1 = ___3_height;
		Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_2 = (Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259*)(Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259*)SZArrayNew(Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259_il2cpp_TypeInfo_var, (uint32_t)((int32_t)il2cpp_codegen_multiply(L_0, L_1)));
		V_0 = L_2;
		// int pulledColorCount = 0;
		V_1 = 0;
		goto IL_00a8;
	}

IL_0010:
	{
		// byte rlePacket = r.ReadByte();
		BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158* L_3 = ___0_r;
		NullCheck(L_3);
		uint8_t L_4;
		L_4 = VirtualFuncInvoker0< uint8_t >::Invoke(10 /* System.Byte System.IO.BinaryReader::ReadByte() */, L_3);
		// int RLEPacketType = GetBits(rlePacket, 7, 1);
		uint8_t L_5 = L_4;
		int32_t L_6;
		L_6 = TGALoader_GetBits_m644EA9B2DA0F84A296F1779AB2E352B65383211E(L_5, 7, 1, NULL);
		V_2 = L_6;
		// int RLEPixelCount = GetBits(rlePacket, 0, 7) + 1;
		int32_t L_7;
		L_7 = TGALoader_GetBits_m644EA9B2DA0F84A296F1779AB2E352B65383211E(L_5, 0, 7, NULL);
		V_3 = ((int32_t)il2cpp_codegen_add(L_7, 1));
		// if (RLEPacketType == 0)
		int32_t L_8 = V_2;
		if (L_8)
		{
			goto IL_0069;
		}
	}
	{
		// for (int i = 0; i < RLEPixelCount; i++)
		V_4 = 0;
		goto IL_0062;
	}

IL_0031:
	{
		// var color = (bitDepth == 32) ? r.ReadColor32RGBA().FlipRB() : r.ReadColor32RGB().FlipRB();
		int32_t L_9 = ___1_bitDepth;
		if ((((int32_t)L_9) == ((int32_t)((int32_t)32))))
		{
			goto IL_0043;
		}
	}
	{
		BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158* L_10 = ___0_r;
		Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B L_11;
		L_11 = BinaryExtensions_ReadColor32RGB_m4E6A56048B5909CE85A0EC79B45F161FD1AAAD86(L_10, NULL);
		Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B L_12;
		L_12 = ColorExtensions_FlipRB_mAE6EB26665B0643B471B17C6E9CE67D18ADC0FDD(L_11, NULL);
		G_B6_0 = L_12;
		goto IL_004e;
	}

IL_0043:
	{
		BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158* L_13 = ___0_r;
		Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B L_14;
		L_14 = BinaryExtensions_ReadColor32RGBA_m08B1549AF8CA5D27A28E9B2A80BFD74E94B2E92D(L_13, NULL);
		Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B L_15;
		L_15 = ColorExtensions_FlipRB_mAE6EB26665B0643B471B17C6E9CE67D18ADC0FDD(L_14, NULL);
		G_B6_0 = L_15;
	}

IL_004e:
	{
		V_5 = G_B6_0;
		// pulledColors[i + pulledColorCount] = color;
		Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_16 = V_0;
		int32_t L_17 = V_4;
		int32_t L_18 = V_1;
		Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B L_19 = V_5;
		NullCheck(L_16);
		(L_16)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_17, L_18))), (Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B)L_19);
		// for (int i = 0; i < RLEPixelCount; i++)
		int32_t L_20 = V_4;
		V_4 = ((int32_t)il2cpp_codegen_add(L_20, 1));
	}

IL_0062:
	{
		// for (int i = 0; i < RLEPixelCount; i++)
		int32_t L_21 = V_4;
		int32_t L_22 = V_3;
		if ((((int32_t)L_21) < ((int32_t)L_22)))
		{
			goto IL_0031;
		}
	}
	{
		goto IL_00a4;
	}

IL_0069:
	{
		// var color = (bitDepth == 32) ? r.ReadColor32RGBA().FlipRB() : r.ReadColor32RGB().FlipRB();
		int32_t L_23 = ___1_bitDepth;
		if ((((int32_t)L_23) == ((int32_t)((int32_t)32))))
		{
			goto IL_007b;
		}
	}
	{
		BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158* L_24 = ___0_r;
		Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B L_25;
		L_25 = BinaryExtensions_ReadColor32RGB_m4E6A56048B5909CE85A0EC79B45F161FD1AAAD86(L_24, NULL);
		Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B L_26;
		L_26 = ColorExtensions_FlipRB_mAE6EB26665B0643B471B17C6E9CE67D18ADC0FDD(L_25, NULL);
		G_B12_0 = L_26;
		goto IL_0086;
	}

IL_007b:
	{
		BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158* L_27 = ___0_r;
		Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B L_28;
		L_28 = BinaryExtensions_ReadColor32RGBA_m08B1549AF8CA5D27A28E9B2A80BFD74E94B2E92D(L_27, NULL);
		Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B L_29;
		L_29 = ColorExtensions_FlipRB_mAE6EB26665B0643B471B17C6E9CE67D18ADC0FDD(L_28, NULL);
		G_B12_0 = L_29;
	}

IL_0086:
	{
		V_6 = G_B12_0;
		// for (int i = 0; i < RLEPixelCount; i++)
		V_7 = 0;
		goto IL_009f;
	}

IL_008d:
	{
		// pulledColors[i + pulledColorCount] = color;
		Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_30 = V_0;
		int32_t L_31 = V_7;
		int32_t L_32 = V_1;
		Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B L_33 = V_6;
		NullCheck(L_30);
		(L_30)->SetAt(static_cast<il2cpp_array_size_t>(((int32_t)il2cpp_codegen_add(L_31, L_32))), (Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B)L_33);
		// for (int i = 0; i < RLEPixelCount; i++)
		int32_t L_34 = V_7;
		V_7 = ((int32_t)il2cpp_codegen_add(L_34, 1));
	}

IL_009f:
	{
		// for (int i = 0; i < RLEPixelCount; i++)
		int32_t L_35 = V_7;
		int32_t L_36 = V_3;
		if ((((int32_t)L_35) < ((int32_t)L_36)))
		{
			goto IL_008d;
		}
	}

IL_00a4:
	{
		// pulledColorCount += RLEPixelCount;
		int32_t L_37 = V_1;
		int32_t L_38 = V_3;
		V_1 = ((int32_t)il2cpp_codegen_add(L_37, L_38));
	}

IL_00a8:
	{
		// while (pulledColorCount < pulledColors.Length)
		int32_t L_39 = V_1;
		Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_40 = V_0;
		NullCheck(L_40);
		if ((((int32_t)L_39) < ((int32_t)((int32_t)(((RuntimeArray*)L_40)->max_length)))))
		{
			goto IL_0010;
		}
	}
	{
		// return pulledColors;
		Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_41 = V_0;
		return L_41;
	}
}
// UnityEngine.Texture2D Dummiesman.TGALoader::Load(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* TGALoader_Load_m8F5D5BCAA30FD14B48110AFF16E5B6452BAEBD70 (String_t* ___0_fileName, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	FileStream_t07C7222EE10B75F352B89B76E60820160FF10AD8* V_0 = NULL;
	Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* V_1 = NULL;
	{
		// using (var imageFile = File.OpenRead(fileName))
		String_t* L_0 = ___0_fileName;
		FileStream_t07C7222EE10B75F352B89B76E60820160FF10AD8* L_1;
		L_1 = File_OpenRead_m6181B052EB0E98D2E18FAC79E7744D766BA4244C(L_0, NULL);
		V_0 = L_1;
	}
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_0010:
			{// begin finally (depth: 1)
				{
					FileStream_t07C7222EE10B75F352B89B76E60820160FF10AD8* L_2 = V_0;
					if (!L_2)
					{
						goto IL_0019;
					}
				}
				{
					FileStream_t07C7222EE10B75F352B89B76E60820160FF10AD8* L_3 = V_0;
					NullCheck(L_3);
					InterfaceActionInvoker0::Invoke(0 /* System.Void System.IDisposable::Dispose() */, IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var, L_3);
				}

IL_0019:
				{
					return;
				}
			}// end finally (depth: 1)
		});
		try
		{// begin try (depth: 1)
			// return Load(imageFile);
			FileStream_t07C7222EE10B75F352B89B76E60820160FF10AD8* L_4 = V_0;
			Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_5;
			L_5 = TGALoader_Load_mFFD983DFCBF01C4B0C51AEC8829191B59E63AD20(L_4, NULL);
			V_1 = L_5;
			goto IL_001a;
		}// end try (depth: 1)
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_001a:
	{
		// }
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_6 = V_1;
		return L_6;
	}
}
// UnityEngine.Texture2D Dummiesman.TGALoader::Load(System.Byte[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* TGALoader_Load_mA6CEA84E76054B05FE07E43AA47C20F76FCE20A4 (ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___0_bytes, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&MemoryStream_tAAED1B42172E3390584E4194308AB878E786AAC2_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	MemoryStream_tAAED1B42172E3390584E4194308AB878E786AAC2* V_0 = NULL;
	Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* V_1 = NULL;
	{
		// using (var ms = new MemoryStream(bytes))
		ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_0 = ___0_bytes;
		MemoryStream_tAAED1B42172E3390584E4194308AB878E786AAC2* L_1 = (MemoryStream_tAAED1B42172E3390584E4194308AB878E786AAC2*)il2cpp_codegen_object_new(MemoryStream_tAAED1B42172E3390584E4194308AB878E786AAC2_il2cpp_TypeInfo_var);
		NullCheck(L_1);
		MemoryStream__ctor_m662CA0D5A0004A2E3B475FE8DCD687B654870AA2(L_1, L_0, NULL);
		V_0 = L_1;
	}
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_0010:
			{// begin finally (depth: 1)
				{
					MemoryStream_tAAED1B42172E3390584E4194308AB878E786AAC2* L_2 = V_0;
					if (!L_2)
					{
						goto IL_0019;
					}
				}
				{
					MemoryStream_tAAED1B42172E3390584E4194308AB878E786AAC2* L_3 = V_0;
					NullCheck(L_3);
					InterfaceActionInvoker0::Invoke(0 /* System.Void System.IDisposable::Dispose() */, IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var, L_3);
				}

IL_0019:
				{
					return;
				}
			}// end finally (depth: 1)
		});
		try
		{// begin try (depth: 1)
			// return Load(ms);
			MemoryStream_tAAED1B42172E3390584E4194308AB878E786AAC2* L_4 = V_0;
			Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_5;
			L_5 = TGALoader_Load_mFFD983DFCBF01C4B0C51AEC8829191B59E63AD20(L_4, NULL);
			V_1 = L_5;
			goto IL_001a;
		}// end try (depth: 1)
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_001a:
	{
		// }
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_6 = V_1;
		return L_6;
	}
}
// UnityEngine.Texture2D Dummiesman.TGALoader::Load(System.IO.Stream)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* TGALoader_Load_mFFD983DFCBF01C4B0C51AEC8829191B59E63AD20 (Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* ___0_TGAStream, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Byte_t94D9231AC217BE4D2E004C4CD32DF6D099EA41A3_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral267226911D4A958D79875B1057280198F25BE5F6);
		s_Il2CppMethodInitialized = true;
	}
	BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158* V_0 = NULL;
	uint8_t V_1 = 0x0;
	int16_t V_2 = 0;
	int16_t V_3 = 0;
	int32_t V_4 = 0;
	Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* V_5 = NULL;
	Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* V_6 = NULL;
	int16_t G_B8_0 = 0;
	int16_t G_B8_1 = 0;
	int16_t G_B7_0 = 0;
	int16_t G_B7_1 = 0;
	int32_t G_B9_0 = 0;
	int16_t G_B9_1 = 0;
	int16_t G_B9_2 = 0;
	{
		// using (BinaryReader r = new BinaryReader(TGAStream))
		Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* L_0 = ___0_TGAStream;
		BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158* L_1 = (BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158*)il2cpp_codegen_object_new(BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158_il2cpp_TypeInfo_var);
		NullCheck(L_1);
		BinaryReader__ctor_m898732FE0DBEDD480B24F6DE45A9AC696E44CC0F(L_1, L_0, NULL);
		V_0 = L_1;
	}
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_00d2:
			{// begin finally (depth: 1)
				{
					BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158* L_2 = V_0;
					if (!L_2)
					{
						goto IL_00db;
					}
				}
				{
					BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158* L_3 = V_0;
					NullCheck(L_3);
					InterfaceActionInvoker0::Invoke(0 /* System.Void System.IDisposable::Dispose() */, IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var, L_3);
				}

IL_00db:
				{
					return;
				}
			}// end finally (depth: 1)
		});
		try
		{// begin try (depth: 1)
			{
				// r.BaseStream.Seek(2, SeekOrigin.Begin);
				BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158* L_4 = V_0;
				NullCheck(L_4);
				Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* L_5;
				L_5 = VirtualFuncInvoker0< Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* >::Invoke(5 /* System.IO.Stream System.IO.BinaryReader::get_BaseStream() */, L_4);
				NullCheck(L_5);
				int64_t L_6;
				L_6 = VirtualFuncInvoker2< int64_t, int64_t, int32_t >::Invoke(30 /* System.Int64 System.IO.Stream::Seek(System.Int64,System.IO.SeekOrigin) */, L_5, ((int64_t)2), 0);
				// byte imageType = r.ReadByte();
				BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158* L_7 = V_0;
				NullCheck(L_7);
				uint8_t L_8;
				L_8 = VirtualFuncInvoker0< uint8_t >::Invoke(10 /* System.Byte System.IO.BinaryReader::ReadByte() */, L_7);
				V_1 = L_8;
				// if (imageType != 10 && imageType != 2)
				uint8_t L_9 = V_1;
				if ((((int32_t)L_9) == ((int32_t)((int32_t)10))))
				{
					goto IL_0043_1;
				}
			}
			{
				uint8_t L_10 = V_1;
				if ((((int32_t)L_10) == ((int32_t)2)))
				{
					goto IL_0043_1;
				}
			}
			{
				// Debug.LogError($"Unsupported targa image type. ({imageType})");
				uint8_t L_11 = V_1;
				uint8_t L_12 = L_11;
				RuntimeObject* L_13 = Box(Byte_t94D9231AC217BE4D2E004C4CD32DF6D099EA41A3_il2cpp_TypeInfo_var, &L_12);
				String_t* L_14;
				L_14 = String_Format_mA8DBB4C2516B9723C5A41E6CB1E2FAF4BBE96DD8(_stringLiteral267226911D4A958D79875B1057280198F25BE5F6, L_13, NULL);
				il2cpp_codegen_runtime_class_init_inline(Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
				Debug_LogError_mB00B2B4468EF3CAF041B038D840820FB84C924B2(L_14, NULL);
				// return null;
				V_6 = (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4*)NULL;
				goto IL_00dc;
			}

IL_0043_1:
			{
				// r.BaseStream.Seek(12, SeekOrigin.Begin);
				BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158* L_15 = V_0;
				NullCheck(L_15);
				Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* L_16;
				L_16 = VirtualFuncInvoker0< Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* >::Invoke(5 /* System.IO.Stream System.IO.BinaryReader::get_BaseStream() */, L_15);
				NullCheck(L_16);
				int64_t L_17;
				L_17 = VirtualFuncInvoker2< int64_t, int64_t, int32_t >::Invoke(30 /* System.Int64 System.IO.Stream::Seek(System.Int64,System.IO.SeekOrigin) */, L_16, ((int64_t)((int32_t)12)), 0);
				// short width = r.ReadInt16();
				BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158* L_18 = V_0;
				NullCheck(L_18);
				int16_t L_19;
				L_19 = VirtualFuncInvoker0< int16_t >::Invoke(13 /* System.Int16 System.IO.BinaryReader::ReadInt16() */, L_18);
				V_2 = L_19;
				// short height = r.ReadInt16();
				BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158* L_20 = V_0;
				NullCheck(L_20);
				int16_t L_21;
				L_21 = VirtualFuncInvoker0< int16_t >::Invoke(13 /* System.Int16 System.IO.BinaryReader::ReadInt16() */, L_20);
				V_3 = L_21;
				// int bitDepth = r.ReadByte();
				BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158* L_22 = V_0;
				NullCheck(L_22);
				uint8_t L_23;
				L_23 = VirtualFuncInvoker0< uint8_t >::Invoke(10 /* System.Byte System.IO.BinaryReader::ReadByte() */, L_22);
				V_4 = L_23;
				// if (bitDepth < 24)
				int32_t L_24 = V_4;
				if ((((int32_t)L_24) >= ((int32_t)((int32_t)24))))
				{
					goto IL_007a_1;
				}
			}
			{
				// throw new Exception("Tried to load TGA with unsupported bit depth");
				Exception_t* L_25 = (Exception_t*)il2cpp_codegen_object_new(((RuntimeClass*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&Exception_t_il2cpp_TypeInfo_var)));
				NullCheck(L_25);
				Exception__ctor_m9B2BD92CD68916245A75109105D9071C9D430E7F(L_25, ((String_t*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&_stringLiteral3201B86FACEA09A6EC2396E7556112CD64565211)), NULL);
				IL2CPP_RAISE_MANAGED_EXCEPTION(L_25, ((RuntimeMethod*)il2cpp_codegen_initialize_runtime_metadata_inline((uintptr_t*)&TGALoader_Load_mFFD983DFCBF01C4B0C51AEC8829191B59E63AD20_RuntimeMethod_var)));
			}

IL_007a_1:
			{
				// r.BaseStream.Seek(1, SeekOrigin.Current);
				BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158* L_26 = V_0;
				NullCheck(L_26);
				Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* L_27;
				L_27 = VirtualFuncInvoker0< Stream_tF844051B786E8F7F4244DBD218D74E8617B9A2DE* >::Invoke(5 /* System.IO.Stream System.IO.BinaryReader::get_BaseStream() */, L_26);
				NullCheck(L_27);
				int64_t L_28;
				L_28 = VirtualFuncInvoker2< int64_t, int64_t, int32_t >::Invoke(30 /* System.Int64 System.IO.Stream::Seek(System.Int64,System.IO.SeekOrigin) */, L_27, ((int64_t)1), 1);
				// Texture2D tex = new Texture2D(width, height, (bitDepth == 24) ? TextureFormat.RGB24 :  TextureFormat.ARGB32, true);
				int16_t L_29 = V_2;
				int16_t L_30 = V_3;
				int32_t L_31 = V_4;
				G_B7_0 = L_30;
				G_B7_1 = L_29;
				if ((((int32_t)L_31) == ((int32_t)((int32_t)24))))
				{
					G_B8_0 = L_30;
					G_B8_1 = L_29;
					goto IL_0094_1;
				}
			}
			{
				G_B9_0 = 5;
				G_B9_1 = G_B7_0;
				G_B9_2 = G_B7_1;
				goto IL_0095_1;
			}

IL_0094_1:
			{
				G_B9_0 = 3;
				G_B9_1 = G_B8_0;
				G_B9_2 = G_B8_1;
			}

IL_0095_1:
			{
				Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_32 = (Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4*)il2cpp_codegen_object_new(Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4_il2cpp_TypeInfo_var);
				NullCheck(L_32);
				Texture2D__ctor_mECF60A9EC0638EC353C02C8E99B6B465D23BE917(L_32, G_B9_2, G_B9_1, G_B9_0, (bool)1, NULL);
				V_5 = L_32;
				// if (imageType == 2)
				uint8_t L_33 = V_1;
				if ((!(((uint32_t)L_33) == ((uint32_t)2))))
				{
					goto IL_00b4_1;
				}
			}
			{
				// tex.SetPixels32(LoadRawTGAData(r, bitDepth, width, height));
				Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_34 = V_5;
				BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158* L_35 = V_0;
				int32_t L_36 = V_4;
				int16_t L_37 = V_2;
				int16_t L_38 = V_3;
				Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_39;
				L_39 = TGALoader_LoadRawTGAData_mE8533A32EB9376821A049F17FC68B035F0CF6DA5(L_35, L_36, L_37, L_38, NULL);
				NullCheck(L_34);
				Texture2D_SetPixels32_m169F9873A21FB8DECA24DC1B8F06FB23D13BEE2A(L_34, L_39, NULL);
				goto IL_00c5_1;
			}

IL_00b4_1:
			{
				// tex.SetPixels32(LoadRLETGAData(r, bitDepth, width, height));
				Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_40 = V_5;
				BinaryReader_t9A6D85F0FE9AE4EBB5E8D66997DFD1D84939E158* L_41 = V_0;
				int32_t L_42 = V_4;
				int16_t L_43 = V_2;
				int16_t L_44 = V_3;
				Color32U5BU5D_t38116C3E91765C4C5726CE12C77FAD7F9F737259* L_45;
				L_45 = TGALoader_LoadRLETGAData_m697F5F83681111FDB4A4260CB501CBFB280DAEF7(L_41, L_42, L_43, L_44, NULL);
				NullCheck(L_40);
				Texture2D_SetPixels32_m169F9873A21FB8DECA24DC1B8F06FB23D13BEE2A(L_40, L_45, NULL);
			}

IL_00c5_1:
			{
				// tex.Apply();
				Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_46 = V_5;
				NullCheck(L_46);
				Texture2D_Apply_mA014182C9EE0BBF6EEE3B286854F29E50EB972DC(L_46, NULL);
				// return tex;
				Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_47 = V_5;
				V_6 = L_47;
				goto IL_00dc;
			}
		}// end try (depth: 1)
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_00dc:
	{
		// }
		Texture2D_tE6505BC111DD8A424A9DBE8E05D7D09E11FFFCF4* L_48 = V_6;
		return L_48;
	}
}
// System.Void Dummiesman.TGALoader::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void TGALoader__ctor_m3BD8839506BD5B26AA424AC8265DD4E71F24FA57 (TGALoader_tBF4AA5DFA40A991239260EF4CD506E8F5F59B1E2* __this, const RuntimeMethod* method) 
{
	{
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
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
// UnityEngine.Color Dummiesman.Extensions.ColorExtensions::FlipRB(UnityEngine.Color)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ColorExtensions_FlipRB_mE0881F8E342236C92E353CB994086AB3916D8746 (Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___0_color, const RuntimeMethod* method) 
{
	{
		// return new Color(color.b, color.g, color.r, color.a);
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_0 = ___0_color;
		float L_1 = L_0.___b_2;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_2 = ___0_color;
		float L_3 = L_2.___g_1;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_4 = ___0_color;
		float L_5 = L_4.___r_0;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_6 = ___0_color;
		float L_7 = L_6.___a_3;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_8;
		memset((&L_8), 0, sizeof(L_8));
		Color__ctor_m3786F0D6E510D9CFA544523A955870BD2A514C8C_inline((&L_8), L_1, L_3, L_5, L_7, /*hidden argument*/NULL);
		return L_8;
	}
}
// UnityEngine.Color32 Dummiesman.Extensions.ColorExtensions::FlipRB(UnityEngine.Color32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ColorExtensions_FlipRB_mAE6EB26665B0643B471B17C6E9CE67D18ADC0FDD (Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B ___0_color, const RuntimeMethod* method) 
{
	{
		// return new Color32(color.b, color.g, color.r, color.a);
		Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B L_0 = ___0_color;
		uint8_t L_1 = L_0.___b_3;
		Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B L_2 = ___0_color;
		uint8_t L_3 = L_2.___g_2;
		Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B L_4 = ___0_color;
		uint8_t L_5 = L_4.___r_1;
		Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B L_6 = ___0_color;
		uint8_t L_7 = L_6.___a_4;
		Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B L_8;
		memset((&L_8), 0, sizeof(L_8));
		Color32__ctor_mC9C6B443F0C7CA3F8B174158B2AF6F05E18EAC4E_inline((&L_8), L_1, L_3, L_5, L_7, /*hidden argument*/NULL);
		return L_8;
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
// Conversion methods for marshalling of: SFB.ExtensionFilter
IL2CPP_EXTERN_C void ExtensionFilter_t8E3B1120DA244D6F742247E3EF9A152C3FAE3A57_marshal_pinvoke(const ExtensionFilter_t8E3B1120DA244D6F742247E3EF9A152C3FAE3A57& unmarshaled, ExtensionFilter_t8E3B1120DA244D6F742247E3EF9A152C3FAE3A57_marshaled_pinvoke& marshaled)
{
	Exception_t* ___Extensions_1Exception = il2cpp_codegen_get_marshal_directive_exception("Cannot marshal field 'Extensions' of type 'ExtensionFilter'.");
	IL2CPP_RAISE_MANAGED_EXCEPTION(___Extensions_1Exception, NULL);
}
IL2CPP_EXTERN_C void ExtensionFilter_t8E3B1120DA244D6F742247E3EF9A152C3FAE3A57_marshal_pinvoke_back(const ExtensionFilter_t8E3B1120DA244D6F742247E3EF9A152C3FAE3A57_marshaled_pinvoke& marshaled, ExtensionFilter_t8E3B1120DA244D6F742247E3EF9A152C3FAE3A57& unmarshaled)
{
	Exception_t* ___Extensions_1Exception = il2cpp_codegen_get_marshal_directive_exception("Cannot marshal field 'Extensions' of type 'ExtensionFilter'.");
	IL2CPP_RAISE_MANAGED_EXCEPTION(___Extensions_1Exception, NULL);
}
// Conversion method for clean up from marshalling of: SFB.ExtensionFilter
IL2CPP_EXTERN_C void ExtensionFilter_t8E3B1120DA244D6F742247E3EF9A152C3FAE3A57_marshal_pinvoke_cleanup(ExtensionFilter_t8E3B1120DA244D6F742247E3EF9A152C3FAE3A57_marshaled_pinvoke& marshaled)
{
}
// Conversion methods for marshalling of: SFB.ExtensionFilter
IL2CPP_EXTERN_C void ExtensionFilter_t8E3B1120DA244D6F742247E3EF9A152C3FAE3A57_marshal_com(const ExtensionFilter_t8E3B1120DA244D6F742247E3EF9A152C3FAE3A57& unmarshaled, ExtensionFilter_t8E3B1120DA244D6F742247E3EF9A152C3FAE3A57_marshaled_com& marshaled)
{
	Exception_t* ___Extensions_1Exception = il2cpp_codegen_get_marshal_directive_exception("Cannot marshal field 'Extensions' of type 'ExtensionFilter'.");
	IL2CPP_RAISE_MANAGED_EXCEPTION(___Extensions_1Exception, NULL);
}
IL2CPP_EXTERN_C void ExtensionFilter_t8E3B1120DA244D6F742247E3EF9A152C3FAE3A57_marshal_com_back(const ExtensionFilter_t8E3B1120DA244D6F742247E3EF9A152C3FAE3A57_marshaled_com& marshaled, ExtensionFilter_t8E3B1120DA244D6F742247E3EF9A152C3FAE3A57& unmarshaled)
{
	Exception_t* ___Extensions_1Exception = il2cpp_codegen_get_marshal_directive_exception("Cannot marshal field 'Extensions' of type 'ExtensionFilter'.");
	IL2CPP_RAISE_MANAGED_EXCEPTION(___Extensions_1Exception, NULL);
}
// Conversion method for clean up from marshalling of: SFB.ExtensionFilter
IL2CPP_EXTERN_C void ExtensionFilter_t8E3B1120DA244D6F742247E3EF9A152C3FAE3A57_marshal_com_cleanup(ExtensionFilter_t8E3B1120DA244D6F742247E3EF9A152C3FAE3A57_marshaled_com& marshaled)
{
}
// System.Void SFB.ExtensionFilter::.ctor(System.String,System.String[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ExtensionFilter__ctor_mC6B29D2340E2ABFDB631D14F82670A0B68B70373 (ExtensionFilter_t8E3B1120DA244D6F742247E3EF9A152C3FAE3A57* __this, String_t* ___0_filterName, StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* ___1_filterExtensions, const RuntimeMethod* method) 
{
	{
		// Name = filterName;
		String_t* L_0 = ___0_filterName;
		__this->___Name_0 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___Name_0), (void*)L_0);
		// Extensions = filterExtensions;
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_1 = ___1_filterExtensions;
		__this->___Extensions_1 = L_1;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___Extensions_1), (void*)L_1);
		// }
		return;
	}
}
IL2CPP_EXTERN_C  void ExtensionFilter__ctor_mC6B29D2340E2ABFDB631D14F82670A0B68B70373_AdjustorThunk (RuntimeObject* __this, String_t* ___0_filterName, StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* ___1_filterExtensions, const RuntimeMethod* method)
{
	ExtensionFilter_t8E3B1120DA244D6F742247E3EF9A152C3FAE3A57* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<ExtensionFilter_t8E3B1120DA244D6F742247E3EF9A152C3FAE3A57*>(__this + _offset);
	ExtensionFilter__ctor_mC6B29D2340E2ABFDB631D14F82670A0B68B70373(_thisAdjusted, ___0_filterName, ___1_filterExtensions, method);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void SFB.StandaloneFileBrowser::.cctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void StandaloneFileBrowser__cctor_m85AE1EDB818F98D95877C32B683EAEFDE40044DC (const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.String[] SFB.StandaloneFileBrowser::OpenFilePanel(System.String,System.String,System.String,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* StandaloneFileBrowser_OpenFilePanel_m52446C4EFFC962134ABA4C57022ED887D6DB89FD (String_t* ___0_title, String_t* ___1_directory, String_t* ___2_extension, bool ___3_multiselect, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ExtensionFilterU5BU5D_t724AA1EDDC78E2F3CC3EB4C808F408EDF52EDCFD_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StandaloneFileBrowser_t787EC519E2F250D5F984F7C4E41441B46C779AF6_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709);
		s_Il2CppMethodInitialized = true;
	}
	ExtensionFilterU5BU5D_t724AA1EDDC78E2F3CC3EB4C808F408EDF52EDCFD* V_0 = NULL;
	ExtensionFilterU5BU5D_t724AA1EDDC78E2F3CC3EB4C808F408EDF52EDCFD* G_B3_0 = NULL;
	{
		// var extensions = string.IsNullOrEmpty(extension) ? null : new [] { new ExtensionFilter("", extension) };
		String_t* L_0 = ___2_extension;
		bool L_1;
		L_1 = String_IsNullOrEmpty_mEA9E3FB005AC28FE02E69FCF95A7B8456192B478(L_0, NULL);
		if (L_1)
		{
			goto IL_002b;
		}
	}
	{
		ExtensionFilterU5BU5D_t724AA1EDDC78E2F3CC3EB4C808F408EDF52EDCFD* L_2 = (ExtensionFilterU5BU5D_t724AA1EDDC78E2F3CC3EB4C808F408EDF52EDCFD*)(ExtensionFilterU5BU5D_t724AA1EDDC78E2F3CC3EB4C808F408EDF52EDCFD*)SZArrayNew(ExtensionFilterU5BU5D_t724AA1EDDC78E2F3CC3EB4C808F408EDF52EDCFD_il2cpp_TypeInfo_var, (uint32_t)1);
		ExtensionFilterU5BU5D_t724AA1EDDC78E2F3CC3EB4C808F408EDF52EDCFD* L_3 = L_2;
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_4 = (StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248*)(StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248*)SZArrayNew(StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248_il2cpp_TypeInfo_var, (uint32_t)1);
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_5 = L_4;
		String_t* L_6 = ___2_extension;
		NullCheck(L_5);
		ArrayElementTypeCheck (L_5, L_6);
		(L_5)->SetAt(static_cast<il2cpp_array_size_t>(0), (String_t*)L_6);
		ExtensionFilter_t8E3B1120DA244D6F742247E3EF9A152C3FAE3A57 L_7;
		memset((&L_7), 0, sizeof(L_7));
		ExtensionFilter__ctor_mC6B29D2340E2ABFDB631D14F82670A0B68B70373((&L_7), _stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709, L_5, /*hidden argument*/NULL);
		NullCheck(L_3);
		(L_3)->SetAt(static_cast<il2cpp_array_size_t>(0), (ExtensionFilter_t8E3B1120DA244D6F742247E3EF9A152C3FAE3A57)L_7);
		G_B3_0 = L_3;
		goto IL_002c;
	}

IL_002b:
	{
		G_B3_0 = ((ExtensionFilterU5BU5D_t724AA1EDDC78E2F3CC3EB4C808F408EDF52EDCFD*)(NULL));
	}

IL_002c:
	{
		V_0 = G_B3_0;
		// return OpenFilePanel(title, directory, extensions, multiselect);
		String_t* L_8 = ___0_title;
		String_t* L_9 = ___1_directory;
		ExtensionFilterU5BU5D_t724AA1EDDC78E2F3CC3EB4C808F408EDF52EDCFD* L_10 = V_0;
		bool L_11 = ___3_multiselect;
		il2cpp_codegen_runtime_class_init_inline(StandaloneFileBrowser_t787EC519E2F250D5F984F7C4E41441B46C779AF6_il2cpp_TypeInfo_var);
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_12;
		L_12 = StandaloneFileBrowser_OpenFilePanel_mA9A53F487A5FAB785DA5A42CB82560E113900F28(L_8, L_9, L_10, L_11, NULL);
		return L_12;
	}
}
// System.String[] SFB.StandaloneFileBrowser::OpenFilePanel(System.String,System.String,SFB.ExtensionFilter[],System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* StandaloneFileBrowser_OpenFilePanel_mA9A53F487A5FAB785DA5A42CB82560E113900F28 (String_t* ___0_title, String_t* ___1_directory, ExtensionFilterU5BU5D_t724AA1EDDC78E2F3CC3EB4C808F408EDF52EDCFD* ___2_extensions, bool ___3_multiselect, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IStandaloneFileBrowser_t702D6FF622C15DC43255001FD380A5D424F308B2_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StandaloneFileBrowser_t787EC519E2F250D5F984F7C4E41441B46C779AF6_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// return _platformWrapper.OpenFilePanel(title, directory, extensions, multiselect);
		il2cpp_codegen_runtime_class_init_inline(StandaloneFileBrowser_t787EC519E2F250D5F984F7C4E41441B46C779AF6_il2cpp_TypeInfo_var);
		RuntimeObject* L_0 = ((StandaloneFileBrowser_t787EC519E2F250D5F984F7C4E41441B46C779AF6_StaticFields*)il2cpp_codegen_static_fields_for(StandaloneFileBrowser_t787EC519E2F250D5F984F7C4E41441B46C779AF6_il2cpp_TypeInfo_var))->____platformWrapper_0;
		String_t* L_1 = ___0_title;
		String_t* L_2 = ___1_directory;
		ExtensionFilterU5BU5D_t724AA1EDDC78E2F3CC3EB4C808F408EDF52EDCFD* L_3 = ___2_extensions;
		bool L_4 = ___3_multiselect;
		NullCheck(L_0);
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_5;
		L_5 = InterfaceFuncInvoker4< StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248*, String_t*, String_t*, ExtensionFilterU5BU5D_t724AA1EDDC78E2F3CC3EB4C808F408EDF52EDCFD*, bool >::Invoke(0 /* System.String[] SFB.IStandaloneFileBrowser::OpenFilePanel(System.String,System.String,SFB.ExtensionFilter[],System.Boolean) */, IStandaloneFileBrowser_t702D6FF622C15DC43255001FD380A5D424F308B2_il2cpp_TypeInfo_var, L_0, L_1, L_2, L_3, L_4);
		return L_5;
	}
}
// System.Void SFB.StandaloneFileBrowser::OpenFilePanelAsync(System.String,System.String,System.String,System.Boolean,System.Action`1<System.String[]>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void StandaloneFileBrowser_OpenFilePanelAsync_m76460A53AF91D10241E89284FAE418459C1B0706 (String_t* ___0_title, String_t* ___1_directory, String_t* ___2_extension, bool ___3_multiselect, Action_1_t5439CAB6DF93B6A7A29E473D9B2A9943E580CAF8* ___4_cb, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ExtensionFilterU5BU5D_t724AA1EDDC78E2F3CC3EB4C808F408EDF52EDCFD_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StandaloneFileBrowser_t787EC519E2F250D5F984F7C4E41441B46C779AF6_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709);
		s_Il2CppMethodInitialized = true;
	}
	ExtensionFilterU5BU5D_t724AA1EDDC78E2F3CC3EB4C808F408EDF52EDCFD* V_0 = NULL;
	ExtensionFilterU5BU5D_t724AA1EDDC78E2F3CC3EB4C808F408EDF52EDCFD* G_B3_0 = NULL;
	{
		// var extensions = string.IsNullOrEmpty(extension) ? null : new [] { new ExtensionFilter("", extension) };
		String_t* L_0 = ___2_extension;
		bool L_1;
		L_1 = String_IsNullOrEmpty_mEA9E3FB005AC28FE02E69FCF95A7B8456192B478(L_0, NULL);
		if (L_1)
		{
			goto IL_002b;
		}
	}
	{
		ExtensionFilterU5BU5D_t724AA1EDDC78E2F3CC3EB4C808F408EDF52EDCFD* L_2 = (ExtensionFilterU5BU5D_t724AA1EDDC78E2F3CC3EB4C808F408EDF52EDCFD*)(ExtensionFilterU5BU5D_t724AA1EDDC78E2F3CC3EB4C808F408EDF52EDCFD*)SZArrayNew(ExtensionFilterU5BU5D_t724AA1EDDC78E2F3CC3EB4C808F408EDF52EDCFD_il2cpp_TypeInfo_var, (uint32_t)1);
		ExtensionFilterU5BU5D_t724AA1EDDC78E2F3CC3EB4C808F408EDF52EDCFD* L_3 = L_2;
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_4 = (StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248*)(StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248*)SZArrayNew(StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248_il2cpp_TypeInfo_var, (uint32_t)1);
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_5 = L_4;
		String_t* L_6 = ___2_extension;
		NullCheck(L_5);
		ArrayElementTypeCheck (L_5, L_6);
		(L_5)->SetAt(static_cast<il2cpp_array_size_t>(0), (String_t*)L_6);
		ExtensionFilter_t8E3B1120DA244D6F742247E3EF9A152C3FAE3A57 L_7;
		memset((&L_7), 0, sizeof(L_7));
		ExtensionFilter__ctor_mC6B29D2340E2ABFDB631D14F82670A0B68B70373((&L_7), _stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709, L_5, /*hidden argument*/NULL);
		NullCheck(L_3);
		(L_3)->SetAt(static_cast<il2cpp_array_size_t>(0), (ExtensionFilter_t8E3B1120DA244D6F742247E3EF9A152C3FAE3A57)L_7);
		G_B3_0 = L_3;
		goto IL_002c;
	}

IL_002b:
	{
		G_B3_0 = ((ExtensionFilterU5BU5D_t724AA1EDDC78E2F3CC3EB4C808F408EDF52EDCFD*)(NULL));
	}

IL_002c:
	{
		V_0 = G_B3_0;
		// OpenFilePanelAsync(title, directory, extensions, multiselect, cb);
		String_t* L_8 = ___0_title;
		String_t* L_9 = ___1_directory;
		ExtensionFilterU5BU5D_t724AA1EDDC78E2F3CC3EB4C808F408EDF52EDCFD* L_10 = V_0;
		bool L_11 = ___3_multiselect;
		Action_1_t5439CAB6DF93B6A7A29E473D9B2A9943E580CAF8* L_12 = ___4_cb;
		il2cpp_codegen_runtime_class_init_inline(StandaloneFileBrowser_t787EC519E2F250D5F984F7C4E41441B46C779AF6_il2cpp_TypeInfo_var);
		StandaloneFileBrowser_OpenFilePanelAsync_m4E9384D6A7E1459E8493C956E29DA2F4AD3AA4A8(L_8, L_9, L_10, L_11, L_12, NULL);
		// }
		return;
	}
}
// System.Void SFB.StandaloneFileBrowser::OpenFilePanelAsync(System.String,System.String,SFB.ExtensionFilter[],System.Boolean,System.Action`1<System.String[]>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void StandaloneFileBrowser_OpenFilePanelAsync_m4E9384D6A7E1459E8493C956E29DA2F4AD3AA4A8 (String_t* ___0_title, String_t* ___1_directory, ExtensionFilterU5BU5D_t724AA1EDDC78E2F3CC3EB4C808F408EDF52EDCFD* ___2_extensions, bool ___3_multiselect, Action_1_t5439CAB6DF93B6A7A29E473D9B2A9943E580CAF8* ___4_cb, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IStandaloneFileBrowser_t702D6FF622C15DC43255001FD380A5D424F308B2_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StandaloneFileBrowser_t787EC519E2F250D5F984F7C4E41441B46C779AF6_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// _platformWrapper.OpenFilePanelAsync(title, directory, extensions, multiselect, cb);
		il2cpp_codegen_runtime_class_init_inline(StandaloneFileBrowser_t787EC519E2F250D5F984F7C4E41441B46C779AF6_il2cpp_TypeInfo_var);
		RuntimeObject* L_0 = ((StandaloneFileBrowser_t787EC519E2F250D5F984F7C4E41441B46C779AF6_StaticFields*)il2cpp_codegen_static_fields_for(StandaloneFileBrowser_t787EC519E2F250D5F984F7C4E41441B46C779AF6_il2cpp_TypeInfo_var))->____platformWrapper_0;
		String_t* L_1 = ___0_title;
		String_t* L_2 = ___1_directory;
		ExtensionFilterU5BU5D_t724AA1EDDC78E2F3CC3EB4C808F408EDF52EDCFD* L_3 = ___2_extensions;
		bool L_4 = ___3_multiselect;
		Action_1_t5439CAB6DF93B6A7A29E473D9B2A9943E580CAF8* L_5 = ___4_cb;
		NullCheck(L_0);
		InterfaceActionInvoker5< String_t*, String_t*, ExtensionFilterU5BU5D_t724AA1EDDC78E2F3CC3EB4C808F408EDF52EDCFD*, bool, Action_1_t5439CAB6DF93B6A7A29E473D9B2A9943E580CAF8* >::Invoke(3 /* System.Void SFB.IStandaloneFileBrowser::OpenFilePanelAsync(System.String,System.String,SFB.ExtensionFilter[],System.Boolean,System.Action`1<System.String[]>) */, IStandaloneFileBrowser_t702D6FF622C15DC43255001FD380A5D424F308B2_il2cpp_TypeInfo_var, L_0, L_1, L_2, L_3, L_4, L_5);
		// }
		return;
	}
}
// System.String[] SFB.StandaloneFileBrowser::OpenFolderPanel(System.String,System.String,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* StandaloneFileBrowser_OpenFolderPanel_mDCD8922B2DD3FB72167AD48E84B283FB2A1B870E (String_t* ___0_title, String_t* ___1_directory, bool ___2_multiselect, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IStandaloneFileBrowser_t702D6FF622C15DC43255001FD380A5D424F308B2_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StandaloneFileBrowser_t787EC519E2F250D5F984F7C4E41441B46C779AF6_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// return _platformWrapper.OpenFolderPanel(title, directory, multiselect);
		il2cpp_codegen_runtime_class_init_inline(StandaloneFileBrowser_t787EC519E2F250D5F984F7C4E41441B46C779AF6_il2cpp_TypeInfo_var);
		RuntimeObject* L_0 = ((StandaloneFileBrowser_t787EC519E2F250D5F984F7C4E41441B46C779AF6_StaticFields*)il2cpp_codegen_static_fields_for(StandaloneFileBrowser_t787EC519E2F250D5F984F7C4E41441B46C779AF6_il2cpp_TypeInfo_var))->____platformWrapper_0;
		String_t* L_1 = ___0_title;
		String_t* L_2 = ___1_directory;
		bool L_3 = ___2_multiselect;
		NullCheck(L_0);
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_4;
		L_4 = InterfaceFuncInvoker3< StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248*, String_t*, String_t*, bool >::Invoke(1 /* System.String[] SFB.IStandaloneFileBrowser::OpenFolderPanel(System.String,System.String,System.Boolean) */, IStandaloneFileBrowser_t702D6FF622C15DC43255001FD380A5D424F308B2_il2cpp_TypeInfo_var, L_0, L_1, L_2, L_3);
		return L_4;
	}
}
// System.Void SFB.StandaloneFileBrowser::OpenFolderPanelAsync(System.String,System.String,System.Boolean,System.Action`1<System.String[]>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void StandaloneFileBrowser_OpenFolderPanelAsync_mA36F48F48C4F3FEC352D55292665712B12535175 (String_t* ___0_title, String_t* ___1_directory, bool ___2_multiselect, Action_1_t5439CAB6DF93B6A7A29E473D9B2A9943E580CAF8* ___3_cb, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IStandaloneFileBrowser_t702D6FF622C15DC43255001FD380A5D424F308B2_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StandaloneFileBrowser_t787EC519E2F250D5F984F7C4E41441B46C779AF6_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// _platformWrapper.OpenFolderPanelAsync(title, directory, multiselect, cb);
		il2cpp_codegen_runtime_class_init_inline(StandaloneFileBrowser_t787EC519E2F250D5F984F7C4E41441B46C779AF6_il2cpp_TypeInfo_var);
		RuntimeObject* L_0 = ((StandaloneFileBrowser_t787EC519E2F250D5F984F7C4E41441B46C779AF6_StaticFields*)il2cpp_codegen_static_fields_for(StandaloneFileBrowser_t787EC519E2F250D5F984F7C4E41441B46C779AF6_il2cpp_TypeInfo_var))->____platformWrapper_0;
		String_t* L_1 = ___0_title;
		String_t* L_2 = ___1_directory;
		bool L_3 = ___2_multiselect;
		Action_1_t5439CAB6DF93B6A7A29E473D9B2A9943E580CAF8* L_4 = ___3_cb;
		NullCheck(L_0);
		InterfaceActionInvoker4< String_t*, String_t*, bool, Action_1_t5439CAB6DF93B6A7A29E473D9B2A9943E580CAF8* >::Invoke(4 /* System.Void SFB.IStandaloneFileBrowser::OpenFolderPanelAsync(System.String,System.String,System.Boolean,System.Action`1<System.String[]>) */, IStandaloneFileBrowser_t702D6FF622C15DC43255001FD380A5D424F308B2_il2cpp_TypeInfo_var, L_0, L_1, L_2, L_3, L_4);
		// }
		return;
	}
}
// System.String SFB.StandaloneFileBrowser::SaveFilePanel(System.String,System.String,System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* StandaloneFileBrowser_SaveFilePanel_m47FEDCFDF939EA02541D2FF7842EC156029B8A68 (String_t* ___0_title, String_t* ___1_directory, String_t* ___2_defaultName, String_t* ___3_extension, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ExtensionFilterU5BU5D_t724AA1EDDC78E2F3CC3EB4C808F408EDF52EDCFD_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StandaloneFileBrowser_t787EC519E2F250D5F984F7C4E41441B46C779AF6_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709);
		s_Il2CppMethodInitialized = true;
	}
	ExtensionFilterU5BU5D_t724AA1EDDC78E2F3CC3EB4C808F408EDF52EDCFD* V_0 = NULL;
	ExtensionFilterU5BU5D_t724AA1EDDC78E2F3CC3EB4C808F408EDF52EDCFD* G_B3_0 = NULL;
	{
		// var extensions = string.IsNullOrEmpty(extension) ? null : new [] { new ExtensionFilter("", extension) };
		String_t* L_0 = ___3_extension;
		bool L_1;
		L_1 = String_IsNullOrEmpty_mEA9E3FB005AC28FE02E69FCF95A7B8456192B478(L_0, NULL);
		if (L_1)
		{
			goto IL_002b;
		}
	}
	{
		ExtensionFilterU5BU5D_t724AA1EDDC78E2F3CC3EB4C808F408EDF52EDCFD* L_2 = (ExtensionFilterU5BU5D_t724AA1EDDC78E2F3CC3EB4C808F408EDF52EDCFD*)(ExtensionFilterU5BU5D_t724AA1EDDC78E2F3CC3EB4C808F408EDF52EDCFD*)SZArrayNew(ExtensionFilterU5BU5D_t724AA1EDDC78E2F3CC3EB4C808F408EDF52EDCFD_il2cpp_TypeInfo_var, (uint32_t)1);
		ExtensionFilterU5BU5D_t724AA1EDDC78E2F3CC3EB4C808F408EDF52EDCFD* L_3 = L_2;
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_4 = (StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248*)(StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248*)SZArrayNew(StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248_il2cpp_TypeInfo_var, (uint32_t)1);
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_5 = L_4;
		String_t* L_6 = ___3_extension;
		NullCheck(L_5);
		ArrayElementTypeCheck (L_5, L_6);
		(L_5)->SetAt(static_cast<il2cpp_array_size_t>(0), (String_t*)L_6);
		ExtensionFilter_t8E3B1120DA244D6F742247E3EF9A152C3FAE3A57 L_7;
		memset((&L_7), 0, sizeof(L_7));
		ExtensionFilter__ctor_mC6B29D2340E2ABFDB631D14F82670A0B68B70373((&L_7), _stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709, L_5, /*hidden argument*/NULL);
		NullCheck(L_3);
		(L_3)->SetAt(static_cast<il2cpp_array_size_t>(0), (ExtensionFilter_t8E3B1120DA244D6F742247E3EF9A152C3FAE3A57)L_7);
		G_B3_0 = L_3;
		goto IL_002c;
	}

IL_002b:
	{
		G_B3_0 = ((ExtensionFilterU5BU5D_t724AA1EDDC78E2F3CC3EB4C808F408EDF52EDCFD*)(NULL));
	}

IL_002c:
	{
		V_0 = G_B3_0;
		// return SaveFilePanel(title, directory, defaultName, extensions);
		String_t* L_8 = ___0_title;
		String_t* L_9 = ___1_directory;
		String_t* L_10 = ___2_defaultName;
		ExtensionFilterU5BU5D_t724AA1EDDC78E2F3CC3EB4C808F408EDF52EDCFD* L_11 = V_0;
		il2cpp_codegen_runtime_class_init_inline(StandaloneFileBrowser_t787EC519E2F250D5F984F7C4E41441B46C779AF6_il2cpp_TypeInfo_var);
		String_t* L_12;
		L_12 = StandaloneFileBrowser_SaveFilePanel_m27DF41BF602A1712BE13DF3F7EB49A998A50B654(L_8, L_9, L_10, L_11, NULL);
		return L_12;
	}
}
// System.String SFB.StandaloneFileBrowser::SaveFilePanel(System.String,System.String,System.String,SFB.ExtensionFilter[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* StandaloneFileBrowser_SaveFilePanel_m27DF41BF602A1712BE13DF3F7EB49A998A50B654 (String_t* ___0_title, String_t* ___1_directory, String_t* ___2_defaultName, ExtensionFilterU5BU5D_t724AA1EDDC78E2F3CC3EB4C808F408EDF52EDCFD* ___3_extensions, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IStandaloneFileBrowser_t702D6FF622C15DC43255001FD380A5D424F308B2_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StandaloneFileBrowser_t787EC519E2F250D5F984F7C4E41441B46C779AF6_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// return _platformWrapper.SaveFilePanel(title, directory, defaultName, extensions);
		il2cpp_codegen_runtime_class_init_inline(StandaloneFileBrowser_t787EC519E2F250D5F984F7C4E41441B46C779AF6_il2cpp_TypeInfo_var);
		RuntimeObject* L_0 = ((StandaloneFileBrowser_t787EC519E2F250D5F984F7C4E41441B46C779AF6_StaticFields*)il2cpp_codegen_static_fields_for(StandaloneFileBrowser_t787EC519E2F250D5F984F7C4E41441B46C779AF6_il2cpp_TypeInfo_var))->____platformWrapper_0;
		String_t* L_1 = ___0_title;
		String_t* L_2 = ___1_directory;
		String_t* L_3 = ___2_defaultName;
		ExtensionFilterU5BU5D_t724AA1EDDC78E2F3CC3EB4C808F408EDF52EDCFD* L_4 = ___3_extensions;
		NullCheck(L_0);
		String_t* L_5;
		L_5 = InterfaceFuncInvoker4< String_t*, String_t*, String_t*, String_t*, ExtensionFilterU5BU5D_t724AA1EDDC78E2F3CC3EB4C808F408EDF52EDCFD* >::Invoke(2 /* System.String SFB.IStandaloneFileBrowser::SaveFilePanel(System.String,System.String,System.String,SFB.ExtensionFilter[]) */, IStandaloneFileBrowser_t702D6FF622C15DC43255001FD380A5D424F308B2_il2cpp_TypeInfo_var, L_0, L_1, L_2, L_3, L_4);
		return L_5;
	}
}
// System.Void SFB.StandaloneFileBrowser::SaveFilePanelAsync(System.String,System.String,System.String,System.String,System.Action`1<System.String>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void StandaloneFileBrowser_SaveFilePanelAsync_m8BC10027FAD38947C71E351D999AA426ED5E6D74 (String_t* ___0_title, String_t* ___1_directory, String_t* ___2_defaultName, String_t* ___3_extension, Action_1_t3CB5D1A819C3ED3F99E9E39F890F18633253949A* ___4_cb, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&ExtensionFilterU5BU5D_t724AA1EDDC78E2F3CC3EB4C808F408EDF52EDCFD_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StandaloneFileBrowser_t787EC519E2F250D5F984F7C4E41441B46C779AF6_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709);
		s_Il2CppMethodInitialized = true;
	}
	ExtensionFilterU5BU5D_t724AA1EDDC78E2F3CC3EB4C808F408EDF52EDCFD* V_0 = NULL;
	ExtensionFilterU5BU5D_t724AA1EDDC78E2F3CC3EB4C808F408EDF52EDCFD* G_B3_0 = NULL;
	{
		// var extensions = string.IsNullOrEmpty(extension) ? null : new [] { new ExtensionFilter("", extension) };
		String_t* L_0 = ___3_extension;
		bool L_1;
		L_1 = String_IsNullOrEmpty_mEA9E3FB005AC28FE02E69FCF95A7B8456192B478(L_0, NULL);
		if (L_1)
		{
			goto IL_002b;
		}
	}
	{
		ExtensionFilterU5BU5D_t724AA1EDDC78E2F3CC3EB4C808F408EDF52EDCFD* L_2 = (ExtensionFilterU5BU5D_t724AA1EDDC78E2F3CC3EB4C808F408EDF52EDCFD*)(ExtensionFilterU5BU5D_t724AA1EDDC78E2F3CC3EB4C808F408EDF52EDCFD*)SZArrayNew(ExtensionFilterU5BU5D_t724AA1EDDC78E2F3CC3EB4C808F408EDF52EDCFD_il2cpp_TypeInfo_var, (uint32_t)1);
		ExtensionFilterU5BU5D_t724AA1EDDC78E2F3CC3EB4C808F408EDF52EDCFD* L_3 = L_2;
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_4 = (StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248*)(StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248*)SZArrayNew(StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248_il2cpp_TypeInfo_var, (uint32_t)1);
		StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* L_5 = L_4;
		String_t* L_6 = ___3_extension;
		NullCheck(L_5);
		ArrayElementTypeCheck (L_5, L_6);
		(L_5)->SetAt(static_cast<il2cpp_array_size_t>(0), (String_t*)L_6);
		ExtensionFilter_t8E3B1120DA244D6F742247E3EF9A152C3FAE3A57 L_7;
		memset((&L_7), 0, sizeof(L_7));
		ExtensionFilter__ctor_mC6B29D2340E2ABFDB631D14F82670A0B68B70373((&L_7), _stringLiteralDA39A3EE5E6B4B0D3255BFEF95601890AFD80709, L_5, /*hidden argument*/NULL);
		NullCheck(L_3);
		(L_3)->SetAt(static_cast<il2cpp_array_size_t>(0), (ExtensionFilter_t8E3B1120DA244D6F742247E3EF9A152C3FAE3A57)L_7);
		G_B3_0 = L_3;
		goto IL_002c;
	}

IL_002b:
	{
		G_B3_0 = ((ExtensionFilterU5BU5D_t724AA1EDDC78E2F3CC3EB4C808F408EDF52EDCFD*)(NULL));
	}

IL_002c:
	{
		V_0 = G_B3_0;
		// SaveFilePanelAsync(title, directory, defaultName, extensions, cb);
		String_t* L_8 = ___0_title;
		String_t* L_9 = ___1_directory;
		String_t* L_10 = ___2_defaultName;
		ExtensionFilterU5BU5D_t724AA1EDDC78E2F3CC3EB4C808F408EDF52EDCFD* L_11 = V_0;
		Action_1_t3CB5D1A819C3ED3F99E9E39F890F18633253949A* L_12 = ___4_cb;
		il2cpp_codegen_runtime_class_init_inline(StandaloneFileBrowser_t787EC519E2F250D5F984F7C4E41441B46C779AF6_il2cpp_TypeInfo_var);
		StandaloneFileBrowser_SaveFilePanelAsync_m4DE0BB49F677327EAFE8D5F1645340FFB7EC6A08(L_8, L_9, L_10, L_11, L_12, NULL);
		// }
		return;
	}
}
// System.Void SFB.StandaloneFileBrowser::SaveFilePanelAsync(System.String,System.String,System.String,SFB.ExtensionFilter[],System.Action`1<System.String>)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void StandaloneFileBrowser_SaveFilePanelAsync_m4DE0BB49F677327EAFE8D5F1645340FFB7EC6A08 (String_t* ___0_title, String_t* ___1_directory, String_t* ___2_defaultName, ExtensionFilterU5BU5D_t724AA1EDDC78E2F3CC3EB4C808F408EDF52EDCFD* ___3_extensions, Action_1_t3CB5D1A819C3ED3F99E9E39F890F18633253949A* ___4_cb, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IStandaloneFileBrowser_t702D6FF622C15DC43255001FD380A5D424F308B2_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StandaloneFileBrowser_t787EC519E2F250D5F984F7C4E41441B46C779AF6_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// _platformWrapper.SaveFilePanelAsync(title, directory, defaultName, extensions, cb);
		il2cpp_codegen_runtime_class_init_inline(StandaloneFileBrowser_t787EC519E2F250D5F984F7C4E41441B46C779AF6_il2cpp_TypeInfo_var);
		RuntimeObject* L_0 = ((StandaloneFileBrowser_t787EC519E2F250D5F984F7C4E41441B46C779AF6_StaticFields*)il2cpp_codegen_static_fields_for(StandaloneFileBrowser_t787EC519E2F250D5F984F7C4E41441B46C779AF6_il2cpp_TypeInfo_var))->____platformWrapper_0;
		String_t* L_1 = ___0_title;
		String_t* L_2 = ___1_directory;
		String_t* L_3 = ___2_defaultName;
		ExtensionFilterU5BU5D_t724AA1EDDC78E2F3CC3EB4C808F408EDF52EDCFD* L_4 = ___3_extensions;
		Action_1_t3CB5D1A819C3ED3F99E9E39F890F18633253949A* L_5 = ___4_cb;
		NullCheck(L_0);
		InterfaceActionInvoker5< String_t*, String_t*, String_t*, ExtensionFilterU5BU5D_t724AA1EDDC78E2F3CC3EB4C808F408EDF52EDCFD*, Action_1_t3CB5D1A819C3ED3F99E9E39F890F18633253949A* >::Invoke(5 /* System.Void SFB.IStandaloneFileBrowser::SaveFilePanelAsync(System.String,System.String,System.String,SFB.ExtensionFilter[],System.Action`1<System.String>) */, IStandaloneFileBrowser_t702D6FF622C15DC43255001FD380A5D424F308B2_il2cpp_TypeInfo_var, L_0, L_1, L_2, L_3, L_4, L_5);
		// }
		return;
	}
}
// System.Void SFB.StandaloneFileBrowser::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void StandaloneFileBrowser__ctor_m134B0D90725E6B9A4DA3599D30537B6309EE87A0 (StandaloneFileBrowser_t787EC519E2F250D5F984F7C4E41441B46C779AF6* __this, const RuntimeMethod* method) 
{
	{
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
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
// System.Void Keyboard.Key::Awake()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Key_Awake_mE70A506A77B7A6BB87DB326A0B65B119767B8786 (Key_tB9DA6A9816AEA58ACE1AE6EA33755EAEEBAC8970* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Component_GetComponent_TisButton_t6786514A57F7AFDEE5431112FEA0CAB24F5AE098_mFF8BA4CA5D7158D1D6249559A3289E7A6DF0A2BB_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Key_ChangeKeyColors_mF848C4E6D96720A9311F65E6847AEC4E06F92038_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Key_ChangeKeyState_mD1A5BC6C4AAF356404BEA30434ED235412CF1A66_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&UnityAction_1_t8EC357AF4FBD2A0C4A575C4BBD0B3A81029E43A9_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&UnityAction_4_t05D51CE8BEA0460D330923E761D421EF194ED9B1_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// button = GetComponent<Button>();
		Button_t6786514A57F7AFDEE5431112FEA0CAB24F5AE098* L_0;
		L_0 = Component_GetComponent_TisButton_t6786514A57F7AFDEE5431112FEA0CAB24F5AE098_mFF8BA4CA5D7158D1D6249559A3289E7A6DF0A2BB(__this, Component_GetComponent_TisButton_t6786514A57F7AFDEE5431112FEA0CAB24F5AE098_mFF8BA4CA5D7158D1D6249559A3289E7A6DF0A2BB_RuntimeMethod_var);
		__this->___button_6 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___button_6), (void*)L_0);
		// button.onClick.AddListener(OnPress);
		Button_t6786514A57F7AFDEE5431112FEA0CAB24F5AE098* L_1 = __this->___button_6;
		NullCheck(L_1);
		ButtonClickedEvent_t8EA72E90B3BD1392FB3B3EF167D5121C23569E4C* L_2;
		L_2 = Button_get_onClick_m701712A7F7F000CC80D517C4510697E15722C35C_inline(L_1, NULL);
		UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7* L_3 = (UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7*)il2cpp_codegen_object_new(UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7_il2cpp_TypeInfo_var);
		NullCheck(L_3);
		UnityAction__ctor_mC53E20D6B66E0D5688CD81B88DBB34F5A58B7131(L_3, __this, (intptr_t)((void*)GetVirtualMethodInfo(__this, 6)), NULL);
		NullCheck(L_2);
		UnityEvent_AddListener_m8AA4287C16628486B41DA41CA5E7A856A706D302(L_2, L_3, NULL);
		// keyboard.onKeyboardModeChanged.AddListener(UpdateKey);
		KeyboardManager_t41DD8382AE61564F08C9856BE00640CCB87720FB* L_4 = __this->___keyboard_5;
		NullCheck(L_4);
		UnityEvent_tDC2C3548799DBC91D1E3F3DE60083A66F4751977* L_5 = L_4->___onKeyboardModeChanged_40;
		UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7* L_6 = (UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7*)il2cpp_codegen_object_new(UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7_il2cpp_TypeInfo_var);
		NullCheck(L_6);
		UnityAction__ctor_mC53E20D6B66E0D5688CD81B88DBB34F5A58B7131(L_6, __this, (intptr_t)((void*)GetVirtualMethodInfo(__this, 7)), NULL);
		NullCheck(L_5);
		UnityEvent_AddListener_m8AA4287C16628486B41DA41CA5E7A856A706D302(L_5, L_6, NULL);
		// keyChannel.onFirstKeyPress.AddListener(UpdateKey);
		KeyChannel_t928FC4C0F40F35E44A1B18D92A9B172B2B760A8A* L_7 = __this->___keyChannel_4;
		NullCheck(L_7);
		UnityEvent_tDC2C3548799DBC91D1E3F3DE60083A66F4751977* L_8 = L_7->___onFirstKeyPress_7;
		UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7* L_9 = (UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7*)il2cpp_codegen_object_new(UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7_il2cpp_TypeInfo_var);
		NullCheck(L_9);
		UnityAction__ctor_mC53E20D6B66E0D5688CD81B88DBB34F5A58B7131(L_9, __this, (intptr_t)((void*)GetVirtualMethodInfo(__this, 7)), NULL);
		NullCheck(L_8);
		UnityEvent_AddListener_m8AA4287C16628486B41DA41CA5E7A856A706D302(L_8, L_9, NULL);
		// keyChannel.OnKeyColorsChanged += ChangeKeyColors;
		KeyChannel_t928FC4C0F40F35E44A1B18D92A9B172B2B760A8A* L_10 = __this->___keyChannel_4;
		KeyChannel_t928FC4C0F40F35E44A1B18D92A9B172B2B760A8A* L_11 = L_10;
		NullCheck(L_11);
		UnityAction_4_t05D51CE8BEA0460D330923E761D421EF194ED9B1* L_12 = L_11->___OnKeyColorsChanged_5;
		UnityAction_4_t05D51CE8BEA0460D330923E761D421EF194ED9B1* L_13 = (UnityAction_4_t05D51CE8BEA0460D330923E761D421EF194ED9B1*)il2cpp_codegen_object_new(UnityAction_4_t05D51CE8BEA0460D330923E761D421EF194ED9B1_il2cpp_TypeInfo_var);
		NullCheck(L_13);
		UnityAction_4__ctor_mE2C6FCF45CF8C72EE9A867DC5FEEF5B05372FFEF(L_13, __this, (intptr_t)((void*)Key_ChangeKeyColors_mF848C4E6D96720A9311F65E6847AEC4E06F92038_RuntimeMethod_var), NULL);
		Delegate_t* L_14;
		L_14 = Delegate_Combine_m1F725AEF318BE6F0426863490691A6F4606E7D00(L_12, L_13, NULL);
		NullCheck(L_11);
		L_11->___OnKeyColorsChanged_5 = ((UnityAction_4_t05D51CE8BEA0460D330923E761D421EF194ED9B1*)Castclass((RuntimeObject*)L_14, UnityAction_4_t05D51CE8BEA0460D330923E761D421EF194ED9B1_il2cpp_TypeInfo_var));
		Il2CppCodeGenWriteBarrier((void**)(&L_11->___OnKeyColorsChanged_5), (void*)((UnityAction_4_t05D51CE8BEA0460D330923E761D421EF194ED9B1*)Castclass((RuntimeObject*)L_14, UnityAction_4_t05D51CE8BEA0460D330923E761D421EF194ED9B1_il2cpp_TypeInfo_var)));
		// keyChannel.OnKeysStateChange += ChangeKeyState;
		KeyChannel_t928FC4C0F40F35E44A1B18D92A9B172B2B760A8A* L_15 = __this->___keyChannel_4;
		KeyChannel_t928FC4C0F40F35E44A1B18D92A9B172B2B760A8A* L_16 = L_15;
		NullCheck(L_16);
		UnityAction_1_t8EC357AF4FBD2A0C4A575C4BBD0B3A81029E43A9* L_17 = L_16->___OnKeysStateChange_6;
		UnityAction_1_t8EC357AF4FBD2A0C4A575C4BBD0B3A81029E43A9* L_18 = (UnityAction_1_t8EC357AF4FBD2A0C4A575C4BBD0B3A81029E43A9*)il2cpp_codegen_object_new(UnityAction_1_t8EC357AF4FBD2A0C4A575C4BBD0B3A81029E43A9_il2cpp_TypeInfo_var);
		NullCheck(L_18);
		UnityAction_1__ctor_m11A393DB3C00474B4520978077E444DB6E4418DD(L_18, __this, (intptr_t)((void*)Key_ChangeKeyState_mD1A5BC6C4AAF356404BEA30434ED235412CF1A66_RuntimeMethod_var), NULL);
		Delegate_t* L_19;
		L_19 = Delegate_Combine_m1F725AEF318BE6F0426863490691A6F4606E7D00(L_17, L_18, NULL);
		NullCheck(L_16);
		L_16->___OnKeysStateChange_6 = ((UnityAction_1_t8EC357AF4FBD2A0C4A575C4BBD0B3A81029E43A9*)Castclass((RuntimeObject*)L_19, UnityAction_1_t8EC357AF4FBD2A0C4A575C4BBD0B3A81029E43A9_il2cpp_TypeInfo_var));
		Il2CppCodeGenWriteBarrier((void**)(&L_16->___OnKeysStateChange_6), (void*)((UnityAction_1_t8EC357AF4FBD2A0C4A575C4BBD0B3A81029E43A9*)Castclass((RuntimeObject*)L_19, UnityAction_1_t8EC357AF4FBD2A0C4A575C4BBD0B3A81029E43A9_il2cpp_TypeInfo_var)));
		// }
		return;
	}
}
// System.Void Keyboard.Key::OnDestroy()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Key_OnDestroy_mCE2AA067E1E423557CA57B9DABE23E2FF68E9348 (Key_tB9DA6A9816AEA58ACE1AE6EA33755EAEEBAC8970* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Key_ChangeKeyColors_mF848C4E6D96720A9311F65E6847AEC4E06F92038_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Key_ChangeKeyState_mD1A5BC6C4AAF356404BEA30434ED235412CF1A66_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&UnityAction_1_t8EC357AF4FBD2A0C4A575C4BBD0B3A81029E43A9_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&UnityAction_4_t05D51CE8BEA0460D330923E761D421EF194ED9B1_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// button.onClick.RemoveListener(OnPress);
		Button_t6786514A57F7AFDEE5431112FEA0CAB24F5AE098* L_0 = __this->___button_6;
		NullCheck(L_0);
		ButtonClickedEvent_t8EA72E90B3BD1392FB3B3EF167D5121C23569E4C* L_1;
		L_1 = Button_get_onClick_m701712A7F7F000CC80D517C4510697E15722C35C_inline(L_0, NULL);
		UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7* L_2 = (UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7*)il2cpp_codegen_object_new(UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7_il2cpp_TypeInfo_var);
		NullCheck(L_2);
		UnityAction__ctor_mC53E20D6B66E0D5688CD81B88DBB34F5A58B7131(L_2, __this, (intptr_t)((void*)GetVirtualMethodInfo(__this, 6)), NULL);
		NullCheck(L_1);
		UnityEvent_RemoveListener_m0E138F5575CB4363019D3DA570E98FAD502B812C(L_1, L_2, NULL);
		// keyboard.onKeyboardModeChanged.RemoveListener(UpdateKey);
		KeyboardManager_t41DD8382AE61564F08C9856BE00640CCB87720FB* L_3 = __this->___keyboard_5;
		NullCheck(L_3);
		UnityEvent_tDC2C3548799DBC91D1E3F3DE60083A66F4751977* L_4 = L_3->___onKeyboardModeChanged_40;
		UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7* L_5 = (UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7*)il2cpp_codegen_object_new(UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7_il2cpp_TypeInfo_var);
		NullCheck(L_5);
		UnityAction__ctor_mC53E20D6B66E0D5688CD81B88DBB34F5A58B7131(L_5, __this, (intptr_t)((void*)GetVirtualMethodInfo(__this, 7)), NULL);
		NullCheck(L_4);
		UnityEvent_RemoveListener_m0E138F5575CB4363019D3DA570E98FAD502B812C(L_4, L_5, NULL);
		// keyChannel.onFirstKeyPress.RemoveListener(UpdateKey);
		KeyChannel_t928FC4C0F40F35E44A1B18D92A9B172B2B760A8A* L_6 = __this->___keyChannel_4;
		NullCheck(L_6);
		UnityEvent_tDC2C3548799DBC91D1E3F3DE60083A66F4751977* L_7 = L_6->___onFirstKeyPress_7;
		UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7* L_8 = (UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7*)il2cpp_codegen_object_new(UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7_il2cpp_TypeInfo_var);
		NullCheck(L_8);
		UnityAction__ctor_mC53E20D6B66E0D5688CD81B88DBB34F5A58B7131(L_8, __this, (intptr_t)((void*)GetVirtualMethodInfo(__this, 7)), NULL);
		NullCheck(L_7);
		UnityEvent_RemoveListener_m0E138F5575CB4363019D3DA570E98FAD502B812C(L_7, L_8, NULL);
		// keyChannel.OnKeyColorsChanged -= ChangeKeyColors;
		KeyChannel_t928FC4C0F40F35E44A1B18D92A9B172B2B760A8A* L_9 = __this->___keyChannel_4;
		KeyChannel_t928FC4C0F40F35E44A1B18D92A9B172B2B760A8A* L_10 = L_9;
		NullCheck(L_10);
		UnityAction_4_t05D51CE8BEA0460D330923E761D421EF194ED9B1* L_11 = L_10->___OnKeyColorsChanged_5;
		UnityAction_4_t05D51CE8BEA0460D330923E761D421EF194ED9B1* L_12 = (UnityAction_4_t05D51CE8BEA0460D330923E761D421EF194ED9B1*)il2cpp_codegen_object_new(UnityAction_4_t05D51CE8BEA0460D330923E761D421EF194ED9B1_il2cpp_TypeInfo_var);
		NullCheck(L_12);
		UnityAction_4__ctor_mE2C6FCF45CF8C72EE9A867DC5FEEF5B05372FFEF(L_12, __this, (intptr_t)((void*)Key_ChangeKeyColors_mF848C4E6D96720A9311F65E6847AEC4E06F92038_RuntimeMethod_var), NULL);
		Delegate_t* L_13;
		L_13 = Delegate_Remove_m8B7DD5661308FA972E23CA1CC3FC9CEB355504E3(L_11, L_12, NULL);
		NullCheck(L_10);
		L_10->___OnKeyColorsChanged_5 = ((UnityAction_4_t05D51CE8BEA0460D330923E761D421EF194ED9B1*)Castclass((RuntimeObject*)L_13, UnityAction_4_t05D51CE8BEA0460D330923E761D421EF194ED9B1_il2cpp_TypeInfo_var));
		Il2CppCodeGenWriteBarrier((void**)(&L_10->___OnKeyColorsChanged_5), (void*)((UnityAction_4_t05D51CE8BEA0460D330923E761D421EF194ED9B1*)Castclass((RuntimeObject*)L_13, UnityAction_4_t05D51CE8BEA0460D330923E761D421EF194ED9B1_il2cpp_TypeInfo_var)));
		// keyChannel.OnKeysStateChange -= ChangeKeyState;
		KeyChannel_t928FC4C0F40F35E44A1B18D92A9B172B2B760A8A* L_14 = __this->___keyChannel_4;
		KeyChannel_t928FC4C0F40F35E44A1B18D92A9B172B2B760A8A* L_15 = L_14;
		NullCheck(L_15);
		UnityAction_1_t8EC357AF4FBD2A0C4A575C4BBD0B3A81029E43A9* L_16 = L_15->___OnKeysStateChange_6;
		UnityAction_1_t8EC357AF4FBD2A0C4A575C4BBD0B3A81029E43A9* L_17 = (UnityAction_1_t8EC357AF4FBD2A0C4A575C4BBD0B3A81029E43A9*)il2cpp_codegen_object_new(UnityAction_1_t8EC357AF4FBD2A0C4A575C4BBD0B3A81029E43A9_il2cpp_TypeInfo_var);
		NullCheck(L_17);
		UnityAction_1__ctor_m11A393DB3C00474B4520978077E444DB6E4418DD(L_17, __this, (intptr_t)((void*)Key_ChangeKeyState_mD1A5BC6C4AAF356404BEA30434ED235412CF1A66_RuntimeMethod_var), NULL);
		Delegate_t* L_18;
		L_18 = Delegate_Remove_m8B7DD5661308FA972E23CA1CC3FC9CEB355504E3(L_16, L_17, NULL);
		NullCheck(L_15);
		L_15->___OnKeysStateChange_6 = ((UnityAction_1_t8EC357AF4FBD2A0C4A575C4BBD0B3A81029E43A9*)Castclass((RuntimeObject*)L_18, UnityAction_1_t8EC357AF4FBD2A0C4A575C4BBD0B3A81029E43A9_il2cpp_TypeInfo_var));
		Il2CppCodeGenWriteBarrier((void**)(&L_15->___OnKeysStateChange_6), (void*)((UnityAction_1_t8EC357AF4FBD2A0C4A575C4BBD0B3A81029E43A9*)Castclass((RuntimeObject*)L_18, UnityAction_1_t8EC357AF4FBD2A0C4A575C4BBD0B3A81029E43A9_il2cpp_TypeInfo_var)));
		// }
		return;
	}
}
// System.Void Keyboard.Key::OnPress()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Key_OnPress_m71355FFA48E3DD2D8924B5C1B9E504B2D0EAE92C (Key_tB9DA6A9816AEA58ACE1AE6EA33755EAEEBAC8970* __this, const RuntimeMethod* method) 
{
	{
		// keyboard.DeactivateShift();
		KeyboardManager_t41DD8382AE61564F08C9856BE00640CCB87720FB* L_0 = __this->___keyboard_5;
		NullCheck(L_0);
		KeyboardManager_DeactivateShift_m5583AF2C623B7571D949EB0AC968DF509284F400(L_0, NULL);
		// }
		return;
	}
}
// System.Void Keyboard.Key::UpdateKey()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Key_UpdateKey_m23BCD5A10DBFCE21DC570F2405CEB24A76AD3BD7 (Key_tB9DA6A9816AEA58ACE1AE6EA33755EAEEBAC8970* __this, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void Keyboard.Key::ChangeKeyColors(UnityEngine.Color,UnityEngine.Color,UnityEngine.Color,UnityEngine.Color)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Key_ChangeKeyColors_mF848C4E6D96720A9311F65E6847AEC4E06F92038 (Key_tB9DA6A9816AEA58ACE1AE6EA33755EAEEBAC8970* __this, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___0_normalColor, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___1_highlightedColor, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___2_pressedColor, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___3_selectedColor, const RuntimeMethod* method) 
{
	ColorBlock_tDD7C62E7AFE442652FC98F8D058CE8AE6BFD7C11 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		// ColorBlock cb = button.colors;
		Button_t6786514A57F7AFDEE5431112FEA0CAB24F5AE098* L_0 = __this->___button_6;
		NullCheck(L_0);
		ColorBlock_tDD7C62E7AFE442652FC98F8D058CE8AE6BFD7C11 L_1;
		L_1 = Selectable_get_colors_mB53E365D02351D4B64084295C4B2A7AF2DEC4750_inline(L_0, NULL);
		V_0 = L_1;
		// cb.normalColor = normalColor;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_2 = ___0_normalColor;
		ColorBlock_set_normalColor_m3EBF594F6FA2C6494ACA9FCB9B458807D85B96F8_inline((&V_0), L_2, NULL);
		// cb.highlightedColor = highlightedColor;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_3 = ___1_highlightedColor;
		ColorBlock_set_highlightedColor_m04E97DF2CCE7CAC47120D8F486E18BF62F16FF86_inline((&V_0), L_3, NULL);
		// cb.pressedColor = pressedColor;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_4 = ___2_pressedColor;
		ColorBlock_set_pressedColor_m644C938090857AB07C57B25FE53F6DC2BB0DD5A8_inline((&V_0), L_4, NULL);
		// cb.selectedColor = selectedColor;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_5 = ___3_selectedColor;
		ColorBlock_set_selectedColor_m76FEFB1148798B7A356C974CDEA3BA2E2E3C1D21_inline((&V_0), L_5, NULL);
		// button.colors = cb;
		Button_t6786514A57F7AFDEE5431112FEA0CAB24F5AE098* L_6 = __this->___button_6;
		ColorBlock_tDD7C62E7AFE442652FC98F8D058CE8AE6BFD7C11 L_7 = V_0;
		NullCheck(L_6);
		Selectable_set_colors_m0A49ED3ACD6647B7E5A2DA10B3D417E8FE1BE55A(L_6, L_7, NULL);
		// }
		return;
	}
}
// System.Void Keyboard.Key::ChangeKeyState(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Key_ChangeKeyState_mD1A5BC6C4AAF356404BEA30434ED235412CF1A66 (Key_tB9DA6A9816AEA58ACE1AE6EA33755EAEEBAC8970* __this, bool ___0_enabled, const RuntimeMethod* method) 
{
	{
		// button.interactable = enabled;
		Button_t6786514A57F7AFDEE5431112FEA0CAB24F5AE098* L_0 = __this->___button_6;
		bool L_1 = ___0_enabled;
		NullCheck(L_0);
		Selectable_set_interactable_m8DD581C1AD99B2EFA8B3EE9AF69EDDF26688B492(L_0, L_1, NULL);
		// }
		return;
	}
}
// System.Void Keyboard.Key::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Key__ctor_m9C214508D172EE99713AC7F36C9B0309D9C77312 (Key_tB9DA6A9816AEA58ACE1AE6EA33755EAEEBAC8970* __this, const RuntimeMethod* method) 
{
	{
		MonoBehaviour__ctor_m592DB0105CA0BC97AA1C5F4AD27B12D68A3B7C1E(__this, NULL);
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
// System.Void Keyboard.KeyboardManager::Awake()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void KeyboardManager_Awake_m065966AA2EB6496D7A50A2DACF1B1630993ECF63 (KeyboardManager_t41DD8382AE61564F08C9856BE00640CCB87720FB* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Component_GetComponentInChildren_TisTextMeshProUGUI_t101091AF4B578BB534C92E9D1EEAF0611636D957_m60A1B193FDBBFB3719065622DB5E0BB21CA4ABDC_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&KeyboardManager_OnDeletePress_mF2C78138A5C6B941C45092D2705C28944C42AE94_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&KeyboardManager_OnShiftPress_mF04B1244E8EB01E629B736A32297C46C2457A9E9_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&KeyboardManager_OnSpacePress_m38F1CC2F29F04AD3B6DEC34AB6377E8B26086124_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&KeyboardManager_OnSwitchPress_m593AE16BABC05F9A43E1A26CDB30CD1062817479_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&KeyboardManager_SwitchBetweenNumbersAndSpecialCharacters_m3004A040F523A15EBAB631216BBD0E4D6BFA0AF7_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// shiftButtonColors = shiftButton.colors;
		Button_t6786514A57F7AFDEE5431112FEA0CAB24F5AE098* L_0 = __this->___shiftButton_16;
		NullCheck(L_0);
		ColorBlock_tDD7C62E7AFE442652FC98F8D058CE8AE6BFD7C11 L_1;
		L_1 = Selectable_get_colors_mB53E365D02351D4B64084295C4B2A7AF2DEC4750_inline(L_0, NULL);
		__this->___shiftButtonColors_32 = L_1;
		// CheckTextLength();
		KeyboardManager_CheckTextLength_m29214ABD71A9EF74FD355FDE3FC2575DF015D55B(__this, NULL);
		// speechButton.interactable = false;
		Button_t6786514A57F7AFDEE5431112FEA0CAB24F5AE098* L_2 = __this->___speechButton_6;
		NullCheck(L_2);
		Selectable_set_interactable_m8DD581C1AD99B2EFA8B3EE9AF69EDDF26688B492(L_2, (bool)0, NULL);
		// spacebarButton.onClick.AddListener(OnSpacePress);
		Button_t6786514A57F7AFDEE5431112FEA0CAB24F5AE098* L_3 = __this->___spacebarButton_5;
		NullCheck(L_3);
		ButtonClickedEvent_t8EA72E90B3BD1392FB3B3EF167D5121C23569E4C* L_4;
		L_4 = Button_get_onClick_m701712A7F7F000CC80D517C4510697E15722C35C_inline(L_3, NULL);
		UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7* L_5 = (UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7*)il2cpp_codegen_object_new(UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7_il2cpp_TypeInfo_var);
		NullCheck(L_5);
		UnityAction__ctor_mC53E20D6B66E0D5688CD81B88DBB34F5A58B7131(L_5, __this, (intptr_t)((void*)KeyboardManager_OnSpacePress_m38F1CC2F29F04AD3B6DEC34AB6377E8B26086124_RuntimeMethod_var), NULL);
		NullCheck(L_4);
		UnityEvent_AddListener_m8AA4287C16628486B41DA41CA5E7A856A706D302(L_4, L_5, NULL);
		// deleteButton.onClick.AddListener(OnDeletePress);
		Button_t6786514A57F7AFDEE5431112FEA0CAB24F5AE098* L_6 = __this->___deleteButton_7;
		NullCheck(L_6);
		ButtonClickedEvent_t8EA72E90B3BD1392FB3B3EF167D5121C23569E4C* L_7;
		L_7 = Button_get_onClick_m701712A7F7F000CC80D517C4510697E15722C35C_inline(L_6, NULL);
		UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7* L_8 = (UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7*)il2cpp_codegen_object_new(UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7_il2cpp_TypeInfo_var);
		NullCheck(L_8);
		UnityAction__ctor_mC53E20D6B66E0D5688CD81B88DBB34F5A58B7131(L_8, __this, (intptr_t)((void*)KeyboardManager_OnDeletePress_mF2C78138A5C6B941C45092D2705C28944C42AE94_RuntimeMethod_var), NULL);
		NullCheck(L_7);
		UnityEvent_AddListener_m8AA4287C16628486B41DA41CA5E7A856A706D302(L_7, L_8, NULL);
		// switchButton.onClick.AddListener(OnSwitchPress);
		Button_t6786514A57F7AFDEE5431112FEA0CAB24F5AE098* L_9 = __this->___switchButton_8;
		NullCheck(L_9);
		ButtonClickedEvent_t8EA72E90B3BD1392FB3B3EF167D5121C23569E4C* L_10;
		L_10 = Button_get_onClick_m701712A7F7F000CC80D517C4510697E15722C35C_inline(L_9, NULL);
		UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7* L_11 = (UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7*)il2cpp_codegen_object_new(UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7_il2cpp_TypeInfo_var);
		NullCheck(L_11);
		UnityAction__ctor_mC53E20D6B66E0D5688CD81B88DBB34F5A58B7131(L_11, __this, (intptr_t)((void*)KeyboardManager_OnSwitchPress_m593AE16BABC05F9A43E1A26CDB30CD1062817479_RuntimeMethod_var), NULL);
		NullCheck(L_10);
		UnityEvent_AddListener_m8AA4287C16628486B41DA41CA5E7A856A706D302(L_10, L_11, NULL);
		// shiftButton.onClick.AddListener(OnShiftPress);
		Button_t6786514A57F7AFDEE5431112FEA0CAB24F5AE098* L_12 = __this->___shiftButton_16;
		NullCheck(L_12);
		ButtonClickedEvent_t8EA72E90B3BD1392FB3B3EF167D5121C23569E4C* L_13;
		L_13 = Button_get_onClick_m701712A7F7F000CC80D517C4510697E15722C35C_inline(L_12, NULL);
		UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7* L_14 = (UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7*)il2cpp_codegen_object_new(UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7_il2cpp_TypeInfo_var);
		NullCheck(L_14);
		UnityAction__ctor_mC53E20D6B66E0D5688CD81B88DBB34F5A58B7131(L_14, __this, (intptr_t)((void*)KeyboardManager_OnShiftPress_mF04B1244E8EB01E629B736A32297C46C2457A9E9_RuntimeMethod_var), NULL);
		NullCheck(L_13);
		UnityEvent_AddListener_m8AA4287C16628486B41DA41CA5E7A856A706D302(L_13, L_14, NULL);
		// switchNumberSpecialButton.onClick.AddListener(SwitchBetweenNumbersAndSpecialCharacters);
		Button_t6786514A57F7AFDEE5431112FEA0CAB24F5AE098* L_15 = __this->___switchNumberSpecialButton_20;
		NullCheck(L_15);
		ButtonClickedEvent_t8EA72E90B3BD1392FB3B3EF167D5121C23569E4C* L_16;
		L_16 = Button_get_onClick_m701712A7F7F000CC80D517C4510697E15722C35C_inline(L_15, NULL);
		UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7* L_17 = (UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7*)il2cpp_codegen_object_new(UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7_il2cpp_TypeInfo_var);
		NullCheck(L_17);
		UnityAction__ctor_mC53E20D6B66E0D5688CD81B88DBB34F5A58B7131(L_17, __this, (intptr_t)((void*)KeyboardManager_SwitchBetweenNumbersAndSpecialCharacters_m3004A040F523A15EBAB631216BBD0E4D6BFA0AF7_RuntimeMethod_var), NULL);
		NullCheck(L_16);
		UnityEvent_AddListener_m8AA4287C16628486B41DA41CA5E7A856A706D302(L_16, L_17, NULL);
		// switchButtonText = switchButton.GetComponentInChildren<TextMeshProUGUI>();
		Button_t6786514A57F7AFDEE5431112FEA0CAB24F5AE098* L_18 = __this->___switchButton_8;
		NullCheck(L_18);
		TextMeshProUGUI_t101091AF4B578BB534C92E9D1EEAF0611636D957* L_19;
		L_19 = Component_GetComponentInChildren_TisTextMeshProUGUI_t101091AF4B578BB534C92E9D1EEAF0611636D957_m60A1B193FDBBFB3719065622DB5E0BB21CA4ABDC(L_18, Component_GetComponentInChildren_TisTextMeshProUGUI_t101091AF4B578BB534C92E9D1EEAF0611636D957_m60A1B193FDBBFB3719065622DB5E0BB21CA4ABDC_RuntimeMethod_var);
		__this->___switchButtonText_11 = L_19;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___switchButtonText_11), (void*)L_19);
		// switchNumSpecButtonText = switchNumberSpecialButton.GetComponentInChildren<TextMeshProUGUI>();
		Button_t6786514A57F7AFDEE5431112FEA0CAB24F5AE098* L_20 = __this->___switchNumberSpecialButton_20;
		NullCheck(L_20);
		TextMeshProUGUI_t101091AF4B578BB534C92E9D1EEAF0611636D957* L_21;
		L_21 = Component_GetComponentInChildren_TisTextMeshProUGUI_t101091AF4B578BB534C92E9D1EEAF0611636D957_m60A1B193FDBBFB3719065622DB5E0BB21CA4ABDC(L_20, Component_GetComponentInChildren_TisTextMeshProUGUI_t101091AF4B578BB534C92E9D1EEAF0611636D957_m60A1B193FDBBFB3719065622DB5E0BB21CA4ABDC_RuntimeMethod_var);
		__this->___switchNumSpecButtonText_23 = L_21;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___switchNumSpecButtonText_23), (void*)L_21);
		// keyChannel.RaiseKeyColorsChangedEvent(normalColor, highlightedColor, pressedColor, selectedColor);
		KeyChannel_t928FC4C0F40F35E44A1B18D92A9B172B2B760A8A* L_22 = __this->___keyChannel_4;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_23 = __this->___normalColor_24;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_24 = __this->___highlightedColor_25;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_25 = __this->___pressedColor_26;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_26 = __this->___selectedColor_27;
		NullCheck(L_22);
		KeyChannel_RaiseKeyColorsChangedEvent_mD1C7EE314F1390115D846C87B8E06805D5CBDC50(L_22, L_23, L_24, L_25, L_26, NULL);
		// switchNumberSpecialButton.gameObject.SetActive(false);
		Button_t6786514A57F7AFDEE5431112FEA0CAB24F5AE098* L_27 = __this->___switchNumberSpecialButton_20;
		NullCheck(L_27);
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_28;
		L_28 = Component_get_gameObject_m57AEFBB14DB39EC476F740BA000E170355DE691B(L_27, NULL);
		NullCheck(L_28);
		GameObject_SetActive_m638E92E1E75E519E5B24CF150B08CA8E0CDFAB92(L_28, (bool)0, NULL);
		// numbersKeyboard.SetActive(false);
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_29 = __this->___numbersKeyboard_13;
		NullCheck(L_29);
		GameObject_SetActive_m638E92E1E75E519E5B24CF150B08CA8E0CDFAB92(L_29, (bool)0, NULL);
		// specialCharactersKeyboard.SetActive(false);
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_30 = __this->___specialCharactersKeyboard_14;
		NullCheck(L_30);
		GameObject_SetActive_m638E92E1E75E519E5B24CF150B08CA8E0CDFAB92(L_30, (bool)0, NULL);
		// if (!autoCapsAtStart) return;
		bool L_31 = __this->___autoCapsAtStart_15;
		if (L_31)
		{
			goto IL_0126;
		}
	}
	{
		// if (!autoCapsAtStart) return;
		return;
	}

IL_0126:
	{
		// ActivateShift();
		KeyboardManager_ActivateShift_m4618EDB6F0C88292C071EB032A812B48ABF0AB1E(__this, NULL);
		// UpdateShiftButtonAppearance();
		KeyboardManager_UpdateShiftButtonAppearance_m14947FCA031715FE3843587C48002A45F7BEC128(__this, NULL);
		// }
		return;
	}
}
// System.Void Keyboard.KeyboardManager::OnDestroy()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void KeyboardManager_OnDestroy_m4D5B236923E58B2CC1EA0A8A67E15A5603AFE4C0 (KeyboardManager_t41DD8382AE61564F08C9856BE00640CCB87720FB* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&KeyboardManager_OnDeletePress_mF2C78138A5C6B941C45092D2705C28944C42AE94_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&KeyboardManager_OnShiftPress_mF04B1244E8EB01E629B736A32297C46C2457A9E9_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&KeyboardManager_OnSpacePress_m38F1CC2F29F04AD3B6DEC34AB6377E8B26086124_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&KeyboardManager_OnSwitchPress_m593AE16BABC05F9A43E1A26CDB30CD1062817479_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&KeyboardManager_SwitchBetweenNumbersAndSpecialCharacters_m3004A040F523A15EBAB631216BBD0E4D6BFA0AF7_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// spacebarButton.onClick.RemoveListener(OnSpacePress);
		Button_t6786514A57F7AFDEE5431112FEA0CAB24F5AE098* L_0 = __this->___spacebarButton_5;
		NullCheck(L_0);
		ButtonClickedEvent_t8EA72E90B3BD1392FB3B3EF167D5121C23569E4C* L_1;
		L_1 = Button_get_onClick_m701712A7F7F000CC80D517C4510697E15722C35C_inline(L_0, NULL);
		UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7* L_2 = (UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7*)il2cpp_codegen_object_new(UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7_il2cpp_TypeInfo_var);
		NullCheck(L_2);
		UnityAction__ctor_mC53E20D6B66E0D5688CD81B88DBB34F5A58B7131(L_2, __this, (intptr_t)((void*)KeyboardManager_OnSpacePress_m38F1CC2F29F04AD3B6DEC34AB6377E8B26086124_RuntimeMethod_var), NULL);
		NullCheck(L_1);
		UnityEvent_RemoveListener_m0E138F5575CB4363019D3DA570E98FAD502B812C(L_1, L_2, NULL);
		// deleteButton.onClick.RemoveListener(OnDeletePress);
		Button_t6786514A57F7AFDEE5431112FEA0CAB24F5AE098* L_3 = __this->___deleteButton_7;
		NullCheck(L_3);
		ButtonClickedEvent_t8EA72E90B3BD1392FB3B3EF167D5121C23569E4C* L_4;
		L_4 = Button_get_onClick_m701712A7F7F000CC80D517C4510697E15722C35C_inline(L_3, NULL);
		UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7* L_5 = (UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7*)il2cpp_codegen_object_new(UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7_il2cpp_TypeInfo_var);
		NullCheck(L_5);
		UnityAction__ctor_mC53E20D6B66E0D5688CD81B88DBB34F5A58B7131(L_5, __this, (intptr_t)((void*)KeyboardManager_OnDeletePress_mF2C78138A5C6B941C45092D2705C28944C42AE94_RuntimeMethod_var), NULL);
		NullCheck(L_4);
		UnityEvent_RemoveListener_m0E138F5575CB4363019D3DA570E98FAD502B812C(L_4, L_5, NULL);
		// switchButton.onClick.RemoveListener(OnSwitchPress);
		Button_t6786514A57F7AFDEE5431112FEA0CAB24F5AE098* L_6 = __this->___switchButton_8;
		NullCheck(L_6);
		ButtonClickedEvent_t8EA72E90B3BD1392FB3B3EF167D5121C23569E4C* L_7;
		L_7 = Button_get_onClick_m701712A7F7F000CC80D517C4510697E15722C35C_inline(L_6, NULL);
		UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7* L_8 = (UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7*)il2cpp_codegen_object_new(UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7_il2cpp_TypeInfo_var);
		NullCheck(L_8);
		UnityAction__ctor_mC53E20D6B66E0D5688CD81B88DBB34F5A58B7131(L_8, __this, (intptr_t)((void*)KeyboardManager_OnSwitchPress_m593AE16BABC05F9A43E1A26CDB30CD1062817479_RuntimeMethod_var), NULL);
		NullCheck(L_7);
		UnityEvent_RemoveListener_m0E138F5575CB4363019D3DA570E98FAD502B812C(L_7, L_8, NULL);
		// shiftButton.onClick.RemoveListener(OnShiftPress);
		Button_t6786514A57F7AFDEE5431112FEA0CAB24F5AE098* L_9 = __this->___shiftButton_16;
		NullCheck(L_9);
		ButtonClickedEvent_t8EA72E90B3BD1392FB3B3EF167D5121C23569E4C* L_10;
		L_10 = Button_get_onClick_m701712A7F7F000CC80D517C4510697E15722C35C_inline(L_9, NULL);
		UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7* L_11 = (UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7*)il2cpp_codegen_object_new(UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7_il2cpp_TypeInfo_var);
		NullCheck(L_11);
		UnityAction__ctor_mC53E20D6B66E0D5688CD81B88DBB34F5A58B7131(L_11, __this, (intptr_t)((void*)KeyboardManager_OnShiftPress_mF04B1244E8EB01E629B736A32297C46C2457A9E9_RuntimeMethod_var), NULL);
		NullCheck(L_10);
		UnityEvent_RemoveListener_m0E138F5575CB4363019D3DA570E98FAD502B812C(L_10, L_11, NULL);
		// switchNumberSpecialButton.onClick.RemoveListener(SwitchBetweenNumbersAndSpecialCharacters);
		Button_t6786514A57F7AFDEE5431112FEA0CAB24F5AE098* L_12 = __this->___switchNumberSpecialButton_20;
		NullCheck(L_12);
		ButtonClickedEvent_t8EA72E90B3BD1392FB3B3EF167D5121C23569E4C* L_13;
		L_13 = Button_get_onClick_m701712A7F7F000CC80D517C4510697E15722C35C_inline(L_12, NULL);
		UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7* L_14 = (UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7*)il2cpp_codegen_object_new(UnityAction_t11A1F3B953B365C072A5DCC32677EE1796A962A7_il2cpp_TypeInfo_var);
		NullCheck(L_14);
		UnityAction__ctor_mC53E20D6B66E0D5688CD81B88DBB34F5A58B7131(L_14, __this, (intptr_t)((void*)KeyboardManager_SwitchBetweenNumbersAndSpecialCharacters_m3004A040F523A15EBAB631216BBD0E4D6BFA0AF7_RuntimeMethod_var), NULL);
		NullCheck(L_13);
		UnityEvent_RemoveListener_m0E138F5575CB4363019D3DA570E98FAD502B812C(L_13, L_14, NULL);
		// }
		return;
	}
}
// System.Void Keyboard.KeyboardManager::OnEnable()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void KeyboardManager_OnEnable_m958C7E01AC12DA9153228B461036E437B734D0B9 (KeyboardManager_t41DD8382AE61564F08C9856BE00640CCB87720FB* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&KeyboardManager_KeyPress_m4D6965693DBCED4B36CE839C7A9C702EA37BDBF0_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&UnityAction_1_t690494F0E492A2098660E28B8EB7D71B2C69BE1B_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// private void OnEnable() => keyChannel.OnKeyPressed += KeyPress;
		KeyChannel_t928FC4C0F40F35E44A1B18D92A9B172B2B760A8A* L_0 = __this->___keyChannel_4;
		KeyChannel_t928FC4C0F40F35E44A1B18D92A9B172B2B760A8A* L_1 = L_0;
		NullCheck(L_1);
		UnityAction_1_t690494F0E492A2098660E28B8EB7D71B2C69BE1B* L_2 = L_1->___OnKeyPressed_4;
		UnityAction_1_t690494F0E492A2098660E28B8EB7D71B2C69BE1B* L_3 = (UnityAction_1_t690494F0E492A2098660E28B8EB7D71B2C69BE1B*)il2cpp_codegen_object_new(UnityAction_1_t690494F0E492A2098660E28B8EB7D71B2C69BE1B_il2cpp_TypeInfo_var);
		NullCheck(L_3);
		UnityAction_1__ctor_mE6251CCFD943EB114960F556A546E2777B18AC71(L_3, __this, (intptr_t)((void*)KeyboardManager_KeyPress_m4D6965693DBCED4B36CE839C7A9C702EA37BDBF0_RuntimeMethod_var), NULL);
		Delegate_t* L_4;
		L_4 = Delegate_Combine_m1F725AEF318BE6F0426863490691A6F4606E7D00(L_2, L_3, NULL);
		NullCheck(L_1);
		L_1->___OnKeyPressed_4 = ((UnityAction_1_t690494F0E492A2098660E28B8EB7D71B2C69BE1B*)Castclass((RuntimeObject*)L_4, UnityAction_1_t690494F0E492A2098660E28B8EB7D71B2C69BE1B_il2cpp_TypeInfo_var));
		Il2CppCodeGenWriteBarrier((void**)(&L_1->___OnKeyPressed_4), (void*)((UnityAction_1_t690494F0E492A2098660E28B8EB7D71B2C69BE1B*)Castclass((RuntimeObject*)L_4, UnityAction_1_t690494F0E492A2098660E28B8EB7D71B2C69BE1B_il2cpp_TypeInfo_var)));
		return;
	}
}
// System.Void Keyboard.KeyboardManager::OnDisable()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void KeyboardManager_OnDisable_m265E353D4F271422457616877500475488EF6107 (KeyboardManager_t41DD8382AE61564F08C9856BE00640CCB87720FB* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&KeyboardManager_KeyPress_m4D6965693DBCED4B36CE839C7A9C702EA37BDBF0_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&UnityAction_1_t690494F0E492A2098660E28B8EB7D71B2C69BE1B_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// private void OnDisable() => keyChannel.OnKeyPressed -= KeyPress;
		KeyChannel_t928FC4C0F40F35E44A1B18D92A9B172B2B760A8A* L_0 = __this->___keyChannel_4;
		KeyChannel_t928FC4C0F40F35E44A1B18D92A9B172B2B760A8A* L_1 = L_0;
		NullCheck(L_1);
		UnityAction_1_t690494F0E492A2098660E28B8EB7D71B2C69BE1B* L_2 = L_1->___OnKeyPressed_4;
		UnityAction_1_t690494F0E492A2098660E28B8EB7D71B2C69BE1B* L_3 = (UnityAction_1_t690494F0E492A2098660E28B8EB7D71B2C69BE1B*)il2cpp_codegen_object_new(UnityAction_1_t690494F0E492A2098660E28B8EB7D71B2C69BE1B_il2cpp_TypeInfo_var);
		NullCheck(L_3);
		UnityAction_1__ctor_mE6251CCFD943EB114960F556A546E2777B18AC71(L_3, __this, (intptr_t)((void*)KeyboardManager_KeyPress_m4D6965693DBCED4B36CE839C7A9C702EA37BDBF0_RuntimeMethod_var), NULL);
		Delegate_t* L_4;
		L_4 = Delegate_Remove_m8B7DD5661308FA972E23CA1CC3FC9CEB355504E3(L_2, L_3, NULL);
		NullCheck(L_1);
		L_1->___OnKeyPressed_4 = ((UnityAction_1_t690494F0E492A2098660E28B8EB7D71B2C69BE1B*)Castclass((RuntimeObject*)L_4, UnityAction_1_t690494F0E492A2098660E28B8EB7D71B2C69BE1B_il2cpp_TypeInfo_var));
		Il2CppCodeGenWriteBarrier((void**)(&L_1->___OnKeyPressed_4), (void*)((UnityAction_1_t690494F0E492A2098660E28B8EB7D71B2C69BE1B*)Castclass((RuntimeObject*)L_4, UnityAction_1_t690494F0E492A2098660E28B8EB7D71B2C69BE1B_il2cpp_TypeInfo_var)));
		return;
	}
}
// System.Void Keyboard.KeyboardManager::Update()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void KeyboardManager_Update_m6369EFD26203E42EFD842681AEDAB682A494DEBA (KeyboardManager_t41DD8382AE61564F08C9856BE00640CCB87720FB* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GameObject_GetComponent_TisTMP_InputField_t3488E0EE8C3DF56C6A328EC95D1BEEA2DF4A7D5F_m6CA031C91E5D203C24D3315721B6E3910B9C8729_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// if(eventSystem.currentSelectedGameObject != selectedGameObject){
		EventSystem_t61C51380B105BE9D2C39C4F15B7E655659957707* L_0 = __this->___eventSystem_41;
		NullCheck(L_0);
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_1;
		L_1 = EventSystem_get_currentSelectedGameObject_mD606FFACF3E72755298A523CBB709535CF08C98A_inline(L_0, NULL);
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_2 = __this->___selectedGameObject_42;
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = Object_op_Inequality_mD0BE578448EAA61948F25C32F8DD55AB1F778602(L_1, L_2, NULL);
		if (!L_3)
		{
			goto IL_005b;
		}
	}
	{
		// selectedGameObject = eventSystem.currentSelectedGameObject;
		EventSystem_t61C51380B105BE9D2C39C4F15B7E655659957707* L_4 = __this->___eventSystem_41;
		NullCheck(L_4);
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_5;
		L_5 = EventSystem_get_currentSelectedGameObject_mD606FFACF3E72755298A523CBB709535CF08C98A_inline(L_4, NULL);
		__this->___selectedGameObject_42 = L_5;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___selectedGameObject_42), (void*)L_5);
		// if(selectedGameObject != null){
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_6 = __this->___selectedGameObject_42;
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		bool L_7;
		L_7 = Object_op_Inequality_mD0BE578448EAA61948F25C32F8DD55AB1F778602(L_6, (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C*)NULL, NULL);
		if (!L_7)
		{
			goto IL_005b;
		}
	}
	{
		// if(selectedGameObject.GetComponent<TMP_InputField>() != null){
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_8 = __this->___selectedGameObject_42;
		NullCheck(L_8);
		TMP_InputField_t3488E0EE8C3DF56C6A328EC95D1BEEA2DF4A7D5F* L_9;
		L_9 = GameObject_GetComponent_TisTMP_InputField_t3488E0EE8C3DF56C6A328EC95D1BEEA2DF4A7D5F_m6CA031C91E5D203C24D3315721B6E3910B9C8729(L_8, GameObject_GetComponent_TisTMP_InputField_t3488E0EE8C3DF56C6A328EC95D1BEEA2DF4A7D5F_m6CA031C91E5D203C24D3315721B6E3910B9C8729_RuntimeMethod_var);
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		bool L_10;
		L_10 = Object_op_Inequality_mD0BE578448EAA61948F25C32F8DD55AB1F778602(L_9, (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C*)NULL, NULL);
		if (!L_10)
		{
			goto IL_005b;
		}
	}
	{
		// outputField = selectedGameObject.GetComponent<TMP_InputField>();
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_11 = __this->___selectedGameObject_42;
		NullCheck(L_11);
		TMP_InputField_t3488E0EE8C3DF56C6A328EC95D1BEEA2DF4A7D5F* L_12;
		L_12 = GameObject_GetComponent_TisTMP_InputField_t3488E0EE8C3DF56C6A328EC95D1BEEA2DF4A7D5F_m6CA031C91E5D203C24D3315721B6E3910B9C8729(L_11, GameObject_GetComponent_TisTMP_InputField_t3488E0EE8C3DF56C6A328EC95D1BEEA2DF4A7D5F_m6CA031C91E5D203C24D3315721B6E3910B9C8729_RuntimeMethod_var);
		__this->___outputField_28 = L_12;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___outputField_28), (void*)L_12);
	}

IL_005b:
	{
		// }
		return;
	}
}
// System.Void Keyboard.KeyboardManager::KeyPress(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void KeyboardManager_KeyPress_m4D6965693DBCED4B36CE839C7A9C702EA37BDBF0 (KeyboardManager_t41DD8382AE61564F08C9856BE00640CCB87720FB* __this, String_t* ___0_key, const RuntimeMethod* method) 
{
	String_t* V_0 = NULL;
	int32_t V_1 = 0;
	int32_t V_2 = 0;
	int32_t V_3 = 0;
	{
		// keyHasBeenPressed = true;
		__this->___keyHasBeenPressed_34 = (bool)1;
		// bool wasShiftActive = shiftActive;
		bool L_0 = __this->___shiftActive_35;
		// DeactivateShift();
		KeyboardManager_DeactivateShift_m5583AF2C623B7571D949EB0AC968DF509284F400(__this, NULL);
		// if (wasShiftActive || capsLockActive)
		if (L_0)
		{
			goto IL_001d;
		}
	}
	{
		bool L_1 = __this->___capsLockActive_36;
		if (!L_1)
		{
			goto IL_0026;
		}
	}

IL_001d:
	{
		// textToInsert = key.ToUpper();
		String_t* L_2 = ___0_key;
		NullCheck(L_2);
		String_t* L_3;
		L_3 = String_ToUpper_m5F499BC30C2A5F5C96248B4C3D1A3B4694748B49(L_2, NULL);
		V_0 = L_3;
		goto IL_002d;
	}

IL_0026:
	{
		// textToInsert = key.ToLower();
		String_t* L_4 = ___0_key;
		NullCheck(L_4);
		String_t* L_5;
		L_5 = String_ToLower_m6191ABA3DC514ED47C10BDA23FD0DDCEAE7ACFBD(L_4, NULL);
		V_0 = L_5;
	}

IL_002d:
	{
		// int startPos = Mathf.Min(outputField.selectionAnchorPosition, outputField.selectionFocusPosition);
		TMP_InputField_t3488E0EE8C3DF56C6A328EC95D1BEEA2DF4A7D5F* L_6 = __this->___outputField_28;
		NullCheck(L_6);
		int32_t L_7;
		L_7 = TMP_InputField_get_selectionAnchorPosition_mAAD925C368B16EFE972C11F551A1D9DCB93B0B93(L_6, NULL);
		TMP_InputField_t3488E0EE8C3DF56C6A328EC95D1BEEA2DF4A7D5F* L_8 = __this->___outputField_28;
		NullCheck(L_8);
		int32_t L_9;
		L_9 = TMP_InputField_get_selectionFocusPosition_m64C9DB19CDB18E29B7CB02DCC84B5F05ACDB473E(L_8, NULL);
		int32_t L_10;
		L_10 = Mathf_Min_m888083F74FF5655778F0403BB5E9608BEFDEA8CB_inline(L_7, L_9, NULL);
		V_1 = L_10;
		// int endPos = Mathf.Max(outputField.selectionAnchorPosition, outputField.selectionFocusPosition);
		TMP_InputField_t3488E0EE8C3DF56C6A328EC95D1BEEA2DF4A7D5F* L_11 = __this->___outputField_28;
		NullCheck(L_11);
		int32_t L_12;
		L_12 = TMP_InputField_get_selectionAnchorPosition_mAAD925C368B16EFE972C11F551A1D9DCB93B0B93(L_11, NULL);
		TMP_InputField_t3488E0EE8C3DF56C6A328EC95D1BEEA2DF4A7D5F* L_13 = __this->___outputField_28;
		NullCheck(L_13);
		int32_t L_14;
		L_14 = TMP_InputField_get_selectionFocusPosition_m64C9DB19CDB18E29B7CB02DCC84B5F05ACDB473E(L_13, NULL);
		int32_t L_15;
		L_15 = Mathf_Max_m7FA442918DE37E3A00106D1F2E789D65829792B8_inline(L_12, L_14, NULL);
		V_2 = L_15;
		// outputField.text = outputField.text.Remove(startPos, endPos - startPos);
		TMP_InputField_t3488E0EE8C3DF56C6A328EC95D1BEEA2DF4A7D5F* L_16 = __this->___outputField_28;
		TMP_InputField_t3488E0EE8C3DF56C6A328EC95D1BEEA2DF4A7D5F* L_17 = __this->___outputField_28;
		NullCheck(L_17);
		String_t* L_18;
		L_18 = TMP_InputField_get_text_mA4ACBF52435893D9DFD822A492454301740B3C6A_inline(L_17, NULL);
		int32_t L_19 = V_1;
		int32_t L_20 = V_2;
		int32_t L_21 = V_1;
		NullCheck(L_18);
		String_t* L_22;
		L_22 = String_Remove_m4D7A58E2124F8D0D8AE3EEDE74B6AD6A863ABA68(L_18, L_19, ((int32_t)il2cpp_codegen_subtract(L_20, L_21)), NULL);
		NullCheck(L_16);
		TMP_InputField_set_text_m684E9CDA2D9E82D1C497B5E03DBE79C00584FF62(L_16, L_22, NULL);
		// outputField.text = outputField.text.Insert(startPos, textToInsert);
		TMP_InputField_t3488E0EE8C3DF56C6A328EC95D1BEEA2DF4A7D5F* L_23 = __this->___outputField_28;
		TMP_InputField_t3488E0EE8C3DF56C6A328EC95D1BEEA2DF4A7D5F* L_24 = __this->___outputField_28;
		NullCheck(L_24);
		String_t* L_25;
		L_25 = TMP_InputField_get_text_mA4ACBF52435893D9DFD822A492454301740B3C6A_inline(L_24, NULL);
		int32_t L_26 = V_1;
		String_t* L_27 = V_0;
		NullCheck(L_25);
		String_t* L_28;
		L_28 = String_Insert_mA279E748F06514A6D0B9B680D651D6A6C6BB561A(L_25, L_26, L_27, NULL);
		NullCheck(L_23);
		TMP_InputField_set_text_m684E9CDA2D9E82D1C497B5E03DBE79C00584FF62(L_23, L_28, NULL);
		// outputField.selectionAnchorPosition = outputField.selectionFocusPosition = startPos + textToInsert.Length;
		TMP_InputField_t3488E0EE8C3DF56C6A328EC95D1BEEA2DF4A7D5F* L_29 = __this->___outputField_28;
		TMP_InputField_t3488E0EE8C3DF56C6A328EC95D1BEEA2DF4A7D5F* L_30 = __this->___outputField_28;
		int32_t L_31 = V_1;
		String_t* L_32 = V_0;
		NullCheck(L_32);
		int32_t L_33;
		L_33 = String_get_Length_m42625D67623FA5CC7A44D47425CE86FB946542D2_inline(L_32, NULL);
		int32_t L_34 = ((int32_t)il2cpp_codegen_add(L_31, L_33));
		V_3 = L_34;
		NullCheck(L_30);
		TMP_InputField_set_selectionFocusPosition_m862731C1A303D3778E292AB427BC1BEF4407050D(L_30, L_34, NULL);
		int32_t L_35 = V_3;
		NullCheck(L_29);
		TMP_InputField_set_selectionAnchorPosition_mB6E72D94EFD7C55EAFA8F8AAC30D255935438B06(L_29, L_35, NULL);
		// if (isFirstKeyPress)
		bool L_36 = __this->___isFirstKeyPress_33;
		if (!L_36)
		{
			goto IL_00e1;
		}
	}
	{
		// isFirstKeyPress = false;
		__this->___isFirstKeyPress_33 = (bool)0;
		// keyChannel.onFirstKeyPress.Invoke();
		KeyChannel_t928FC4C0F40F35E44A1B18D92A9B172B2B760A8A* L_37 = __this->___keyChannel_4;
		NullCheck(L_37);
		UnityEvent_tDC2C3548799DBC91D1E3F3DE60083A66F4751977* L_38 = L_37->___onFirstKeyPress_7;
		NullCheck(L_38);
		UnityEvent_Invoke_mFBF80D59B03C30C5FE6A06F897D954ACADE061D2(L_38, NULL);
	}

IL_00e1:
	{
		// CheckTextLength();
		KeyboardManager_CheckTextLength_m29214ABD71A9EF74FD355FDE3FC2575DF015D55B(__this, NULL);
		// }
		return;
	}
}
// System.Void Keyboard.KeyboardManager::OnSpacePress()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void KeyboardManager_OnSpacePress_m38F1CC2F29F04AD3B6DEC34AB6377E8B26086124 (KeyboardManager_t41DD8382AE61564F08C9856BE00640CCB87720FB* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral2386E77CF610F786B06A91AF2C1B3FD2282D2745);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	int32_t V_1 = 0;
	int32_t V_2 = 0;
	{
		// int startPos = Mathf.Min(outputField.selectionAnchorPosition, outputField.selectionFocusPosition);
		TMP_InputField_t3488E0EE8C3DF56C6A328EC95D1BEEA2DF4A7D5F* L_0 = __this->___outputField_28;
		NullCheck(L_0);
		int32_t L_1;
		L_1 = TMP_InputField_get_selectionAnchorPosition_mAAD925C368B16EFE972C11F551A1D9DCB93B0B93(L_0, NULL);
		TMP_InputField_t3488E0EE8C3DF56C6A328EC95D1BEEA2DF4A7D5F* L_2 = __this->___outputField_28;
		NullCheck(L_2);
		int32_t L_3;
		L_3 = TMP_InputField_get_selectionFocusPosition_m64C9DB19CDB18E29B7CB02DCC84B5F05ACDB473E(L_2, NULL);
		int32_t L_4;
		L_4 = Mathf_Min_m888083F74FF5655778F0403BB5E9608BEFDEA8CB_inline(L_1, L_3, NULL);
		V_0 = L_4;
		// int endPos = Mathf.Max(outputField.selectionAnchorPosition, outputField.selectionFocusPosition);
		TMP_InputField_t3488E0EE8C3DF56C6A328EC95D1BEEA2DF4A7D5F* L_5 = __this->___outputField_28;
		NullCheck(L_5);
		int32_t L_6;
		L_6 = TMP_InputField_get_selectionAnchorPosition_mAAD925C368B16EFE972C11F551A1D9DCB93B0B93(L_5, NULL);
		TMP_InputField_t3488E0EE8C3DF56C6A328EC95D1BEEA2DF4A7D5F* L_7 = __this->___outputField_28;
		NullCheck(L_7);
		int32_t L_8;
		L_8 = TMP_InputField_get_selectionFocusPosition_m64C9DB19CDB18E29B7CB02DCC84B5F05ACDB473E(L_7, NULL);
		int32_t L_9;
		L_9 = Mathf_Max_m7FA442918DE37E3A00106D1F2E789D65829792B8_inline(L_6, L_8, NULL);
		V_1 = L_9;
		// outputField.text = outputField.text.Remove(startPos, endPos - startPos);
		TMP_InputField_t3488E0EE8C3DF56C6A328EC95D1BEEA2DF4A7D5F* L_10 = __this->___outputField_28;
		TMP_InputField_t3488E0EE8C3DF56C6A328EC95D1BEEA2DF4A7D5F* L_11 = __this->___outputField_28;
		NullCheck(L_11);
		String_t* L_12;
		L_12 = TMP_InputField_get_text_mA4ACBF52435893D9DFD822A492454301740B3C6A_inline(L_11, NULL);
		int32_t L_13 = V_0;
		int32_t L_14 = V_1;
		int32_t L_15 = V_0;
		NullCheck(L_12);
		String_t* L_16;
		L_16 = String_Remove_m4D7A58E2124F8D0D8AE3EEDE74B6AD6A863ABA68(L_12, L_13, ((int32_t)il2cpp_codegen_subtract(L_14, L_15)), NULL);
		NullCheck(L_10);
		TMP_InputField_set_text_m684E9CDA2D9E82D1C497B5E03DBE79C00584FF62(L_10, L_16, NULL);
		// outputField.text = outputField.text.Insert(startPos, " ");
		TMP_InputField_t3488E0EE8C3DF56C6A328EC95D1BEEA2DF4A7D5F* L_17 = __this->___outputField_28;
		TMP_InputField_t3488E0EE8C3DF56C6A328EC95D1BEEA2DF4A7D5F* L_18 = __this->___outputField_28;
		NullCheck(L_18);
		String_t* L_19;
		L_19 = TMP_InputField_get_text_mA4ACBF52435893D9DFD822A492454301740B3C6A_inline(L_18, NULL);
		int32_t L_20 = V_0;
		NullCheck(L_19);
		String_t* L_21;
		L_21 = String_Insert_mA279E748F06514A6D0B9B680D651D6A6C6BB561A(L_19, L_20, _stringLiteral2386E77CF610F786B06A91AF2C1B3FD2282D2745, NULL);
		NullCheck(L_17);
		TMP_InputField_set_text_m684E9CDA2D9E82D1C497B5E03DBE79C00584FF62(L_17, L_21, NULL);
		// outputField.selectionAnchorPosition = outputField.selectionFocusPosition = startPos + 1;
		TMP_InputField_t3488E0EE8C3DF56C6A328EC95D1BEEA2DF4A7D5F* L_22 = __this->___outputField_28;
		TMP_InputField_t3488E0EE8C3DF56C6A328EC95D1BEEA2DF4A7D5F* L_23 = __this->___outputField_28;
		int32_t L_24 = V_0;
		int32_t L_25 = ((int32_t)il2cpp_codegen_add(L_24, 1));
		V_2 = L_25;
		NullCheck(L_23);
		TMP_InputField_set_selectionFocusPosition_m862731C1A303D3778E292AB427BC1BEF4407050D(L_23, L_25, NULL);
		int32_t L_26 = V_2;
		NullCheck(L_22);
		TMP_InputField_set_selectionAnchorPosition_mB6E72D94EFD7C55EAFA8F8AAC30D255935438B06(L_22, L_26, NULL);
		// CheckTextLength();
		KeyboardManager_CheckTextLength_m29214ABD71A9EF74FD355FDE3FC2575DF015D55B(__this, NULL);
		// }
		return;
	}
}
// System.Void Keyboard.KeyboardManager::OnDeletePress()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void KeyboardManager_OnDeletePress_mF2C78138A5C6B941C45092D2705C28944C42AE94 (KeyboardManager_t41DD8382AE61564F08C9856BE00640CCB87720FB* __this, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	int32_t V_1 = 0;
	int32_t V_2 = 0;
	{
		// if (string.IsNullOrEmpty(outputField.text)) return;
		TMP_InputField_t3488E0EE8C3DF56C6A328EC95D1BEEA2DF4A7D5F* L_0 = __this->___outputField_28;
		NullCheck(L_0);
		String_t* L_1;
		L_1 = TMP_InputField_get_text_mA4ACBF52435893D9DFD822A492454301740B3C6A_inline(L_0, NULL);
		bool L_2;
		L_2 = String_IsNullOrEmpty_mEA9E3FB005AC28FE02E69FCF95A7B8456192B478(L_1, NULL);
		if (!L_2)
		{
			goto IL_0013;
		}
	}
	{
		// if (string.IsNullOrEmpty(outputField.text)) return;
		return;
	}

IL_0013:
	{
		// int startPos = Mathf.Min(outputField.selectionAnchorPosition, outputField.selectionFocusPosition);
		TMP_InputField_t3488E0EE8C3DF56C6A328EC95D1BEEA2DF4A7D5F* L_3 = __this->___outputField_28;
		NullCheck(L_3);
		int32_t L_4;
		L_4 = TMP_InputField_get_selectionAnchorPosition_mAAD925C368B16EFE972C11F551A1D9DCB93B0B93(L_3, NULL);
		TMP_InputField_t3488E0EE8C3DF56C6A328EC95D1BEEA2DF4A7D5F* L_5 = __this->___outputField_28;
		NullCheck(L_5);
		int32_t L_6;
		L_6 = TMP_InputField_get_selectionFocusPosition_m64C9DB19CDB18E29B7CB02DCC84B5F05ACDB473E(L_5, NULL);
		int32_t L_7;
		L_7 = Mathf_Min_m888083F74FF5655778F0403BB5E9608BEFDEA8CB_inline(L_4, L_6, NULL);
		V_0 = L_7;
		// int endPos = Mathf.Max(outputField.selectionAnchorPosition, outputField.selectionFocusPosition);
		TMP_InputField_t3488E0EE8C3DF56C6A328EC95D1BEEA2DF4A7D5F* L_8 = __this->___outputField_28;
		NullCheck(L_8);
		int32_t L_9;
		L_9 = TMP_InputField_get_selectionAnchorPosition_mAAD925C368B16EFE972C11F551A1D9DCB93B0B93(L_8, NULL);
		TMP_InputField_t3488E0EE8C3DF56C6A328EC95D1BEEA2DF4A7D5F* L_10 = __this->___outputField_28;
		NullCheck(L_10);
		int32_t L_11;
		L_11 = TMP_InputField_get_selectionFocusPosition_m64C9DB19CDB18E29B7CB02DCC84B5F05ACDB473E(L_10, NULL);
		int32_t L_12;
		L_12 = Mathf_Max_m7FA442918DE37E3A00106D1F2E789D65829792B8_inline(L_9, L_11, NULL);
		V_1 = L_12;
		// if (endPos > startPos)
		int32_t L_13 = V_1;
		int32_t L_14 = V_0;
		if ((((int32_t)L_13) <= ((int32_t)L_14)))
		{
			goto IL_008a;
		}
	}
	{
		// outputField.text = outputField.text.Remove(startPos, endPos - startPos);
		TMP_InputField_t3488E0EE8C3DF56C6A328EC95D1BEEA2DF4A7D5F* L_15 = __this->___outputField_28;
		TMP_InputField_t3488E0EE8C3DF56C6A328EC95D1BEEA2DF4A7D5F* L_16 = __this->___outputField_28;
		NullCheck(L_16);
		String_t* L_17;
		L_17 = TMP_InputField_get_text_mA4ACBF52435893D9DFD822A492454301740B3C6A_inline(L_16, NULL);
		int32_t L_18 = V_0;
		int32_t L_19 = V_1;
		int32_t L_20 = V_0;
		NullCheck(L_17);
		String_t* L_21;
		L_21 = String_Remove_m4D7A58E2124F8D0D8AE3EEDE74B6AD6A863ABA68(L_17, L_18, ((int32_t)il2cpp_codegen_subtract(L_19, L_20)), NULL);
		NullCheck(L_15);
		TMP_InputField_set_text_m684E9CDA2D9E82D1C497B5E03DBE79C00584FF62(L_15, L_21, NULL);
		// outputField.selectionAnchorPosition = outputField.selectionFocusPosition = startPos;
		TMP_InputField_t3488E0EE8C3DF56C6A328EC95D1BEEA2DF4A7D5F* L_22 = __this->___outputField_28;
		TMP_InputField_t3488E0EE8C3DF56C6A328EC95D1BEEA2DF4A7D5F* L_23 = __this->___outputField_28;
		int32_t L_24 = V_0;
		int32_t L_25 = L_24;
		V_2 = L_25;
		NullCheck(L_23);
		TMP_InputField_set_selectionFocusPosition_m862731C1A303D3778E292AB427BC1BEF4407050D(L_23, L_25, NULL);
		int32_t L_26 = V_2;
		NullCheck(L_22);
		TMP_InputField_set_selectionAnchorPosition_mB6E72D94EFD7C55EAFA8F8AAC30D255935438B06(L_22, L_26, NULL);
		goto IL_00c9;
	}

IL_008a:
	{
		// else if (startPos > 0)
		int32_t L_27 = V_0;
		if ((((int32_t)L_27) <= ((int32_t)0)))
		{
			goto IL_00c9;
		}
	}
	{
		// outputField.text = outputField.text.Remove(startPos - 1, 1);
		TMP_InputField_t3488E0EE8C3DF56C6A328EC95D1BEEA2DF4A7D5F* L_28 = __this->___outputField_28;
		TMP_InputField_t3488E0EE8C3DF56C6A328EC95D1BEEA2DF4A7D5F* L_29 = __this->___outputField_28;
		NullCheck(L_29);
		String_t* L_30;
		L_30 = TMP_InputField_get_text_mA4ACBF52435893D9DFD822A492454301740B3C6A_inline(L_29, NULL);
		int32_t L_31 = V_0;
		NullCheck(L_30);
		String_t* L_32;
		L_32 = String_Remove_m4D7A58E2124F8D0D8AE3EEDE74B6AD6A863ABA68(L_30, ((int32_t)il2cpp_codegen_subtract(L_31, 1)), 1, NULL);
		NullCheck(L_28);
		TMP_InputField_set_text_m684E9CDA2D9E82D1C497B5E03DBE79C00584FF62(L_28, L_32, NULL);
		// outputField.selectionAnchorPosition = outputField.selectionFocusPosition = startPos - 1;
		TMP_InputField_t3488E0EE8C3DF56C6A328EC95D1BEEA2DF4A7D5F* L_33 = __this->___outputField_28;
		TMP_InputField_t3488E0EE8C3DF56C6A328EC95D1BEEA2DF4A7D5F* L_34 = __this->___outputField_28;
		int32_t L_35 = V_0;
		int32_t L_36 = ((int32_t)il2cpp_codegen_subtract(L_35, 1));
		V_2 = L_36;
		NullCheck(L_34);
		TMP_InputField_set_selectionFocusPosition_m862731C1A303D3778E292AB427BC1BEF4407050D(L_34, L_36, NULL);
		int32_t L_37 = V_2;
		NullCheck(L_33);
		TMP_InputField_set_selectionAnchorPosition_mB6E72D94EFD7C55EAFA8F8AAC30D255935438B06(L_33, L_37, NULL);
	}

IL_00c9:
	{
		// CheckTextLength();
		KeyboardManager_CheckTextLength_m29214ABD71A9EF74FD355FDE3FC2575DF015D55B(__this, NULL);
		// }
		return;
	}
}
// System.Void Keyboard.KeyboardManager::CheckTextLength()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void KeyboardManager_CheckTextLength_m29214ABD71A9EF74FD355FDE3FC2575DF015D55B (KeyboardManager_t41DD8382AE61564F08C9856BE00640CCB87720FB* __this, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	bool V_1 = false;
	{
		// int currentLength = outputField.text.Length;
		TMP_InputField_t3488E0EE8C3DF56C6A328EC95D1BEEA2DF4A7D5F* L_0 = __this->___outputField_28;
		NullCheck(L_0);
		String_t* L_1;
		L_1 = TMP_InputField_get_text_mA4ACBF52435893D9DFD822A492454301740B3C6A_inline(L_0, NULL);
		NullCheck(L_1);
		int32_t L_2;
		L_2 = String_get_Length_m42625D67623FA5CC7A44D47425CE86FB946542D2_inline(L_1, NULL);
		V_0 = L_2;
		// bool keysEnabled = currentLength < maxCharacters;
		int32_t L_3 = V_0;
		int32_t L_4 = __this->___maxCharacters_30;
		V_1 = (bool)((((int32_t)L_3) < ((int32_t)L_4))? 1 : 0);
		// keyChannel.RaiseKeysStateChangeEvent(keysEnabled);
		KeyChannel_t928FC4C0F40F35E44A1B18D92A9B172B2B760A8A* L_5 = __this->___keyChannel_4;
		bool L_6 = V_1;
		NullCheck(L_5);
		KeyChannel_RaiseKeysStateChangeEvent_mE220A22E89C0F8E3D1582B7836CE764C1E69D92E(L_5, L_6, NULL);
		// enterButton.interactable = currentLength >= minCharacters;
		Button_t6786514A57F7AFDEE5431112FEA0CAB24F5AE098* L_7 = __this->___enterButton_29;
		int32_t L_8 = V_0;
		int32_t L_9 = __this->___minCharacters_31;
		NullCheck(L_7);
		Selectable_set_interactable_m8DD581C1AD99B2EFA8B3EE9AF69EDDF26688B492(L_7, (bool)((((int32_t)((((int32_t)L_8) < ((int32_t)L_9))? 1 : 0)) == ((int32_t)0))? 1 : 0), NULL);
		// deleteButton.interactable = true;
		Button_t6786514A57F7AFDEE5431112FEA0CAB24F5AE098* L_10 = __this->___deleteButton_7;
		NullCheck(L_10);
		Selectable_set_interactable_m8DD581C1AD99B2EFA8B3EE9AF69EDDF26688B492(L_10, (bool)1, NULL);
		// if (currentLength != maxCharacters) return;
		int32_t L_11 = V_0;
		int32_t L_12 = __this->___maxCharacters_30;
		if ((((int32_t)L_11) == ((int32_t)L_12)))
		{
			goto IL_0054;
		}
	}
	{
		// if (currentLength != maxCharacters) return;
		return;
	}

IL_0054:
	{
		// DeactivateShift();
		KeyboardManager_DeactivateShift_m5583AF2C623B7571D949EB0AC968DF509284F400(__this, NULL);
		// capsLockActive = false;
		__this->___capsLockActive_36 = (bool)0;
		// UpdateShiftButtonAppearance();
		KeyboardManager_UpdateShiftButtonAppearance_m14947FCA031715FE3843587C48002A45F7BEC128(__this, NULL);
		// }
		return;
	}
}
// System.Void Keyboard.KeyboardManager::OnSwitchPress()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void KeyboardManager_OnSwitchPress_m593AE16BABC05F9A43E1A26CDB30CD1062817479 (KeyboardManager_t41DD8382AE61564F08C9856BE00640CCB87720FB* __this, const RuntimeMethod* method) 
{
	UnityEvent_tDC2C3548799DBC91D1E3F3DE60083A66F4751977* G_B5_0 = NULL;
	UnityEvent_tDC2C3548799DBC91D1E3F3DE60083A66F4751977* G_B4_0 = NULL;
	{
		// if (lettersKeyboard.activeSelf)
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_0 = __this->___lettersKeyboard_12;
		NullCheck(L_0);
		bool L_1;
		L_1 = GameObject_get_activeSelf_m4F3E5240E138B66AAA080EA30759A3D0517DA368(L_0, NULL);
		if (!L_1)
		{
			goto IL_0066;
		}
	}
	{
		// lettersKeyboard.SetActive(false);
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_2 = __this->___lettersKeyboard_12;
		NullCheck(L_2);
		GameObject_SetActive_m638E92E1E75E519E5B24CF150B08CA8E0CDFAB92(L_2, (bool)0, NULL);
		// numbersKeyboard.SetActive(true);
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_3 = __this->___numbersKeyboard_13;
		NullCheck(L_3);
		GameObject_SetActive_m638E92E1E75E519E5B24CF150B08CA8E0CDFAB92(L_3, (bool)1, NULL);
		// specialCharactersKeyboard.SetActive(false);
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_4 = __this->___specialCharactersKeyboard_14;
		NullCheck(L_4);
		GameObject_SetActive_m638E92E1E75E519E5B24CF150B08CA8E0CDFAB92(L_4, (bool)0, NULL);
		// switchNumberSpecialButton.gameObject.SetActive(true);
		Button_t6786514A57F7AFDEE5431112FEA0CAB24F5AE098* L_5 = __this->___switchNumberSpecialButton_20;
		NullCheck(L_5);
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_6;
		L_6 = Component_get_gameObject_m57AEFBB14DB39EC476F740BA000E170355DE691B(L_5, NULL);
		NullCheck(L_6);
		GameObject_SetActive_m638E92E1E75E519E5B24CF150B08CA8E0CDFAB92(L_6, (bool)1, NULL);
		// switchButtonText.text = switchToNumbers;
		TextMeshProUGUI_t101091AF4B578BB534C92E9D1EEAF0611636D957* L_7 = __this->___switchButtonText_11;
		String_t* L_8 = __this->___switchToNumbers_9;
		NullCheck(L_7);
		VirtualActionInvoker1< String_t* >::Invoke(66 /* System.Void TMPro.TMP_Text::set_text(System.String) */, L_7, L_8);
		// switchNumSpecButtonText.text = specialString;
		TextMeshProUGUI_t101091AF4B578BB534C92E9D1EEAF0611636D957* L_9 = __this->___switchNumSpecButtonText_23;
		String_t* L_10 = __this->___specialString_22;
		NullCheck(L_9);
		VirtualActionInvoker1< String_t* >::Invoke(66 /* System.Void TMPro.TMP_Text::set_text(System.String) */, L_9, L_10);
		goto IL_00bd;
	}

IL_0066:
	{
		// lettersKeyboard.SetActive(true);
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_11 = __this->___lettersKeyboard_12;
		NullCheck(L_11);
		GameObject_SetActive_m638E92E1E75E519E5B24CF150B08CA8E0CDFAB92(L_11, (bool)1, NULL);
		// numbersKeyboard.SetActive(false);
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_12 = __this->___numbersKeyboard_13;
		NullCheck(L_12);
		GameObject_SetActive_m638E92E1E75E519E5B24CF150B08CA8E0CDFAB92(L_12, (bool)0, NULL);
		// specialCharactersKeyboard.SetActive(false);
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_13 = __this->___specialCharactersKeyboard_14;
		NullCheck(L_13);
		GameObject_SetActive_m638E92E1E75E519E5B24CF150B08CA8E0CDFAB92(L_13, (bool)0, NULL);
		// switchNumberSpecialButton.gameObject.SetActive(false);
		Button_t6786514A57F7AFDEE5431112FEA0CAB24F5AE098* L_14 = __this->___switchNumberSpecialButton_20;
		NullCheck(L_14);
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_15;
		L_15 = Component_get_gameObject_m57AEFBB14DB39EC476F740BA000E170355DE691B(L_14, NULL);
		NullCheck(L_15);
		GameObject_SetActive_m638E92E1E75E519E5B24CF150B08CA8E0CDFAB92(L_15, (bool)0, NULL);
		// switchButtonText.text = switchToLetter;
		TextMeshProUGUI_t101091AF4B578BB534C92E9D1EEAF0611636D957* L_16 = __this->___switchButtonText_11;
		String_t* L_17 = __this->___switchToLetter_10;
		NullCheck(L_16);
		VirtualActionInvoker1< String_t* >::Invoke(66 /* System.Void TMPro.TMP_Text::set_text(System.String) */, L_16, L_17);
		// switchNumSpecButtonText.text = specialString;
		TextMeshProUGUI_t101091AF4B578BB534C92E9D1EEAF0611636D957* L_18 = __this->___switchNumSpecButtonText_23;
		String_t* L_19 = __this->___specialString_22;
		NullCheck(L_18);
		VirtualActionInvoker1< String_t* >::Invoke(66 /* System.Void TMPro.TMP_Text::set_text(System.String) */, L_18, L_19);
	}

IL_00bd:
	{
		// DeactivateShift();
		KeyboardManager_DeactivateShift_m5583AF2C623B7571D949EB0AC968DF509284F400(__this, NULL);
		// onKeyboardModeChanged?.Invoke();
		UnityEvent_tDC2C3548799DBC91D1E3F3DE60083A66F4751977* L_20 = __this->___onKeyboardModeChanged_40;
		UnityEvent_tDC2C3548799DBC91D1E3F3DE60083A66F4751977* L_21 = L_20;
		G_B4_0 = L_21;
		if (L_21)
		{
			G_B5_0 = L_21;
			goto IL_00ce;
		}
	}
	{
		return;
	}

IL_00ce:
	{
		NullCheck(G_B5_0);
		UnityEvent_Invoke_mFBF80D59B03C30C5FE6A06F897D954ACADE061D2(G_B5_0, NULL);
		// }
		return;
	}
}
// System.Void Keyboard.KeyboardManager::OnShiftPress()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void KeyboardManager_OnShiftPress_mF04B1244E8EB01E629B736A32297C46C2457A9E9 (KeyboardManager_t41DD8382AE61564F08C9856BE00640CCB87720FB* __this, const RuntimeMethod* method) 
{
	UnityEvent_tDC2C3548799DBC91D1E3F3DE60083A66F4751977* G_B11_0 = NULL;
	UnityEvent_tDC2C3548799DBC91D1E3F3DE60083A66F4751977* G_B10_0 = NULL;
	{
		// if (capsLockActive)
		bool L_0 = __this->___capsLockActive_36;
		if (!L_0)
		{
			goto IL_0018;
		}
	}
	{
		// capsLockActive = false;
		__this->___capsLockActive_36 = (bool)0;
		// shiftActive = false;
		__this->___shiftActive_35 = (bool)0;
		goto IL_0064;
	}

IL_0018:
	{
		// else switch (shiftActive)
		bool L_1 = __this->___shiftActive_35;
		if (!L_1)
		{
			goto IL_005d;
		}
	}
	{
		// case true when !keyHasBeenPressed && Time.time - lastShiftClickTime < shiftDoubleClickDelay:
		bool L_2 = __this->___keyHasBeenPressed_34;
		if (L_2)
		{
			goto IL_004c;
		}
	}
	{
		float L_3;
		L_3 = Time_get_time_m3A271BB1B20041144AC5B7863B71AB1F0150374B(NULL);
		float L_4 = __this->___lastShiftClickTime_38;
		float L_5 = __this->___shiftDoubleClickDelay_39;
		if ((!(((float)((float)il2cpp_codegen_subtract(L_3, L_4))) < ((float)L_5))))
		{
			goto IL_004c;
		}
	}
	{
		// capsLockActive = true;
		__this->___capsLockActive_36 = (bool)1;
		// shiftActive = false;
		__this->___shiftActive_35 = (bool)0;
		// break;
		goto IL_0064;
	}

IL_004c:
	{
		// case true when !keyHasBeenPressed:
		bool L_6 = __this->___keyHasBeenPressed_34;
		if (L_6)
		{
			goto IL_0064;
		}
	}
	{
		// shiftActive = false;
		__this->___shiftActive_35 = (bool)0;
		// break;
		goto IL_0064;
	}

IL_005d:
	{
		// shiftActive = true;
		__this->___shiftActive_35 = (bool)1;
	}

IL_0064:
	{
		// lastShiftClickTime = Time.time;
		float L_7;
		L_7 = Time_get_time_m3A271BB1B20041144AC5B7863B71AB1F0150374B(NULL);
		__this->___lastShiftClickTime_38 = L_7;
		// UpdateShiftButtonAppearance();
		KeyboardManager_UpdateShiftButtonAppearance_m14947FCA031715FE3843587C48002A45F7BEC128(__this, NULL);
		// onKeyboardModeChanged?.Invoke();
		UnityEvent_tDC2C3548799DBC91D1E3F3DE60083A66F4751977* L_8 = __this->___onKeyboardModeChanged_40;
		UnityEvent_tDC2C3548799DBC91D1E3F3DE60083A66F4751977* L_9 = L_8;
		G_B10_0 = L_9;
		if (L_9)
		{
			G_B11_0 = L_9;
			goto IL_0080;
		}
	}
	{
		return;
	}

IL_0080:
	{
		NullCheck(G_B11_0);
		UnityEvent_Invoke_mFBF80D59B03C30C5FE6A06F897D954ACADE061D2(G_B11_0, NULL);
		// }
		return;
	}
}
// System.Void Keyboard.KeyboardManager::ActivateShift()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void KeyboardManager_ActivateShift_m4618EDB6F0C88292C071EB032A812B48ABF0AB1E (KeyboardManager_t41DD8382AE61564F08C9856BE00640CCB87720FB* __this, const RuntimeMethod* method) 
{
	UnityEvent_tDC2C3548799DBC91D1E3F3DE60083A66F4751977* G_B4_0 = NULL;
	UnityEvent_tDC2C3548799DBC91D1E3F3DE60083A66F4751977* G_B3_0 = NULL;
	{
		// if (!capsLockActive) shiftActive = true;
		bool L_0 = __this->___capsLockActive_36;
		if (L_0)
		{
			goto IL_000f;
		}
	}
	{
		// if (!capsLockActive) shiftActive = true;
		__this->___shiftActive_35 = (bool)1;
	}

IL_000f:
	{
		// UpdateShiftButtonAppearance();
		KeyboardManager_UpdateShiftButtonAppearance_m14947FCA031715FE3843587C48002A45F7BEC128(__this, NULL);
		// onKeyboardModeChanged?.Invoke();
		UnityEvent_tDC2C3548799DBC91D1E3F3DE60083A66F4751977* L_1 = __this->___onKeyboardModeChanged_40;
		UnityEvent_tDC2C3548799DBC91D1E3F3DE60083A66F4751977* L_2 = L_1;
		G_B3_0 = L_2;
		if (L_2)
		{
			G_B4_0 = L_2;
			goto IL_0020;
		}
	}
	{
		return;
	}

IL_0020:
	{
		NullCheck(G_B4_0);
		UnityEvent_Invoke_mFBF80D59B03C30C5FE6A06F897D954ACADE061D2(G_B4_0, NULL);
		// }
		return;
	}
}
// System.Void Keyboard.KeyboardManager::DeactivateShift()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void KeyboardManager_DeactivateShift_m5583AF2C623B7571D949EB0AC968DF509284F400 (KeyboardManager_t41DD8382AE61564F08C9856BE00640CCB87720FB* __this, const RuntimeMethod* method) 
{
	UnityEvent_tDC2C3548799DBC91D1E3F3DE60083A66F4751977* G_B5_0 = NULL;
	UnityEvent_tDC2C3548799DBC91D1E3F3DE60083A66F4751977* G_B4_0 = NULL;
	{
		// if (shiftActive && !capsLockActive && keyHasBeenPressed)
		bool L_0 = __this->___shiftActive_35;
		if (!L_0)
		{
			goto IL_0036;
		}
	}
	{
		bool L_1 = __this->___capsLockActive_36;
		if (L_1)
		{
			goto IL_0036;
		}
	}
	{
		bool L_2 = __this->___keyHasBeenPressed_34;
		if (!L_2)
		{
			goto IL_0036;
		}
	}
	{
		// shiftActive = false;
		__this->___shiftActive_35 = (bool)0;
		// UpdateShiftButtonAppearance();
		KeyboardManager_UpdateShiftButtonAppearance_m14947FCA031715FE3843587C48002A45F7BEC128(__this, NULL);
		// onKeyboardModeChanged?.Invoke();
		UnityEvent_tDC2C3548799DBC91D1E3F3DE60083A66F4751977* L_3 = __this->___onKeyboardModeChanged_40;
		UnityEvent_tDC2C3548799DBC91D1E3F3DE60083A66F4751977* L_4 = L_3;
		G_B4_0 = L_4;
		if (L_4)
		{
			G_B5_0 = L_4;
			goto IL_0031;
		}
	}
	{
		goto IL_0036;
	}

IL_0031:
	{
		NullCheck(G_B5_0);
		UnityEvent_Invoke_mFBF80D59B03C30C5FE6A06F897D954ACADE061D2(G_B5_0, NULL);
	}

IL_0036:
	{
		// keyHasBeenPressed = false;
		__this->___keyHasBeenPressed_34 = (bool)0;
		// }
		return;
	}
}
// System.Boolean Keyboard.KeyboardManager::IsShiftActive()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool KeyboardManager_IsShiftActive_m6751E01EFDE79B39663039847F711D4161E9C39F (KeyboardManager_t41DD8382AE61564F08C9856BE00640CCB87720FB* __this, const RuntimeMethod* method) 
{
	{
		// public bool IsShiftActive() => shiftActive;
		bool L_0 = __this->___shiftActive_35;
		return L_0;
	}
}
// System.Boolean Keyboard.KeyboardManager::IsCapsLockActive()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool KeyboardManager_IsCapsLockActive_m84C0D99FD40D977DBC3788ABCE1EE41EA4BACDEB (KeyboardManager_t41DD8382AE61564F08C9856BE00640CCB87720FB* __this, const RuntimeMethod* method) 
{
	{
		// public bool IsCapsLockActive() => capsLockActive;
		bool L_0 = __this->___capsLockActive_36;
		return L_0;
	}
}
// System.Void Keyboard.KeyboardManager::SwitchBetweenNumbersAndSpecialCharacters()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void KeyboardManager_SwitchBetweenNumbersAndSpecialCharacters_m3004A040F523A15EBAB631216BBD0E4D6BFA0AF7 (KeyboardManager_t41DD8382AE61564F08C9856BE00640CCB87720FB* __this, const RuntimeMethod* method) 
{
	bool V_0 = false;
	TextMeshProUGUI_t101091AF4B578BB534C92E9D1EEAF0611636D957* G_B4_0 = NULL;
	TextMeshProUGUI_t101091AF4B578BB534C92E9D1EEAF0611636D957* G_B3_0 = NULL;
	String_t* G_B5_0 = NULL;
	TextMeshProUGUI_t101091AF4B578BB534C92E9D1EEAF0611636D957* G_B5_1 = NULL;
	UnityEvent_tDC2C3548799DBC91D1E3F3DE60083A66F4751977* G_B7_0 = NULL;
	UnityEvent_tDC2C3548799DBC91D1E3F3DE60083A66F4751977* G_B6_0 = NULL;
	{
		// if (lettersKeyboard.activeSelf) return;
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_0 = __this->___lettersKeyboard_12;
		NullCheck(L_0);
		bool L_1;
		L_1 = GameObject_get_activeSelf_m4F3E5240E138B66AAA080EA30759A3D0517DA368(L_0, NULL);
		if (!L_1)
		{
			goto IL_000e;
		}
	}
	{
		// if (lettersKeyboard.activeSelf) return;
		return;
	}

IL_000e:
	{
		// bool isNumbersKeyboardActive = numbersKeyboard.activeSelf;
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_2 = __this->___numbersKeyboard_13;
		NullCheck(L_2);
		bool L_3;
		L_3 = GameObject_get_activeSelf_m4F3E5240E138B66AAA080EA30759A3D0517DA368(L_2, NULL);
		V_0 = L_3;
		// numbersKeyboard.SetActive(!isNumbersKeyboardActive);
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_4 = __this->___numbersKeyboard_13;
		bool L_5 = V_0;
		NullCheck(L_4);
		GameObject_SetActive_m638E92E1E75E519E5B24CF150B08CA8E0CDFAB92(L_4, (bool)((((int32_t)L_5) == ((int32_t)0))? 1 : 0), NULL);
		// specialCharactersKeyboard.SetActive(isNumbersKeyboardActive);
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_6 = __this->___specialCharactersKeyboard_14;
		bool L_7 = V_0;
		NullCheck(L_6);
		GameObject_SetActive_m638E92E1E75E519E5B24CF150B08CA8E0CDFAB92(L_6, L_7, NULL);
		// switchNumSpecButtonText.text = switchNumSpecButtonText.text == specialString ? numbersString : specialString;
		TextMeshProUGUI_t101091AF4B578BB534C92E9D1EEAF0611636D957* L_8 = __this->___switchNumSpecButtonText_23;
		TextMeshProUGUI_t101091AF4B578BB534C92E9D1EEAF0611636D957* L_9 = __this->___switchNumSpecButtonText_23;
		NullCheck(L_9);
		String_t* L_10;
		L_10 = VirtualFuncInvoker0< String_t* >::Invoke(65 /* System.String TMPro.TMP_Text::get_text() */, L_9);
		String_t* L_11 = __this->___specialString_22;
		bool L_12;
		L_12 = String_op_Equality_m030E1B219352228970A076136E455C4E568C02C1(L_10, L_11, NULL);
		G_B3_0 = L_8;
		if (L_12)
		{
			G_B4_0 = L_8;
			goto IL_005b;
		}
	}
	{
		String_t* L_13 = __this->___specialString_22;
		G_B5_0 = L_13;
		G_B5_1 = G_B3_0;
		goto IL_0061;
	}

IL_005b:
	{
		String_t* L_14 = __this->___numbersString_21;
		G_B5_0 = L_14;
		G_B5_1 = G_B4_0;
	}

IL_0061:
	{
		NullCheck(G_B5_1);
		VirtualActionInvoker1< String_t* >::Invoke(66 /* System.Void TMPro.TMP_Text::set_text(System.String) */, G_B5_1, G_B5_0);
		// onKeyboardModeChanged?.Invoke();
		UnityEvent_tDC2C3548799DBC91D1E3F3DE60083A66F4751977* L_15 = __this->___onKeyboardModeChanged_40;
		UnityEvent_tDC2C3548799DBC91D1E3F3DE60083A66F4751977* L_16 = L_15;
		G_B6_0 = L_16;
		if (L_16)
		{
			G_B7_0 = L_16;
			goto IL_0071;
		}
	}
	{
		return;
	}

IL_0071:
	{
		NullCheck(G_B7_0);
		UnityEvent_Invoke_mFBF80D59B03C30C5FE6A06F897D954ACADE061D2(G_B7_0, NULL);
		// }
		return;
	}
}
// System.Void Keyboard.KeyboardManager::UpdateShiftButtonAppearance()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void KeyboardManager_UpdateShiftButtonAppearance_m14947FCA031715FE3843587C48002A45F7BEC128 (KeyboardManager_t41DD8382AE61564F08C9856BE00640CCB87720FB* __this, const RuntimeMethod* method) 
{
	{
		// if (capsLockActive)
		bool L_0 = __this->___capsLockActive_36;
		if (!L_0)
		{
			goto IL_002c;
		}
	}
	{
		// shiftButtonColors.normalColor = highlightedColor;
		ColorBlock_tDD7C62E7AFE442652FC98F8D058CE8AE6BFD7C11* L_1 = (&__this->___shiftButtonColors_32);
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_2 = __this->___highlightedColor_25;
		ColorBlock_set_normalColor_m3EBF594F6FA2C6494ACA9FCB9B458807D85B96F8_inline(L_1, L_2, NULL);
		// buttonImage.sprite = activeSprite;
		Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* L_3 = __this->___buttonImage_17;
		Sprite_tAFF74BC83CD68037494CB0B4F28CBDF8971CAB99* L_4 = __this->___activeSprite_19;
		NullCheck(L_3);
		Image_set_sprite_mC0C248340BA27AAEE56855A3FAFA0D8CA12956DE(L_3, L_4, NULL);
		goto IL_007a;
	}

IL_002c:
	{
		// else if(shiftActive)
		bool L_5 = __this->___shiftActive_35;
		if (!L_5)
		{
			goto IL_0058;
		}
	}
	{
		// shiftButtonColors.normalColor = highlightedColor;
		ColorBlock_tDD7C62E7AFE442652FC98F8D058CE8AE6BFD7C11* L_6 = (&__this->___shiftButtonColors_32);
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_7 = __this->___highlightedColor_25;
		ColorBlock_set_normalColor_m3EBF594F6FA2C6494ACA9FCB9B458807D85B96F8_inline(L_6, L_7, NULL);
		// buttonImage.sprite = defaultSprite;
		Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* L_8 = __this->___buttonImage_17;
		Sprite_tAFF74BC83CD68037494CB0B4F28CBDF8971CAB99* L_9 = __this->___defaultSprite_18;
		NullCheck(L_8);
		Image_set_sprite_mC0C248340BA27AAEE56855A3FAFA0D8CA12956DE(L_8, L_9, NULL);
		goto IL_007a;
	}

IL_0058:
	{
		// shiftButtonColors.normalColor = normalColor;
		ColorBlock_tDD7C62E7AFE442652FC98F8D058CE8AE6BFD7C11* L_10 = (&__this->___shiftButtonColors_32);
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_11 = __this->___normalColor_24;
		ColorBlock_set_normalColor_m3EBF594F6FA2C6494ACA9FCB9B458807D85B96F8_inline(L_10, L_11, NULL);
		// buttonImage.sprite = defaultSprite;
		Image_tBC1D03F63BF71132E9A5E472B8742F172A011E7E* L_12 = __this->___buttonImage_17;
		Sprite_tAFF74BC83CD68037494CB0B4F28CBDF8971CAB99* L_13 = __this->___defaultSprite_18;
		NullCheck(L_12);
		Image_set_sprite_mC0C248340BA27AAEE56855A3FAFA0D8CA12956DE(L_12, L_13, NULL);
	}

IL_007a:
	{
		// shiftButton.colors = shiftButtonColors;
		Button_t6786514A57F7AFDEE5431112FEA0CAB24F5AE098* L_14 = __this->___shiftButton_16;
		ColorBlock_tDD7C62E7AFE442652FC98F8D058CE8AE6BFD7C11 L_15 = __this->___shiftButtonColors_32;
		NullCheck(L_14);
		Selectable_set_colors_m0A49ED3ACD6647B7E5A2DA10B3D417E8FE1BE55A(L_14, L_15, NULL);
		// }
		return;
	}
}
// System.Void Keyboard.KeyboardManager::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void KeyboardManager__ctor_m74908BC9A97BD1A41B659D9B9CCF3CA02D4D2393 (KeyboardManager_t41DD8382AE61564F08C9856BE00640CCB87720FB* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral906902D085F4FCFFBE1AC027823E498FE4DA23F1);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralA3C7F6BB1B46455CBE10794712ECEC4C0181B2F3);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralC04D29956674D158EF253F0C3DB19BB0C4033629);
		s_Il2CppMethodInitialized = true;
	}
	{
		// [SerializeField] private string switchToNumbers = "Numbers";
		__this->___switchToNumbers_9 = _stringLiteralA3C7F6BB1B46455CBE10794712ECEC4C0181B2F3;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___switchToNumbers_9), (void*)_stringLiteralA3C7F6BB1B46455CBE10794712ECEC4C0181B2F3);
		// [SerializeField] private string switchToLetter = "Letters";
		__this->___switchToLetter_10 = _stringLiteral906902D085F4FCFFBE1AC027823E498FE4DA23F1;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___switchToLetter_10), (void*)_stringLiteral906902D085F4FCFFBE1AC027823E498FE4DA23F1);
		// [SerializeField] internal bool autoCapsAtStart = true;
		__this->___autoCapsAtStart_15 = (bool)1;
		// [SerializeField] private string numbersString = "Numbers";
		__this->___numbersString_21 = _stringLiteralA3C7F6BB1B46455CBE10794712ECEC4C0181B2F3;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___numbersString_21), (void*)_stringLiteralA3C7F6BB1B46455CBE10794712ECEC4C0181B2F3);
		// [SerializeField] private string specialString = "Special";
		__this->___specialString_22 = _stringLiteralC04D29956674D158EF253F0C3DB19BB0C4033629;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___specialString_22), (void*)_stringLiteralC04D29956674D158EF253F0C3DB19BB0C4033629);
		// [SerializeField] private Color normalColor = Color.black;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_0;
		L_0 = Color_get_black_mB50217951591A045844C61E7FF31EEE3FEF16737_inline(NULL);
		__this->___normalColor_24 = L_0;
		// [SerializeField] private Color highlightedColor = Color.yellow;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_1;
		L_1 = Color_get_yellow_m66637FA14383E8D74F24AE256B577CE1D55D469F_inline(NULL);
		__this->___highlightedColor_25 = L_1;
		// [SerializeField] private Color pressedColor = Color.red;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_2;
		L_2 = Color_get_red_mA2E53E7173FDC97E68E335049AB0FAAEE43A844D_inline(NULL);
		__this->___pressedColor_26 = L_2;
		// [SerializeField] private Color selectedColor = Color.blue;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_3;
		L_3 = Color_get_blue_mF04A26CE61D6DA3C0D8B1C4720901B1028C7AB87_inline(NULL);
		__this->___selectedColor_27 = L_3;
		// [SerializeField] private int maxCharacters = 15;
		__this->___maxCharacters_30 = ((int32_t)15);
		// [SerializeField] private int minCharacters = 3;
		__this->___minCharacters_31 = 3;
		// private bool isFirstKeyPress = true;
		__this->___isFirstKeyPress_33 = (bool)1;
		// private float shiftDoubleClickDelay = 0.5f;
		__this->___shiftDoubleClickDelay_39 = (0.5f);
		MonoBehaviour__ctor_m592DB0105CA0BC97AA1C5F4AD27B12D68A3B7C1E(__this, NULL);
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
// System.Void Keyboard.KeyChannel::RaiseKeyPressedEvent(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void KeyChannel_RaiseKeyPressedEvent_m7DC25E723FD945824CF374B90363FD10A2C3FD72 (KeyChannel_t928FC4C0F40F35E44A1B18D92A9B172B2B760A8A* __this, String_t* ___0_key, const RuntimeMethod* method) 
{
	UnityAction_1_t690494F0E492A2098660E28B8EB7D71B2C69BE1B* G_B2_0 = NULL;
	UnityAction_1_t690494F0E492A2098660E28B8EB7D71B2C69BE1B* G_B1_0 = NULL;
	{
		// OnKeyPressed?.Invoke(key);
		UnityAction_1_t690494F0E492A2098660E28B8EB7D71B2C69BE1B* L_0 = __this->___OnKeyPressed_4;
		UnityAction_1_t690494F0E492A2098660E28B8EB7D71B2C69BE1B* L_1 = L_0;
		G_B1_0 = L_1;
		if (L_1)
		{
			G_B2_0 = L_1;
			goto IL_000b;
		}
	}
	{
		return;
	}

IL_000b:
	{
		String_t* L_2 = ___0_key;
		NullCheck(G_B2_0);
		UnityAction_1_Invoke_m98256205DDBB544C1E934EB7590AC6D6D2093BF4_inline(G_B2_0, L_2, NULL);
		return;
	}
}
// System.Void Keyboard.KeyChannel::RaiseKeyColorsChangedEvent(UnityEngine.Color,UnityEngine.Color,UnityEngine.Color,UnityEngine.Color)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void KeyChannel_RaiseKeyColorsChangedEvent_mD1C7EE314F1390115D846C87B8E06805D5CBDC50 (KeyChannel_t928FC4C0F40F35E44A1B18D92A9B172B2B760A8A* __this, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___0_normalColor, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___1_highlightedColor, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___2_pressedColor, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___3_selectedColor, const RuntimeMethod* method) 
{
	UnityAction_4_t05D51CE8BEA0460D330923E761D421EF194ED9B1* G_B2_0 = NULL;
	UnityAction_4_t05D51CE8BEA0460D330923E761D421EF194ED9B1* G_B1_0 = NULL;
	{
		// OnKeyColorsChanged?.Invoke(normalColor, highlightedColor, pressedColor, selectedColor);
		UnityAction_4_t05D51CE8BEA0460D330923E761D421EF194ED9B1* L_0 = __this->___OnKeyColorsChanged_5;
		UnityAction_4_t05D51CE8BEA0460D330923E761D421EF194ED9B1* L_1 = L_0;
		G_B1_0 = L_1;
		if (L_1)
		{
			G_B2_0 = L_1;
			goto IL_000b;
		}
	}
	{
		return;
	}

IL_000b:
	{
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_2 = ___0_normalColor;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_3 = ___1_highlightedColor;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_4 = ___2_pressedColor;
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_5 = ___3_selectedColor;
		NullCheck(G_B2_0);
		UnityAction_4_Invoke_m9F4982DA5FB273A0BBC65D0448920E4310F21CB0_inline(G_B2_0, L_2, L_3, L_4, L_5, NULL);
		return;
	}
}
// System.Void Keyboard.KeyChannel::RaiseKeysStateChangeEvent(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void KeyChannel_RaiseKeysStateChangeEvent_mE220A22E89C0F8E3D1582B7836CE764C1E69D92E (KeyChannel_t928FC4C0F40F35E44A1B18D92A9B172B2B760A8A* __this, bool ___0_enabled, const RuntimeMethod* method) 
{
	UnityAction_1_t8EC357AF4FBD2A0C4A575C4BBD0B3A81029E43A9* G_B2_0 = NULL;
	UnityAction_1_t8EC357AF4FBD2A0C4A575C4BBD0B3A81029E43A9* G_B1_0 = NULL;
	{
		// OnKeysStateChange?.Invoke(enabled);
		UnityAction_1_t8EC357AF4FBD2A0C4A575C4BBD0B3A81029E43A9* L_0 = __this->___OnKeysStateChange_6;
		UnityAction_1_t8EC357AF4FBD2A0C4A575C4BBD0B3A81029E43A9* L_1 = L_0;
		G_B1_0 = L_1;
		if (L_1)
		{
			G_B2_0 = L_1;
			goto IL_000b;
		}
	}
	{
		return;
	}

IL_000b:
	{
		bool L_2 = ___0_enabled;
		NullCheck(G_B2_0);
		UnityAction_1_Invoke_mDDD7C50AEB02B2E86BCA82D46A0B32C9B8A6965B_inline(G_B2_0, L_2, NULL);
		return;
	}
}
// System.Void Keyboard.KeyChannel::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void KeyChannel__ctor_mDDF1CA4D02CA0EC42AD9F86BF89A148BFB9AD8ED (KeyChannel_t928FC4C0F40F35E44A1B18D92A9B172B2B760A8A* __this, const RuntimeMethod* method) 
{
	{
		ScriptableObject__ctor_mD037FDB0B487295EA47F79A4DB1BF1846C9087FF(__this, NULL);
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
// System.Void Keyboard.LetterKey::Awake()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LetterKey_Awake_mCCE802DF0DE23FECC44882FC07F72397B0BEF312 (LetterKey_tE8293A64AC9C3DB2D3C25A5F73BA0F931E763D49* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Component_GetComponentInChildren_TisTextMeshProUGUI_t101091AF4B578BB534C92E9D1EEAF0611636D957_m60A1B193FDBBFB3719065622DB5E0BB21CA4ABDC_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// base.Awake();
		Key_Awake_mE70A506A77B7A6BB87DB326A0B65B119767B8786(__this, NULL);
		// buttonText = GetComponentInChildren<TextMeshProUGUI>();
		TextMeshProUGUI_t101091AF4B578BB534C92E9D1EEAF0611636D957* L_0;
		L_0 = Component_GetComponentInChildren_TisTextMeshProUGUI_t101091AF4B578BB534C92E9D1EEAF0611636D957_m60A1B193FDBBFB3719065622DB5E0BB21CA4ABDC(__this, Component_GetComponentInChildren_TisTextMeshProUGUI_t101091AF4B578BB534C92E9D1EEAF0611636D957_m60A1B193FDBBFB3719065622DB5E0BB21CA4ABDC_RuntimeMethod_var);
		__this->___buttonText_8 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___buttonText_8), (void*)L_0);
		// InitializeKey();
		LetterKey_InitializeKey_mF209A9417F5BC9B52B47617EB0A66DB25C878C20(__this, NULL);
		// }
		return;
	}
}
// System.Void Keyboard.LetterKey::InitializeKey()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LetterKey_InitializeKey_mF209A9417F5BC9B52B47617EB0A66DB25C878C20 (LetterKey_tE8293A64AC9C3DB2D3C25A5F73BA0F931E763D49* __this, const RuntimeMethod* method) 
{
	TextMeshProUGUI_t101091AF4B578BB534C92E9D1EEAF0611636D957* G_B2_0 = NULL;
	TextMeshProUGUI_t101091AF4B578BB534C92E9D1EEAF0611636D957* G_B1_0 = NULL;
	String_t* G_B3_0 = NULL;
	TextMeshProUGUI_t101091AF4B578BB534C92E9D1EEAF0611636D957* G_B3_1 = NULL;
	{
		// private void InitializeKey() => buttonText.text = keyboard.autoCapsAtStart ? character.ToUpper() : character;
		TextMeshProUGUI_t101091AF4B578BB534C92E9D1EEAF0611636D957* L_0 = __this->___buttonText_8;
		KeyboardManager_t41DD8382AE61564F08C9856BE00640CCB87720FB* L_1 = ((Key_tB9DA6A9816AEA58ACE1AE6EA33755EAEEBAC8970*)__this)->___keyboard_5;
		NullCheck(L_1);
		bool L_2 = L_1->___autoCapsAtStart_15;
		G_B1_0 = L_0;
		if (L_2)
		{
			G_B2_0 = L_0;
			goto IL_001b;
		}
	}
	{
		String_t* L_3 = __this->___character_7;
		G_B3_0 = L_3;
		G_B3_1 = G_B1_0;
		goto IL_0026;
	}

IL_001b:
	{
		String_t* L_4 = __this->___character_7;
		NullCheck(L_4);
		String_t* L_5;
		L_5 = String_ToUpper_m5F499BC30C2A5F5C96248B4C3D1A3B4694748B49(L_4, NULL);
		G_B3_0 = L_5;
		G_B3_1 = G_B2_0;
	}

IL_0026:
	{
		NullCheck(G_B3_1);
		VirtualActionInvoker1< String_t* >::Invoke(66 /* System.Void TMPro.TMP_Text::set_text(System.String) */, G_B3_1, G_B3_0);
		return;
	}
}
// System.Void Keyboard.LetterKey::OnPress()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LetterKey_OnPress_m452611BD788B49375C2C99F266E4397A5A1B120D (LetterKey_tE8293A64AC9C3DB2D3C25A5F73BA0F931E763D49* __this, const RuntimeMethod* method) 
{
	{
		// base.OnPress();
		Key_OnPress_m71355FFA48E3DD2D8924B5C1B9E504B2D0EAE92C(__this, NULL);
		// keyChannel.RaiseKeyPressedEvent(character);
		KeyChannel_t928FC4C0F40F35E44A1B18D92A9B172B2B760A8A* L_0 = ((Key_tB9DA6A9816AEA58ACE1AE6EA33755EAEEBAC8970*)__this)->___keyChannel_4;
		String_t* L_1 = __this->___character_7;
		NullCheck(L_0);
		KeyChannel_RaiseKeyPressedEvent_m7DC25E723FD945824CF374B90363FD10A2C3FD72(L_0, L_1, NULL);
		// }
		return;
	}
}
// System.Void Keyboard.LetterKey::UpdateKey()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LetterKey_UpdateKey_m0B616AFC8AFBD5A51DB1AD67BF8ED22E583E4575 (LetterKey_tE8293A64AC9C3DB2D3C25A5F73BA0F931E763D49* __this, const RuntimeMethod* method) 
{
	{
		// if(keyboard.IsShiftActive() || keyboard.IsCapsLockActive())
		KeyboardManager_t41DD8382AE61564F08C9856BE00640CCB87720FB* L_0 = ((Key_tB9DA6A9816AEA58ACE1AE6EA33755EAEEBAC8970*)__this)->___keyboard_5;
		NullCheck(L_0);
		bool L_1;
		L_1 = KeyboardManager_IsShiftActive_m6751E01EFDE79B39663039847F711D4161E9C39F_inline(L_0, NULL);
		if (L_1)
		{
			goto IL_001a;
		}
	}
	{
		KeyboardManager_t41DD8382AE61564F08C9856BE00640CCB87720FB* L_2 = ((Key_tB9DA6A9816AEA58ACE1AE6EA33755EAEEBAC8970*)__this)->___keyboard_5;
		NullCheck(L_2);
		bool L_3;
		L_3 = KeyboardManager_IsCapsLockActive_m84C0D99FD40D977DBC3788ABCE1EE41EA4BACDEB_inline(L_2, NULL);
		if (!L_3)
		{
			goto IL_0031;
		}
	}

IL_001a:
	{
		// buttonText.text = character.ToUpper();
		TextMeshProUGUI_t101091AF4B578BB534C92E9D1EEAF0611636D957* L_4 = __this->___buttonText_8;
		String_t* L_5 = __this->___character_7;
		NullCheck(L_5);
		String_t* L_6;
		L_6 = String_ToUpper_m5F499BC30C2A5F5C96248B4C3D1A3B4694748B49(L_5, NULL);
		NullCheck(L_4);
		VirtualActionInvoker1< String_t* >::Invoke(66 /* System.Void TMPro.TMP_Text::set_text(System.String) */, L_4, L_6);
		return;
	}

IL_0031:
	{
		// buttonText.text = character.ToLower();
		TextMeshProUGUI_t101091AF4B578BB534C92E9D1EEAF0611636D957* L_7 = __this->___buttonText_8;
		String_t* L_8 = __this->___character_7;
		NullCheck(L_8);
		String_t* L_9;
		L_9 = String_ToLower_m6191ABA3DC514ED47C10BDA23FD0DDCEAE7ACFBD(L_8, NULL);
		NullCheck(L_7);
		VirtualActionInvoker1< String_t* >::Invoke(66 /* System.Void TMPro.TMP_Text::set_text(System.String) */, L_7, L_9);
		// }
		return;
	}
}
// System.Void Keyboard.LetterKey::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void LetterKey__ctor_m486C36E7534533BA6DE1AD556D39CC3F0D875065 (LetterKey_tE8293A64AC9C3DB2D3C25A5F73BA0F931E763D49* __this, const RuntimeMethod* method) 
{
	{
		Key__ctor_m9C214508D172EE99713AC7F36C9B0309D9C77312(__this, NULL);
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
// System.UInt32 <PrivateImplementationDetails>::ComputeStringHash(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR uint32_t U3CPrivateImplementationDetailsU3E_ComputeStringHash_m6EA1F233618497AEFF8902A5EDFA24C74E2F2876 (String_t* ___0_s, const RuntimeMethod* method) 
{
	uint32_t V_0 = 0;
	int32_t V_1 = 0;
	{
		String_t* L_0 = ___0_s;
		if (!L_0)
		{
			goto IL_002a;
		}
	}
	{
		V_0 = ((int32_t)-2128831035);
		V_1 = 0;
		goto IL_0021;
	}

IL_000d:
	{
		String_t* L_1 = ___0_s;
		int32_t L_2 = V_1;
		NullCheck(L_1);
		Il2CppChar L_3;
		L_3 = String_get_Chars_mC49DF0CD2D3BE7BE97B3AD9C995BE3094F8E36D3(L_1, L_2, NULL);
		uint32_t L_4 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_multiply(((int32_t)((int32_t)L_3^(int32_t)L_4)), ((int32_t)16777619)));
		int32_t L_5 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add(L_5, 1));
	}

IL_0021:
	{
		int32_t L_6 = V_1;
		String_t* L_7 = ___0_s;
		NullCheck(L_7);
		int32_t L_8;
		L_8 = String_get_Length_m42625D67623FA5CC7A44D47425CE86FB946542D2_inline(L_7, NULL);
		if ((((int32_t)L_6) < ((int32_t)L_8)))
		{
			goto IL_000d;
		}
	}

IL_002a:
	{
		uint32_t L_9 = V_0;
		return L_9;
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
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Color32__ctor_mC9C6B443F0C7CA3F8B174158B2AF6F05E18EAC4E_inline (Color32_t73C5004937BF5BB8AD55323D51AAA40A898EF48B* __this, uint8_t ___0_r, uint8_t ___1_g, uint8_t ___2_b, uint8_t ___3_a, const RuntimeMethod* method) 
{
	{
		__this->___rgba_0 = 0;
		uint8_t L_0 = ___0_r;
		__this->___r_1 = L_0;
		uint8_t L_1 = ___1_g;
		__this->___g_2 = L_1;
		uint8_t L_2 = ___2_b;
		__this->___b_3 = L_2;
		uint8_t L_3 = ___3_a;
		__this->___a_4 = L_3;
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Color__ctor_m3786F0D6E510D9CFA544523A955870BD2A514C8C_inline (Color_tD001788D726C3A7F1379BEED0260B9591F440C1F* __this, float ___0_r, float ___1_g, float ___2_b, float ___3_a, const RuntimeMethod* method) 
{
	{
		float L_0 = ___0_r;
		__this->___r_0 = L_0;
		float L_1 = ___1_g;
		__this->___g_1 = L_1;
		float L_2 = ___2_b;
		__this->___b_2 = L_2;
		float L_3 = ___3_a;
		__this->___a_3 = L_3;
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR ButtonClickedEvent_t8EA72E90B3BD1392FB3B3EF167D5121C23569E4C* Button_get_onClick_m701712A7F7F000CC80D517C4510697E15722C35C_inline (Button_t6786514A57F7AFDEE5431112FEA0CAB24F5AE098* __this, const RuntimeMethod* method) 
{
	{
		// get { return m_OnClick; }
		ButtonClickedEvent_t8EA72E90B3BD1392FB3B3EF167D5121C23569E4C* L_0 = __this->___m_OnClick_20;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR ColorBlock_tDD7C62E7AFE442652FC98F8D058CE8AE6BFD7C11 Selectable_get_colors_mB53E365D02351D4B64084295C4B2A7AF2DEC4750_inline (Selectable_t3251808068A17B8E92FB33590A4C2FA66D456712* __this, const RuntimeMethod* method) 
{
	{
		// public ColorBlock        colors            { get { return m_Colors; } set { if (SetPropertyUtility.SetStruct(ref m_Colors, value))            OnSetProperty(); } }
		ColorBlock_tDD7C62E7AFE442652FC98F8D058CE8AE6BFD7C11 L_0 = __this->___m_Colors_9;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void ColorBlock_set_normalColor_m3EBF594F6FA2C6494ACA9FCB9B458807D85B96F8_inline (ColorBlock_tDD7C62E7AFE442652FC98F8D058CE8AE6BFD7C11* __this, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___0_value, const RuntimeMethod* method) 
{
	{
		// public Color normalColor       { get { return m_NormalColor; } set { m_NormalColor = value; } }
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_0 = ___0_value;
		__this->___m_NormalColor_0 = L_0;
		// public Color normalColor       { get { return m_NormalColor; } set { m_NormalColor = value; } }
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void ColorBlock_set_highlightedColor_m04E97DF2CCE7CAC47120D8F486E18BF62F16FF86_inline (ColorBlock_tDD7C62E7AFE442652FC98F8D058CE8AE6BFD7C11* __this, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___0_value, const RuntimeMethod* method) 
{
	{
		// public Color highlightedColor  { get { return m_HighlightedColor; } set { m_HighlightedColor = value; } }
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_0 = ___0_value;
		__this->___m_HighlightedColor_1 = L_0;
		// public Color highlightedColor  { get { return m_HighlightedColor; } set { m_HighlightedColor = value; } }
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void ColorBlock_set_pressedColor_m644C938090857AB07C57B25FE53F6DC2BB0DD5A8_inline (ColorBlock_tDD7C62E7AFE442652FC98F8D058CE8AE6BFD7C11* __this, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___0_value, const RuntimeMethod* method) 
{
	{
		// public Color pressedColor      { get { return m_PressedColor; } set { m_PressedColor = value; } }
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_0 = ___0_value;
		__this->___m_PressedColor_2 = L_0;
		// public Color pressedColor      { get { return m_PressedColor; } set { m_PressedColor = value; } }
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void ColorBlock_set_selectedColor_m76FEFB1148798B7A356C974CDEA3BA2E2E3C1D21_inline (ColorBlock_tDD7C62E7AFE442652FC98F8D058CE8AE6BFD7C11* __this, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___0_value, const RuntimeMethod* method) 
{
	{
		// public Color selectedColor     { get { return m_SelectedColor; } set { m_SelectedColor = value; } }
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_0 = ___0_value;
		__this->___m_SelectedColor_3 = L_0;
		// public Color selectedColor     { get { return m_SelectedColor; } set { m_SelectedColor = value; } }
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* EventSystem_get_currentSelectedGameObject_mD606FFACF3E72755298A523CBB709535CF08C98A_inline (EventSystem_t61C51380B105BE9D2C39C4F15B7E655659957707* __this, const RuntimeMethod* method) 
{
	{
		// get { return m_CurrentSelected; }
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_0 = __this->___m_CurrentSelected_10;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t Mathf_Min_m888083F74FF5655778F0403BB5E9608BEFDEA8CB_inline (int32_t ___0_a, int32_t ___1_b, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	int32_t G_B3_0 = 0;
	{
		int32_t L_0 = ___0_a;
		int32_t L_1 = ___1_b;
		if ((((int32_t)L_0) < ((int32_t)L_1)))
		{
			goto IL_0008;
		}
	}
	{
		int32_t L_2 = ___1_b;
		G_B3_0 = L_2;
		goto IL_0009;
	}

IL_0008:
	{
		int32_t L_3 = ___0_a;
		G_B3_0 = L_3;
	}

IL_0009:
	{
		V_0 = G_B3_0;
		goto IL_000c;
	}

IL_000c:
	{
		int32_t L_4 = V_0;
		return L_4;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t Mathf_Max_m7FA442918DE37E3A00106D1F2E789D65829792B8_inline (int32_t ___0_a, int32_t ___1_b, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	int32_t G_B3_0 = 0;
	{
		int32_t L_0 = ___0_a;
		int32_t L_1 = ___1_b;
		if ((((int32_t)L_0) > ((int32_t)L_1)))
		{
			goto IL_0008;
		}
	}
	{
		int32_t L_2 = ___1_b;
		G_B3_0 = L_2;
		goto IL_0009;
	}

IL_0008:
	{
		int32_t L_3 = ___0_a;
		G_B3_0 = L_3;
	}

IL_0009:
	{
		V_0 = G_B3_0;
		goto IL_000c;
	}

IL_000c:
	{
		int32_t L_4 = V_0;
		return L_4;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR String_t* TMP_InputField_get_text_mA4ACBF52435893D9DFD822A492454301740B3C6A_inline (TMP_InputField_t3488E0EE8C3DF56C6A328EC95D1BEEA2DF4A7D5F* __this, const RuntimeMethod* method) 
{
	{
		// return m_Text;
		String_t* L_0 = __this->___m_Text_60;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t String_get_Length_m42625D67623FA5CC7A44D47425CE86FB946542D2_inline (String_t* __this, const RuntimeMethod* method) 
{
	{
		int32_t L_0 = __this->____stringLength_4;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Color_tD001788D726C3A7F1379BEED0260B9591F440C1F Color_get_black_mB50217951591A045844C61E7FF31EEE3FEF16737_inline (const RuntimeMethod* method) 
{
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_0;
		memset((&L_0), 0, sizeof(L_0));
		Color__ctor_m3786F0D6E510D9CFA544523A955870BD2A514C8C_inline((&L_0), (0.0f), (0.0f), (0.0f), (1.0f), /*hidden argument*/NULL);
		V_0 = L_0;
		goto IL_001d;
	}

IL_001d:
	{
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_1 = V_0;
		return L_1;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Color_tD001788D726C3A7F1379BEED0260B9591F440C1F Color_get_yellow_m66637FA14383E8D74F24AE256B577CE1D55D469F_inline (const RuntimeMethod* method) 
{
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_0;
		memset((&L_0), 0, sizeof(L_0));
		Color__ctor_m3786F0D6E510D9CFA544523A955870BD2A514C8C_inline((&L_0), (1.0f), (0.921568632f), (0.0156862754f), (1.0f), /*hidden argument*/NULL);
		V_0 = L_0;
		goto IL_001d;
	}

IL_001d:
	{
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_1 = V_0;
		return L_1;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Color_tD001788D726C3A7F1379BEED0260B9591F440C1F Color_get_red_mA2E53E7173FDC97E68E335049AB0FAAEE43A844D_inline (const RuntimeMethod* method) 
{
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_0;
		memset((&L_0), 0, sizeof(L_0));
		Color__ctor_m3786F0D6E510D9CFA544523A955870BD2A514C8C_inline((&L_0), (1.0f), (0.0f), (0.0f), (1.0f), /*hidden argument*/NULL);
		V_0 = L_0;
		goto IL_001d;
	}

IL_001d:
	{
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_1 = V_0;
		return L_1;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Color_tD001788D726C3A7F1379BEED0260B9591F440C1F Color_get_blue_mF04A26CE61D6DA3C0D8B1C4720901B1028C7AB87_inline (const RuntimeMethod* method) 
{
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_0;
		memset((&L_0), 0, sizeof(L_0));
		Color__ctor_m3786F0D6E510D9CFA544523A955870BD2A514C8C_inline((&L_0), (0.0f), (0.0f), (1.0f), (1.0f), /*hidden argument*/NULL);
		V_0 = L_0;
		goto IL_001d;
	}

IL_001d:
	{
		Color_tD001788D726C3A7F1379BEED0260B9591F440C1F L_1 = V_0;
		return L_1;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool KeyboardManager_IsShiftActive_m6751E01EFDE79B39663039847F711D4161E9C39F_inline (KeyboardManager_t41DD8382AE61564F08C9856BE00640CCB87720FB* __this, const RuntimeMethod* method) 
{
	{
		// public bool IsShiftActive() => shiftActive;
		bool L_0 = __this->___shiftActive_35;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool KeyboardManager_IsCapsLockActive_m84C0D99FD40D977DBC3788ABCE1EE41EA4BACDEB_inline (KeyboardManager_t41DD8382AE61564F08C9856BE00640CCB87720FB* __this, const RuntimeMethod* method) 
{
	{
		// public bool IsCapsLockActive() => capsLockActive;
		bool L_0 = __this->___capsLockActive_36;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void UnityAction_1_Invoke_m777839BF9CB9F96B081106B47202D06FB35326CA_gshared_inline (UnityAction_1_t9C30BCD020745BF400CBACF22C6F34ADBA2DDA6A* __this, RuntimeObject* ___0_arg0, const RuntimeMethod* method) 
{
	typedef void (*FunctionPointerType) (RuntimeObject*, RuntimeObject*, const RuntimeMethod*);
	((FunctionPointerType)__this->___invoke_impl_1)((Il2CppObject*)__this->___method_code_6, ___0_arg0, reinterpret_cast<RuntimeMethod*>(__this->___method_3));
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void UnityAction_4_Invoke_m9F4982DA5FB273A0BBC65D0448920E4310F21CB0_gshared_inline (UnityAction_4_t05D51CE8BEA0460D330923E761D421EF194ED9B1* __this, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___0_arg0, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___1_arg1, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___2_arg2, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___3_arg3, const RuntimeMethod* method) 
{
	typedef void (*FunctionPointerType) (RuntimeObject*, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F, Color_tD001788D726C3A7F1379BEED0260B9591F440C1F, const RuntimeMethod*);
	((FunctionPointerType)__this->___invoke_impl_1)((Il2CppObject*)__this->___method_code_6, ___0_arg0, ___1_arg1, ___2_arg2, ___3_arg3, reinterpret_cast<RuntimeMethod*>(__this->___method_3));
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void UnityAction_1_Invoke_mDDD7C50AEB02B2E86BCA82D46A0B32C9B8A6965B_gshared_inline (UnityAction_1_t8EC357AF4FBD2A0C4A575C4BBD0B3A81029E43A9* __this, bool ___0_arg0, const RuntimeMethod* method) 
{
	typedef void (*FunctionPointerType) (RuntimeObject*, bool, const RuntimeMethod*);
	((FunctionPointerType)__this->___invoke_impl_1)((Il2CppObject*)__this->___method_code_6, ___0_arg0, reinterpret_cast<RuntimeMethod*>(__this->___method_3));
}
