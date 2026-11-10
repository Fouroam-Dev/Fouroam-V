# Fouroam-V — Roadmap

## Fase 0: Base externa de rede

- [x] Criar [Fouroam Server](https://github.com/Fouroam-Dev/Fouroam-Server) com sessão de 4 jogadores, autenticação TLS, chat e comandos do host.
- [x] Testar servidor e cliente externos em um computador Windows.
- [ ] Testar comunicação em dois computadores físicos, via LAN/VPN.

## Fase 1: Interface local no modo História

- [x] Criar script C# ScriptHookVDotNet3 direcionado ao .NET Framework 4.8.
- [x] Desenhar menu próprio em azul/preto e navegação F7/setas/Enter/Esc.
- [x] Isolar lógica de menu e escrever testes sem dependência do jogo.
- [x] Adicionar build Windows e pacote de DLL no GitHub Actions.
- [ ] Confirmar compilação e testes no GitHub Actions.
- [ ] Testar manualmente em GTA V Story Mode compatível.

## Fase 2: Permissões e compatibilidade

- [x] Analisar a arquitetura pública do RAGECOOP-V.
- [x] Localizar as diretrizes de mods de setembro de 2026 da Rockstar.
- [ ] Determinar uma integração multijogador licenciada/autorizada, se disponível.
- [ ] Definir compatibilidade de Legacy/Enhanced e versões específicas.
- [ ] Garantir uma revisão de segurança e licenças antes de distribuição pública.

## Fase 3: Simulador independente

- [ ] Implementar sincronização de posições e interpolação em simulador **fora do GTA V**.
- [ ] Testar movimentação de dois participantes e recuperação de conexão.
- [ ] Verificar desempenho, latência e limites de autoridade do host.
- [ ] Avaliar integração em motor/plataforma autorizada somente após revisão de permissões.

## Fora do escopo atual

- GTA Online ou modificação de serviços oficiais.
- Sincronização GTA V de jogadores, veículos, NPCs e missões.
- Alterar campanhas oficiais ou contornar DRM/anti-cheat.
- Prometer co-op no modo História sem verificação de licença.
