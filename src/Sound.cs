using System;
namespace RayAudio {
	public class Sound : IDisposable {
		internal UIntPtr NativePtr;
		internal float VolumeCache = 1f;
		internal float PitchCache = 1f;

		internal Sound(UIntPtr ptr) {
			NativePtr = ptr;
		}

		public static Sound Load(string path) {
			AudioDevice.CheckState();

			return new Sound(Native.RHLoadSound(path));
		}

		public void Play() {
			Native.RHPlaySound(NativePtr);
		}

		public void Stop() {
			Native.RHStopSound(NativePtr);
		}

		public void Pause() {
			Native.RHPauseSound(NativePtr);
		}

		public void Resume() {
			Native.RHResumeSound(NativePtr);
		}

		public void Dispose() {
			Native.RHUnloadSound(NativePtr);
		}

		public bool IsPlaying {
			get {
				return Native.RHIsSoundPlaying(NativePtr);
			}
		}

		public float Volume {
			get { return VolumeCache; }
			set {
				VolumeCache = value;
				Native.RHSetSoundVolume(NativePtr, value);
			}
		}

		public float Pitch { 
			get { return PitchCache; }
			set
			{
				PitchCache = value;
				Native.RHSetSoundPitch(NativePtr, value);
			}
		}
	}
}
