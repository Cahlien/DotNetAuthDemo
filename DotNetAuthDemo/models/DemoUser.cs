using Microsoft.AspNetCore.Identity;

namespace DotNetAuthDemo.models;

public class DemoUser(string demoProperty) : IdentityUser
{
    public DemoUser()
        : this("DefaultProperty")
    {}
    
    public string DemoProperty { get; set; } = demoProperty;
}