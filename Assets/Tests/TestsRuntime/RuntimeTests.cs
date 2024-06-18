using NUnit.Framework;
using System.Collections;
using UnityEngine.TestTools;

public class RuntimeTests
{
    [UnityTest]
    public IEnumerator RuntimeTestsWithEnumeratorPasses()
    {
        yield return null;
        Assert.IsTrue(true);
    }
}
