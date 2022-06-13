// See https://aka.ms/new-console-template for more information
using System;

namespace meuscode
{

class Program
    {
        static void Main (string[] args)
        {
            PessoaJuridica pj = new PessoaJuridica();
            PessoaJuridica novapj = new PessoaJuridica();

            Endereco end = new Endereco();
            end.logradouro = "Rua X";
            end.numero = 327;
            end.complemento= "Perto de Neiltom";
            end.enderecoComercial=false;

            novapj.endereco = end;
            novapj.cnpj = "02802308900001";
            novapjh.RazaoSocial = "Pessoa Juridica";
            pj.ValidarCNPJ(novapj.cnpj){
                System.Console.WriteLine("CNPJ Valido");
            }else{
                System.Console.WriteLine("CNPJ Invalido");
            }

            PessoaFisica novapf = new PessoaFisica();
            novapf.endereco = end;
            end.logradouro = "Rua X";
            novapf.cpf= "01234567891";
            novapf.nome= "Corleone";
            novapf.dataNascimento= new DateTime(1994/05/11);

           
            Console.WriteLine($"rua:{novapf.endereco.logradouro},{novapf.endereco.numero}");
            Console.WriteLine($"Nome:{novapf.nome}");

            PessoaFisica pf = new PessoaFisica();

            Console.WriteLine (pf.ValidarDataNascimento(pf.dataNascimento));

            bool idadeValida = pf.ValidarDataNascimento(novapf.dataNascimento);
            Console.WriteLine(idadeValida);

            if (idadeValida==true){
                System.Console.WriteLine($"Cadastro Aprovado");

            } else{;
                System.Console.WriteLine($"Cadastro Reprovado");

            }
        }

    }
}
