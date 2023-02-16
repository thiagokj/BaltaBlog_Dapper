# Csharp | Blog com Dapper

## Projeto para estudos e revisão de conceitos em Csharp.

Requisitos:

```csharp
dotnet add package microsoft.Data.SqlClient --version 2.1.0
dotnet add package dapper --version 2.0.90
dotnet add package Dapper.Contrib
dotnet add package System.Configuration.ConfigurationManager // opcional
```

Boas práticas:

1. Por convenção e organização, criar pastas com nome no plural (**Models**).
   Na criação de entidades (classes), o nome deve ser no singular (**User**).

1. Utilizando o **Dapper.Contrib**, faça sempre o vinculo das entidades por meio de anotações.

```Csharp
using Dapper.Contrib.Extensions;

namespace Blog
{
    [Table("[User]")] // Exemplo de anotação
    public class User{....}
}
```

1. **Repository Pattern** | Crie repositórios para organizar o acesso à dados na aplicação.
   Para cada entidade crie um repositório. Dessa forma, reduzimos a necessidade
   de alterações no código em diferentes lugares.

   Aqui os métodos estáticos para conexão deixam de ser utilizados, uma vez que esses métodos
   são carregados na memória, ao iniciar a aplicação.

   Crie um Repository genérico e faça a **herança** dos métodos e propriedades nos repositórios especialistas.
