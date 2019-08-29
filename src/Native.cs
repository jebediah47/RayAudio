using System;
using System.Runtime.InteropServices;

namespace RayAudio
{
	internal static class Native
	{
		[StructLayout(LayoutKind.Sequential)]
		public struct Wave
		{
			uint sampleCount;
			uint sampleRate;
			uint sampleSize;
			uint channels;
			UIntPtr data;
		}

		[DllImport("raudio")]
		public static extern void InitAudioDevice();

		[DllImport("raudio")]
		public static extern void CloseAudioDevice();

		[DllImport("raudio")]
		public static extern bool IsAudioDeviceReady();

		[DllImport("raudio")]
		public static extern void SetMasterVolume(float volume);

		[DllImport("raudio")]
		public static extern UIntPtr RHLoadSound([MarshalAs(UnmanagedType.LPStr)] string fileName);

		[DllImport("raudio")]
		public static extern void RHUnloadSound(UIntPtr sound);

		[DllImport("raudio")]
		public static extern void RHPlaySound(UIntPtr sound);

		[DllImport("raudio")]
		public static extern void RHPlaySoundMulti(UIntPtr sound);

		[DllImport("raudio")]
		public static extern void RHStopSound(UIntPtr sound);

		[DllImport("raudio")]
		public static extern void RHPauseSound(UIntPtr sound);

		[DllImport("raudio")]
		public static extern void RHResumeSound(UIntPtr sound);

		[DllImport("raudio")]
		public static extern bool RHIsSoundPlaying(UIntPtr sound);

		[DllImport("raudio")]
		public static extern void RHSetSoundVolume(UIntPtr sound, float volume);

		[DllImport("raudio")]
		public static extern void RHSetSoundPitch(UIntPtr sound, float pitch);

		[DllImport("raudio")]
		public static extern UIntPtr RHLoadMusicStream([MarshalAs(UnmanagedType.LPStr)] string fileName);

		[DllImport("raudio")]
		public static extern void RHUnloadMusicStream(UIntPtr music);

		[DllImport("raudio")]
		public static extern void RHPlayMusicStream(UIntPtr music);

		[DllImport("raudio")]
		public static extern void UpdateMusicStream(UIntPtr music);

		[DllImport("raudio")]
		public static extern void StopMusicStream(UIntPtr music);

		[DllImport("raudio")]
		public static extern void RHPauseMusicStream(UIntPtr music);

		[DllImport("raudio")]
		public static extern void RHResumeMusicStream(UIntPtr music);

		[DllImport("raudio")]
		public static extern bool RHIsMusicPlaying(UIntPtr music);

		[DllImport("raudio")]
		public static extern void RHSetMusicVolume(UIntPtr music, float volume);

		[DllImport("raudio")]
		public static extern void RHSetMusicPitch(UIntPtr music, float pitch);

		[DllImport("raudio")]
		public static extern float RHGetMusicTimeLength(UIntPtr music);

		[DllImport("raudio")]
		public static extern float RHGetMusicTimePlayed(UIntPtr music);

		[DllImport("raudio")]
		public static extern bool EXVorbisSeek(UIntPtr music, float secs);
	}
}
