using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysTINSClass
{
    public class Produto
    {
        public int Id { get; set; }
        public string? CodBarras { get; set; }
        public string? Descricao { get; set; }
        public string? ValorUnit { get; set; }
        public double? UnidadeVenda { get; set; }
        public Categoria Categoria { get; set;  }
        public double? EstoqueMinimo { get; set; }
        public string? ClasseDesconto { get; set; }
        public DateTime? DataCad { get; set; }



        public Produto() // método construtor (new)
        {
            Categoria = new();
        }



        public Produto( string? codBarras, string? descricao, string? valorUnit, double? unidadeVenda, Categoria categoria, double? estoqueMinimo, string? classeDesconto, DateTime? dataCad)
        {
            CodBarras = codBarras;
            Descricao = descricao;
            ValorUnit = valorUnit;
            UnidadeVenda = unidadeVenda;
            Categoria = categoria;
            EstoqueMinimo = estoqueMinimo;
            ClasseDesconto = classeDesconto;
            DataCad = dataCad;
        }

        public Produto(string? codBarras, string? descricao, string? valorUnit, double? unidadeVenda, Categoria categoria, double? estoqueMinimo, string? classeDesconto)
        {
            CodBarras = codBarras;
            Descricao = descricao;
            ValorUnit = valorUnit;
            UnidadeVenda = unidadeVenda;
            Categoria = categoria;
            EstoqueMinimo = estoqueMinimo;
            ClasseDesconto = classeDesconto;
        }

        public Produto(int id, string? codBarras, string? descricao, string? valorUnit, double? unidadeVenda, Categoria categoria, double? estoqueMinimo, string? classeDesconto, DateTime? dataCad)
        {
            Id = id;
            CodBarras = codBarras;
            Descricao = descricao;
            ValorUnit = valorUnit;
            UnidadeVenda = unidadeVenda;
            Categoria = categoria;
            EstoqueMinimo = estoqueMinimo;
            ClasseDesconto = classeDesconto;
            DataCad = dataCad;
        }
            // inserir 
            public void Inserir()
            {
                var cmd = Banco.Abrir();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "sp_usuario_insert";
                cmd.Parameters.AddWithValue("spcod_barras", CodigoBarras);
                cmd.Parameters.AddWithValue("spdescricao", Descricao);
                cmd.Parameters.AddWithValue("spvalor_unit", ValorUnit);
                cmd.Parameters.AddWithValue("spunidade_venda", UnidadeVenda);
                cmd.Parameters.AddWithValue("spcategoria_id", Categoria.Id);
                cmd.Parameters.AddWithValue("spestoque_minimo", EstoqueMinimo);
                cmd.Parameters.AddWithValue("spclasse_desconto", Desconto);

            var dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Id = dr.GetInt32(0);
                }
                cmd.Connection.Close();
            }
            // ObterPorId
            public static Usuario ObterPorId(int id)
            {
                Usuario usuario = new();
                var cmd = Banco.Abrir();
                cmd.CommandText = $"select * from usuarios where id = {id}";
                var dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    usuario = new(
                            dr.GetInt32(0),
                            dr.GetString(1),
                            dr.GetString(2),
                            dr.GetString(3),
                            Nivel.ObterPorId(dr.GetInt32(4)),
                            dr.GetBoolean(5)
                        );
                }
                return usuario;
            }
            public static List<Usuario> ObterLista()
            {
                List<Usuario> lista = new();
                var cmd = Banco.Abrir();
                cmd.CommandText = $"select * from usuarios order by nome asc";
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new(
                            dr.GetInt32(0),
                            dr.GetString(1),
                            dr.GetString(2),
                            dr.GetString(3),
                            Nivel.ObterPorId(dr.GetInt32(4)),
                            dr.GetBoolean(5)
                        )
                    );
                }
                return lista;
            }
            public bool Atualizar()
            {
                var cmd = Banco.Abrir();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_usuario_altera";
                cmd.Parameters.AddWithValue("spid", Id);
                cmd.Parameters.AddWithValue("spnome", Nome);
                cmd.Parameters.AddWithValue("spsenha", Senha);
                cmd.Parameters.AddWithValue("spnivel", Nivel.Id);
                return cmd.ExecuteNonQuery() > 0 ? true : false;
            }
            // efetuar login
            public static Usuario EfetuarLogin(string email, string senha)
            {
                Usuario usuario = new();
                var cmd = Banco.Abrir();
                cmd.CommandText = $"select * from usuarios where email = '{email}' and senha = md5('{senha}') and ativo = 1";
                var dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    usuario = new(
                            dr.GetInt32(0),
                            dr.GetString(1),
                            dr.GetString(2),
                            dr.GetString(3),
                            Nivel.ObterPorId(dr.GetInt32(4)),
                            dr.GetBoolean(5)
                        );
                }
                return usuario;
            }

        }
    }
public Produtos(int id, string? codBarras, string? descricao, string? valorUnit, double? unidadeVenda, Categoria categoria, double? estoqueMinimo, string? classeDesconto, DateTime? dataCad)
        {
            Id = id;
            CodBarras = codBarras;
            Descricao = descricao;
            ValorUnit = valorUnit;
            UnidadeVenda = unidadeVenda;
            Categoria = categoria;
            EstoqueMinimo = estoqueMinimo;
            ClasseDesconto = classeDesconto;
            DataCad = dataCad;
        }
    }
//id int(4) AI PK 
//nome varchar(60) 
//email varchar(60) 
//senha varchar(32) 
//nivel_id int(11) 
//ativo bit(1)

//CREATE DEFINER =`root`@`localhost` PROCEDURE `sp_usuario_altera`(
//-- parâmetros da procedure
//spid int, spnome varchar(60), spsenha varchar(32), spnivel int)
//begin
//	update usuarios 
//	set nome = spnome, senha = md5(spsenha), nivel_id = spnivel where id = spid;
//end$$

//CREATE DEFINER =`root`@`localhost` PROCEDURE `sp_usuario_insert`(
//-- parâmetros da procedure
//spnome varchar(60), spemail varchar(60), spsenha varchar(32), spnivel int)
//begin
//	insert into usuarios 
//	values (0, spnome, spemail, md5(spsenha), spnivel, default);
//select* from usuarios where id = last_insert_id();
//end$$




