using FluentNHibernate.Mapping;
using zad_3___bis.Model;

namespace zad_3___bis.Mapping
{
    class DepartmentMap : ClassMap<Department>
    {
        public DepartmentMap()
        {
            Table("Department");
            LazyLoad();

            Id(x => x.DepartmentID)
              .Column("DepartmentID")
              .CustomType("Int32")
              .Access.Property()
              .CustomSqlType("INTEGER")
              .Not.Nullable()
              .GeneratedBy.Identity();

            Map(x => x.Name)
                .CustomType("AnsiString")
                .Length(50)
                .Column("Name")
                .Access.Property()
                .Generated.Never();

            Map(x => x.Budget)
                .Column("Budget")
                .CustomType("Int32")
                .Access.Property()
                .Generated.Never()
                .CustomSqlType("INTEGER");

            Map(x => x.StartDate)
                .CustomSqlType("datetime2")
                .Not.Nullable();

            Map(x => x.Administrator)
                .CustomType("AnsiString")
                .Length(50)
                .Column("Administrator")
                .Access.Property()
                .Generated.Never();

            HasMany(x => x.Coursession).KeyColumn("DeptId").Inverse().Cascade.All();
        }
    }
}
