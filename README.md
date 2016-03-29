# Softwares necess�rios

- Visual Studio Community 2015 (precisa ser o 2015, n�o 2013, 2012 e etc).

# Funcionalidades

## M�dulo de administra��o

Nesta se��o s�o descritas as funcionalidades do m�dulo de administra��o do sistema. Este m�dulo estar� acess�vel apenas
para usu�rios administradores do sistema.

### Gerenciamento de cidades

Respons�vel pelo cadastro e gerenciamento das cidades do sistema. Devem ser informados:
- Nome
- Estado
- Pa�s

### Gerenciamento de Ag�ncias da Defesa Civil

Respons�vel pelo cadastramento de ag�ncias da defesa civil. Deve ser informado:
- Nome
- Cidade
- Usu�rio administrador


### Gerenciamento de not�cias

Canal oficial para o cadastro de not�cias. Deve ser informado:
- Ag�ncia (selecionada automaticamente de acordo com a ag�ncia que o usu�rio logado pertence)
- Mensagem
- Enviar para dispositivos m�veis (sim ou n�o)
- Link para mais informa��es

### Gerenciamento de usu�rios

Gerenciamento de usu�rios do sistema. O sistema possui tr�s tipos de usu�rios (administradores gerais, administradores de ag�ncia e cidad�os)

- Nome
- Email
- Senha
- Tipo de usu�rio


### Gerenciamento de pontos de monitoramento

Respons�vel pelo cadastro e gerenciamento dos pontos de monitoramento.

- Nome
- Latitude
- Longitude
- Tipo de sensor (alagamento, temperatura, press�o, ru�do e etc)


### Gerenciamento de pontos da rota segura 

Cadastro das ruas participantes da rota segura

- Nome da rua
- Latitude e longitude de in�cio
- Latitude e longitude de t�rmino


### Gerenciamento de contribui��es dos usu�rios (informe um alagamento)

Respons�vel por dar sequ�ncia as contribui��es enviadas pelos cidad�os. 
- Caso o alagamento proceda, o operador (administrador da ag�ncia) pode marcar o sensor mais pr�ximo como alagado
- Caso a contribui��o n�o proceda o operador por excluir a contribui��o
	- O operador deve poder suspender novas contribui��es de um determinado usu�rio em caso de abuso (por 3 dias)
	- O operador deve poder banir contribui��es de um determinado usu�rio (o usu�rio deve ter sido suspenso pelo menos 1 vez)


## Aplicativo Web (p�blico)
Nesta se��o s�o descritas as funcionalidades dispon�veis para usu�rios visitantes comuns, com e sem necessidade de autentica��o.

### Mapa com os pontos de monitoramento

P�gina contendo um mapa com os pontos de monitoramento. Cada ponto deve mostrar:
- Nome
- Informa��es de monitoramento (alagamento, temperatura, press�o, ru�do e etc)
- Data e hora da �ltima atualiza��o
- Bot�o para receber notifica��es daquele ponto de monitoramento espec�fico.

### Mapa com a rota segura

P�gina com a rota segura atualizada. As ruas pertencentes a rota segura devem estar destacadas em verde.

### Funcionalidade de "Informe um alagamento"

Em um primeiro momento o usu�rio ser� instru�do a instalar o aplicativo em seu celular. No futuro ser� avaliada a possibilidade de 
enviar contribui��es diretamente pela p�gina web.

### Visualiza��o de not�cias oficiais

P�gina com uma lista de comunicados oficiais da defesa civil. Ao clicar no comunicado o cidad�o � direcionado para o link correspondente
ao cadastrado para aquele comunicado.

## API (Restful)

## Aplicativo Mobile (Xamarin)

TODO: Informar o link para o projeto mobile do xamarin no github.

### Visualiza��o de pontos de monitoramento no mapa
### Visualiza��o de not�cias e informa��es oficiais
### Funcionalide de "Informe um alagamento"


## Sensores

Nesta se��o s�o descritas as funcionalidades dos sensores para monitoramento.
TODO: Informar aqui o link para o projeto do github dos sensores

# Observa��es

O sistema ser� desenvolvido utilizando ASP.NET MVC 6 (parte do ASP.NET 5) e Entity Framework 7. Ambos est�o em beta e, portanto,
podem ocorrer problemas de compatibilidade ao baixar o projeto.

# Comandos �teis

## Criando o banco de dados a partir do EF7
dnu restore
dnvm use 1.0.0-rc1-final -p
dnx ef migrations add Initial
dnx ef database update