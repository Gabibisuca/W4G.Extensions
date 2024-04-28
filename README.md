# W4G.Extensions

Este reposit�rio cont�m uma cole��o de extens�es para facilitar o desenvolvimento em diversas plataformas. 

Atualmente em constru��o, o objetivo � fornecer uma biblioteca de recursos �teis e comuns para agilizar o processo de desenvolvimento.

## Recursos Dispon�veis (em constante atualiza��o)

- **ToCurrency**: 
- Extens�es para trabalhar com forma��o de valores monet�rios.
- Aplica-se a: tipos int, double ou decimal.

## Como Utilizar

1. **Instala��o via NuGet**: Voc� pode instalar as extens�es via NuGet Package Manager executando o seguinte comando no Console do Gerenciador de Pacotes:
1. **Instala��o via NuGet**: Voc� pode instalar as extens�es via NuGet Package Manager executando o seguinte comando no Console do Gerenciador de Pacotes:

```bash	
Install-Package W4G.Extensions
```
2. **Exemplos de Utiliza��o**:

* ToCurrency:

```csharp
using W4G.Extensions;
class Program
{
    static void Main()
    {
        double valor = 12345.6789;

        Console.WriteLine("Valor Informado: " + valor);
        Console.WriteLine();
        Console.WriteLine("Valor formatado: " + valor.ToCurrency());
        Console.WriteLine("Valor formatado sem arredondamento: " + valor.ToCurrency(truncValue: true));
        Console.WriteLine("Valor formatado sem casas decimais): " + valor.ToCurrency(0));
        Console.WriteLine("Valor formatado com 3 casas decimais: " + valor.ToCurrency(3));
        Console.WriteLine("Valor formatado com 3 casas decimais e sem arredondamento: " + valor.ToCurrency(3, true));
        Console.WriteLine("Valor formatado usando a moeda (US)): " + valor.ToCurrency(cultureName: "en-US"));
    }
}
```
Output:
```bash
Valor Informado: 12345,6789

Valor formatado: R$ 12.345,68
Valor formatado sem arredondamento: R$ 12.345,67
Valor formatado sem casas decimais): R$ 12.346
Valor formatado com 3 casas decimais: R$ 12.345,679
Valor formatado com 3 casas decimais e sem arredondamento: R$ 12.345,678
Valor formatado usando a moeda (US)): $12,345.68
```

## Contribuindo
Contribui��es s�o bem-vindas! Sinta-se � vontade para abrir issues para relatar bugs, sugerir novas funcionalidades ou enviar pull requests com melhorias.

## Licen�a
Este projeto � licenciado sob a MIT License.

Este README.md fornece uma vis�o geral do reposit�rio, lista os recursos dispon�veis, explica como instalar e usar as extens�es, e tamb�m encoraja contribui��es.