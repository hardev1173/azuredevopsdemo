using System;
using Xunit;
using CoreWebAPIAzure;
using CoreWebAPIAzure.Controllers;


namespace CoreWebAPIAzure.Test
{

    public class UnitTest1
    {
        ValuesController valuesController = new ValuesController();
        [Fact]
        public void Test1()
        {
            var test = valuesController.Get(1);
            Assert.Equal("hardev", test);
            
            
        }
    }
}
