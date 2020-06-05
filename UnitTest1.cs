using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject3
{
    [TestClass]
    public class UnitTest1
    {
        lab4.firetruck firetruck = new lab4.firetruck();
        lab4.police police = new lab4.police();
        lab4.taxi taxi = new lab4.taxi();
        [TestMethod]
        public void addPass()
        {
          
            firetruck.addPass(new lab4.fireman());
            firetruck.addPass(new lab4.fireman());


            police.addPass(new lab4.policeman());
            police.addPass(new lab4.policeman());

            taxi.addPass(new lab4.policeman());
            taxi.addPass(new lab4.policeman());

        }


        [TestMethod]
        public void delTese()
        {
            firetruck.delPass(0);
        }


        [TestMethod]
        public void exception()
        {
            firetruck.addPass(new lab4.policeman());
        }
    }
}
