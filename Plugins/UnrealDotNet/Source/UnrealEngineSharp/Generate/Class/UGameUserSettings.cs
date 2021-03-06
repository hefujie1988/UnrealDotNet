// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\GameUserSettings.h:38

namespace UnrealEngine
{
	public partial class UGameUserSettings : UObject
	{
		public UGameUserSettings(IntPtr adress)
			: base(adress)
		{
		}

		public UGameUserSettings(UObject Parent = null, string Name = "GameUserSettings")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UGameUserSettings(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_UGameUserSettings_bUseDynamicResolution_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UGameUserSettings_bUseDynamicResolution_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_UGameUserSettings_bUseVSync_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UGameUserSettings_bUseVSync_SET(IntPtr Ptr, bool Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UGameUserSettings(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameUserSettings_ApplyHardwareBenchmarkResults(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameUserSettings_ApplyNonResolutionSettings(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameUserSettings_ApplyResolutionSettings(IntPtr self, bool bCheckForCommandLineOverrides);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameUserSettings_ApplySettings(IntPtr self, bool bCheckForCommandLineOverrides);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameUserSettings_ConfirmVideoMode(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameUserSettings_EnableHDRDisplayOutput(IntPtr self, bool bEnable, int displayNits);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UGameUserSettings_FindResolutionQualityForScreenSize(IntPtr self, float width, float height);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UGameUserSettings_GetAntiAliasingQuality(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UGameUserSettings_GetAudioQualityLevel(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UGameUserSettings_GetCurrentHDRDisplayNits(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UGameUserSettings_GetDefaultResolution(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UGameUserSettings_GetDefaultResolutionScale(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UGameUserSettings_GetDefaultWindowPosition(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UGameUserSettings_GetDesktopResolution(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UGameUserSettings_GetEffectiveFrameRateLimit(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UGameUserSettings_GetFoliageQuality(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UGameUserSettings_GetFrameRateLimit(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UGameUserSettings_GetGameUserSettings(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UGameUserSettings_GetLastConfirmedScreenResolution(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UGameUserSettings_GetLastCPUBenchmarkResult(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UGameUserSettings_GetLastGPUBenchmarkResult(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UGameUserSettings_GetOverallScalabilityLevel(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UGameUserSettings_GetPostProcessingQuality(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UGameUserSettings_GetRecommendedResolutionScale(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameUserSettings_GetResolutionScaleInformation(IntPtr self, float currentScaleNormalized, int currentScaleValue, int minScaleValue, int maxScaleValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameUserSettings_GetResolutionScaleInformationEx(IntPtr self, float currentScaleNormalized, float currentScaleValue, float minScaleValue, float maxScaleValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UGameUserSettings_GetScreenResolution(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UGameUserSettings_GetShadowQuality(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UGameUserSettings_GetSyncInterval(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UGameUserSettings_GetTextureQuality(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UGameUserSettings_GetViewDistanceQuality(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UGameUserSettings_GetVisualEffectQuality(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UGameUserSettings_GetWindowPosition(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UGameUserSettings_IsDirty(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UGameUserSettings_IsDynamicResolutionDirty(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UGameUserSettings_IsDynamicResolutionEnabled(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UGameUserSettings_IsFullscreenModeDirty(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UGameUserSettings_IsHDREnabled(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UGameUserSettings_IsScreenResolutionDirty(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UGameUserSettings_IsVersionValid(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UGameUserSettings_IsVSyncDirty(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UGameUserSettings_IsVSyncEnabled(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameUserSettings_LoadConfigIni(IntPtr self, bool bForceReload);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameUserSettings_LoadSettings(IntPtr self, bool bForceReload);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameUserSettings_PreloadResolutionSettings(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameUserSettings_RequestUIUpdate(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameUserSettings_ResetToCurrentSettings(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameUserSettings_RevertVideoMode(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameUserSettings_RunHardwareBenchmark(IntPtr self, int workScale, float cPUMultiplier, float gPUMultiplier);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameUserSettings_SaveSettings(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameUserSettings_SetAntiAliasingQuality(IntPtr self, int value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameUserSettings_SetAudioQualityLevel(IntPtr self, int qualityLevel);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameUserSettings_SetBenchmarkFallbackValues(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameUserSettings_SetDynamicResolutionEnabled(IntPtr self, bool bEnable);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameUserSettings_SetFoliageQuality(IntPtr self, int value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameUserSettings_SetFrameRateLimit(IntPtr self, float newLimit);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameUserSettings_SetFrameRateLimitCVar(IntPtr self, float inLimit);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameUserSettings_SetOverallScalabilityLevel(IntPtr self, int value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameUserSettings_SetPostProcessingQuality(IntPtr self, int value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameUserSettings_SetResolutionScaleNormalized(IntPtr self, float newScaleNormalized);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameUserSettings_SetResolutionScaleValue(IntPtr self, int newScaleValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameUserSettings_SetResolutionScaleValueEx(IntPtr self, float newScaleValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameUserSettings_SetScreenResolution(IntPtr self, IntPtr resolution);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameUserSettings_SetShadowQuality(IntPtr self, int value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameUserSettings_SetSyncIntervalCVar(IntPtr self, int inInterval);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameUserSettings_SetSyncTypeCVar(IntPtr self, int inInterval);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameUserSettings_SetTextureQuality(IntPtr self, int value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameUserSettings_SetToDefaults(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameUserSettings_SetViewDistanceQuality(IntPtr self, int value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameUserSettings_SetVisualEffectQuality(IntPtr self, int value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameUserSettings_SetVSyncEnabled(IntPtr self, bool bEnable);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameUserSettings_SetWindowPosition(IntPtr self, int windowPosX, int windowPosY);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UGameUserSettings_SupportsHDRDisplayOutput(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameUserSettings_UpdateResolutionQuality(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameUserSettings_UpdateVersion(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UGameUserSettings_ValidateSettings(IntPtr self);
		
		#endregion
		
		#region Property
		public bool bUseDynamicResolution
		{
			get => E_PROP_UGameUserSettings_bUseDynamicResolution_GET(NativePointer);
			set => E_PROP_UGameUserSettings_bUseDynamicResolution_SET(NativePointer, value);
		}

		public bool bUseVSync
		{
			get => E_PROP_UGameUserSettings_bUseVSync_GET(NativePointer);
			set => E_PROP_UGameUserSettings_bUseVSync_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Applies the settings stored in ScalabilityQuality and saves settings
		/// </summary>
		public virtual void ApplyHardwareBenchmarkResults()
			=> E_UGameUserSettings_ApplyHardwareBenchmarkResults(this);
		
		public virtual void ApplyNonResolutionSettings()
			=> E_UGameUserSettings_ApplyNonResolutionSettings(this);
		
		public void ApplyResolutionSettings(bool bCheckForCommandLineOverrides)
			=> E_UGameUserSettings_ApplyResolutionSettings(this, bCheckForCommandLineOverrides);
		
		
		/// <summary>
		/// Applies all current user settings to the game and saves to permanent storage (e.g. file), optionally checking for command line overrides.
		/// </summary>
		public virtual void ApplySettings(bool bCheckForCommandLineOverrides)
			=> E_UGameUserSettings_ApplySettings(this, bCheckForCommandLineOverrides);
		
		
		/// <summary>
		/// Mark current video mode settings (fullscreenmode/resolution) as being confirmed by the user
		/// </summary>
		public virtual void ConfirmVideoMode()
			=> E_UGameUserSettings_ConfirmVideoMode(this);
		
		
		/// <summary>
		/// Enables or disables HDR display output. Can be called again to change the desired nit level
		/// </summary>
		public void EnableHDRDisplayOutput(bool bEnable, int displayNits = 1000)
			=> E_UGameUserSettings_EnableHDRDisplayOutput(this, bEnable, displayNits);
		
		
		/// <summary>
		/// Picks the best resolution quality for a given screen size
		/// </summary>
		protected float FindResolutionQualityForScreenSize(float width, float height)
			=> E_UGameUserSettings_FindResolutionQualityForScreenSize(this, width, height);
		
		public int GetAntiAliasingQuality()
			=> E_UGameUserSettings_GetAntiAliasingQuality(this);
		
		
		/// <summary>
		/// Returns the user's audio quality level setting
		/// </summary>
		public int GetAudioQualityLevel()
			=> E_UGameUserSettings_GetAudioQualityLevel(this);
		
		
		/// <summary>
		/// Returns 0 if HDR isn't supported or is turned off
		/// </summary>
		public int GetCurrentHDRDisplayNits()
			=> E_UGameUserSettings_GetCurrentHDRDisplayNits(this);
		
		
		/// <summary>
		/// Returns the default resolution when no resolution is set
		/// </summary>
		public FIntPoint GetDefaultResolution()
			=> E_UGameUserSettings_GetDefaultResolution(this);
		
		
		/// <summary>
		/// Gets the desired resolution quality based on DesiredScreenWidth/Height and the current screen resolution
		/// </summary>
		public virtual float GetDefaultResolutionScale()
			=> E_UGameUserSettings_GetDefaultResolutionScale(this);
		
		
		/// <summary>
		/// Returns the default window position when no position is set
		/// </summary>
		public FIntPoint GetDefaultWindowPosition()
			=> E_UGameUserSettings_GetDefaultWindowPosition(this);
		
		
		/// <summary>
		/// Returns user's desktop resolution, in pixels.
		/// </summary>
		public FIntPoint GetDesktopResolution()
			=> E_UGameUserSettings_GetDesktopResolution(this);
		
		
		/// <summary>
		/// Returns the effective frame rate limit (by default it returns the FrameRateLimit member)
		/// </summary>
		protected virtual float GetEffectiveFrameRateLimit()
			=> E_UGameUserSettings_GetEffectiveFrameRateLimit(this);
		
		public int GetFoliageQuality()
			=> E_UGameUserSettings_GetFoliageQuality(this);
		
		
		/// <summary>
		/// Gets the user's frame rate limit (0 indiciates the frame rate limit is disabled)
		/// </summary>
		public float GetFrameRateLimit()
			=> E_UGameUserSettings_GetFrameRateLimit(this);
		
		
		/// <summary>
		/// Returns the game local machine settings (resolution, windowing mode, scalability settings, etc...)
		/// </summary>
		public UGameUserSettings GetGameUserSettings()
			=> E_UGameUserSettings_GetGameUserSettings(this);
		
		
		/// <summary>
		/// Returns the last confirmed user setting for game screen resolution, in pixels.
		/// </summary>
		public FIntPoint GetLastConfirmedScreenResolution()
			=> E_UGameUserSettings_GetLastConfirmedScreenResolution(this);
		
		
		/// <summary>
		/// Returns the last CPU benchmark result (set by RunHardwareBenchmark)
		/// </summary>
		public float GetLastCPUBenchmarkResult()
			=> E_UGameUserSettings_GetLastCPUBenchmarkResult(this);
		
		
		/// <summary>
		/// Returns the last GPU benchmark result (set by RunHardwareBenchmark)
		/// </summary>
		public float GetLastGPUBenchmarkResult()
			=> E_UGameUserSettings_GetLastGPUBenchmarkResult(this);
		
		public virtual int GetOverallScalabilityLevel()
			=> E_UGameUserSettings_GetOverallScalabilityLevel(this);
		
		public int GetPostProcessingQuality()
			=> E_UGameUserSettings_GetPostProcessingQuality(this);
		
		
		/// <summary>
		/// Gets the recommended resolution quality based on LastRecommendedScreenWidth/Height and the current screen resolution
		/// </summary>
		public virtual float GetRecommendedResolutionScale()
			=> E_UGameUserSettings_GetRecommendedResolutionScale(this);
		
		public void GetResolutionScaleInformation_Deprecated(float currentScaleNormalized, int currentScaleValue, int minScaleValue, int maxScaleValue)
			=> E_UGameUserSettings_GetResolutionScaleInformation(this, currentScaleNormalized, currentScaleValue, minScaleValue, maxScaleValue);
		
		public void GetResolutionScaleInformation(float currentScaleNormalized, float currentScaleValue, float minScaleValue, float maxScaleValue)
			=> E_UGameUserSettings_GetResolutionScaleInformationEx(this, currentScaleNormalized, currentScaleValue, minScaleValue, maxScaleValue);
		
		
		/// <summary>
		/// Returns the user setting for game screen resolution, in pixels.
		/// </summary>
		public FIntPoint GetScreenResolution()
			=> E_UGameUserSettings_GetScreenResolution(this);
		
		public int GetShadowQuality()
			=> E_UGameUserSettings_GetShadowQuality(this);
		
		
		/// <summary>
		/// Gets the current vsync interval setting
		/// </summary>
		public int GetSyncInterval()
			=> E_UGameUserSettings_GetSyncInterval(this);
		
		public int GetTextureQuality()
			=> E_UGameUserSettings_GetTextureQuality(this);
		
		public int GetViewDistanceQuality()
			=> E_UGameUserSettings_GetViewDistanceQuality(this);
		
		public int GetVisualEffectQuality()
			=> E_UGameUserSettings_GetVisualEffectQuality(this);
		
		public virtual FIntPoint GetWindowPosition()
			=> E_UGameUserSettings_GetWindowPosition(this);
		
		
		/// <summary>
		/// Checks if any user settings is different from current
		/// </summary>
		public virtual bool IsDirty()
			=> E_UGameUserSettings_IsDirty(this);
		
		
		/// <summary>
		/// Checks if the dynamic resolution user setting is different from current system setting
		/// </summary>
		public bool IsDynamicResolutionDirty()
			=> E_UGameUserSettings_IsDynamicResolutionDirty(this);
		
		
		/// <summary>
		/// Returns the user setting for dynamic resolution.
		/// </summary>
		public bool IsDynamicResolutionEnabled()
			=> E_UGameUserSettings_IsDynamicResolutionEnabled(this);
		
		
		/// <summary>
		/// Checks if the FullscreenMode user setting is different from current
		/// </summary>
		public bool IsFullscreenModeDirty()
			=> E_UGameUserSettings_IsFullscreenModeDirty(this);
		
		public bool IsHDREnabled()
			=> E_UGameUserSettings_IsHDREnabled(this);
		
		
		/// <summary>
		/// Checks if the Screen Resolution user setting is different from current
		/// </summary>
		public bool IsScreenResolutionDirty()
			=> E_UGameUserSettings_IsScreenResolutionDirty(this);
		
		
		/// <summary>
		/// Check if the current version of the game user settings is valid. Sub-classes can override this to provide game-specific versioning as necessary.
		/// </summary>
		/// <return>True</return>
		protected virtual bool IsVersionValid()
			=> E_UGameUserSettings_IsVersionValid(this);
		
		
		/// <summary>
		/// Checks if the vsync user setting is different from current system setting
		/// </summary>
		public bool IsVSyncDirty()
			=> E_UGameUserSettings_IsVSyncDirty(this);
		
		
		/// <summary>
		/// Returns the user setting for vsync.
		/// </summary>
		public bool IsVSyncEnabled()
			=> E_UGameUserSettings_IsVSyncEnabled(this);
		
		
		/// <summary>
		/// Loads the user .ini settings into GConfig
		/// </summary>
		public void LoadConfigIni(bool bForceReload = false)
			=> E_UGameUserSettings_LoadConfigIni(this, bForceReload);
		
		
		/// <summary>
		/// Loads the user settings from persistent storage
		/// </summary>
		public virtual void LoadSettings(bool bForceReload)
			=> E_UGameUserSettings_LoadSettings(this, bForceReload);
		
		
		/// <summary>
		/// Loads the resolution settings before is object is available
		/// </summary>
		public void PreloadResolutionSettings()
			=> E_UGameUserSettings_PreloadResolutionSettings(this);
		
		public void RequestUIUpdate()
			=> E_UGameUserSettings_RequestUIUpdate(this);
		
		
		/// <summary>
		/// This function resets all settings to the current system settings
		/// </summary>
		public virtual void ResetToCurrentSettings()
			=> E_UGameUserSettings_ResetToCurrentSettings(this);
		
		
		/// <summary>
		/// Revert video mode (fullscreenmode/resolution) back to the last user confirmed values
		/// </summary>
		public void RevertVideoMode()
			=> E_UGameUserSettings_RevertVideoMode(this);
		
		
		/// <summary>
		/// Runs the hardware benchmark and populates ScalabilityQuality as well as the last benchmark results config members, but does not apply the settings it determines. Designed to be called in conjunction with ApplyHardwareBenchmarkResults
		/// </summary>
		public virtual void RunHardwareBenchmark(int workScale, float cPUMultiplier, float gPUMultiplier)
			=> E_UGameUserSettings_RunHardwareBenchmark(this, workScale, cPUMultiplier, gPUMultiplier);
		
		
		/// <summary>
		/// Save the user settings to persistent storage (automatically happens as part of ApplySettings)
		/// </summary>
		public virtual void SaveSettings()
			=> E_UGameUserSettings_SaveSettings(this);
		
		public void SetAntiAliasingQuality(int value)
			=> E_UGameUserSettings_SetAntiAliasingQuality(this, value);
		
		
		/// <summary>
		/// Sets the user's audio quality level setting
		/// </summary>
		public void SetAudioQualityLevel(int qualityLevel)
			=> E_UGameUserSettings_SetAudioQualityLevel(this, qualityLevel);
		
		
		/// <summary>
		/// Set scalability settings to sensible fallback values, for use when the benchmark fails or potentially causes a crash
		/// </summary>
		public void SetBenchmarkFallbackValues()
			=> E_UGameUserSettings_SetBenchmarkFallbackValues(this);
		
		
		/// <summary>
		/// Sets the user setting for dynamic resolution. See UGameUserSettings::bUseDynamicResolution.
		/// </summary>
		public void SetDynamicResolutionEnabled(bool bEnable)
			=> E_UGameUserSettings_SetDynamicResolutionEnabled(this, bEnable);
		
		public void SetFoliageQuality(int value)
			=> E_UGameUserSettings_SetFoliageQuality(this, value);
		
		
		/// <summary>
		/// Sets the user's frame rate limit (0 will disable frame rate limiting)
		/// </summary>
		public void SetFrameRateLimit(float newLimit)
			=> E_UGameUserSettings_SetFrameRateLimit(this, newLimit);
		
		
		/// <summary>
		/// Sets the frame rate limit CVar to the passed in value, 0.0 indicates no limit
		/// </summary>
		protected void SetFrameRateLimitCVar(float inLimit)
			=> E_UGameUserSettings_SetFrameRateLimitCVar(this, inLimit);
		
		public virtual void SetOverallScalabilityLevel(int value)
			=> E_UGameUserSettings_SetOverallScalabilityLevel(this, value);
		
		public void SetPostProcessingQuality(int value)
			=> E_UGameUserSettings_SetPostProcessingQuality(this, value);
		
		public void SetResolutionScaleNormalized(float newScaleNormalized)
			=> E_UGameUserSettings_SetResolutionScaleNormalized(this, newScaleNormalized);
		
		public void SetResolutionScaleValue_Deprecated(int newScaleValue)
			=> E_UGameUserSettings_SetResolutionScaleValue(this, newScaleValue);
		
		public void SetResolutionScaleValue(float newScaleValue)
			=> E_UGameUserSettings_SetResolutionScaleValueEx(this, newScaleValue);
		
		
		/// <summary>
		/// Sets the user setting for game screen resolution, in pixels.
		/// </summary>
		public void SetScreenResolution(FIntPoint resolution)
			=> E_UGameUserSettings_SetScreenResolution(this, resolution);
		
		public void SetShadowQuality(int value)
			=> E_UGameUserSettings_SetShadowQuality(this, value);
		
		
		/// <summary>
		/// Sets the sync interval limit CVar forc consoles 0-3
		/// </summary>
		protected void SetSyncIntervalCVar(int inInterval)
			=> E_UGameUserSettings_SetSyncIntervalCVar(this, inInterval);
		
		
		/// <summary>
		/// Sets the input latency mode 0 and 2
		/// </summary>
		protected void SetSyncTypeCVar(int inInterval)
			=> E_UGameUserSettings_SetSyncTypeCVar(this, inInterval);
		
		public void SetTextureQuality(int value)
			=> E_UGameUserSettings_SetTextureQuality(this, value);
		
		public virtual void SetToDefaults()
			=> E_UGameUserSettings_SetToDefaults(this);
		
		public void SetViewDistanceQuality(int value)
			=> E_UGameUserSettings_SetViewDistanceQuality(this, value);
		
		public void SetVisualEffectQuality(int value)
			=> E_UGameUserSettings_SetVisualEffectQuality(this, value);
		
		
		/// <summary>
		/// Sets the user setting for vsync. See UGameUserSettings::bUseVSync.
		/// </summary>
		public void SetVSyncEnabled(bool bEnable)
			=> E_UGameUserSettings_SetVSyncEnabled(this, bEnable);
		
		public virtual void SetWindowPosition(int windowPosX, int windowPosY)
			=> E_UGameUserSettings_SetWindowPosition(this, windowPosX, windowPosY);
		
		
		/// <summary>
		/// Whether the curently running system supports HDR display output
		/// </summary>
		public virtual bool SupportsHDRDisplayOutput()
			=> E_UGameUserSettings_SupportsHDRDisplayOutput(this);
		
		protected void UpdateResolutionQuality()
			=> E_UGameUserSettings_UpdateResolutionQuality(this);
		
		
		/// <summary>
		/// Update the version of the game user settings to the current version
		/// </summary>
		protected virtual void UpdateVersion()
			=> E_UGameUserSettings_UpdateVersion(this);
		
		
		/// <summary>
		/// Validates and resets bad user settings to default. Deletes stale user settings file if necessary.
		/// </summary>
		public virtual void ValidateSettings()
			=> E_UGameUserSettings_ValidateSettings(this);
		
		#endregion
		
		public static implicit operator IntPtr(UGameUserSettings self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UGameUserSettings(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UGameUserSettings>(PtrDesc);
		}}}
