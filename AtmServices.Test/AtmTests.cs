namespace AtmServices.Test;

using AtmServices;

public class AtmTests

{
    Atm testAtm;
    int initialBalance = 100;

    public AtmTests() {
        testAtm = new Atm(initialBalance);
    }

    [Fact]
    public void Test_Withdraw()
    {
        var result = testAtm.withdraw(25);
        Assert.True(result);
        Assert.Equal(75,testAtm.getBalance());
    }

    [Fact]
    public void Test_Withdraw_Overdraw()
    {
        var result = testAtm.withdraw(110);
        Assert.False(result);
    }

        [Fact]
    public void Test_Deposit()
    {
        var result = testAtm.deposit(10);
        Assert.True(result);
        Assert.Equal(110,testAtm.getBalance());
    }

        [Fact]
    public void Test_Deposit_Negative()
    {
        var result = testAtm.deposit(-10);
        Assert.False(result);
    }

}