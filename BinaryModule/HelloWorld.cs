using System.Management.Automation;

namespace BinaryModule;

public class HelloWorld : Cmdlet
{
    [Parameter(Mandatory = true)]
    public string Name { get; set; } = null!;

    public string HelloMessage()
    {
        return $"Hello {Name}!";
    }

    protected override void ProcessRecord()
    {
        WriteObject(HelloMessage());
    }

}
