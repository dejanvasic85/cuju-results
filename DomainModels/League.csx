#load "StorageModel.csx"


using System;

public class League : StorageModel
{
    public bool Enabled { get; set; }
    public string Title { get; set; }
    public string ShortName { get; set; }
    public string Url { get; set; }
    public string Location { get; set; }
    public int? MaxRounds { get; set; }
    public string YearSpan { get; set; }
    public string AgeGroup { get; set; }
    public char Gender { get; set; }
    public int? Division { get; set; }
    public string Association { get; set; }
}