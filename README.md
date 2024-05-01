# W4G.Extensions

Este reposit�rio cont�m uma cole��o de extens�es para facilitar o desenvolvimento em diversas plataformas. 

Atualmente em constru��o, o objetivo � fornecer uma biblioteca de recursos �teis e comuns para agilizar o processo de desenvolvimento.

## Recursos Dispon�veis (em constante atualiza��o)

### Extens�es para N�meros
- **[ToCurrency](https://github.com/wagnerpt/W4G.Extensions/wiki/ToCurrency)**: Formata��o de valores monet�rios. Aplica-se a: tipos int, double ou decimal.
- **[ToExtensionMoneyBRL](https://github.com/wagnerpt/W4G.Extensions/wiki/ToExtensionMoneyBRL)**: Retorna o valor por extenso em reais (R$). Aplica-se a: tipos int, long, double ou decimal.
- **[ToExtensionValueBR](https://github.com/wagnerpt/W4G.Extensions/wiki/ToExtensionValueBR)**: Retorna o n�mero por extenso em portugu�s. Aplica-se a: tipos int, long, double ou decimal.

### Extens�es para Strings
- **[NoAccents](https://github.com/wagnerpt/W4G.Extensions/wiki/NoAccents)**: Remove acentos e "�" de uma string.
- **[OnlyNumbers](https://github.com/wagnerpt/W4G.Extensions/wiki/OnlyNumbers)**: Retorna somente os n�meros contido em uma string.

## Como Utilizar

**Instala��o via NuGet**: Voc� pode instalar as extens�es via NuGet Package Manager executando o seguinte comando no Console do Gerenciador de Pacotes:

```bash	
dotnet add package W4G.Extensions
```

Depois de instalar o pacote, voc� pode usar as extens�es em seu c�digo. Veja um exemplo de uso do m�todo ToCurrency():

```csharp
using W4G.Extensions;

class Program
{
	static void Main(string[] args)
	{
		double value = 1234.56;
		string formattedValue = value.ToCurrency(); // R$ 1.234,56
		Console.WriteLine(formattedValue);
	}
}
```

## Contribuindo
Contribui��es s�o bem-vindas! Sinta-se � vontade para abrir issues para relatar bugs, sugerir novas funcionalidades ou enviar pull requests com melhorias.

## Licen�a
Este projeto � licenciado sob a MIT License.

Este README.md fornece uma vis�o geral do reposit�rio, lista os recursos dispon�veis, explica como instalar e usar as extens�es, e tamb�m encoraja contribui��es.
