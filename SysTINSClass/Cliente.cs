using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
/* id int(4) AI PK 
nome varchar(100) 
cpf char(11) 
telefone char(14) 
email varchar(60) 
data_nasc date 
data_cad timestamp 
ativo bit(1)*/

namespace SysTINSClass
{
    public class Cliente
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }
        public DateTime DataNasc { get; set; }
        public DateTime DataCad { get; set; }
        public List<Endereco> Endereco { get; set; }

        public Cliente()
        {
            Endereco = new();
        }

        public Cliente(string nome, string cpf, string telefone, string email, DateTime dataNasc)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            DataNasc = dataNasc;

        }

        public Cliente(int id, string nome, string telefone, DateTime dataNasc)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            DataNasc = dataNasc;

        }
        public void Inserir()
        {

            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_cliente_insert";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spcpf", Cpf);
            cmd.Parameters.AddWithValue("sptelefone", Telefone);
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.Parameters.AddWithValue("spdatanasc", DataNasc);
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public static Cliente ObterPorId(int id)
        {
            Cliente cliente = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from cliente where id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cliente.Add(new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2)
                    ));
            }

            return cliente;
        }

        public bool Atualizar()

        {
            bool resposta = false;
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("sptelefone", Telefone);
            cmd.Parameters.AddWithValue("spdatanasc", DataNasc);
            if (cmd.ExecuteNonQuery() > 0)
            {
                cmd.Connection.Close();
                resposta = true;
            }
            return resposta;
        }
    }
}


        
    


