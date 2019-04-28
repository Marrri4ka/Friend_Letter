namespace FriendLetter.Models
{
  public class LetterVariable // class
  {
    private string _recipient;
    private string _sender;
    private string _location;// Field

    public string GetRecipient() // method
    {
      return _recipient;

    }

    public void SetRecipient (string newRecipient)
    {
      _recipient = newRecipient;
    }

    public string GetSender()
    {
      return _sender;
    }

    public void SetSender (string newSender)
    {
      _sender =newSender;
    }

    public string GetLocation()
    {
      return _location;
    }

    public void SetLocation (string newLocation)
    {
      _location = newLocation;
    }
  }
}