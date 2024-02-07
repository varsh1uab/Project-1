namespace api.Entities;

public class AppUser
{
    public int Id {get; set; } //property
    public string UserName { get; set;} //property
public int Age {get; set; }
    public byte[] PasswordHash {get; set;}
    public byte[] PasswordSalt {get; set;}
}
