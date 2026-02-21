using DesignPatternChallenge.Mediator;
using DesignPatternChallenge.Models;

namespace DesignPatternChallenge.Services;

public class ChatService
{
    private readonly IChatMediator _mediator;

    public ChatService(IChatMediator mediator)
    {
        _mediator = mediator;
    }

    public void SendMessage(ChatUser sender, string message)
    {
        _mediator.SendMessage(message, sender);
    }

    public void SendPrivateMessage(ChatUser sender, ChatUser recipient, string message)
    {
        _mediator.SendPrivateMessage(message, sender, recipient);
    }

    public void MuteUser(ChatUser byUser, ChatUser target)
    {
        _mediator.MuteUser(target, byUser);
    }

    public void JoinGroup(ChatUser user)
    {
        user.JoinGroup();
    }

    public void LeaveGroup(ChatUser user)
    {
        user.LeaveGroup();
    }
}