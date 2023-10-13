using AutoMapper;
using MyArch.BusinessLogic.Intefaces;
using MyArch.Core.Interfaces.Bases;

namespace MyArch.BusinessLogic.AppServices
{
    public class AppService : IAppService
    {
        public IUnitOfWork UnitOfWork { get; set; }
        public IMapper Mapper { get; set; }
        public AppService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            UnitOfWork = unitOfWork;
            Mapper = mapper;
        }

        public void Dispose()
        {
            UnitOfWork.Dispose();
        }

    }
}
