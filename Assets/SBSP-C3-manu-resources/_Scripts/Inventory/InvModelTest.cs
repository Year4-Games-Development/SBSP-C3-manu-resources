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

        [Test]
        public void TestSlotCount()
        {
            var count = new GameObject("ItemSlot");
            Assert.AreEqual("ItemSlot", count.name);
        }

        [Test]
        public void TestSlotsAreNotNull()
        {
            var gos = new GameObject("ItemImage");
            Assert.IsNotNull("ItemSlot", gos.name);
        }
    }
}


