# SISTEMA DE BIBLIOTECA

Projeto desenvolvido para a disciplina de Programação Cliente e Servidor do curso de Análise e Desenvolvimento de Sistemas - 3º semestre.

## INTEGRANTES

- Aryane Yasmin Moraes da Costa - RA: 0979665
- Bruno Camarão Pereira - RA: 0982506
- Gabrielle Caroline da Costa - RA: 0981827

## DESCRIÇÃO

O projeto consiste em um sistema para gerenciamento de uma biblioteca, desenvolvido em C# com integração ao banco de dados MySQL.

O sistema permite realizar o cadastro e a consulta de usuários e livros, além do controle de empréstimos e devoluções.

## FUNCIONALIDADES

- Login de usuários
- Cadastro de usuários
- Cadastro de autores
- Cadastro de livros
- Consulta de usuários por nome ou e-mail
- Consulta de livros por título ou autor
- Consulta de livros disponíveis
- Registro de empréstimos
- Registro de devoluções
- Controle da quantidade disponível dos livros
- Validação da data prevista para devolução
- Controle de acesso de acordo com o tipo de usuário

## USUÁRIOS PARA TESTE

### Administrador
Matrícula: 0001  
Senha: 123

### Funcionário
Matrícula: 0002  
Senha: 123

### Aluno
Matrícula: 0003  
Senha: 123

## BANCO DE DADOS

Banco utilizado: MySQL

Nome do banco: biblioteca

Tabelas utilizadas:

- usuarios
- autores
- livros
- emprestimos

O arquivo `biblioteca.sql` acompanha o projeto e contém a estrutura do banco de dados e os registros utilizados para teste.

## COMO EXECUTAR

1. Iniciar o Apache e o MySQL pelo XAMPP.
2. Abrir o phpMyAdmin.
3. Importar o arquivo `biblioteca.sql` para criar o banco de dados e suas tabelas.
4. Abrir o projeto `sistemaBiblioteca` no Visual Studio.
5. Executar o sistema.
6. Utilizar um dos usuários de teste para realizar o login.

## TECNOLOGIAS UTILIZADAS

- C#
- Windows Forms
- MySQL
- XAMPP
- MySql.Data
- Visual Studio

## REQUISITOS

Para executar o projeto é necessário ter instalado:

- Visual Studio
- XAMPP
- MySQL
- MySql.Data

## CONFIGURAÇÃO DA CONEXÃO

A conexão com o banco de dados está configurada no arquivo `Conexao.cs`, localizado na pasta `banco`.

Configuração utilizada:

- Servidor: localhost
- Banco de dados: biblioteca
- Usuário: root
- Senha: sem senha

Antes de executar o sistema, o MySQL deve estar iniciado pelo XAMPP.