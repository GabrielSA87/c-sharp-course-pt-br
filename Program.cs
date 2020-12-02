using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;
using CursoCSharp.Api;
using CursoCSharp.TopicosAvancados;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>()
            {
                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolacão - Fundamentos", Interpolacao.Executar},
                {"Notacão Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Numero - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritiméticos - Fundamentos", OperadoresAritimeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Logicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atribuicão - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operador Ternário - Fundamentos", OperadorTernario.Executar},
                
                // Estruturas de Controle
                {"Estrutura If - Estrutura de Controle", EstruturaIf.Executar},
                {"Estrutura If/Else - Estrutura de Controle", EstruturaIfElse.Executar},
                {"Estrutura If/Else/If - Estrutura de Controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estrutura de Controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estrutura de Controle", EstruturaWhile.Executar},
                {"Estrutura Do While - Estrutura de Controle", EstruturaDoWhile.Executar},
                {"Estrutura For - Estrutura de Controle", EstruturaFor.Executar},
                {"Estrutura ForEach - Estrutura de Controle", EstruturaForEach.Executar},
                {"Estrutura Break - Estrutura de Controle", EstruturaBreak.Executar},
                {"Estrutura Continue - Estrutura de Controle", EstruturaContinue.Executar},

                // Classes & Métodos
                {"Membros - Classes e Métodos", Membros.Executar},
                {"Construtores - Classes e Métodos", Construtores.Executar},
                {"Métodos com Retorno - Classes e Métodos", MetodosComRetorno.Executar},
                {"Métodos Estáticos - Classes e Métodos", MetodosEstaticos.Executar},
                {"Atributos Estáticos - Classes e Métodos", AtributosEstaticos.Executar},
                {"Desafio Atributo - Classes e Métodos", DesafioAtributo.Executar},
                {"Params - Classes e Métodos", Params.Executar},
                {"Parâmetros Nomeados - Classes e Métodos", ParametrosNomeados.Executar},
                {"Get Set - Classes e Métodos", GetSet.Executar},
                {"Props - Classes e Métodos", Props.Executar},
                {"Read Only - Classes e Métodos", ReadOnly.Executar},
                {"Enum - Classes e Métodos", ExemploEnum.Executar},
                {"Struct - Classes e Métodos", ExemploStruct.Executar},
                {"Struct vs Class - Classes e Métodos", StructVsClass.Executar},
                {"Valor vs Referencia - Classes e Métodos", ValorVsReferencia.Executar},
                {"Parâmetros por Referência - Classes e Métodos", ParamentrosPorReferencia.Executar},
                {"Parâmetros Padrão - Classes e Métodos", ParametroPadrao.Executar},

                // Colecões
                {"List - Colecões", ColecoesList.Executar},
                {"Array List - Colecões", ColecoesArrayList.Executar},
                {"Set - Colecões", ColecoesSet.Executar},
                {"Queue - Colecões", ColecoesQueue.Executar},
                {"Igualdade - Colecões", Igualdade.Executar},
                {"Stack - Colecões", ColecoesStack.Executar},
                {"Dictionary - Colecões", ColecoesDictionary.Executar},
                {"Array - Colecões", Colecoes.Array.Executar},
                
                // Orientacão a Objetos
                {"Heranca - OO", Heranca.Executar},
                {"Construtor This - OO", ConstrutorThis.Executar},
                {"Encapsulamento - OO", OO.Encapsulamento.Executar},
                {"Polimorfismo - OO", Polimorfismo.Executar},
                {"Abstract - OO", Abstract.Executar},
                {"Interface - OO", Interface.Executar},
                {"Sealed - OO", Sealed.Executar},

                // Métodos e Funcões
                {"Exemplo Lambda - Métodos e Funcões", ExemploLambda.Executar},
                {"Lambdas como Delegate - Métodos e Funcões", LambdasDelegate.Executar},
                {"Usando Delegates - Métodos e Funcões", UsandoDelegates.Executar},
                {"Delegates como Funcão Anonima - Métodos e Funcões", DelegateFuncAnonima.Executar},
                {"Delegates como Parametros - Métodos e Funcões", DelegatesComoParametros.Executar},
                {"Métodos de Extensão - Métodos e Funcões", MetodosDeExtensao.Executar},

                // Excecões
                {"Primeira Excecão - Excecões", PrimeiraExcecao.Executar},
                {"Excecões Personalizadas - Excecões", ExcecoesPersonalizadas.Executar},

                // Api
                {"Primeiro Arquivo - Usando API", PrimeiroArquivo.Executar},
                {"Lendo Arquivos - Usando API", LendoArquivos.Executar},
                {"Exemplo FileInfo - Usando API", ExemploFileInfo.Executar},
                {"Diretórios - Usando API", Diretorios.Executar},
                {"Exemplo DirectoryInfo - Usando API", ExemploDirectoryInfo.Executar},
                {"Exemplo Path - Usando API", ExemploPath.Executar},
                {"Exemplo DateTime - Usando API", ExemploDateTime.Executar},
                {"Exemplo TimeSpan - Usando API", ExemploTimeSpan.Executar},

                // Tópicos Avancados
                {"LINQ 1 - Tópicos Avancados", Linq1.Executar},
                {"LINQ 2 - Tópicos Avancados", Linq2.Executar},
                {"Nullables - Tópicos Avancados", Nullables.Executar},
                {"Dynamic - Tópicos Avancados", Dynamic.Executar},
                {"Genericos - Tópicos Avancados", Genericos.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}
