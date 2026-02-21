using DesignPatternChallenge.Mediator;
using DesignPatternChallenge.Models;
using DesignPatternChallenge.Services;

Console.WriteLine("=== Sistema de Chat Mediator com Service ===\n");

var chatRoom = new ChatRoom();
var chatService = new ChatService(chatRoom);

var alice = new ChatUser("Alice", chatRoom);
var bob = new ChatUser("Bob", chatRoom);
var carlos = new ChatUser("Carlos", chatRoom);
var diana = new ChatUser("Diana", chatRoom);

// Usuários entram no grupo usando o service
chatService.JoinGroup(alice);
chatService.JoinGroup(bob);
chatService.JoinGroup(carlos);
chatService.JoinGroup(diana);

Console.WriteLine("\n=== Conversação ===");
chatService.SendMessage(alice, "Olá, pessoal!");
chatService.SendMessage(bob, "Oi, Alice!");
chatService.SendMessage(carlos, "E aí!");

Console.WriteLine("\n=== Mensagem Privada ===");
chatService.SendPrivateMessage(alice, bob, "Bob, você viu o relatório?");

Console.WriteLine("\n=== Moderação ===");
chatService.MuteUser(alice, carlos);
chatService.SendMessage(carlos, "Ainda posso falar?"); // Não será enviado

Console.WriteLine("\n=== Saindo do Grupo ===");
chatService.LeaveGroup(diana);
chatService.SendMessage(alice, "Diana saiu");

Console.WriteLine("\n=== Benefícios do Mediator + Service ===");
Console.WriteLine("✓ Comunicação centralizada");
Console.WriteLine("✓ Baixo acoplamento entre usuários");
Console.WriteLine("✓ Lógica de moderação e notificações unificada");
Console.WriteLine("✓ Camada de serviço facilita manutenção e testes");
Console.WriteLine("✓ Fácil extensão para novos tipos de interação");