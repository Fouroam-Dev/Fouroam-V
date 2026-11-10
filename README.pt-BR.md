<div align="center">

# Fouroam-V

**Quatro amigos. Um mundo.**

Projeto open-source que estuda sessões cooperativas privadas e auto-hospedadas para até quatro amigos no Grand Theft Auto V.

[![Licença: MIT](https://img.shields.io/badge/licen%C3%A7a-MIT-blue.svg)](LICENSE)
![Estágio: Conceito](https://img.shields.io/badge/est%C3%A1gio-conceito-orange.svg)
![Plataforma: Windows](https://img.shields.io/badge/plataforma-Windows-lightgrey.svg)

[English](README.md) · [Português](README.pt-BR.md) · [Planejamento](ROADMAP.md) · [Contribuição](CONTRIBUTING.md)

</div>

> [!IMPORTANT]
> **Estado atual: conceito / pré-alfa.** Este repositório contém documentação e configuração inicial. **Ainda não existe cliente ou servidor cooperativo disponível para jogar.** As funcionalidades descritas são objetivos, não recursos implementados.

## O que é o Fouroam-V?

A proposta é permitir que pequenos grupos de amigos mantenham uma **sessão cooperativa privada** sem alugar um servidor dedicado ou depender de uma lista pública de servidores.

A experiência planejada:

1. Um jogador hospeda uma sessão no próprio computador Windows.
2. Até três amigos entram pela rede local (LAN) ou por uma VPN privada, como o Radmin VPN.
3. Todos participam de uma sessão compartilhada.

A hospedagem em VPS poderá ser avaliada como opção, mas **não é requisito**. Cada jogador precisaria possuir sua própria cópia legítima de GTA V.

## Objetivos do projeto

| Funcionalidade | Situação |
| --- | --- |
| Sessões privadas para até quatro jogadores | Planejado |
| Servidor local hospedado pelo jogador | Planejado |
| Conexões por LAN ou VPN | Planejado |
| Sincronização de posição e movimento | Em pesquisa / planejado |
| Sincronização de veículos, eventos e NPCs | Em pesquisa / planejado |
| Reconexão e estabilidade da sessão | Planejado |
| Objetivos compartilhados e experimentos com missões | Depende de viabilidade e autorização |
| Conquistas oficiais da Steam / Epic Games | Não implementado nem prometido |

**Nenhuma funcionalidade desta tabela foi implementada.** O primeiro marco será uma prova de conceito de sincronização de rede dentro das permissões aplicáveis.

## Princípios

- **Até quatro pessoas:** foco em um host e três convidados.
- **Sem backend central obrigatório:** sem exigir contas ou infraestrutura paga.
- **Código aberto:** transparência e colaboração.
- **Rede simples:** LAN ou VPN privada, sem prometer que toda configuração de NAT funcionará automaticamente.

## Direção técnica

A arquitetura **ainda não está definida**. Estamos avaliando:

- Um processo host/servidor leve para Windows, possivelmente em C# e .NET.
- Um cliente do lado do jogo, dependendo de um meio de integração compatível e autorizado.
- Autoridade de sessão concentrada no host.
- Sincronização eficiente, confiabilidade e recuperação de conexões.

Ainda não existem executáveis, instaladores ou comandos para iniciar um servidor. Consulte o [planejamento](ROADMAP.md).

## Como contribuir

Leia [CONTRIBUTING.md](CONTRIBUTING.md), [CODE_OF_CONDUCT.md](CODE_OF_CONDUCT.md) e [SECURITY.md](SECURITY.md). Propostas técnicas e melhorias na documentação podem ser abertas em [Issues](https://github.com/Fouroam-Dev/Fouroam-V/issues).

## Aviso legal

Fouroam-V é **independente e não oficial**, sem afiliação ou endosso da Rockstar Games, Take-Two Interactive, Valve ou Epic Games.

GTA V e seus conteúdos pertencem aos titulares correspondentes. A licença MIT cobre apenas o material original deste repositório, sem autorizar uso de arquivos, marcas, código, missões oficiais ou serviços de terceiros.

Modificações multiplayer, alterações nas missões oficiais e distribuição podem sofrer restrições. **É necessário verificar regras e permissões antes de implementar ou distribuir o projeto.** Não envie arquivos do jogo, recursos obtidos ilegalmente, mecanismos para burlar autenticação ou anti-cheat.

## Licença

Código e documentação originais: [MIT License](LICENSE), respeitados os direitos de terceiros.
