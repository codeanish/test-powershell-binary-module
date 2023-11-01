namespace BinaryModule.Tests;

public class HelloWorldTests
{
    [Fact]
    public void HelloMessage_NullName()
    {
        var helloWorld = new HelloWorld();
        // helloWorld.Name = null!;
        Assert.Equal("Hello !", helloWorld.HelloMessage());
    }

    [Fact]
    public void HelloMessage_EmptyName()
    {
        var helloWorld = new HelloWorld();
        helloWorld.Name = "";
        Assert.Equal("Hello !", helloWorld.HelloMessage());
    }

    [Fact]
    public void HelloMessage_WithName()
    {
        var helloWorld = new HelloWorld();
        helloWorld.Name = "World";
        Assert.Equal("Hello World!", helloWorld.HelloMessage());
    }
}