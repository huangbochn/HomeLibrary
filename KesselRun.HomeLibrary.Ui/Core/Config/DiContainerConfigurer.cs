﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using AutoMapper;
using KesselRun.HomeLibrary.Common.Contracts;
using KesselRun.HomeLibrary.EF;
using KesselRun.HomeLibrary.EF.Repositories.Factories;
using KesselRun.HomeLibrary.Mapper.Mappers;
using KesselRun.HomeLibrary.Service;
using KesselRun.HomeLibrary.Service.Infrastructure;
using KesselRun.HomeLibrary.Service.Infrastructure.Queries;
using KesselRun.HomeLibrary.UiModel.Models;
using Microsoft.Practices.Unity;
using WinFormsMvp.Binder;
using WinFormsMvp.Unity;

namespace KesselRun.HomeLibrary.Ui.Core.Config
{
    public class DiContainerConfigurer : IBootstrapper
    {
        private readonly IUnityContainer _container = new UnityContainer();

        public DiContainerConfigurer()
        {

        }

        public void Configure()
        {
            PresenterBinder.Factory = new UnityPresenterFactory(_container);

            _container.RegisterType<INavigator, Navigator>(new TransientLifetimeManager());

            _container.RegisterInstance<IMappingEngine>(AutoMapper.Mapper.Engine)
                .RegisterType<IUniversalMapper, UniversalMapper>(new TransientLifetimeManager());

            _container.RegisterType<IRepositoryProvider, RepositoryProvider>(
                new TransientLifetimeManager(),
                new InjectionMember[] {new InjectionConstructor(new RepositoryFactories())}
                );

            _container.RegisterType<IUnitOfWork, UnitOfWork>(new TransientLifetimeManager());
            _container.RegisterType<ILendingsService, LendingsService>(new TransientLifetimeManager());
            //_container.RegisterType
            //    <IQueryHandler<GetLendingsPagedSortedQuery, IList<Lending>>, GetLendingsPagedSortedQueryHandler>(
            //        new TransientLifetimeManager()
            //        );

            // Go look in all assemblies and register all implementa-
            // tions of ICommandHandler<T> by their closed interface:
            
            AutoRegisterType(typeof(IQueryHandler<,>)); // Register IQueryHandlers

            // Decorate each returned ICommandHandler<T> object with an
            // TransactionCommandHandlerDecorator<T>.
        }


        /// <summary>
        /// From http://stackoverflow.com/a/13859582/540156, as updated by me
        /// </summary>
        /// <param name="type"></param>
        private void AutoRegisterType(Type type)
        {
            var assembly = Assembly.Load("KesselRun.HomeLibrary.Service");

            var handlerRegistrations =
                from implementation in assembly.GetExportedTypes()
                where !implementation.IsAbstract
                where !implementation.ContainsGenericParameters
                let services =
                    from iface in implementation.GetInterfaces()
                    where iface.IsGenericType
                    where iface.GetGenericTypeDefinition() == type
                          
                    select iface
                from service in services
                select new {service, implementation};

            foreach (var registration in handlerRegistrations)
            {
                _container.RegisterType(
                    registration.service,
                    registration.implementation,
                    type.Name + "Registration");
            }

            _container.RegisterType<IQueryProcessor, QueryProcessor>(new ContainerControlledLifetimeManager());
        }
    }
}