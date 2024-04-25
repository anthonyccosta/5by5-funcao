using System.ComponentModel;
using System.Data.Common;

int qtdlinhas = 2, qtdcolunas = 2;
float[,] matriz1 = new float[qtdlinhas, qtdcolunas];
float[,] matriz2 = new float[qtdlinhas, qtdcolunas];
float[,] matriz3 = new float[qtdlinhas, qtdcolunas];

//CRIAR 3 FUNÇÕES - MENU DE SELEÇÃO COM MATRIZ (VOID)
//SORTEIO DA MATRIZ
//FUNÇÃO QUE INFORMA O TAMANHO DA CRIAÇÃO DA MATRIZ (PASSAR 2 INT, UM PARA LINHA E UM PARA COLUNA)

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

do
{
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
        int opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                SomarMatriz(matriz1, matriz2);
                break;
            case 2:
                SubtraçãoMatriz(matriz1, matriz2);
                break;
            case 3:
                MultiplicacaoMatriz(matriz1, matriz2);
                break;
            case 4:
                DivisaoMatriz(matriz1, matriz2);
                break;
            default:
                Console.WriteLine("OPCAO INVALIDA");
                break;
        }
    }
    Console.ReadKey();
    Console.Clear();
} while (true);

//Operações
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

void SubtraçãoMatriz(float[,] m1, float[,] m2)
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

void MultiplicacaoMatriz(float[,] m1, float[,] m2)
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

float[,] sortearMatriz()
{
    float[,] matrizpreenchuda = new float[qtdlinhas, qtdcolunas];

    for (int linha = 0; linha < qtdlinhas; linha++) // 
    {
        for (int coluna = 0; coluna < qtdcolunas; coluna++) //
        {
            matrizpreenchuda[linha, coluna] = new Random().Next(0,10);
        }
    }
    return matrizpreenchuda;
}

matriz1 = sortearMatriz();

imprimirMatriz(matriz1, "Matriz 1");
imprimirMatriz(matriz2, "Matriz 1");