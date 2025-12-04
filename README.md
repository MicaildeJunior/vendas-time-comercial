📄 README – Vendas Time Comercial
🧾 Vendas Time Comercial – API de Cálculo de Comissões

Projeto desenvolvido para demonstrar domínio em C#, ASP.NET Core, Entity Framework Core, SQL Server, arquitetura em camadas e boas práticas de código.

A API realiza o cálculo de comissões de vendedores com base em registros de vendas armazenados em banco de dados.

🚀 Tecnologias Utilizadas

.NET 8

ASP.NET Core Web API

Entity Framework Core (Code First)

SQL Server

Swagger (OpenAPI)

Arquitetura em camadas:

VendasTimeComercial.Api

VendasTimeComercial.Application

VendasTimeComercial.Domain

VendasTimeComercial.Infrastructure

VendasTimeComercial.Shared

📌 Regras de Comissão

Cada venda possui um valor e sua comissão é calculada da seguinte forma:

Valor da Venda	Comissão
Menor que R$ 100,00	0%
Entre R$ 100,00 e R$ 499,99	1%
A partir de R$ 500,00	5%

A API soma todas as vendas por vendedor e retorna:

Total vendido

Comissão total

Nome do vendedor

📦 Endpoints
📍 GET /api/comissoes

Retorna o cálculo completo das comissões de todos os vendedores.

Exemplo de resposta:
[
  {
    "vendedor": "João Silva",
    "totalVendido": 10754.70,
    "comissaoTotal": 495.68
  },
  {
    "vendedor": "Maria Souza",
    "totalVendido": 9874.30,
    "comissaoTotal": 465.95
  }
]

🗄️ Banco de Dados

A solução utiliza Entity Framework Core com migrations armazenadas no projeto Infrastructure.

Para facilitar o teste, o repositório inclui uma pasta /Scripts, contendo:

✔ criar-banco.sql

Cria o banco de dados e a tabela Vendas.

✔ insert-vendedores.sql

Popula o banco com registros reais de vendas dos quatro vendedores:

João Silva

Maria Souza

Carlos Oliveira

Ana Lima

▶️ Como Executar o Projeto
1️⃣ Clonar o repositório
git clone https://github.com/MicaildeJunior/vendas-tempo-comercial.git

2️⃣ Configurar o SQL Server

No arquivo appsettings.json, ajuste a connection string para sua instância local:

"ConnectionStrings": {
  "VendasTimeComercialConnection": "Data Source=SEU_SERVIDOR\\SQLEXPRESS;Initial Catalog=VendasTimeComercialDb;Integrated Security=True;TrustServerCertificate=True;"
}

3️⃣ Criar o banco de dados

Rodar o script:

/Scripts/criar-banco.sql

4️⃣ Inserir os dados de teste

Rodar:

/Scripts/insert-vendedores.sql

5️⃣ Executar a API

No terminal:

cd VendasTimeComercial.Api
dotnet run


A API ficará disponível em:

https://localhost:7047/swagger


(Porta pode variar)

🧪 Testes via Swagger

Acesse:

https://localhost:{porta}/swagger


E execute o endpoint:

GET /api/comissoes

📐 Arquitetura da Solução

A aplicação segue um padrão em camadas, facilitando manutenção e expansão:

VendasTimeComercial.Api          → Controllers e Configurações
VendasTimeComercial.Application  → Serviços e DTOs
VendasTimeComercial.Domain       → Entidades e Interfaces
VendasTimeComercial.Infrastructure → EF Core, Repositórios, Migrations
VendasTimeComercial.Shared       → Utilidades e Classes Comuns

📝 Objetivo do Projeto

Este projeto foi desenvolvido para fins de avaliação técnica, demonstrando:

Boa organização de código

Aplicação correta de arquitetura em camadas

Utilização de EF Core com SQL Server

Exposição de APIs REST

Processamento de regra de negócio real (cálculo de comissões)

👤 Autor

Micailde de Oliveira Junior
Desenvolvedor Backend | C# | .NET | SQL Server
GitHub: https://github.com/MicaildeJunior
