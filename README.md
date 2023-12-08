# CRUD simples com banco de dados SQL.

Trata-se de um projeto de CRUD (Create, Read, Update, Delete) com banco de dados SQL e arquitetura MVC (Model-View-Controller).

## Como rodar o projeto:

### Dependências necessárias:

* [**Visual Studio**](https://visualstudio.microsoft.com/pt-br/)
* [**Docker**](https://www.docker.com/products/docker-desktop/)

### Ferramenta opcional
* Uma ferramenta de gerenciamento de banco de dados, como o [**SQL Management Studio**](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16) ou similares para consultar e interagir com os dados no banco de dados.

### Configuração do Ambiente:

1. Instale o Visual Studio e o Docker.

2. Execute o seguinte comando no terminal (Prompt de comando ou PowerShell) para criar um contêiner do SQL Server via Docker:

    ```shell
    docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=yourStrong(!)Password" -p 1433:1433 -d mcr.microsoft.com/mssql/server:2022-latest
    ```

    Certifique-se de escolher uma senha forte e substituí-la no campo "yourStrong(!)Password".

3. Clone este repositório usando o seguinte comando no terminal (Prompt de comando ou PowerShell):

    ```shell
    git clone https://github.com/AllyssonAntonucci/WebCRUDMVCSQL.git
    ```

4. Antes de compilar o projeto no Visual Studio, abra o arquivo `Program.cs` e substitua a linha de código:

    ```csharp
    builder.Configuration.GetConnectionString("ConexaoBancoSQL")
    ```

    pela sua string de conexão do banco SQL.

5. Pronto, o projeto está pronto para uso!

---

Para mais informações ou dúvidas, sinta-se à vontade para entrar em contato comigo:
* Email: allysson.antonucci.dev@gmail.com







