# 🧮 API Calculadora — ASP.NET Core Minimal API

Uma API simples e completa de calculadora desenvolvida em **ASP.NET Core Minimal API**, criada para fins de estudo e prática de desenvolvimento backend.  
A API permite executar diversas operações matemáticas diretamente pela URL.

---

## 🚀 **Operações Disponíveis**

### ➕ Adição  
`/calc/somar?x=10&y=20`

### ➖ Subtração  
`/calc/subtrair?x=30&y=12`

### ✖ Multiplicação  
`/calc/multiplicar?x=7&y=8`

### ➗ Divisão  
`/calc/dividir?x=100&y=5`

---

## ⚡ Operações Avançadas

### ⬆️ Potência  
`/calc/potencia?base=2&expoente=8`  
Retorno: `256`

### 🟦 Raiz Quadrada  
`/calc/raiz?x=81`  
Retorno: `9`

### 🟪 Raiz Cúbica  
`/calc/raizcubica?x=27`  
Retorno: `3`

### ➖ Valor Absoluto (módulo)  
`/calc/modulo?x=-35`  
Retorno: `35`

### 📉 Porcentagem (opcional — se quiser implementar)  
`/calc/percentual?valor=200&porcentagem=10`  
Retorno: `20`

---

## 🛠 Tecnologias

- .NET 8 / .NET 7
- ASP.NET Core Minimal API
- C#

---

## ▶️ Como Executar

1. Abra o terminal dentro da pasta do projeto.
2. Execute:

```bash
dotnet run
