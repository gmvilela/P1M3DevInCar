# P1M3DevInCar

2 REQUISITOS DA APLICAÇÃO
A aplicação que deverá ser realizada individualmente deve contemplar os seguintes requisitos:
A aplicação deverá ser desenvolvida em ASP.NET Core 6;
A API deve seguir o modelo GraphQL;
Deve ser configurada uma autenticação para o projeto e ser definida uma chave específica para a configuração do token;
A mutation relacionada aos cadastramento dos veículos e de venda devem estar protegidas para apenas usuários autenticados;
Inicializar alguns veículos, ideal é começar 3 de cada tipo definido abaixo;
Para guardar e acessar os dados, utilize o banco de dados SQL.

3 ROTEIRO DA APLICAÇÃO
A montadora/revenda de veículos DEVinCar deseja automatizar todo o sistema de armazenamento de informações referentes aos carros fabricados. O sistema deve conter os seguintes tipos de carros, cada um com suas características:

Moto/Triciclo
Uma moto/triciclo possui como característica principal sua potência.
Deve-se informar o total rodas da moto/triciclo.
Carro
Carro possui como características principais:
Total de portas.
Se será flex ou somente gasolina.
Potência (em cavalos).
Camionete:
Carro possui como características principais:
Total de portas.
Capacidade de carregamento na caçamba (em litros).
Potência (em cavalos).
Se será gasolina ou diesel.

Todos os veículos serão conterão também os atributos descritos abaixo:
Número do chassi *
Data de fabricação
Nome
Placa
Valor
Cor

O sistema também deverá retornar os seguintes relatórios:
Listar todos os veículos. O usuário poderá informar qual tipo do veículo deseja listar:
Motos/Triciclo
Carros
Camionete
Todos
Veículos disponíveis
Veículos vendidos
Veículo vendido com o maior preço
Veículo vendido com o menor preço

Eventos/Notificações geradas:
Subscription para cada veículo vendido
Subscription para cada veículo adicionado

Métodos:
Vender veículo *
Informações necessárias:
Veículo que será vendido
CPF do comprador
Data
Alterar cor
Alterar valor
Novo veículo *
