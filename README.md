# Spoleto.Taxcom

[![](https://img.shields.io/github/license/spoleto-software/Spoleto.Taxcom)](https://github.com/spoleto-software/Spoleto.Taxcom/blob/main/LICENSE)
[![](https://img.shields.io/nuget/v/Spoleto.Taxcom)](https://www.nuget.org/packages/Spoleto.Taxcom/)
![Build](https://github.com/spoleto-software/Spoleto.Taxcom/actions/workflows/ci.yml/badge.svg)

## ��������
SDK ��� ������ � API ������� Taxcom (https://lk-ofd.taxcom.ru), ��������������� ������� � ������� ������ ���������� � �������� Taxcom.

## �����������
- ��������� REST API Taxcom
- �������������� ���������� ������������ � ��������
- ����������� ������ ��� ������������ ������������������
- ���������� ������ ���� ������� ��� ������������� � ���� ��� ����������� �������������

 
## ���������
```bash
Install-Package Spoleto.Taxcom
```

## ������� �����

### ������������� `Microsoft Dependency`:
```csharp
using Spoleto.Taxcom;

services.AddSingleton(taxcomOptions);
services.AddSingleton<ITaxcomProvider, TaxcomProvider>();

// ����� ����:
var provider = _serviceProvider.GetRequiredService<ITaxcomProvider>();

// ���� ������������� � ���� �����:
public class YourClass
{
    private readonly ITaxcomProvider _provider;

    public YourClass(ITaxcomProvider taxcomProvider)
    {
        _provider = taxcomProvider;
    }
}

// � �����, ��������, ��������� ������ �� ���
var searchModel = new DocumentUrlSearchModel
{
	FnFactoryNumber = "123456789",
	FdNumber = 12345
};

var documentUrlModel = await provider.GetDocumentUrlAsync(searchModel);
```

### ������������� `TaxcomProviderFactory`:
```csharp
using Spoleto.Taxcom;

var provider = new TaxcomProviderFactory().WithOptions("integratorId", "login", "password").Build();

// ��������� ������ �� ���
var searchModel = new DocumentUrlSearchModel
{
	FnFactoryNumber = "123456789",
	FdNumber = 12345
};

var documentUrlModel = await provider.GetDocumentUrlAsync(searchModel);
```


## ��������
MIT


## ����������
- .NET Standard 2.0+
- .NET 8+

## ������������
������ ������ ��� ������ `Spoleto.Taxcom.Tests`.

```bash
dotnet test
```

