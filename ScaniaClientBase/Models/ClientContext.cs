using System.Data.Entity;

namespace ScaniaClientBase.Models
{
    // SSBCVP : Faça seu contexto herdar de DbContext para que você possa utilizar o Entity Framework
    public class ClienteContext : DbContext
    {
        // Aqui você liga a sua classe Cliente com um novo objeto Clientes que será utilizado pelo Entity Framework
        // para o acesso ao banco de dados local, no caso um mini Sql Server
        public DbSet<Cliente> Clientes { get; set; }

        // Aqui você determina o nome do seu banco caso o mesmo não exista ainda, é o que chamamos de code first
        public ClienteContext() : base("ScaniaClientBase")
        { }

    }
}