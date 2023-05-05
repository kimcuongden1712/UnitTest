using Xunit;

namespace CleverCore.Data.EF.Test
{
    public class AppDbContextTest
    {
        [Fact]
        public void Constructor_CreateInMemoryDb_Success()
        {
            var context = ContextFactorycs.Create();
            Assert.True(context.Database.EnsureCreated());
        }
    }
}