using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Этот класс может быть наследованн
	/// <para>Abstract base class of all Engine classes, responsible for management of systems critical to editor or game systems. </para>
	/// <para>Also defines default classes for certain engine systems. </para>
	/// </summary>
	public partial class ManageEngine : UEngine
	{
		public ManageEngine(IntPtr Adress)
			: base(Adress)
		{
		}

		
		/// <summary>
		/// <para>Called at shutdown, just before the exit purge. </para>
		/// </summary>
		public override void PreExit() { }
		
		public override void ShutdownAudioDeviceManager() { }
		
		
		/// <summary>
		/// <para>Start the game, separate from the initialize call to allow for post initialize configuration before the game starts. </para>
		/// </summary>
		public override void Start() { }
		
		
		/// <summary>
		/// <para>Update everything. </para>
		/// </summary>
		public override void Tick(float DeltaSeconds, bool bIdleMode) { }
		
		
		/// <summary>
		/// <para>Needs to be called when a world is added to broadcast messages. </para>
		/// </summary>
		public override void WorldAdded(UWorld World) { }
		
		
		/// <summary>
		/// <para>Needs to be called when a world is destroyed to broadcast messages. </para>
		/// </summary>
		public override void WorldDestroyed(UWorld InWorld) { }
		
		public static implicit operator IntPtr(ManageEngine Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ManageEngine(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as ManageEngine ?? new ManageEngine(Adress);
		}