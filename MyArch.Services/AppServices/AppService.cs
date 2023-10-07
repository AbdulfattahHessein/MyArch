using AutoMapper;
using MyArch.Core.Interfaces.Bases;

namespace MyArch.Services.AppServices
{
    public class AppService
    {
        #region Vars
        protected IUnitOfWork UnitOfWork { get; set; }
        protected readonly IMapper Mapper;
        #endregion

        #region CTR
        public AppService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            UnitOfWork = unitOfWork;
            Mapper = mapper;
        }

        public void Dispose()
        {
            UnitOfWork.Dispose();
        }
        #endregion
    }
}
