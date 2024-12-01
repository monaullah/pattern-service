using System.Linq;
using PatternService.Controllers;
using Xunit;

namespace PatternService.Tests.Controllers;

public class CustomersControllerTest
{
    //arrange
    private FirstController _firstController = new();
    
    [Fact]
    public void Get_Custmers()
    {
        //act
        var result = _firstController.Get();

        //assert
        Assert.NotNull(result);
        Assert.Equal(4, result.Count());
    }

    [Fact]
    public void Get_Customer_By_Id()
    {
        //act
        var result = _firstController.Get(1);
        
        //assert
        Assert.Equal("Customer 2", result.Item2);
    }
}