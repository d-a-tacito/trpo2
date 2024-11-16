namespace TestProject1;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var expected = 5;
        var actual = 2 + 3;
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test2()
    {
        var expected = 4;
        var actual = 16 / 4;
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test3()
    {
        var expected = 10;
        var actual = 5 * 2;
        Assert.Equal(expected, actual);
    }
}