﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sapataria.Modelo
{
    public class Cliente : Pessoa
    {
        public Morada Morada { get; set; }

        /// <summary>
        /// Construtor básico sem parâmetros
        /// </summary>
        public Cliente()
        {

        }

        /// <summary>
        /// Construtor que espera nome e nif
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="numeroIdentificacaoFiscal"></param>
        public Cliente(string nome, string numeroIdentificacaoFiscal)
        {
            this.Nome = nome;
            this.NumeroIdentificacaoFiscal = numeroIdentificacaoFiscal;
        }

        /// <summary>
        /// Construtor que permite passar o nome do cliente
        /// </summary>
        /// <param name="nome"></param>
        public Cliente(string nome)
        {
            this.Nome = nome;
        }

        public override int ObterIdade()
        {
            var idade = (int)((DateTime.Now.Subtract(DataNascimento)).Days * 365.25);
            return idade;
        }


        public static List<Cliente> operator +(Cliente cliente, Cliente cliente2)
        {
            var resultado = new List<Cliente>();
            resultado.Add(cliente);
            resultado.Add(cliente2);
            return resultado;
        }


        public static List<Cliente> operator +(List<Cliente> clientes, Cliente cliente2)
        {
            clientes.Add(cliente2);
            return clientes;
        }
    }
}
