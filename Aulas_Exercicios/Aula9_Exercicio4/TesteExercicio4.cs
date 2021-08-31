using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula9_Exercicio4
{
    class TesteExercicio4
    {
        static void Main(string[] args)
        {
            Postagem post0 = new Postagem();
            post0.Titulo = "Minha Primeira Viagem P/ Europa";
            post0.Data="24-05-2021";
            post0.Conteudo="Minha primeira viagem p/ a Europa foi um sabor!";
            post0.Visitas=3;

            Postagem post1 = new Postagem();
            post1.Titulo="Titulo2";
            post1.Data="24-05-2022";
            post1.Conteudo="Abobrinha";
            post1.Visitas=45;

            Postagem post2 = new Postagem();
            post2.Titulo="Cobri uma jaca e olha no que deu!";
            post2.Data="23-05-2021";
            post2.Conteudo="Apenas cobri uma jaca e nada ocorreu";
            post2.Visitas=3000;

            Usuario user1 = new Usuario();
            user1.Nome = "Vanessa";
            user1.Sobrenome = "Sardinha";
            user1.Senha = "VanessinhaLinda123";
            user1.Postagens[0] = post0;
            user1.Postagens[1] = post1;
            user1.Postagens[2] = post2;

            Console.WriteLine("Nome: " + user1.Nome);
            Console.WriteLine("Sobrenome: " + user1.Sobrenome);
            Console.WriteLine("Senha: " + user1.Senha);
            for (int i = 0; i < 3; ++i)
            {
                Console.WriteLine("Titulo: " + user1.Postagens[i].Titulo);
                Console.WriteLine("Data: " + user1.Postagens[i].Data);
                Console.WriteLine("Conteúdo: " + user1.Postagens[i].Conteudo);
                Console.WriteLine("Visitas: " + user1.Postagens[i].Visitas);
            }
        }
    }
}
