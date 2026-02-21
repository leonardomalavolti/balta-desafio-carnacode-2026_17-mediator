using DesignPatternChallenge.Models;

namespace DesignPatternChallenge.Mediator;

public class ChatRoom : IChatMediator
{
    private readonly List<ChatUser> _users = new();

    public void RegisterUser(ChatUser user)
    {
        if (!_users.Contains(user))
            _users.Add(user);
    }

    public void SendMessage(string message, ChatUser sender)
    {
        if (sender.IsMuted)
        {
            Console.WriteLine($"[{sender.Name}] ❌ Você está mutado");
            return;
        }

        Console.WriteLine($"[{sender.Name}] Enviou: {message}");
        foreach (var user in _users)
        {
            if (user != sender && !user.IsMuted)
            {
                user.ReceiveMessage(sender.Name, message);
            }
        }
    }

    public void SendPrivateMessage(string message, ChatUser sender, ChatUser recipient)
    {
        if (sender.IsMuted)
        {
            Console.WriteLine($"[{sender.Name}] ❌ Você está mutado");
            return;
        }

        Console.WriteLine($"[{sender.Name}] Enviou mensagem privada para {recipient.Name}");
        recipient.ReceivePrivateMessage(sender.Name, message);
    }

    public void NotifyUserEntered(ChatUser user)
    {
        foreach (var u in _users.Where(u => u != user))
        {
            u.ReceiveNotification($"{user.Name} entrou no grupo");
        }

        Console.WriteLine($"[{user.Name}] Entrou no grupo com {_users.Count} membros");
    }

    public void NotifyUserLeft(ChatUser user)
    {
        _users.Remove(user);
        foreach (var u in _users)
        {
            u.ReceiveNotification($"{user.Name} saiu do grupo");
        }

        Console.WriteLine($"[{user.Name}] Saiu do grupo");
    }

    public void MuteUser(ChatUser target, ChatUser byUser)
    {
        target.SetMuted(true);
        Console.WriteLine($"[{byUser.Name}] Mutou {target.Name}");

        foreach (var u in _users.Where(u => u != target && u != byUser))
        {
            u.ReceiveNotification($"{target.Name} foi mutado por {byUser.Name}");
        }
    }
}