Configuração de porta para Azure Data Studio via Bing Chat:

* Abra o Azure Data Studio e selecione Arquivo > Preferências > Configurações ( Code > Preferências > Configurações no Mac) para acessar as configurações do usuário e do espaço de trabalho1.
Copie qualquer configuração que você queira alterar para o arquivo settings.json apropriado1.
Procure pela configuração mssql.connections e edite o valor da porta para o que você deseja1. Por exemplo, se você quiser usar a porta 1434, você pode escrever algo como:

"mssql.connections": [
    {
        "server": "localhost",
        "database": "",
        "user": "",
        "password": "",
        "authenticationType": "SqlLogin",
        "port": 1434
    }
]

Salve o arquivo settings.json e reinicie o Azure Data Studio1.
Quando você for se conectar a um servidor SQL, selecione Servidores > Nova Conexão e preencha os detalhes da conexão com o nome do servidor, o tipo de autenticação, o nome de usuário e a senha23. Você também pode clicar em Opções Avançadas para ver ou alterar outras configurações, como a porta2.

* Se você não consegue abrir o programa, você pode tentar editar o arquivo settings.json manualmente na pasta onde ele está instalado. Você pode encontrar a pasta usando o explorador de arquivos do Windows e procurando por azuredatastudio ou usando a pesquisa do Windows. Dentro da pasta, procure pelo arquivo settings.json e abra-o com um editor de texto. Em seguida, siga os mesmos passos que eu mencionei antes para mudar a porta.

Se isso não funcionar, talvez seja melhor você desinstalar o Azure Data Studio e instalar novamente com a porta correta. Você pode fazer isso usando o comando /PORT=<porta> na janela do prompt de comando quando for instalar o programa. Por exemplo, se você quiser usar a porta 1434, você pode escrever algo como:

azuredatastudio-windows-user-setup-x.xx.x.exe /VERYSILENT /MERGETASKS=!runcode /PORT=1434
