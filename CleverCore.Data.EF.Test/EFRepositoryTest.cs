using CleverCore.Data.Entities;
using CleverCore.Infrastructure.Interfaces;
using System.Linq;
using Xunit;

namespace CleverCore.Data.EF.Test
{
    public class EFRepositoryTest
    {
        private readonly AppDbContext _appDbContext;
        private readonly IUnitOfWork _unitOfWork;

        public EFRepositoryTest()
        {
            _appDbContext = ContextFactory.Create();
            _appDbContext.Database.EnsureCreated();
            _unitOfWork = new EFUnitOfWork(_appDbContext);
        }

        [Fact]
        public void ConstructorShouldSuccessWhenCreateEfRepository()
        {
            EfRepository<Function, string> repository = new EfRepository<Function, string>(_appDbContext);
            Assert.NotNull(repository);
        }

        [Fact]
        public void Add_InsertNewRecord_Success()
        {
            EfRepository<Function, string> efRepository = new EfRepository<Function, string>(_appDbContext);
            efRepository.Add(new Function()
            {
                Id = "USER",
                Name = "test",
                Status = Enums.Status.Active,
                URL = "/test",
                SortOrder = 1,
                IconCss = ""
            });
            _unitOfWork.Commit();
            Function function = efRepository.FindById("USER");
            Assert.NotNull(function);
        }

        [Fact]
        public void Add_FindAll_Success()
        {
            EfRepository<Function, string> efRepository = new EfRepository<Function, string>(_appDbContext);
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
            efRepository.Add(
            new Function()
            {
                Id = "ROLE",
                Name = "test",
                Status = Enums.Status.Active,
                URL = "/test",
                SortOrder = 2,
                IconCss = ""
            });
            efRepository.Add(
            new Function()
            {
                Id = "EX",
                Name = "test",
                Status = Enums.Status.Active,
                URL = "/test",
                SortOrder = 1,
                IconCss = ""
            });
            _unitOfWork.Commit();
            var functions = efRepository.FindAll().ToList();
            Assert.Equal(3, functions.Count);
        }

        [Fact]
        public void Add_FindById_Success()
        {
            EfRepository<Function, string> efRepository = new EfRepository<Function, string>(_appDbContext);
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
            efRepository.Add(
            new Function()
            {
                Id = "ROLE",
                Name = "test",
                Status = Enums.Status.Active,
                URL = "/test",
                SortOrder = 2,
                IconCss = ""
            });
            _unitOfWork.Commit();
            var functions = efRepository.FindById("USER");
            Assert.Equal("USER", functions.Id);
        }
    }
}