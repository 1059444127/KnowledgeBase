﻿//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace KnowledgeBase.Add.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ZhiShiKuEntities : DbContext
    {
        public ZhiShiKuEntities()
            : base("name=ZhiShiKuEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Dept> Dept { get; set; }
        public DbSet<Modules> Modules { get; set; }
        public DbSet<UserInfo> UserInfo { get; set; }
        public DbSet<Test> Test { get; set; }
        public DbSet<UserInfoSelect> UserInfoSelect { get; set; }
        public DbSet<BigCodeName> BigCodeName { get; set; }
        public DbSet<DiseaseCodeName> DiseaseCodeName { get; set; }
        public DbSet<SmallCodeName> SmallCodeName { get; set; }
        public DbSet<DiseaseInfo> DiseaseInfo { get; set; }
        public DbSet<ModulesContents> ModulesContents { get; set; }
    }
}
