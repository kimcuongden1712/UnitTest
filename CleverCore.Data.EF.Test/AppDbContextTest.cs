using Xunit;

namespace CleverCore.Data.EF.Test
{
    public class AppDbContextTest
    {
        [Fact]
        public void Constructor_CreateInMemoryDb_Success()
        {
            var context = ContextFactory.Create();
            Assert.NotNull(context);
        }

        [Fact]
        public void Constructor_CreateInMemoryDb_CreateDatabaseSuccess()
        {
            var context = ContextFactory.Create();
            Assert.True(context.Database.EnsureCreated());
        }
    }
}