
using System.Text.Json;
using System.Xml.Serialization;
using SaveToXmL;

Pessoa pessoa = new Pessoa()
{
    Nome="João", 
    Sobrenome="Pessoa",
    Cpf="108.111.527-77",
    Escolaridade="Ens. Superior",
    RendaMensal=5000.00m
};

//SalvarNoXml(pessoa);
SalvarNoJson(pessoa);

void SalvarNoJson(Pessoa pessoa)
{
   var caminho = @"c:\temp\pessoa.json";
   var json = JsonSerializer.Serialize<Pessoa>(pessoa);
   File.WriteAllText(caminho,json);
}

void SalvarNoXml(Pessoa pessoa)
{
    var caminho = @"c:\temp\pessoa.xml";
    var serializador = new XmlSerializer(typeof(Pessoa));
    try{
        FileStream fs = new FileStream(caminho,FileMode.Create);
        StreamWriter sw = new StreamWriter(fs);
        serializador.Serialize(sw,pessoa);
        sw.Close();
    } 
    catch(Exception ex)
    {
      System.Console.WriteLine($"Erro:{ex.Message}");
    }
   
}