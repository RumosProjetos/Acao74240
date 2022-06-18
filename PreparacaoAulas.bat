IF "%1"=="" GOTO Continue
	gito add .
	gito commit -m %1
	gito push

	echo 'Criando Pasta de Solucao'
	mkdir Aula%1
	cd Aula%1
	echo 'Agenda' >> agenda.txt

	echo 'Versao mais atual do .NET CORE instalada'
	dotnet --version
	#dotnet --info #Caso queira ver todas as versões

	echo 'Criacao dos Projetos'
	dotnet new console -n Projeto.ConsoleApp -o Projeto.ConsoleApp
	dotnet new classlib -n Projeto.LogicaNegocio -o Projeto.LogicaNegocio
	dotnet new classlib -n Projeto.Modelo -o Projeto.Modelo
	dotnet new mstest -n Projeto.Tests -o Projeto.Tests

	echo 'Criacao da Solucao'
	dotnet new sln -n Solucao
	dotnet sln add Projeto.ConsoleApp
	dotnet sln add Projeto.LogicaNegocio
	dotnet sln add Projeto.Modelo
	dotnet sln add Projeto.Tests

	echo 'Preparacao dos Testes'
	dotnet add Projeto.ConsoleApp/Projeto.ConsoleApp.csproj reference Projeto.LogicaNegocio/Projeto.LogicaNegocio.csproj
	dotnet add Projeto.Tests/Projeto.Tests.csproj reference Projeto.LogicaNegocio/Projeto.LogicaNegocio.csproj

	echo 'Validacao do Preparo'
	dotnet restore
	dotnet build
	dotnet test
:Continue
echo 'Favor informar o nome da pasta'		
