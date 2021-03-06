using System;
/// <summary>
///Assembly
/// </summary>

public class AttributeTargetsAssembly
{
    public static int Main()
    {
        AttributeTargetsAssembly AttributeTargetsAssembly = new AttributeTargetsAssembly();

        TestLibrary.TestFramework.BeginTestCase("AttributeTargetsAssembly");
        if (AttributeTargetsAssembly.RunTests())
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("PASS");
            return 100;
        }
        else
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("FAIL");
            return 0;
        }
    }
    public bool RunTests()
    {
        bool retVal = true;
       TestLibrary.TestFramework.LogInformation("[Positive]");
        retVal = PosTest1() && retVal;
      
        return retVal;
    }
    // Returns true if the expected result is right
    // Returns false if the expected result is wrong

    public bool PosTest1()
    {
        bool retVal = true;
        TestLibrary.TestFramework.BeginScenario("PosTest1: Verify the AttributeTargets.Assembly value is 0x0001. ");
        try
        {
            int expectValue = 0x0001;
            if ((int)AttributeTargets.Assembly != expectValue)
            {
                TestLibrary.TestFramework.LogError("001.1", " AttributeTargets.Assembly should return 0x0001.");
                retVal = false;
            }
           
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("001.0", "Unexpected exception: " + e);
            retVal = false;
        }
       
        return retVal;
    }
   
}

