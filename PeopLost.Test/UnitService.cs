using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PeopLost.Service.Members;
using PeopLost.Controllers;
using PeopLost.Data;

namespace PeopLost.Test
{
    [TestClass]
    public class UnitService
    {
        PeopLostObjectContext context = new PeopLostObjectContext();
        [TestMethod]
        public void Test_Member_Insert_Service()
        {
            //MemberService _service = new MemberService(;
        }
    }
}
