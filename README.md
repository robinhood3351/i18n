# Lepo.i18n
[Created with ❤ in Poland by lepo.co](https://dev.lepo.co/)  
Convenient app translation.

[![GitHub license](https://img.shields.io/github/license/lepoco/i18n)](https://github.com/lepoco/i18n/blob/master/LICENSE) [![Nuget](https://img.shields.io/nuget/v/lepo.i18n)](https://www.nuget.org/packages/lepo.i18n/) [![Nuget (with prereleases)](https://img.shields.io/nuget/vpre/lepo.i18n?label=nuget-pre)](https://www.nuget.org/packages/lepo.i18n/) [![Nuget](https://img.shields.io/nuget/dt/lepo.i18n?label=nuget-downloads)](https://www.nuget.org/packages/lepo.i18n/) [![Size](https://img.shields.io/github/repo-size/lepoco/i18n)](https://github.com/lepoco/i18n) [![Sponsors](https://img.shields.io/github/sponsors/lepoco)](https://github.com/sponsors/lepoco)

# How to use?
- Install library via NuGet.  
![NuGet package image](https://user-images.githubusercontent.com/13592821/151101238-3ce0591b-5b9c-4c02-9c82-43854fc7d442.png)


- Add translation files to your application, e.g. `Strings/pl_PL.yaml`, and mark them as embedded resource.

- Register selected language
```c#
Lepo.i18n.Translator.SetLanguage(Assembly.GetExecutingAssembly(), "pl_PL", "Lepo.i18n.Demo.Strings.pl_PL.yaml");
```

- Add a library reference in your XAML and start translating.
```xaml
<Page xmlns:i18n="clr-namespace:Lepo.i18n;assembly=Lepo.i18n">

  <TextBlock Text="{i18n:Translate String='Hello World'}"/>

</Page>
```

## Compilation
Use Visual Studio 2022 and invoke the .sln.

Visual Studio  
**Lepo.i18n** is an Open Source project. You are entitled to download and use the freely available Visual Studio Community Edition to build, run or develop for Lepo.i18n. As per the Visual Studio Community Edition license, this applies regardless of whether you are an individual or a corporate user.

## License
Lepo.i18n is free and open source software licensed under **MIT License**. You can use it in private and commercial projects.  
Keep in mind that you must include a copy of the license in your project.
