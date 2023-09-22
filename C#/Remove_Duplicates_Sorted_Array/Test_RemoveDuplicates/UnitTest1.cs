using Remove_Duplicates_Sorted_Array;

namespace Test_RemoveDuplicates;

[TestFixture]
public class Tests
{
    [Test]
    public void TestRemoveDuplicates()
    {
        int[] inputArray = { 1, 1, 2, 2, 3, 4, 4, 5 };
        var expectedResult = 5;

        var actualResult = Program.RemoveDuplicates(inputArray);

        Assert.AreEqual(expectedResult, actualResult);
    }
}