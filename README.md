# API .NET / MongoDB.

API desenvolvida durante o treinamento do curso de .NET da Digital Innovation One, ministrado pelo professor @gabrielfbarros.

Para testar:

- Cadastrar infectado

POST - https://localhost:5001/infectado

{
	"dataNascimento": "1990-03-01",
	"sexo": "M",
	"latitude": -23.5630994,
	"longitude": -46.6565712
}

- Listar todos os infectados

GET - https://localhost:5001/infectado

- Listar infectado específico

GET - https://localhost:5001/infectado/id

- Atualizar infectado

PUT - https://localhost:5001/infectado/id

- Excluir infectado

DELETE - https://localhost:5001/infectado/id


------------



Observações:

- É necessário configurar o acesso ao banco de dados no appsettings.json em "ConnectionString": "mongodb+srv://(nome do usuário do banco):senha de acesso ao banco@cluster...".

- Caso seja necessário, habilitar autorização no navegador, conforme a figura abaixo.
[![](https://github.com/brunolapolla/.NET-API-MongoDB-COVID-19-/blob/main/P%C3%A1gina%20com%20acesso%20n%C3%A3o%20autorizado.jpg)](https://github.com/brunolapolla/.NET-API-MongoDB-COVID-19-/blob/main/P%C3%A1gina%20com%20acesso%20n%C3%A3o%20autorizado.jpg)


------------



Links Uteis:

.net core - https://dotnet.microsoft.com/download

visual code - https://code.visualstudio.com/download

postman - https://www.postman.com/downloads/

mongo atlas - https://www.mongodb.com/cloud/atlas/register


------------

Referências:

https://docs.mongodb.com/

https://docs.mongodb.com/manual/

https://docs.mongodb.com/ecosystem/drivers/csharp/

https://docs.atlas.mongodb.com/
