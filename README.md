# Softwares necessários

- Visual Studio Community 2015 (precisa ser o 2015, não 2013, 2012 e etc).

# Funcionalidades

## Módulo de administração

Nesta seção são descritas as funcionalidades do módulo de administração do sistema. Este módulo estará acessível apenas
para usuários administradores do sistema.

### Gerenciamento de cidades

Responsável pelo cadastro e gerenciamento das cidades do sistema. Devem ser informados:
- Nome
- Estado
- País

### Gerenciamento de Agências da Defesa Civil

Responsável pelo cadastramento de agências da defesa civil. Deve ser informado:
- Nome
- Cidade
- Usuário administrador


### Gerenciamento de notícias

Canal oficial para o cadastro de notícias. Deve ser informado:
- Agência (selecionada automaticamente de acordo com a agência que o usuário logado pertence)
- Mensagem
- Enviar para dispositivos móveis (sim ou não)
- Link para mais informações

### Gerenciamento de usuários

Gerenciamento de usuários do sistema. O sistema possui três tipos de usuários (administradores gerais, administradores de agência e cidadãos)

- Nome
- Email
- Senha
- Tipo de usuário


### Gerenciamento de pontos de monitoramento

Responsável pelo cadastro e gerenciamento dos pontos de monitoramento.

- Nome
- Latitude
- Longitude
- Tipo de sensor (alagamento, temperatura, pressão, ruído e etc)


### Gerenciamento de pontos da rota segura 

Cadastro das ruas participantes da rota segura

- Nome da rua
- Latitude e longitude de início
- Latitude e longitude de término


### Gerenciamento de contribuições dos usuários (informe um alagamento)

Responsável por dar sequência as contribuições enviadas pelos cidadãos. 
- Caso o alagamento proceda, o operador (administrador da agência) pode marcar o sensor mais próximo como alagado
- Caso a contribuição não proceda o operador por excluir a contribuição
	- O operador deve poder suspender novas contribuições de um determinado usuário em caso de abuso (por 3 dias)
	- O operador deve poder banir contribuições de um determinado usuário (o usuário deve ter sido suspenso pelo menos 1 vez)


## Aplicativo Web (público)
Nesta seção são descritas as funcionalidades disponíveis para usuários visitantes comuns, com e sem necessidade de autenticação.

### Mapa com os pontos de monitoramento

Página contendo um mapa com os pontos de monitoramento. Cada ponto deve mostrar:
- Nome
- Informações de monitoramento (alagamento, temperatura, pressão, ruído e etc)
- Data e hora da última atualização
- Botão para receber notificações daquele ponto de monitoramento específico.

### Mapa com a rota segura

Página com a rota segura atualizada. As ruas pertencentes a rota segura devem estar destacadas em verde.

### Funcionalidade de "Informe um alagamento"

Em um primeiro momento o usuário será instruído a instalar o aplicativo em seu celular. No futuro será avaliada a possibilidade de 
enviar contribuições diretamente pela página web.

### Visualização de notícias oficiais

Página com uma lista de comunicados oficiais da defesa civil. Ao clicar no comunicado o cidadão é direcionado para o link correspondente
ao cadastrado para aquele comunicado.

## API (Restful)

## Aplicativo Mobile (Xamarin)

TODO: Informar o link para o projeto mobile do xamarin no github.

### Visualização de pontos de monitoramento no mapa
### Visualização de notícias e informações oficiais
### Funcionalide de "Informe um alagamento"


## Sensores

Nesta seção são descritas as funcionalidades dos sensores para monitoramento.
TODO: Informar aqui o link para o projeto do github dos sensores

# Observações

O sistema será desenvolvido utilizando ASP.NET MVC 6 (parte do ASP.NET 5) e Entity Framework 7. Ambos estão em beta e, portanto,
podem ocorrer problemas de compatibilidade ao baixar o projeto.

# Comandos Úteis

## Criando o banco de dados a partir do EF7
dnu restore
dnvm use 1.0.0-rc1-final -p
dnx ef migrations add Initial
dnx ef database update