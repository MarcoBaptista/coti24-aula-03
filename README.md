# Sistema de Cadastro de Clientes e Endereços

Este é um projeto de Console em C#.NET destinado ao cadastro de clientes e seus respectivos endereços. O sistema consulta endereços utilizando a API ViaCep e armazena os dados dos clientes e endereços em um banco de dados SQL Server, utilizando Dapper para a comunicação com o banco de dados.

## Tecnologias e Ferramentas Utilizadas

- **Visual Studio 2022**: Ambiente de desenvolvimento integrado (IDE) utilizado para o desenvolvimento do projeto.
- **.NET 8**: A versão do framework .NET utilizada.
- **ViaCep**: API para consulta de endereços pelo CEP. Mais informações podem ser encontradas em [ViaCep](https://viacep.com.br/).
- **Dapper**: Uma biblioteca ORM leve para .NET que simplifica o acesso ao banco de dados. Mais detalhes estão disponíveis em [Dapper](https://github.com/DapperLib/Dapper).
- **SQL Server**: Sistema de gerenciamento de banco de dados relacional utilizado para armazenar os dados dos clientes e endereços.

## Configuração Inicial

Para executar este projeto, algumas configurações iniciais são necessárias:

1. **Banco de Dados SQL Server**: É preciso ter uma instância do SQL Server rodando localmente ou em um servidor acessível. 

2. **Criação do Banco de Dados**: Execute o script `Script.sql` disponível no diretório do projeto para criar as tabelas necessárias no banco de dados.

3. **Configuração da Connection String**: Na classe `ClienteRepository`, altere a string de conexão (`ConnectionString`) para corresponder às configurações do seu banco de dados SQL Server local.

## Executando o Projeto

Para executar o projeto, siga os passos abaixo:

1. Abra o projeto no **Visual Studio 2022**.
2. Certifique-se de que todas as dependências foram restauradas corretamente.
3. Execute o projeto pressionando `F5` ou clicando em **Debug > Start Debugging**.

## Contribuições

Contribuições são sempre bem-vindas! Se você tem alguma sugestão para melhorar este projeto, sinta-se à vontade para criar um pull request ou abrir uma issue.
