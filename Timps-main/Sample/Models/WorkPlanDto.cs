﻿using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TekTrackingCore.Sample.Models
{
    public class WorkPlan
    {
        public string WpName { get; set; }
        public string title { get; set; }
    }



    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Completion
    {
        [JsonProperty("completed")]
        public bool Completed { get; set; }

        [JsonProperty("ranges")]
        public List<Range> Ranges { get; set; }
    }

    public class InspectionFormInfo
    {
        [JsonProperty("assetId")]
        public string AssetId { get; set; }

        [JsonProperty("assetName")]
        public string AssetName { get; set; }

        [JsonProperty("assetType")]
        public string AssetType { get; set; }

        [JsonProperty("inspectionFormName")]
        public string InspectionFormName { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("testCode")]
        public string TestCode { get; set; }

        [JsonProperty("testId")]
        public string TestId { get; set; }
    }

    public class InspectionFrequency
    {
        [JsonProperty("freq")]
        public int Freq { get; set; }

        [JsonProperty("timeFrame")]
        public string TimeFrame { get; set; }

        [JsonProperty("timeFrameNumber")]
        public int TimeFrameNumber { get; set; }

        [JsonProperty("recurNumber")]
        public int RecurNumber { get; set; }

        [JsonProperty("recurTimeFrame")]
        public string RecurTimeFrame { get; set; }

        [JsonProperty("maxInterval")]
        public int MaxInterval { get; set; }

        [JsonProperty("minDays")]
        public int MinDays { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class Interval
    {
        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("expEnd")]
        public string ExpEnd { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("startLocation")]
        public string StartLocation { get; set; }

        [JsonProperty("traversed")]
        public string Traversed { get; set; }

        [JsonProperty("observed")]
        public string Observed { get; set; }

        [JsonProperty("allSideTracks")]
        public bool AllSideTracks { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class LineCords
    {
        [JsonProperty("geometry")]
        public string Geometry { get; set; }
    }

    public class Range
    {
        [JsonProperty("inspectionId")]
        public string InspectionId { get; set; }

        [JsonProperty("inspectionName")]
        public string InspectionName { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("intervals")]
        public List<Interval> Intervals { get; set; }
    }

    public class WorkPlanDto
    {
        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("runRanges")]
        public List<RunRange> RunRanges { get; set; }

        [JsonProperty("inspectionFrequencies")]
        public List<InspectionFrequency> InspectionFrequencies { get; set; }

        [JsonProperty("minDays")]
        public int MinDays { get; set; }

        [JsonProperty("tasks")]
        public List<Task> Tasks { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("inspectionAssets")]
        public List<string> InspectionAssets { get; set; }

        [JsonProperty("isRemoved")]
        public bool IsRemoved { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("sort_id")]
        public int SortId { get; set; }

        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("inspectionType")]
        public string InspectionType { get; set; }

        [JsonProperty("FRAOption")]
        public string FRAOption { get; set; }

        [JsonProperty("inspectionFrequency")]
        public int InspectionFrequency { get; set; }

        [JsonProperty("maxAllowable")]
        public int MaxAllowable { get; set; }

        [JsonProperty("lineId")]
        public string LineId { get; set; }

        [JsonProperty("workZone")]
        public bool WorkZone { get; set; }

        [JsonProperty("foulTime")]
        public bool FoulTime { get; set; }

        [JsonProperty("watchmen")]
        public string Watchmen { get; set; }

        [JsonProperty("startDate")]
        public DateTime StartDate { get; set; }

        [JsonProperty("inspection_type")]
        public string Inspection_Type { get; set; }

        [JsonProperty("inspection_date")]
        public DateTime InspectionDate { get; set; }

        [JsonProperty("inspection_freq")]
        public string InspectionFreq { get; set; }

        [JsonProperty("inspectionFormInfo")]
        public List<InspectionFormInfo> InspectionFormInfo { get; set; }

        [JsonProperty("nextInspDateFieldName")]
        public string NextInspDateFieldName { get; set; }

        [JsonProperty("lastInspDateFieldName")]
        public string LastInspDateFieldName { get; set; }

        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("__v")]
        public int V { get; set; }

        [JsonProperty("lastInspection")]
        public DateTime LastInspection { get; set; }

        [JsonProperty("completion")]
        public Completion Completion { get; set; }

        [JsonProperty("nextInspectionDate")]
        public DateTime NextInspectionDate { get; set; }
    }

    public class RunRange
    {
        [JsonProperty("isNew")]
        public bool IsNew { get; set; }

        [JsonProperty("runParentId")]
        public object RunParentId { get; set; }

        [JsonProperty("id")]
        public object Id { get; set; }
    }

    public class Task
    {
        [JsonProperty("lineCords")]
        public LineCords LineCords { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("desc")]
        public string Desc { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("units")]
        public List<Unit> Units { get; set; }
    }

    public class TestForm
    {
        [JsonProperty("assetId")]
        public string AssetId { get; set; }

        [JsonProperty("assetName")]
        public string AssetName { get; set; }

        [JsonProperty("assetType")]
        public string AssetType { get; set; }

        [JsonProperty("inspectionFormName")]
        public string InspectionFormName { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("testCode")]
        public string TestCode { get; set; }

        [JsonProperty("testId")]
        public string TestId { get; set; }
    }

    public class Unit
    {
        [JsonProperty("unitId")]
        public string UnitId { get; set; }

        [JsonProperty("assetId")]
        public string AssetId { get; set; }

        [JsonProperty("coordinates")]
        public List<object> Coordinates { get; set; }

        [JsonProperty("assetType")]
        public string AssetType { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("parent_id")]
        public string ParentId { get; set; }

        [JsonProperty("locationType")]
        public string LocationType { get; set; }

        [JsonProperty("testForm")]
        public List<TestForm> TestForm { get; set; }

        [JsonProperty("inspection_type")]
        public string InspectionType { get; set; }

        [JsonProperty("inspection_freq")]
        public string InspectionFreq { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class User
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

       
    }





}



