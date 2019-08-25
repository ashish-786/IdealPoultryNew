using System;
using System.Collections.Generic;

namespace IdealPoultryApp.DataModelsPoultry
{
    public partial class TempBreedAvailability
    {
        public decimal BreedId { get; set; }
        public DateTime ShipDate { get; set; }
        public decimal? BreedAvailabilityId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public byte SortOrder { get; set; }
        public byte SrFactor { get; set; }
        public byte PFactor { get; set; }
        public byte MFactor { get; set; }
        public decimal BreedSexableProjected { get; set; }
        public decimal BreedNonsexableProjected { get; set; }
        public decimal BreedSexableSreSold { get; set; }
        public decimal BreedNonsexableSreSold { get; set; }
        public decimal BreedSexableAvailable { get; set; }
        public decimal BreedNonsexableAvailable { get; set; }
        public decimal BreedSrSold { get; set; }
        public decimal BreedPSold { get; set; }
        public decimal BreedMSold { get; set; }
        public decimal BreedInsrcSrSold { get; set; }
        public decimal BreedOutsrcSrSold { get; set; }
        public decimal BreedInsrcPSold { get; set; }
        public decimal BreedOutsrcPSold { get; set; }
        public decimal BreedInsrcMSold { get; set; }
        public decimal BreedOutsrcMSold { get; set; }
        public decimal BreedInsrcSexSreSold { get; set; }
        public decimal BreedOutsrcSexSreSold { get; set; }
        public decimal BreedInsrcNonsexSreSold { get; set; }
        public decimal BreedOutsrcNonsexSreSold { get; set; }
        public decimal AdjBreedSexableAvailable { get; set; }
        public decimal AdjBreedNonsexableAvailable { get; set; }
        public decimal TotalSexableProjected { get; set; }
        public decimal TotalNonsexableProjected { get; set; }
        public decimal TotalSexableSreSold { get; set; }
        public decimal TotalPSold { get; set; }
        public decimal TotalMSold { get; set; }
        public decimal AdjTotalSexableAvail { get; set; }
        public decimal AdjTotalNonsexableAvail { get; set; }
        public decimal BreedSexableAvgEggYield { get; set; }
        public decimal BreedNonsexableAvgEggYield { get; set; }
        public decimal BreedSexableTrayCount { get; set; }
        public decimal BreedNonsexableTrayCount { get; set; }
        public decimal TotalNonsexableSreSold { get; set; }
        public decimal TotalSexableAvailable { get; set; }
        public decimal TotalNonsexableAvailable { get; set; }
        public decimal TotalSrSold { get; set; }
    }
}
