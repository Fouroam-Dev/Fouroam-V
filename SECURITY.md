# Security Policy

## Supported versions

Fouroam-V is currently a **concept / pre-alpha** repository with no published client, server or supported release. No runtime versions are supported at this time.

When code is published, this section will identify supported versions and security-update expectations.

## Reporting a vulnerability

**Do not open a public GitHub issue** containing exploit details, sensitive credentials or private network data.

Send a private report to **[eu@athiliodev.com.br](mailto:eu@athiliodev.com.br)** with **Fouroam-V security** in the subject. If GitHub private vulnerability reporting becomes available, it may also be used.

Please include, when known:

- A concise description and potential impact.
- Affected commit, component or future release version.
- Reproduction steps or a minimal proof of concept.
- Relevant logs with all IP addresses, secrets and personal information redacted.

The maintainers will review the report and coordinate a fix or mitigation as appropriate. No fixed response or patch timeline is promised.

## Future threat model

The planned self-hosted client/server will need particular scrutiny around:

- Untrusted network packets and input validation.
- Host authority, session access and unauthorized joins.
- Denial-of-service and malformed packet handling.
- Accidental exposure of players' addresses, logs or files.
- Dependency integrity and release authenticity.

Never share VPN passwords, service tokens, credentials or private network details in issues, pull requests or screenshots.

## Scope

This policy covers **original Fouroam-V code and infrastructure** when they exist. It does not authorize attacks against Rockstar, game platforms, third-party mods, VPN services or other players.
