﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula.Models
{
    public class Pessoa
    {

        public Pessoa() { }
        public Pessoa(string nome,string sobrenome)
        { 
            Nome = nome;
            SobreNome = sobrenome; 
        }

        private string _nome;
        public string Nome
        {
            get => _nome.ToUpper();

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value;
            }
        }
        private int _idade;
        public int Idade
        {

            get => _idade;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que zero");
                }
                _idade = value;
            }
        }
        public string SobreNome { get; set; }


        public string NomeCompleto => $"{Nome} {SobreNome}".ToUpper();

        public void Apresentar()
        {
            Console.WriteLine($"Nome:{NomeCompleto}, Idade: {Idade}");
        }
    }
}