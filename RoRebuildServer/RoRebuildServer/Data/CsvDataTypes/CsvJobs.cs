﻿namespace RoRebuildServer.Data.CsvDataTypes;

public class CsvJobs
{
    public required int Id { get; set; }
    public required string Class { get; set; }
    public required string SpriteMale { get; set; }
    public required string SpriteFemale { get; set; }
}