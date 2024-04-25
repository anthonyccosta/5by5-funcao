using System.ComponentModel;
using System.Data.Common;

int qtdlinhas = 2, qtdcolunas = 2;
float[,] matriz1 = new float[qtdlinhas, qtdcolunas];
float[,] matriz2 = new float[qtdlinhas, qtdcolunas];
//float[,] matriz3 = new float[qtdlinhas, qtdcolunas];

matriz1 = sortearMatriz(qtdlinhas, qtdcolunas);
matriz2 = sortearMatriz(qtdlinhas, qtdcolunas);


//CRIAR 3 FUNÇÕES - MENU DE SELEÇÃO COM MATRIZ (VOID)
//SORTEIO DA MATRIZ
//FUNÇÃO QUE INFORMA O TAMANHO DA CRIAÇÃO DA MATRIZ (PASSAR 2 INT, UM PARA LINHA E UM PARA COLUNA)

do
{
    Menu();
    int opcao = int.Parse(Console.ReadLine());
    switch (opcao)
    {
        //case 1:
        //    SomarMatriz(matriz1);
        //    break;
        //case 2:
        //    SubtraçãoMatriz(matriz1);
        //    break;
        case 1:
            imprimirMatriz(matriz1, "Matriz 1");
            break;
        case 2:
            imprimirMatriz(matriz2, "Matriz 2");
            break;
        case 3:
            operacoesMatrizes(matriz1, matriz2);
            break;
        case 4:
            matriz1 = sortearMatriz(qtdlinhas, qtdcolunas);
            matriz2 = sortearMatriz(qtdlinhas, qtdcolunas);
            Console.WriteLine("Matrizes sorteadas com sucesso!");
            break;
        case 5:
            informarTamanhoMatriz(qtdlinhas,qtdcolunas);
            matriz1 = new float[qtdlinhas, qtdcolunas];
            matriz2 = new float[qtdlinhas, qtdcolunas];
            Console.WriteLine("Tamanho da matriz atualizado com sucesso!");
            break;
        case 6:
            Console.WriteLine("Saindo do menu...");
            break;
        default:
            Console.WriteLine("OPCAO INVALIDA");
            break;
    }
    Console.ReadKey();
    Console.Clear();
} while (true);
void Menu()
{
    Console.WriteLine("\nMenu de Seleção:");
    Console.WriteLine("1. Mostrar Matriz 1");
    Console.WriteLine("2. Mostrar Matriz 2");
    Console.WriteLine("3. Operações Matemáticas");
    Console.WriteLine("4. Sortear Valores nas Matrizes");
    Console.WriteLine("5. Informar Novo Tamanho de Matriz");
    Console.WriteLine("6. Sair");
    Console.Write("Digite sua opção: ");
}
//CRIAÇÃO DA MATRIZ 1
void imprimirMatriz(float[,] matriz, string titulo) //TIPO / PARAMETRO / NOME DA FUNCAO
{
    // EXIBE A MATRIZ
    Console.WriteLine(titulo);
    for (int linha = 0; linha < qtdlinhas; linha++) // 
    {
        Console.WriteLine();
        for (int coluna = 0; coluna < qtdcolunas; coluna++) //
        {
            Console.Write(matriz[linha, coluna] + " "); //
        }
    }
}
float[,] sortearMatriz(int linhas, int colunas)
{
    float[,] matrizpreenchuda = new float[qtdlinhas, qtdcolunas];

    for (int linha = 0; linha < qtdlinhas; linha++) // 
    {
        for (int coluna = 0; coluna < qtdcolunas; coluna++) //
        {
            matrizpreenchuda[linha, coluna] = new Random().Next(0, 10);
        }
    }
    return matrizpreenchuda;
}

//imprimirMatriz(matriz1, "Matriz 1");
//imprimirMatriz(matriz2, "Matriz 2");
void informarTamanhoMatriz(int linhas, int colunas)
{
    do
    {
        Console.Write("Digite o número de linhas: ");
        linhas = int.Parse(Console.ReadLine());

        Console.Write("Digite o número de colunas: ");
        colunas = int.Parse(Console.ReadLine());

        if (linhas <= 0 || colunas <= 0)
        {
            Console.WriteLine("Dimensões inválidas. Tente novamente.");
        }
    } while (linhas <= 0 || colunas <= 0);
}

//Operações
void operacoesMatrizes(float[,] matriz1, float[,] matriz2)
{
    int opcaoOperacao;

    do
    {
        Console.WriteLine("\nOperações Matemáticas:");
        Console.WriteLine("1. Somar Matrizes");
        Console.WriteLine("2. Subtrair Matrizes");
        Console.WriteLine("3. Multiplicar Matrizes");
        Console.WriteLine("4. Dividir Matrizes");
        Console.WriteLine("5. Voltar ao Menu Principal");
        Console.Write("Digite sua opção: ");

        opcaoOperacao = int.Parse(Console.ReadLine());

        switch (opcaoOperacao)
        {
            case 1:
                SomarMatriz(matriz1, matriz2);
                break;
            case 2:
                SubtrairMatriz(matriz1, matriz2);
                break;
            case 3:
                MultiplicarMatriz(matriz1, matriz2);
                break;
            case 4:
                DivisaoMatriz(matriz1, matriz2);
                break;
            case 5:
                break; // Retorna ao menu principal
            default:
                Console.WriteLine("Opção inválida. Tente novamente.");
                break;
        }
    } while (opcaoOperacao != 5);
}
void SomarMatriz(float[,]m1, float[,]m2)
{
    float[,]matrizresultante = new float[qtdlinhas, qtdcolunas];

    for (int linha = 0; linha < qtdlinhas; linha++)
    {
        for (int coluna = 0;coluna < qtdcolunas;coluna++)
        {
            matrizresultante[linha, coluna] = m1[linha,coluna] + m2[linha,coluna];
        }
    }
    imprimirMatriz(matrizresultante, "Resultado da Matriz Somada: ");
}

void SubtrairMatriz(float[,] m1, float[,] m2)
{
    float[,] matrizresultante = new float[qtdlinhas, qtdcolunas];

    for (int linha = 0; linha < qtdlinhas; linha++)
    {
        for (int coluna = 0; coluna < qtdcolunas; coluna++)
        {
            matrizresultante[linha, coluna] = m1[linha, coluna] - m2[linha, coluna];
        }
    }
    imprimirMatriz(matrizresultante, "Resultado da Matriz Subtração: ");
}

void MultiplicarMatriz(float[,] m1, float[,] m2)
{
    float[,] matrizresultante = new float[qtdlinhas, qtdcolunas];

    for (int linha = 0; linha < qtdlinhas; linha++)
    {
        for (int coluna = 0; coluna < qtdcolunas; coluna++)
        {
            matrizresultante[linha, coluna] = m1[linha, coluna] * m2[linha, coluna];
        }
    }
    imprimirMatriz(matrizresultante, "Resultado da Matriz Multiplicação: ");
}

void DivisaoMatriz(float[,] m1, float[,] m2)
{
    float[,] matrizresultante = new float[qtdlinhas, qtdcolunas];

    for (int linha = 0; linha < qtdlinhas; linha++)
    {
        for (int coluna = 0; coluna < qtdcolunas; coluna++)
        {
            if (matriz2[linha, coluna] != 0)
            {
                matrizresultante[linha, coluna] = m1[linha, coluna] / m2[linha, coluna];
            }
            else
            {
                matrizresultante[linha, coluna] = float.NaN;
                Console.WriteLine("ERRO: Divisão por 0 na posição (" + linha + ", " + coluna + ")");
            }
            matrizresultante[linha, coluna] = m1[linha, coluna] / m2[linha, coluna];
        }
    }
    imprimirMatriz(matrizresultante, "Resultado da Matriz Dividida: ");
}