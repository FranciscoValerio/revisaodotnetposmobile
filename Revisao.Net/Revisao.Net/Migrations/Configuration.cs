namespace Revisao.Net.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Revisao.Net.Models.Contexto>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Revisao.Net.Models.Contexto context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Tarefas.AddOrUpdate(
              p => p.Titulo,
                new Tarefas { Titulo = "Minha Tarefa n� 1", Concluido = false, DataLimite = DateTime.Now, Username = "andre@lima.com.br", Descricao = "Descri��o da minha tarefa n� 1" },
                new Tarefas { Titulo = "Minha Tarefa n� 2", Concluido = false, DataLimite = DateTime.Now, Username = "andre@lima.com.br", Descricao = "Descri��o um pouco mais longa da minha tarefa n� 2" },
                new Tarefas { Titulo = "Minha Tarefa n� 3", Concluido = false, DataLimite = DateTime.Now, Username = "andre@lima.com.br", Descricao = "Descri��o bem mais longa, mas longa mesmo, ficando uma linha bem grande, da minha tarefa n� 3" },
                new Tarefas { Titulo = "Minha Tarefa n� 11", Concluido = false, DataLimite = DateTime.Now, Username = "andre@lima.com.br", Descricao = "Descri��o da minha tarefa n� 11" },
                new Tarefas { Titulo = "Minha Tarefa n� 21", Concluido = false, DataLimite = DateTime.Now, Username = "andre@lima.com.br", Descricao = "Descri��o um pouco mais longa da minha tarefa n� 21" },
                new Tarefas { Titulo = "Minha Tarefa n� 31", Concluido = false, DataLimite = DateTime.Now, Username = "andre@lima.com.br", Descricao = "Descri��o bem mais longa, mas longa mesmo, ficando uma linha bem grande, da minha tarefa n� 31" },
                new Tarefas { Titulo = "Minha Tarefa n� 12", Concluido = false, DataLimite = DateTime.Now, Username = "andre@lima.com.br", Descricao = "Descri��o da minha tarefa n� 12" },
                new Tarefas { Titulo = "Minha Tarefa n� 22", Concluido = false, DataLimite = DateTime.Now, Username = "andre@lima.com.br", Descricao = "Descri��o um pouco mais longa da minha tarefa n� 22" },
                new Tarefas { Titulo = "Minha Tarefa n� 32", Concluido = false, DataLimite = DateTime.Now, Username = "andre@lima.com.br", Descricao = "Descri��o bem mais longa, mas longa mesmo, ficando uma linha bem grande, da minha tarefa n� 32" },
                new Tarefas { Titulo = "Minha Tarefa n� 13", Concluido = false, DataLimite = DateTime.Now, Username = "andre@lima.com.br", Descricao = "Descri��o da minha tarefa n� 13" },
                new Tarefas { Titulo = "Minha Tarefa n� 23", Concluido = false, DataLimite = DateTime.Now, Username = "andre@lima.com.br", Descricao = "Descri��o um pouco mais longa da minha tarefa n� 23" },
                new Tarefas { Titulo = "Minha Tarefa n� 33", Concluido = false, DataLimite = DateTime.Now, Username = "andre@lima.com.br", Descricao = "Descri��o bem mais longa, mas longa mesmo, ficando uma linha bem grande, da minha tarefa n� 33" },
                new Tarefas { Titulo = "Minha Tarefa n� 14", Concluido = false, DataLimite = DateTime.Now, Username = "andre@lima.com.br", Descricao = "Descri��o da minha tarefa n� 14" },
                new Tarefas { Titulo = "Minha Tarefa n� 24", Concluido = false, DataLimite = DateTime.Now, Username = "andre@lima.com.br", Descricao = "Descri��o um pouco mais longa da minha tarefa n� 24" },
                new Tarefas { Titulo = "Minha Tarefa n� 34", Concluido = false, DataLimite = DateTime.Now, Username = "andre@lima.com.br", Descricao = "Descri��o bem mais longa, mas longa mesmo, ficando uma linha bem grande, da minha tarefa n� 34" },
                new Tarefas { Titulo = "Minha Tarefa n� 15", Concluido = false, DataLimite = DateTime.Now, Username = "andre@lima.com.br", Descricao = "Descri��o da minha tarefa n� 15" },
                new Tarefas { Titulo = "Minha Tarefa n� 25", Concluido = false, DataLimite = DateTime.Now, Username = "andre@lima.com.br", Descricao = "Descri��o um pouco mais longa da minha tarefa n� 25" },
                new Tarefas { Titulo = "Minha Tarefa n� 35", Concluido = false, DataLimite = DateTime.Now, Username = "andre@lima.com.br", Descricao = "Descri��o bem mais longa, mas longa mesmo, ficando uma linha bem grande, da minha tarefa n� 35" },
                new Tarefas { Titulo = "Minha Tarefa n� 16", Concluido = false, DataLimite = DateTime.Now, Username = "andre@lima.com.br", Descricao = "Descri��o da minha tarefa n� 16" },
                new Tarefas { Titulo = "Minha Tarefa n� 26", Concluido = false, DataLimite = DateTime.Now, Username = "andre@lima.com.br", Descricao = "Descri��o um pouco mais longa da minha tarefa n� 26" },
                new Tarefas { Titulo = "Minha Tarefa n� 36", Concluido = false, DataLimite = DateTime.Now, Username = "andre@lima.com.br", Descricao = "Descri��o bem mais longa, mas longa mesmo, ficando uma linha bem grande, da minha tarefa n� 36" }
            );

        }
    }
}
