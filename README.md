# CalculatesInterest

API REST em ASP.NET Core para cálculo de juros compostos, com documentação via Swagger e testes unitários da camada de serviços.

## Endpoints

| Método | Rota | Parâmetros (query) | Retorno |
|---|---|---|---|
| GET | `/TaxaDeJuros` | `taxaDeJuros` (double) | A taxa informada, ou vazio se for negativa |
| GET | `/CalculaJuros` | `valorInicial` (double), `taxaDeJuros` (double), `meses` (int) | Valor final com juros compostos, arredondado em 2 casas |
| GET | `/ShowMeTheCode` | — | URL deste repositório |

O cálculo usa a fórmula de juros compostos:

```
valorFinal = valorInicial × (1 + taxaDeJuros) ^ meses
```

A taxa é informada em decimal (`0.01` = 1% ao mês).

### Exemplo

```
GET /CalculaJuros?valorInicial=100&taxaDeJuros=0.01&meses=5
→ 105.1
```

## Estrutura

```
CalculatesInterest/                 API (controllers, interfaces e services)
CalculatesInterest.ServiceTests/    Testes unitários dos services
CalculatesInterest.sln              Solução
```

A API segue uma separação simples em camadas: os controllers recebem a requisição e delegam para os services, que são injetados via interface no `Startup.cs`.

## Como rodar

Pré-requisito: [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet/5.0).

```bash
dotnet run --project CalculatesInterest
```

A documentação Swagger fica disponível em `https://localhost:5001/swagger`.

## Testes

```bash
dotnet test
```

## Tecnologias

- ASP.NET Core 5
- Swashbuckle (Swagger / OpenAPI)
- xUnit
