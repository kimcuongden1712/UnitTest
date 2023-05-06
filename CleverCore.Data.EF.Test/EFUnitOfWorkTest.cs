using CleverCore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CleverCore.Data.EF.Test
{
    public class EFUnitOfWorkTest
    {
        private readonly AppDbContext _appDbContext;
        public EFUnitOfWorkTest()
        {
            _appDbContext = ContextFactory.Create();
        }

        [Fact]
        public void Commit_Success()
        {
            var efRepository = new EfRepository<Function, string>(_appDbContext);
            var unitOfWork = new EFUnitOfWork(_appDbContext);
            efRepository.Add(
                new Function()
                {
                    Id = "USER",
                    Name = "test",
                    Status = Enums.Status.Active,
                    URL = "/test",
                    SortOrder = 1,
                    IconCss = ""
                });
            unitOfWork.Commit();
            var functions = efRepository.FindAll().ToList();
            Assert.Single(functions);
        }
    }
}
