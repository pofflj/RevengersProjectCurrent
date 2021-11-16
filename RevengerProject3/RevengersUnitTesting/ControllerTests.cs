﻿using NUnit.Framework;
using RevengerProject3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevengerProject3.Tests
{
    [TestFixture()]
    public class ControllerTests
    {
        private Controller _controller;
        private Player _player;

        [SetUp]
        public void SetUp()
        {
            _controller = new Controller();
            _player = new Player("test");
        }

        [Test()]
        public void ResearchResourceTest_InputIsPositive()
        {
            _player.WorkersAtResearchLab = 1;
            var result = _controller.ResearchResource(_player);
            Assert.IsTrue(result>0, "Number greater than 0");
        }
    }
}