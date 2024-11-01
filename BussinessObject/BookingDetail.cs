﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BussinessObject
{
    public class BookingDetail
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ForeignKey("BookingReservation")]
        public int BookingReservationID { get; set; }
        [ForeignKey("RoomInformation")]
        public int RoomID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Actual price must be a non-negative value.")]
        public decimal? ActualPrice { get; set; }

        [CustomValidation(typeof(BookingDetail), nameof(ValidateDates))]
        public static ValidationResult ValidateDates(BookingDetail detail, ValidationContext context)
        {
            if (detail.StartDate >= detail.EndDate)
            {
                return new ValidationResult("End date must be later than start date.");
            }
            return ValidationResult.Success;
        }
    }
}
