using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace GymWorkoutFormProject
{
    public class Purchase
    {
        private int purchaseID;
        private int memberID;
        private int trainerID;
        private int numSession;
        private double subtotal;
        private double provTax;
        private double fedTax;
        private double total;
        private int month;
        private int year;

        public Purchase()
        {
        }

        public Purchase(int purchaseID, int memberID, int trainerID, int numSession,
                        double subtotal, double provTax, double fedTax, double total, int month, int year)
        {
            this.purchaseID = purchaseID;
            this.memberID = memberID;
            this.trainerID = trainerID;
            this.numSession = numSession;
            this.subtotal = subtotal;
            this.provTax = provTax;
            this.fedTax = fedTax;
            this.total = total;
            this.month = month;
            this.year = year;
        }

        public int PurchaseID
        {
            get { return purchaseID; }
            set { purchaseID = value; }
        }

        public int MemberID
        {
            get { return memberID; }
            set { memberID = value; }
        }

        public int TrainerID
        {
            get { return trainerID; }
            set { trainerID = value; }
        }

        public int NumSession
        {
            get { return numSession; }
            set { numSession = value; }
        }

        public double Subtotal
        {
            get { return subtotal; }
            set { subtotal = value; }
        }

        public double ProvTax
        {
            get { return provTax; }
            set { provTax = value; }
        }

        public double FedTax
        {
            get { return fedTax; }
            set { fedTax = value; }
        }

        public double Total
        {
            get { return total; }
            set { total = value; }
        }

        public int Month
        {
            get { return month; }
            set { month = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }
    }
}