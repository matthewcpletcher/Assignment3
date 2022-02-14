using Xunit;
using System;
using System.Collections.Generic;
using System.Text;
using Assignment3.Models;

namespace Assignment3.Tests;

public class UnitTest1
{
    [Fact]

    public void Test1()
    {

        var Cust = new Customer()
        {
            Name = "john doe",
            Address = "2099 South lane",
            PhoneNum = "806-445-2227",
            Email = "john@yahoo.com" 
        };

        //Test would check the customer name for profanity

        Assert.NotEqual("Profanity", Cust.Name);

    }
}
