# Segfy Hands-On

Projeto criado como parte da 4° fase do processo seletivo para vaga de Programador Jr na empresa Segfy.

O repositório possui duas Solutions, SegfyHandsOn e SegfyHandsOn_v2. A primeira solution contem uma aplicação na estrutura DDD, com injeção de dependencia, validator, classes que herdam de uma base genérica. Essa solution foi minha primeira tentativa para realizar a atividade, tive algumas complicações com relação a conflitos entre as versões dos diferentes projetos que se resolveram ao utilizar o Visual Studio 2019. Logo após não obtive sucesso em efetuar o processo de migration. Depois de muitas tentativas abri mão de continuar este projeto e criei uma nova solution, SegfyHandsOn_v2. Esta nova solution possui um projeto WebAPI utilizando mvc e um projeto de testes de integração, nesta mesma pasta da solution se encontra o front da atividade, feita em Angular versão 8.0.1.

## Como executar o projeto:

##### Configurando projeto back-end no Visual Studio 2019:

* No projeto WebAPI:
  - Mudar a string connection para apontar para o banco local.
  - Adicionar migrations com o comando add-migration no prompt do nuget package.
  - Executar comando update-database no prompt do nuget package.
  - Na classe Startup.cs, no método Configure em app.UseCors insira a URL em que o projeto Angular está rodando.

#### Configurando projeto de front-end no Visual Code:

- Faça a instalação do NodeJs.
- Através de seu prompt de comando instale o Angular/cli utilizando o comando: npm install -g @angular/cli.
- Extraia o arquivo node_modules.zip presente na pasta Angular.
- No arquivo seguroauto-detail.service-ts configure a url na qual sua api está rodando. Ex: http://localhost:59035/api.
- Rode a aplicação utilizando no temrinal de comando o comando: ng serve

## Arquitetura: 

- MVC 

## IDEs utilizadas:

- Visual Studio Code
- Visual Studio 2019

## Framework:

- Asp.Net Core 2.2
- NodeJs: 10.16.0

## Prints:

  Prints do projeto disponivel na pasta Prints.



