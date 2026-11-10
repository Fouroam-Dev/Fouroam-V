# Fouroam-V

**Four friends. One world.**

Independent open-source research into private networking, with a first **GTA V Story Mode UI prototype**.

![Status](https://img.shields.io/badge/status-pre--alpha-orange)
[![Build](https://github.com/Fouroam-Dev/Fouroam-V/actions/workflows/game-client.yml/badge.svg)](https://github.com/Fouroam-Dev/Fouroam-V/actions/workflows/game-client.yml)
[![MIT](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE)

[Português](README.pt-BR.md) · [Installation](docs/INSTALL-STORY-MODE.md) · [Roadmap](ROADMAP.md)

> **Not a multiplayer mod.** This initial in-game client is a **local Story Mode menu only**. It does not connect the GTA V game to other players or synchronize gameplay. Our independent [Fouroam Server](https://github.com/Fouroam-Dev/Fouroam-Server) has a working external TCP/TLS network test client, but the game client is not connected to it.

## In-game client prototype

- Original **C# .NET Framework 4.8** ScriptHookVDotNet3 script (build-time NuGet API dependency).
- Press **F7** to open/close a dark/blue panel within Story Mode.
- Up/Down, Enter and Escape navigate **Status**, **Local Diagnostics**, **About**, **Close**.
- Shared menu state is independent of the game (.NET Standard 2.0); navigation is tested without GTA V.
- GitHub Actions builds a package containing only **Fouroam.GameClient.dll**, **Fouroam.Client.Core.dll**, license and setup instructions. No copyrighted game files or third-party runtime libraries are included.

[Read the installation guide](docs/INSTALL-STORY-MODE.md). **Actual in-game compatibility has not yet been verified**, even if CI compilation passes.

## Architecture

~~~text
src/Fouroam.Client.Core/       Menu navigation and state machine (netstandard2.0)
src/Fouroam.GameClient/        ScriptHookVDotNet3 UI entrypoint (net48)
tests/Fouroam.Client.Tests/    Pure menu tests (net10.0)
.github/workflows/            Windows build and temporary DLL artifact
~~~

## Game integration restrictions

We used [RAGECOOP-V](https://github.com/RAGECOOP/RAGECOOP-V) as a public architectural reference without copying its source.

Rockstar's **September 2026 mod guidelines restrict multiplayer mods to officially licensed platforms**. Accordingly, this module deliberately has **no in-game networking, game sync, GTA Online access, mission changes, or DRM/anti-cheat workarounds**. We will evaluate permitted paths before further game integration.

[Official Rockstar modification guidelines](https://www.rockstargames.com/br/community-resources/mod-guidelines)

## Legal notice

Fouroam is independent and is not affiliated with or endorsed by Rockstar Games, Take-Two Interactive or RAGECOOP. GTA V, ScriptHookVDotNet and Script Hook V are third-party products and are not distributed here.

## License

[MIT](LICENSE) covers only original Fouroam Dev source and documentation.
