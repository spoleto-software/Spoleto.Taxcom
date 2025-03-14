# Spoleto.Taxcom

[![](https://img.shields.io/github/license/spoleto-software/Spoleto.Taxcom)](https://github.com/spoleto-software/Spoleto.Taxcom/blob/main/LICENSE)
[![](https://img.shields.io/nuget/v/Spoleto.Taxcom)](https://www.nuget.org/packages/Spoleto.Taxcom/)
![Build](https://github.com/spoleto-software/Spoleto.Taxcom/actions/workflows/ci.yml/badge.svg)

## Описание
SDK для работы с API сервиса Taxcom (https://lk-ofd.taxcom.ru), предоставляющее простой и удобный способ интеграции с сервисом Taxcom.

## Особенности
- Поддержка REST API Taxcom
- Автоматическое управление авторизацией и токенами
- Асинхронные методы для максимальной производительности
- Синхронные версии всех методов для использования в коде без возможности асинхронности

 
## Установка
```bash
Install-Package Spoleto.Taxcom
```

## Быстрый старт

### Использование `Microsoft Dependency`:
```csharp
using Spoleto.Taxcom;

services.AddSingleton(taxcomOptions);
services.AddSingleton<ITaxcomProvider, TaxcomProvider>();

// Далее либо:
var provider = _serviceProvider.GetRequiredService<ITaxcomProvider>();

// Либо инжектировать в свой класс:
public class YourClass
{
    private readonly ITaxcomProvider _provider;

    public YourClass(ITaxcomProvider taxcomProvider)
    {
        _provider = taxcomProvider;
    }
}

// И далее, например, получение ссылки на чек
var searchModel = new DocumentUrlSearchModel
{
	FnFactoryNumber = "123456789",
	FdNumber = 12345
};

var documentUrlModel = await provider.GetDocumentUrlAsync(searchModel);
```

### Использование `TaxcomProviderFactory`:
```csharp
using Spoleto.Taxcom;

var provider = new TaxcomProviderFactory().WithOptions("integratorId", "login", "password").Build();

// Получение ссылки на чек
var searchModel = new DocumentUrlSearchModel
{
	FnFactoryNumber = "123456789",
	FdNumber = 12345
};

var documentUrlModel = await provider.GetDocumentUrlAsync(searchModel);
```


## Лицензия
MIT


## Требования
- .NET Standard 2.0+
- .NET 8+

## Тестирование
Создан проект для тестов `Spoleto.Taxcom.Tests`.

```bash
dotnet test
```

