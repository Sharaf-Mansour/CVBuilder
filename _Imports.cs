﻿global using Microsoft.AspNetCore.Components.Web;
global using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
global using CVBuilder;
global using System.Collections.Generic;
global using System;
global using HappyCRUD;
global using FluentValidation;
//global using Blazored.FluentValidation;
global using System.Text.RegularExpressions;
global using System.Text.Json;
global using CVBuilder.Models;
global using CVBuilder.ModelsValidators;
global using Microsoft.AspNetCore.Components.Forms;
global using Microsoft.AspNetCore.Components;
global using System.Net.Http.Json;
namespace CVBuilder;
public static class DateData
{
    public static Span<int> Years() => Enumerable.Range(1900, 2023 - 1900).Reverse().ToArray();
    public static Span<Months> Month() => (Span<Months>)Enum.GetValues(typeof(Months))!;
    public static T DeepClone<T>(this T a) where T : class => JsonSerializer.Deserialize<T>(JsonSerializer.Serialize(a)) ?? a;
}
public record Country(int Id, string Name, string TwoLetterIsoCode, string ThreeLetterIsoCode);
public record StateProvince(int Id, string Name, int CountryId);
public  record CountryState(Country Country, StateProvince[] StateProvince);