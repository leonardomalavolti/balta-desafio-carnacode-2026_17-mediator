![CO-5](https://github.com/user-attachments/assets/3b37a043-982a-445d-9611-142ba1a9178b)

## 🥁 CarnaCode 2026 - Desafio 17 - Mediator

Oi, eu sou o Leonardo Malavolti e este é o espaço onde compartilho minha jornada de aprendizado durante o desafio **CarnaCode 2026**, realizado pelo [balta.io](https://balta.io). 👻

Aqui você vai encontrar projetos, exercícios e códigos que estou desenvolvendo durante o desafio. O objetivo é colocar a mão na massa, testar ideias e registrar minha evolução no mundo da tecnologia.

### Sobre este desafio
No desafio **Mediator** eu tive que resolver um problema real implementando o **Design Pattern** em questão.
Neste processo eu aprendi:
* ✅ Boas Práticas de Software
* ✅ Código Limpo
* ✅ SOLID
* ✅ Design Patterns (Padrões de Projeto)
* ✅ Desacoplamento de objetos
* ✅ Comunicação centralizada via Mediator

## Problema
Um aplicativo de mensagens tem usuários que precisam:
- Enviar mensagens para grupos
- Notificar quando entram/saem
- Gerenciar permissões (como mutar usuários)

O código original tinha problemas:
* Cada usuário conhecia todos os outros → alto acoplamento
* Comunicação M×N: cada usuário enviava para N-1 outros
* Lógica de notificação duplicada em cada método
* Usuários modificavam estado de outros diretamente
* Difícil adicionar regras centralizadas (moderação, filtros)
* Não havia log centralizado
* Difícil adicionar novos tipos de interação

## Solução Implementada
Utilizando o **Mediator Pattern** com `ChatRoom` e `ChatService`:
* O **Mediator** (`ChatRoom`) centraliza toda comunicação e moderação
* Usuários (`ChatUser`) não conhecem uns aos outros diretamente
* O **ChatService** encapsula operações como enviar mensagens, mensagens privadas e mutar usuários
* Notificações, entrada/saída e mensagens são tratadas em um único ponto
* Código mais limpo, desacoplado e extensível

### Benefícios
* Comunicação centralizada
* Baixo acoplamento entre usuários
* Lógica de moderação e notificações unificada
* Camada de serviço facilita manutenção e testes
* Fácil extensão para novos tipos de interação
* Permite adicionar filtros, logs ou regras de rate limiting de forma centralizada

## Sobre o CarnaCode 2026
O desafio **CarnaCode 2026** consiste em implementar todos os 23 padrões de projeto (Design Patterns) em cenários reais. Durante os 23 desafios desta jornada, os participantes são submetidos ao aprendizado e prática na identificação de códigos não escaláveis e na solução de problemas utilizando padrões de mercado.

### eBook - Fundamentos dos Design Patterns
Minha principal fonte de conhecimento durante o desafio foi o eBook gratuito [Fundamentos dos Design Patterns](https://lp.balta.io/ebook-fundamentos-design-patterns).

### Veja meu progresso no desafio
[Incluir link para o repositório central]
