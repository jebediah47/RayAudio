using System;
namespace RayAudio {
	public static class AudioDevice {
		public static bool IsInitialized {
			get; private set;
		}

		public static bool WasClosed {
			get; private set;
		}

		public static void Initialize() {
			if (WasClosed) throw new InvalidOperationException("Cannot reinitialize audio device after closing it.");
			Native.InitAudioDevice();
			IsInitialized = true;
		}

		public static void Close() {
			CheckState();
			Native.CloseAudioDevice();
			IsInitialized = false;
			WasClosed = true;
		}

		internal static void CheckState() {
			if (!IsInitialized) throw new InvalidOperationException("Audio device not initialized.");
		}
	}
}
