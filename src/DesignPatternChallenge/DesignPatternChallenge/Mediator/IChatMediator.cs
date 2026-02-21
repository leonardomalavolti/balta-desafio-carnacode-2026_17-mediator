using DesignPatternChallenge.Models;

namespace DesignPatternChallenge.Mediator;

public interface IChatMediator
{
    void RegisterUser(ChatUser user);
    void SendMessage(string message, ChatUser sender);
    void SendPrivateMessage(string message, ChatUser sender, ChatUser recipient);
    void NotifyUserEntered(ChatUser user);
    void NotifyUserLeft(ChatUser user);
    void MuteUser(ChatUser target, ChatUser byUser);
}
