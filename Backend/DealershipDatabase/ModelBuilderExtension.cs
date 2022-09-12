using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DealershipDatabase
{
    public static class ModelBuilderExtension
    {
        public static void ApplyConfigurationsFromAssembly(this ModelBuilder builder, Assembly assembly)
        {
            var configurations = assembly.DefinedTypes.Where(t =>
                t.ImplementedInterfaces.Any(i =>
                   i.IsGenericType &&
                   i.Name.Equals(typeof(IEntityTypeConfiguration<>).Name,
                          StringComparison.InvariantCultureIgnoreCase)
                 ) &&
                 t.IsClass &&
                 !t.IsAbstract &&
                 !t.IsNested)
                 .ToList();
            foreach (var configuration in configurations)
            {
                var entityType = configuration.BaseType.GenericTypeArguments.SingleOrDefault(t => t.IsClass);

                var applyConfigMethods = typeof(ModelBuilder).GetMethods().Where(m => m.Name.Equals("ApplyConfiguration") && m.IsGenericMethod);
                var applyConfigMethod = applyConfigMethods.Single(m => m.GetParameters().Any(p => p.ParameterType.Name.Equals(typeof(IEntityTypeConfiguration<>).Name)));

                var applyConfigGenericMethod = applyConfigMethod.MakeGenericMethod(entityType);

                applyConfigGenericMethod.Invoke(builder,
                             new object[] { Activator.CreateInstance(configuration) });
            }
        }
    }
}
