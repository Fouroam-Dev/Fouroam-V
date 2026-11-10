# Fouroam-V Roadmap

This roadmap describes **proposed milestones**, not delivery commitments. The project is currently a concept, and no playable build exists.

## Phase 0 — Feasibility and permission review

- [ ] Review Rockstar / Take-Two rules for multiplayer mods and changes to official story missions.
- [ ] Identify a permitted way to integrate a client with the game.
- [ ] Document dependencies, their licenses and any third-party limitations.
- [ ] Define supported GTA V edition(s), operating systems and game build compatibility.

**Gate:** Do not distribute a game-integrated client or copyrighted game assets before permissions and compatibility are understood.

## Phase 1 — Standalone network prototype

- [ ] Create a minimal self-hosted server prototype independent of GTA V.
- [ ] Connect two peers over LAN and a private VPN.
- [ ] Exchange position/state updates, measure latency and packet loss.
- [ ] Test session shutdown and reconnect behavior.

## Phase 2 — Authorized game-side proof of concept

- [ ] Demonstrate two participants in a shared test environment using an authorized integration method.
- [ ] Evaluate character and animation state synchronization.
- [ ] Establish host authority and basic security boundaries.

## Phase 3 — Four-player private sessions

- [ ] Support a maximum of four peers.
- [ ] Evaluate vehicle and NPC/world synchronization.
- [ ] Document LAN, VPN and optional VPS deployment.
- [ ] Add structured logs, version compatibility checks and recovery tests.

## Phase 4 — Cooperative gameplay research

- [ ] Explore original, user-created objectives and shared activities.
- [ ] Review whether official story content can be supported lawfully.
- [ ] Evaluate save and checkpoint consistency without claiming official platform achievement support.

## Non-goals for the initial prototype

- Public multiplayer server browser.
- Paid hosting platform or mandatory account service.
- GTA Online compatibility.
- Circumventing authentication, anti-cheat, DRM or platform restrictions.
- Guarantees of official GTA V story missions or Steam/Epic achievements.

Milestones may be reordered or cancelled based on technical and legal findings.
