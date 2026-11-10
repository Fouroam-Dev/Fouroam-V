# Contributing to Fouroam-V

Thanks for your interest in contributing!

**Current stage:** concept / pre-alpha. The repository does not yet contain a playable co-op client or server. Documentation, feasibility research, independent networking prototypes and carefully scoped architecture proposals are the most useful contributions right now.

## Before contributing

- Read the [Code of Conduct](CODE_OF_CONDUCT.md) and [Roadmap](ROADMAP.md).
- Check for an existing [issue](https://github.com/Fouroam-Dev/Fouroam-V/issues).
- For significant changes, propose the approach in an issue before implementing it.
- Do not claim that unreleased features are working.

## Legal and original work

Only submit work that you are authorized to contribute and license under MIT.

**Do not include:**

- Game executables, extracted game assets, leaked source code or proprietary Rockstar content.
- Copied code from other multiplayer mods unless its license explicitly permits the proposed reuse and proper notices are included.
- Authentication, DRM or anti-cheat bypasses, stolen credentials or pirated game distribution.
- Client integrations that violate applicable platform or game rules.

Research involving GTA V story missions or multiplayer integration requires review of the relevant permissions before implementation and distribution.

## Development workflow

1. Fork the repository and create a branch such as `docs/readme-clarification`, `feat/prototype-name` or `fix/short-description`.
2. Make small, reviewable changes; describe intended behavior and limitations.
3. Add instructions and tests when code is introduced. Document how the tests were run.
4. Avoid committing binaries, secrets, VPN credentials, game files or generated build outputs.
5. Open a pull request against `main` and link the related issue when applicable.

There is not yet a stable build command, test suite or finalized technology stack. Any future build instructions must match actual checked-in source code.

## Commit conventions

Use [Conventional Commits](https://www.conventionalcommits.org/):

- `docs: clarify self-hosted session goals`
- `feat(network): add standalone LAN handshake prototype`
- `fix(network): handle peer disconnect`
- `test: cover session capacity limits`

Keep descriptions clear and use English for source documentation and commit messages when practical. Portuguese documentation is welcome.

## Pull request checklist

- [ ] The change is scoped and documented.
- [ ] New behavior is labeled **planned**, **experimental** or **implemented** accurately.
- [ ] Tests or manual verification steps are provided where relevant.
- [ ] The contribution contains no third-party assets or code without permission.
- [ ] No passwords, access tokens, personal data or game files are included.

## Security concerns

Do not publicly disclose exploitable vulnerabilities. Follow [SECURITY.md](SECURITY.md) for private reporting.
