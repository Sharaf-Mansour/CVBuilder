﻿global using Microsoft.AspNetCore.Components.Web;
global using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
global using CVBuilder;
global using System.Collections.Generic;
global using System;
global using HappyCRUD;
global using FluentValidation;
global using Blazored.FluentValidation;
global using System.Text.RegularExpressions;
global using System.Text.Json;
global using CVBuilder.Models;
global using CVBuilder.ModelsValidators;
namespace CVBuilder;
public static class DateData
{
    public static Span<int> Years() => Enumerable.Range(1900, 2023 - 1900).Reverse().ToArray();
    public static Span<Months> Month() => (Span<Months>)Enum.GetValues(typeof(Months))!;
    public static T DeepClone<T>(this T a) where T : class => JsonSerializer.Deserialize<T>(JsonSerializer.Serialize(a)) ?? a;
}