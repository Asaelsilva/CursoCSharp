using System;
using System.Collections.Generic;
using CursoCSharp.Fundamentos;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.OrientacaoAObjetos;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos", Comentarios.Executar},
                {"Variaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferencia - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Numeros - Fundamentos", FormatandoNumeros.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritmédicos - Fundamentos", OperadoresAritmedicos.Executar},
                {"Operadores Relacionais - Fundamentos", OperacoesRelacionais.Executar},
                {"Operadores Logico - Fundamentos", OperadoresLogico.Executar},

                //Classes e Metodos

                {"Membros - Classes e Metodos", Membros.Executar},
                {"Construtores - Classes e Metodos", Construtores.Executar},
                {"Metodos com Retorno - Classes e Metodos", MetodosComRetorno.Executar},
                {"Metodos Estaticos - Classes e Metodos", MetodosEstaticos.Executar},
                {"Atributos Estaticos - Classes e Metodos", AtributosEstaticos.Executar},
                {"Desafio Atributo - Classes e Metodos", DesafioAtributo.Executar},
                {"Params - Classes e Metodos", Params.Executar},
                {"Parammetros Nomeados - Classes e Metodos", ParametrosNomeados.Executar},
                {"Get Set - Classes e Metodos", GetSet.Executar},
                {"Props - Classes e Metodos", Props.Executar},
                {"Readonly - Classes e Metodos", Readonly.Executar},
                {"Enum - Classes e Metodos", Enums.Executar},
                {"Structs - Classes e Metodos", ExemploStructs.Executar},
                {"Struct vs Classes - Classes e Metodos", StructVsClasses.Executar},
                {"Valor vs Referencia - Classes e Metodos", ValorVsReferencia.Executar},
                {"Parametros por Referencia - Classes e Metodos", ParametrosPorReferencia.Executar},
                {"Parametro com valor Padrão - Classes e Metodos", ParametroPadrao.Executar},

                //Orientaçaao a Objetos
                {"Herança - Orientaçaao a Objetos", Heranca.Executar},
                {"Construtor This - Orientaçaao a Objetos", ConstrutorThis.Executar},
                {"Encapsulamento - Orientaçaao a Objetos", OrientacaoAObjetos.Encapsulamento.Executar},
                {"Polimorfismo - Orientaçaao a Objetos", Polimorfismo.Executar},
                {"Abstract - Orientaçaao a Objetos", Abstract.Executar},
                {"Interface - Orientaçaao a Objetos", Interface.Executar},
                {"Sealed - Orientaçaao a Objetos", Sealed.Executar},

                //Metodos e Funções
                {"Lambd - Metodos & Funções ", ExemploLambda.Executar},
                {"Lambda Delegate - Metodos & Funções ", LambdasDelegate.Executar},
                {"Usando Delegate - Metodos & Funções ", UsandoDelegate.Executar},
                {"Delegates com funções anonimas - Metodos & Funções ", DelegateFuncAnnonima.Executar},
                {"Delegates como Parametros - Metodos & Funções ", DelegatesComoParametros.Executar},
                {"Metodos de Extençãos - Metodos & Funções ", MetodosDeExtensao.Executar},

                // Exceções 
                {"Primeira Excecao - Exceções ", PrimeiraExcecao.Executar},
                {"Excecoes Personalizadas - Exceções ", ExcecoesPersonalizadas.Executar},

            });

            central.SelecionarEExecutar();
        }
    }
}