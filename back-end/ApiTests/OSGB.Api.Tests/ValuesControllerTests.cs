﻿using System.Collections.Generic;
using Xunit;

namespace OSGB.Api.Tests
{
    public class ValuesControllerTests
    {
        [Fact]
        public void ShouldReturnStringArray()
        {
            var controller = new Controllers.ValuesController();

            //Given
            var expected = new string[] { "value1", "value2" };
            //When
            var actual = controller.Get();
            //Then
            Assert.Equal(expected, actual);
        }
    }
}
