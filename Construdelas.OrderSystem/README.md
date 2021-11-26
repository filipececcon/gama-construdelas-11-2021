# Projeto de Sistema de Pedidos

O projeto consiste em abordar conceitos de code design (arquitetura de projeto) e design patterns (padrões de projeto) para apredizado.

### Entidades

- Order:
- OrdemItem:
- Product:

## Infraestrutura

Para erguer o ambiente de base de dados na maquina com o docker basta executar a linha abaixo no terminal:

> docker-compose up -d

Para acessar a base de dados, abra a interface no brower pelo link abaixo:

http://localhost:9000

Configure a conexão conforme abaixo:

- Sistema: PostgreSQL
- Servidor: postgres
- Usuario: postgres
- Senha: admin

Obs: pode acontecer da base de dados demorar uns segundos a mais para estar apta a receber conexões.

Para desfazer o ambiente executar a linha de comando abaixo:

> docker-compose down
