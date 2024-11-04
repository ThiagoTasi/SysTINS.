using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysTINSClass
{
    internal class Categoria
    {
        public string? Nome { get; set; }
        public string? Sigla { get; set; }

        public Categoria() { } // método construtor (new)

        public Categoria(string? nome, string? sigla)
        {
            Nome = nome;
            Sigla = sigla;
        }

        // inserir
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"insert categoria (nome, sigla) values ('{Nome}','{Sigla}') ";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        // consultar por id
        public static Categoria ObterPorId(int id)
        {
            Categoria categoria = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select id, nome, sigla from categoria where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                //categoria.Nome = dr.GetString(0);
                //categoria.Sigla= dr.GetString(1);
                categoria = new(dr.GetString(0), dr.GetString(1));
            }
            cmd.Connection.Close();
            return categoria;
        }
        // obter lista
        public static List<Categoria> ObterLista()
        {
            List<Categoria> lista = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from categoria order by nome asc";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new(dr.GetString(0), dr.GetString(1)));
            }
            cmd.Connection.Close();
            return lista;
        }
        // atualizar
        public bool Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"update categoria set nome = '{Nome}', sigla = '{Sigla}'";
            return cmd.ExecuteNonQuery() > 0 ? true : false;
        }
        // deletar nivel
        public void Excluir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = $"delete from categoria";
            cmd.ExecuteNonQuery();
        }
    }
}
