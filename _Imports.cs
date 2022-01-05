global using Microsoft.AspNetCore.Components.Web;
global using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
global using CVBuilder;
global using System.Collections.Generic;
global using System;
global using HappyCRUD;
global using FluentValidation;
global using System.Text.RegularExpressions;
global using System.Text.Json;
global using CVBuilder.Models;
global using CVBuilder.ModelsValidators;
global using Microsoft.AspNetCore.Components.Forms;
global using Microsoft.AspNetCore.Components;
global using System.Net.Http.Json;
global using Blazored.Toast;
namespace CVBuilder;
public static class DateData
{
    public static Span<int> Years() => Enumerable.Range(1900, 2023 - 1900).Reverse().ToArray();
    public static Span<Months> Month() => (Span<Months>)Enum.GetValues(typeof(Months))!;
    public static Span<MaritalStatus> MaritalStatus() => (Span<MaritalStatus>)Enum.GetValues(typeof(MaritalStatus))!;
    public static Span<MilitaryStatus> MilitaryStatus() => (Span<MilitaryStatus>)Enum.GetValues(typeof(MilitaryStatus))!;

    public static T DeepClone<T>(this T a) where T : class => JsonSerializer.Deserialize<T>(JsonSerializer.Serialize(a)) ?? a;
    internal static CountryState[]? CountryStates;
}
public record StateProvince(int Id, string Name, int CountryId);
public record CountryState(Country Country, StateProvince[] StateProvince);
public enum MaritalStatus
{
    Single = 1, Engaged, Married, Widowed, Separated, Divorced, Open
}
public enum MilitaryStatus
{
    Postponed = 1, Exempted, Completed, Active
}
public enum Months
{
    January = 1, February, March, April, May, June, July, August, September, October, November, December
}