RayAudio
===

RayAudio is a C# binding of the `raudio.c` standalone library from the [raylib](https://github.com/raysan5/raylib) project.

RayAudio was created for [Semi](https://github.com/modthegungeon/Semi), where it is employed in order to allow for mods to play custom sounds and music. You might find it useful in projects in which you don't need thousands of complicated sound effects and proprietary plugins.

Building
===

RayAudio is a normal .NET 3.5 project. However, it depends on a native helper library residing in `/raudio-helper`. A Makefile is provided that is confirmed to work on Linux, but for other platforms you might need to change up the command a little bit. Considering how small raudio.c is, this shouldn't take longer than a couple of minutes.

Usage
===

Before playing any audio, you have to initialize the audio device:

```cs
RayAudio.AudioDevice.Initialize();
```

After this, you can load a `Sound` or a `MusicStream`:

```cs
var sound = RayAudio.Sound.Load("/...");
var music = RayAudio.Music.Load("/...");
```

To play a sound, just use:

```cs
sound.Play();
```

As for streaming files (`MusicStream`), after playing them (`music.Play()`) you will have to refill the buffers as often as you can (ideally every frame) using:

```cs
music.Update();
```

Remember to dispose of `Sound` and `MusicStream` resources, and to call `AudioDevice.Close()` when the program exits.
