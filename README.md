# Projeto Classificação de Empresas

## - Informação sobre o presente projeto:

- O projeto foi feito no Visual Studio
- A linguagem utilizada foi C#
- O banco de dados utilizado foi o MySQL, manuseado no MySQL Workbench 8.0
- O Form foi feito em Aplicativo do windows Forms(.NET Framwork)
- A API foi feita em Aplicativo Web ASP.NET Core
- Os teste unitários foram feitos em Projeto de Teste do xUnit(.NET Core)


## - Para executar siga os passos a seguir:

1 - Faça um git clone desse repositório.  
2 - Abra o arquivo DATABASE.sql no MySQL Workbench, executando-o quando aberto.   
3 - Abra a pasta ClassificadorDeEmpresas.API no Visual Studio, execute e aguarde carregar, essa pasta contém a API.   
4 - Abra a pasta ClassificadorDeEmpresas no Visual Studio, execute e aguarde carregar, essa pasta contém o Form, ou seja, a interface.  

-> Desse modo a API seria executada antes e o Form em seguida, assim podendo utilizar tal sistema de classicação de empresas secretas.

OBs.: Os testes unitários estão na pasta ClassificadorDeEmpresas.API, antes de executar os testes tenha certeza que não há mais dados na tabela empresa, caso necessário utilize o seguinte comando no MySQL Workbench -> "truncate table empresas;", no qual tal comando faz um delete de todos os dados da tabela, deixando-a fazia.

OBS.: Para fazer o cadastro ou alteração que necessite da importação de um arquivo .json, há no repositório um exemplo de arquivo.json no qual contém uma lista que pode ser retornada para testar a importação.
