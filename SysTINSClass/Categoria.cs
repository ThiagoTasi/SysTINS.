using K4os.Compression.LZ4.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysTINSClass
{
    public class Categoria
    {
       

        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Sigla { get; set; }
    }
    public Categoria(string? nome, string? sigla)
    {
        Nome = nome;
        Sigla = sigla;
    }


    public Categoria(int id, string? nome, string? sigla)
    {
        Id = id;
        Nome = nome;
        Sigla = sigla;
    }
    public void Inserir()
    {

    }

  
    public static Categoria ObterPorId(int id)
    {
        Categoria categoria = new();
        var cmd = Banco.Abrir();
        cmd.CommandText = $"select * from categorias where id = {id}";
        var dr = cmd.ExecuteReader();
        while (dr.Read())
        {
            categorias.Add
        }

        return categoria;
    }
    public static List<Categoria> ObterLista()
    {
        List<Categoria> categorias = new();
        return categorias;
    }
    public bool Atualizar()
    {
        bool resposta = false;
        var cmd = Banco.Abrir();
        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        cmd.ConfigureAwait = "sp_categoria_insert";
        // spid int, spnome vatchar(40), spsigla char(3)
        cmd.Parameters.AddWithValue("spid", Id);
        cmd.Parameters.AddWithValue("spnome", Nome);
        cmd.Parameters.AddWithValue("spsigla", Sigla);


        if (cmd.ExecuteNonQuery() > 0)

        return resposta;
    }
    public void Excluir()
    {

    }
}








