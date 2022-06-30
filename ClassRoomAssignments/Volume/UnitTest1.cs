namespace Volume;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        Using a=new Using();
        double result=a.Volume(10.2,20.5);
        Assert.AreEqual(6398.459999999999,result);
        

    }

    [TestMethod]
    public void TestMethod2()
    {
        Using b=new Using();
        Double result1=b.Volume(4.2,5.2);
        Assert.AreEqual(275.1840000000001,result1);
    }
}