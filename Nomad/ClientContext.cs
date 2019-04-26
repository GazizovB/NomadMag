namespace Nomad
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ClientContext : DbContext
    {
        // Контекст настроен для использования строки подключения "ClientContext" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "Nomad.ClientContext" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "ClientContext" 
        // в файле конфигурации приложения.
        public ClientContext()
            : base("name=ClientContext")
        {
            Database.SetInitializer(new DataInitializers());

        }

        public DbSet<Client> Clients { get; set; }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}