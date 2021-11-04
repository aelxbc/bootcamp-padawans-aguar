using System;
using System.Collections.Generic;

namespace LogicaAguar
{
    class Program
    {
        static void Main(string[] args)
        {
            //LISTA DE USUÁRIOS
            List<Usuario> lista = new List<Usuario>();

            lista.Add(new Usuario("Arthur Bicalho", "arthurbic@Hotmail.com", "Rua Ouro Preto 1410, Santo Agostinho", "Belo Horizonte", "Minas Gerais", " 04/11/2021 12:42PM", "Cano estourado"));

            foreach(Usuario item in lista)
            {
                Console.WriteLine(" Nome: " + item.Nome + "\n E-mail: " + item.Email + "\n Endereço: " + item.Endereco + "\n Cidade: " + item.Cidade + "\n Estado: " + item.Estado + "\n Data: " + item.Data);
            }

        }
    }
}
