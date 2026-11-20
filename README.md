# 💾 SaveToXmL
 
Aplicativo de console em **.NET 8** que demonstra como **serializar um objeto C# e salvá-lo em arquivo**, nos formatos **JSON** e **XML**.
 
É um exemplo simples e direto, ideal para quem está aprendendo a persistir dados em arquivos com `System.Text.Json` e `System.Xml.Serialization`.
 
---
 
## ✨ O que o projeto faz
 
- Cria um objeto `Pessoa` com dados de exemplo (nome, sobrenome, CPF, escolaridade e renda mensal).
- Serializa o objeto para **JSON** com `JsonSerializer` e grava o arquivo em disco.
- Possui também a versão para **XML** com `XmlSerializer`, com tratamento de erros (`try/catch`).
## 🧰 Tecnologias
 
| Tecnologia | Uso |
|---|---|
| C# e .NET 8 | Linguagem e plataforma (aplicativo de console) |
| `System.Text.Json` | Serialização para JSON |
| `System.Xml.Serialization` | Serialização para XML |
| `System.IO` | Gravação dos arquivos |
 
## 📁 Estrutura do projeto
 
```
SaveToXmL/
├── Program.cs       # Cria a Pessoa e salva em JSON ou XML
├── Pessoa.cs        # Classe de modelo
└── SaveToXmL.csproj
```
 
### Modelo `Pessoa`
 
| Propriedade | Tipo |
|---|---|
| `Nome` | `string?` |
| `Sobrenome` | `string?` |
| `Cpf` | `string?` |
| `Escolaridade` | `string?` |
| `RendaMensal` | `decimal` |
 
## ✅ Pré-requisitos
 
- [.NET SDK 8.0](https://dotnet.microsoft.com/download/dotnet/8.0)
## 🚀 Como executar
 
```bash
# 1. Clone o repositório
git clone https://github.com/<seu-usuario>/SaveToXmL.git
cd SaveToXmL
 
# 2. Crie a pasta de destino dos arquivos (Windows)
mkdir C:\temp
 
# 3. Execute
dotnet run
```
 
> ⚠️ **Caminho dos arquivos:** o código grava em `C:\temp\pessoa.json` e `C:\temp\pessoa.xml`. A pasta `C:\temp` precisa **existir** antes da execução, e esse caminho funciona no **Windows**. Em Linux ou macOS, altere a variável `caminho` em `Program.cs` (por exemplo, para `Path.Combine(Path.GetTempPath(), "pessoa.json")`).
 
## 🔀 Alternando entre JSON e XML
 
No `Program.cs`, a chamada de gravação fica nestas duas linhas. Por padrão, **somente o JSON está ativo**:
 
```csharp
//SalvarNoXml(pessoa);
SalvarNoJson(pessoa);
```
 
Para gerar o XML, descomente `SalvarNoXml(pessoa);` (e, se quiser, comente a linha do JSON).
 
## 📄 Exemplos de saída
 
**`pessoa.json`**
 
```json
{"Nome":"Jo\u00E3o","Sobrenome":"Pessoa","Cpf":"108.111.527-77","Escolaridade":"Ens. Superior","RendaMensal":5000.00}
```
 
> O `JsonSerializer` padrão gera o JSON em **uma única linha** e escapa caracteres acentuados (como `ã` → `\u00E3`). Para um JSON legível, use as opções:
>
> ```csharp
> var opcoes = new JsonSerializerOptions
> {
>     WriteIndented = true,
>     Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
> };
> var json = JsonSerializer.Serialize(pessoa, opcoes);
> ```
 
**`pessoa.xml`**
 
```xml
<?xml version="1.0" encoding="utf-8"?>
<Pessoa xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <Nome>João</Nome>
  <Sobrenome>Pessoa</Sobrenome>
  <Cpf>108.111.527-77</Cpf>
  <Escolaridade>Ens. Superior</Escolaridade>
  <RendaMensal>5000.00</RendaMensal>
</Pessoa>
```
 
## 🗺️ Ideias de evolução
 
- [ ] Ler os arquivos de volta (**desserialização**) com `JsonSerializer.Deserialize` e `XmlSerializer.Deserialize`.
- [ ] Usar `using` para garantir o fechamento dos arquivos no método XML.
- [ ] Receber o formato (JSON ou XML) e o caminho de destino por argumentos ou menu.
- [ ] Usar caminhos independentes do sistema operacional com `Path.Combine`.
- [ ] Serializar uma **lista** de pessoas.
- [ ] Validar o CPF antes de salvar.
- [ ] Adicionar tratamento de erros também no método JSON.
## 📄 Licença
 
Defina aqui a licença do projeto (por exemplo, [MIT](https://opensource.org/licenses/MIT)).
 
---
 
Feito com 💙 durante os estudos de **serialização em C#**.
 
