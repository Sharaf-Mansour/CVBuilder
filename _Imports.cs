global using Microsoft.AspNetCore.Components.Web;
global using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
global using CVBuilder;
global using System.Collections.Generic;
global using System;
global using HappyCRUD;
global using FluentValidation;
global using System.Text.RegularExpressions;
global using CVBuilder.Models;
global using CVBuilder.ModelValidators;
global using Microsoft.AspNetCore.Components.Forms;
global using Microsoft.AspNetCore.Components;
global using System.Net.Http.Json;
global using Blazored.Toast;
global using Force.DeepCloner;
global using  Arora.Blazor.StateContainer;

namespace CVBuilder;
public static class DateData
{
    private static int StartYear => 1900;
    private static int EndYear => DateTime.Now.Year + 1;
    public static Span<int> Years() => Enumerable.Range(StartYear, EndYear - StartYear).Reverse().ToArray();
    public static Span<Months> Month() => (Span<Months>)Enum.GetValues(typeof(Months))!;
    public static Span<MaritalStatus> MaritalStatus() => (Span<MaritalStatus>)Enum.GetValues(typeof(MaritalStatus))!;
    public static Span<MilitaryStatus> MilitaryStatus() => (Span<MilitaryStatus>)Enum.GetValues(typeof(MilitaryStatus))!;
    internal static CountryState[]? CountryStates = CountryStatesData.CountryStates;
}
public class CountryState
{
    public Country? Country { get; set; }
    public StateProvince[]? StateProvince { get; set; }
}
public class StateProvince
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int CountryId { get; set; }
}
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
