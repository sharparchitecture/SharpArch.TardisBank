namespace Suteki.TardisBank.Infrastructure.NHibernateMaps
{
    using FluentNHibernate.Automapping;
    using FluentNHibernate.Automapping.Alterations;

    using Suteki.TardisBank.Model;

    public class AccountMap : IAutoMappingOverride<Account>
    {
        public void Override(AutoMapping<Account> mapping)
        {
            mapping.HasMany(a => a.PaymentSchedules).Cascade.AllDeleteOrphan().Inverse();
        }
    }
}