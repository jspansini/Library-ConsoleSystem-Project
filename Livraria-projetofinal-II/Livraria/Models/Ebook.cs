﻿using Livraria.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Livraria.Models.Enum;

namespace Livraria.Models
{
    internal class Ebook : IProduto
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }
        public int AnoPublicacao { get; set; }
        public string ISBN { get; set; }
        public double Preco { get; set; }
        public TipoProduto tipoProduto { get; set; } = TipoProduto.Ebook;

        public Ebook(int id, string titulo, string autor, string editora, int anoPublicacao, string isbn, double preco)
        {
            Id = id;
            Titulo = titulo;
            Autor = autor;
            Editora = editora;
            AnoPublicacao = anoPublicacao;
            ISBN = isbn;
            Preco = preco;
        }

        public void EnviarLivro(string endereco)
        {
            Console.WriteLine($"Ebook enviado para: {endereco}.");
        }
    }
}
