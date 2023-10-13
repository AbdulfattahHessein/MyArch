using AutoMapper;
using MyArch.Core.Interfaces.Bases;

namespace MyArch.BusinessLogic.Intefaces
{
    public interface IAppService
    {
        IUnitOfWork UnitOfWork { get; set; }
        IMapper Mapper { get; set; }
        void Dispose();
    }
}