# Fouroam-V

**Quatro amigos. Um mundo.**

Projeto open-source com infraestrutura de rede própria e uma primeira **interface experimental para o modo História do GTA V**.

![Estado](https://img.shields.io/badge/estado-pr%C3%A9--alfa-orange)
[![Build](https://github.com/Fouroam-Dev/Fouroam-V/actions/workflows/game-client.yml/badge.svg)](https://github.com/Fouroam-Dev/Fouroam-V/actions/workflows/game-client.yml)
[![MIT](https://img.shields.io/badge/licen%C3%A7a-MIT-blue.svg)](LICENSE)

[English](README.md) · [Instalação](docs/INSTALL-STORY-MODE.md) · [Roadmap](ROADMAP.md)

> **Ainda não é multiplayer dentro do jogo.** O cliente inicial é apenas um **menu local do modo História**, sem conexão entre jogadores no GTA V. O [Fouroam Server](https://github.com/Fouroam-Dev/Fouroam-Server) já tem rede TCP/TLS funcionando com um cliente externo separado, mas esse script não se conecta a ele.

## Primeiro módulo dentro do GTA V

- Código **C# próprio**, utilizando .NET Framework 4.8 e a API pública ScriptHookVDotNet3.
- **F7** para abrir/fechar um painel escuro e azul dentro do jogo.
- **Setas, Enter e Esc** para navegar por **Estado**, **Diagnóstico**, **Sobre** e **Fechar**.
- Núcleo do menu separado e testado automaticamente sem precisar do GTA V.
- GitHub Actions gera um ZIP com apenas \`Fouroam.GameClient.dll\`, \`Fouroam.Client.Core.dll\`, licença e instruções.

**O funcionamento dentro de uma instalação real ainda precisa ser verificado.** Consulte [como instalar e testar](docs/INSTALL-STORY-MODE.md).

## Pastas do código

~~~text
src/Fouroam.Client.Core/       Estado e navegação da interface
src/Fouroam.GameClient/        Módulo de menu para ScriptHookVDotNet3
tests/Fouroam.Client.Tests/    Testes de navegação
.github/workflows/            Compilação e artefatos de teste
~~~

## E a sincronização de jogadores?

Estudamos a estrutura pública do [RAGECOOP-V](https://github.com/RAGECOOP/RAGECOOP-V) como referência arquitetural, **sem copiar o código**.

As [diretrizes da Rockstar de setembro de 2026](https://www.rockstargames.com/br/community-resources/mod-guidelines) limitam a criação de mods multiplayer a plataformas licenciadas. Por isso **não vamos anunciar um modo co-op não autorizado como funcional**. O módulo atual não altera missões, não transmite dados de gameplay e não interage com GTA Online.

## Licença e terceiros

[MIT](LICENSE) para o código original do Fouroam Dev. Projeto independente e sem afiliação com Rockstar Games ou Take-Two. Arquivos do GTA V e de ferramentas de terceiros não estão incluídos.
