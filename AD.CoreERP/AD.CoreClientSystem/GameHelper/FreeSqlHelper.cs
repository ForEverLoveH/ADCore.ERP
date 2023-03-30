using System;
using System.Configuration;
using System.Diagnostics;
using AD.CoreCommon;

namespace AD.CoreERP
{
    public class FreeSqlHelper
    {
       // private static string freesqlConnection = ConfigurationManager.AppSettings.Get("freeSqlConnection");
        static Lazy<IFreeSql> ServersqlLazy = new Lazy<IFreeSql>(() => new FreeSql.FreeSqlBuilder()
            .UseMonitorCommand(cmd => Trace.WriteLine($"Sql：{cmd.CommandText}"))//监听SQL语句,Trace在输出选项卡中查看
            .UseConnectionString(FreeSql.DataType.Sqlite, @"Data Source=./Data/ERPCore")
            .UseAutoSyncStructure(true) //自动同步实体结构到数据库，FreeSql不会扫描程序集，只有CRUD时才会生成表。
            .Build());
        public static IFreeSql Sqlite => ServersqlLazy.Value;
    }
}