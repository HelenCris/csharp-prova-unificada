# AVALIAÇÃO UNIFICADA C# - INTERMEDIARIO E AVANÇADO 1 E 2

### 🛠 TECNOLOGIAS

As seguintes ferramentas foram usadas na construção do projeto:

- [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
- [Entity Framework](https://entityframework-extensions.net/efcore-pomelo-mysql-provider)

### 🎲 Rodando a aplicação

```bash
# Clone este repositório
$ git clone <https://github.com/HelenCris/csharp-prova-unificada>

# Acesse a pasta do projeto no terminal/cmd
$ cd csharp-prova-unificada

# Execute o seguinte comando para executar o migrations da aplicação

$ dotnet ef migrations add CriandoEstruturaInicialDoBanco
$ dotnet ef database update

# Para executar a aplicação 
$ dotnet watch run

```

### CRIE UM SISTEMA DE BIBLIOTECA QUE CONTENHA OS SEGUINTES REQUISITOS:

- [x] UM BANCO DE DADOS;
- [x] UMA TELA DE LOGIN;
- [x] CÓDIGOS COMENTADOS;
- [x] INFORMAÇÕES COMO: NOME DO LIVRO, AUTOR, ANO DE PUBLICAÇÃO
E DESCRIÇÃO;
- [x] CRUD – CADASTRO, BUSCA, EDIÇÃO E EXCLUSÃO DE CADASTROS; 