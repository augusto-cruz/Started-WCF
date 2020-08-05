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

    C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\IDE

Arquivo
    > Adicionar Serviço
        > Adiciona a URI do serviço Ex: `http://localhost:<port>/Service1.svc`
