API Pessoas 2 — CRUD Minimal API em .NET

Este projeto é uma API simples criada em .NET 8 utilizando Minimal APIs, demonstrando um CRUD básico de pessoas utilizando um “banco” em memória.

Ideal para iniciantes que desejam aprender:

Estrutura de uma API REST

Rotas GET, POST, PUT e DELETE

Minimal APIs

Record types

Organização de projeto



---------------------------------------------------------------------------------------------------------------------------------------------------------




Tecnologias utilizadas

.NET 8

Minimal APIs

C#

Lista em memória (sem banco de dados)




---------------------------------------------------------------------------------------------------------------------------------------------------------

Endpoints da API
🔹 GET /pessoas

Retorna todas as pessoas.

🔹 GET /pessoas/{id}

Retorna uma pessoa específica por ID.

🔹 POST /pessoas

Cria uma nova pessoa.

Exemplo do corpo:


{
  "nome": "Carlos",
  "idade": 30
}


🔹 PUT /pessoas/{id}

Atualiza nome e idade.

🔹 DELETE /pessoas/{id}

Remove uma pessoa da lista.




---------------------------------------------------------------------------------------------------------------------------------------------------------


Como rodar o projeto

Na pasta do projeto, execute:

dotnet run


A API subirá em:

https://localhost:xxxx
http://localhost:xxxx


---------------------------------------------------------------------------------------------------------------------------------------------------------


Sobre o projeto

Este projeto faz parte do meu aprendizado em C# e .NET.
Representa minha primeira API criada com Minimal APIs.



---------------------------------------------------------------------------------------------------------------------------------------------------------

Objetivo

Servir como projeto de portfólio e base para APIs maiores, como:

Projeto de ONG

Sistema de voluntários

Aplicativos simples

Integrações futuras com bancos reais










