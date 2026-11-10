<div align="center">

# Fouroam-V

**Four friends. One world.**

An open-source project exploring private, self-hosted co-op sessions for up to four friends in Grand Theft Auto V.

[![License: MIT](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE)
![Stage: Concept](https://img.shields.io/badge/stage-concept-orange.svg)
![Platform: Windows](https://img.shields.io/badge/platform-Windows-lightgrey.svg)

[English](README.md) · [Português](README.pt-BR.md) · [Roadmap](ROADMAP.md) · [Contributing](CONTRIBUTING.md)

</div>

> [!IMPORTANT]
> **Project status: concept / pre-alpha.** The repository currently contains documentation and project setup, **not a downloadable or playable co-op client/server**. The features below describe goals, not finished functionality.

## What is Fouroam-V?

Fouroam-V aims to make it easy for a small group of friends to host a **private cooperative session** without renting a dedicated game server or using a public server browser.

The proposed experience is straightforward:

1. One player hosts a lightweight session on their own Windows PC.
2. Up to three friends connect over a local network (LAN) or a private VPN, such as Radmin VPN.
3. The group explores and plays together in a shared session.

An optional VPS or dedicated machine could also host the server, but **paid hosting is not part of the requirement**. A purchased, legitimate copy of GTA V would still be required by each player.

## Project goals

| Capability | Current status |
| --- | --- |
| Private sessions for up to four players | Planned |
| Local, player-hosted server | Planned |
| LAN and VPN-based connections | Planned |
| Player position and movement synchronization | Research / planned |
| Vehicles, world events and NPC synchronization | Research / planned |
| Connection recovery and session stability | Planned |
| Shared objectives and mission experiments | Feasibility and permission review required |
| Steam / Epic Games achievement integration | Not supported or promised |

**Nothing in this table is implemented yet.** The first milestone is a small, authorized network-synchronization proof of concept.

## Why a self-hosted approach?

- **Small groups first:** optimize for one host and at most three guests.
- **No required central service:** avoid accounts, public lobbies or a mandatory online backend.
- **Transparent and open source:** make the project's original code inspectable and contribution-friendly.
- **Practical networking:** allow local connections or private VPN networks without promising universal NAT traversal.

## Planned technical direction

The architecture has **not** been finalized. Initial research is focused on:

- A lightweight Windows host/server process, potentially built with C# and .NET.
- A game-side client, with its implementation dependent on a lawful and compatible integration method.
- An authoritative session host for shared state.
- Efficient state synchronization with reliability and disconnect handling.

No builds, installers, protocol specifications or server commands exist yet. See the [roadmap](ROADMAP.md) for the development sequence.

## Contributing

Development discussions, bug reports about repository content and technical proposals are welcome. Read the [contribution guide](CONTRIBUTING.md), [code of conduct](CODE_OF_CONDUCT.md), and [security policy](SECURITY.md) before contributing.

- [Open an issue](https://github.com/Fouroam-Dev/Fouroam-V/issues)
- [Read the roadmap](ROADMAP.md)
- [View the source](https://github.com/Fouroam-Dev/Fouroam-V)

## Legal and third-party notice

Fouroam-V is an **independent, unofficial community project** and is not affiliated with, endorsed by or sponsored by Rockstar Games, Take-Two Interactive, Valve or Epic Games.

**Grand Theft Auto V, GTA V and associated assets belong to their respective owners.** The MIT license below covers original code and documentation in this repository only. It does **not** grant any right to GTA V game assets, trademarks, game code, official story content, platform services or third-party components.

Multiplayer modification, modification of official missions and distribution may be restricted by the game's terms and applicable policies. **Implementation and release require a review of relevant permissions and rules first.** Do not contribute copyrighted game files, leaked assets, authentication bypasses, anti-cheat bypasses or pirated content.

## License

Original project code and documentation are licensed under the [MIT License](LICENSE), subject to third-party rights and applicable terms.
