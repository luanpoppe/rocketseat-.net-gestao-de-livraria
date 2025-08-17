# Gestão de Livraria

Este projeto é uma API RESTful desenvolvida como parte de um exercício da formação de C# da plataforma Rocketseat. O objetivo principal é criar um sistema de gerenciamento de livros para uma livraria online, permitindo operações CRUD (Criar, Visualizar, Editar e Excluir) de livros. O desenvolvimento seguiu princípios de boas práticas de programação, como a separação de responsabilidades e a clareza do código, visando a manutenibilidade e escalabilidade.

## Tecnologias Utilizadas

- **C#**
- **.NET 9**
- **ASP.NET Core**

## Funcionalidades

A API oferece os seguintes endpoints para gerenciar livros:

- **Criar Livro:** Adiciona um novo livro ao sistema.
- **Visualizar Livros:** Retorna uma lista de todos os livros cadastrados.
- **Editar Livro:** Atualiza as informações de um livro existente.
- **Excluir Livro:** Remove um livro do sistema.

## Persistência de Dados

Atualmente, os dados dos livros são armazenados em memória (`BooksTemporaryDB.cs`). Isso significa que todos os dados são voláteis e serão perdidos ao reiniciar a aplicação. Esta abordagem foi adotada para focar na lógica de negócio da API e nos conceitos de desenvolvimento web com ASP.NET Core, com a intenção de integrar uma solução de banco de dados persistente em futuras iterações.

## Estrutura de Dados (Livro)

Cada livro no sistema possui os seguintes campos:

- `Id` (Guid): Um identificador único para cada livro.
- `Title` (string): O título do livro.
- `Author` (string): O autor do livro.
- `Genre` (enum): O gênero do livro. Os gêneros possíveis são:
  - `Fiction` (Ficção)
  - `NonFiction` (Não Ficção)
  - `Romance` (Romance)
  - `Mystery` (Mistério)
- `Price` (double): O preço do livro.
- `InStock` (double): A quantidade de livros em estoque.

## Como Rodar o Projeto

Para configurar e rodar este projeto localmente, siga os passos abaixo:

1.  **Clone o repositório:**

    ```bash
    git clone https://github.com/luanpoppe/rocketseat-.net-gestao-de-livraria.git
    cd rocketseat-.net-gestao-de-livraria
    ```

2.  **Navegue até o diretório do projeto:**

    ```bash
    cd GestaoDeLivraria
    ```

3.  **Restaure as dependências:**

    ```bash
    dotnet restore
    ```

4.  **Execute a aplicação:**
    ```bash
    dotnet run
    ```
    A API estará disponível em `https://localhost:7281` (HTTPS) e `http://localhost:5149` (HTTP).

## Endpoints da API

A API utiliza o Swagger/OpenAPI para documentação interativa dos endpoints. Você pode acessá-la em `https://localhost:7281/swagger` (ou a porta HTTPS configurada) após rodar a aplicação.

### Exemplos de Requisições:

#### 1. Criar um Livro (POST)

`POST /books`

**Body (JSON):**

```json
{
  "title": "O Senhor dos Anéis",
  "author": "J.R.R. Tolkien",
  "genre": "Fiction",
  "price": 49.9,
  "inStock": 100
}
```

#### 2. Visualizar Todos os Livros (GET)

`GET /books`

#### 3. Editar Informações de um Livro (PUT)

`PUT /books/{id}`

**Body (JSON):**

```json
{
  "title": "O Senhor dos Anéis - Edição Especial",
  "author": "J.R.R. Tolkien",
  "genre": "Fiction",
  "price": 79.9,
  "inStock": 95
}
```

#### 4. Excluir um Livro (DELETE)

`DELETE /books/{id}`

---

**Observação:** A API retorna `status codes` HTTP apropriados para cada situação (e.g., 200 OK, 201 Created, 400 Bad Request, 404 Not Found, 204 No Content).

## Entrega

Após concluir o desafio, o link do código no GitHub deve ser enviado para a plataforma. É encorajado compartilhar a experiência e o aprendizado no LinkedIn.
