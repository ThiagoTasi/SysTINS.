using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
 id int(11) AI PK 
cliente_id int(4) 
cep char(8) 
logradouro varchar(100) 
numero varchar(40) 
complemento varchar(60) 
bairro varchar(60) 
cidade varchar(60) 
uf char(2) 
tipo_endereco char(3)*/

namespace SysTINSClass
{
   public class Endereco
    {
        public int Id { get; set; }
        public Cliente Cliente{ get; set; }
        public string? Cep { get; set; }
        public string? Logradouro { get; set; }
        public string? Numero { get; set; }
        public string? Complemento { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
        public string? UF { get; set; }
        public string?TipoEndereco { get; set; }

        public Endereco()
        {
        
        }

        public Endereco(int id, Cliente cliente, string? cep, string? logradouro, string? numero, string? complemento, string? bairro, string? cidade, string? uF, string? tipoEndereco)
        {
            Id = id;
            Cliente = cliente;
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            UF = uF;
            TipoEndereco = tipoEndereco;
        }

        public Endereco(int id, Cliente cliente, string? cep, string? logradouro, string? numero, string? complemento, string? bairro, string? cidade, string? uF, string? tipoEndereco)
        {
            Id = id;
            Cliente = cliente;
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            UF = uF;
            TipoEndereco = tipoEndereco;
        }

        public Endereco(int id)
        {
            Id = id;
        }

            public void Inserir()
        {

            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_endereco_insert";
            cmd.Parameters.AddWithValue("spcliente_id", Cliente_Id);
            cmd.Parameters.AddWithValue("spcep", Cep);
            cmd.Parameters.AddWithValue("splogradouro", Logradouro);
            cmd.Parameters.AddWithValue("spnumero", Numero);
            cmd.Parameters.AddWithValue("spcomplemento", Complemento);
            cmd.Parameters.AddWithValue("spbairro", Bairro);
            cmd.Parameters.AddWithValue("spcidade", Cidade);
            cmd.Parameters.AddWithValue("spuf", UF);
            cmd.Parameters.AddWithValue("sptipo_endereco", Tipo_Endereco);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public static Endereco ObterPorId(int id)
        {
            Endereco endereco = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from endereco where id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                endereco.Add(new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetString(5),
                    dr.GetString(6),
                    dr.GetString(7),
                    dr.GetString(8)
                    ));
            }

            return endereco;
        }

        public bool Atualizar()

        {
            bool resposta = false;
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_endereco_update";
            cmd.Parameters.AddWithValue("spcliente_id", Cliente_Id);
            cmd.Parameters.AddWithValue("spcep", Cep);
            cmd.Parameters.AddWithValue("splogradouro", Logradouro);
            cmd.Parameters.AddWithValue("spnumero", Numero);
            cmd.Parameters.AddWithValue("spcomplemento", Complemento);
            cmd.Parameters.AddWithValue("spbairro", Bairro);
            cmd.Parameters.AddWithValue("spcidade", Cidade);
            cmd.Parameters.AddWithValue("spuf", UF);
            cmd.Parameters.AddWithValue("sptipo_endereco", Tipo_Endereco);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            ;
            if (cmd.ExecuteNonQuery() > 0)
            {
                cmd.Connection.Close();
                resposta = true;
            }
            return resposta;

            // efetuar login
            public void delete ()
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
}
    }
}


        
    



    }
}
