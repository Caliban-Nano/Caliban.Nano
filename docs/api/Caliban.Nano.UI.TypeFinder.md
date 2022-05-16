#### [Caliban.Nano](index.md 'index')
### [Caliban.Nano.UI](Caliban.Nano.UI.md 'Caliban.Nano.UI')

## TypeFinder Class

A very optimistic type finder.

```csharp
public static class TypeFinder
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; TypeFinder
### Fields

<a name='Caliban.Nano.UI.TypeFinder.Sources'></a>

## TypeFinder.Sources Field

List of known assemblies.

```csharp
public static readonly List<Assembly> Sources;
```

#### Field Value
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[System.Reflection.Assembly](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.Assembly 'System.Reflection.Assembly')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')
### Properties

<a name='Caliban.Nano.UI.TypeFinder.Rule'></a>

## TypeFinder.Rule Property

Type name transformation rule.

```csharp
public static System.Func<string,string> Rule { get; set; }
```

#### Property Value
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')
### Methods

<a name='Caliban.Nano.UI.TypeFinder.FindType(string)'></a>

## TypeFinder.FindType(string) Method

Returns an injected instance for the requested type.

```csharp
public static object FindType(string name);
```
#### Parameters

<a name='Caliban.Nano.UI.TypeFinder.FindType(string).name'></a>

`name` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The type name.

#### Returns
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
An injected instance.

#### Exceptions

[System.TypeLoadException](https://docs.microsoft.com/en-us/dotnet/api/System.TypeLoadException 'System.TypeLoadException')  
Thrown if the type could not be loaded.

<a name='Caliban.Nano.UI.TypeFinder.FindView(System.Type)'></a>

## TypeFinder.FindView(Type) Method

Returns a view instance for the requested type.

```csharp
public static object FindView(System.Type type);
```
#### Parameters

<a name='Caliban.Nano.UI.TypeFinder.FindView(System.Type).type'></a>

`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The view type.

#### Returns
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
A view instance.

<a name='Caliban.Nano.UI.TypeFinder.FindViewModel(System.Type)'></a>

## TypeFinder.FindViewModel(Type) Method

Returns a view model instance for the requested type.

```csharp
public static object FindViewModel(System.Type type);
```
#### Parameters

<a name='Caliban.Nano.UI.TypeFinder.FindViewModel(System.Type).type'></a>

`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The view model type.

#### Returns
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
A view model instance.