using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace GymWorkoutFormProject
{
    public class Trainer
    {
        private int trainerID;
        private string trainerName;
        private string expertise;
        private double hourlyRate;
        private int numSession;
        public const double provTax = 0.09975;
        public const double fedTax = 0.05;

        public Trainer()
        {
            trainerName = "";
            expertise = "";
        }

        public Trainer(int trainerID, string trainerName, string expertise, double hourlyRate)
        {
            this.trainerID = trainerID;
            this.trainerName = trainerName;
            this.expertise = expertise;
            this.hourlyRate = hourlyRate;
        }

        public int TrainerID
        {
            get { return trainerID; }
            set { trainerID = value; }
        }

        public string TrainerName
        {
            get { return trainerName; }
            set { trainerName = value; }
        }

        public string Expertise
        {
            get { return expertise; }
            set { expertise = value; }
        }

        public double HourlyRate
        {
            get { return hourlyRate; }
            set { hourlyRate = value; }
        }

        public int NumSession
        {
            get { return numSession; }
            set { numSession = value; }
        }

        public double CalculateSubtotal()
        {
            return numSession * hourlyRate;
        }

        public double CalculateProvTax()
        {
            return CalculateSubtotal() * provTax;
        }

        public double CalculateFedTax()
        {
            return CalculateSubtotal() * fedTax;
        }

        public double CalculateTotal()
        {
            return CalculateSubtotal() + CalculateProvTax() + CalculateFedTax();
        }
    }
}