#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <cstring>
#include <string.h>
#include <stdio.h>
#include <cmath>
#include <limits>
#include <assert.h>
#include <stdint.h>

#include "class-internals.h"
#include "codegen/il2cpp-codegen.h"
#include "object-internals.h"

// UnityEngine.Mesh[]
struct MeshU5BU5D_t894826206;
// System.Void
struct Void_t1841601450;
// System.Char[]
struct CharU5BU5D_t1328083999;
// UnityEngine.Shader
struct Shader_t2430389951;
// UnityEngine.Material
struct Material_t193706927;
// System.Collections.Generic.List`1<UnityEngine.Material>
struct List_1_t3857795355;
// UnityEngine.AnimationCurve
struct AnimationCurve_t3306541151;
// UnityEngine.Texture2D
struct Texture2D_t3542995729;
// UnityEngine.RenderTexture
struct RenderTexture_t2666733923;




#ifndef RUNTIMEOBJECT_H
#define RUNTIMEOBJECT_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Object

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // RUNTIMEOBJECT_H
#ifndef VALUETYPE_T3507792607_H
#define VALUETYPE_T3507792607_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.ValueType
struct  ValueType_t3507792607  : public RuntimeObject
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
// Native definition for P/Invoke marshalling of System.ValueType
struct ValueType_t3507792607_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.ValueType
struct ValueType_t3507792607_marshaled_com
{
};
#endif // VALUETYPE_T3507792607_H
#ifndef TRIANGLES_T1046072227_H
#define TRIANGLES_T1046072227_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityStandardAssets.ImageEffects.Triangles
struct  Triangles_t1046072227  : public RuntimeObject
{
public:

public:
};

struct Triangles_t1046072227_StaticFields
{
public:
	// UnityEngine.Mesh[] UnityStandardAssets.ImageEffects.Triangles::meshes
	MeshU5BU5D_t894826206* ___meshes_0;
	// System.Int32 UnityStandardAssets.ImageEffects.Triangles::currentTris
	int32_t ___currentTris_1;

public:
	inline static int32_t get_offset_of_meshes_0() { return static_cast<int32_t>(offsetof(Triangles_t1046072227_StaticFields, ___meshes_0)); }
	inline MeshU5BU5D_t894826206* get_meshes_0() const { return ___meshes_0; }
	inline MeshU5BU5D_t894826206** get_address_of_meshes_0() { return &___meshes_0; }
	inline void set_meshes_0(MeshU5BU5D_t894826206* value)
	{
		___meshes_0 = value;
		Il2CppCodeGenWriteBarrier((&___meshes_0), value);
	}

	inline static int32_t get_offset_of_currentTris_1() { return static_cast<int32_t>(offsetof(Triangles_t1046072227_StaticFields, ___currentTris_1)); }
	inline int32_t get_currentTris_1() const { return ___currentTris_1; }
	inline int32_t* get_address_of_currentTris_1() { return &___currentTris_1; }
	inline void set_currentTris_1(int32_t value)
	{
		___currentTris_1 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // TRIANGLES_T1046072227_H
#ifndef INTPTR_T_H
#define INTPTR_T_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.IntPtr
struct  IntPtr_t 
{
public:
	// System.Void* System.IntPtr::m_value
	void* ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(IntPtr_t, ___m_value_0)); }
	inline void* get_m_value_0() const { return ___m_value_0; }
	inline void** get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(void* value)
	{
		___m_value_0 = value;
	}
};

struct IntPtr_t_StaticFields
{
public:
	// System.IntPtr System.IntPtr::Zero
	IntPtr_t ___Zero_1;

public:
	inline static int32_t get_offset_of_Zero_1() { return static_cast<int32_t>(offsetof(IntPtr_t_StaticFields, ___Zero_1)); }
	inline IntPtr_t get_Zero_1() const { return ___Zero_1; }
	inline IntPtr_t* get_address_of_Zero_1() { return &___Zero_1; }
	inline void set_Zero_1(IntPtr_t value)
	{
		___Zero_1 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // INTPTR_T_H
#ifndef ENUM_T2459695545_H
#define ENUM_T2459695545_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Enum
struct  Enum_t2459695545  : public ValueType_t3507792607
{
public:

public:
};

struct Enum_t2459695545_StaticFields
{
public:
	// System.Char[] System.Enum::split_char
	CharU5BU5D_t1328083999* ___split_char_0;

public:
	inline static int32_t get_offset_of_split_char_0() { return static_cast<int32_t>(offsetof(Enum_t2459695545_StaticFields, ___split_char_0)); }
	inline CharU5BU5D_t1328083999* get_split_char_0() const { return ___split_char_0; }
	inline CharU5BU5D_t1328083999** get_address_of_split_char_0() { return &___split_char_0; }
	inline void set_split_char_0(CharU5BU5D_t1328083999* value)
	{
		___split_char_0 = value;
		Il2CppCodeGenWriteBarrier((&___split_char_0), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
// Native definition for P/Invoke marshalling of System.Enum
struct Enum_t2459695545_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.Enum
struct Enum_t2459695545_marshaled_com
{
};
#endif // ENUM_T2459695545_H
#ifndef VECTOR2_T2243707579_H
#define VECTOR2_T2243707579_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.Vector2
struct  Vector2_t2243707579 
{
public:
	// System.Single UnityEngine.Vector2::x
	float ___x_0;
	// System.Single UnityEngine.Vector2::y
	float ___y_1;

public:
	inline static int32_t get_offset_of_x_0() { return static_cast<int32_t>(offsetof(Vector2_t2243707579, ___x_0)); }
	inline float get_x_0() const { return ___x_0; }
	inline float* get_address_of_x_0() { return &___x_0; }
	inline void set_x_0(float value)
	{
		___x_0 = value;
	}

	inline static int32_t get_offset_of_y_1() { return static_cast<int32_t>(offsetof(Vector2_t2243707579, ___y_1)); }
	inline float get_y_1() const { return ___y_1; }
	inline float* get_address_of_y_1() { return &___y_1; }
	inline void set_y_1(float value)
	{
		___y_1 = value;
	}
};

struct Vector2_t2243707579_StaticFields
{
public:
	// UnityEngine.Vector2 UnityEngine.Vector2::zeroVector
	Vector2_t2243707579  ___zeroVector_2;
	// UnityEngine.Vector2 UnityEngine.Vector2::oneVector
	Vector2_t2243707579  ___oneVector_3;
	// UnityEngine.Vector2 UnityEngine.Vector2::upVector
	Vector2_t2243707579  ___upVector_4;
	// UnityEngine.Vector2 UnityEngine.Vector2::downVector
	Vector2_t2243707579  ___downVector_5;
	// UnityEngine.Vector2 UnityEngine.Vector2::leftVector
	Vector2_t2243707579  ___leftVector_6;
	// UnityEngine.Vector2 UnityEngine.Vector2::rightVector
	Vector2_t2243707579  ___rightVector_7;
	// UnityEngine.Vector2 UnityEngine.Vector2::positiveInfinityVector
	Vector2_t2243707579  ___positiveInfinityVector_8;
	// UnityEngine.Vector2 UnityEngine.Vector2::negativeInfinityVector
	Vector2_t2243707579  ___negativeInfinityVector_9;

public:
	inline static int32_t get_offset_of_zeroVector_2() { return static_cast<int32_t>(offsetof(Vector2_t2243707579_StaticFields, ___zeroVector_2)); }
	inline Vector2_t2243707579  get_zeroVector_2() const { return ___zeroVector_2; }
	inline Vector2_t2243707579 * get_address_of_zeroVector_2() { return &___zeroVector_2; }
	inline void set_zeroVector_2(Vector2_t2243707579  value)
	{
		___zeroVector_2 = value;
	}

	inline static int32_t get_offset_of_oneVector_3() { return static_cast<int32_t>(offsetof(Vector2_t2243707579_StaticFields, ___oneVector_3)); }
	inline Vector2_t2243707579  get_oneVector_3() const { return ___oneVector_3; }
	inline Vector2_t2243707579 * get_address_of_oneVector_3() { return &___oneVector_3; }
	inline void set_oneVector_3(Vector2_t2243707579  value)
	{
		___oneVector_3 = value;
	}

	inline static int32_t get_offset_of_upVector_4() { return static_cast<int32_t>(offsetof(Vector2_t2243707579_StaticFields, ___upVector_4)); }
	inline Vector2_t2243707579  get_upVector_4() const { return ___upVector_4; }
	inline Vector2_t2243707579 * get_address_of_upVector_4() { return &___upVector_4; }
	inline void set_upVector_4(Vector2_t2243707579  value)
	{
		___upVector_4 = value;
	}

	inline static int32_t get_offset_of_downVector_5() { return static_cast<int32_t>(offsetof(Vector2_t2243707579_StaticFields, ___downVector_5)); }
	inline Vector2_t2243707579  get_downVector_5() const { return ___downVector_5; }
	inline Vector2_t2243707579 * get_address_of_downVector_5() { return &___downVector_5; }
	inline void set_downVector_5(Vector2_t2243707579  value)
	{
		___downVector_5 = value;
	}

	inline static int32_t get_offset_of_leftVector_6() { return static_cast<int32_t>(offsetof(Vector2_t2243707579_StaticFields, ___leftVector_6)); }
	inline Vector2_t2243707579  get_leftVector_6() const { return ___leftVector_6; }
	inline Vector2_t2243707579 * get_address_of_leftVector_6() { return &___leftVector_6; }
	inline void set_leftVector_6(Vector2_t2243707579  value)
	{
		___leftVector_6 = value;
	}

	inline static int32_t get_offset_of_rightVector_7() { return static_cast<int32_t>(offsetof(Vector2_t2243707579_StaticFields, ___rightVector_7)); }
	inline Vector2_t2243707579  get_rightVector_7() const { return ___rightVector_7; }
	inline Vector2_t2243707579 * get_address_of_rightVector_7() { return &___rightVector_7; }
	inline void set_rightVector_7(Vector2_t2243707579  value)
	{
		___rightVector_7 = value;
	}

	inline static int32_t get_offset_of_positiveInfinityVector_8() { return static_cast<int32_t>(offsetof(Vector2_t2243707579_StaticFields, ___positiveInfinityVector_8)); }
	inline Vector2_t2243707579  get_positiveInfinityVector_8() const { return ___positiveInfinityVector_8; }
	inline Vector2_t2243707579 * get_address_of_positiveInfinityVector_8() { return &___positiveInfinityVector_8; }
	inline void set_positiveInfinityVector_8(Vector2_t2243707579  value)
	{
		___positiveInfinityVector_8 = value;
	}

	inline static int32_t get_offset_of_negativeInfinityVector_9() { return static_cast<int32_t>(offsetof(Vector2_t2243707579_StaticFields, ___negativeInfinityVector_9)); }
	inline Vector2_t2243707579  get_negativeInfinityVector_9() const { return ___negativeInfinityVector_9; }
	inline Vector2_t2243707579 * get_address_of_negativeInfinityVector_9() { return &___negativeInfinityVector_9; }
	inline void set_negativeInfinityVector_9(Vector2_t2243707579  value)
	{
		___negativeInfinityVector_9 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // VECTOR2_T2243707579_H
#ifndef OBJECT_T1021602117_H
#define OBJECT_T1021602117_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.Object
struct  Object_t1021602117  : public RuntimeObject
{
public:
	// System.IntPtr UnityEngine.Object::m_CachedPtr
	IntPtr_t ___m_CachedPtr_0;

public:
	inline static int32_t get_offset_of_m_CachedPtr_0() { return static_cast<int32_t>(offsetof(Object_t1021602117, ___m_CachedPtr_0)); }
	inline IntPtr_t get_m_CachedPtr_0() const { return ___m_CachedPtr_0; }
	inline IntPtr_t* get_address_of_m_CachedPtr_0() { return &___m_CachedPtr_0; }
	inline void set_m_CachedPtr_0(IntPtr_t value)
	{
		___m_CachedPtr_0 = value;
	}
};

struct Object_t1021602117_StaticFields
{
public:
	// System.Int32 UnityEngine.Object::OffsetOfInstanceIDInCPlusPlusObject
	int32_t ___OffsetOfInstanceIDInCPlusPlusObject_1;

public:
	inline static int32_t get_offset_of_OffsetOfInstanceIDInCPlusPlusObject_1() { return static_cast<int32_t>(offsetof(Object_t1021602117_StaticFields, ___OffsetOfInstanceIDInCPlusPlusObject_1)); }
	inline int32_t get_OffsetOfInstanceIDInCPlusPlusObject_1() const { return ___OffsetOfInstanceIDInCPlusPlusObject_1; }
	inline int32_t* get_address_of_OffsetOfInstanceIDInCPlusPlusObject_1() { return &___OffsetOfInstanceIDInCPlusPlusObject_1; }
	inline void set_OffsetOfInstanceIDInCPlusPlusObject_1(int32_t value)
	{
		___OffsetOfInstanceIDInCPlusPlusObject_1 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
// Native definition for P/Invoke marshalling of UnityEngine.Object
struct Object_t1021602117_marshaled_pinvoke
{
	intptr_t ___m_CachedPtr_0;
};
// Native definition for COM marshalling of UnityEngine.Object
struct Object_t1021602117_marshaled_com
{
	intptr_t ___m_CachedPtr_0;
};
#endif // OBJECT_T1021602117_H
#ifndef RENDERTEXTUREFORMAT_T3360518468_H
#define RENDERTEXTUREFORMAT_T3360518468_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.RenderTextureFormat
struct  RenderTextureFormat_t3360518468 
{
public:
	// System.Int32 UnityEngine.RenderTextureFormat::value__
	int32_t ___value___1;

public:
	inline static int32_t get_offset_of_value___1() { return static_cast<int32_t>(offsetof(RenderTextureFormat_t3360518468, ___value___1)); }
	inline int32_t get_value___1() const { return ___value___1; }
	inline int32_t* get_address_of_value___1() { return &___value___1; }
	inline void set_value___1(int32_t value)
	{
		___value___1 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // RENDERTEXTUREFORMAT_T3360518468_H
#ifndef ADAPTIVETEXSIZE_T1008153775_H
#define ADAPTIVETEXSIZE_T1008153775_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityStandardAssets.ImageEffects.Tonemapping/AdaptiveTexSize
struct  AdaptiveTexSize_t1008153775 
{
public:
	// System.Int32 UnityStandardAssets.ImageEffects.Tonemapping/AdaptiveTexSize::value__
	int32_t ___value___1;

public:
	inline static int32_t get_offset_of_value___1() { return static_cast<int32_t>(offsetof(AdaptiveTexSize_t1008153775, ___value___1)); }
	inline int32_t get_value___1() const { return ___value___1; }
	inline int32_t* get_address_of_value___1() { return &___value___1; }
	inline void set_value___1(int32_t value)
	{
		___value___1 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // ADAPTIVETEXSIZE_T1008153775_H
#ifndef TONEMAPPERTYPE_T3310062628_H
#define TONEMAPPERTYPE_T3310062628_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityStandardAssets.ImageEffects.Tonemapping/TonemapperType
struct  TonemapperType_t3310062628 
{
public:
	// System.Int32 UnityStandardAssets.ImageEffects.Tonemapping/TonemapperType::value__
	int32_t ___value___1;

public:
	inline static int32_t get_offset_of_value___1() { return static_cast<int32_t>(offsetof(TonemapperType_t3310062628, ___value___1)); }
	inline int32_t get_value___1() const { return ___value___1; }
	inline int32_t* get_address_of_value___1() { return &___value___1; }
	inline void set_value___1(int32_t value)
	{
		___value___1 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // TONEMAPPERTYPE_T3310062628_H
#ifndef ABERRATIONMODE_T3949418959_H
#define ABERRATIONMODE_T3949418959_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityStandardAssets.ImageEffects.VignetteAndChromaticAberration/AberrationMode
struct  AberrationMode_t3949418959 
{
public:
	// System.Int32 UnityStandardAssets.ImageEffects.VignetteAndChromaticAberration/AberrationMode::value__
	int32_t ___value___1;

public:
	inline static int32_t get_offset_of_value___1() { return static_cast<int32_t>(offsetof(AberrationMode_t3949418959, ___value___1)); }
	inline int32_t get_value___1() const { return ___value___1; }
	inline int32_t* get_address_of_value___1() { return &___value___1; }
	inline void set_value___1(int32_t value)
	{
		___value___1 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // ABERRATIONMODE_T3949418959_H
#ifndef COMPONENT_T3819376471_H
#define COMPONENT_T3819376471_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.Component
struct  Component_t3819376471  : public Object_t1021602117
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // COMPONENT_T3819376471_H
#ifndef BEHAVIOUR_T955675639_H
#define BEHAVIOUR_T955675639_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.Behaviour
struct  Behaviour_t955675639  : public Component_t3819376471
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // BEHAVIOUR_T955675639_H
#ifndef MONOBEHAVIOUR_T1158329972_H
#define MONOBEHAVIOUR_T1158329972_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.MonoBehaviour
struct  MonoBehaviour_t1158329972  : public Behaviour_t955675639
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // MONOBEHAVIOUR_T1158329972_H
#ifndef IMAGEEFFECTBASE_T517806655_H
#define IMAGEEFFECTBASE_T517806655_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityStandardAssets.ImageEffects.ImageEffectBase
struct  ImageEffectBase_t517806655  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.Shader UnityStandardAssets.ImageEffects.ImageEffectBase::shader
	Shader_t2430389951 * ___shader_2;
	// UnityEngine.Material UnityStandardAssets.ImageEffects.ImageEffectBase::m_Material
	Material_t193706927 * ___m_Material_3;

public:
	inline static int32_t get_offset_of_shader_2() { return static_cast<int32_t>(offsetof(ImageEffectBase_t517806655, ___shader_2)); }
	inline Shader_t2430389951 * get_shader_2() const { return ___shader_2; }
	inline Shader_t2430389951 ** get_address_of_shader_2() { return &___shader_2; }
	inline void set_shader_2(Shader_t2430389951 * value)
	{
		___shader_2 = value;
		Il2CppCodeGenWriteBarrier((&___shader_2), value);
	}

	inline static int32_t get_offset_of_m_Material_3() { return static_cast<int32_t>(offsetof(ImageEffectBase_t517806655, ___m_Material_3)); }
	inline Material_t193706927 * get_m_Material_3() const { return ___m_Material_3; }
	inline Material_t193706927 ** get_address_of_m_Material_3() { return &___m_Material_3; }
	inline void set_m_Material_3(Material_t193706927 * value)
	{
		___m_Material_3 = value;
		Il2CppCodeGenWriteBarrier((&___m_Material_3), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // IMAGEEFFECTBASE_T517806655_H
#ifndef POSTEFFECTSBASE_T2152133263_H
#define POSTEFFECTSBASE_T2152133263_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityStandardAssets.ImageEffects.PostEffectsBase
struct  PostEffectsBase_t2152133263  : public MonoBehaviour_t1158329972
{
public:
	// System.Boolean UnityStandardAssets.ImageEffects.PostEffectsBase::supportHDRTextures
	bool ___supportHDRTextures_2;
	// System.Boolean UnityStandardAssets.ImageEffects.PostEffectsBase::supportDX11
	bool ___supportDX11_3;
	// System.Boolean UnityStandardAssets.ImageEffects.PostEffectsBase::isSupported
	bool ___isSupported_4;
	// System.Collections.Generic.List`1<UnityEngine.Material> UnityStandardAssets.ImageEffects.PostEffectsBase::createdMaterials
	List_1_t3857795355 * ___createdMaterials_5;

public:
	inline static int32_t get_offset_of_supportHDRTextures_2() { return static_cast<int32_t>(offsetof(PostEffectsBase_t2152133263, ___supportHDRTextures_2)); }
	inline bool get_supportHDRTextures_2() const { return ___supportHDRTextures_2; }
	inline bool* get_address_of_supportHDRTextures_2() { return &___supportHDRTextures_2; }
	inline void set_supportHDRTextures_2(bool value)
	{
		___supportHDRTextures_2 = value;
	}

	inline static int32_t get_offset_of_supportDX11_3() { return static_cast<int32_t>(offsetof(PostEffectsBase_t2152133263, ___supportDX11_3)); }
	inline bool get_supportDX11_3() const { return ___supportDX11_3; }
	inline bool* get_address_of_supportDX11_3() { return &___supportDX11_3; }
	inline void set_supportDX11_3(bool value)
	{
		___supportDX11_3 = value;
	}

	inline static int32_t get_offset_of_isSupported_4() { return static_cast<int32_t>(offsetof(PostEffectsBase_t2152133263, ___isSupported_4)); }
	inline bool get_isSupported_4() const { return ___isSupported_4; }
	inline bool* get_address_of_isSupported_4() { return &___isSupported_4; }
	inline void set_isSupported_4(bool value)
	{
		___isSupported_4 = value;
	}

	inline static int32_t get_offset_of_createdMaterials_5() { return static_cast<int32_t>(offsetof(PostEffectsBase_t2152133263, ___createdMaterials_5)); }
	inline List_1_t3857795355 * get_createdMaterials_5() const { return ___createdMaterials_5; }
	inline List_1_t3857795355 ** get_address_of_createdMaterials_5() { return &___createdMaterials_5; }
	inline void set_createdMaterials_5(List_1_t3857795355 * value)
	{
		___createdMaterials_5 = value;
		Il2CppCodeGenWriteBarrier((&___createdMaterials_5), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // POSTEFFECTSBASE_T2152133263_H
#ifndef TWIRL_T1381705816_H
#define TWIRL_T1381705816_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityStandardAssets.ImageEffects.Twirl
struct  Twirl_t1381705816  : public ImageEffectBase_t517806655
{
public:
	// UnityEngine.Vector2 UnityStandardAssets.ImageEffects.Twirl::radius
	Vector2_t2243707579  ___radius_4;
	// System.Single UnityStandardAssets.ImageEffects.Twirl::angle
	float ___angle_5;
	// UnityEngine.Vector2 UnityStandardAssets.ImageEffects.Twirl::center
	Vector2_t2243707579  ___center_6;

public:
	inline static int32_t get_offset_of_radius_4() { return static_cast<int32_t>(offsetof(Twirl_t1381705816, ___radius_4)); }
	inline Vector2_t2243707579  get_radius_4() const { return ___radius_4; }
	inline Vector2_t2243707579 * get_address_of_radius_4() { return &___radius_4; }
	inline void set_radius_4(Vector2_t2243707579  value)
	{
		___radius_4 = value;
	}

	inline static int32_t get_offset_of_angle_5() { return static_cast<int32_t>(offsetof(Twirl_t1381705816, ___angle_5)); }
	inline float get_angle_5() const { return ___angle_5; }
	inline float* get_address_of_angle_5() { return &___angle_5; }
	inline void set_angle_5(float value)
	{
		___angle_5 = value;
	}

	inline static int32_t get_offset_of_center_6() { return static_cast<int32_t>(offsetof(Twirl_t1381705816, ___center_6)); }
	inline Vector2_t2243707579  get_center_6() const { return ___center_6; }
	inline Vector2_t2243707579 * get_address_of_center_6() { return &___center_6; }
	inline void set_center_6(Vector2_t2243707579  value)
	{
		___center_6 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // TWIRL_T1381705816_H
#ifndef VIGNETTEANDCHROMATICABERRATION_T3322560050_H
#define VIGNETTEANDCHROMATICABERRATION_T3322560050_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityStandardAssets.ImageEffects.VignetteAndChromaticAberration
struct  VignetteAndChromaticAberration_t3322560050  : public PostEffectsBase_t2152133263
{
public:
	// UnityStandardAssets.ImageEffects.VignetteAndChromaticAberration/AberrationMode UnityStandardAssets.ImageEffects.VignetteAndChromaticAberration::mode
	int32_t ___mode_6;
	// System.Single UnityStandardAssets.ImageEffects.VignetteAndChromaticAberration::intensity
	float ___intensity_7;
	// System.Single UnityStandardAssets.ImageEffects.VignetteAndChromaticAberration::chromaticAberration
	float ___chromaticAberration_8;
	// System.Single UnityStandardAssets.ImageEffects.VignetteAndChromaticAberration::axialAberration
	float ___axialAberration_9;
	// System.Single UnityStandardAssets.ImageEffects.VignetteAndChromaticAberration::blur
	float ___blur_10;
	// System.Single UnityStandardAssets.ImageEffects.VignetteAndChromaticAberration::blurSpread
	float ___blurSpread_11;
	// System.Single UnityStandardAssets.ImageEffects.VignetteAndChromaticAberration::luminanceDependency
	float ___luminanceDependency_12;
	// System.Single UnityStandardAssets.ImageEffects.VignetteAndChromaticAberration::blurDistance
	float ___blurDistance_13;
	// UnityEngine.Shader UnityStandardAssets.ImageEffects.VignetteAndChromaticAberration::vignetteShader
	Shader_t2430389951 * ___vignetteShader_14;
	// UnityEngine.Shader UnityStandardAssets.ImageEffects.VignetteAndChromaticAberration::separableBlurShader
	Shader_t2430389951 * ___separableBlurShader_15;
	// UnityEngine.Shader UnityStandardAssets.ImageEffects.VignetteAndChromaticAberration::chromAberrationShader
	Shader_t2430389951 * ___chromAberrationShader_16;
	// UnityEngine.Material UnityStandardAssets.ImageEffects.VignetteAndChromaticAberration::m_VignetteMaterial
	Material_t193706927 * ___m_VignetteMaterial_17;
	// UnityEngine.Material UnityStandardAssets.ImageEffects.VignetteAndChromaticAberration::m_SeparableBlurMaterial
	Material_t193706927 * ___m_SeparableBlurMaterial_18;
	// UnityEngine.Material UnityStandardAssets.ImageEffects.VignetteAndChromaticAberration::m_ChromAberrationMaterial
	Material_t193706927 * ___m_ChromAberrationMaterial_19;

public:
	inline static int32_t get_offset_of_mode_6() { return static_cast<int32_t>(offsetof(VignetteAndChromaticAberration_t3322560050, ___mode_6)); }
	inline int32_t get_mode_6() const { return ___mode_6; }
	inline int32_t* get_address_of_mode_6() { return &___mode_6; }
	inline void set_mode_6(int32_t value)
	{
		___mode_6 = value;
	}

	inline static int32_t get_offset_of_intensity_7() { return static_cast<int32_t>(offsetof(VignetteAndChromaticAberration_t3322560050, ___intensity_7)); }
	inline float get_intensity_7() const { return ___intensity_7; }
	inline float* get_address_of_intensity_7() { return &___intensity_7; }
	inline void set_intensity_7(float value)
	{
		___intensity_7 = value;
	}

	inline static int32_t get_offset_of_chromaticAberration_8() { return static_cast<int32_t>(offsetof(VignetteAndChromaticAberration_t3322560050, ___chromaticAberration_8)); }
	inline float get_chromaticAberration_8() const { return ___chromaticAberration_8; }
	inline float* get_address_of_chromaticAberration_8() { return &___chromaticAberration_8; }
	inline void set_chromaticAberration_8(float value)
	{
		___chromaticAberration_8 = value;
	}

	inline static int32_t get_offset_of_axialAberration_9() { return static_cast<int32_t>(offsetof(VignetteAndChromaticAberration_t3322560050, ___axialAberration_9)); }
	inline float get_axialAberration_9() const { return ___axialAberration_9; }
	inline float* get_address_of_axialAberration_9() { return &___axialAberration_9; }
	inline void set_axialAberration_9(float value)
	{
		___axialAberration_9 = value;
	}

	inline static int32_t get_offset_of_blur_10() { return static_cast<int32_t>(offsetof(VignetteAndChromaticAberration_t3322560050, ___blur_10)); }
	inline float get_blur_10() const { return ___blur_10; }
	inline float* get_address_of_blur_10() { return &___blur_10; }
	inline void set_blur_10(float value)
	{
		___blur_10 = value;
	}

	inline static int32_t get_offset_of_blurSpread_11() { return static_cast<int32_t>(offsetof(VignetteAndChromaticAberration_t3322560050, ___blurSpread_11)); }
	inline float get_blurSpread_11() const { return ___blurSpread_11; }
	inline float* get_address_of_blurSpread_11() { return &___blurSpread_11; }
	inline void set_blurSpread_11(float value)
	{
		___blurSpread_11 = value;
	}

	inline static int32_t get_offset_of_luminanceDependency_12() { return static_cast<int32_t>(offsetof(VignetteAndChromaticAberration_t3322560050, ___luminanceDependency_12)); }
	inline float get_luminanceDependency_12() const { return ___luminanceDependency_12; }
	inline float* get_address_of_luminanceDependency_12() { return &___luminanceDependency_12; }
	inline void set_luminanceDependency_12(float value)
	{
		___luminanceDependency_12 = value;
	}

	inline static int32_t get_offset_of_blurDistance_13() { return static_cast<int32_t>(offsetof(VignetteAndChromaticAberration_t3322560050, ___blurDistance_13)); }
	inline float get_blurDistance_13() const { return ___blurDistance_13; }
	inline float* get_address_of_blurDistance_13() { return &___blurDistance_13; }
	inline void set_blurDistance_13(float value)
	{
		___blurDistance_13 = value;
	}

	inline static int32_t get_offset_of_vignetteShader_14() { return static_cast<int32_t>(offsetof(VignetteAndChromaticAberration_t3322560050, ___vignetteShader_14)); }
	inline Shader_t2430389951 * get_vignetteShader_14() const { return ___vignetteShader_14; }
	inline Shader_t2430389951 ** get_address_of_vignetteShader_14() { return &___vignetteShader_14; }
	inline void set_vignetteShader_14(Shader_t2430389951 * value)
	{
		___vignetteShader_14 = value;
		Il2CppCodeGenWriteBarrier((&___vignetteShader_14), value);
	}

	inline static int32_t get_offset_of_separableBlurShader_15() { return static_cast<int32_t>(offsetof(VignetteAndChromaticAberration_t3322560050, ___separableBlurShader_15)); }
	inline Shader_t2430389951 * get_separableBlurShader_15() const { return ___separableBlurShader_15; }
	inline Shader_t2430389951 ** get_address_of_separableBlurShader_15() { return &___separableBlurShader_15; }
	inline void set_separableBlurShader_15(Shader_t2430389951 * value)
	{
		___separableBlurShader_15 = value;
		Il2CppCodeGenWriteBarrier((&___separableBlurShader_15), value);
	}

	inline static int32_t get_offset_of_chromAberrationShader_16() { return static_cast<int32_t>(offsetof(VignetteAndChromaticAberration_t3322560050, ___chromAberrationShader_16)); }
	inline Shader_t2430389951 * get_chromAberrationShader_16() const { return ___chromAberrationShader_16; }
	inline Shader_t2430389951 ** get_address_of_chromAberrationShader_16() { return &___chromAberrationShader_16; }
	inline void set_chromAberrationShader_16(Shader_t2430389951 * value)
	{
		___chromAberrationShader_16 = value;
		Il2CppCodeGenWriteBarrier((&___chromAberrationShader_16), value);
	}

	inline static int32_t get_offset_of_m_VignetteMaterial_17() { return static_cast<int32_t>(offsetof(VignetteAndChromaticAberration_t3322560050, ___m_VignetteMaterial_17)); }
	inline Material_t193706927 * get_m_VignetteMaterial_17() const { return ___m_VignetteMaterial_17; }
	inline Material_t193706927 ** get_address_of_m_VignetteMaterial_17() { return &___m_VignetteMaterial_17; }
	inline void set_m_VignetteMaterial_17(Material_t193706927 * value)
	{
		___m_VignetteMaterial_17 = value;
		Il2CppCodeGenWriteBarrier((&___m_VignetteMaterial_17), value);
	}

	inline static int32_t get_offset_of_m_SeparableBlurMaterial_18() { return static_cast<int32_t>(offsetof(VignetteAndChromaticAberration_t3322560050, ___m_SeparableBlurMaterial_18)); }
	inline Material_t193706927 * get_m_SeparableBlurMaterial_18() const { return ___m_SeparableBlurMaterial_18; }
	inline Material_t193706927 ** get_address_of_m_SeparableBlurMaterial_18() { return &___m_SeparableBlurMaterial_18; }
	inline void set_m_SeparableBlurMaterial_18(Material_t193706927 * value)
	{
		___m_SeparableBlurMaterial_18 = value;
		Il2CppCodeGenWriteBarrier((&___m_SeparableBlurMaterial_18), value);
	}

	inline static int32_t get_offset_of_m_ChromAberrationMaterial_19() { return static_cast<int32_t>(offsetof(VignetteAndChromaticAberration_t3322560050, ___m_ChromAberrationMaterial_19)); }
	inline Material_t193706927 * get_m_ChromAberrationMaterial_19() const { return ___m_ChromAberrationMaterial_19; }
	inline Material_t193706927 ** get_address_of_m_ChromAberrationMaterial_19() { return &___m_ChromAberrationMaterial_19; }
	inline void set_m_ChromAberrationMaterial_19(Material_t193706927 * value)
	{
		___m_ChromAberrationMaterial_19 = value;
		Il2CppCodeGenWriteBarrier((&___m_ChromAberrationMaterial_19), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // VIGNETTEANDCHROMATICABERRATION_T3322560050_H
#ifndef VORTEX_T4170634026_H
#define VORTEX_T4170634026_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityStandardAssets.ImageEffects.Vortex
struct  Vortex_t4170634026  : public ImageEffectBase_t517806655
{
public:
	// UnityEngine.Vector2 UnityStandardAssets.ImageEffects.Vortex::radius
	Vector2_t2243707579  ___radius_4;
	// System.Single UnityStandardAssets.ImageEffects.Vortex::angle
	float ___angle_5;
	// UnityEngine.Vector2 UnityStandardAssets.ImageEffects.Vortex::center
	Vector2_t2243707579  ___center_6;

public:
	inline static int32_t get_offset_of_radius_4() { return static_cast<int32_t>(offsetof(Vortex_t4170634026, ___radius_4)); }
	inline Vector2_t2243707579  get_radius_4() const { return ___radius_4; }
	inline Vector2_t2243707579 * get_address_of_radius_4() { return &___radius_4; }
	inline void set_radius_4(Vector2_t2243707579  value)
	{
		___radius_4 = value;
	}

	inline static int32_t get_offset_of_angle_5() { return static_cast<int32_t>(offsetof(Vortex_t4170634026, ___angle_5)); }
	inline float get_angle_5() const { return ___angle_5; }
	inline float* get_address_of_angle_5() { return &___angle_5; }
	inline void set_angle_5(float value)
	{
		___angle_5 = value;
	}

	inline static int32_t get_offset_of_center_6() { return static_cast<int32_t>(offsetof(Vortex_t4170634026, ___center_6)); }
	inline Vector2_t2243707579  get_center_6() const { return ___center_6; }
	inline Vector2_t2243707579 * get_address_of_center_6() { return &___center_6; }
	inline void set_center_6(Vector2_t2243707579  value)
	{
		___center_6 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // VORTEX_T4170634026_H
#ifndef TONEMAPPING_T1171761296_H
#define TONEMAPPING_T1171761296_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityStandardAssets.ImageEffects.Tonemapping
struct  Tonemapping_t1171761296  : public PostEffectsBase_t2152133263
{
public:
	// UnityStandardAssets.ImageEffects.Tonemapping/TonemapperType UnityStandardAssets.ImageEffects.Tonemapping::type
	int32_t ___type_6;
	// UnityStandardAssets.ImageEffects.Tonemapping/AdaptiveTexSize UnityStandardAssets.ImageEffects.Tonemapping::adaptiveTextureSize
	int32_t ___adaptiveTextureSize_7;
	// UnityEngine.AnimationCurve UnityStandardAssets.ImageEffects.Tonemapping::remapCurve
	AnimationCurve_t3306541151 * ___remapCurve_8;
	// UnityEngine.Texture2D UnityStandardAssets.ImageEffects.Tonemapping::curveTex
	Texture2D_t3542995729 * ___curveTex_9;
	// System.Single UnityStandardAssets.ImageEffects.Tonemapping::exposureAdjustment
	float ___exposureAdjustment_10;
	// System.Single UnityStandardAssets.ImageEffects.Tonemapping::middleGrey
	float ___middleGrey_11;
	// System.Single UnityStandardAssets.ImageEffects.Tonemapping::white
	float ___white_12;
	// System.Single UnityStandardAssets.ImageEffects.Tonemapping::adaptionSpeed
	float ___adaptionSpeed_13;
	// UnityEngine.Shader UnityStandardAssets.ImageEffects.Tonemapping::tonemapper
	Shader_t2430389951 * ___tonemapper_14;
	// System.Boolean UnityStandardAssets.ImageEffects.Tonemapping::validRenderTextureFormat
	bool ___validRenderTextureFormat_15;
	// UnityEngine.Material UnityStandardAssets.ImageEffects.Tonemapping::tonemapMaterial
	Material_t193706927 * ___tonemapMaterial_16;
	// UnityEngine.RenderTexture UnityStandardAssets.ImageEffects.Tonemapping::rt
	RenderTexture_t2666733923 * ___rt_17;
	// UnityEngine.RenderTextureFormat UnityStandardAssets.ImageEffects.Tonemapping::rtFormat
	int32_t ___rtFormat_18;

public:
	inline static int32_t get_offset_of_type_6() { return static_cast<int32_t>(offsetof(Tonemapping_t1171761296, ___type_6)); }
	inline int32_t get_type_6() const { return ___type_6; }
	inline int32_t* get_address_of_type_6() { return &___type_6; }
	inline void set_type_6(int32_t value)
	{
		___type_6 = value;
	}

	inline static int32_t get_offset_of_adaptiveTextureSize_7() { return static_cast<int32_t>(offsetof(Tonemapping_t1171761296, ___adaptiveTextureSize_7)); }
	inline int32_t get_adaptiveTextureSize_7() const { return ___adaptiveTextureSize_7; }
	inline int32_t* get_address_of_adaptiveTextureSize_7() { return &___adaptiveTextureSize_7; }
	inline void set_adaptiveTextureSize_7(int32_t value)
	{
		___adaptiveTextureSize_7 = value;
	}

	inline static int32_t get_offset_of_remapCurve_8() { return static_cast<int32_t>(offsetof(Tonemapping_t1171761296, ___remapCurve_8)); }
	inline AnimationCurve_t3306541151 * get_remapCurve_8() const { return ___remapCurve_8; }
	inline AnimationCurve_t3306541151 ** get_address_of_remapCurve_8() { return &___remapCurve_8; }
	inline void set_remapCurve_8(AnimationCurve_t3306541151 * value)
	{
		___remapCurve_8 = value;
		Il2CppCodeGenWriteBarrier((&___remapCurve_8), value);
	}

	inline static int32_t get_offset_of_curveTex_9() { return static_cast<int32_t>(offsetof(Tonemapping_t1171761296, ___curveTex_9)); }
	inline Texture2D_t3542995729 * get_curveTex_9() const { return ___curveTex_9; }
	inline Texture2D_t3542995729 ** get_address_of_curveTex_9() { return &___curveTex_9; }
	inline void set_curveTex_9(Texture2D_t3542995729 * value)
	{
		___curveTex_9 = value;
		Il2CppCodeGenWriteBarrier((&___curveTex_9), value);
	}

	inline static int32_t get_offset_of_exposureAdjustment_10() { return static_cast<int32_t>(offsetof(Tonemapping_t1171761296, ___exposureAdjustment_10)); }
	inline float get_exposureAdjustment_10() const { return ___exposureAdjustment_10; }
	inline float* get_address_of_exposureAdjustment_10() { return &___exposureAdjustment_10; }
	inline void set_exposureAdjustment_10(float value)
	{
		___exposureAdjustment_10 = value;
	}

	inline static int32_t get_offset_of_middleGrey_11() { return static_cast<int32_t>(offsetof(Tonemapping_t1171761296, ___middleGrey_11)); }
	inline float get_middleGrey_11() const { return ___middleGrey_11; }
	inline float* get_address_of_middleGrey_11() { return &___middleGrey_11; }
	inline void set_middleGrey_11(float value)
	{
		___middleGrey_11 = value;
	}

	inline static int32_t get_offset_of_white_12() { return static_cast<int32_t>(offsetof(Tonemapping_t1171761296, ___white_12)); }
	inline float get_white_12() const { return ___white_12; }
	inline float* get_address_of_white_12() { return &___white_12; }
	inline void set_white_12(float value)
	{
		___white_12 = value;
	}

	inline static int32_t get_offset_of_adaptionSpeed_13() { return static_cast<int32_t>(offsetof(Tonemapping_t1171761296, ___adaptionSpeed_13)); }
	inline float get_adaptionSpeed_13() const { return ___adaptionSpeed_13; }
	inline float* get_address_of_adaptionSpeed_13() { return &___adaptionSpeed_13; }
	inline void set_adaptionSpeed_13(float value)
	{
		___adaptionSpeed_13 = value;
	}

	inline static int32_t get_offset_of_tonemapper_14() { return static_cast<int32_t>(offsetof(Tonemapping_t1171761296, ___tonemapper_14)); }
	inline Shader_t2430389951 * get_tonemapper_14() const { return ___tonemapper_14; }
	inline Shader_t2430389951 ** get_address_of_tonemapper_14() { return &___tonemapper_14; }
	inline void set_tonemapper_14(Shader_t2430389951 * value)
	{
		___tonemapper_14 = value;
		Il2CppCodeGenWriteBarrier((&___tonemapper_14), value);
	}

	inline static int32_t get_offset_of_validRenderTextureFormat_15() { return static_cast<int32_t>(offsetof(Tonemapping_t1171761296, ___validRenderTextureFormat_15)); }
	inline bool get_validRenderTextureFormat_15() const { return ___validRenderTextureFormat_15; }
	inline bool* get_address_of_validRenderTextureFormat_15() { return &___validRenderTextureFormat_15; }
	inline void set_validRenderTextureFormat_15(bool value)
	{
		___validRenderTextureFormat_15 = value;
	}

	inline static int32_t get_offset_of_tonemapMaterial_16() { return static_cast<int32_t>(offsetof(Tonemapping_t1171761296, ___tonemapMaterial_16)); }
	inline Material_t193706927 * get_tonemapMaterial_16() const { return ___tonemapMaterial_16; }
	inline Material_t193706927 ** get_address_of_tonemapMaterial_16() { return &___tonemapMaterial_16; }
	inline void set_tonemapMaterial_16(Material_t193706927 * value)
	{
		___tonemapMaterial_16 = value;
		Il2CppCodeGenWriteBarrier((&___tonemapMaterial_16), value);
	}

	inline static int32_t get_offset_of_rt_17() { return static_cast<int32_t>(offsetof(Tonemapping_t1171761296, ___rt_17)); }
	inline RenderTexture_t2666733923 * get_rt_17() const { return ___rt_17; }
	inline RenderTexture_t2666733923 ** get_address_of_rt_17() { return &___rt_17; }
	inline void set_rt_17(RenderTexture_t2666733923 * value)
	{
		___rt_17 = value;
		Il2CppCodeGenWriteBarrier((&___rt_17), value);
	}

	inline static int32_t get_offset_of_rtFormat_18() { return static_cast<int32_t>(offsetof(Tonemapping_t1171761296, ___rtFormat_18)); }
	inline int32_t get_rtFormat_18() const { return ___rtFormat_18; }
	inline int32_t* get_address_of_rtFormat_18() { return &___rtFormat_18; }
	inline void set_rtFormat_18(int32_t value)
	{
		___rtFormat_18 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // TONEMAPPING_T1171761296_H





#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize1900 = { sizeof (Tonemapping_t1171761296), -1, 0, 0 };
extern const int32_t g_FieldOffsetTable1900[13] = 
{
	Tonemapping_t1171761296::get_offset_of_type_6(),
	Tonemapping_t1171761296::get_offset_of_adaptiveTextureSize_7(),
	Tonemapping_t1171761296::get_offset_of_remapCurve_8(),
	Tonemapping_t1171761296::get_offset_of_curveTex_9(),
	Tonemapping_t1171761296::get_offset_of_exposureAdjustment_10(),
	Tonemapping_t1171761296::get_offset_of_middleGrey_11(),
	Tonemapping_t1171761296::get_offset_of_white_12(),
	Tonemapping_t1171761296::get_offset_of_adaptionSpeed_13(),
	Tonemapping_t1171761296::get_offset_of_tonemapper_14(),
	Tonemapping_t1171761296::get_offset_of_validRenderTextureFormat_15(),
	Tonemapping_t1171761296::get_offset_of_tonemapMaterial_16(),
	Tonemapping_t1171761296::get_offset_of_rt_17(),
	Tonemapping_t1171761296::get_offset_of_rtFormat_18(),
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize1901 = { sizeof (TonemapperType_t3310062628)+ sizeof (RuntimeObject), sizeof(int32_t), 0, 0 };
extern const int32_t g_FieldOffsetTable1901[8] = 
{
	TonemapperType_t3310062628::get_offset_of_value___1() + static_cast<int32_t>(sizeof(RuntimeObject)),
	0,
	0,
	0,
	0,
	0,
	0,
	0,
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize1902 = { sizeof (AdaptiveTexSize_t1008153775)+ sizeof (RuntimeObject), sizeof(int32_t), 0, 0 };
extern const int32_t g_FieldOffsetTable1902[8] = 
{
	AdaptiveTexSize_t1008153775::get_offset_of_value___1() + static_cast<int32_t>(sizeof(RuntimeObject)),
	0,
	0,
	0,
	0,
	0,
	0,
	0,
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize1903 = { sizeof (Triangles_t1046072227), -1, sizeof(Triangles_t1046072227_StaticFields), 0 };
extern const int32_t g_FieldOffsetTable1903[2] = 
{
	Triangles_t1046072227_StaticFields::get_offset_of_meshes_0(),
	Triangles_t1046072227_StaticFields::get_offset_of_currentTris_1(),
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize1904 = { sizeof (Twirl_t1381705816), -1, 0, 0 };
extern const int32_t g_FieldOffsetTable1904[3] = 
{
	Twirl_t1381705816::get_offset_of_radius_4(),
	Twirl_t1381705816::get_offset_of_angle_5(),
	Twirl_t1381705816::get_offset_of_center_6(),
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize1905 = { sizeof (VignetteAndChromaticAberration_t3322560050), -1, 0, 0 };
extern const int32_t g_FieldOffsetTable1905[14] = 
{
	VignetteAndChromaticAberration_t3322560050::get_offset_of_mode_6(),
	VignetteAndChromaticAberration_t3322560050::get_offset_of_intensity_7(),
	VignetteAndChromaticAberration_t3322560050::get_offset_of_chromaticAberration_8(),
	VignetteAndChromaticAberration_t3322560050::get_offset_of_axialAberration_9(),
	VignetteAndChromaticAberration_t3322560050::get_offset_of_blur_10(),
	VignetteAndChromaticAberration_t3322560050::get_offset_of_blurSpread_11(),
	VignetteAndChromaticAberration_t3322560050::get_offset_of_luminanceDependency_12(),
	VignetteAndChromaticAberration_t3322560050::get_offset_of_blurDistance_13(),
	VignetteAndChromaticAberration_t3322560050::get_offset_of_vignetteShader_14(),
	VignetteAndChromaticAberration_t3322560050::get_offset_of_separableBlurShader_15(),
	VignetteAndChromaticAberration_t3322560050::get_offset_of_chromAberrationShader_16(),
	VignetteAndChromaticAberration_t3322560050::get_offset_of_m_VignetteMaterial_17(),
	VignetteAndChromaticAberration_t3322560050::get_offset_of_m_SeparableBlurMaterial_18(),
	VignetteAndChromaticAberration_t3322560050::get_offset_of_m_ChromAberrationMaterial_19(),
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize1906 = { sizeof (AberrationMode_t3949418959)+ sizeof (RuntimeObject), sizeof(int32_t), 0, 0 };
extern const int32_t g_FieldOffsetTable1906[3] = 
{
	AberrationMode_t3949418959::get_offset_of_value___1() + static_cast<int32_t>(sizeof(RuntimeObject)),
	0,
	0,
};
extern const Il2CppTypeDefinitionSizes g_typeDefinitionSize1907 = { sizeof (Vortex_t4170634026), -1, 0, 0 };
extern const int32_t g_FieldOffsetTable1907[3] = 
{
	Vortex_t4170634026::get_offset_of_radius_4(),
	Vortex_t4170634026::get_offset_of_angle_5(),
	Vortex_t4170634026::get_offset_of_center_6(),
};
#ifdef __clang__
#pragma clang diagnostic pop
#endif
