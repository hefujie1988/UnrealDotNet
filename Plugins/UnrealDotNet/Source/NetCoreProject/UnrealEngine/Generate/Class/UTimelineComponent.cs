using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Класс не может быть наследован в Вашем коде, используйте ManageTimelineComponent
	/// <para>TimelineComponent holds a series of events, floats, vectors or colors with associated keyframes. </para>
	/// <para>Events can be triggered at keyframes along the timeline. </para>
	/// <para>Floats, vectors, and colors are interpolated between keyframes along the timeline. </para>
	/// </summary>
	public  partial class UTimelineComponent : UActorComponent
	{
		public UTimelineComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_UTimelineComponent_GetIgnoreTimeDilation(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_UTimelineComponent_GetPlaybackPosition(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_UTimelineComponent_GetPlayRate(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_UTimelineComponent_GetTimelineLength(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_UTimelineComponent_IsLooping(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_UTimelineComponent_IsPlaying(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_UTimelineComponent_IsReversing(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UTimelineComponent_Play(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UTimelineComponent_PlayFromStart(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UTimelineComponent_Reverse(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UTimelineComponent_ReverseFromEnd(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UTimelineComponent_SetDirectionPropertyName(IntPtr Self, string DirectionPropertyName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UTimelineComponent_SetIgnoreTimeDilation(IntPtr Self, bool bNewIgnoreTimeDilation);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UTimelineComponent_SetLooping(IntPtr Self, bool bNewLooping);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UTimelineComponent_SetNewTime(IntPtr Self, float NewTime);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UTimelineComponent_SetPlaybackPosition(IntPtr Self, float NewPosition, bool bFireEvents, bool bFireUpdate);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UTimelineComponent_SetPlayRate(IntPtr Self, float NewRate);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UTimelineComponent_SetPropertySetObject(IntPtr Self, IntPtr NewPropertySetObject);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UTimelineComponent_SetTimelineLength(IntPtr Self, float NewLength);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UTimelineComponent_Stop(IntPtr Self);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Get whether to ignore time dilation. </para>
		/// </summary>
		public bool GetIgnoreTimeDilation()
			=> E_UTimelineComponent_GetIgnoreTimeDilation(this);
		
		
		/// <summary>
		/// <para>Get the current playback position of the Timeline </para>
		/// </summary>
		public float GetPlaybackPosition()
			=> E_UTimelineComponent_GetPlaybackPosition(this);
		
		
		/// <summary>
		/// <para>Get the current play rate for this timeline </para>
		/// </summary>
		public float GetPlayRate()
			=> E_UTimelineComponent_GetPlayRate(this);
		
		
		/// <summary>
		/// <para>Get length of the timeline </para>
		/// </summary>
		public float GetTimelineLength()
			=> E_UTimelineComponent_GetTimelineLength(this);
		
		
		/// <summary>
		/// <para>Get whether we are looping or not </para>
		/// </summary>
		public bool IsLooping()
			=> E_UTimelineComponent_IsLooping(this);
		
		
		/// <summary>
		/// <para>Get whether this timeline is playing or not. </para>
		/// </summary>
		public bool IsPlaying()
			=> E_UTimelineComponent_IsPlaying(this);
		
		
		/// <summary>
		/// <para>Get whether we are reversing or not </para>
		/// </summary>
		public bool IsReversing()
			=> E_UTimelineComponent_IsReversing(this);
		
		
		/// <summary>
		/// <para>Start playback of timeline </para>
		/// </summary>
		public void Play()
			=> E_UTimelineComponent_Play(this);
		
		
		/// <summary>
		/// <para>Start playback of timeline from the start </para>
		/// </summary>
		public void PlayFromStart()
			=> E_UTimelineComponent_PlayFromStart(this);
		
		
		/// <summary>
		/// <para>Start playback of timeline in reverse </para>
		/// </summary>
		public void Reverse()
			=> E_UTimelineComponent_Reverse(this);
		
		
		/// <summary>
		/// <para>Start playback of timeline in reverse from the end </para>
		/// </summary>
		public void ReverseFromEnd()
			=> E_UTimelineComponent_ReverseFromEnd(this);
		
		
		/// <summary>
		/// <para>Set the delegate to call when timeline is finished </para>
		/// </summary>
		public void SetDirectionPropertyName(string DirectionPropertyName)
			=> E_UTimelineComponent_SetDirectionPropertyName(this, DirectionPropertyName);
		
		
		/// <summary>
		/// <para>Set whether to ignore time dilation. </para>
		/// </summary>
		public void SetIgnoreTimeDilation(bool bNewIgnoreTimeDilation)
			=> E_UTimelineComponent_SetIgnoreTimeDilation(this, bNewIgnoreTimeDilation);
		
		
		/// <summary>
		/// <para>true means we would loop, false means we should not. </para>
		/// </summary>
		public void SetLooping(bool bNewLooping)
			=> E_UTimelineComponent_SetLooping(this, bNewLooping);
		
		
		/// <summary>
		/// <para>Set the new playback position time to use </para>
		/// </summary>
		public void SetNewTime(float NewTime)
			=> E_UTimelineComponent_SetNewTime(this, NewTime);
		
		
		/// <summary>
		/// <para>Jump to a position in the timeline. </para>
		/// <param name="bFireEvents">If true, event functions that are between current position and new playback position will fire. </param>
		/// <param name="bFireUpdate">If true, the update output exec will fire after setting the new playback position. </param>
		/// </summary>
		public void SetPlaybackPosition(float NewPosition, bool bFireEvents, bool bFireUpdate = true)
			=> E_UTimelineComponent_SetPlaybackPosition(this, NewPosition, bFireEvents, bFireUpdate);
		
		
		/// <summary>
		/// <para>Sets the new play rate for this timeline </para>
		/// </summary>
		public void SetPlayRate(float NewRate)
			=> E_UTimelineComponent_SetPlayRate(this, NewRate);
		
		
		/// <summary>
		/// <para>Optionally provide an object to automatically update properties on </para>
		/// </summary>
		public void SetPropertySetObject(UObject NewPropertySetObject)
			=> E_UTimelineComponent_SetPropertySetObject(this, NewPropertySetObject);
		
		
		/// <summary>
		/// <para>Set length of the timeline </para>
		/// </summary>
		public void SetTimelineLength(float NewLength)
			=> E_UTimelineComponent_SetTimelineLength(this, NewLength);
		
		
		/// <summary>
		/// <para>Stop playback of timeline </para>
		/// </summary>
		public void Stop()
			=> E_UTimelineComponent_Stop(this);
		
		#endregion
		
		public static implicit operator IntPtr(UTimelineComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UTimelineComponent(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as UTimelineComponent ?? new UTimelineComponent(Adress);
		}}}
