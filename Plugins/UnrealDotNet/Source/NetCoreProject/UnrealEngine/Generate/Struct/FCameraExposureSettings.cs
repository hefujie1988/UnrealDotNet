using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public partial class FCameraExposureSettings
	{
		private readonly IntPtr NativePointer;
		private readonly bool IsRef;
		
		public FCameraExposureSettings()
		{
			NativePointer = E_CreateStruct_FCameraExposureSettings();
			IsRef = false;
		}

		internal FCameraExposureSettings(IntPtr NativePointer, bool IsRef)
		{
			this.NativePointer = NativePointer;
			this.IsRef = IsRef;
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FCameraExposureSettings();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_DeleteStruct(IntPtr Adress);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_FCameraExposureSettings_LowPercent_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FCameraExposureSettings_LowPercent_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_FCameraExposureSettings_HighPercent_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FCameraExposureSettings_HighPercent_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_FCameraExposureSettings_MinBrightness_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FCameraExposureSettings_MinBrightness_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_FCameraExposureSettings_MaxBrightness_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FCameraExposureSettings_MaxBrightness_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_FCameraExposureSettings_SpeedUp_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FCameraExposureSettings_SpeedUp_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_FCameraExposureSettings_SpeedDown_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FCameraExposureSettings_SpeedDown_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_FCameraExposureSettings_Bias_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FCameraExposureSettings_Bias_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_FCameraExposureSettings_HistogramLogMin_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FCameraExposureSettings_HistogramLogMin_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_FCameraExposureSettings_HistogramLogMax_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FCameraExposureSettings_HistogramLogMax_SET(IntPtr Ptr, float Value);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// The eye adaptation will adapt to a value extracted from the luminance histogram of the scene color.
		/// The value is defined as having x percent below this brightness. Higher values give bright spots on the screen more priority
		/// but can lead to less stable results. Lower values give the medium and darker values more priority but might cause burn out of
		/// bright spots.
		/// >0, <100, good values are in the range 70 .. 80
		/// </summary>
		public float LowPercent
		{
			get => E_PROP_FCameraExposureSettings_LowPercent_GET(NativePointer);
			set => E_PROP_FCameraExposureSettings_LowPercent_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The eye adaptation will adapt to a value extracted from the luminance histogram of the scene color.
		/// The value is defined as having x percent below this brightness. Higher values give bright spots on the screen more priority
		/// but can lead to less stable results. Lower values give the medium and darker values more priority but might cause burn out of
		/// bright spots.
		/// >0, <100, good values are in the range 80 .. 95
		/// </summary>
		public float HighPercent
		{
			get => E_PROP_FCameraExposureSettings_HighPercent_GET(NativePointer);
			set => E_PROP_FCameraExposureSettings_HighPercent_SET(NativePointer, value);
		}

		
		/// <summary>
		/// A good value should be positive near 0. This is the minimum brightness the auto exposure can adapt to.
		/// It should be tweaked in a dark lighting situation (too small: image appears too bright, too large: image appears too dark).
		/// Note: Tweaking emissive materials and lights or tweaking auto exposure can look the same. Tweaking auto exposure has global
		/// effect and defined the HDR range - you don't want to change that late in the project development.
		/// Eye Adaptation is disabled if MinBrightness = MaxBrightness
		/// </summary>
		public float MinBrightness
		{
			get => E_PROP_FCameraExposureSettings_MinBrightness_GET(NativePointer);
			set => E_PROP_FCameraExposureSettings_MinBrightness_SET(NativePointer, value);
		}

		
		/// <summary>
		/// A good value should be positive (2 is a good value). This is the maximum brightness the auto exposure can adapt to.
		/// It should be tweaked in a bright lighting situation (too small: image appears too bright, too large: image appears too dark).
		/// Note: Tweaking emissive materials and lights or tweaking auto exposure can look the same. Tweaking auto exposure has global
		/// effect and defined the HDR range - you don't want to change that late in the project development.
		/// Eye Adaptation is disabled if MinBrightness = MaxBrightness
		/// </summary>
		public float MaxBrightness
		{
			get => E_PROP_FCameraExposureSettings_MaxBrightness_GET(NativePointer);
			set => E_PROP_FCameraExposureSettings_MaxBrightness_SET(NativePointer, value);
		}

		
		/// <summary>
		/// >0
		/// </summary>
		public float SpeedUp
		{
			get => E_PROP_FCameraExposureSettings_SpeedUp_GET(NativePointer);
			set => E_PROP_FCameraExposureSettings_SpeedUp_SET(NativePointer, value);
		}

		
		/// <summary>
		/// >0
		/// </summary>
		public float SpeedDown
		{
			get => E_PROP_FCameraExposureSettings_SpeedDown_GET(NativePointer);
			set => E_PROP_FCameraExposureSettings_SpeedDown_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Logarithmic adjustment for the exposure. Only used if a tonemapper is specified.
		/// 0: no adjustment, -1:2x darker, -2:4x darker, 1:2x brighter, 2:4x brighter, ...
		/// </summary>
		public float ExposureBias
		{
			get => E_PROP_FCameraExposureSettings_Bias_GET(NativePointer);
			set => E_PROP_FCameraExposureSettings_Bias_SET(NativePointer, value);
		}

		
		/// <summary>
		/// temporary exposed until we found good values, -8: 1/256, -10: 1/1024
		/// </summary>
		public float HistogramLogMin
		{
			get => E_PROP_FCameraExposureSettings_HistogramLogMin_GET(NativePointer);
			set => E_PROP_FCameraExposureSettings_HistogramLogMin_SET(NativePointer, value);
		}

		
		/// <summary>
		/// temporary exposed until we found good values 4: 16, 8: 256
		/// </summary>
		public float HistogramLogMax
		{
			get => E_PROP_FCameraExposureSettings_HistogramLogMax_GET(NativePointer);
			set => E_PROP_FCameraExposureSettings_HistogramLogMax_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FCameraExposureSettings Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FCameraExposureSettings(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FCameraExposureSettings(Adress, false);
		}