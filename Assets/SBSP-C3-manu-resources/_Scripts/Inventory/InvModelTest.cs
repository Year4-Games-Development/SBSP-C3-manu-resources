using System.Collections;
using UnityEngine.TestTools;
using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class InvModelTest
    {
        [Test]
        public void TestSlotNames()
        {
            var go = new GameObject("ItemImage");
            Assert.AreEqual("ItemImage", go.name);
        }
    }
}


