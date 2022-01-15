using Autofac;
using MentoriaFinanceiro.Application;
using MentoriaFinanceiro.Application.Interfaces;
using MentoriaFinanceiro.Application.Interfaces.Mappers;
using MentoriaFinanceiro.Application.Mappers;
using MentoriaFinanceiro.Domain.Core.Interfaces.Repositories;
using MentoriaFinanceiro.Domain.Core.Interfaces.Services;
using MentoriaFinanceiro.Domain.Services;
using MentoriaFinanceiro.Infrastructure.Data.Repositories;

namespace MentoriaFinanceiro.Infrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC
            builder.RegisterType<ApplicationServicePessoa>().As<IApplicationServicePessoa>();
            builder.RegisterType<ApplicationServiceConta>().As<IApplicationServiceConta>();
            builder.RegisterType<ApplicationServiceMovimentacao>().As<IApplicationServiceMovimentacao>();
            builder.RegisterType<ApplicationServiceOperacao>().As<IApplicationServiceOperacao>();
            builder.RegisterType<ServicePessoa>().As<IServicePessoa>();
            builder.RegisterType<ServiceConta>().As<IServiceConta>();
            builder.RegisterType<ServiceMovimentacao>().As<IServiceMovimentacao>();
            builder.RegisterType<ServiceOperacao>().As<IServiceOperacao>();
            builder.RegisterType<RepositoryPessoa>().As<IRepositoryPessoa>();
            builder.RegisterType<RepositoryConta>().As<IRepositoryConta>();
            builder.RegisterType<RepositoryMovimentacao>().As<IRepositoryMovimentacao>();
            builder.RegisterType<RepositoryOperacao>().As<IRepositoryOperacao>();
            builder.RegisterType<MapperPessoa>().As<IMapperPessoa>();
            builder.RegisterType<MapperConta>().As<IMapperConta>();
            builder.RegisterType<MapperMovimentacao>().As<IMapperMovimentacao>();
            builder.RegisterType<MapperOperacao>().As<IMapperOperacao>();
           
            #endregion
        }
    }
}
