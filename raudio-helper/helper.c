#define SUPPORT_FILEFORMAT_OGG
#define SUPPORT_FILEFORMAT_FLAC
#define RAUDIO_STANDALONE
#include "raudio.c"
#include <stdlib.h>

/*** Sound ***/

void* RHLoadSound(const char *fileName) {
	Sound* ptr = malloc(sizeof(Sound));
	*ptr = LoadSound(fileName);
	return ptr;
}

void RHUnloadSound(Sound* sound) { UnloadSound(*sound); }
void RHPlaySound(Sound* sound) { PlaySound(*sound); }
void RHStopSound(Sound* sound) { StopSound(*sound); }
void RHPauseSound(Sound* sound) { PauseSound(*sound); }
void RHResumeSound(Sound* sound) { ResumeSound(*sound); }
void RHPlaySoundMulti(Sound* sound) { PlaySoundMulti(*sound); }
bool RHIsSoundPlaying(Sound* sound) { return IsSoundPlaying(*sound); }
void RHSetSoundVolume(Sound* sound, float volume) { SetSoundVolume(*sound, volume); }
void RHSetSoundPitch(Sound* sound, float pitch) { SetSoundPitch(*sound, pitch); }


/*** Music ***/

Music* RHLoadMusicStream(const char *fileName) {
	Music* ptr = malloc(sizeof(Music));
	*ptr = LoadMusicStream(fileName);
	return ptr;
}

void RHUnloadMusicStream(Music* music) { UnloadMusicStream(*music); }
void RHPlayMusicStream(Music* music) { PlayMusicStream(*music); }
void RHPauseMusicStream(Music* music) { PauseMusicStream(*music); }
void RHResumeMusicStream(Music* music) { ResumeMusicStream(*music); }
bool RHIsMusicPlaying(Music* music) { return IsMusicPlaying(*music); }
void RHSetMusicVolume(Music* music, float volume) { SetMusicVolume(*music, volume); }
void RHSetMusicPitch(Music* music, float pitch) { SetMusicPitch(*music, pitch); }
float RHGetMusicTimeLength(Music* music) { return GetMusicTimeLength(*music); }
float RHGetMusicTimePlayed(Music* music) { return GetMusicTimePlayed(*music); }
