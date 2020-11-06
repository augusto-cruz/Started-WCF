#                   ► WCF (Windows Communication Foundation)

## Conhecendo WCF

Adress   - Define onde o serviço reside;
Contract - Define o que o serviço vai fazer;
Binding  - Define como se comunicar com o serviço.

Address + Binding + Contract = Endpoint 

## Criando o projeto

Para criar o projeto usando um template do VS tenha instalado o WCF (Instalação co o VS Installer).

    Novo Projeto
        > Aplicativo de Serviço WCF

## WcfTestClient

Aplicação cliente para realizar os testes em serviços WCF.

Caminho:

    C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\IDE\WcfTestClient

Arquivo
    > Adicionar Serviço
        > Adiciona a URI do serviço Ex: `http://localhost:<port>/UserService.svc`

## Arquitetura Projeto

O arquivo WCF na API implementa tudo o que tem na interface de que herda.

Requisição
    > Arquivo WCF - Service.svc
        > BLL (Camada de Negócios)
            > DAL (Camada de acesso a dados)
                > Response

<!-- ## Configurando o projeto

No arquivo `Web.config`:

    <system.serviceModel>
		<serviceHostingEnvironment>
			<serviceActivations>
				<add 
					factory="System.ServiceModel.Activation.ServiceHostFactory"
					relativeAddress="api/service.svc"
					service="WCF_DotNetFramework.API.Service"
				/>
			</serviceActivations>
		</serviceHostingEnvironment>

		<behaviors>
			<serviceBehaviors>
				<behavior>
					<serviceMetadata httpGetEnabled="true" />
				</behavior>
			</serviceBehaviors>
		</behaviors>
	</system.serviceModel> -->
