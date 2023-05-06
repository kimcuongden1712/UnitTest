using CleverCore.Utilities.Dtos;
using System;
using Xunit;

namespace CleverCore.Utilities.Test.Dtos
{
    public class PagedResultTest
    {
        [Fact]
        public void Constructor_CreateObject_NotNullObj()
        {
            var pagedResult = new PagedResult<Array>();
            Assert.NotNull(pagedResult);
        }

        [Fact]
        public void Constructor_CreateObject_WithResultNotNull()
        {
            var result = new PagedResult<Array>();
            Assert.NotNull(result.Results);
        }
    }
}