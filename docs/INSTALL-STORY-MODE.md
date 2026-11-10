# Fouroam-V — instalação da interface no modo História (pré-alfa)

**Esta build é uma interface local de diagnóstico. Não oferece multiplayer dentro do GTA V, não altera missões e não funciona no GTA Online.**

## Dependências instaladas separadamente

- GTA V original para PC e uma edição/build compatível.
- [Script Hook V](http://www.dev-c.com/gtav/scripthookv/).
- [ScriptHookVDotNet v3](https://github.com/scripthookvdotnet/scripthookvdotnet) (a compilação usa a API 3.6.0).
- .NET Framework 4.8 para execução de scripts.

A compatibilidade com GTA V Legacy ou Enhanced depende da versão do carregador; **não é garantida**. Não execute esta interface no GTA Online nem desative proteções.

## Instalação

1. Acesse **Actions → Fouroam Game Client (Story Mode UI)** no repositório Fouroam-V.
2. Em uma execução verde, baixe o artefato **Fouroam-V-StoryMode-UI-prealpha** e extraia.
3. Localize a pasta \`scripts\` dentro do GTA V, conforme as instruções do ScriptHookVDotNet.
4. Copie \`Fouroam.GameClient.dll\` e \`Fouroam.Client.Core.dll\` para \`scripts\`.
5. Inicie **somente** o modo História. Pressione **F7**.
6. Navegue pelas setas, confirme com **Enter**, volte com **Esc** ou feche com **F7**.

O menu tem **Status**, **Diagnóstico**, **Sobre** e **Fechar**. Ainda não abre sessões cooperativas nem conecta o jogo ao Fouroam Server. A rede TLS existe apenas nos clientes de teste externos do repositório Fouroam-Server.

Os arquivos do GTA V e do ScriptHook não estão no ZIP e não são redistribuídos pelo projeto. O teste dentro do jogo ainda depende de validação manual numa instalação compatível.

## Compilar

~~~cmd
dotnet restore Fouroam-V.slnx
dotnet build Fouroam-V.slnx -c Release
dotnet run --project tests/Fouroam.Client.Tests -c Release
~~~

A DLL de jogo utiliza .NET Framework 4.8 e a biblioteca de navegação é netstandard2.0.

## Sobre permissões

As [diretrizes de modificações da Rockstar de setembro de 2026](https://www.rockstargames.com/br/community-resources/mod-guidelines) restringem mods multiplayer às plataformas oficialmente licenciadas. Antes de desenvolver ou distribuir conexão multiplayer *dentro* do GTA V, precisamos verificar uma integração autorizada. Esta build é apenas um menu local de modo História, sem alterar o jogo online.

Nunca inclua arquivos do jogo, dados pessoais, tokens, hacks, bypasses ou chaves privadas nos commits.
