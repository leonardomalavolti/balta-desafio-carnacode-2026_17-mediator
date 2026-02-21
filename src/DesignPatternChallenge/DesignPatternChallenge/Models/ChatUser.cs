using DesignPatternChallenge.Mediator;

namespace DesignPatternChallenge.Models;

public class ChatUser
{
    public string Name { get; }
    public bool IsMuted { get; private set; }

    private readonly IChatMediator _mediator;

    public ChatUser(string name, IChatMediator mediator)
    {
        Name = name;
        _mediator = mediator;
    }

    public void JoinGroup()
    {
        _mediator.RegisterUser(this);
        _mediator.NotifyUserEntered(this);
    }

    public void LeaveGroup()
    {
        _mediator.NotifyUserLeft(this);
    }

    public void SendMessage(string message)
    {
        _mediator.SendMessage(message, this);
    }

    public void SendPrivateMessage(ChatUser recipient, string message)
    {
        _mediator.SendPrivateMessage(message, this, recipient);
    }

    public void MuteUser(ChatUser target)
    {
        _mediator.MuteUser(target, this);
    }

    public void ReceiveMessage(string senderName, string message)
    {
        Console.WriteLine($"  → [{Name}] Recebeu de {senderName}: {message}");
    }

    public void ReceivePrivateMessage(string senderName, string message)
    {
        Console.WriteLine($"  → [{Name}] 🔒 Mensagem privada de {senderName}: {message}");
    }

    public void ReceiveNotification(string notification)
    {
        Console.WriteLine($"  → [{Name}] ℹ️ {notification}");
    }

    public void SetMuted(bool muted)
    {
        IsMuted = muted;
    }
}
