using System.Runtime.ConstrainedExecution;

public class User{
    public int UserId { get; set; }
    public string Login { get; set; }
    public string Salt { get; set; }
    public string Password { get; set; }
    
}