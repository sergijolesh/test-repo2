using System;
using NUnit.Framework;

[TestFixture]
public class SerialClientTests
{
    [Test]
    public void TestClientMessageFormat()
    {
        string mockInput = "Hello, Server";
        string expectedOutput = "Modified: " + mockInput;

        // Simulate response from "server"
        string response = SerialClient.ProcessMessage(mockInput); // hypothetical function
        Assert.AreEqual(expectedOutput, response);
    }
}
