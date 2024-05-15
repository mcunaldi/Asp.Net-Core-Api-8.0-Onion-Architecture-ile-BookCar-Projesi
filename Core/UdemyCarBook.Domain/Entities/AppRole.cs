namespace UdemyCarBook.Domain.Entities;
public class AppRole
{
    public int AppRoleID { get; set; }
    public string AppRoleName { get; set; }
    public List<AppUser> AppUsers { get; set; }
}
